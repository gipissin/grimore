Imports System.Security.Cryptography

Public Class frm_cadclientes
    Private Sub frm_cadcliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar_banco()
        Carregar_preferencias()
    End Sub

    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione a foto do cliente"
                .Filter = "Imagens|*.jpg;*.png;*.jpeg"
                .ShowDialog()
                diretorio = .FileName
                img_foto.Load(diretorio)
            End With
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Try
            If txt_nome.Text = "" Or txt_cpf.Text = "" Then
                MsgBox("Preencha os campos obrigatórios.", MsgBoxStyle.Exclamation, "ATENÇÃO")
                Exit Sub
            End If

            ' Verifica se CPF já existe
            SQL = $"SELECT * FROM tb_clientes WHERE cpf = '{txt_cpf.Text}'"
            rs = database.Execute(SQL)

            If rs.EOF = True Then
                ' id gerado automatico
                SQL = $"INSERT INTO tb_clientes (nome, email, telefone, cpf, data_nascimento, preferencias, observacoes, foto)
                        VALUES ('{txt_nome.Text}', '{txt_email.Text}', '{txt_telefone.Text}',
                                '{txt_cpf.Text}', '{dtp_nascimento.Value.ToString("yyyy-MM-dd")}',
                                '{cmb_preferencias.Text}', '{txt_observacoes.Text}', '{diretorio}')"
                rs = database.Execute(SQL)
                MsgBox("Cliente cadastrado com sucesso!", MsgBoxStyle.Information, "AVISO")
                Limpar_cadcliente()
            Else
                MsgBox("CPF já cadastrado!", MsgBoxStyle.Exclamation, "ATENÇÃO")
                Limpar_cadcliente()
            End If
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical, "ATENÇÃO")
        End Try
    End Sub

    Sub Limpar_cadcliente()
        txt_nome.Clear()
        txt_email.Clear()
        txt_telefone.Clear()
        txt_cpf.Clear()
        txt_observacoes.Clear()
        cmb_preferencias.SelectedIndex = 0
        img_foto.Image = Nothing
        diretorio = ""
    End Sub

    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        frm_menu.Show()
        Me.Hide()
    End Sub
End Class