Public Class frm_situacaocliente
    Private Sub frm_devolucao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar_banco()
        ' Preenche com o cliente do frm_emprestimo se existir
        If frm_emprestimo.txt_idcliente.Text <> "" Then
            txt_idcliente.Text = frm_emprestimo.txt_idcliente.Text
            txt_nomecliente.Text = frm_emprestimo.txt_nomecliente.Text
        End If
    End Sub

    ' Ao sair do campo ID busca o cliente
    Private Sub txt_idcliente_LostFocus(sender As Object, e As EventArgs) Handles txt_idcliente.LostFocus
        If txt_idcliente.Text = "" Then
            txt_nomecliente.Clear()
            Exit Sub
        End If
        Try
            SQL = $"SELECT * FROM tb_clientes WHERE id_cliente = '{txt_idcliente.Text}'"
            rs = database.Execute(SQL)
            If rs.EOF = False Then
                txt_nomecliente.Text = rs.Fields("nome").Value.ToString()
            Else
                MsgBox("Cliente não encontrado.", MsgBoxStyle.Exclamation, "ATENÇÃO")
                txt_idcliente.Clear()
                txt_nomecliente.Clear()
                txt_idcliente.Focus()
            End If
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_livrosemposse_Click(sender As Object, e As EventArgs) Handles btn_livrosemposse.Click
        If txt_idcliente.Text = "" Then
            MsgBox("Informe o ID do cliente primeiro.", MsgBoxStyle.Exclamation, "ATENÇÃO")
            Exit Sub
        End If
        Me.Hide()
        frm_pendentes.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btn_historico_Click(sender As Object, e As EventArgs) Handles btn_historico.Click
        If txt_idcliente.Text = "" Then
            MsgBox("Informe o ID do cliente primeiro.", MsgBoxStyle.Exclamation, "ATENÇÃO")
            Exit Sub
        End If
        Me.Hide()
        frm_historico.ShowDialog()
        Me.Show()
    End Sub

    Private Sub ts_menu_Click(sender As Object, e As EventArgs) Handles ts_menu.Click
        Me.Close()
    End Sub

    Private Sub ts_emprestimo_Click(sender As Object, e As EventArgs) Handles ts_emprestimo.Click
        frm_emprestimo.Show()
        Me.Hide()
    End Sub
End Class