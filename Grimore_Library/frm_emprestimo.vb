Public Class frm_emprestimo
    Private ofd As New OpenFileDialog()
    Private Sub frm_emprestimo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carregar_generos()
        Conectar_banco()
        ' devolução em 7 dias
        dtp_emprestimo.Value = DateTime.Now
        dtp_devolucao.Value = DateTime.Now.AddDays(7)
        txt_qtdestoque.Enabled = False
        txt_titulo.Enabled = False
        txt_etiqueta.Enabled = False
        cmb_area.Enabled = False
    End Sub

    Private Sub txt_idcliente_LostFocus(sender As Object, e As EventArgs) Handles txt_idcliente.LostFocus
        If txt_idcliente.Text <> "" Then Buscar_cliente_Emprestimo(txt_idcliente.Text)
    End Sub

    Private Sub txt_isbn_LostFocus(sender As Object, e As EventArgs) Handles txt_isbn.LostFocus
        Try
            If txt_isbn.Text = "" Then Exit Sub
            SQL = $"SELECT titulo, etiqueta, area, quantidade FROM tb_livros WHERE isbn = '{txt_isbn.Text}'"
            rs = database.Execute(SQL)

            If rs.EOF = False Then
                txt_titulo.Text = rs.Fields("titulo").Value.ToString()
                txt_etiqueta.Text = rs.Fields("etiqueta").Value.ToString()
                cmb_area.Text = rs.Fields("area").Value.ToString()
                txt_qtdestoque.Text = rs.Fields("quantidade").Value.ToString()
            Else
                MsgBox("Livro não encontrado.", MsgBoxStyle.Exclamation, "ATENÇÃO")
                txt_isbn.Clear() : txt_isbn.Focus()
            End If
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_emprestimo_Click(sender As Object, e As EventArgs) Handles btn_emprestimo.Click
        Try
            If txt_idcliente.Text = "" Or txt_isbn.Text = "" Or txt_qtdemprestimo.Text = "" Then
                MsgBox("Preencha todos os campos para prosseguir.", MsgBoxStyle.Exclamation, "ATENÇÃO")
                Exit Sub
            End If

            If Not IsNumeric(txt_qtdemprestimo.Text) Or CInt(txt_qtdemprestimo.Text) <= 0 Then
                MsgBox("A quantidade deve ser um número maior que zero.", MsgBoxStyle.Exclamation, "ATENÇÃO")
                Exit Sub
            End If

            Dim qtd_solicitada As Integer = CInt(txt_qtdemprestimo.Text)
            Dim estoque As Integer = CInt(txt_qtdestoque.Text)

            If qtd_solicitada > estoque Then
                MsgBox($"Estoque insuficiente! Disponível: {estoque}", MsgBoxStyle.Exclamation, "ATENÇÃO")
                Exit Sub
            End If

            ' Insere o empréstimo
            SQL = $"INSERT INTO tb_emprestimos (id_cliente, isbn, titulo, data_emprestimo, data_devolucao, devolvido, quantidade)
                VALUES ('{txt_idcliente.Text}', '{txt_isbn.Text}', '{txt_titulo.Text}',
                        '{dtp_emprestimo.Value.ToString("yyyy-MM-dd")}',
                        '{dtp_devolucao.Value.ToString("yyyy-MM-dd")}', 0, {qtd_solicitada})"
            database.Execute(SQL)

            ' Desconta do acervo
            SQL = $"UPDATE tb_livros SET quantidade = quantidade - {qtd_solicitada} WHERE isbn = '{txt_isbn.Text}'"
            database.Execute(SQL)

            MsgBox("Empréstimo registrado com sucesso!", MsgBoxStyle.Information, "AVISO")
            Limpar_tudo()
        Catch ex As Exception
            MsgBox("Erro ao gravar: " & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
    End Sub

    Private Sub btn_devolucao_Click(sender As Object, e As EventArgs)
        If txt_idcliente.Text = "" Then
            MsgBox("Informe o ID do cliente primeiro.", MsgBoxStyle.Exclamation, "ATENÇÃO")
            Exit Sub
        End If
        frm_situacaocliente.ShowDialog()
    End Sub

    Private Sub btn_menu_Click(sender As Object, e As EventArgs)
        frm_menu.Show : Hide
    End Sub

    Sub Limpar_tudo()
        txt_idcliente.Clear() : txt_nomecliente.Clear() : txt_titulo.Clear() : txt_isbn.Clear()
        txt_etiqueta.Clear() : txt_qtdestoque.Clear() : txt_qtdemprestimo.Clear() : cmb_area.Text = ""
        dtp_emprestimo.Value = DateTime.Now : dtp_devolucao.Value = DateTime.Now.AddDays(7)
    End Sub

    Private Sub ts_pendencias_Click(sender As Object, e As EventArgs) Handles ts_pendencias.Click
        frm_situacaocliente.Show()
        Hide()
    End Sub

    Private Sub ts_menu_Click(sender As Object, e As EventArgs) Handles ts_menu.Click
        frm_menu.Show()
        Hide()
    End Sub

    Private Sub ts_acervo_Click(sender As Object, e As EventArgs) Handles ts_acervo.Click
        frm_acervo.Show()
    End Sub

    Private Sub CLIENTESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CLIENTESToolStripMenuItem.Click
        frm_gerenciarclientes.Show()
    End Sub
End Class