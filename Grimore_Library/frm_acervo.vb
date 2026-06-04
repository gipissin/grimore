Public Class frm_acervo

    Private Sub frm_acervo_Load(sender As Object, e As EventArgs) Handles Me.Load
        Conectar_banco()
        Carregar_formacervo()

        dgv_acervo.ReadOnly = False
        dgv_acervo.EditMode = DataGridViewEditMode.EditOnEnter
    End Sub
    Private Sub txt_livrobusc_TextChanged(sender As Object, e As EventArgs) Handles txt_livrobusc.TextChanged
        Carregar_Acervo(txt_livrobusc.Text)
    End Sub

    Sub Carregar_Acervo(pesquisa As String)
        Try
            If pesquisa = "" Then
                SQL = "SELECT titulo, autor, editora, isbn, quantidade, etiqueta FROM tb_livros ORDER BY titulo ASC"
            Else
                SQL = $"SELECT titulo, autor, editora, isbn, quantidade, etiqueta FROM tb_livros WHERE titulo LIKE '%{pesquisa}%' ORDER BY titulo ASC"
            End If

            rs = database.Execute(SQL)

            With dgv_acervo
                .Rows.Clear()

                Do While rs.EOF = False
                    .Rows.Add(
                        rs.Fields(0).Value.ToString(),
                        rs.Fields(1).Value.ToString(),
                        rs.Fields(2).Value.ToString(),
                        rs.Fields(3).Value.ToString(),
                        rs.Fields(4).Value.ToString(),
                        rs.Fields(5).Value.ToString(),
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
    Private Sub dgv_acervo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_acervo.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        Try
            If e.ColumnIndex = 6 Then

                dgv_acervo.EndEdit()

                Dim aux_isbn As String = dgv_acervo.Rows(e.RowIndex).Cells("Column4").Value.ToString()

                Dim novo_titulo As String = dgv_acervo.Rows(e.RowIndex).Cells("Column1").Value.ToString()
                Dim novo_autor As String = dgv_acervo.Rows(e.RowIndex).Cells("Column2").Value.ToString()
                Dim nova_editora As String = dgv_acervo.Rows(e.RowIndex).Cells("Column3").Value.ToString()
                Dim nova_qtd As String = dgv_acervo.Rows(e.RowIndex).Cells("Column8").Value.ToString()

                Dim nova_etiqueta As String = dgv_acervo.Rows(e.RowIndex).Cells("Column5").Value.ToString()

                Dim resposta As MsgBoxResult = MsgBox("Deseja salvar as alterações feitas no livro: " & novo_titulo & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CONFIRMAÇÃO")

                If resposta = MsgBoxResult.Yes Then
                    SQL = $"UPDATE tb_livros SET " &
                          $"titulo = '{novo_titulo}', " &
                          $"autor = '{novo_autor}', " &
                          $"editora = '{nova_editora}', " &
                          $"quantidade = '{nova_qtd}', " &
                          $"etiqueta = '{nova_etiqueta}' " &
                          $"WHERE isbn = '{aux_isbn}'"

                    database.Execute(SQL)

                    MsgBox("Livro atualizado com sucesso no banco de dados!", MsgBoxStyle.Information, "SUCESSO")

                    Carregar_formacervo()
                End If
            End If

            If e.ColumnIndex = 7 Then
                Dim auxiliar_isbn As String = dgv_acervo.Rows(e.RowIndex).Cells("Column4").Value.ToString()

                SQL = $"SELECT * FROM tb_livros WHERE isbn = '{auxiliar_isbn}'"
                rs = database.Execute(SQL)

                If rs.EOF = False Then
                    Dim resposta_user As MsgBoxResult = MsgBox("Gostaria de excluir definitivamente o livro: " & dgv_acervo.Rows(e.RowIndex).Cells("Column1").Value.ToString() & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resposta_user = MsgBoxResult.Yes Then
                        SQL = $"DELETE FROM tb_livros WHERE isbn = '{auxiliar_isbn}'"
                        rs = database.Execute(SQL)
                        Carregar_formacervo()
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox("Erro na operação: " & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
    End Sub

    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        frm_menu.Show()
        Me.Hide()
    End Sub

    Private Sub btn_buscaracervo_Click(sender As Object, e As EventArgs)
        Try
            SQL = $"SELECT * FROM tb_livros where titulo like '%{txt_livrobusc.Text}%' order by titulo asc"
            rs = database.Execute(SQL)
            With dgv_acervo
                .Rows.Clear
                Do While rs.EOF = False
                    .Rows.Add(
                        rs.Fields(0).Value.ToString,
                        rs.Fields(1).Value.ToString,
                        rs.Fields(2).Value.ToString,
                        Nothing,
                        rs.Fields(4).Value.ToString,
                        rs.Fields(5).Value.ToString.ToUpper,
                        Nothing,
                        Nothing,
                        rs.Fields(8).Value.ToString,
                        Nothing,
                        Nothing,
                        Nothing
                    )
                    rs.MoveNext
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical, "ATENÇÃO")
        End Try
    End Sub

    Private Sub ts_menu_Click(sender As Object, e As EventArgs) Handles ts_menu.Click
        frm_menu.Show()
        Me.Hide()
    End Sub

    Private Sub ts_cadastroacervo_Click(sender As Object, e As EventArgs) Handles ts_cadastroacervo.Click
        frm_cadacervo.Show()
        Me.Hide()
    End Sub
End Class