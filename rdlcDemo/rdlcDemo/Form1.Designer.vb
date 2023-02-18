<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonCheck = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(347, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 75)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RDLC DEMO"
        '
        'ButtonCheck
        '
        Me.ButtonCheck.Location = New System.Drawing.Point(694, 58)
        Me.ButtonCheck.Name = "ButtonCheck"
        Me.ButtonCheck.Size = New System.Drawing.Size(182, 53)
        Me.ButtonCheck.TabIndex = 1
        Me.ButtonCheck.Text = "Check"
        Me.ButtonCheck.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(21, 129)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1489, 819)
        Me.ReportViewer1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1538, 980)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.ButtonCheck)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonCheck As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer

End Class
