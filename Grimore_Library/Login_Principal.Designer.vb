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
        PictureBox1 = New PictureBox()
        txt_usuario = New TextBox()
        txt_senha = New TextBox()
        btn_resetsenha = New LinkLabel()
        btn_entrar = New Button()
        btn_verificar = New Button()
        Label9 = New Label()
        Panel1 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label5 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 398)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(94, 83)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' txt_usuario
        ' 
        txt_usuario.BackColor = Color.Gainsboro
        txt_usuario.Location = New Point(25, 144)
        txt_usuario.Name = "txt_usuario"
        txt_usuario.Size = New Size(379, 23)
        txt_usuario.TabIndex = 3
        ' 
        ' txt_senha
        ' 
        txt_senha.BackColor = Color.Gainsboro
        txt_senha.Location = New Point(25, 228)
        txt_senha.Name = "txt_senha"
        txt_senha.PasswordChar = "•"c
        txt_senha.Size = New Size(379, 23)
        txt_senha.TabIndex = 4
        ' 
        ' btn_resetsenha
        ' 
        btn_resetsenha.AutoSize = True
        btn_resetsenha.Font = New Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_resetsenha.LinkColor = Color.BlueViolet
        btn_resetsenha.Location = New Point(134, 375)
        btn_resetsenha.Name = "btn_resetsenha"
        btn_resetsenha.Size = New Size(156, 19)
        btn_resetsenha.TabIndex = 5
        btn_resetsenha.TabStop = True
        btn_resetsenha.Text = "Esqueceu a senha?"
        ' 
        ' btn_entrar
        ' 
        btn_entrar.BackColor = Color.BlueViolet
        btn_entrar.FlatStyle = FlatStyle.Flat
        btn_entrar.Font = New Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_entrar.ForeColor = Color.White
        btn_entrar.Location = New Point(25, 322)
        btn_entrar.Name = "btn_entrar"
        btn_entrar.Size = New Size(379, 39)
        btn_entrar.TabIndex = 6
        btn_entrar.Text = "Entrar"
        btn_entrar.UseVisualStyleBackColor = False
        ' 
        ' btn_verificar
        ' 
        btn_verificar.Image = CType(resources.GetObject("btn_verificar.Image"), Image)
        btn_verificar.Location = New Point(25, 266)
        btn_verificar.Margin = New Padding(3, 2, 3, 2)
        btn_verificar.Name = "btn_verificar"
        btn_verificar.Size = New Size(42, 28)
        btn_verificar.TabIndex = 21
        btn_verificar.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(73, 272)
        Label9.Name = "Label9"
        Label9.Size = New Size(153, 19)
        Label9.TabIndex = 22
        Label9.Text = "Visualizar senha?"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(btn_verificar)
        Panel1.Controls.Add(btn_entrar)
        Panel1.Controls.Add(btn_resetsenha)
        Panel1.Controls.Add(txt_senha)
        Panel1.Controls.Add(txt_usuario)
        Panel1.Location = New Point(370, 43)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(425, 438)
        Panel1.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(25, 41)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 34)
        Label3.TabIndex = 0
        Label3.Text = "LOGIN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(25, 188)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 27)
        Label2.TabIndex = 23
        Label2.Text = "Senha"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(25, 108)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 27)
        Label1.TabIndex = 1
        Label1.Text = "Usuario"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(12, 69)
        Label5.Name = "Label5"
        Label5.Size = New Size(338, 34)
        Label5.TabIndex = 26
        Label5.Text = "Bem Vindo a Grimore!"
        ' 
        ' login_principal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(829, 505)
        Controls.Add(Label5)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Name = "login_principal"
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents btn_resetsenha As LinkLabel
    Friend WithEvents btn_entrar As Button
    Friend WithEvents btn_verificar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
End Class
