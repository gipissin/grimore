<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cad_clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cad_clientes))
        PictureBox2 = New PictureBox()
        Label8 = New Label()
        Label2 = New Label()
        nome = New Label()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label1 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label3 = New Label()
        Label4 = New Label()
        ComboBox1 = New ComboBox()
        Label5 = New Label()
        TextBox5 = New TextBox()
        PictureBox1 = New PictureBox()
        MaskedTextBox1 = New MaskedTextBox()
        MaskedTextBox2 = New MaskedTextBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImageLayout = ImageLayout.None
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(715, 369)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(94, 83)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 22
        PictureBox2.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Sylfaen", 11.25F)
        Label8.ForeColor = SystemColors.ControlLightLight
        Label8.Location = New Point(202, 111)
        Label8.Name = "Label8"
        Label8.Size = New Size(62, 19)
        Label8.TabIndex = 29
        Label8.Text = "Telefone"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(40, 176)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 19)
        Label2.TabIndex = 26
        Label2.Text = "E-mail"
        ' 
        ' nome
        ' 
        nome.AutoSize = True
        nome.BackColor = Color.Transparent
        nome.Font = New Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        nome.ForeColor = Color.Transparent
        nome.Location = New Point(40, 45)
        nome.Name = "nome"
        nome.Size = New Size(46, 19)
        nome.TabIndex = 25
        nome.Text = "Nome"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(42, 198)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(268, 23)
        TextBox2.TabIndex = 24
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.White
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("Courier New", 9.75F, FontStyle.Bold)
        TextBox1.Location = New Point(40, 67)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(306, 22)
        TextBox1.TabIndex = 23
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(40, 111)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 19)
        Label1.TabIndex = 31
        Label1.Text = "Seu CPF"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(399, 133)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(152, 23)
        DateTimePicker1.TabIndex = 32
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Sylfaen", 11.25F)
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(399, 111)
        Label3.Name = "Label3"
        Label3.Size = New Size(134, 19)
        Label3.TabIndex = 33
        Label3.Text = "Data de Nascimento"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Sylfaen", 11.25F)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(40, 272)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 19)
        Label4.TabIndex = 35
        Label4.Text = "Preferências"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(40, 294)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(156, 23)
        ComboBox1.TabIndex = 36
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Sylfaen", 11.25F)
        Label5.ForeColor = Color.Transparent
        Label5.Location = New Point(40, 320)
        Label5.Name = "Label5"
        Label5.Size = New Size(92, 19)
        Label5.TabIndex = 37
        Label5.Text = "Diga-me mais"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(40, 342)
        TextBox5.Multiline = True
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(400, 82)
        TextBox5.TabIndex = 38
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(566, 24)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(184, 239)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 39
        PictureBox1.TabStop = False
        ' 
        ' MaskedTextBox1
        ' 
        MaskedTextBox1.Font = New Font("Courier New", 9.75F, FontStyle.Bold)
        MaskedTextBox1.Location = New Point(40, 133)
        MaskedTextBox1.Mask = "999.999.999.-99"
        MaskedTextBox1.Name = "MaskedTextBox1"
        MaskedTextBox1.Size = New Size(132, 22)
        MaskedTextBox1.TabIndex = 40
        ' 
        ' MaskedTextBox2
        ' 
        MaskedTextBox2.Font = New Font("Courier New", 9.75F, FontStyle.Bold)
        MaskedTextBox2.Location = New Point(202, 133)
        MaskedTextBox2.Mask = "55+ (__) _____-_____"
        MaskedTextBox2.Name = "MaskedTextBox2"
        MaskedTextBox2.Size = New Size(172, 22)
        MaskedTextBox2.TabIndex = 41
        ' 
        ' Cad_clientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(801, 453)
        Controls.Add(MaskedTextBox2)
        Controls.Add(MaskedTextBox1)
        Controls.Add(PictureBox1)
        Controls.Add(TextBox5)
        Controls.Add(Label5)
        Controls.Add(ComboBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label1)
        Controls.Add(Label8)
        Controls.Add(Label2)
        Controls.Add(nome)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(PictureBox2)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Cad_clientes"
        Text = "Cadastro de Clientes"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nome As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
End Class
