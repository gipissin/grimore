<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        cad_clientes = New Button()
        consulta_dispon = New Button()
        cad_acervo = New Button()
        devolucao = New Button()
        emprestimos = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cad_clientes
        ' 
        cad_clientes.BackColor = Color.FromArgb(CByte(118), CByte(27), CByte(201))
        cad_clientes.Font = New Font("Sylfaen", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cad_clientes.ForeColor = Color.White
        cad_clientes.Location = New Point(200, 193)
        cad_clientes.Name = "cad_clientes"
        cad_clientes.Size = New Size(406, 66)
        cad_clientes.TabIndex = 5
        cad_clientes.Text = "Cadastro de Clientes"
        cad_clientes.UseVisualStyleBackColor = False
        ' 
        ' consulta_dispon
        ' 
        consulta_dispon.BackColor = Color.FromArgb(CByte(118), CByte(27), CByte(201))
        consulta_dispon.Font = New Font("Sylfaen", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        consulta_dispon.ForeColor = Color.White
        consulta_dispon.Location = New Point(200, 117)
        consulta_dispon.Name = "consulta_dispon"
        consulta_dispon.Size = New Size(406, 70)
        consulta_dispon.TabIndex = 4
        consulta_dispon.Text = "Consulta de Disponibilidade"
        consulta_dispon.UseVisualStyleBackColor = False
        ' 
        ' cad_acervo
        ' 
        cad_acervo.BackColor = Color.FromArgb(CByte(118), CByte(27), CByte(201))
        cad_acervo.Font = New Font("Sylfaen", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cad_acervo.ForeColor = Color.White
        cad_acervo.Location = New Point(200, 43)
        cad_acervo.Name = "cad_acervo"
        cad_acervo.Size = New Size(406, 68)
        cad_acervo.TabIndex = 3
        cad_acervo.Text = "Cadastro de Acervo"
        cad_acervo.UseVisualStyleBackColor = False
        ' 
        ' devolucao
        ' 
        devolucao.BackColor = Color.FromArgb(CByte(118), CByte(27), CByte(201))
        devolucao.Font = New Font("Sylfaen", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        devolucao.ForeColor = Color.White
        devolucao.Location = New Point(200, 336)
        devolucao.Name = "devolucao"
        devolucao.Size = New Size(406, 70)
        devolucao.TabIndex = 7
        devolucao.Text = "Controle de Devoluções"
        devolucao.UseVisualStyleBackColor = False
        ' 
        ' emprestimos
        ' 
        emprestimos.BackColor = Color.FromArgb(CByte(118), CByte(27), CByte(201))
        emprestimos.Font = New Font("Sylfaen", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        emprestimos.ForeColor = Color.White
        emprestimos.Location = New Point(200, 264)
        emprestimos.Name = "emprestimos"
        emprestimos.Size = New Size(406, 68)
        emprestimos.TabIndex = 6
        emprestimos.Text = "Gastão de Empréstimos"
        emprestimos.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(715, 368)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(94, 83)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(devolucao)
        Controls.Add(emprestimos)
        Controls.Add(cad_clientes)
        Controls.Add(consulta_dispon)
        Controls.Add(cad_acervo)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Menu"
        Text = "Menu"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents botao_sobre As Button
    Private WithEvents botao_creditos As Button
    Private WithEvents botao_menu As Button
    Private WithEvents devolucao As Button
    Private WithEvents emprestimos As Button
    Friend WithEvents PictureBox1 As PictureBox
    Private cad_clientes As Button
    Private consulta_dispon As Button
    Private cad_acervo As Button
End Class
