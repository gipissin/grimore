Public Class frm_alterarsenha
    Private Sub Alterar_Senha_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar_banco()
        txt_senha.Enabled = False
        txt_senha.BackColor = Color.LightGray
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        Try
            If txt_senha.Text.Length > 8 Or txt_senha.Text.Length < 4 Then
                MsgBox("A senha deve conter entre 4 e 8 caracteres, por favor revisar.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            Else
                SQL = $"update tb_usuarios set senha = '{txt_senha.Text}' where matricula = '{txt_matricula.Text}'"
                rs = database.Execute(UCase(SQL))
                MsgBox("Senha alterada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Me.Close()
                login_principal.Show()
            End If
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Private Sub btn_verificar_Click(sender As Object, e As EventArgs) Handles btn_verificar.Click
        Try
            SQL = $"select * from tb_usuarios where matricula = '{txt_matricula.Text}'"
            rs = database.Execute(UCase(SQL))
            If rs.EOF = True Then
                MsgBox("Matrícula não encontrada, tente novamente.")
                txt_matricula.Clear()
                txt_perguntaseg.Clear()
                Exit Sub
            End If
            If txt_perguntaseg.Text <> rs.Fields("pergunta_seg").Value Then
                MsgBox("Resposta de segurança incorreta, tente novamente.")
                txt_perguntaseg.Clear()
            Else
                txt_senha.Enabled = True
                txt_senha.BackColor = Color.White
            End If
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        frm_menu.Show()
    End Sub
End Class