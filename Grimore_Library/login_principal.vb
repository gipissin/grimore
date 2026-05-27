Public Class login_principal
    Private Sub login_principal_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar_banco()
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Try
            txt_usuario.Text = txt_usuario.Text.ToUpper
            txt_senha.Text = txt_senha.Text.ToUpper
            SQL = $"select * from tb_usuarios where usuario='{txt_usuario.Text}'"
            rs = database.Execute(SQL)
            If rs.EOF = False Then
                status_user = rs.Fields(3).Value
                If txt_senha.Text = rs.Fields(1).Value Then
                    If Permissoes_acesso(status_user) = True Then
                        MessageBox.Show("BEM VINDO " + rs.Fields(4).Value)
                        Funcionalidade_admin()
                        Hide()
                        frm_menu.Show()
                    End If
                Else
                    MsgBox("Senha incorreta, tente novamente!", MsgBoxStyle.Critical, "Erro")
                End If
            Else
                MsgBox("Usuario não localizado, contate seu administrador!", MsgBoxStyle.Critical, "Erro")
            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro ao tentar realizar o login: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

    Private Sub btn_verificar_Click(sender As Object, e As EventArgs) Handles btn_verificar.Click
        If txt_senha.PasswordChar = "•"c Then
            txt_senha.PasswordChar = Nothing
        Else
            txt_senha.PasswordChar = "•"c
        End If
    End Sub

    Private Sub btn_resetsenha_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btn_resetsenha.LinkClicked
        Me.Hide()
        frm_alterarsenha.Show()
    End Sub
End Class