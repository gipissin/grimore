<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_situacaocliente
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_situacaocliente))
        MenuStrip2 = New MenuStrip()
        ts_menu = New ToolStripMenuItem()
        txt_nomecliente = New TextBox()
        txt_idcliente = New TextBox()
        Label7 = New Label()
        Label3 = New Label()
        btn_livrosemposse = New Button()
        btn_historico = New Button()
        ts_emprestimo = New ToolStripMenuItem()
        MenuStrip2.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip2
        ' 
        MenuStrip2.BackColor = Color.MediumPurple
        MenuStrip2.ImageScalingSize = New Size(20, 20)
        MenuStrip2.Items.AddRange(New ToolStripItem() {ts_menu, ts_emprestimo})
        MenuStrip2.Location = New Point(0, 0)
        MenuStrip2.Name = "MenuStrip2"
        MenuStrip2.Padding = New Padding(5, 2, 0, 2)
        MenuStrip2.Size = New Size(877, 24)
        MenuStrip2.TabIndex = 31
        MenuStrip2.Text = "MenuStrip2"
        ' 
        ' ts_menu
        ' 
        ts_menu.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ts_menu.ForeColor = Color.White
        ts_menu.Name = "ts_menu"
        ts_menu.Size = New Size(58, 20)
        ts_menu.Text = "MENU"
        ' 
        ' txt_nomecliente
        ' 
        txt_nomecliente.BackColor = Color.Gainsboro
        txt_nomecliente.Location = New Point(27, 78)
        txt_nomecliente.Name = "txt_nomecliente"
        txt_nomecliente.Size = New Size(256, 23)
        txt_nomecliente.TabIndex = 35
        ' 
        ' txt_idcliente
        ' 
        txt_idcliente.BackColor = Color.Gainsboro
        txt_idcliente.Location = New Point(321, 78)
        txt_idcliente.Name = "txt_idcliente"
        txt_idcliente.Size = New Size(147, 23)
        txt_idcliente.TabIndex = 34
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.MediumPurple
        Label7.Font = New Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(321, 42)
        Label7.Name = "Label7"
        Label7.Size = New Size(132, 21)
        Label7.TabIndex = 33
        Label7.Text = "ID do cliente"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.MediumPurple
        Label3.Font = New Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(27, 42)
        Label3.Name = "Label3"
        Label3.Size = New Size(164, 21)
        Label3.TabIndex = 32
        Label3.Text = "Nome do cliente"
        ' 
        ' btn_livrosemposse
        ' 
        btn_livrosemposse.BackColor = Color.MediumPurple
        btn_livrosemposse.Font = New Font("Cooper Black", 14.25F)
        btn_livrosemposse.ForeColor = Color.White
        btn_livrosemposse.Location = New Point(27, 138)
        btn_livrosemposse.Name = "btn_livrosemposse"
        btn_livrosemposse.Size = New Size(345, 68)
        btn_livrosemposse.TabIndex = 36
        btn_livrosemposse.Text = "LIVROS EM POSSE DO CLIENTE (PENDENTES)"
        btn_livrosemposse.UseVisualStyleBackColor = False
        ' 
        ' btn_historico
        ' 
        btn_historico.BackColor = Color.MediumPurple
        btn_historico.Font = New Font("Cooper Black", 14.25F)
        btn_historico.ForeColor = Color.White
        btn_historico.Location = New Point(428, 138)
        btn_historico.Name = "btn_historico"
        btn_historico.Size = New Size(345, 68)
        btn_historico.TabIndex = 37
        btn_historico.Text = "HISTÓRICO DE EMPRÉSTIMOS ANTERIORES"
        btn_historico.UseVisualStyleBackColor = False
        ' 
        ' ts_emprestimo
        ' 
        ts_emprestimo.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ts_emprestimo.ForeColor = Color.White
        ts_emprestimo.Name = "ts_emprestimo"
        ts_emprestimo.Size = New Size(104, 20)
        ts_emprestimo.Text = "EMPRESTIMO"
        ' 
        ' frm_situacaocliente
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(877, 506)
        Controls.Add(btn_historico)
        Controls.Add(btn_livrosemposse)
        Controls.Add(txt_nomecliente)
        Controls.Add(txt_idcliente)
        Controls.Add(Label7)
        Controls.Add(Label3)
        Controls.Add(MenuStrip2)
        Name = "frm_situacaocliente"
        Text = "SITUAÇÃO DO CLIENTE"
        MenuStrip2.ResumeLayout(False)
        MenuStrip2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ts_menu As ToolStripMenuItem
    Friend WithEvents txt_nomecliente As TextBox
    Friend WithEvents txt_idcliente As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_livrosemposse As Button
    Friend WithEvents btn_historico As Button
    Friend WithEvents ts_emprestimo As ToolStripMenuItem
End Class
