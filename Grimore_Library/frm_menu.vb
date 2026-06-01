Public Class frm_menu
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If tipo_conta = "ADMIN" Then
            btn_admcontas.Visible = True
        Else
            btn_admcontas.Visible = False
        End If
    End Sub
    Private Sub btn_admcontas_Click(sender As Object, e As EventArgs) Handles btn_admcontas.Click
        frm_menuadmin.Show
        Hide
    End Sub

    Private Sub btn_acervo_Click(sender As Object, e As EventArgs) Handles btn_acervo.Click
        frm_cadacervo.Show()
        Me.Hide()
    End Sub

    Private Sub btn_cadclientes_Click(sender As Object, e As EventArgs) Handles btn_cadclientes.Click
        frm_cadclientes.Show()
        Me.Hide()
    End Sub

    Private Sub btn_senha_Click(sender As Object, e As EventArgs) Handles btn_senha.Click
        frm_alterarsenha.Show()
        Me.Hide()
    End Sub

    Private Sub btn_emprestimo_Click(sender As Object, e As EventArgs) Handles btn_emprestimo.Click
        frm_emprestimo.Show()
        Me.Hide()
    End Sub

    Private Sub btn_devolucao_Click(sender As Object, e As EventArgs)
        frm_emprestimo.Show
        Hide
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Dim resposta As MsgBoxResult = MsgBox("Deseja realmente sair da sua conta?",
                                          MsgBoxStyle.Question + MsgBoxStyle.YesNo,
                                          "LOGOUT")

        If resposta = MsgBoxResult.Yes Then
            Dim telaLogin As New login_principal()

            telaLogin.Show()

            Me.Close()
        End If
    End Sub
End Class