<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class entrada
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(entrada))
        botao_menu = New Button()
        botao_creditos = New Button()
        botao_sobre = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' botao_menu
        ' 
        botao_menu.BackColor = Color.FromArgb(CByte(118), CByte(27), CByte(201))
        botao_menu.FlatStyle = FlatStyle.Flat
        botao_menu.Font = New Font("Sylfaen", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        botao_menu.ForeColor = Color.White
        botao_menu.Location = New Point(239, 102)
        botao_menu.Name = "botao_menu"
        botao_menu.Size = New Size(302, 68)
        botao_menu.TabIndex = 0
        botao_menu.Text = "Menu"
        botao_menu.UseVisualStyleBackColor = False
        ' 
        ' botao_creditos
        ' 
        botao_creditos.BackColor = Color.FromArgb(CByte(118), CByte(27), CByte(201))
        botao_creditos.FlatStyle = FlatStyle.Flat
        botao_creditos.Font = New Font("Sylfaen", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        botao_creditos.ForeColor = Color.White
        botao_creditos.Location = New Point(239, 194)
        botao_creditos.Name = "botao_creditos"
        botao_creditos.Size = New Size(302, 70)
        botao_creditos.TabIndex = 1
        botao_creditos.Text = "Créditos"
        botao_creditos.UseVisualStyleBackColor = False
        ' 
        ' botao_sobre
        ' 
        botao_sobre.BackColor = Color.FromArgb(CByte(118), CByte(27), CByte(201))
        botao_sobre.FlatStyle = FlatStyle.Flat
        botao_sobre.Font = New Font("Sylfaen", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        botao_sobre.ForeColor = Color.White
        botao_sobre.Location = New Point(239, 288)
        botao_sobre.Name = "botao_sobre"
        botao_sobre.Size = New Size(302, 66)
        botao_sobre.TabIndex = 2
        botao_sobre.Text = "Sobre"
        botao_sobre.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(712, 366)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(94, 83)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' entrada
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(63), CByte(13), CByte(145))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(botao_sobre)
        Controls.Add(botao_creditos)
        Controls.Add(botao_menu)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "entrada"
        Text = "Entrada"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents botao_sobre As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button4 As Button
    Private botao_menu As Button
    Private botao_creditos As Button
End Class
