<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPedidos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelPrincipal = New System.Windows.Forms.Panel()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.PanelBot = New System.Windows.Forms.Panel()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.ibEntrantes = New FontAwesome.Sharp.IconButton()
        Me.ibBebidas = New FontAwesome.Sharp.IconButton()
        Me.ibPrincipal = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PanelPrincipal)
        Me.Panel1.Controls.Add(Me.PanelTop)
        Me.Panel1.Controls.Add(Me.PanelBot)
        Me.Panel1.Controls.Add(Me.PanelMenu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1671, 749)
        Me.Panel1.TabIndex = 0
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPrincipal.Location = New System.Drawing.Point(230, 80)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(1441, 573)
        Me.PanelPrincipal.TabIndex = 4
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.MediumPurple
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(230, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(1441, 80)
        Me.PanelTop.TabIndex = 3
        '
        'PanelBot
        '
        Me.PanelBot.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.PanelBot.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBot.Location = New System.Drawing.Point(230, 653)
        Me.PanelBot.Name = "PanelBot"
        Me.PanelBot.Size = New System.Drawing.Size(1441, 96)
        Me.PanelBot.TabIndex = 2
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.SkyBlue
        Me.PanelMenu.Controls.Add(Me.ibEntrantes)
        Me.PanelMenu.Controls.Add(Me.ibBebidas)
        Me.PanelMenu.Controls.Add(Me.ibPrincipal)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(230, 749)
        Me.PanelMenu.TabIndex = 1
        '
        'ibEntrantes
        '
        Me.ibEntrantes.Dock = System.Windows.Forms.DockStyle.Top
        Me.ibEntrantes.FlatAppearance.BorderSize = 0
        Me.ibEntrantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ibEntrantes.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ibEntrantes.ForeColor = System.Drawing.Color.Black
        Me.ibEntrantes.IconChar = FontAwesome.Sharp.IconChar.Bacon
        Me.ibEntrantes.IconColor = System.Drawing.Color.Black
        Me.ibEntrantes.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ibEntrantes.IconSize = 45
        Me.ibEntrantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ibEntrantes.Location = New System.Drawing.Point(0, 208)
        Me.ibEntrantes.Name = "ibEntrantes"
        Me.ibEntrantes.Padding = New System.Windows.Forms.Padding(10, 0, 5, 0)
        Me.ibEntrantes.Size = New System.Drawing.Size(230, 104)
        Me.ibEntrantes.TabIndex = 5
        Me.ibEntrantes.Text = "      Entrantes"
        Me.ibEntrantes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ibEntrantes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ibEntrantes.UseVisualStyleBackColor = True
        '
        'ibBebidas
        '
        Me.ibBebidas.Dock = System.Windows.Forms.DockStyle.Top
        Me.ibBebidas.FlatAppearance.BorderSize = 0
        Me.ibBebidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ibBebidas.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ibBebidas.ForeColor = System.Drawing.Color.Black
        Me.ibBebidas.IconChar = FontAwesome.Sharp.IconChar.GlassCheers
        Me.ibBebidas.IconColor = System.Drawing.Color.Black
        Me.ibBebidas.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ibBebidas.IconSize = 50
        Me.ibBebidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ibBebidas.Location = New System.Drawing.Point(0, 104)
        Me.ibBebidas.Name = "ibBebidas"
        Me.ibBebidas.Padding = New System.Windows.Forms.Padding(10, 0, 5, 0)
        Me.ibBebidas.Size = New System.Drawing.Size(230, 104)
        Me.ibBebidas.TabIndex = 4
        Me.ibBebidas.Text = "      Bebidas"
        Me.ibBebidas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ibBebidas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ibBebidas.UseVisualStyleBackColor = True
        '
        'ibPrincipal
        '
        Me.ibPrincipal.Dock = System.Windows.Forms.DockStyle.Top
        Me.ibPrincipal.FlatAppearance.BorderSize = 0
        Me.ibPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ibPrincipal.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ibPrincipal.ForeColor = System.Drawing.Color.Black
        Me.ibPrincipal.IconChar = FontAwesome.Sharp.IconChar.Burger
        Me.ibPrincipal.IconColor = System.Drawing.Color.Black
        Me.ibPrincipal.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ibPrincipal.IconSize = 40
        Me.ibPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ibPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.ibPrincipal.Name = "ibPrincipal"
        Me.ibPrincipal.Padding = New System.Windows.Forms.Padding(10, 0, 5, 0)
        Me.ibPrincipal.Size = New System.Drawing.Size(230, 104)
        Me.ibPrincipal.TabIndex = 3
        Me.ibPrincipal.Text = "  Platos Principales"
        Me.ibPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ibPrincipal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ibPrincipal.UseVisualStyleBackColor = True
        '
        'FormPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1671, 749)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FormPedidos"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.PanelMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelBot As Panel
    Friend WithEvents PanelPrincipal As Panel
    Friend WithEvents PanelTop As Panel
    Friend WithEvents ibPrincipal As FontAwesome.Sharp.IconButton
    Friend WithEvents ibEntrantes As FontAwesome.Sharp.IconButton
    Friend WithEvents ibBebidas As FontAwesome.Sharp.IconButton
End Class
