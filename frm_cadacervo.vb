Public Class frm_cadacervo
    Private Sub frm_cadacervo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar_banco()
        Carregar_generos()
        txt_notacao.Enabled = False
        txt_etiqueta.Enabled = False
    End Sub
    Private Sub img_capa_Click(sender As Object, e As EventArgs) Handles img_capa.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione a capa do livro"
                .InitialDirectory = Application.StartupPath & "\Fotos\capas"
                .ShowDialog()
                diretorio = .FileName
                img_capa.Load(diretorio)
            End With
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Try
            'Validação dos campos
            If txt_autor.Text = "" Or
            txt_titulo.Text = "" Or
            txt_pha.Text = "" Or
            txt_isbn.Text = "" Or
            cmb_area.Text = "" Or
            diretorio = "" Then
                MsgBox("Por favor, preencha todos os campos obrigatórios.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub

                'validacao do pha
            ElseIf Not IsNumeric(txt_pha.Text) Then
                MsgBox("O campo PHA deve conter apenas números.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            Else
                SQL = $"SELECT * FROM tb_livros where isbn='{txt_isbn.Text}'"
                rs = database.Execute(SQL)

                If rs.EOF = True Then
                    'titulo, autor, editora, area, isbn, quantidade, cod_pha, notacao, etiqueta, foto
                    SQL = $"INSERT INTO tb_livros (titulo, autor, editora, area, isbn, quantidade, cod_pha, notacao, etiqueta, foto) VALUES ('{txt_titulo.Text}', '{txt_autor.Text}', '{txt_editora.Text}', '{cmb_area.Text}', '{txt_isbn.Text}', '{txt_quantidade.Text}', '{txt_pha.Text}', '{txt_notacao.Text}', '{txt_etiqueta.Text}', '{diretorio}')"
                    rs = database.Execute(UCase(SQL))
                    MsgBox("Livro cadastrado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    Limpar_campos()
                Else
                    SQL = $"UPDATE tb_livros SET autor='{txt_autor.Text}', titulo='{txt_titulo.Text}', pha='{txt_pha.Text}', area='{cmb_area.Text}', capa='{diretorio}', etiqueta='{txt_etiqueta.Text}', notacao='{txt_notacao.Text}' WHERE isbn='{txt_isbn.Text}'"
                    rs = database.Execute(UCase(SQL))
                    MsgBox("Livro atualizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    Limpar_campos()
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txt_pha_LostFocus(sender As Object, e As EventArgs) Handles txt_pha.LostFocus
        txt_etiqueta.Text = Montar_etiqueta(cmb_area.Text, txt_autor.Text, txt_titulo.Text, txt_pha.Text)
        txt_notacao.Text = notacao
    End Sub

    Private Sub ACERVOCOMPLETOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACERVOCOMPLETOToolStripMenuItem.Click

    End Sub
End Class