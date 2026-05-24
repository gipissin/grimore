<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class alterar_senha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Alterar_Senha))
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Label4 = New Label()
        txt_perguntaseg = New TextBox()
        Panel2 = New Panel()
        Label3 = New Label()
        btn_confirmar = New Button()
        txt_senha = New TextBox()
        txt_matricula = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
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
        PictureBox1.Location = New Point(715, 369)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(94, 83)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkSlateBlue
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(txt_perguntaseg)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(btn_confirmar)
        Panel1.Controls.Add(txt_senha)
        Panel1.Controls.Add(txt_matricula)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(224, 27)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(352, 452)
        Panel1.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.DarkGoldenrod
        Label4.Location = New Point(37, 174)
        Label4.Name = "Label4"
        Label4.Size = New Size(301, 31)
        Label4.TabIndex = 8
        Label4.Text = "Qual o nome do seu gatinho?"
        ' 
        ' txt_perguntaseg
        ' 
        txt_perguntaseg.BackColor = Color.Gainsboro
        txt_perguntaseg.Location = New Point(36, 215)
        txt_perguntaseg.Name = "txt_perguntaseg"
        txt_perguntaseg.Size = New Size(280, 23)
        txt_perguntaseg.TabIndex = 7
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.MediumSlateBlue
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(22, 22)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(312, 43)
        Panel2.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Sylfaen", 21.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(17, 3)
        Label3.Name = "Label3"
        Label3.Size = New Size(255, 39)
        Label3.TabIndex = 0
        Label3.Text = "Alterar sua senha?"
        ' 
        ' btn_confirmar
        ' 
        btn_confirmar.BackColor = Color.SlateBlue
        btn_confirmar.FlatStyle = FlatStyle.Flat
        btn_confirmar.Font = New Font("Sylfaen", 18F)
        btn_confirmar.ForeColor = Color.DarkGoldenrod
        btn_confirmar.Location = New Point(87, 363)
        btn_confirmar.Name = "btn_confirmar"
        btn_confirmar.Size = New Size(185, 39)
        btn_confirmar.TabIndex = 5
        btn_confirmar.Text = "Confirmar"
        btn_confirmar.UseVisualStyleBackColor = False
        ' 
        ' txt_senha
        ' 
        txt_senha.BackColor = Color.Gainsboro
        txt_senha.Location = New Point(40, 303)
        txt_senha.Name = "txt_senha"
        txt_senha.Size = New Size(277, 23)
        txt_senha.TabIndex = 4
        ' 
        ' txt_matricula
        ' 
        txt_matricula.BackColor = Color.Gainsboro
        txt_matricula.Location = New Point(37, 129)
        txt_matricula.Name = "txt_matricula"
        txt_matricula.Size = New Size(280, 23)
        txt_matricula.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DarkGoldenrod
        Label2.Location = New Point(110, 257)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 31)
        Label2.TabIndex = 1
        Label2.Text = "Nova Senha"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkGoldenrod
        Label1.Location = New Point(123, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 31)
        Label1.TabIndex = 0
        Label1.Text = "Matrícula"
        ' 
        ' Alterar_Senha
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 524)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Name = "Alterar_Senha"
        Text = "Alterar Sua senha"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents txt_matricula As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_confirmar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_perguntaseg As TextBox
End Class