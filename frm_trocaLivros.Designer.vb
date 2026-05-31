<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_trocaLivros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_trocaLivros))
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label8 = New Label()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Button2 = New Button()
        Button1 = New Button()
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker1 = New DateTimePicker()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel3 = New Panel()
        Button3 = New Button()
        cmb_area = New ComboBox()
        Label9 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(cmb_area)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(TextBox5)
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(DateTimePicker2)
        Panel1.Controls.Add(DateTimePicker1)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(55, 37)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(837, 589)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.MediumPurple
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Label8)
        Panel2.Location = New Point(163, 20)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(499, 44)
        Panel2.TabIndex = 16
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(126, -1)
        Label8.Name = "Label8"
        Label8.Size = New Size(239, 38)
        Label8.TabIndex = 17
        Label8.Text = "Faça a sua troca"
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = Color.Gainsboro
        TextBox5.Location = New Point(73, 151)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(256, 23)
        TextBox5.TabIndex = 15
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.Gainsboro
        TextBox4.Location = New Point(367, 151)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(147, 23)
        TextBox4.TabIndex = 14
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.Gainsboro
        TextBox3.Location = New Point(382, 262)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(102, 85)
        TextBox3.TabIndex = 13
        TextBox3.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.Gainsboro
        TextBox2.Location = New Point(73, 245)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(256, 23)
        TextBox2.TabIndex = 12
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Gainsboro
        TextBox1.Location = New Point(73, 324)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(256, 23)
        TextBox1.TabIndex = 11
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.MediumPurple
        Button2.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(619, 324)
        Button2.Name = "Button2"
        Button2.Size = New Size(164, 68)
        Button2.TabIndex = 10
        Button2.Text = "Devolução"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.MediumPurple
        Button1.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(619, 202)
        Button1.Name = "Button1"
        Button1.Size = New Size(166, 68)
        Button1.TabIndex = 9
        Button1.Text = "Empréstimo"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.CalendarFont = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker2.CalendarMonthBackground = Color.White
        DateTimePicker2.Font = New Font("Sylfaen", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DateTimePicker2.Format = DateTimePickerFormat.Short
        DateTimePicker2.Location = New Point(73, 494)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(166, 27)
        DateTimePicker2.TabIndex = 8
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Sylfaen", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(290, 494)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(159, 27)
        DateTimePicker1.TabIndex = 7
        DateTimePicker1.Value = New Date(2026, 5, 30, 0, 0, 0, 0)
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.MediumPurple
        Label7.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Bold)
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(367, 115)
        Label7.Name = "Label7"
        Label7.Size = New Size(134, 27)
        Label7.TabIndex = 6
        Label7.Text = "ID do cliente"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.MediumPurple
        Label6.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Bold)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(382, 224)
        Label6.Name = "Label6"
        Label6.Size = New Size(89, 27)
        Label6.TabIndex = 5
        Label6.Text = "Etiqueta"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.MediumPurple
        Label5.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Bold)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(290, 454)
        Label5.Name = "Label5"
        Label5.Size = New Size(182, 27)
        Label5.TabIndex = 4
        Label5.Text = "Data de devolução"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.MediumPurple
        Label4.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Bold)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(73, 454)
        Label4.Name = "Label4"
        Label4.Size = New Size(190, 27)
        Label4.TabIndex = 3
        Label4.Text = "Data de emprétimo"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.MediumPurple
        Label3.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Bold)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(73, 115)
        Label3.Name = "Label3"
        Label3.Size = New Size(161, 27)
        Label3.TabIndex = 2
        Label3.Text = "Nome do cliente"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.MediumPurple
        Label2.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Bold)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(73, 207)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 27)
        Label2.TabIndex = 1
        Label2.Text = "Título"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.MediumPurple
        Label1.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Bold)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(73, 286)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 27)
        Label1.TabIndex = 0
        Label1.Text = "ISBN"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(908, 649)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(94, 89)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Gray
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Location = New Point(869, 37)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(23, 589)
        Panel3.TabIndex = 17
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.MediumPurple
        Button3.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(610, 434)
        Button3.Name = "Button3"
        Button3.Size = New Size(185, 67)
        Button3.TabIndex = 17
        Button3.Text = "Dados do clientes"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' cmb_area
        ' 
        cmb_area.BackColor = Color.Gainsboro
        cmb_area.Font = New Font("Courier New", 9.75F, FontStyle.Bold)
        cmb_area.FormattingEnabled = True
        cmb_area.Location = New Point(73, 399)
        cmb_area.Name = "cmb_area"
        cmb_area.Size = New Size(162, 24)
        cmb_area.TabIndex = 34
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.MediumPurple
        Label9.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(73, 365)
        Label9.Name = "Label9"
        Label9.Size = New Size(216, 27)
        Label9.TabIndex = 35
        Label9.Text = "Area do conhecimento"
        ' 
        ' frm_trocaLivros
        ' 
        AutoScaleDimensions = New SizeF(7F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(997, 738)
        Controls.Add(Panel3)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Font = New Font("Comic Sans MS", 8.25F, FontStyle.Bold)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frm_trocaLivros"
        Text = "Emprétimos e Devoluções"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents cmb_area As ComboBox
    Friend WithEvents Label9 As Label
End Class
