Public Class frm_gerenciarclientes
    Private Sub frm_gerenciarclientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = login_principal.Icon
        Conectar_banco()
        dgv_clientes.ReadOnly = False
        dgv_clientes.EditMode = DataGridViewEditMode.EditOnEnter
        Carregar_Clientes("")
    End Sub

    Private Sub txt_clientebusc_TextChanged(sender As Object, e As EventArgs) Handles txt_clientebusc.TextChanged
        Carregar_Clientes(txt_clientebusc.Text)
    End Sub

    Sub Carregar_Clientes(pesquisa As String)
        Try
            Dim col As DataGridViewComboBoxColumn = CType(Me.dgv_clientes.Columns("Column7"), DataGridViewComboBoxColumn)
            If col.Items.Count = 0 Then
                col.Items.AddRange("ATIVO", "INATIVO")
            End If

            If pesquisa = "" Then
                SQL = "SELECT id_cliente, nome, email, telefone, cpf, status_cliente FROM tb_clientes ORDER BY nome ASC"
            Else
                SQL = $"SELECT id_cliente, nome, email, telefone, cpf, status_cliente FROM tb_clientes WHERE nome LIKE '%{pesquisa}%' ORDER BY nome ASC"
            End If

            rs = database.Execute(SQL)

            With dgv_clientes
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(
                        rs.Fields("id_cliente").Value.ToString(),
                        rs.Fields("nome").Value.ToString(),
                        rs.Fields("email").Value.ToString(),
                        rs.Fields("telefone").Value.ToString(),
                        rs.Fields("cpf").Value.ToString(),
                        rs.Fields("status_cliente").Value.ToString(),
                        Nothing
                    )
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical, "ATENÇÃO")
        End Try
    End Sub

    Private Sub dgv_clientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_clientes.CellContentClick
        If e.RowIndex < 0 Then Exit Sub
        Try
            Dim auxiliar_id As String = dgv_clientes.Rows(e.RowIndex).Cells("Column1").Value.ToString()
            Dim nome_cliente As String = dgv_clientes.Rows(e.RowIndex).Cells("Column2").Value.ToString()

            If dgv_clientes.Columns(e.ColumnIndex).Name = "Column6" Then

                dgv_clientes.EndEdit()

                Dim novo_email As String = dgv_clientes.Rows(e.RowIndex).Cells("Column3").Value.ToString()
                Dim nova_telefone As String = dgv_clientes.Rows(e.RowIndex).Cells("Column4").Value.ToString()
                Dim novo_cpf As String = dgv_clientes.Rows(e.RowIndex).Cells("Column5").Value.ToString()
                Dim novo_status As String = dgv_clientes.Rows(e.RowIndex).Cells("Column7").Value.ToString()

                If novo_status = "INATIVO" Then
                    SQL = $"SELECT * FROM tb_emprestimos WHERE id_cliente = '{auxiliar_id}' AND devolvido = 0 AND isbn IS NOT NULL AND isbn <> ''"
                    rs = database.Execute(SQL)
                    If rs.EOF = False Then
                        MsgBox("Não é possível inativar o cliente, pois ele possui empréstimos em aberto!", MsgBoxStyle.Exclamation, "AVISO")
                        Carregar_Clientes("")
                        Exit Sub
                    End If
                End If

                Dim resposta As MsgBoxResult = MsgBox("Deseja salvar as alterações feitas no cliente: " & nome_cliente & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CONFIRMAÇÃO")

                If resposta = MsgBoxResult.Yes Then
                    SQL = $"UPDATE tb_clientes SET " &
                      $"nome = '{nome_cliente}', " &
                      $"email = '{novo_email}', " &
                      $"telefone = '{nova_telefone}', " &
                      $"cpf = '{novo_cpf}', " &
                      $"status_cliente = '{novo_status}' " &
                      $"WHERE id_cliente = '{auxiliar_id}'"

                    database.Execute(SQL)
                    MsgBox("Cliente atualizado com sucesso!", MsgBoxStyle.Information, "SUCESSO")
                    Carregar_Clientes("")
                End If

            ElseIf dgv_clientes.Columns(e.ColumnIndex).Name = "Column7" Then

                Dim status_atual As String = dgv_clientes.Rows(e.RowIndex).Cells("Column7").Value.ToString()
                Dim resposta_user = MsgBox("Gostaria de alterar o status do cliente: " & nome_cliente & " para " & status_atual & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")

                If resposta_user = MsgBoxResult.Yes Then

                    ' TRAVA DE SEGURANÇA AO MUDAR O STATUS!
                    If status_atual = "INATIVO" Then
                        SQL = $"SELECT * FROM tb_emprestimos WHERE id_cliente = '{auxiliar_id}' AND isbn IS NOT NULL AND isbn <> ''"
                        rs = database.Execute(SQL)
                        If rs.EOF = False Then
                            MsgBox("Não é possível inativar o cliente, pois ele possui empréstimos em aberto!", MsgBoxStyle.Exclamation, "AVISO")
                            Carregar_Clientes("")
                            Exit Sub
                        End If
                    End If

                    SQL = $"UPDATE tb_clientes SET status_cliente = '{status_atual}' WHERE id_cliente = '{auxiliar_id}'"
                    database.Execute(SQL)
                    MsgBox("Status do cliente atualizado com sucesso!", MsgBoxStyle.Information, "SUCESSO")
                    Carregar_Clientes("")
                Else
                    Carregar_Clientes("")
                End If
            End If

        Catch ex As Exception
            MsgBox("Erro na operação: " & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
    End Sub

    Private Sub dgv_clientes_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_clientes.CellEndEdit
        If e.RowIndex < 0 Then Exit Sub

        Dim id As String = dgv_clientes.Rows(e.RowIndex).Cells("Column1").Value.ToString()
        Dim novo_valor As String = dgv_clientes.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
        Dim nome_coluna As String = dgv_clientes.Columns(e.ColumnIndex).Name
        Dim coluna_banco As String = ""

        Select Case nome_coluna
            Case "Column2" : coluna_banco = "nome"
            Case "Column3" : coluna_banco = "email"
            Case "Column4" : coluna_banco = "telefone"
            Case "Column5" : coluna_banco = "cpf"
        End Select

        If coluna_banco <> "" Then
            Try
                SQL = $"UPDATE tb_clientes SET {coluna_banco} = '{novo_valor}' WHERE id_cliente = '{id}'"
                database.Execute(SQL)

                ' Bloqueia a célula novamente após salvar
                dgv_clientes.Rows(e.RowIndex).Cells(e.ColumnIndex).ReadOnly = True
            Catch ex As Exception
                MsgBox("Erro ao salvar: " & ex.Message, MsgBoxStyle.Critical, "ERRO")
            End Try
        End If
    End Sub

    Private Sub btn_cadastrarcliente_Click(sender As Object, e As EventArgs) Handles btn_cadastrarcliente.Click
        frm_cadclientes.Show()
        Me.Hide()
    End Sub

    Private Sub ts_menu_Click(sender As Object, e As EventArgs) Handles ts_menu.Click
        frm_menu.Show()
        Me.Hide()
    End Sub


End Class