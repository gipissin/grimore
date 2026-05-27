Public Class frm_admin
    Private Sub frm_admin_Load(sender As Object, e As EventArgs) Handles Me.Load
        Conectar_banco()
        Carregar_formadmin()
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
                If .CurrentRow.Cells(6).Selected = True Then
                    aux_matricula = .CurrentRow.Cells(1).Value
                    SQL = $"SELECT * FROM tb_usuarios WHERE matricula = '{aux_matricula}'"
                    rs = database.Execute(SQL)
                    With cad_usuario
                        'matricula, senha, pergunta_seg,status_conta,usuario,tipo_usuario
                        If rs.EOF = False Then
                            .txt_matricula.Text = rs.Fields(0).Value
                            .txt_senha.Text = rs.Fields(1).Value
                            .txt_perguntaseg.Text = rs.Fields(2).Value
                            .cmb_status.Text = rs.Fields(3).Value
                            .txt_nome.Text = rs.Fields(4).Value
                            .cmb_tipo.Text = rs.Fields(5).Value
                            cad_usuario.ShowDialog()
                        End If
                    End With
                ElseIf .CurrentRow.Cells(7).Selected = True Then
                    aux_matricula = .CurrentRow.Cells(1).Value
                    SQL = $"SELECT * FROM tb_usuarios WHERE matricula = '{aux_matricula}'"
                    rs = database.Execute(SQL)
                    With cad_usuario
                        'matricula, senha, pergunta_seg,status_conta,usuario,tipo_usuario
                        If rs.EOF = False Then
                            resposta_user = MsgBox("Gostaria de excluir a matricula: " & aux_matricula & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                            If resposta_user = MsgBoxResult.Yes Then
                                SQL = $"DELETE FROM tb_usuarios WHERE matricula = '{aux_matricula}'"
                                rs = database.Execute(SQL)
                                MessageBox.Show("Usuário excluído com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
End Class