Public Class frm_menuadmin
    Private Sub btn_cadusuario_Click(sender As Object, e As EventArgs) Handles btn_cadusuario.Click
        frm_cadusuario.ShowDialog()
        Me.Hide()
    End Sub
    Private Sub btn_gerusuario_Click(sender As Object, e As EventArgs) Handles btn_gerusuario.Click
        frm_admin.ShowDialog()
        Me.Hide()
    End Sub
    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        frm_menu.Show()
        Me.Hide()
    End Sub
End Class