<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BanchouPatcher
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BanchouPatcher))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Origen = New System.Windows.Forms.TextBox()
        Me.Destino = New System.Windows.Forms.TextBox()
        Me.AbrirOrigen = New System.Windows.Forms.Button()
        Me.AbrirDestino = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Prefijo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DirDestino = New System.Windows.Forms.TextBox()
        Me.AbrirDirDestino = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Comprimir = New System.Windows.Forms.CheckBox()
        Me.Patch = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Estado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Origen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Destino"
        '
        'Origen
        '
        Me.Origen.Location = New System.Drawing.Point(87, 53)
        Me.Origen.Name = "Origen"
        Me.Origen.Size = New System.Drawing.Size(534, 23)
        Me.Origen.TabIndex = 2
        Me.Origen.Text = "Abrir archivo origen"
        '
        'Destino
        '
        Me.Destino.Location = New System.Drawing.Point(87, 89)
        Me.Destino.Name = "Destino"
        Me.Destino.Size = New System.Drawing.Size(534, 23)
        Me.Destino.TabIndex = 3
        Me.Destino.Text = "Abrir archivo destino"
        '
        'AbrirOrigen
        '
        Me.AbrirOrigen.Location = New System.Drawing.Point(629, 53)
        Me.AbrirOrigen.Name = "AbrirOrigen"
        Me.AbrirOrigen.Size = New System.Drawing.Size(34, 23)
        Me.AbrirOrigen.TabIndex = 4
        Me.AbrirOrigen.Text = "..."
        Me.AbrirOrigen.UseVisualStyleBackColor = True
        '
        'AbrirDestino
        '
        Me.AbrirDestino.Location = New System.Drawing.Point(629, 89)
        Me.AbrirDestino.Name = "AbrirDestino"
        Me.AbrirDestino.Size = New System.Drawing.Size(34, 23)
        Me.AbrirDestino.TabIndex = 5
        Me.AbrirDestino.Text = "..."
        Me.AbrirDestino.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 30)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nombre del" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "parche"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Prefijo
        '
        Me.Prefijo.Location = New System.Drawing.Point(87, 134)
        Me.Prefijo.Name = "Prefijo"
        Me.Prefijo.Size = New System.Drawing.Size(534, 23)
        Me.Prefijo.TabIndex = 7
        Me.Prefijo.Text = "Nombre del parche"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 30)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Directorio" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de destino"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DirDestino
        '
        Me.DirDestino.Location = New System.Drawing.Point(87, 179)
        Me.DirDestino.Name = "DirDestino"
        Me.DirDestino.Size = New System.Drawing.Size(534, 23)
        Me.DirDestino.TabIndex = 9
        Me.DirDestino.Text = "Abrir directorio destino"
        '
        'AbrirDirDestino
        '
        Me.AbrirDirDestino.Location = New System.Drawing.Point(629, 179)
        Me.AbrirDirDestino.Name = "AbrirDirDestino"
        Me.AbrirDirDestino.Size = New System.Drawing.Size(34, 23)
        Me.AbrirDirDestino.TabIndex = 10
        Me.AbrirDirDestino.Text = "..."
        Me.AbrirDirDestino.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(352, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Comprimir
        '
        Me.Comprimir.AutoSize = True
        Me.Comprimir.Location = New System.Drawing.Point(330, 227)
        Me.Comprimir.Name = "Comprimir"
        Me.Comprimir.Size = New System.Drawing.Size(325, 19)
        Me.Comprimir.TabIndex = 12
        Me.Comprimir.Text = "Comprimir archivos en .zip y borrar archivos intermedios"
        Me.Comprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Comprimir.UseVisualStyleBackColor = True
        '
        'Patch
        '
        Me.Patch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Patch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Patch.Location = New System.Drawing.Point(201, 276)
        Me.Patch.Name = "Patch"
        Me.Patch.Size = New System.Drawing.Size(281, 74)
        Me.Patch.TabIndex = 13
        Me.Patch.Text = "PATCH!!!1"
        Me.Patch.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Estado})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 382)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(682, 22)
        Me.StatusStrip1.TabIndex = 14
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Estado
        '
        Me.Estado.Name = "Estado"
        Me.Estado.Size = New System.Drawing.Size(35, 17)
        Me.Estado.Text = "Listo."
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(682, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de..."
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BanchouPatcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 404)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Patch)
        Me.Controls.Add(Me.Comprimir)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.AbrirDirDestino)
        Me.Controls.Add(Me.DirDestino)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Prefijo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.AbrirDestino)
        Me.Controls.Add(Me.AbrirOrigen)
        Me.Controls.Add(Me.Destino)
        Me.Controls.Add(Me.Origen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "BanchouPatcher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BanchouPatcher for Windows"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Origen As System.Windows.Forms.TextBox
    Friend WithEvents Destino As System.Windows.Forms.TextBox
    Friend WithEvents AbrirOrigen As System.Windows.Forms.Button
    Friend WithEvents AbrirDestino As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Prefijo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DirDestino As System.Windows.Forms.TextBox
    Friend WithEvents AbrirDirDestino As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Comprimir As System.Windows.Forms.CheckBox
    Friend WithEvents Patch As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Estado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog

End Class
