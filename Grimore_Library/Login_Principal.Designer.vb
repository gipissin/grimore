<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login_principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login_principal))
        Label1 = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        btn_entrar = New Button()
        btn_resetsenha = New LinkLabel()
        txt_senha = New TextBox()
        txt_matricula = New TextBox()
        Panel2 = New Panel()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkGoldenrod
        Label1.Location = New Point(120, 107)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 31)
        Label1.TabIndex = 0
        Label1.Text = "Matrícula"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sylfaen", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DarkGoldenrod
        Label2.Location = New Point(136, 208)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 31)
        Label2.TabIndex = 1
        Label2.Text = "Senha"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkSlateBlue
        Panel1.Controls.Add(btn_entrar)
        Panel1.Controls.Add(btn_resetsenha)
        Panel1.Controls.Add(txt_senha)
        Panel1.Controls.Add(txt_matricula)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(209, 28)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(360, 418)
        Panel1.TabIndex = 2
        ' 
        ' btn_entrar
        ' 
        btn_entrar.BackColor = Color.SlateBlue
        btn_entrar.FlatStyle = FlatStyle.Flat
        btn_entrar.Font = New Font("Sylfaen", 18.0F)
        btn_entrar.ForeColor = Color.DarkGoldenrod
        btn_entrar.Location = New Point(83, 306)
        btn_entrar.Name = "btn_entrar"
        btn_entrar.Size = New Size(185, 39)
        btn_entrar.TabIndex = 6
        btn_entrar.Text = "Entrar"
        btn_entrar.UseVisualStyleBackColor = False
        ' 
        ' btn_resetsenha
        ' 
        btn_resetsenha.AutoSize = True
        btn_resetsenha.Font = New Font("Sylfaen", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_resetsenha.LinkColor = Color.DarkGoldenrod
        btn_resetsenha.Location = New Point(106, 362)
        btn_resetsenha.Name = "btn_resetsenha"
        btn_resetsenha.Size = New Size(127, 22)
        btn_resetsenha.TabIndex = 5
        btn_resetsenha.TabStop = True
        btn_resetsenha.Text = "Esqueceu a senha?"
        ' 
        ' txt_senha
        ' 
        txt_senha.BackColor = Color.Gainsboro
        txt_senha.Location = New Point(40, 242)
        txt_senha.Name = "txt_senha"
        txt_senha.PasswordChar = "•"c
        txt_senha.Size = New Size(280, 23)
        txt_senha.TabIndex = 4
        ' 
        ' txt_matricula
        ' 
        txt_matricula.BackColor = Color.Gainsboro
        txt_matricula.Location = New Point(40, 165)
        txt_matricula.Name = "txt_matricula"
        txt_matricula.Size = New Size(280, 23)
        txt_matricula.TabIndex = 3
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.MediumSlateBlue
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(25, 16)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(312, 43)
        Panel2.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Sylfaen", 21.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(94, 2)
        Label3.Name = "Label3"
        Label3.Size = New Size(113, 39)
        Label3.TabIndex = 0
        Label3.Text = "LOGIN"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(723, 410)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(94, 83)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' login_principal
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(829, 505)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Name = "login_principal"
        Text = "Login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents txt_matricula As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_resetsenha As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_entrar As Button
End Class
