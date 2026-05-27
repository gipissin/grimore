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
        ToolStrip1 = New ToolStrip()
        ToolStripLabel1 = New ToolStripLabel()
        ToolStripSeparator1 = New ToolStripSeparator()
        txt_matriculabusc = New ToolStripTextBox()
        btn_buscar = New ToolStripButton()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewComboBoxColumn()
        Column7 = New DataGridViewImageColumn()
        Column8 = New DataGridViewImageColumn()
        CType(dgv_admin, ComponentModel.ISupportInitialize).BeginInit()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgv_admin
        ' 
        dgv_admin.BackgroundColor = Color.DarkSlateBlue
        dgv_admin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_admin.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8})
        dgv_admin.GridColor = Color.Black
        dgv_admin.Location = New Point(1, 105)
        dgv_admin.Margin = New Padding(2)
        dgv_admin.Name = "dgv_admin"
        dgv_admin.RowHeadersWidth = 62
        dgv_admin.Size = New Size(1267, 262)
        dgv_admin.TabIndex = 0
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.BackColor = Color.SlateBlue
        ToolStrip1.ImageScalingSize = New Size(24, 24)
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripLabel1, ToolStripSeparator1, txt_matriculabusc, btn_buscar})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(1268, 31)
        ToolStrip1.TabIndex = 1
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' ToolStripLabel1
        ' 
        ToolStripLabel1.Name = "ToolStripLabel1"
        ToolStripLabel1.Size = New Size(135, 28)
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
        txt_matriculabusc.Size = New Size(100, 31)
        ' 
        ' btn_buscar
        ' 
        btn_buscar.DisplayStyle = ToolStripItemDisplayStyle.Image
        btn_buscar.Image = CType(resources.GetObject("btn_buscar.Image"), Image)
        btn_buscar.ImageTransparentColor = Color.Magenta
        btn_buscar.Name = "btn_buscar"
        btn_buscar.Size = New Size(28, 28)
        btn_buscar.Text = "ToolStripButton1"
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "NOME"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.Width = 150
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "MATRICULA"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.Width = 150
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "SENHA"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.Width = 150
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "RESPOSTA"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.Width = 150
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "TIPO"
        Column5.MinimumWidth = 8
        Column5.Name = "Column5"
        Column5.Resizable = DataGridViewTriState.True
        Column5.Width = 150
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "STATUS"
        Column6.MinimumWidth = 8
        Column6.Name = "Column6"
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
        Column8.Resizable = DataGridViewTriState.True
        Column8.SortMode = DataGridViewColumnSortMode.Automatic
        Column8.Width = 150
        ' 
        ' frm_admin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSlateBlue
        ClientSize = New Size(1268, 368)
        Controls.Add(ToolStrip1)
        Controls.Add(dgv_admin)
        Margin = New Padding(2)
        Name = "frm_admin"
        Text = "administrador"
        CType(dgv_admin, ComponentModel.ISupportInitialize).EndInit()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgv_admin As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents txt_matriculabusc As ToolStripTextBox
    Friend WithEvents btn_buscar As ToolStripButton
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewComboBoxColumn
    Friend WithEvents Column7 As DataGridViewImageColumn
    Friend WithEvents Column8 As DataGridViewImageColumn
End Class
