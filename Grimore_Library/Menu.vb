Public Class Menu
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

End Class