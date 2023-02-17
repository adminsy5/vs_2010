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
        Me.TextBoxPolicyNumber = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.ComboBoxPolicyType = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxPremiumofAmt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxNoOfYear = New System.Windows.Forms.TextBox()
        Me.LabelPolicyType = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxPolicyHolderName = New System.Windows.Forms.TextBox()
        Me.DataGridViewReader = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewReader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(316, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Policy Number"
        '
        'TextBoxPolicyNumber
        '
        Me.TextBoxPolicyNumber.Location = New System.Drawing.Point(520, 150)
        Me.TextBoxPolicyNumber.Name = "TextBoxPolicyNumber"
        Me.TextBoxPolicyNumber.Size = New System.Drawing.Size(293, 31)
        Me.TextBoxPolicyNumber.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ButtonSave)
        Me.GroupBox1.Controls.Add(Me.ButtonUpdate)
        Me.GroupBox1.Controls.Add(Me.ButtonClear)
        Me.GroupBox1.Controls.Add(Me.ButtonDelete)
        Me.GroupBox1.Controls.Add(Me.ButtonRefresh)
        Me.GroupBox1.Controls.Add(Me.ComboBoxPolicyType)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBoxPremiumofAmt)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBoxNoOfYear)
        Me.GroupBox1.Controls.Add(Me.LabelPolicyType)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxPolicyHolderName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxPolicyNumber)
        Me.GroupBox1.Location = New System.Drawing.Point(68, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1764, 692)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "March/April 2018"
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(723, 391)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(138, 46)
        Me.ButtonSave.TabIndex = 14
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(1466, 568)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(138, 46)
        Me.ButtonUpdate.TabIndex = 13
        Me.ButtonUpdate.Text = "Update"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(1057, 483)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(138, 46)
        Me.ButtonClear.TabIndex = 12
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(95, 568)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(138, 46)
        Me.ButtonDelete.TabIndex = 11
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Location = New System.Drawing.Point(406, 483)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(138, 46)
        Me.ButtonRefresh.TabIndex = 4
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'ComboBoxPolicyType
        '
        Me.ComboBoxPolicyType.FormattingEnabled = True
        Me.ComboBoxPolicyType.Items.AddRange(New Object() {"- Choose Item -", "Health", "Life Insurance", "General"})
        Me.ComboBoxPolicyType.Location = New System.Drawing.Point(759, 303)
        Me.ComboBoxPolicyType.Name = "ComboBoxPolicyType"
        Me.ComboBoxPolicyType.Size = New System.Drawing.Size(217, 33)
        Me.ComboBoxPolicyType.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(893, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(203, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Premium Of Amount"
        '
        'TextBoxPremiumofAmt
        '
        Me.TextBoxPremiumofAmt.Location = New System.Drawing.Point(1132, 150)
        Me.TextBoxPremiumofAmt.Name = "TextBoxPremiumofAmt"
        Me.TextBoxPremiumofAmt.Size = New System.Drawing.Size(209, 31)
        Me.TextBoxPremiumofAmt.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(977, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "No Of Year"
        '
        'TextBoxNoOfYear
        '
        Me.TextBoxNoOfYear.Location = New System.Drawing.Point(1132, 210)
        Me.TextBoxNoOfYear.Name = "TextBoxNoOfYear"
        Me.TextBoxNoOfYear.Size = New System.Drawing.Size(209, 31)
        Me.TextBoxNoOfYear.TabIndex = 7
        '
        'LabelPolicyType
        '
        Me.LabelPolicyType.AutoSize = True
        Me.LabelPolicyType.Location = New System.Drawing.Point(614, 311)
        Me.LabelPolicyType.Name = "LabelPolicyType"
        Me.LabelPolicyType.Size = New System.Drawing.Size(124, 25)
        Me.LabelPolicyType.TabIndex = 4
        Me.LabelPolicyType.Text = "Policy Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(266, 228)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Policy Holder Name"
        '
        'TextBoxPolicyHolderName
        '
        Me.TextBoxPolicyHolderName.Location = New System.Drawing.Point(520, 222)
        Me.TextBoxPolicyHolderName.Name = "TextBoxPolicyHolderName"
        Me.TextBoxPolicyHolderName.Size = New System.Drawing.Size(293, 31)
        Me.TextBoxPolicyHolderName.TabIndex = 3
        '
        'DataGridViewReader
        '
        Me.DataGridViewReader.AllowUserToAddRows = False
        Me.DataGridViewReader.AllowUserToDeleteRows = False
        Me.DataGridViewReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewReader.Location = New System.Drawing.Point(68, 778)
        Me.DataGridViewReader.Name = "DataGridViewReader"
        Me.DataGridViewReader.ReadOnly = True
        Me.DataGridViewReader.RowTemplate.Height = 33
        Me.DataGridViewReader.Size = New System.Drawing.Size(1764, 223)
        Me.DataGridViewReader.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Coral
        Me.Label6.Location = New System.Drawing.Point(652, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(351, 51)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Insurance Policy "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1906, 1053)
        Me.Controls.Add(Me.DataGridViewReader)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "InsurancePolicy"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewReader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPolicyNumber As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonUpdate As System.Windows.Forms.Button
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonRefresh As System.Windows.Forms.Button
    Friend WithEvents ComboBoxPolicyType As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPremiumofAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNoOfYear As System.Windows.Forms.TextBox
    Friend WithEvents LabelPolicyType As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPolicyHolderName As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewReader As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
