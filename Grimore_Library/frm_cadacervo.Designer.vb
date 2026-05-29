<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadacervo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cadacervo))
        foto_livro = New PrintPreviewDialog()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        Label10 = New Label()
        TextBox5 = New TextBox()
        TextBox3 = New TextBox()
        PictureBox3 = New PictureBox()
        Label9 = New Label()
        ComboBox5 = New ComboBox()
        Label8 = New Label()
        TextBox4 = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        ComboBox3 = New ComboBox()
        ComboBox1 = New ComboBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Panel2 = New Panel()
        Label11 = New Label()
        Button1 = New Button()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' foto_livro
        ' 
        foto_livro.AutoScrollMargin = New Size(0, 0)
        foto_livro.AutoScrollMinSize = New Size(0, 0)
        foto_livro.ClientSize = New Size(400, 300)
        foto_livro.Enabled = True
        foto_livro.Icon = CType(resources.GetObject("foto_livro.Icon"), Icon)
        foto_livro.Name = "foto_livro"
        foto_livro.Visible = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImageLayout = ImageLayout.None
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(789, 545)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(94, 83)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 21
        PictureBox2.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(TextBox5)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(ComboBox5)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(ComboBox3)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label4)
        Panel1.Font = New Font("Sylfaen", 12F)
        Panel1.Location = New Point(66, 31)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(687, 542)
        Panel1.TabIndex = 22
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.MediumPurple
        Label10.Font = New Font("Sylfaen", 12F)
        Label10.Location = New Point(494, 119)
        Label10.Name = "Label10"
        Label10.Size = New Size(98, 22)
        Label10.TabIndex = 45
        Label10.Text = "Capa do livro"
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = Color.Gainsboro
        TextBox5.Location = New Point(176, 416)
        TextBox5.Multiline = True
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(135, 31)
        TextBox5.TabIndex = 44
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.Gainsboro
        TextBox3.Location = New Point(169, 333)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(155, 29)
        TextBox3.TabIndex = 43
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Gainsboro
        PictureBox3.BorderStyle = BorderStyle.FixedSingle
        PictureBox3.Location = New Point(35, 416)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(106, 93)
        PictureBox3.TabIndex = 42
        PictureBox3.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.MediumPurple
        Label9.Font = New Font("Sylfaen", 12F)
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(222, 244)
        Label9.Name = "Label9"
        Label9.Size = New Size(45, 22)
        Label9.TabIndex = 41
        Label9.Text = "ISBN"
        ' 
        ' ComboBox5
        ' 
        ComboBox5.BackColor = Color.Gainsboro
        ComboBox5.Font = New Font("Courier New", 9.75F, FontStyle.Bold)
        ComboBox5.FormattingEnabled = True
        ComboBox5.Location = New Point(222, 269)
        ComboBox5.Name = "ComboBox5"
        ComboBox5.Size = New Size(162, 24)
        ComboBox5.TabIndex = 40
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.MediumPurple
        Label8.Font = New Font("Sylfaen", 12F)
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(35, 185)
        Label8.Name = "Label8"
        Label8.Size = New Size(58, 22)
        Label8.TabIndex = 39
        Label8.Text = "Editora"
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.Gainsboro
        TextBox4.Font = New Font("Courier New", 9.75F, FontStyle.Bold)
        TextBox4.Location = New Point(35, 210)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(268, 22)
        TextBox4.TabIndex = 38
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.MediumPurple
        Label7.Font = New Font("Sylfaen", 12F)
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(35, 391)
        Label7.Name = "Label7"
        Label7.Size = New Size(64, 22)
        Label7.TabIndex = 37
        Label7.Text = "Etiqueta"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.MediumPurple
        Label6.Font = New Font("Sylfaen", 12F)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(176, 391)
        Label6.Name = "Label6"
        Label6.Size = New Size(122, 22)
        Label6.TabIndex = 36
        Label6.Text = "Notação do autor"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.MediumPurple
        Label5.Font = New Font("Sylfaen", 12F)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(169, 303)
        Label5.Name = "Label5"
        Label5.Size = New Size(93, 22)
        Label5.TabIndex = 35
        Label5.Text = "Código PHA"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.MediumPurple
        Label4.Font = New Font("Sylfaen", 12F)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(35, 308)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 22)
        Label4.TabIndex = 34
        Label4.Text = "Quantidade"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.MediumPurple
        Label3.Font = New Font("Sylfaen", 12F)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(35, 244)
        Label3.Name = "Label3"
        Label3.Size = New Size(156, 22)
        Label3.TabIndex = 33
        Label3.Text = "Area do conhecimento"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.MediumPurple
        Label2.Font = New Font("Sylfaen", 12F)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(35, 133)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 22)
        Label2.TabIndex = 32
        Label2.Text = "Autor"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.MediumPurple
        Label1.Font = New Font("Sylfaen", 12F)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(35, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 22)
        Label1.TabIndex = 31
        Label1.Text = "Título"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Gainsboro
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(435, 144)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(209, 293)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 30
        PictureBox1.TabStop = False
        ' 
        ' ComboBox3
        ' 
        ComboBox3.BackColor = Color.Gainsboro
        ComboBox3.Font = New Font("Courier New", 9.75F, FontStyle.Bold)
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(35, 338)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(109, 24)
        ComboBox3.TabIndex = 29
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.Gainsboro
        ComboBox1.Font = New Font("Courier New", 9.75F, FontStyle.Bold)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(35, 269)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(162, 24)
        ComboBox1.TabIndex = 28
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.Gainsboro
        TextBox2.Font = New Font("Courier New", 9.75F, FontStyle.Bold)
        TextBox2.Location = New Point(35, 158)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(268, 22)
        TextBox2.TabIndex = 27
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Gainsboro
        TextBox1.Font = New Font("Courier New", 9.75F, FontStyle.Bold)
        TextBox1.Location = New Point(35, 108)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(268, 22)
        TextBox1.TabIndex = 26
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.MediumPurple
        Panel2.Controls.Add(Label11)
        Panel2.Location = New Point(154, 9)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(321, 47)
        Panel2.TabIndex = 46
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Sylfaen", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(51, 6)
        Label11.Name = "Label11"
        Label11.Size = New Size(209, 35)
        Label11.TabIndex = 0
        Label11.Text = "Cadastre o livro"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.MediumPurple
        Button1.Font = New Font("Sylfaen", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(450, 476)
        Button1.Name = "Button1"
        Button1.Size = New Size(159, 50)
        Button1.TabIndex = 47
        Button1.Text = "Salvar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' frm_cadacervo
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(63), CByte(13), CByte(145))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(872, 628)
        Controls.Add(Panel1)
        Controls.Add(PictureBox2)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frm_cadacervo"
        Text = "Cadastro de Acervo"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents foto_livro As PrintPreviewDialog
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label11 As Label
End Class
