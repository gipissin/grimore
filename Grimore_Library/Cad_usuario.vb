Public Class cad_usuario
    Private Sub cad_usuario_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar_banco()
        Carregar_tipo()
        Carregar_status()
    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Try
            'Verificaçao do preenchimento de dados:
            If txt_matricula.Text = "" Or txt_senha.Text = "" Or txt_csenha.Text = "" Or txt_perguntaseg.Text = "" Or txt_nome.Text = "" Then
                MessageBox.Show("Preencha todos os campos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'MATRICULA
            ElseIf txt_matricula.Text.Length > 10 Or txt_matricula.Text.Length < 4 Then
                MessageBox.Show("A matrícula deve conter entre 4 e 10 caracteres, por favor revisar.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_matricula.Clear()
                txt_matricula.Focus()
            ElseIf Not IsNumeric(txt_matricula.Text) Then
                MessageBox.Show("A matrícula deve conter apenas números, por favor revisar.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'SENHA
            ElseIf txt_senha.Text <> txt_csenha.Text Then
                MessageBox.Show("Senhas não coincidem, por favor revisar.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_senha.Clear()
                txt_csenha.Clear()
                txt_senha.Focus()
            ElseIf txt_senha.Text.Length > 8 Or txt_senha.Text.Length < 4 Then
                MessageBox.Show("A senha deve conter entre 4 e 8 caracteres, por favor revisar.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                SQL = $"select * from tb_usuarios where matricula='{txt_matricula.Text}'"
                rs = database.Execute(SQL)
                If rs.EOF = True Then
                    SQL = $"insert into tb_usuarios (matricula, senha, pergunta_seg,status_conta,usuario,tipo_usuario)
                           values ('{txt_matricula.Text}', '{txt_senha.Text}', '{txt_perguntaseg.Text}','{status}','{txt_nome.Text}','{cmb_tipo.Text}')"
                    rs = database.Execute(UCase(SQL))
                    MessageBox.Show("Usuário cadastrado com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim resposta_user As DialogResult = MessageBox.Show("Deseja cadastrar outro usuário?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If resposta_user = DialogResult.Yes Then
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
                    MessageBox.Show("Matrícula já cadastrada, por favor revisar.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txt_matricula.Clear()
                    txt_senha.Clear()
                    txt_csenha.Clear()
                    txt_matricula.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Erro: " & ex.Message, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class