<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_alterarsenha
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_alterarsenha))
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        btn_verificar = New Button()
        btn_confirmar = New Button()
        Label3 = New Label()
        Label4 = New Label()
        txt_perguntaseg = New TextBox()
        txt_senha = New TextBox()
        txt_matricula = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
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
        PictureBox1.Location = New Point(683, 429)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(94, 83)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.GhostWhite
        Panel1.Controls.Add(btn_verificar)
        Panel1.Controls.Add(btn_confirmar)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(txt_perguntaseg)
        Panel1.Controls.Add(txt_senha)
        Panel1.Controls.Add(txt_matricula)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(224, 27)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(368, 485)
        Panel1.TabIndex = 6
        ' 
        ' btn_verificar
        ' 
        btn_verificar.BackColor = Color.BlueViolet
        btn_verificar.FlatStyle = FlatStyle.Flat
        btn_verificar.Font = New Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_verificar.ForeColor = Color.White
        btn_verificar.Location = New Point(114, 252)
        btn_verificar.Name = "btn_verificar"
        btn_verificar.Size = New Size(139, 43)
        btn_verificar.TabIndex = 11
        btn_verificar.Text = "Verificar"
        btn_verificar.UseVisualStyleBackColor = False
        ' 
        ' btn_confirmar
        ' 
        btn_confirmar.BackColor = Color.BlueViolet
        btn_confirmar.FlatStyle = FlatStyle.Flat
        btn_confirmar.Font = New Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_confirmar.ForeColor = Color.White
        btn_confirmar.Location = New Point(85, 399)
        btn_confirmar.Name = "btn_confirmar"
        btn_confirmar.Size = New Size(196, 49)
        btn_confirmar.TabIndex = 10
        btn_confirmar.Text = "Confirmar"
        btn_confirmar.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(37, 36)
        Label3.Name = "Label3"
        Label3.Size = New Size(284, 34)
        Label3.TabIndex = 9
        Label3.Text = "ALTERAR SENHA"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Cooper Black", 16F)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(21, 174)
        Label4.Name = "Label4"
        Label4.Size = New Size(329, 25)
        Label4.TabIndex = 8
        Label4.Text = "Qual o nome do seu gatinho?"
        ' 
        ' txt_perguntaseg
        ' 
        txt_perguntaseg.BackColor = Color.Gainsboro
        txt_perguntaseg.Location = New Point(36, 211)
        txt_perguntaseg.Name = "txt_perguntaseg"
        txt_perguntaseg.Size = New Size(280, 23)
        txt_perguntaseg.TabIndex = 7
        ' 
        ' txt_senha
        ' 
        txt_senha.BackColor = Color.Gainsboro
        txt_senha.Location = New Point(42, 357)
        txt_senha.Name = "txt_senha"
        txt_senha.Size = New Size(277, 23)
        txt_senha.TabIndex = 4
        ' 
        ' txt_matricula
        ' 
        txt_matricula.BackColor = Color.Gainsboro
        txt_matricula.Location = New Point(37, 125)
        txt_matricula.Name = "txt_matricula"
        txt_matricula.Size = New Size(280, 23)
        txt_matricula.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cooper Black", 18F)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(104, 315)
        Label2.Name = "Label2"
        Label2.Size = New Size(155, 27)
        Label2.TabIndex = 1
        Label2.Text = "Nova Senha"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.AliceBlue
        Label1.Font = New Font("Cooper Black", 18F)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(111, 85)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 27)
        Label1.TabIndex = 0
        Label1.Text = "Matrícula"
        ' 
        ' btn_menu
        ' 
        btn_menu.BackColor = Color.Transparent
        btn_menu.Image = CType(resources.GetObject("btn_menu.Image"), Image)
        btn_menu.Location = New Point(683, 40)
        btn_menu.Name = "btn_menu"
        btn_menu.Size = New Size(80, 75)
        btn_menu.TabIndex = 7
        btn_menu.Text = vbCrLf
        btn_menu.UseVisualStyleBackColor = False
        ' 
        ' frm_alterarsenha
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 556)
        Controls.Add(btn_menu)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Name = "frm_alterarsenha"
        Text = "Alterar Sua senha"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents txt_matricula As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_perguntaseg As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_verificar As Button
    Friend WithEvents btn_confirmar As Button
    Friend WithEvents btn_menu As Button
End Class