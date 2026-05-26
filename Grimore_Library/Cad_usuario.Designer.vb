<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cad_usuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cad_usuario))
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Label8 = New Label()
        cmb_status = New ComboBox()
        Label7 = New Label()
        cmb_tipo = New ComboBox()
        txt_nome = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        txt_perguntaseg = New TextBox()
        txt_csenha = New TextBox()
        Label4 = New Label()
        btn_cadastrar = New Button()
        txt_senha = New TextBox()
        txt_matricula = New TextBox()
        Panel2 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btn_verificar = New Button()
        Label9 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(806, 714)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(107, 111)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkSlateBlue
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(btn_verificar)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(cmb_status)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(cmb_tipo)
        Panel1.Controls.Add(txt_nome)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(txt_perguntaseg)
        Panel1.Controls.Add(txt_csenha)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(btn_cadastrar)
        Panel1.Controls.Add(txt_senha)
        Panel1.Controls.Add(txt_matricula)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(256, 36)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(402, 763)
        Panel1.TabIndex = 6
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.DarkGoldenrod
        Label8.Location = New Point(211, 571)
        Label8.Name = "Label8"
        Label8.Size = New Size(92, 39)
        Label8.TabIndex = 16
        Label8.Text = "Status"
        ' 
        ' cmb_status
        ' 
        cmb_status.FormattingEnabled = True
        cmb_status.Location = New Point(219, 613)
        cmb_status.Margin = New Padding(2, 3, 2, 3)
        cmb_status.Name = "cmb_status"
        cmb_status.Size = New Size(147, 28)
        cmb_status.TabIndex = 15
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.DarkGoldenrod
        Label7.Location = New Point(42, 571)
        Label7.Name = "Label7"
        Label7.Size = New Size(75, 39)
        Label7.TabIndex = 14
        Label7.Text = "Tipo"
        ' 
        ' cmb_tipo
        ' 
        cmb_tipo.FormattingEnabled = True
        cmb_tipo.Location = New Point(42, 613)
        cmb_tipo.Margin = New Padding(2, 3, 2, 3)
        cmb_tipo.Name = "cmb_tipo"
        cmb_tipo.Size = New Size(147, 28)
        cmb_tipo.TabIndex = 13
        ' 
        ' txt_nome
        ' 
        txt_nome.BackColor = Color.Gainsboro
        txt_nome.Location = New Point(47, 143)
        txt_nome.Margin = New Padding(3, 4, 3, 4)
        txt_nome.Name = "txt_nome"
        txt_nome.Size = New Size(319, 27)
        txt_nome.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.DarkGoldenrod
        Label6.Location = New Point(160, 100)
        Label6.Name = "Label6"
        Label6.Size = New Size(92, 39)
        Label6.TabIndex = 11
        Label6.Text = "Nome"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.DarkGoldenrod
        Label5.Location = New Point(62, 482)
        Label5.Name = "Label5"
        Label5.Size = New Size(296, 39)
        Label5.TabIndex = 10
        Label5.Text = "Nome do seu gatinho?"
        ' 
        ' txt_perguntaseg
        ' 
        txt_perguntaseg.BackColor = Color.Gainsboro
        txt_perguntaseg.Location = New Point(42, 525)
        txt_perguntaseg.Margin = New Padding(3, 4, 3, 4)
        txt_perguntaseg.Name = "txt_perguntaseg"
        txt_perguntaseg.Size = New Size(324, 27)
        txt_perguntaseg.TabIndex = 9
        ' 
        ' txt_csenha
        ' 
        txt_csenha.BackColor = Color.Gainsboro
        txt_csenha.Location = New Point(47, 394)
        txt_csenha.Margin = New Padding(3, 4, 3, 4)
        txt_csenha.Name = "txt_csenha"
        txt_csenha.PasswordChar = "*"c
        txt_csenha.Size = New Size(319, 27)
        txt_csenha.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.DarkGoldenrod
        Label4.Location = New Point(95, 351)
        Label4.Name = "Label4"
        Label4.Size = New Size(228, 39)
        Label4.TabIndex = 7
        Label4.Text = "Confirmar Senha"
        ' 
        ' btn_cadastrar
        ' 
        btn_cadastrar.BackColor = Color.SlateBlue
        btn_cadastrar.FlatStyle = FlatStyle.Flat
        btn_cadastrar.Font = New Font("Sylfaen", 18F)
        btn_cadastrar.ForeColor = Color.AntiqueWhite
        btn_cadastrar.Location = New Point(95, 688)
        btn_cadastrar.Margin = New Padding(3, 4, 3, 4)
        btn_cadastrar.Name = "btn_cadastrar"
        btn_cadastrar.Size = New Size(211, 52)
        btn_cadastrar.TabIndex = 6
        btn_cadastrar.Text = "Cadastrar"
        btn_cadastrar.UseVisualStyleBackColor = False
        ' 
        ' txt_senha
        ' 
        txt_senha.BackColor = Color.Gainsboro
        txt_senha.Location = New Point(47, 320)
        txt_senha.Margin = New Padding(3, 4, 3, 4)
        txt_senha.Name = "txt_senha"
        txt_senha.PasswordChar = "*"c
        txt_senha.Size = New Size(319, 27)
        txt_senha.TabIndex = 4
        ' 
        ' txt_matricula
        ' 
        txt_matricula.BackColor = Color.Gainsboro
        txt_matricula.Location = New Point(47, 231)
        txt_matricula.Margin = New Padding(3, 4, 3, 4)
        txt_matricula.Name = "txt_matricula"
        txt_matricula.Size = New Size(319, 27)
        txt_matricula.TabIndex = 3
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.MediumSlateBlue
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(29, 21)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(356, 57)
        Panel2.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Sylfaen", 21.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(3, 3)
        Label3.Name = "Label3"
        Label3.Size = New Size(348, 48)
        Label3.TabIndex = 0
        Label3.Text = "Cadastro de Usuário"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DarkGoldenrod
        Label2.Location = New Point(160, 277)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 39)
        Label2.TabIndex = 1
        Label2.Text = "Senha"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkGoldenrod
        Label1.Location = New Point(136, 188)
        Label1.Name = "Label1"
        Label1.Size = New Size(139, 39)
        Label1.TabIndex = 0
        Label1.Text = "Matrícula"
        ' 
        ' btn_verificar
        ' 
        btn_verificar.Image = CType(resources.GetObject("btn_verificar.Image"), Image)
        btn_verificar.Location = New Point(74, 427)
        btn_verificar.Name = "btn_verificar"
        btn_verificar.Size = New Size(48, 37)
        btn_verificar.TabIndex = 17
        btn_verificar.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Sylfaen", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.DarkGoldenrod
        Label9.Location = New Point(128, 430)
        Label9.Name = "Label9"
        Label9.Size = New Size(220, 29)
        Label9.TabIndex = 18
        Label9.Text = "Vizualizar sua senha?"
        ' 
        ' cad_usuario
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(906, 824)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "cad_usuario"
        Text = "Cadastro de Usuário"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents txt_matricula As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_csenha As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_perguntaseg As TextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmb_tipo As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmb_status As ComboBox
    Friend WithEvents btn_verificar As Button
    Friend WithEvents Label9 As Label
End Class
