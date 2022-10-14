<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPlayers
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
        Me.txtNumPlayers = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNumPlayers
        '
        Me.txtNumPlayers.Location = New System.Drawing.Point(114, 101)
        Me.txtNumPlayers.Name = "txtNumPlayers"
        Me.txtNumPlayers.Size = New System.Drawing.Size(159, 26)
        Me.txtNumPlayers.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter the Number of Players to be added:"
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(52, 147)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(120, 40)
        Me.btnContinue.TabIndex = 2
        Me.btnContinue.Text = "Co&ntinue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(229, 147)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(120, 40)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'AddPlayers
        '
        Me.AcceptButton = Me.btnContinue
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(384, 259)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNumPlayers)
        Me.Name = "AddPlayers"
        Me.Text = "AddPlayers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNumPlayers As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnContinue As Button
    Friend WithEvents btnCancel As Button
End Class
