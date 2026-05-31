<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cad_acervo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cad_acervo))
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        ComboBox4 = New ComboBox()
        TextBox3 = New TextBox()
        PictureBox1 = New PictureBox()
        foto_livro = New PrintPreviewDialog()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        TextBox4 = New TextBox()
        Label9 = New Label()
        ComboBox5 = New ComboBox()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Courier New", 9.75F, FontStyle.Bold)
        TextBox1.Location = New Point(50, 37)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(268, 22)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Courier New", 9.75F, FontStyle.Bold)
        TextBox2.Location = New Point(48, 81)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(268, 22)
        TextBox2.TabIndex = 1
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Courier New", 9.75F, FontStyle.Bold)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(48, 179)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(162, 24)
        ComboBox1.TabIndex = 4
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Font = New Font("Courier New", 9.75F, FontStyle.Bold)
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(169, 229)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(108, 24)
        ComboBox2.TabIndex = 5
        ' 
        ' ComboBox3
        ' 
        ComboBox3.Font = New Font("Courier New", 9.75F, FontStyle.Bold)
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(49, 229)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(109, 24)
        ComboBox3.TabIndex = 6
        ' 
        ' ComboBox4
        ' 
        ComboBox4.Font = New Font("Courier New", 9.75F, FontStyle.Bold)
        ComboBox4.FormattingEnabled = True
        ComboBox4.Location = New Point(289, 230)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(107, 24)
        ComboBox4.TabIndex = 7
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Courier New", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(48, 281)
        TextBox3.MaxLength = 3000
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(405, 157)
        TextBox3.TabIndex = 8
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(520, 48)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(209, 293)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(50, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 19)
        Label1.TabIndex = 10
        Label1.Text = "Título"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(50, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 19)
        Label2.TabIndex = 11
        Label2.Text = "Autor"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Sylfaen", 11.25F)
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(48, 157)
        Label3.Name = "Label3"
        Label3.Size = New Size(147, 19)
        Label3.TabIndex = 12
        Label3.Text = "Area do conhecimento"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Sylfaen", 11.25F)
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(48, 208)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 19)
        Label4.TabIndex = 13
        Label4.Text = "Quantidade"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Sylfaen", 11.25F)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(169, 208)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 19)
        Label5.TabIndex = 14
        Label5.Text = "Estante"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Sylfaen", 11.25F)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(289, 208)
        Label6.Name = "Label6"
        Label6.Size = New Size(67, 19)
        Label6.TabIndex = 15
        Label6.Text = "Prateleira"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Sylfaen", 11.25F)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(50, 259)
        Label7.Name = "Label7"
        Label7.Size = New Size(55, 19)
        Label7.TabIndex = 16
        Label7.Text = "Sinopse"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Sylfaen", 11.25F)
        Label8.ForeColor = SystemColors.ControlLightLight
        Label8.Location = New Point(48, 108)
        Label8.Name = "Label8"
        Label8.Size = New Size(54, 19)
        Label8.TabIndex = 18
        Label8.Text = "Editora"
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Courier New", 9.75F, FontStyle.Bold)
        TextBox4.Location = New Point(50, 131)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(268, 22)
        TextBox4.TabIndex = 17
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Sylfaen", 11.25F)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(234, 157)
        Label9.Name = "Label9"
        Label9.Size = New Size(61, 19)
        Label9.TabIndex = 20
        Label9.Text = "Formato"
        ' 
        ' ComboBox5
        ' 
        ComboBox5.Font = New Font("Courier New", 9.75F, FontStyle.Bold)
        ComboBox5.FormattingEnabled = True
        ComboBox5.Location = New Point(234, 178)
        ComboBox5.Name = "ComboBox5"
        ComboBox5.Size = New Size(162, 24)
        ComboBox5.TabIndex = 19
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImageLayout = ImageLayout.None
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(713, 368)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(94, 83)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 21
        PictureBox2.TabStop = False
        ' 
        ' Cad_acervo
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(63), CByte(13), CByte(145))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(803, 450)
        Controls.Add(PictureBox2)
        Controls.Add(Label9)
        Controls.Add(ComboBox5)
        Controls.Add(Label8)
        Controls.Add(TextBox4)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(TextBox3)
        Controls.Add(ComboBox4)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Cad_acervo"
        Text = "Cadastro de Acervo"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents foto_livro As PrintPreviewDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
