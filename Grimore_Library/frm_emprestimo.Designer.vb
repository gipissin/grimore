<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_emprestimo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_emprestimo))
        Panel1 = New Panel()
        Label11 = New Label()
        txt_qtdemprestimo = New TextBox()
        txt_qtdestoque = New TextBox()
        Label10 = New Label()
        cmb_area = New ComboBox()
        Label9 = New Label()
        Panel2 = New Panel()
        Label8 = New Label()
        txt_nomecliente = New TextBox()
        txt_idcliente = New TextBox()
        txt_etiqueta = New TextBox()
        txt_titulo = New TextBox()
        txt_isbn = New TextBox()
        btn_emprestimo = New Button()
        dtp_emprestimo = New DateTimePicker()
        dtp_devolucao = New DateTimePicker()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        MenuStrip2 = New MenuStrip()
        ts_menu = New ToolStripMenuItem()
        ts_acervo = New ToolStripMenuItem()
        ts_pendencias = New ToolStripMenuItem()
        CLIENTESToolStripMenuItem = New ToolStripMenuItem()
        PictureBox2 = New PictureBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        MenuStrip2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(txt_qtdemprestimo)
        Panel1.Controls.Add(txt_qtdestoque)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(cmb_area)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(txt_nomecliente)
        Panel1.Controls.Add(txt_idcliente)
        Panel1.Controls.Add(txt_etiqueta)
        Panel1.Controls.Add(txt_titulo)
        Panel1.Controls.Add(txt_isbn)
        Panel1.Controls.Add(btn_emprestimo)
        Panel1.Controls.Add(dtp_emprestimo)
        Panel1.Controls.Add(dtp_devolucao)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(30, 68)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(837, 589)
        Panel1.TabIndex = 1
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.MediumPurple
        Label11.Font = New Font("Cooper Black", 14.25F)
        Label11.ForeColor = Color.White
        Label11.Location = New Point(322, 374)
        Label11.Name = "Label11"
        Label11.Size = New Size(218, 21)
        Label11.TabIndex = 39
        Label11.Text = "Quantidade escolhida"
        ' 
        ' txt_qtdemprestimo
        ' 
        txt_qtdemprestimo.BackColor = Color.Gainsboro
        txt_qtdemprestimo.Location = New Point(354, 414)
        txt_qtdemprestimo.Name = "txt_qtdemprestimo"
        txt_qtdemprestimo.Size = New Size(147, 23)
        txt_qtdemprestimo.TabIndex = 38
        ' 
        ' txt_qtdestoque
        ' 
        txt_qtdestoque.BackColor = Color.Gainsboro
        txt_qtdestoque.Location = New Point(610, 416)
        txt_qtdestoque.Name = "txt_qtdestoque"
        txt_qtdestoque.ReadOnly = True
        txt_qtdestoque.Size = New Size(147, 23)
        txt_qtdestoque.TabIndex = 37
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.MediumPurple
        Label10.Font = New Font("Cooper Black", 14.25F)
        Label10.ForeColor = Color.White
        Label10.Location = New Point(565, 374)
        Label10.Name = "Label10"
        Label10.Size = New Size(235, 21)
        Label10.TabIndex = 36
        Label10.Text = "Quantidade em estoque"
        ' 
        ' cmb_area
        ' 
        cmb_area.BackColor = Color.Gainsboro
        cmb_area.Font = New Font("Courier New", 9.75F, FontStyle.Bold)
        cmb_area.FormattingEnabled = True
        cmb_area.Location = New Point(73, 408)
        cmb_area.Name = "cmb_area"
        cmb_area.Size = New Size(162, 24)
        cmb_area.TabIndex = 34
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.MediumPurple
        Label9.Font = New Font("Cooper Black", 14.25F)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(73, 374)
        Label9.Name = "Label9"
        Label9.Size = New Size(225, 21)
        Label9.TabIndex = 35
        Label9.Text = "Area do conhecimento"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.MediumPurple
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Label8)
        Panel2.Location = New Point(163, 20)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(499, 44)
        Panel2.TabIndex = 16
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(146, 3)
        Label8.Name = "Label8"
        Label8.Size = New Size(195, 34)
        Label8.TabIndex = 17
        Label8.Text = "Empréstimo"
        ' 
        ' txt_nomecliente
        ' 
        txt_nomecliente.BackColor = Color.Gainsboro
        txt_nomecliente.Location = New Point(322, 151)
        txt_nomecliente.Name = "txt_nomecliente"
        txt_nomecliente.Size = New Size(256, 23)
        txt_nomecliente.TabIndex = 15
        ' 
        ' txt_idcliente
        ' 
        txt_idcliente.BackColor = Color.Gainsboro
        txt_idcliente.Location = New Point(73, 151)
        txt_idcliente.Name = "txt_idcliente"
        txt_idcliente.Size = New Size(147, 23)
        txt_idcliente.TabIndex = 14
        ' 
        ' txt_etiqueta
        ' 
        txt_etiqueta.BackColor = Color.Gainsboro
        txt_etiqueta.Location = New Point(382, 262)
        txt_etiqueta.Multiline = True
        txt_etiqueta.Name = "txt_etiqueta"
        txt_etiqueta.Size = New Size(102, 85)
        txt_etiqueta.TabIndex = 13
        txt_etiqueta.TextAlign = HorizontalAlignment.Center
        ' 
        ' txt_titulo
        ' 
        txt_titulo.BackColor = Color.Gainsboro
        txt_titulo.Location = New Point(73, 324)
        txt_titulo.Name = "txt_titulo"
        txt_titulo.Size = New Size(256, 23)
        txt_titulo.TabIndex = 12
        ' 
        ' txt_isbn
        ' 
        txt_isbn.BackColor = Color.Gainsboro
        txt_isbn.Location = New Point(73, 237)
        txt_isbn.Name = "txt_isbn"
        txt_isbn.Size = New Size(256, 23)
        txt_isbn.TabIndex = 11
        ' 
        ' btn_emprestimo
        ' 
        btn_emprestimo.BackColor = Color.MediumPurple
        btn_emprestimo.Font = New Font("Cooper Black", 14.25F)
        btn_emprestimo.Location = New Point(610, 476)
        btn_emprestimo.Name = "btn_emprestimo"
        btn_emprestimo.Size = New Size(166, 68)
        btn_emprestimo.TabIndex = 9
        btn_emprestimo.Text = "Empréstimo"
        btn_emprestimo.UseVisualStyleBackColor = False
        ' 
        ' dtp_emprestimo
        ' 
        dtp_emprestimo.CalendarFont = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtp_emprestimo.CalendarMonthBackground = Color.White
        dtp_emprestimo.Font = New Font("Cooper Black", 14.25F)
        dtp_emprestimo.Format = DateTimePickerFormat.Short
        dtp_emprestimo.Location = New Point(73, 507)
        dtp_emprestimo.Name = "dtp_emprestimo"
        dtp_emprestimo.Size = New Size(166, 29)
        dtp_emprestimo.TabIndex = 8
        ' 
        ' dtp_devolucao
        ' 
        dtp_devolucao.Font = New Font("Cooper Black", 14.25F)
        dtp_devolucao.Format = DateTimePickerFormat.Short
        dtp_devolucao.Location = New Point(321, 507)
        dtp_devolucao.Name = "dtp_devolucao"
        dtp_devolucao.Size = New Size(159, 29)
        dtp_devolucao.TabIndex = 7
        dtp_devolucao.Value = New Date(2026, 5, 30, 0, 0, 0, 0)
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.MediumPurple
        Label7.Font = New Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(73, 115)
        Label7.Name = "Label7"
        Label7.Size = New Size(132, 21)
        Label7.TabIndex = 6
        Label7.Text = "ID do cliente"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.MediumPurple
        Label6.Font = New Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(382, 224)
        Label6.Name = "Label6"
        Label6.Size = New Size(94, 21)
        Label6.TabIndex = 5
        Label6.Text = "Etiqueta"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.MediumPurple
        Label5.Font = New Font("Cooper Black", 14.25F)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(321, 467)
        Label5.Name = "Label5"
        Label5.Size = New Size(185, 21)
        Label5.TabIndex = 4
        Label5.Text = "Data de devolução"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.MediumPurple
        Label4.Font = New Font("Cooper Black", 14.25F)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(73, 467)
        Label4.Name = "Label4"
        Label4.Size = New Size(194, 21)
        Label4.TabIndex = 3
        Label4.Text = "Data de emprétimo"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.MediumPurple
        Label3.Font = New Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(322, 115)
        Label3.Name = "Label3"
        Label3.Size = New Size(164, 21)
        Label3.TabIndex = 2
        Label3.Text = "Nome do cliente"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.MediumPurple
        Label2.Font = New Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(73, 286)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 21)
        Label2.TabIndex = 1
        Label2.Text = "Título"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.MediumPurple
        Label1.Font = New Font("Cooper Black", 14.25F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(73, 199)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 21)
        Label1.TabIndex = 0
        Label1.Text = "ISBN"
        ' 
        ' MenuStrip2
        ' 
        MenuStrip2.BackColor = Color.MediumPurple
        MenuStrip2.ImageScalingSize = New Size(20, 20)
        MenuStrip2.Items.AddRange(New ToolStripItem() {ts_menu, ts_acervo, ts_pendencias, CLIENTESToolStripMenuItem})
        MenuStrip2.Location = New Point(0, 0)
        MenuStrip2.Name = "MenuStrip2"
        MenuStrip2.Padding = New Padding(5, 2, 0, 2)
        MenuStrip2.Size = New Size(993, 24)
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
        ' ts_acervo
        ' 
        ts_acervo.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ts_acervo.ForeColor = Color.White
        ts_acervo.Name = "ts_acervo"
        ts_acervo.Size = New Size(74, 20)
        ts_acervo.Text = "ACERVO"
        ' 
        ' ts_pendencias
        ' 
        ts_pendencias.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ts_pendencias.ForeColor = Color.White
        ts_pendencias.Name = "ts_pendencias"
        ts_pendencias.Size = New Size(105, 20)
        ts_pendencias.Text = "PENDENCIAS"
        ' 
        ' CLIENTESToolStripMenuItem
        ' 
        CLIENTESToolStripMenuItem.Font = New Font("Cooper Black", 9F)
        CLIENTESToolStripMenuItem.ForeColor = Color.White
        CLIENTESToolStripMenuItem.Name = "CLIENTESToolStripMenuItem"
        CLIENTESToolStripMenuItem.Size = New Size(83, 20)
        CLIENTESToolStripMenuItem.Text = "CLIENTES"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImageLayout = ImageLayout.None
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(887, 576)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(94, 83)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 32
        PictureBox2.TabStop = False
        ' 
        ' frm_emprestimo
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(993, 685)
        Controls.Add(PictureBox2)
        Controls.Add(MenuStrip2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "frm_emprestimo"
        Text = "EMPRESTIMO"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        MenuStrip2.ResumeLayout(False)
        MenuStrip2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmb_area As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_nomecliente As TextBox
    Friend WithEvents txt_idcliente As TextBox
    Friend WithEvents txt_etiqueta As TextBox
    Friend WithEvents txt_titulo As TextBox
    Friend WithEvents txt_isbn As TextBox
    Friend WithEvents btn_emprestimo As Button
    Friend WithEvents dtp_emprestimo As DateTimePicker
    Friend WithEvents dtp_devolucao As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_qtdestoque As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_qtdemprestimo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ts_menu As ToolStripMenuItem
    Friend WithEvents ts_acervo As ToolStripMenuItem
    Friend WithEvents ts_pendencias As ToolStripMenuItem
    Friend WithEvents CLIENTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox2 As PictureBox
End Class
