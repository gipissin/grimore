Public Class login_principal
    Private Sub login_principal_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar_banco()
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Try
            SQL = $"select * from tb_usuarios where matricula='{txt_matricula.Text}'"
            rs = database.Execute(SQL)
            If rs.EOF = False Then
                If txt_senha.Text = rs.Fields(1).Value Then
                    MessageBox.Show("Bem Vindo " + rs.Fields(0).Value)
                    Me.Hide()
                    Menu.Show()
                Else
                    MsgBox("Login invalido! Tente novamente", MsgBoxStyle.Critical, "Erro")
                End If
            Else
                MsgBox("Login invalido! Tente novamente", MsgBoxStyle.Critical, "Erro")
            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro ao tentar realizar o login: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub
End Class