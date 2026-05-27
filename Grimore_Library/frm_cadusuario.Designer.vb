<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadusuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cadusuario))
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Label1 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label3 = New Label()
        Label9 = New Label()
        btn_verificar = New Button()
        Label8 = New Label()
        txt_csenha = New TextBox()
        cmb_status = New ComboBox()
        Label7 = New Label()
        cmb_tipo = New ComboBox()
        txt_nome = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        txt_perguntaseg = New TextBox()
        btn_cadastrar = New Button()
        txt_senha = New TextBox()
        txt_matricula = New TextBox()
        Label2 = New Label()
        btn_menu = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 470)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(94, 83)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(btn_verificar)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(txt_csenha)
        Panel1.Controls.Add(cmb_status)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(cmb_tipo)
        Panel1.Controls.Add(txt_nome)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(txt_perguntaseg)
        Panel1.Controls.Add(btn_cadastrar)
        Panel1.Controls.Add(txt_senha)
        Panel1.Controls.Add(txt_matricula)
        Panel1.Location = New Point(384, 21)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(501, 562)
        Panel1.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(247, 211)
        Label1.Name = "Label1"
        Label1.Size = New Size(221, 27)
        Label1.TabIndex = 23
        Label1.Text = "Confirmar Senha"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Black
        Label11.Location = New Point(43, 211)
        Label11.Name = "Label11"
        Label11.Size = New Size(86, 27)
        Label11.TabIndex = 22
        Label11.Text = "Senha"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(43, 152)
        Label10.Name = "Label10"
        Label10.Size = New Size(132, 27)
        Label10.TabIndex = 21
        Label10.Text = "Matrícula"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(36, 21)
        Label3.Name = "Label3"
        Label3.Size = New Size(312, 34)
        Label3.TabIndex = 0
        Label3.Text = "Cadastro de Usuário"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(94, 291)
        Label9.Name = "Label9"
        Label9.Size = New Size(153, 19)
        Label9.TabIndex = 20
        Label9.Text = "Visualizar senha?"
        ' 
        ' btn_verificar
        ' 
        btn_verificar.Image = CType(resources.GetObject("btn_verificar.Image"), Image)
        btn_verificar.Location = New Point(46, 287)
        btn_verificar.Margin = New Padding(3, 2, 3, 2)
        btn_verificar.Name = "btn_verificar"
        btn_verificar.Size = New Size(42, 28)
        btn_verificar.TabIndex = 19
        btn_verificar.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(286, 410)
        Label8.Name = "Label8"
        Label8.Size = New Size(90, 27)
        Label8.TabIndex = 16
        Label8.Text = "Status"
        ' 
        ' txt_csenha
        ' 
        txt_csenha.BackColor = Color.Gainsboro
        txt_csenha.Location = New Point(266, 241)
        txt_csenha.Name = "txt_csenha"
        txt_csenha.PasswordChar = "•"c
        txt_csenha.Size = New Size(202, 23)
        txt_csenha.TabIndex = 8
        ' 
        ' cmb_status
        ' 
        cmb_status.FormattingEnabled = True
        cmb_status.Location = New Point(266, 446)
        cmb_status.Margin = New Padding(2)
        cmb_status.Name = "cmb_status"
        cmb_status.Size = New Size(129, 23)
        cmb_status.TabIndex = 15
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(137, 410)
        Label7.Name = "Label7"
        Label7.Size = New Size(68, 27)
        Label7.TabIndex = 14
        Label7.Text = "Tipo"
        ' 
        ' cmb_tipo
        ' 
        cmb_tipo.FormattingEnabled = True
        cmb_tipo.Location = New Point(115, 446)
        cmb_tipo.Margin = New Padding(2)
        cmb_tipo.Name = "cmb_tipo"
        cmb_tipo.Size = New Size(129, 23)
        cmb_tipo.TabIndex = 13
        ' 
        ' txt_nome
        ' 
        txt_nome.BackColor = Color.Gainsboro
        txt_nome.Location = New Point(41, 107)
        txt_nome.Name = "txt_nome"
        txt_nome.Size = New Size(427, 23)
        txt_nome.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(43, 77)
        Label6.Name = "Label6"
        Label6.Size = New Size(82, 27)
        Label6.TabIndex = 11
        Label6.Text = "Nome"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(46, 331)
        Label5.Name = "Label5"
        Label5.Size = New Size(276, 27)
        Label5.TabIndex = 10
        Label5.Text = "Nome do seu gatinho?"
        ' 
        ' txt_perguntaseg
        ' 
        txt_perguntaseg.BackColor = Color.Gainsboro
        txt_perguntaseg.Location = New Point(43, 370)
        txt_perguntaseg.Name = "txt_perguntaseg"
        txt_perguntaseg.Size = New Size(422, 23)
        txt_perguntaseg.TabIndex = 9
        ' 
        ' btn_cadastrar
        ' 
        btn_cadastrar.BackColor = Color.BlueViolet
        btn_cadastrar.FlatStyle = FlatStyle.Flat
        btn_cadastrar.Font = New Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_cadastrar.ForeColor = Color.White
        btn_cadastrar.Location = New Point(163, 500)
        btn_cadastrar.Name = "btn_cadastrar"
        btn_cadastrar.Size = New Size(185, 39)
        btn_cadastrar.TabIndex = 6
        btn_cadastrar.Text = "Cadastrar"
        btn_cadastrar.UseVisualStyleBackColor = False
        ' 
        ' txt_senha
        ' 
        txt_senha.BackColor = Color.Gainsboro
        txt_senha.Location = New Point(41, 241)
        txt_senha.Name = "txt_senha"
        txt_senha.PasswordChar = "•"c
        txt_senha.Size = New Size(203, 23)
        txt_senha.TabIndex = 4
        ' 
        ' txt_matricula
        ' 
        txt_matricula.BackColor = Color.Gainsboro
        txt_matricula.Location = New Point(43, 182)
        txt_matricula.Name = "txt_matricula"
        txt_matricula.Size = New Size(425, 23)
        txt_matricula.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Cooper Black", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(28, 121)
        Label2.Name = "Label2"
        Label2.Size = New Size(331, 72)
        Label2.TabIndex = 27
        Label2.Text = "Faça parte da " & vbCrLf & "Nossa Comunidade!"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' btn_menu
        ' 
        btn_menu.BackColor = Color.Transparent
        btn_menu.Image = CType(resources.GetObject("btn_menu.Image"), Image)
        btn_menu.Location = New Point(12, 20)
        btn_menu.Name = "btn_menu"
        btn_menu.Size = New Size(80, 75)
        btn_menu.TabIndex = 24
        btn_menu.Text = vbCrLf
        btn_menu.UseVisualStyleBackColor = False
        ' 
        ' frm_cadusuario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(898, 629)
        Controls.Add(btn_menu)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Name = "frm_cadusuario"
        Text = "Cadastro de Usuário"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents txt_matricula As TextBox
    Friend WithEvents txt_csenha As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_perguntaseg As TextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmb_tipo As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmb_status As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_verificar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_menu As Button
End Class
