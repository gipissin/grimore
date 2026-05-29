Public Class frm_acervo
    Private Sub frm_acervo_Load(sender As Object, e As EventArgs) Handles Me.Load
        Conectar_banco()
        Carregar_formacervo()
    End Sub

    Private Sub dgv_acervo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_acervo.CellContentClick
        Try
            With dgv_acervo
                If .CurrentRow.Cells(7).Selected = True Then
                    Dim auxiliar_isbn As String = .CurrentRow.Cells(3).Value
                    SQL = $"SELECT * FROM tb_livros WHERE isbn = '{auxiliar_isbn}'"
                    rs = database.Execute(SQL)
                    If rs.EOF = False Then
                        resposta_user = MsgBox("Gostaria de excluir o livro: " & .CurrentRow.Cells(0).Value & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                        If resposta_user = MsgBoxResult.Yes Then
                            SQL = $"DELETE FROM tb_livros WHERE isbn = '{auxiliar_isbn}'"
                            rs = database.Execute(SQL)
                            Carregar_formacervo()
                        End If
                    End If
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical, "ATENÇÃO")
        End Try
    End Sub

    Private Sub dgv_acervo_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_acervo.CellEndEdit
        If e.RowIndex < 0 Then Exit Sub
        Dim nome_coluna_isbn As String = "Column6"

        If dgv_acervo.Rows(e.RowIndex).Cells(nome_coluna_isbn).Value Is Nothing Then Exit Sub

        Dim aux_isbn As String = dgv_acervo.Rows(e.RowIndex).Cells(nome_coluna_isbn).Value.ToString()
        Dim novo_valor As String = dgv_acervo.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()

        Dim nome_coluna_editada As String = dgv_acervo.Columns(e.ColumnIndex).Name
        Dim coluna_banco As String = ""

        Select Case nome_coluna_editada
            Case "Column1"
                coluna_banco = "titulo"
            Case "Column2"
                coluna_banco = "autor"
            Case "Column3"
                coluna_banco = "editora"
            Case "Column5"
                coluna_banco = "etiqueta"
        End Select

        If coluna_banco <> "" Then
            Try
                SQL = $"UPDATE tb_livros SET {coluna_banco} = '{novo_valor}' WHERE isbn = '{aux_isbn}'"
                rs = database.Execute(SQL)
            Catch ex As Exception
                MsgBox("Erro ao salvar alteração: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            End Try
        End If
    End Sub
End Class