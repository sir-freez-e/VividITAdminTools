<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LQAButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LTVButton = New System.Windows.Forms.Button()
        Me.ORSButton = New System.Windows.Forms.Button()
        Me.ODRButton = New System.Windows.Forms.Button()
        Me.SFCButton = New System.Windows.Forms.Button()
        Me.DSIMButton = New System.Windows.Forms.Button()
        Me.SHCButton = New System.Windows.Forms.Button()
        Me.GPUButton = New System.Windows.Forms.Button()
        Me.NRButton = New System.Windows.Forms.Button()
        Me.RWUButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1048, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.ToolStripMenuItem4})
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(46, 24)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreferencesToolStripMenuItem})
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(144, 26)
        Me.ToolStripMenuItem3.Text = "Options"
        '
        'PreferencesToolStripMenuItem
        '
        Me.PreferencesToolStripMenuItem.Name = "PreferencesToolStripMenuItem"
        Me.PreferencesToolStripMenuItem.Size = New System.Drawing.Size(168, 26)
        Me.PreferencesToolStripMenuItem.Text = "Preferences"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(144, 26)
        Me.ToolStripMenuItem4.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1, Me.CheckForUpdatesToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(217, 26)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(217, 26)
        Me.CheckForUpdatesToolStripMenuItem.Text = "Check for Updates "
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 592)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1048, 24)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.BackColor = System.Drawing.Color.Navy
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.ExitButton)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(661, 514)
        Me.Panel1.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 75)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(607, 359)
        Me.TextBox1.TabIndex = 6
        '
        'ExitButton
        '
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ExitButton.ForeColor = System.Drawing.Color.White
        Me.ExitButton.Location = New System.Drawing.Point(12, 472)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(94, 29)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(12, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(215, 28)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = ":: Vivid IT Admin Tools ::"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CheckBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CheckBox1.Location = New System.Drawing.Point(407, 474)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(244, 27)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Run with elevated privileges"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel2.Controls.Add(Me.LQAButton)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.LTVButton)
        Me.Panel2.Controls.Add(Me.ORSButton)
        Me.Panel2.Controls.Add(Me.ODRButton)
        Me.Panel2.Controls.Add(Me.SFCButton)
        Me.Panel2.Controls.Add(Me.DSIMButton)
        Me.Panel2.Controls.Add(Me.SHCButton)
        Me.Panel2.Controls.Add(Me.GPUButton)
        Me.Panel2.Controls.Add(Me.NRButton)
        Me.Panel2.Controls.Add(Me.RWUButton)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(679, 93)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(357, 479)
        Me.Panel2.TabIndex = 7
        '
        'LQAButton
        '
        Me.LQAButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.LQAButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LQAButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.LQAButton.FlatAppearance.BorderSize = 0
        Me.LQAButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LQAButton.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LQAButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LQAButton.Location = New System.Drawing.Point(0, 421)
        Me.LQAButton.Name = "LQAButton"
        Me.LQAButton.Size = New System.Drawing.Size(357, 29)
        Me.LQAButton.TabIndex = 23
        Me.LQAButton.Text = "Launch Quick Assist"
        Me.LQAButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.LQAButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(90, 379)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Remote Assistance Tools"
        '
        'LTVButton
        '
        Me.LTVButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.LTVButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LTVButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.LTVButton.FlatAppearance.BorderSize = 0
        Me.LTVButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LTVButton.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LTVButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LTVButton.Location = New System.Drawing.Point(0, 450)
        Me.LTVButton.Name = "LTVButton"
        Me.LTVButton.Size = New System.Drawing.Size(357, 29)
        Me.LTVButton.TabIndex = 21
        Me.LTVButton.Text = "Launch Teamviewer "
        Me.LTVButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.LTVButton.UseVisualStyleBackColor = True
        '
        'ORSButton
        '
        Me.ORSButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ORSButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.ORSButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.ORSButton.FlatAppearance.BorderSize = 0
        Me.ORSButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ORSButton.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ORSButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ORSButton.Location = New System.Drawing.Point(0, 203)
        Me.ORSButton.Name = "ORSButton"
        Me.ORSButton.Size = New System.Drawing.Size(357, 29)
        Me.ORSButton.TabIndex = 20
        Me.ORSButton.Text = "Outlook Repair Script"
        Me.ORSButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.ORSButton.UseVisualStyleBackColor = True
        '
        'ODRButton
        '
        Me.ODRButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ODRButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.ODRButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.ODRButton.FlatAppearance.BorderSize = 0
        Me.ODRButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ODRButton.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ODRButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ODRButton.Location = New System.Drawing.Point(0, 174)
        Me.ODRButton.Name = "ODRButton"
        Me.ODRButton.Size = New System.Drawing.Size(357, 29)
        Me.ODRButton.TabIndex = 19
        Me.ODRButton.Text = "One Drive Reset"
        Me.ODRButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.ODRButton.UseVisualStyleBackColor = True
        '
        'SFCButton
        '
        Me.SFCButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SFCButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.SFCButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.SFCButton.FlatAppearance.BorderSize = 0
        Me.SFCButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SFCButton.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SFCButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SFCButton.Location = New System.Drawing.Point(0, 145)
        Me.SFCButton.Name = "SFCButton"
        Me.SFCButton.Size = New System.Drawing.Size(357, 29)
        Me.SFCButton.TabIndex = 18
        Me.SFCButton.Text = "System Scan (SFC)"
        Me.SFCButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.SFCButton.UseVisualStyleBackColor = True
        '
        'DSIMButton
        '
        Me.DSIMButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.DSIMButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.DSIMButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.DSIMButton.FlatAppearance.BorderSize = 0
        Me.DSIMButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DSIMButton.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DSIMButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DSIMButton.Location = New System.Drawing.Point(0, 116)
        Me.DSIMButton.Name = "DSIMButton"
        Me.DSIMButton.Size = New System.Drawing.Size(357, 29)
        Me.DSIMButton.TabIndex = 17
        Me.DSIMButton.Text = "DSIM Check Health"
        Me.DSIMButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.DSIMButton.UseVisualStyleBackColor = True
        '
        'SHCButton
        '
        Me.SHCButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SHCButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.SHCButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.SHCButton.FlatAppearance.BorderSize = 0
        Me.SHCButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SHCButton.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SHCButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SHCButton.Location = New System.Drawing.Point(0, 87)
        Me.SHCButton.Name = "SHCButton"
        Me.SHCButton.Size = New System.Drawing.Size(357, 29)
        Me.SHCButton.TabIndex = 16
        Me.SHCButton.Text = "SCCM Health Check"
        Me.SHCButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.SHCButton.UseVisualStyleBackColor = True
        '
        'GPUButton
        '
        Me.GPUButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GPUButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.GPUButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.GPUButton.FlatAppearance.BorderSize = 0
        Me.GPUButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GPUButton.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GPUButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GPUButton.Location = New System.Drawing.Point(0, 58)
        Me.GPUButton.Name = "GPUButton"
        Me.GPUButton.Size = New System.Drawing.Size(357, 29)
        Me.GPUButton.TabIndex = 15
        Me.GPUButton.Text = "Group Policy Update"
        Me.GPUButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.GPUButton.UseVisualStyleBackColor = True
        '
        'NRButton
        '
        Me.NRButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.NRButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.NRButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.NRButton.FlatAppearance.BorderSize = 0
        Me.NRButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NRButton.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NRButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NRButton.Location = New System.Drawing.Point(0, 29)
        Me.NRButton.Name = "NRButton"
        Me.NRButton.Size = New System.Drawing.Size(357, 29)
        Me.NRButton.TabIndex = 14
        Me.NRButton.Text = "Network Reset"
        Me.NRButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.NRButton.UseVisualStyleBackColor = True
        '
        'RWUButton
        '
        Me.RWUButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.RWUButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.RWUButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.RWUButton.FlatAppearance.BorderSize = 0
        Me.RWUButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RWUButton.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RWUButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RWUButton.Location = New System.Drawing.Point(0, 0)
        Me.RWUButton.Name = "RWUButton"
        Me.RWUButton.Size = New System.Drawing.Size(357, 29)
        Me.RWUButton.TabIndex = 13
        Me.RWUButton.Text = "Reset Windows Update"
        Me.RWUButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.RWUButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(11, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Tools by Mawuli"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(682, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Handy First Aid Tools"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1048, 616)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vivid"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents PreferencesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CheckForUpdatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GPUButton As Button
    Friend WithEvents NRButton As Button
    Friend WithEvents RWUButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SHCButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ODRButton As Button
    Friend WithEvents SFCButton As Button
    Friend WithEvents DSIMButton As Button
    Friend WithEvents ORSButton As Button
    Friend WithEvents LQAButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents LTVButton As Button
    Friend WithEvents TextBox1 As TextBox
End Class
