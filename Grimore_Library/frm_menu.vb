Public Class frm_menu
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If tipo_conta = "ADMIN" Then
            btn_admcontas.Visible = True
        Else
            btn_admcontas.Visible = False
        End If
    End Sub
    Private Sub btn_admcontas_Click(sender As Object, e As EventArgs) Handles btn_admcontas.Click
        frm_admin.Show()
    End Sub

    Private Sub btn_acervo_Click(sender As Object, e As EventArgs) Handles btn_acervo.Click
        frm_cadacervo.Show()
    End Sub

    Private Sub btn_cadclientes_Click(sender As Object, e As EventArgs) Handles btn_cadclientes.Click
        frm_cadclientes.Show()
    End Sub

    Private Sub btn_senha_Click(sender As Object, e As EventArgs) Handles btn_senha.Click
        frm_alterarsenha.Show()
    End Sub
End Class