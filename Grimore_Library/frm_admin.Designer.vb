<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_admin))
        dgv_admin = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewComboBoxColumn()
        Column7 = New DataGridViewImageColumn()
        Column8 = New DataGridViewImageColumn()
        Label1 = New Label()
        Panel1 = New Panel()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Panel2 = New Panel()
        MenuStrip1 = New MenuStrip()
        ts_menu = New ToolStripMenuItem()
        ts_caduser = New ToolStripMenuItem()
        ToolStrip1 = New ToolStrip()
        ToolStripLabel1 = New ToolStripLabel()
        ToolStripSeparator1 = New ToolStripSeparator()
        txt_matriculabusc = New ToolStripTextBox()
        btn_buscar = New ToolStripButton()
        CType(dgv_admin, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        MenuStrip1.SuspendLayout()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgv_admin
        ' 
        dgv_admin.AllowUserToAddRows = False
        dgv_admin.AllowUserToDeleteRows = False
        dgv_admin.BackgroundColor = Color.DarkSlateBlue
        dgv_admin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_admin.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8})
        dgv_admin.GridColor = Color.Black
        dgv_admin.Location = New Point(13, 143)
        dgv_admin.Margin = New Padding(2, 3, 2, 3)
        dgv_admin.Name = "dgv_admin"
        dgv_admin.ReadOnly = True
        dgv_admin.RowHeadersWidth = 62
        dgv_admin.Size = New Size(1408, 352)
        dgv_admin.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "NOME"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 150
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "MATRICULA"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 150
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "SENHA"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 150
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "RESPOSTA"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 150
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "TIPO"
        Column5.MinimumWidth = 8
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Resizable = DataGridViewTriState.True
        Column5.Width = 150
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "STATUS"
        Column6.MinimumWidth = 8
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Resizable = DataGridViewTriState.True
        Column6.SortMode = DataGridViewColumnSortMode.Automatic
        Column6.Width = 150
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "EDITAR"
        Column7.Image = CType(resources.GetObject("Column7.Image"), Image)
        Column7.MinimumWidth = 8
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Resizable = DataGridViewTriState.True
        Column7.SortMode = DataGridViewColumnSortMode.Automatic
        Column7.Width = 150
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "EXCLUIR"
        Column8.Image = CType(resources.GetObject("Column8.Image"), Image)
        Column8.MinimumWidth = 8
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Resizable = DataGridViewTriState.True
        Column8.SortMode = DataGridViewColumnSortMode.Automatic
        Column8.Width = 150
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cooper Black", 21.75F)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(307, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(663, 42)
        Label1.TabIndex = 2
        Label1.Text = "GERENCIAMENTO DE USUARIOS"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Thistle
        Panel1.Controls.Add(TextBox1)
        Panel1.Location = New Point(464, 516)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(459, 75)
        Panel1.TabIndex = 3
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox1.BackColor = Color.Thistle
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(0, 23)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(459, 31)
        TextBox1.TabIndex = 0
        TextBox1.Text = "Usuario alterado com sucesso!"
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox2
        ' 
        TextBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox2.BackColor = Color.Thistle
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Font = New Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(3, 23)
        TextBox2.Margin = New Padding(3, 4, 3, 4)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(459, 31)
        TextBox2.TabIndex = 0
        TextBox2.Text = "Usuario deletado com sucesso!"
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Thistle
        Panel2.Controls.Add(TextBox2)
        Panel2.Location = New Point(461, 516)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(459, 75)
        Panel2.TabIndex = 4
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.MediumPurple
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ts_menu, ts_caduser})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(6, 3, 0, 3)
        MenuStrip1.Size = New Size(1446, 30)
        MenuStrip1.TabIndex = 30
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ts_menu
        ' 
        ts_menu.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ts_menu.ForeColor = Color.White
        ts_menu.Name = "ts_menu"
        ts_menu.Size = New Size(69, 24)
        ts_menu.Text = "MENU"
        ' 
        ' ts_caduser
        ' 
        ts_caduser.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ts_caduser.ForeColor = Color.White
        ts_caduser.Name = "ts_caduser"
        ts_caduser.Size = New Size(216, 24)
        ts_caduser.Text = "CADASTRAR USUARIOS"
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.BackColor = Color.MediumPurple
        ToolStrip1.ImageScalingSize = New Size(24, 24)
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripLabel1, ToolStripSeparator1, txt_matriculabusc, btn_buscar})
        ToolStrip1.Location = New Point(0, 30)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(1446, 31)
        ToolStrip1.TabIndex = 31
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' ToolStripLabel1
        ' 
        ToolStripLabel1.Name = "ToolStripLabel1"
        ToolStripLabel1.Size = New Size(168, 28)
        ToolStripLabel1.Text = "PESQUISAR MATRICULA"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 31)
        ' 
        ' txt_matriculabusc
        ' 
        txt_matriculabusc.Name = "txt_matriculabusc"
        txt_matriculabusc.Size = New Size(114, 31)
        ' 
        ' btn_buscar
        ' 
        btn_buscar.DisplayStyle = ToolStripItemDisplayStyle.Image
        btn_buscar.Image = CType(resources.GetObject("btn_buscar.Image"), Image)
        btn_buscar.ImageTransparentColor = Color.Magenta
        btn_buscar.Name = "btn_buscar"
        btn_buscar.Size = New Size(29, 28)
        btn_buscar.Text = "ToolStripButton1"
        ' 
        ' frm_admin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSlateBlue
        ClientSize = New Size(1446, 608)
        Controls.Add(ToolStrip1)
        Controls.Add(MenuStrip1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(dgv_admin)
        Margin = New Padding(2, 3, 2, 3)
        Name = "frm_admin"
        Text = "administrador"
        CType(dgv_admin, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgv_admin As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewComboBoxColumn
    Friend WithEvents Column7 As DataGridViewImageColumn
    Friend WithEvents Column8 As DataGridViewImageColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ts_menu As ToolStripMenuItem
    Friend WithEvents ts_caduser As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents txt_matriculabusc As ToolStripTextBox
    Friend WithEvents btn_buscar As ToolStripButton
End Class
