Module moduloGrimore
    Public diretorio, SQL, resposta_user, status, tipo_conta, aux_matricula, status_user, notacao, etiqueta As String
    Public database As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Sub Conectar_banco()
        Try
            database = CreateObject("ADODB.Connection")
            'database.Open("Provider=SQLOLEDB;Data Source=ALUNO42\SQLEXPRESS;Initial Catalog=projeto_grimore;Trusted_Connection=yes;")
            database.Open("Provider=MSOLEDBSQL;Data Source=localhost;Initial Catalog=projeto_grimore;Trusted_Connection=yes;")
            MsgBox("Conexão OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Sub Carregar_tipo()
        Try
            With frm_cadusuario.cmb_tipo.Items
                .Add("User")
                .Add("Admin")
            End With
            frm_cadusuario.cmb_tipo.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub Carregar_status()
        Try
            With frm_cadusuario.cmb_status.Items
                .Add("Ativo")
                .Add("Inativo")
                .Add("Suspenso")
            End With
            frm_cadusuario.cmb_status.SelectedIndex = 0
            If frm_cadusuario.cmb_status.SelectedIndex = 0 Then
                status = "ATIVO"
            ElseIf frm_cadusuario.cmb_status.SelectedIndex = 1 Then
                status = "INATIVO"
            ElseIf frm_cadusuario.cmb_status.SelectedIndex = 2 Then
                status = "SUSPENSO"
            End If
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Sub Carregar_formadmin()
        Try
            Dim col As DataGridViewComboBoxColumn = CType(frm_admin.dgv_admin.Columns("Column6"), DataGridViewComboBoxColumn)
            If col.Items.Count = 0 Then
                col.Items.AddRange("ATIVO", "INATIVO", "SUSPENSO")
            End If

            SQL = $"SELECT * FROM tb_usuarios order by usuario asc"
            rs = database.Execute(SQL)
            With frm_admin.dgv_admin
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(
                        rs.Fields(4).Value.ToString(),
                        rs.Fields(0).Value.ToString(),
                        rs.Fields(1).Value.ToString(),
                        rs.Fields(2).Value.ToString(),
                        rs.Fields(5).Value.ToString().ToUpper(),
                        rs.Fields(3).Value.ToString(),
                        Nothing,
                        Nothing
                    )
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical, "ATENÇÃO")
        End Try
    End Sub

    Sub Carregar_formacervo()
        Try
            SQL = $"SELECT * FROM tb_livros"
            rs = database.Execute(SQL)
            With frm_acervo.dgv_acervo
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(
                        rs.Fields(0).Value.ToString(), 'titulo
                        rs.Fields(1).Value.ToString(), 'autor
                        rs.Fields(2).Value.ToString(), 'editora
                        rs.Fields(4).Value.ToString(), 'isbn
                        rs.Fields(5).Value.ToString(), 'quantidade
                        rs.Fields(8).Value.ToString(), 'etiqueta
                        Nothing, 'editar
                        Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical, "ATENÇÃO")
        End Try
    End Sub

    Sub Funcionalidade_admin()
        Try
            With login_principal
                SQL = $"SELECT * FROM tb_usuarios WHERE usuario = '{ .txt_usuario.Text}'"
                rs = database.Execute(SQL)

                If rs.EOF = False Then
                    tipo_conta = rs.Fields(5).Value.ToString()
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Function Permissoes_acesso(status As String) As Boolean
        Try
            If status = "INATIVO" Then
                MsgBox("Sua conta está inativa, entre em contato com o administrador para mais informações.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Return False
            ElseIf status = "SUSPENSO" Then
                MsgBox("Sua conta está suspensa, entre em contato com o administrador para mais informações.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Function

    Sub Limpar_campos()
        Try
            With frm_cadusuario
                .txt_nome.Clear()
                .txt_csenha.Clear()
                .txt_matricula.Clear()
                .txt_senha.Clear()
                .txt_perguntaseg.Clear()
                .cmb_tipo.SelectedIndex = 0
                .cmb_status.SelectedIndex = 0
            End With
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Function Separar_letras(texto As String)
        Dim primeira_letra As String = ""
        primeira_letra = texto.Substring(0, 1)
        Return primeira_letra
    End Function
    Function Separar_letrasArea(texto As String)
        Dim letras As String = ""
        letras = texto.Substring(0, 3)
        Return letras
    End Function
    Function Montar_etiqueta(area As String, autor As String, titulo As String, pha As String) As String
        Dim area_pha As String = Separar_letrasArea(area)
        Dim autor_pha As String = Separar_letras(autor)
        Dim titulo_pha As String = Separar_letras(titulo)

        notacao = autor_pha & pha & titulo_pha

        Return area_pha & Environment.NewLine & notacao
    End Function

    Sub Carregar_generos()
        Try
            With frm_cadacervo.cmb_area.Items
                .Add("Artes")
                .Add("Biografias")
                .Add("Ciências Exatas")
                .Add("Ciências Humanas")
                .Add("Ciências Naturais")
                .Add("Contos e Crônicas")
                .Add("Didáticos")
                .Add("Esportes")
                .Add("Fantasia")
                .Add("Ficção Científica")
                .Add("História")
                .Add("Infantojuvenil")
                .Add("Literatura Brasileira")
                .Add("Literatura Estrangeira")
                .Add("Mangás e Quadrinhos")
                .Add("Religião e Espiritualidade")
            End With
            frm_cadacervo.cmb_area.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Module
