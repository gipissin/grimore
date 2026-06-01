Public Class frm_gerenciarclientes
    Private Sub frm_gerenciarclientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar_banco()
        dgv_clientes.EditMode = DataGridViewEditMode.EditProgrammatically
        Carregar_Clientes("")
    End Sub

    Private Sub txt_clientebusc_TextChanged(sender As Object, e As EventArgs) Handles txt_clientebusc.TextChanged
        Carregar_Clientes(txt_clientebusc.Text)
    End Sub

    Sub Carregar_Clientes(pesquisa As String)
        Try
            If pesquisa = "" Then
                SQL = "SELECT id_cliente, nome, email, telefone, cpf FROM tb_clientes ORDER BY nome ASC"
            Else
                SQL = $"SELECT id_cliente, nome, email, telefone, cpf FROM tb_clientes WHERE nome LIKE '%{pesquisa}%' ORDER BY nome ASC"
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
                        rs.Fields("cpf").Value.ToString()
                    )
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical, "ATENÇÃO")
        End Try
    End Sub

    Private Sub dgv_clientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_clientes.CellClick
        If e.RowIndex < 0 Then Exit Sub
        Try
            Dim id As String = dgv_clientes.Rows(e.RowIndex).Cells("Column1").Value.ToString()
            Dim nome As String = dgv_clientes.Rows(e.RowIndex).Cells("Column2").Value.ToString()

            ' BOTÃO EDITAR — Column6
            If e.ColumnIndex = dgv_clientes.Columns("Column6").Index Then
                dgv_clientes.Rows(e.RowIndex).Cells("Column2").ReadOnly = False ' nome
                dgv_clientes.Rows(e.RowIndex).Cells("Column3").ReadOnly = False ' email
                dgv_clientes.Rows(e.RowIndex).Cells("Column4").ReadOnly = False ' telefone
                dgv_clientes.Rows(e.RowIndex).Cells("Column5").ReadOnly = False ' cpf

                dgv_clientes.CurrentCell = dgv_clientes.Rows(e.RowIndex).Cells("Column2")

                dgv_clientes.BeginEdit(True)
            End If

            ' BOTÃO EXCLUIR — Column7
            If e.ColumnIndex = dgv_clientes.Columns("Column7").Index Then
                If MsgBox($"Deseja excluir o cliente '{nome}'?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ATENÇÃO") = MsgBoxResult.Yes Then
                    SQL = $"DELETE FROM tb_clientes WHERE id_cliente = '{id}'"
                    database.Execute(SQL)
                    MsgBox("Cliente excluído com sucesso!", MsgBoxStyle.Information, "AVISO")
                    Carregar_Clientes("")
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical, "ATENÇÃO")
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
End Class