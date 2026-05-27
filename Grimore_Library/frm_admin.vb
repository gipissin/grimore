Public Class frm_admin
    Private Sub frm_admin_Load(sender As Object, e As EventArgs) Handles Me.Load
        Conectar_banco()
        Carregar_formadmin()
        dgv_admin.ReadOnly = False
        dgv_admin.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2
        Panel1.Visible = False
        Panel2.Visible = False

    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Try
            SQL = $"SELECT * FROM tb_usuarios where matricula like '%{txt_matriculabusc.Text}%' order by usuario asc"
            rs = database.Execute(SQL)
            With dgv_admin
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(
                        rs.Fields(4).Value.ToString(),
                        rs.Fields(0).Value.ToString(),
                        rs.Fields(1).Value.ToString(),
                        rs.Fields(2).Value.ToString(),
                        rs.Fields(5).Value.ToString().ToUpper(),
                        rs.Fields(3).Value.ToString(),
                        Nothing,
                        Nothing
                    )
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical, "ATENÇÃO")
        End Try
    End Sub
    Private Sub dgv_admin_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_admin.CellContentClick
        Try
            With dgv_admin

                If .CurrentRow.Cells(7).Selected = True Then
                    aux_matricula = .CurrentRow.Cells(1).Value
                    SQL = $"SELECT * FROM tb_usuarios WHERE matricula = '{aux_matricula}'"
                    rs = database.Execute(SQL)
                    With frm_cadusuario
                        'matricula, senha, pergunta_seg,status_conta,usuario,tipo_usuario
                        If rs.EOF = False Then
                            resposta_user = MsgBox("Gostaria de excluir a matricula: " & aux_matricula & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                            If resposta_user = MsgBoxResult.Yes Then
                                SQL = $"DELETE FROM tb_usuarios WHERE matricula = '{aux_matricula}'"
                                rs = database.Execute(SQL)
                                Panel2.Visible = False
                                Carregar_formadmin()
                            End If
                        End If
                    End With
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical, "ATENÇÃO")
        End Try
    End Sub

    Private Sub dgv_admin_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_admin.CellEndEdit
        If e.RowIndex < 0 Then Exit Sub
        Dim nome_coluna_matricula As String = "Column2"
        If dgv_admin.Rows(e.RowIndex).Cells(nome_coluna_matricula).Value Is Nothing Then Exit Sub
        aux_matricula = dgv_admin.Rows(e.RowIndex).Cells("Column2").Value.ToString()
        Dim novo_valor As String = dgv_admin.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()

        Dim nome_coluna_editada As String = dgv_admin.Columns(e.ColumnIndex).Name
        Dim coluna_banco As String = ""

        Select Case nome_coluna_editada
            Case "Column1"
                coluna_banco = "usuario"
            Case "Column3"
                coluna_banco = "senha"
            Case "Column4"
                coluna_banco = "pergunta_seg"
            Case "Column5"
                coluna_banco = "tipo_usuario"
            Case "Column6"
                coluna_banco = "status_conta"
        End Select

        If coluna_banco <> "" Then
            Try
                SQL = $"UPDATE tb_usuarios SET {coluna_banco} = '{novo_valor}' WHERE matricula = '{aux_matricula}'"
                rs = database.Execute(SQL)
                Panel1.Visible = True
            Catch ex As Exception
                MsgBox("Erro ao salvar alteração: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            End Try
        End If
    End Sub
End Class