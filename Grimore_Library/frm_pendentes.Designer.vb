<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_pendentes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_pendentes))
        dgv_pendentes = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewButtonColumn()
        Column7 = New DataGridViewButtonColumn()
        btn_voltar = New Button()
        MenuStrip1 = New MenuStrip()
        ts_menu = New ToolStripMenuItem()
        ts_geranciaruser = New ToolStripMenuItem()
        CType(dgv_pendentes, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgv_pendentes
        ' 
        dgv_pendentes.AllowUserToAddRows = False
        dgv_pendentes.AllowUserToDeleteRows = False
        dgv_pendentes.BackgroundColor = Color.MediumPurple
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Cooper Black", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgv_pendentes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgv_pendentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_pendentes.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7})
        dgv_pendentes.GridColor = Color.Black
        dgv_pendentes.Location = New Point(12, 48)
        dgv_pendentes.Name = "dgv_pendentes"
        dgv_pendentes.ReadOnly = True
        dgv_pendentes.Size = New Size(776, 288)
        dgv_pendentes.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "id_Emprestimo "
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "isbn"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "titulo"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "data limite"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "renovações"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "devolver"
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Resizable = DataGridViewTriState.True
        Column6.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "renovar"
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Resizable = DataGridViewTriState.True
        Column7.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' btn_voltar
        ' 
        btn_voltar.BackColor = Color.MediumPurple
        btn_voltar.Font = New Font("Cooper Black", 14.25F)
        btn_voltar.Location = New Point(624, 353)
        btn_voltar.Name = "btn_voltar"
        btn_voltar.Size = New Size(164, 68)
        btn_voltar.TabIndex = 12
        btn_voltar.Text = "voltar"
        btn_voltar.UseVisualStyleBackColor = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.MediumPurple
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ts_menu, ts_geranciaruser})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(5, 2, 0, 2)
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 30
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ts_menu
        ' 
        ts_menu.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ts_menu.ForeColor = Color.White
        ts_menu.Name = "ts_menu"
        ts_menu.Size = New Size(58, 20)
        ts_menu.Text = "MENU"
        ' 
        ' ts_geranciaruser
        ' 
        ts_geranciaruser.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ts_geranciaruser.ForeColor = Color.White
        ts_geranciaruser.Name = "ts_geranciaruser"
        ts_geranciaruser.Size = New Size(169, 20)
        ts_geranciaruser.Text = "SITUAÇÃO DO CLEINTE"
        ' 
        ' frm_pendentes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        Controls.Add(btn_voltar)
        Controls.Add(dgv_pendentes)
        Name = "frm_pendentes"
        Text = "PENDENCIAS CLIENTES"
        CType(dgv_pendentes, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgv_pendentes As DataGridView
    Friend WithEvents btn_voltar As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewButtonColumn
    Friend WithEvents Column7 As DataGridViewButtonColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ts_menu As ToolStripMenuItem
    Friend WithEvents ts_geranciaruser As ToolStripMenuItem
End Class
