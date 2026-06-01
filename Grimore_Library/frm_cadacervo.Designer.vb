<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadacervo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cadacervo))
        foto_livro = New PrintPreviewDialog()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        img_capa = New PictureBox()
        Label11 = New Label()
        txt_etiqueta = New TextBox()
        txt_isbn = New MaskedTextBox()
        txt_quantidade = New TextBox()
        btn_salvar = New Button()
        txt_notacao = New TextBox()
        Label10 = New Label()
        txt_pha = New TextBox()
        txt_titulo = New TextBox()
        Label9 = New Label()
        Label6 = New Label()
        txt_autor = New TextBox()
        Label8 = New Label()
        cmb_area = New ComboBox()
        txt_editora = New TextBox()
        Label7 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        MenuStrip2 = New MenuStrip()
        ts_menu = New ToolStripMenuItem()
        ts_acervo = New ToolStripMenuItem()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(img_capa, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip2.SuspendLayout()
        SuspendLayout()
        ' 
        ' foto_livro
        ' 
        foto_livro.AutoScrollMargin = New Size(0, 0)
        foto_livro.AutoScrollMinSize = New Size(0, 0)
        foto_livro.ClientSize = New Size(400, 300)
        foto_livro.Enabled = True
        foto_livro.Icon = CType(resources.GetObject("foto_livro.Icon"), Icon)
        foto_livro.Name = "foto_livro"
        foto_livro.Visible = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImageLayout = ImageLayout.None
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(766, 333)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(94, 83)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 21
        PictureBox2.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(img_capa)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(txt_etiqueta)
        Panel1.Controls.Add(txt_isbn)
        Panel1.Controls.Add(txt_quantidade)
        Panel1.Controls.Add(btn_salvar)
        Panel1.Controls.Add(txt_notacao)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(txt_pha)
        Panel1.Controls.Add(txt_titulo)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(txt_autor)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(cmb_area)
        Panel1.Controls.Add(txt_editora)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label4)
        Panel1.Font = New Font("Sylfaen", 12F)
        Panel1.Location = New Point(66, 31)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(687, 542)
        Panel1.TabIndex = 22
        ' 
        ' img_capa
        ' 
        img_capa.BackColor = Color.Gray
        img_capa.Location = New Point(439, 116)
        img_capa.Margin = New Padding(3, 2, 3, 2)
        img_capa.Name = "img_capa"
        img_capa.Size = New Size(211, 249)
        img_capa.TabIndex = 52
        img_capa.TabStop = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Cooper Black", 15.75F)
        Label11.Location = New Point(35, 32)
        Label11.Name = "Label11"
        Label11.Size = New Size(275, 24)
        Label11.TabIndex = 51
        Label11.Text = "CADASTRO DE ACERVO"
        ' 
        ' txt_etiqueta
        ' 
        txt_etiqueta.BackColor = Color.Gainsboro
        txt_etiqueta.Location = New Point(32, 415)
        txt_etiqueta.Multiline = True
        txt_etiqueta.Name = "txt_etiqueta"
        txt_etiqueta.Size = New Size(118, 72)
        txt_etiqueta.TabIndex = 50
        ' 
        ' txt_isbn
        ' 
        txt_isbn.BackColor = Color.Gainsboro
        txt_isbn.Location = New Point(251, 269)
        txt_isbn.Margin = New Padding(3, 2, 3, 2)
        txt_isbn.Mask = "000-00-000-00-0"
        txt_isbn.Name = "txt_isbn"
        txt_isbn.Size = New Size(150, 29)
        txt_isbn.TabIndex = 49
        ' 
        ' txt_quantidade
        ' 
        txt_quantidade.BackColor = Color.Gainsboro
        txt_quantidade.Location = New Point(248, 328)
        txt_quantidade.Name = "txt_quantidade"
        txt_quantidade.Size = New Size(106, 29)
        txt_quantidade.TabIndex = 48
        ' 
        ' btn_salvar
        ' 
        btn_salvar.BackColor = Color.MediumPurple
        btn_salvar.Font = New Font("Sylfaen", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_salvar.ForeColor = Color.White
        btn_salvar.Location = New Point(458, 399)
        btn_salvar.Name = "btn_salvar"
        btn_salvar.Size = New Size(159, 50)
        btn_salvar.TabIndex = 47
        btn_salvar.Text = "Salvar"
        btn_salvar.UseVisualStyleBackColor = False
        ' 
        ' txt_notacao
        ' 
        txt_notacao.BackColor = Color.Gainsboro
        txt_notacao.Location = New Point(176, 416)
        txt_notacao.Multiline = True
        txt_notacao.Name = "txt_notacao"
        txt_notacao.Size = New Size(135, 31)
        txt_notacao.TabIndex = 44
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.MediumPurple
        Label10.Font = New Font("Cooper Black", 12F)
        Label10.ForeColor = Color.White
        Label10.Location = New Point(478, 81)
        Label10.Name = "Label10"
        Label10.Size = New Size(119, 19)
        Label10.TabIndex = 45
        Label10.Text = "Capa do livro"
        ' 
        ' txt_pha
        ' 
        txt_pha.BackColor = Color.Gainsboro
        txt_pha.Location = New Point(35, 327)
        txt_pha.Name = "txt_pha"
        txt_pha.Size = New Size(155, 29)
        txt_pha.TabIndex = 43
        ' 
        ' txt_titulo
        ' 
        txt_titulo.BackColor = Color.Gainsboro
        txt_titulo.Font = New Font("Courier New", 9.75F, FontStyle.Bold)
        txt_titulo.Location = New Point(35, 108)
        txt_titulo.Name = "txt_titulo"
        txt_titulo.Size = New Size(268, 22)
        txt_titulo.TabIndex = 26
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.MediumPurple
        Label9.Font = New Font("Cooper Black", 12F)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(253, 244)
        Label9.Name = "Label9"
        Label9.Size = New Size(50, 19)
        Label9.TabIndex = 41
        Label9.Text = "ISBN"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.MediumPurple
        Label6.Font = New Font("Cooper Black", 12F)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(176, 381)
        Label6.Name = "Label6"
        Label6.Size = New Size(149, 19)
        Label6.TabIndex = 36
        Label6.Text = "Notação do autor"
        ' 
        ' txt_autor
        ' 
        txt_autor.BackColor = Color.Gainsboro
        txt_autor.Font = New Font("Courier New", 9.75F, FontStyle.Bold)
        txt_autor.Location = New Point(35, 158)
        txt_autor.Name = "txt_autor"
        txt_autor.Size = New Size(268, 22)
        txt_autor.TabIndex = 27
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.MediumPurple
        Label8.Font = New Font("Cooper Black", 12F)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(35, 185)
        Label8.Name = "Label8"
        Label8.Size = New Size(71, 19)
        Label8.TabIndex = 39
        Label8.Text = "Editora"
        ' 
        ' cmb_area
        ' 
        cmb_area.BackColor = Color.Gainsboro
        cmb_area.Font = New Font("Courier New", 9.75F, FontStyle.Bold)
        cmb_area.FormattingEnabled = True
        cmb_area.Location = New Point(35, 269)
        cmb_area.Name = "cmb_area"
        cmb_area.Size = New Size(162, 24)
        cmb_area.TabIndex = 28
        ' 
        ' txt_editora
        ' 
        txt_editora.BackColor = Color.Gainsboro
        txt_editora.Font = New Font("Courier New", 9.75F, FontStyle.Bold)
        txt_editora.Location = New Point(35, 210)
        txt_editora.Name = "txt_editora"
        txt_editora.Size = New Size(268, 22)
        txt_editora.TabIndex = 38
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.MediumPurple
        Label7.Font = New Font("Cooper Black", 12F)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(35, 382)
        Label7.Name = "Label7"
        Label7.Size = New Size(78, 19)
        Label7.TabIndex = 37
        Label7.Text = "Etiqueta"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.MediumPurple
        Label1.Font = New Font("Cooper Black", 12F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(35, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 19)
        Label1.TabIndex = 31
        Label1.Text = "Título"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.MediumPurple
        Label2.Font = New Font("Cooper Black", 12F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(35, 133)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 19)
        Label2.TabIndex = 32
        Label2.Text = "Autor"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.MediumPurple
        Label5.Font = New Font("Cooper Black", 12F)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(38, 302)
        Label5.Name = "Label5"
        Label5.Size = New Size(107, 19)
        Label5.TabIndex = 35
        Label5.Text = "Código PHA"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.MediumPurple
        Label3.Font = New Font("Cooper Black", 12F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(35, 244)
        Label3.Name = "Label3"
        Label3.Size = New Size(189, 19)
        Label3.TabIndex = 33
        Label3.Text = "Area do conhecimento"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.MediumPurple
        Label4.Font = New Font("Cooper Black", 12F)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(248, 302)
        Label4.Name = "Label4"
        Label4.Size = New Size(103, 19)
        Label4.TabIndex = 34
        Label4.Text = "Quantidade"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' MenuStrip2
        ' 
        MenuStrip2.BackColor = Color.MediumPurple
        MenuStrip2.ImageScalingSize = New Size(20, 20)
        MenuStrip2.Items.AddRange(New ToolStripItem() {ts_menu, ts_acervo})
        MenuStrip2.Location = New Point(0, 0)
        MenuStrip2.Name = "MenuStrip2"
        MenuStrip2.Padding = New Padding(5, 2, 0, 2)
        MenuStrip2.Size = New Size(872, 24)
        MenuStrip2.TabIndex = 30
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
        ' ts_acervo
        ' 
        ts_acervo.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ts_acervo.ForeColor = Color.White
        ts_acervo.Name = "ts_acervo"
        ts_acervo.Size = New Size(155, 20)
        ts_acervo.Text = "GERENCIAR ACERVO"
        ' 
        ' frm_cadacervo
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(63), CByte(13), CByte(145))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(872, 562)
        Controls.Add(MenuStrip2)
        Controls.Add(Panel1)
        Controls.Add(PictureBox2)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frm_cadacervo"
        Text = "Cadastro de Acervo"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(img_capa, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip2.ResumeLayout(False)
        MenuStrip2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents foto_livro As PrintPreviewDialog
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_titulo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_notacao As TextBox
    Friend WithEvents txt_pha As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_editora As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_area As ComboBox
    Friend WithEvents txt_autor As TextBox
    Friend WithEvents btn_salvar As Button
    Friend WithEvents txt_quantidade As TextBox
    Friend WithEvents txt_isbn As MaskedTextBox
    Friend WithEvents txt_etiqueta As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents img_capa As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ts_menu As ToolStripMenuItem
    Friend WithEvents ts_acervo As ToolStripMenuItem
End Class
