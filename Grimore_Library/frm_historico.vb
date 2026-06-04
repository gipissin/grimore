Public Class frm_historico
    Private Sub frm_historico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carregar_Historico(frm_situacaocliente.txt_idcliente.Text)
    End Sub

    Sub Carregar_Historico(id_cliente As String)
        Try
            SQL = $"SELECT id_emprestimo, isbn, titulo, data_emprestimo, data_devolucao, data_devolucao_real, devolvido
                FROM tb_emprestimos
                WHERE id_cliente = '{id_cliente}' AND devolvido = 1
                ORDER BY data_devolucao DESC"
            rs = database.Execute(SQL)

            With dgv_historico
                .Rows.Clear()
                Do While rs.EOF = False
                    ' Verifica se data_devolucao_real é NULL
                    Dim data_real As String = ""
                    If Not IsDBNull(rs.Fields("data_devolucao_real").Value) Then
                        data_real = CDate(rs.Fields("data_devolucao_real").Value).ToShortDateString()
                    Else
                        data_real = "Não registrada"
                    End If

                    .Rows.Add(
                    rs.Fields("id_emprestimo").Value.ToString(),
                    rs.Fields("isbn").Value.ToString(),
                    rs.Fields("titulo").Value.ToString(),
                    CDate(rs.Fields("data_emprestimo").Value).ToShortDateString(),
                    CDate(rs.Fields("data_devolucao").Value).ToShortDateString(),
                    data_real,
                    If(rs.Fields("devolvido").Value = True, "DEVOLVIDO", "PENDENTE")
                )
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar histórico: " & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs)
        frm_situacaocliente.Show
        Hide
    End Sub

    Private Sub ts_menu_Click(sender As Object, e As EventArgs) Handles ts_menu.Click
            frm_menu.Show()
            Me.Hide()
        End Sub

        Private Sub ts_geranciaruser_Click(sender As Object, e As EventArgs) Handles ts_geranciaruser.Click
            frm_situacaocliente.Show()
            Me.Hide()
        End Sub
    End Class
