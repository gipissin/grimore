<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_acervo
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_acervo))
        dgv_acervo = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewImageColumn()
        Column7 = New DataGridViewImageColumn()
        btn_menu = New Button()
        PictureBox2 = New PictureBox()
        Label2 = New Label()
        MenuStrip2 = New MenuStrip()
        ts_menu = New ToolStripMenuItem()
        ts_cadastroacervo = New ToolStripMenuItem()
        ToolStrip1 = New ToolStrip()
        ToolStripLabel1 = New ToolStripLabel()
        ToolStripSeparator1 = New ToolStripSeparator()
        txt_livrobusc = New ToolStripTextBox()
        btn_buscaracervo = New ToolStripButton()
        CType(dgv_acervo, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip2.SuspendLayout()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgv_acervo
        ' 
        dgv_acervo.AllowUserToAddRows = False
        dgv_acervo.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(179), CByte(157), CByte(219))
        DataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(CByte(26), CByte(0), CByte(80))
        dgv_acervo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgv_acervo.BackgroundColor = Color.FromArgb(CByte(74), CByte(47), CByte(138))
        dgv_acervo.BorderStyle = BorderStyle.Fixed3D
        dgv_acervo.ColumnHeadersHeight = 40
        dgv_acervo.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column8, Column5, Column6, Column7})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 8F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgv_acervo.DefaultCellStyle = DataGridViewCellStyle2
        dgv_acervo.GridColor = Color.FromArgb(CByte(224), CByte(216), CByte(247))
        dgv_acervo.Location = New Point(0, 120)
        dgv_acervo.Margin = New Padding(3, 2, 3, 2)
        dgv_acervo.Name = "dgv_acervo"
        dgv_acervo.ReadOnly = True
        dgv_acervo.RowHeadersWidth = 51
        dgv_acervo.RowTemplate.Height = 36
        dgv_acervo.Size = New Size(1077, 361)
        dgv_acervo.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Titulo"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Autor"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Editora"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "ISBN"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 125
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "Quantidades"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Width = 125
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Etiqueta"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 125
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Editar"
        Column6.Image = CType(resources.GetObject("Column6.Image"), Image)
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 125
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Excluir"
        Column7.Image = CType(resources.GetObject("Column7.Image"), Image)
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 125
        ' 
        ' btn_menu
        ' 
        btn_menu.BackColor = Color.Transparent
        btn_menu.Image = CType(resources.GetObject("btn_menu.Image"), Image)
        btn_menu.Location = New Point(969, 36)
        btn_menu.Name = "btn_menu"
        btn_menu.Size = New Size(80, 75)
        btn_menu.TabIndex = 30
        btn_menu.Text = vbCrLf
        btn_menu.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImageLayout = ImageLayout.None
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(858, 34)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(94, 83)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 31
        PictureBox2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Cooper Black", 21.75F)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(12, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(485, 34)
        Label2.TabIndex = 32
        Label2.Text = "GERENCIAMENTO DE ACERVO"
        ' 
        ' MenuStrip2
        ' 
        MenuStrip2.BackColor = Color.MediumPurple
        MenuStrip2.ImageScalingSize = New Size(20, 20)
        MenuStrip2.Items.AddRange(New ToolStripItem() {ts_menu, ts_cadastroacervo})
        MenuStrip2.Location = New Point(0, 0)
        MenuStrip2.Name = "MenuStrip2"
        MenuStrip2.Padding = New Padding(5, 2, 0, 2)
        MenuStrip2.Size = New Size(1061, 24)
        MenuStrip2.TabIndex = 34
        MenuStrip2.Text = "MenuStrip2"
        ' 
        ' ts_menu
        ' 
        ts_menu.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ts_menu.ForeColor = Color.White
        ts_menu.Name = "ts_menu"
        ts_menu.Size = New Size(58, 20)
        ts_menu.Text = "MENU"
        ' 
        ' ts_cadastroacervo
        ' 
        ts_cadastroacervo.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ts_cadastroacervo.ForeColor = Color.White
        ts_cadastroacervo.Name = "ts_cadastroacervo"
        ts_cadastroacervo.Size = New Size(150, 20)
        ts_cadastroacervo.Text = "CADASTRO ACERVO"
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.BackColor = Color.MediumPurple
        ToolStrip1.ImageScalingSize = New Size(24, 24)
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripLabel1, ToolStripSeparator1, txt_livrobusc, btn_buscaracervo})
        ToolStrip1.Location = New Point(0, 24)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(1061, 31)
        ToolStrip1.TabIndex = 35
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' ToolStripLabel1
        ' 
        ToolStripLabel1.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ToolStripLabel1.ForeColor = Color.White
        ToolStripLabel1.Name = "ToolStripLabel1"
        ToolStripLabel1.Size = New Size(126, 28)
        ToolStripLabel1.Text = "PESQUISAR LIVRO"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 31)
        ' 
        ' txt_livrobusc
        ' 
        txt_livrobusc.Name = "txt_livrobusc"
        txt_livrobusc.Size = New Size(100, 31)
        ' 
        ' btn_buscaracervo
        ' 
        btn_buscaracervo.DisplayStyle = ToolStripItemDisplayStyle.Image
        btn_buscaracervo.Image = CType(resources.GetObject("btn_buscaracervo.Image"), Image)
        btn_buscaracervo.ImageTransparentColor = Color.Magenta
        btn_buscaracervo.Name = "btn_buscaracervo"
        btn_buscaracervo.Size = New Size(28, 28)
        btn_buscaracervo.Text = "ToolStripButton1"
        ' 
        ' frm_acervo
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1061, 480)
        Controls.Add(ToolStrip1)
        Controls.Add(MenuStrip2)
        Controls.Add(Label2)
        Controls.Add(PictureBox2)
        Controls.Add(btn_menu)
        Controls.Add(dgv_acervo)
        Margin = New Padding(3, 2, 3, 2)
        Name = "frm_acervo"
        Text = "frm_acervo"
        CType(dgv_acervo, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip2.ResumeLayout(False)
        MenuStrip2.PerformLayout()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgv_acervo As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewImageColumn
    Friend WithEvents Column7 As DataGridViewImageColumn
    Friend WithEvents btn_menu As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ts_menu As ToolStripMenuItem
    Friend WithEvents ts_cadastroacervo As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents txt_livrobusc As ToolStripTextBox
    Friend WithEvents btn_buscaracervo As ToolStripButton
End Class
