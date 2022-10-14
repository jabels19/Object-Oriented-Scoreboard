<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstNames = New System.Windows.Forms.ListBox()
        Me.btnAddPlayer = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnViewPoints = New System.Windows.Forms.Button()
        Me.btnAddPoints = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPlayerPoints = New System.Windows.Forms.Label()
        Me.lblTotalPoints = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(686, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(164, 34)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Player From List"
        '
        'lstNames
        '
        Me.lstNames.FormattingEnabled = True
        Me.lstNames.ItemHeight = 20
        Me.lstNames.Location = New System.Drawing.Point(16, 82)
        Me.lstNames.Name = "lstNames"
        Me.lstNames.Size = New System.Drawing.Size(248, 224)
        Me.lstNames.TabIndex = 2
        '
        'btnAddPlayer
        '
        Me.btnAddPlayer.Location = New System.Drawing.Point(16, 345)
        Me.btnAddPlayer.Name = "btnAddPlayer"
        Me.btnAddPlayer.Size = New System.Drawing.Size(127, 43)
        Me.btnAddPlayer.TabIndex = 3
        Me.btnAddPlayer.Text = "A&dd Player"
        Me.ToolTip1.SetToolTip(Me.btnAddPlayer, "Click to add a player to list")
        Me.btnAddPlayer.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(169, 345)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(95, 43)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnViewPoints
        '
        Me.btnViewPoints.Location = New System.Drawing.Point(307, 116)
        Me.btnViewPoints.Name = "btnViewPoints"
        Me.btnViewPoints.Size = New System.Drawing.Size(108, 43)
        Me.btnViewPoints.TabIndex = 5
        Me.btnViewPoints.Text = "&Player Points"
        Me.ToolTip2.SetToolTip(Me.btnViewPoints, "Shows the number of points scored by a player")
        Me.btnViewPoints.UseVisualStyleBackColor = True
        '
        'btnAddPoints
        '
        Me.btnAddPoints.Location = New System.Drawing.Point(307, 236)
        Me.btnAddPoints.Name = "btnAddPoints"
        Me.btnAddPoints.Size = New System.Drawing.Size(108, 43)
        Me.btnAddPoints.TabIndex = 6
        Me.btnAddPoints.Text = "&Add Point"
        Me.ToolTip3.SetToolTip(Me.btnAddPoints, "Adds a point to total points")
        Me.btnAddPoints.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(432, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Points by Player:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(432, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Total Points by Team:"
        '
        'lblPlayerPoints
        '
        Me.lblPlayerPoints.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPlayerPoints.Location = New System.Drawing.Point(470, 116)
        Me.lblPlayerPoints.Name = "lblPlayerPoints"
        Me.lblPlayerPoints.Size = New System.Drawing.Size(122, 40)
        Me.lblPlayerPoints.TabIndex = 9
        '
        'lblTotalPoints
        '
        Me.lblTotalPoints.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalPoints.Location = New System.Drawing.Point(470, 236)
        Me.lblTotalPoints.Name = "lblTotalPoints"
        Me.lblTotalPoints.Size = New System.Drawing.Size(122, 43)
        Me.lblTotalPoints.TabIndex = 10
        '
        'MainForm
        '
        Me.AcceptButton = Me.btnAddPoints
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(686, 450)
        Me.Controls.Add(Me.lblTotalPoints)
        Me.Controls.Add(Me.lblPlayerPoints)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAddPoints)
        Me.Controls.Add(Me.btnViewPoints)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAddPlayer)
        Me.Controls.Add(Me.lstNames)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "Score Keeper by Joel Black"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents lstNames As ListBox
    Friend WithEvents btnAddPlayer As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnViewPoints As Button
    Friend WithEvents btnAddPoints As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPlayerPoints As Label
    Friend WithEvents lblTotalPoints As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents ToolTip3 As ToolTip
End Class
