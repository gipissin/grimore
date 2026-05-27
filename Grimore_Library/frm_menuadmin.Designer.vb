<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_menuadmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_menuadmin))
        Label1 = New Label()
        Panel1 = New Panel()
        btn_gerusuario = New Button()
        btn_cadusuario = New Button()
        btn_menu = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(11, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(290, 24)
        Label1.TabIndex = 0
        Label1.Text = "MENU ADMINISTRATIVO"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btn_gerusuario)
        Panel1.Controls.Add(btn_cadusuario)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(91, 58)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(309, 358)
        Panel1.TabIndex = 1
        ' 
        ' btn_gerusuario
        ' 
        btn_gerusuario.BackColor = Color.BlueViolet
        btn_gerusuario.FlatStyle = FlatStyle.Flat
        btn_gerusuario.Font = New Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_gerusuario.ForeColor = Color.White
        btn_gerusuario.Location = New Point(30, 212)
        btn_gerusuario.Name = "btn_gerusuario"
        btn_gerusuario.Size = New Size(243, 66)
        btn_gerusuario.TabIndex = 8
        btn_gerusuario.Text = "GERENCIAR USUARIOS"
        btn_gerusuario.UseVisualStyleBackColor = False
        ' 
        ' btn_cadusuario
        ' 
        btn_cadusuario.BackColor = Color.BlueViolet
        btn_cadusuario.FlatStyle = FlatStyle.Flat
        btn_cadusuario.Font = New Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_cadusuario.ForeColor = Color.White
        btn_cadusuario.Location = New Point(30, 78)
        btn_cadusuario.Name = "btn_cadusuario"
        btn_cadusuario.Size = New Size(243, 75)
        btn_cadusuario.TabIndex = 7
        btn_cadusuario.Text = "CADASTRO DE USUARIOS" & vbCrLf
        btn_cadusuario.UseVisualStyleBackColor = False
        ' 
        ' btn_menu
        ' 
        btn_menu.BackColor = Color.Transparent
        btn_menu.Image = CType(resources.GetObject("btn_menu.Image"), Image)
        btn_menu.Location = New Point(421, 21)
        btn_menu.Name = "btn_menu"
        btn_menu.Size = New Size(80, 75)
        btn_menu.TabIndex = 8
        btn_menu.Text = vbCrLf
        btn_menu.UseVisualStyleBackColor = False
        ' 
        ' frm_menuadmin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(513, 471)
        Controls.Add(btn_menu)
        Controls.Add(Panel1)
        Name = "frm_menuadmin"
        Text = "frm_menuadmin"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_gerusuario As Button
    Friend WithEvents btn_cadusuario As Button
    Friend WithEvents btn_menu As Button
End Class
