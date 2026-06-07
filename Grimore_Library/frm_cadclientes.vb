Imports System.Security.Cryptography

Public Class frm_cadclientes
    Private Sub frm_cadcliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = login_principal.Icon
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
            status_cliente = "ATIVO"
            SQL = $"SELECT * FROM tb_clientes WHERE cpf='{txt_cpf.Text}'"
            rs = database.Execute(SQL)
            If rs.EOF = True Then
                SQL = $"INSERT INTO tb_clientes (nome, email, telefone, cpf, data_nascimento, preferencias, observacoes, foto, status_cliente)
                        VALUES ('{txt_nome.Text}', '{txt_email.Text}', '{txt_telefone.Text}',
                                '{txt_cpf.Text}', '{dtp_nascimento.Value.ToString("yyyy-MM-dd")}',
                                '{cmb_preferencias.Text}', '{txt_observacoes.Text}', '{diretorio}', '{status_cliente}')"
                database.Execute(SQL)
                MsgBox("Cliente cadastrado com sucesso!", MsgBoxStyle.Information, "AVISO")
                resposta_user = MsgBox("Deseja cadastrar outro cliente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO")
                If resposta_user = vbYes Then
                    Limpar_cadcliente()
                    Exit Sub
                Else
                    Limpar_cadcliente()
                    frm_gerenciarclientes.Show()
                    Me.Hide()
                End If
            Else
                MsgBox("CPF já cadastrado!", MsgBoxStyle.Exclamation, "ATENÇÃO")
                Exit Sub
            End If
            Limpar_cadcliente()
            frm_gerenciarclientes.Carregar_Clientes("")
            frm_gerenciarclientes.Show()
            Me.Hide()

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
    Private Sub ts_menu_Click(sender As Object, e As EventArgs) Handles ts_menu.Click
        frm_menu.Show()
        Me.Hide()
    End Sub

    Private Sub ts_gerenciarclientes_Click(sender As Object, e As EventArgs) Handles ts_gerenciarclientes.Click
        frm_gerenciarclientes.Show()
        Me.Hide()
    End Sub
End Class