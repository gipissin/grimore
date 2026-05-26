Public Class frm_admin
    Private Sub frm_admin_Load(sender As Object, e As EventArgs) Handles Me.Load
        Conectar_banco()
        Carregar_formadmin()
    End Sub
End Class