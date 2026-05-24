Public Class cad_usuario
    Private Sub cad_usuario_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar_banco()
    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Try
            'Verificaçao do preenchimento de dados:
            If txt_matricula.Text = "" Or txt_senha.Text = "" Or txt_csenha.Text = "" Or txt_perguntaseg.Text = "" Then
                MsgBox("Preencha todos os campos", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                'MATRICULA
            ElseIf txt_matricula.Text.Length > 10 Or txt_matricula.Text.Length < 4 Then
                MsgBox("A matrícula deve conter entre 4 e 10 caracteres, por favor revisar.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                txt_matricula.Clear()
                txt_matricula.Focus()
            ElseIf Not IsNumeric(txt_matricula.Text) Then
                MsgBox("A matrícula deve conter apenas números, por favor revisar.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                'SENHA
            ElseIf txt_senha.Text <> txt_csenha.Text Then
                MsgBox("Senhas não coincidem, por favor revisar.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                txt_senha.Clear()
                txt_csenha.Clear()
                txt_senha.Focus()
            ElseIf txt_senha.Text.Length > 8 Or txt_senha.Text.Length < 4 Then
                MsgBox("A senha deve conter entre 4 e 8 caracteres, por favor revisar.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            Else
                SQL = $"select * from tb_usuarios where matricula='{txt_matricula.Text}'"
                rs = database.Execute(SQL)
                If rs.EOF = True Then
                    SQL = $"insert into tb_usuarios (matricula, senha, pergunta_seg)
                           values ('{txt_matricula.Text}', '{txt_senha.Text}', '{txt_perguntaseg.Text}')"
                    rs = database.Execute(UCase(SQL))
                    MsgBox("Usuário cadastrado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    resposta_user = MsgBox("Deseja cadastrar outro usuário?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO")
                    If resposta_user = vbYes Then
                        txt_matricula.Clear()
                        txt_senha.Clear()
                        txt_csenha.Clear()
                        txt_perguntaseg.Clear()
                        txt_matricula.Focus()
                    Else
                        Me.Close()
                        Menu.Show()
                    End If
                Else
                    MsgBox("Matrícula já cadastrada, por favor revisar.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                    txt_matricula.Clear()
                    txt_senha.Clear()
                    txt_csenha.Clear()
                    txt_matricula.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class