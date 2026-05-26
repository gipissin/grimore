Module moduloGrimore
    Public diretorio, SQL, resposta_user, status, tipo_conta As String
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
            With cad_usuario.cmb_tipo.Items
                .Add("User")
                .Add("Admin")
            End With
            cad_usuario.cmb_tipo.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub Carregar_status()
        Try
            With cad_usuario.cmb_status.Items
                .Add("Ativo")
                .Add("Inativo")
                .Add("Suspenso")
            End With
            cad_usuario.cmb_status.SelectedIndex = 0
            If cad_usuario.cmb_status.SelectedIndex = 0 Then
                status = "ATIVO"
            ElseIf cad_usuario.cmb_status.SelectedIndex = 1 Then
                status = "INATIVO"
            ElseIf cad_usuario.cmb_status.SelectedIndex = 2 Then
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
End Module
