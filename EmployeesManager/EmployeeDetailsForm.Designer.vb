<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmployeeDetailsForm
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
        Me.components = New System.ComponentModel.Container()
        Dim IdLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim ManagerLabel As System.Windows.Forms.Label
        Dim HireDateLabel As System.Windows.Forms.Label
        Dim SalaryLabel As System.Windows.Forms.Label
        Dim DepartmentIdLabel As System.Windows.Forms.Label
        Me.EmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.ManagerTextBox = New System.Windows.Forms.TextBox()
        Me.HireDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SalaryTextBox = New System.Windows.Forms.TextBox()
        Me.DepartmentIdTextBox = New System.Windows.Forms.TextBox()
        Me.OkButton = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        IdLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        ManagerLabel = New System.Windows.Forms.Label()
        HireDateLabel = New System.Windows.Forms.Label()
        SalaryLabel = New System.Windows.Forms.Label()
        DepartmentIdLabel = New System.Windows.Forms.Label()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(35, 40)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(27, 20)
        IdLabel.TabIndex = 1
        IdLabel.Text = "Id:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(35, 72)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(55, 20)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Name:"
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(35, 104)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(42, 20)
        TitleLabel.TabIndex = 5
        TitleLabel.Text = "Title:"
        '
        'ManagerLabel
        '
        ManagerLabel.AutoSize = True
        ManagerLabel.Location = New System.Drawing.Point(35, 136)
        ManagerLabel.Name = "ManagerLabel"
        ManagerLabel.Size = New System.Drawing.Size(76, 20)
        ManagerLabel.TabIndex = 7
        ManagerLabel.Text = "Manager:"
        '
        'HireDateLabel
        '
        HireDateLabel.AutoSize = True
        HireDateLabel.Location = New System.Drawing.Point(35, 169)
        HireDateLabel.Name = "HireDateLabel"
        HireDateLabel.Size = New System.Drawing.Size(81, 20)
        HireDateLabel.TabIndex = 9
        HireDateLabel.Text = "Hire Date:"
        '
        'SalaryLabel
        '
        SalaryLabel.AutoSize = True
        SalaryLabel.Location = New System.Drawing.Point(35, 200)
        SalaryLabel.Name = "SalaryLabel"
        SalaryLabel.Size = New System.Drawing.Size(57, 20)
        SalaryLabel.TabIndex = 11
        SalaryLabel.Text = "Salary:"
        '
        'DepartmentIdLabel
        '
        DepartmentIdLabel.AutoSize = True
        DepartmentIdLabel.Location = New System.Drawing.Point(35, 232)
        DepartmentIdLabel.Name = "DepartmentIdLabel"
        DepartmentIdLabel.Size = New System.Drawing.Size(116, 20)
        DepartmentIdLabel.TabIndex = 13
        DepartmentIdLabel.Text = "Department Id:"
        '
        'EmployeesBindingSource
        '
        Me.EmployeesBindingSource.DataSource = GetType(EmployeesManager.ObservableListSource(Of EmployeesManager.Employee))
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(157, 37)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(200, 26)
        Me.IdTextBox.TabIndex = 2
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(157, 69)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(200, 26)
        Me.NameTextBox.TabIndex = 4
        '
        'TitleTextBox
        '
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Title", True))
        Me.TitleTextBox.Location = New System.Drawing.Point(157, 101)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(200, 26)
        Me.TitleTextBox.TabIndex = 6
        '
        'ManagerTextBox
        '
        Me.ManagerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Manager", True))
        Me.ManagerTextBox.Location = New System.Drawing.Point(157, 133)
        Me.ManagerTextBox.Name = "ManagerTextBox"
        Me.ManagerTextBox.Size = New System.Drawing.Size(200, 26)
        Me.ManagerTextBox.TabIndex = 8
        '
        'HireDateDateTimePicker
        '
        Me.HireDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmployeesBindingSource, "HireDate", True))
        Me.HireDateDateTimePicker.Location = New System.Drawing.Point(157, 165)
        Me.HireDateDateTimePicker.Name = "HireDateDateTimePicker"
        Me.HireDateDateTimePicker.Size = New System.Drawing.Size(200, 26)
        Me.HireDateDateTimePicker.TabIndex = 10
        '
        'SalaryTextBox
        '
        Me.SalaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Salary", True))
        Me.SalaryTextBox.Location = New System.Drawing.Point(157, 197)
        Me.SalaryTextBox.Name = "SalaryTextBox"
        Me.SalaryTextBox.Size = New System.Drawing.Size(200, 26)
        Me.SalaryTextBox.TabIndex = 12
        '
        'DepartmentIdTextBox
        '
        Me.DepartmentIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "DepartmentId", True))
        Me.DepartmentIdTextBox.Location = New System.Drawing.Point(157, 229)
        Me.DepartmentIdTextBox.Name = "DepartmentIdTextBox"
        Me.DepartmentIdTextBox.Size = New System.Drawing.Size(200, 26)
        Me.DepartmentIdTextBox.TabIndex = 14
        '
        'OkButton
        '
        Me.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OkButton.Location = New System.Drawing.Point(602, 275)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(75, 33)
        Me.OkButton.TabIndex = 15
        Me.OkButton.Text = "Save"
        Me.OkButton.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBtn.Location = New System.Drawing.Point(699, 275)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(75, 33)
        Me.CancelBtn.TabIndex = 15
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'EmployeeDetailsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 337)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.OkButton)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(TitleLabel)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(ManagerLabel)
        Me.Controls.Add(Me.ManagerTextBox)
        Me.Controls.Add(HireDateLabel)
        Me.Controls.Add(Me.HireDateDateTimePicker)
        Me.Controls.Add(SalaryLabel)
        Me.Controls.Add(Me.SalaryTextBox)
        Me.Controls.Add(DepartmentIdLabel)
        Me.Controls.Add(Me.DepartmentIdTextBox)
        Me.Name = "EmployeeDetailsForm"
        Me.Text = "Edit Employee Details"
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EmployeesBindingSource As BindingSource
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents ManagerTextBox As TextBox
    Friend WithEvents HireDateDateTimePicker As DateTimePicker
    Friend WithEvents SalaryTextBox As TextBox
    Friend WithEvents DepartmentIdTextBox As TextBox
    Friend WithEvents OkButton As Button
    Friend WithEvents CancelBtn As Button
End Class
