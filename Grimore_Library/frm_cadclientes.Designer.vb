<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadclientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cadclientes))
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        Label11 = New Label()
        btn_salvar = New Button()
        Label6 = New Label()
        txt_telefone = New MaskedTextBox()
        txt_cpf = New MaskedTextBox()
        img_foto = New PictureBox()
        txt_observacoes = New TextBox()
        Label5 = New Label()
        cmb_preferencias = New ComboBox()
        Label4 = New Label()
        Label3 = New Label()
        dtp_nascimento = New DateTimePicker()
        Label1 = New Label()
        Label8 = New Label()
        Label2 = New Label()
        nome = New Label()
        txt_email = New TextBox()
        txt_nome = New TextBox()
        OpenFileDialog1 = New OpenFileDialog()
        MenuStrip2 = New MenuStrip()
        ts_menu = New ToolStripMenuItem()
        ts_gerenciarclientes = New ToolStripMenuItem()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(img_foto, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip2.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImageLayout = ImageLayout.None
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(755, 504)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(94, 83)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 22
        PictureBox2.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(btn_salvar)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(txt_telefone)
        Panel1.Controls.Add(txt_cpf)
        Panel1.Controls.Add(img_foto)
        Panel1.Controls.Add(txt_observacoes)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(cmb_preferencias)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(dtp_nascimento)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(nome)
        Panel1.Controls.Add(txt_email)
        Panel1.Controls.Add(txt_nome)
        Panel1.Font = New Font("Sylfaen", 12F)
        Panel1.Location = New Point(24, 30)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(725, 557)
        Panel1.TabIndex = 23
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Cooper Black", 15.75F)
        Label11.Location = New Point(20, 20)
        Label11.Name = "Label11"
        Label11.Size = New Size(292, 24)
        Label11.TabIndex = 52
        Label11.Text = "CADASTRO DE CLIENTES"
        ' 
        ' btn_salvar
        ' 
        btn_salvar.BackColor = Color.MediumPurple
        btn_salvar.Font = New Font("Cooper Black", 12F)
        btn_salvar.Location = New Point(529, 414)
        btn_salvar.Name = "btn_salvar"
        btn_salvar.Size = New Size(162, 63)
        btn_salvar.TabIndex = 58
        btn_salvar.Text = "Salvar"
        btn_salvar.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.MediumPurple
        Label6.Font = New Font("Cooper Black", 12F)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(562, 52)
        Label6.Name = "Label6"
        Label6.Size = New Size(77, 19)
        Label6.TabIndex = 57
        Label6.Text = "Sua foto"
        ' 
        ' txt_telefone
        ' 
        txt_telefone.BackColor = Color.Gainsboro
        txt_telefone.Font = New Font("Courier New", 9.75F, FontStyle.Bold)
        txt_telefone.Location = New Point(294, 146)
        txt_telefone.Mask = "(00) 00000-0000"
        txt_telefone.Name = "txt_telefone"
        txt_telefone.Size = New Size(172, 22)
        txt_telefone.TabIndex = 56
        ' 
        ' txt_cpf
        ' 
        txt_cpf.BackColor = Color.Gainsboro
        txt_cpf.Font = New Font("Courier New", 9.75F, FontStyle.Bold)
        txt_cpf.Location = New Point(20, 217)
        txt_cpf.Mask = "000.000.000-00"
        txt_cpf.Name = "txt_cpf"
        txt_cpf.Size = New Size(156, 22)
        txt_cpf.TabIndex = 55
        ' 
        ' img_foto
        ' 
        img_foto.BackColor = Color.Gainsboro
        img_foto.BackgroundImageLayout = ImageLayout.Center
        img_foto.BorderStyle = BorderStyle.FixedSingle
        img_foto.Location = New Point(507, 77)
        img_foto.Name = "img_foto"
        img_foto.Size = New Size(184, 239)
        img_foto.SizeMode = PictureBoxSizeMode.CenterImage
        img_foto.TabIndex = 54
        img_foto.TabStop = False
        ' 
        ' txt_observacoes
        ' 
        txt_observacoes.BackColor = Color.Gainsboro
        txt_observacoes.Location = New Point(20, 395)
        txt_observacoes.Multiline = True
        txt_observacoes.Name = "txt_observacoes"
        txt_observacoes.Size = New Size(400, 141)
        txt_observacoes.TabIndex = 53
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.MediumPurple
        Label5.Font = New Font("Cooper Black", 12F)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(20, 354)
        Label5.Name = "Label5"
        Label5.Size = New Size(116, 19)
        Label5.TabIndex = 52
        Label5.Text = "Diga-me mais"
        ' 
        ' cmb_preferencias
        ' 
        cmb_preferencias.BackColor = Color.Gainsboro
        cmb_preferencias.FormattingEnabled = True
        cmb_preferencias.Location = New Point(20, 305)
        cmb_preferencias.Name = "cmb_preferencias"
        cmb_preferencias.Size = New Size(268, 30)
        cmb_preferencias.TabIndex = 51
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.MediumPurple
        Label4.Font = New Font("Cooper Black", 12F)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(20, 269)
        Label4.Name = "Label4"
        Label4.Size = New Size(111, 19)
        Label4.TabIndex = 50
        Label4.Text = "Preferências"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.MediumPurple
        Label3.Font = New Font("Cooper Black", 12F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(294, 192)
        Label3.Name = "Label3"
        Label3.Size = New Size(168, 19)
        Label3.TabIndex = 49
        Label3.Text = "Data de Nascimento"
        ' 
        ' dtp_nascimento
        ' 
        dtp_nascimento.CalendarFont = New Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtp_nascimento.CalendarMonthBackground = Color.Gainsboro
        dtp_nascimento.CalendarTrailingForeColor = Color.Black
        dtp_nascimento.Font = New Font("Cooper Black", 12F)
        dtp_nascimento.Format = DateTimePickerFormat.Short
        dtp_nascimento.Location = New Point(294, 217)
        dtp_nascimento.Name = "dtp_nascimento"
        dtp_nascimento.Size = New Size(152, 26)
        dtp_nascimento.TabIndex = 48
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.MediumPurple
        Label1.Font = New Font("Cooper Black", 12F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(20, 188)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 19)
        Label1.TabIndex = 47
        Label1.Text = "Seu CPF"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.MediumPurple
        Label8.Font = New Font("Cooper Black", 12F)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(294, 116)
        Label8.Name = "Label8"
        Label8.Size = New Size(78, 19)
        Label8.TabIndex = 46
        Label8.Text = "Telefone"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.MediumPurple
        Label2.Font = New Font("Cooper Black", 12F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(20, 116)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 19)
        Label2.TabIndex = 45
        Label2.Text = "E-mail"
        ' 
        ' nome
        ' 
        nome.AutoSize = True
        nome.BackColor = Color.MediumPurple
        nome.Font = New Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        nome.ForeColor = Color.White
        nome.Location = New Point(20, 52)
        nome.Name = "nome"
        nome.Size = New Size(55, 19)
        nome.TabIndex = 44
        nome.Text = "Nome"
        ' 
        ' txt_email
        ' 
        txt_email.BackColor = Color.Gainsboro
        txt_email.Location = New Point(20, 141)
        txt_email.Name = "txt_email"
        txt_email.Size = New Size(268, 29)
        txt_email.TabIndex = 43
        ' 
        ' txt_nome
        ' 
        txt_nome.BackColor = Color.Gainsboro
        txt_nome.BorderStyle = BorderStyle.FixedSingle
        txt_nome.Font = New Font("Courier New", 9.75F, FontStyle.Bold)
        txt_nome.Location = New Point(20, 77)
        txt_nome.Name = "txt_nome"
        txt_nome.Size = New Size(446, 22)
        txt_nome.TabIndex = 42
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' MenuStrip2
        ' 
        MenuStrip2.BackColor = Color.MediumPurple
        MenuStrip2.ImageScalingSize = New Size(20, 20)
        MenuStrip2.Items.AddRange(New ToolStripItem() {ts_menu, ts_gerenciarclientes})
        MenuStrip2.Location = New Point(0, 0)
        MenuStrip2.Name = "MenuStrip2"
        MenuStrip2.Padding = New Padding(5, 2, 0, 2)
        MenuStrip2.Size = New Size(857, 24)
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
        ' ts_gerenciarclientes
        ' 
        ts_gerenciarclientes.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ts_gerenciarclientes.ForeColor = Color.White
        ts_gerenciarclientes.Name = "ts_gerenciarclientes"
        ts_gerenciarclientes.Size = New Size(164, 20)
        ts_gerenciarclientes.Text = "GERENCIAR CLIENTES"
        ' 
        ' frm_cadclientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(857, 599)
        Controls.Add(MenuStrip2)
        Controls.Add(Panel1)
        Controls.Add(PictureBox2)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frm_cadclientes"
        Text = "CADASTRO DE CLIENTES"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(img_foto, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip2.ResumeLayout(False)
        MenuStrip2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_telefone As MaskedTextBox
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents txt_observacoes As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_preferencias As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtp_nascimento As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nome As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents btn_salvar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ts_menu As ToolStripMenuItem
    Friend WithEvents ts_gerenciarclientes As ToolStripMenuItem
End Class
