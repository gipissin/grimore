<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_menu))
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        btn_admcontas = New Button()
        btn_senha = New Button()
        btn_devolucao = New Button()
        btn_emprestimo = New Button()
        btn_cadclientes = New Button()
        Label3 = New Label()
        Label1 = New Label()
        btn_acervo = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(828, 564)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(94, 83)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(btn_admcontas)
        Panel1.Controls.Add(btn_senha)
        Panel1.Controls.Add(btn_devolucao)
        Panel1.Controls.Add(btn_emprestimo)
        Panel1.Controls.Add(btn_cadclientes)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btn_acervo)
        Panel1.Location = New Point(188, 40)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(539, 567)
        Panel1.TabIndex = 10
        ' 
        ' btn_admcontas
        ' 
        btn_admcontas.BackColor = Color.BlueViolet
        btn_admcontas.FlatStyle = FlatStyle.Flat
        btn_admcontas.Font = New Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_admcontas.ForeColor = SystemColors.Window
        btn_admcontas.Location = New Point(80, 453)
        btn_admcontas.Name = "btn_admcontas"
        btn_admcontas.Size = New Size(379, 39)
        btn_admcontas.TabIndex = 11
        btn_admcontas.Text = "ADMINISTRATIVO"
        btn_admcontas.UseVisualStyleBackColor = False
        ' 
        ' btn_senha
        ' 
        btn_senha.BackColor = Color.BlueViolet
        btn_senha.FlatStyle = FlatStyle.Flat
        btn_senha.Font = New Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_senha.ForeColor = SystemColors.Window
        btn_senha.Location = New Point(80, 383)
        btn_senha.Name = "btn_senha"
        btn_senha.Size = New Size(379, 39)
        btn_senha.TabIndex = 10
        btn_senha.Text = "ALTERAR SENHA"
        btn_senha.UseVisualStyleBackColor = False
        ' 
        ' btn_devolucao
        ' 
        btn_devolucao.BackColor = Color.BlueViolet
        btn_devolucao.FlatStyle = FlatStyle.Flat
        btn_devolucao.Font = New Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_devolucao.ForeColor = SystemColors.Window
        btn_devolucao.Location = New Point(80, 311)
        btn_devolucao.Name = "btn_devolucao"
        btn_devolucao.Size = New Size(379, 39)
        btn_devolucao.TabIndex = 9
        btn_devolucao.Text = "DEVOLUÇÃO"
        btn_devolucao.UseVisualStyleBackColor = False
        ' 
        ' btn_emprestimo
        ' 
        btn_emprestimo.BackColor = Color.BlueViolet
        btn_emprestimo.FlatStyle = FlatStyle.Flat
        btn_emprestimo.Font = New Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_emprestimo.ForeColor = SystemColors.Window
        btn_emprestimo.Location = New Point(80, 238)
        btn_emprestimo.Name = "btn_emprestimo"
        btn_emprestimo.Size = New Size(379, 39)
        btn_emprestimo.TabIndex = 8
        btn_emprestimo.Text = "EMPRESTIMO"
        btn_emprestimo.UseVisualStyleBackColor = False
        ' 
        ' btn_cadclientes
        ' 
        btn_cadclientes.BackColor = Color.BlueViolet
        btn_cadclientes.FlatStyle = FlatStyle.Flat
        btn_cadclientes.Font = New Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_cadclientes.ForeColor = SystemColors.Window
        btn_cadclientes.Location = New Point(80, 170)
        btn_cadclientes.Name = "btn_cadclientes"
        btn_cadclientes.Size = New Size(379, 39)
        btn_cadclientes.TabIndex = 7
        btn_cadclientes.Text = "CADASTRO DE CLIENTES"
        btn_cadclientes.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(214, 41)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 34)
        Label3.TabIndex = 0
        Label3.Text = "MENU"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(25, 108)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 27)
        Label1.TabIndex = 1
        ' 
        ' btn_acervo
        ' 
        btn_acervo.BackColor = Color.BlueViolet
        btn_acervo.FlatStyle = FlatStyle.Flat
        btn_acervo.Font = New Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_acervo.ForeColor = Color.White
        btn_acervo.Location = New Point(80, 96)
        btn_acervo.Name = "btn_acervo"
        btn_acervo.Size = New Size(379, 39)
        btn_acervo.TabIndex = 6
        btn_acervo.Text = "ACERVO"
        btn_acervo.UseVisualStyleBackColor = False
        ' 
        ' Menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(945, 659)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Menu"
        Text = "Menu"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents botao_sobre As Button
    Private WithEvents botao_creditos As Button
    Private WithEvents botao_menu As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_verificar As Button
    Friend WithEvents btn_acervo As Button
    Friend WithEvents btn_cadclientes As Button
    Friend WithEvents btn_admcontas As Button
    Friend WithEvents btn_senha As Button
    Friend WithEvents btn_devolucao As Button
    Friend WithEvents btn_emprestimo As Button
    Friend WithEvents btn_resetsenha As LinkLabel
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents txt_usuario As TextBox
End Class
