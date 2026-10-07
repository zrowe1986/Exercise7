<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Exercise7
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblFullName = New Label()
        txtFullName = New TextBox()
        btnName = New Button()
        lstResults = New ListBox()
        lblDecimal = New Label()
        txtNumber = New TextBox()
        btnCurrency = New Button()
        lblCurrency = New Label()
        btnPercent = New Button()
        lblPercent = New Label()
        btnNumber = New Button()
        lblNumber = New Label()
        btnClear = New Button()
        btnEnd = New Button()
        SuspendLayout()
        ' 
        ' lblFullName
        ' 
        lblFullName.BackColor = SystemColors.GradientInactiveCaption
        lblFullName.BorderStyle = BorderStyle.FixedSingle
        lblFullName.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFullName.Location = New Point(20, 20)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(150, 40)
        lblFullName.TabIndex = 0
        lblFullName.Text = "Enter Your Full Name"
        lblFullName.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtFullName
        ' 
        txtFullName.BackColor = SystemColors.ControlLight
        txtFullName.ForeColor = SystemColors.MenuText
        txtFullName.Location = New Point(190, 30)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(150, 23)
        txtFullName.TabIndex = 1
        ' 
        ' btnName
        ' 
        btnName.BackColor = SystemColors.GradientInactiveCaption
        btnName.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnName.Location = New Point(60, 80)
        btnName.Name = "btnName"
        btnName.Size = New Size(240, 45)
        btnName.TabIndex = 2
        btnName.Text = "This Is What I Know About Your Name"
        btnName.UseVisualStyleBackColor = False
        ' 
        ' lstResults
        ' 
        lstResults.BackColor = SystemColors.GradientInactiveCaption
        lstResults.FormattingEnabled = True
        lstResults.Location = New Point(40, 140)
        lstResults.Name = "lstResults"
        lstResults.Size = New Size(280, 124)
        lstResults.TabIndex = 3
        ' 
        ' lblDecimal
        ' 
        lblDecimal.BackColor = SystemColors.GradientInactiveCaption
        lblDecimal.BorderStyle = BorderStyle.FixedSingle
        lblDecimal.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDecimal.Location = New Point(20, 285)
        lblDecimal.Name = "lblDecimal"
        lblDecimal.Size = New Size(150, 40)
        lblDecimal.TabIndex = 4
        lblDecimal.Text = "Now Enter a Decimal Number"
        lblDecimal.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtNumber
        ' 
        txtNumber.BackColor = SystemColors.ControlLight
        txtNumber.BorderStyle = BorderStyle.FixedSingle
        txtNumber.Location = New Point(190, 294)
        txtNumber.Name = "txtNumber"
        txtNumber.Size = New Size(150, 23)
        txtNumber.TabIndex = 5
        ' 
        ' btnCurrency
        ' 
        btnCurrency.BackColor = SystemColors.GradientInactiveCaption
        btnCurrency.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCurrency.Location = New Point(20, 340)
        btnCurrency.Name = "btnCurrency"
        btnCurrency.Size = New Size(150, 40)
        btnCurrency.TabIndex = 6
        btnCurrency.Text = "If Currency"
        btnCurrency.UseVisualStyleBackColor = False
        ' 
        ' lblCurrency
        ' 
        lblCurrency.BackColor = SystemColors.ControlLight
        lblCurrency.BorderStyle = BorderStyle.FixedSingle
        lblCurrency.Location = New Point(190, 340)
        lblCurrency.Name = "lblCurrency"
        lblCurrency.Size = New Size(150, 40)
        lblCurrency.TabIndex = 7
        lblCurrency.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnPercent
        ' 
        btnPercent.BackColor = SystemColors.GradientInactiveCaption
        btnPercent.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPercent.Location = New Point(20, 390)
        btnPercent.Name = "btnPercent"
        btnPercent.Size = New Size(150, 40)
        btnPercent.TabIndex = 8
        btnPercent.Text = "If Percent"
        btnPercent.UseVisualStyleBackColor = False
        ' 
        ' lblPercent
        ' 
        lblPercent.BackColor = SystemColors.ControlLight
        lblPercent.BorderStyle = BorderStyle.FixedSingle
        lblPercent.Location = New Point(190, 390)
        lblPercent.Name = "lblPercent"
        lblPercent.Size = New Size(150, 40)
        lblPercent.TabIndex = 9
        lblPercent.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnNumber
        ' 
        btnNumber.BackColor = SystemColors.GradientInactiveCaption
        btnNumber.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNumber.Location = New Point(20, 440)
        btnNumber.Name = "btnNumber"
        btnNumber.Size = New Size(150, 50)
        btnNumber.TabIndex = 10
        btnNumber.Text = "If Number With 1 Decimal Place"
        btnNumber.UseVisualStyleBackColor = False
        ' 
        ' lblNumber
        ' 
        lblNumber.BackColor = SystemColors.ControlLight
        lblNumber.BorderStyle = BorderStyle.FixedSingle
        lblNumber.Location = New Point(190, 440)
        lblNumber.Name = "lblNumber"
        lblNumber.Size = New Size(150, 50)
        lblNumber.TabIndex = 11
        lblNumber.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = SystemColors.Highlight
        btnClear.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = SystemColors.Window
        btnClear.Location = New Point(20, 505)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(150, 35)
        btnClear.TabIndex = 12
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnEnd
        ' 
        btnEnd.BackColor = SystemColors.Highlight
        btnEnd.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEnd.ForeColor = SystemColors.Window
        btnEnd.Location = New Point(190, 505)
        btnEnd.Name = "btnEnd"
        btnEnd.Size = New Size(150, 35)
        btnEnd.TabIndex = 13
        btnEnd.Text = "End"
        btnEnd.UseVisualStyleBackColor = False
        ' 
        ' Exercise7
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(360, 560)
        Controls.Add(btnEnd)
        Controls.Add(btnClear)
        Controls.Add(lblNumber)
        Controls.Add(btnNumber)
        Controls.Add(lblPercent)
        Controls.Add(btnPercent)
        Controls.Add(lblCurrency)
        Controls.Add(btnCurrency)
        Controls.Add(txtNumber)
        Controls.Add(lblDecimal)
        Controls.Add(lstResults)
        Controls.Add(btnName)
        Controls.Add(txtFullName)
        Controls.Add(lblFullName)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Exercise7"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Exercise 7"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblFullName As System.Windows.Forms.Label
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents btnName As System.Windows.Forms.Button
    Friend WithEvents lstResults As System.Windows.Forms.ListBox
    Friend WithEvents lblDecimal As System.Windows.Forms.Label
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnCurrency As System.Windows.Forms.Button
    Friend WithEvents lblCurrency As System.Windows.Forms.Label
    Friend WithEvents btnPercent As System.Windows.Forms.Button
    Friend WithEvents lblPercent As System.Windows.Forms.Label
    Friend WithEvents btnNumber As System.Windows.Forms.Button
    Friend WithEvents lblNumber As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button

End Class