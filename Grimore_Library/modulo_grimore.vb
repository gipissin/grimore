Module modulo_grimore
    Public diretorio, SQL, resposta_user As String
    Public database As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Sub Conectar_banco()
        Try
            database = CreateObject("ADODB.Connection")
            database.Open("Provider=MSOLEDBSQL;Data Source=localhost;Initial Catalog=projeto_grimore;Trusted_Connection=yes;")
            MsgBox("Conexão OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Module
