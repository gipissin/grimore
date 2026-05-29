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
        MaskedTextBox2 = New MaskedTextBox()
        MaskedTextBox1 = New MaskedTextBox()
        PictureBox1 = New PictureBox()
        TextBox5 = New TextBox()
        Label5 = New Label()
        ComboBox1 = New ComboBox()
        Label4 = New Label()
        Label3 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label1 = New Label()
        Label8 = New Label()
        Label2 = New Label()
        nome = New Label()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label6 = New Label()
        Button1 = New Button()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImageLayout = ImageLayout.None
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(772, 519)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(94, 83)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 22
        PictureBox2.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(MaskedTextBox2)
        Panel1.Controls.Add(MaskedTextBox1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(TextBox5)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(DateTimePicker1)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(nome)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Font = New Font("Sylfaen", 12F)
        Panel1.Location = New Point(55, 30)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(725, 557)
        Panel1.TabIndex = 23
        ' 
        ' MaskedTextBox2
        ' 
        MaskedTextBox2.BackColor = Color.Gainsboro
        MaskedTextBox2.Font = New Font("Courier New", 9.75F, FontStyle.Bold)
        MaskedTextBox2.Location = New Point(294, 146)
        MaskedTextBox2.Mask = "55+ (__) _____-_____"
        MaskedTextBox2.Name = "MaskedTextBox2"
        MaskedTextBox2.Size = New Size(172, 22)
        MaskedTextBox2.TabIndex = 56
        ' 
        ' MaskedTextBox1
        ' 
        MaskedTextBox1.BackColor = Color.Gainsboro
        MaskedTextBox1.Font = New Font("Courier New", 9.75F, FontStyle.Bold)
        MaskedTextBox1.Location = New Point(20, 217)
        MaskedTextBox1.Mask = "999.999.999.-99"
        MaskedTextBox1.Name = "MaskedTextBox1"
        MaskedTextBox1.Size = New Size(132, 22)
        MaskedTextBox1.TabIndex = 55
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Gainsboro
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(487, 77)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(184, 239)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 54
        PictureBox1.TabStop = False
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = Color.Gainsboro
        TextBox5.Location = New Point(20, 395)
        TextBox5.Multiline = True
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(400, 141)
        TextBox5.TabIndex = 53
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.MediumPurple
        Label5.Font = New Font("Sylfaen", 12F)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(20, 354)
        Label5.Name = "Label5"
        Label5.Size = New Size(103, 22)
        Label5.TabIndex = 52
        Label5.Text = "Diga-me mais"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.Gainsboro
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(20, 305)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(156, 30)
        ComboBox1.TabIndex = 51
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.MediumPurple
        Label4.Font = New Font("Sylfaen", 12F)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(20, 269)
        Label4.Name = "Label4"
        Label4.Size = New Size(90, 22)
        Label4.TabIndex = 50
        Label4.Text = "Preferências"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.MediumPurple
        Label3.Font = New Font("Sylfaen", 12F)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(174, 188)
        Label3.Name = "Label3"
        Label3.Size = New Size(142, 22)
        Label3.TabIndex = 49
        Label3.Text = "Data de Nascimento"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.CalendarMonthBackground = Color.Gainsboro
        DateTimePicker1.CalendarTrailingForeColor = Color.Black
        DateTimePicker1.Font = New Font("Sylfaen", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(174, 213)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(152, 25)
        DateTimePicker1.TabIndex = 48
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.MediumPurple
        Label1.Font = New Font("Sylfaen", 12F)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(20, 188)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 22)
        Label1.TabIndex = 47
        Label1.Text = "Seu CPF"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.MediumPurple
        Label8.Font = New Font("Sylfaen", 12F)
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(294, 116)
        Label8.Name = "Label8"
        Label8.Size = New Size(67, 22)
        Label8.TabIndex = 46
        Label8.Text = "Telefone"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.MediumPurple
        Label2.Font = New Font("Sylfaen", 12F)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(20, 116)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 22)
        Label2.TabIndex = 45
        Label2.Text = "E-mail"
        ' 
        ' nome
        ' 
        nome.AutoSize = True
        nome.BackColor = Color.MediumPurple
        nome.Font = New Font("Sylfaen", 12F)
        nome.ForeColor = Color.Black
        nome.Location = New Point(20, 52)
        nome.Name = "nome"
        nome.Size = New Size(50, 22)
        nome.TabIndex = 44
        nome.Text = "Nome"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.Gainsboro
        TextBox2.Location = New Point(20, 141)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(268, 29)
        TextBox2.TabIndex = 43
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Gainsboro
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("Courier New", 9.75F, FontStyle.Bold)
        TextBox1.Location = New Point(20, 77)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(306, 22)
        TextBox1.TabIndex = 42
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.MediumPurple
        Label6.Font = New Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(542, 52)
        Label6.Name = "Label6"
        Label6.Size = New Size(63, 22)
        Label6.TabIndex = 57
        Label6.Text = "Sua foto"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.MediumPurple
        Button1.Font = New Font("Sylfaen", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(551, 481)
        Button1.Name = "Button1"
        Button1.Size = New Size(140, 55)
        Button1.TabIndex = 58
        Button1.Text = "Salvar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' frm_cadclientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(857, 599)
        Controls.Add(Panel1)
        Controls.Add(PictureBox2)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frm_cadclientes"
        Text = "Cadastro de Clientes"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nome As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
End Class
