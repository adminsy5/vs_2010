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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridViewReader = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonRp = New System.Windows.Forms.Button()
        Me.CheckBoxUnpaid = New System.Windows.Forms.CheckBox()
        Me.TextBoxFind = New System.Windows.Forms.TextBox()
        Me.TextBoxCourse = New System.Windows.Forms.TextBox()
        Me.DateTimePickerText = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxAmtPaid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxDuration = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxBalance = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxEno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonFind = New System.Windows.Forms.Button()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.DataGridViewReader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewReader
        '
        Me.DataGridViewReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewReader.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridViewReader.Location = New System.Drawing.Point(39, 660)
        Me.DataGridViewReader.Name = "DataGridViewReader"
        Me.DataGridViewReader.RowTemplate.Height = 33
        Me.DataGridViewReader.Size = New System.Drawing.Size(1246, 485)
        Me.DataGridViewReader.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(161, 76)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(160, 36)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(160, 36)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonRp)
        Me.GroupBox1.Controls.Add(Me.CheckBoxUnpaid)
        Me.GroupBox1.Controls.Add(Me.TextBoxFind)
        Me.GroupBox1.Controls.Add(Me.TextBoxCourse)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerText)
        Me.GroupBox1.Controls.Add(Me.TextBoxAmtPaid)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBoxDuration)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBoxBalance)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBoxName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxEno)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ButtonFind)
        Me.GroupBox1.Controls.Add(Me.ButtonRefresh)
        Me.GroupBox1.Controls.Add(Me.ButtonDelete)
        Me.GroupBox1.Controls.Add(Me.ButtonUpdate)
        Me.GroupBox1.Controls.Add(Me.ButtonClear)
        Me.GroupBox1.Controls.Add(Me.ButtonSave)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(1246, 529)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enrollment"
        '
        'ButtonRp
        '
        Me.ButtonRp.Location = New System.Drawing.Point(1036, 386)
        Me.ButtonRp.Name = "ButtonRp"
        Me.ButtonRp.Size = New System.Drawing.Size(152, 45)
        Me.ButtonRp.TabIndex = 25
        Me.ButtonRp.Text = "Report Gen."
        Me.ButtonRp.UseVisualStyleBackColor = True
        '
        'CheckBoxUnpaid
        '
        Me.CheckBoxUnpaid.AutoSize = True
        Me.CheckBoxUnpaid.Location = New System.Drawing.Point(843, 284)
        Me.CheckBoxUnpaid.Name = "CheckBoxUnpaid"
        Me.CheckBoxUnpaid.Size = New System.Drawing.Size(246, 29)
        Me.CheckBoxUnpaid.TabIndex = 24
        Me.CheckBoxUnpaid.Text = "Unpaid Fees Student"
        Me.CheckBoxUnpaid.UseVisualStyleBackColor = True
        '
        'TextBoxFind
        '
        Me.TextBoxFind.Location = New System.Drawing.Point(362, 346)
        Me.TextBoxFind.Name = "TextBoxFind"
        Me.TextBoxFind.Size = New System.Drawing.Size(362, 31)
        Me.TextBoxFind.TabIndex = 23
        '
        'TextBoxCourse
        '
        Me.TextBoxCourse.Location = New System.Drawing.Point(987, 77)
        Me.TextBoxCourse.Name = "TextBoxCourse"
        Me.TextBoxCourse.Size = New System.Drawing.Size(201, 31)
        Me.TextBoxCourse.TabIndex = 22
        '
        'DateTimePickerText
        '
        Me.DateTimePickerText.Location = New System.Drawing.Point(187, 197)
        Me.DateTimePickerText.Name = "DateTimePickerText"
        Me.DateTimePickerText.Size = New System.Drawing.Size(397, 31)
        Me.DateTimePickerText.TabIndex = 20
        '
        'TextBoxAmtPaid
        '
        Me.TextBoxAmtPaid.Location = New System.Drawing.Point(987, 195)
        Me.TextBoxAmtPaid.Name = "TextBoxAmtPaid"
        Me.TextBoxAmtPaid.Size = New System.Drawing.Size(201, 31)
        Me.TextBoxAmtPaid.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(722, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(189, 25)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "AMOUNT PAID (₹)"
        '
        'TextBoxDuration
        '
        Me.TextBoxDuration.Location = New System.Drawing.Point(987, 132)
        Me.TextBoxDuration.Name = "TextBoxDuration"
        Me.TextBoxDuration.Size = New System.Drawing.Size(201, 31)
        Me.TextBoxDuration.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(722, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(217, 25)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "DURATION (MONTH)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(722, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 25)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "COURSE"
        '
        'TextBoxBalance
        '
        Me.TextBoxBalance.Location = New System.Drawing.Point(516, 281)
        Me.TextBoxBalance.Name = "TextBoxBalance"
        Me.TextBoxBalance.Size = New System.Drawing.Size(222, 31)
        Me.TextBoxBalance.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(357, 284)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 25)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "BALANCE (₹)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(68, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "DATE"
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(187, 141)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(476, 31)
        Me.TextBoxName.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "NAME"
        '
        'TextBoxEno
        '
        Me.TextBoxEno.Location = New System.Drawing.Point(187, 83)
        Me.TextBoxEno.Name = "TextBoxEno"
        Me.TextBoxEno.Size = New System.Drawing.Size(242, 31)
        Me.TextBoxEno.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ENO"
        '
        'ButtonFind
        '
        Me.ButtonFind.Location = New System.Drawing.Point(462, 464)
        Me.ButtonFind.Name = "ButtonFind"
        Me.ButtonFind.Size = New System.Drawing.Size(152, 45)
        Me.ButtonFind.TabIndex = 5
        Me.ButtonFind.Text = "Find"
        Me.ButtonFind.UseVisualStyleBackColor = True
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Location = New System.Drawing.Point(787, 339)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(152, 45)
        Me.ButtonRefresh.TabIndex = 4
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(648, 422)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(152, 45)
        Me.ButtonDelete.TabIndex = 3
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(289, 422)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(152, 45)
        Me.ButtonUpdate.TabIndex = 2
        Me.ButtonUpdate.Text = "Update"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(1036, 464)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(152, 45)
        Me.ButtonClear.TabIndex = 1
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(135, 339)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(152, 45)
        Me.ButtonSave.TabIndex = 0
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.LightPink
        Me.Label8.Font = New System.Drawing.Font("Old English Text MT", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label8.Location = New System.Drawing.Point(356, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(1375, 51)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "SUTEX BANK OF COMPUTER APPLICATION & SCIENCE"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(1331, 125)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1511, 1020)
        Me.ReportViewer1.TabIndex = 21
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(2913, 1385)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridViewReader)
        Me.Name = "Form1"
        Me.Text = "Admin"
        CType(Me.DataGridViewReader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewReader As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePickerText As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBoxAmtPaid As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDuration As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBoxBalance As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxEno As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonFind As System.Windows.Forms.Button
    Friend WithEvents ButtonRefresh As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonUpdate As System.Windows.Forms.Button
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCourse As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxFind As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxUnpaid As System.Windows.Forms.CheckBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ButtonRp As System.Windows.Forms.Button

End Class
