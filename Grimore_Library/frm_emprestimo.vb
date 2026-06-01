Public Class frm_emprestimo
    Private ofd As New OpenFileDialog()
    Private Sub frm_emprestimo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carregar_generos()
        Conectar_banco()
        ' devolução em 7 dias
        dtp_emprestimo.Value = DateTime.Now
        dtp_devolucao.Value = DateTime.Now.AddDays(7)
    End Sub

    'ID busca o cliente automaticamente
    Private Sub txt_idcliente_LostFocus(sender As Object, e As EventArgs) Handles txt_idcliente.LostFocus
        If txt_idcliente.Text <> "" Then
            Buscar_cliente(txt_idcliente.Text)
        End If
    End Sub

    ' Botão EMPRÉSTIMO — registra e desconta do acervo
    Private Sub btn_emprestimo_Click(sender As Object, e As EventArgs) Handles btn_emprestimo.Click
        Try
            If txt_idcliente.Text = "" Or txt_isbn.Text = "" Or txt_qtdemprestimo.Text = "" Then
                MsgBox("Preencha todos os campos.", MsgBoxStyle.Exclamation, "ATENÇÃO")
                Exit Sub
            End If

            If Not IsNumeric(txt_qtdemprestimo.Text) Then
                MsgBox("Quantidade inválida.", MsgBoxStyle.Exclamation, "ATENÇÃO")
                Exit Sub
            End If

            Dim qtd_solicitada As Integer = CInt(txt_qtdemprestimo.Text)

            ' Busca estoque DIRETO do banco, não do campo na tela
            SQL = $"SELECT quantidade FROM tb_livros WHERE isbn = '{txt_isbn.Text}'"
            rs = database.Execute(SQL)

            If rs.EOF = True Then
                MsgBox("Livro não encontrado!", MsgBoxStyle.Exclamation, "ATENÇÃO")
                Exit Sub
            End If

            Dim estoque As Integer = CInt(rs.Fields("quantidade").Value)

            ' Valida se tem estoque suficiente
            If qtd_solicitada > estoque Then
                MsgBox($"Quantidade indisponível! Estoque atual: {estoque}", MsgBoxStyle.Exclamation, "ATENÇÃO")
                Exit Sub
            End If

            ' Verifica se já tem empréstimo ativo
            SQL = $"SELECT * FROM tb_emprestimos WHERE id_cliente = '{txt_idcliente.Text}' AND devolvido = 0"
            rs = database.Execute(SQL)
            If rs.EOF = False Then
                MsgBox("Cliente já possui um livro emprestado!", MsgBoxStyle.Exclamation, "ATENÇÃO")
                Exit Sub
            End If

            ' Registra empréstimo com a quantidade solicitada
            SQL = $"INSERT INTO tb_emprestimos (id_cliente, isbn, titulo, data_emprestimo, data_devolucao, devolvido, quantidade)
                VALUES ('{txt_idcliente.Text}', '{txt_isbn.Text}', '{txt_titulo.Text}',
                        '{dtp_emprestimo.Value.ToString("yyyy-MM-dd")}',
                        '{dtp_devolucao.Value.ToString("yyyy-MM-dd")}', 0, {qtd_solicitada})"
            database.Execute(SQL)

            ' Desconta a quantidade solicitada do acervo
            SQL = $"UPDATE tb_livros SET quantidade = quantidade - {qtd_solicitada} WHERE isbn = '{txt_isbn.Text}'"
            database.Execute(SQL)

            MsgBox("Empréstimo registrado com sucesso!", MsgBoxStyle.Information, "AVISO")
            Limpar_emprestimo()

        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical, "ATENÇÃO")
        End Try
    End Sub

    ' Botão DEVOLUÇÃO — devolve e soma no acervo
    Private Sub btn_devolucao_Click(sender As Object, e As EventArgs) Handles btn_devolucao.Click
        Try
            If txt_idcliente.Text = "" Then
                MsgBox("Informe o ID do cliente.", MsgBoxStyle.Exclamation, "ATENÇÃO")
                Exit Sub
            End If

            ' Busca o empréstimo ativo E a quantidade emprestada
            SQL = $"SELECT isbn, quantidade FROM tb_emprestimos 
                WHERE id_cliente = '{txt_idcliente.Text}' AND devolvido = 0"
            rs = database.Execute(SQL)

            If rs.EOF = True Then
                MsgBox("Nenhum empréstimo ativo para este cliente.", MsgBoxStyle.Exclamation, "ATENÇÃO")
                Exit Sub
            End If

            Dim isbn_devolvido As String = rs.Fields("isbn").Value.ToString()
            Dim qtd_devolvida As Integer = CInt(rs.Fields("quantidade").Value) ' ← pega a quantidade do banco

            ' Marca como devolvido
            SQL = $"UPDATE tb_emprestimos SET devolvido = 1 
                WHERE id_cliente = '{txt_idcliente.Text}' AND devolvido = 0"
            database.Execute(SQL)

            ' Devolve a quantidade correta ao acervo
            SQL = $"UPDATE tb_livros SET quantidade = quantidade + {qtd_devolvida} 
                WHERE isbn = '{isbn_devolvido}'"
            database.Execute(SQL)

            MsgBox($"Devolução de {qtd_devolvida} livro(s) registrada com sucesso!", MsgBoxStyle.Information, "AVISO")
            Limpar_emprestimo()

        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical, "ATENÇÃO")
        End Try
    End Sub

    ' Botão DADOS DO CLIENTE — verifica prazo de devolução
    Private Sub btn_dadoscliente_Click(sender As Object, e As EventArgs) Handles btn_dadoscliente.Click
        Try
            If txt_idcliente.Text = "" Then
                MsgBox("Informe o ID do cliente.", MsgBoxStyle.Exclamation, "ATENÇÃO")
                Exit Sub
            End If

            SQL = $"SELECT * FROM tb_emprestimos WHERE id_cliente = '{txt_idcliente.Text}' AND devolvido = 0"
            rs = database.Execute(SQL)

            If rs.EOF = False Then
                Dim data_dev As Date = CDate(rs.Fields("data_devolucao").Value)
                Dim hoje As Date = DateTime.Now.Date
                Dim amanha As Date = hoje.AddDays(1)

                If data_dev.Date = amanha Then
                    MsgBox("ÚLTIMO DIA PARA DEVOLUÇÃO!", MsgBoxStyle.Exclamation, "ATENÇÃO")
                ElseIf data_dev.Date < hoje Then
                    Dim dias_atraso As Integer = (hoje - data_dev.Date).Days
                    MsgBox($"Livro em ATRASO há {dias_atraso} dia(s)!", MsgBoxStyle.Critical, "ATENÇÃO")
                Else
                    Dim dias_restantes As Integer = (data_dev.Date - hoje).Days
                    MsgBox($"Devolução em {dias_restantes} dia(s) — {data_dev.ToString("dd/MM/yyyy")}", MsgBoxStyle.Information, "AVISO")
                End If
            Else
                MsgBox("Cliente sem empréstimo ativo.", MsgBoxStyle.Information, "AVISO")
            End If
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical, "ATENÇÃO")
        End Try
    End Sub

    Sub Limpar_emprestimo()
        txt_idcliente.Clear()
        txt_nomecliente.Clear()
        txt_titulo.Clear()
        txt_isbn.Clear()
        txt_etiqueta.Clear()
        txt_qtdestoque.Clear()
        txt_qtdemprestimo.Clear()
        cmb_area.Text = ""
        dtp_emprestimo.Value = DateTime.Now
        dtp_devolucao.Value = DateTime.Now.AddDays(7)
    End Sub

    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        frm_menu.Show()
        Me.Hide()
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
                txt_qtdestoque.Text = rs.Fields("quantidade").Value.ToString() ' ← adicione
            Else
                MsgBox("Livro não encontrado.", MsgBoxStyle.Exclamation, "ATENÇÃO")
                txt_isbn.Clear()
                txt_isbn.Focus()
            End If
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical, "ATENÇÃO")
        End Try
    End Sub


End Class