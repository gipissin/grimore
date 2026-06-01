<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_gerenciarclientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_gerenciarclientes))
        dgv_clientes = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewButtonColumn()
        Column7 = New DataGridViewButtonColumn()
        MenuStrip1 = New MenuStrip()
        btn_cadastrarcliente = New ToolStripMenuItem()
        ts_menu = New ToolStripMenuItem()
        ToolStrip1 = New ToolStrip()
        ToolStripLabel1 = New ToolStripLabel()
        ToolStripSeparator1 = New ToolStripSeparator()
        txt_clientebusc = New ToolStripTextBox()
        btn_buscaracervo = New ToolStripButton()
        CType(dgv_clientes, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgv_clientes
        ' 
        dgv_clientes.AllowUserToAddRows = False
        dgv_clientes.AllowUserToDeleteRows = False
        dgv_clientes.BackgroundColor = Color.MediumPurple
        dgv_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_clientes.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7})
        dgv_clientes.GridColor = Color.MediumPurple
        dgv_clientes.Location = New Point(29, 85)
        dgv_clientes.Name = "dgv_clientes"
        dgv_clientes.ReadOnly = True
        dgv_clientes.Size = New Size(746, 343)
        dgv_clientes.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "ID"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Nome"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Email"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Telefone"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "CPF"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Editar"
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Excluir"
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.MediumPurple
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ts_menu, btn_cadastrarcliente})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(5, 2, 0, 2)
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 35
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' btn_cadastrarcliente
        ' 
        btn_cadastrarcliente.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_cadastrarcliente.ForeColor = Color.White
        btn_cadastrarcliente.Name = "btn_cadastrarcliente"
        btn_cadastrarcliente.Size = New Size(161, 20)
        btn_cadastrarcliente.Text = "CADASTRAR CLIENTE"
        ' 
        ' ts_menu
        ' 
        ts_menu.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ts_menu.ForeColor = Color.White
        ts_menu.Name = "ts_menu"
        ts_menu.Size = New Size(58, 20)
        ts_menu.Text = "MENU"
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.BackColor = Color.MediumPurple
        ToolStrip1.ImageScalingSize = New Size(24, 24)
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripLabel1, ToolStripSeparator1, txt_clientebusc, btn_buscaracervo})
        ToolStrip1.Location = New Point(0, 24)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(800, 31)
        ToolStrip1.TabIndex = 36
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' ToolStripLabel1
        ' 
        ToolStripLabel1.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ToolStripLabel1.ForeColor = Color.White
        ToolStripLabel1.Name = "ToolStripLabel1"
        ToolStripLabel1.Size = New Size(141, 28)
        ToolStripLabel1.Text = "PESQUISAR CLIENTE"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 31)
        ' 
        ' txt_clientebusc
        ' 
        txt_clientebusc.Name = "txt_clientebusc"
        txt_clientebusc.Size = New Size(100, 31)
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
        ' frm_gerenciarclientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(ToolStrip1)
        Controls.Add(MenuStrip1)
        Controls.Add(dgv_clientes)
        Name = "frm_gerenciarclientes"
        Text = "GERENCIAR CLIENTES"
        CType(dgv_clientes, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgv_clientes As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewButtonColumn
    Friend WithEvents Column7 As DataGridViewButtonColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ts_menu As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents txt_clientebusc As ToolStripTextBox
    Friend WithEvents btn_buscaracervo As ToolStripButton
    Friend WithEvents btn_cadastrarcliente As ToolStripMenuItem
End Class
