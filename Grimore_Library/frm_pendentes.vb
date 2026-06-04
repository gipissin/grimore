Public Class frm_pendentes
    Private Sub frm_pendentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carregar_Pendentes(frm_situacaocliente.txt_idcliente.Text)
    End Sub

    Sub Carregar_Pendentes(id_cliente As String)
        Try
            If id_cliente = "" Then
                SQL = "SELECT e.id_emprestimo, e.isbn, e.titulo, e.data_devolucao, e.qtd_renovacoes, c.nome
                       FROM tb_emprestimos e
                       INNER JOIN tb_clientes c ON e.id_cliente = c.id_cliente
                       WHERE e.devolvido = 0
                       ORDER BY c.nome ASC"
            Else
                SQL = $"SELECT e.id_emprestimo, e.isbn, e.titulo, e.data_devolucao, e.qtd_renovacoes, c.nome
                        FROM tb_emprestimos e
                        INNER JOIN tb_clientes c ON e.id_cliente = c.id_cliente
                        WHERE e.devolvido = 0 AND e.id_cliente = '{id_cliente}'
                        ORDER BY c.nome ASC"
            End If

            rs = database.Execute(SQL)

            With dgv_pendentes
                .Rows.Clear()
                Do While rs.EOF = False
                    Dim novaLinha As Integer = .Rows.Add()
                    .Rows(novaLinha).Cells("Column1").Value = rs.Fields("id_emprestimo").Value.ToString()
                    .Rows(novaLinha).Cells("Column2").Value = rs.Fields("isbn").Value.ToString()
                    .Rows(novaLinha).Cells("Column3").Value = rs.Fields("titulo").Value.ToString()
                    .Rows(novaLinha).Cells("Column4").Value = CDate(rs.Fields("data_devolucao").Value).ToShortDateString()
                    .Rows(novaLinha).Cells("Column5").Value = rs.Fields("qtd_renovacoes").Value.ToString()
                    .Rows(novaLinha).Cells("Column6").Value = "DEVOLVER"
                    .Rows(novaLinha).Cells("Column7").Value = "RENOVAR"
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar pendências: " & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
    End Sub

    Private Sub dgv_pendentes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pendentes.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        Try
            Dim idEmprestimo As Integer = Convert.ToInt32(dgv_pendentes.Rows(e.RowIndex).Cells("Column1").Value)
            Dim isbnLivro As String = dgv_pendentes.Rows(e.RowIndex).Cells("Column2").Value.ToString()
            Dim nomeLivro As String = dgv_pendentes.Rows(e.RowIndex).Cells("Column3").Value.ToString()

            ' BOTÃO DEVOLVER — Column6
            If e.ColumnIndex = dgv_pendentes.Columns("Column6").Index Then
                If MsgBox($"Confirmar devolução de '{nomeLivro}'?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "DEVOLUÇÃO") = MsgBoxResult.Yes Then
                    SQL = $"SELECT quantidade FROM tb_emprestimos WHERE id_emprestimo = {idEmprestimo}"
                    rs = database.Execute(SQL)
                    Dim qtd As Integer = CInt(rs.Fields("quantidade").Value)

                    SQL = $"UPDATE tb_emprestimos SET devolvido = 1, data_devolucao_real = '{DateTime.Now.ToString("yyyy-MM-dd")}' WHERE id_emprestimo = {idEmprestimo}"
                    database.Execute(SQL)

                    SQL = $"UPDATE tb_livros SET quantidade = quantidade + {qtd} WHERE isbn = '{isbnLivro}'"
                    database.Execute(SQL)

                    MsgBox("Livro devolvido com sucesso!", MsgBoxStyle.Information, "AVISO")
                    Carregar_Pendentes(frm_situacaocliente.txt_idcliente.Text)
                End If
            End If

            ' BOTÃO RENOVAR — Column7
            If e.ColumnIndex = dgv_pendentes.Columns("Column7").Index Then
                If MsgBox($"Renovar o prazo de '{nomeLivro}' por mais 7 dias?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "RENOVAÇÃO") = MsgBoxResult.Yes Then
                    Dim dataAtual As DateTime = Convert.ToDateTime(dgv_pendentes.Rows(e.RowIndex).Cells("Column4").Value)
                    Dim novaData As String = dataAtual.AddDays(7).ToString("yyyy-MM-dd")

                    SQL = $"UPDATE tb_emprestimos SET data_devolucao = '{novaData}', qtd_renovacoes = qtd_renovacoes + 1 WHERE id_emprestimo = {idEmprestimo}"
                    database.Execute(SQL)

                    MsgBox($"Prazo renovado! Nova data: {dataAtual.AddDays(7).ToShortDateString()}", MsgBoxStyle.Information, "AVISO")
                    Carregar_Pendentes(frm_situacaocliente.txt_idcliente.Text)
                End If
            End If

        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
    End Sub


    Private Sub btn_voltar_Click(sender As Object, e As EventArgs)
        frm_situacaocliente.Show
        Hide
    End Sub

    Private Sub ts_menu_Click(sender As Object, e As EventArgs) Handles ts_menu.Click
        frm_menu.Show()
        Me.Hide()
    End Sub

    Private Sub ts_geranciaruser_Click(sender As Object, e As EventArgs) Handles ts_geranciaruser.Click
        frm_situacaocliente.Show()
        Me.Hide()
    End Sub
End Class