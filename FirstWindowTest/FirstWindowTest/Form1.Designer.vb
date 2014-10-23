<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FirstWindow
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
        Me.PressMe = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PressMe
        'Adding Text will it add to Project?
        '
        Me.PressMe.Location = New System.Drawing.Point(185, 171)
        Me.PressMe.Name = "PressMe"
        Me.PressMe.Size = New System.Drawing.Size(75, 23)
        Me.PressMe.TabIndex = 0
        Me.PressMe.Text = "Press"
        Me.PressMe.UseVisualStyleBackColor = True
        '
        'FirstWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 370)
        Me.Controls.Add(Me.PressMe)
        Me.Name = "FirstWindow"
        Me.Text = "Press Me"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PressMe As System.Windows.Forms.Button

End Class
