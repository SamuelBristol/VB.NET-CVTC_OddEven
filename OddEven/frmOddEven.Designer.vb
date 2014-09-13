<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOddEven
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
        Me.lblNumber1 = New System.Windows.Forms.Label()
        Me.lblNumber2 = New System.Windows.Forms.Label()
        Me.lblOdd = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtnumber1 = New System.Windows.Forms.TextBox()
        Me.txtnumber2 = New System.Windows.Forms.TextBox()
        Me.pnlInput = New System.Windows.Forms.Panel()
        Me.lstOdd = New System.Windows.Forms.ListBox()
        Me.lstEven = New System.Windows.Forms.ListBox()
        Me.lblEven = New System.Windows.Forms.Label()
        Me.pnlInput.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNumber1
        '
        Me.lblNumber1.AutoSize = True
        Me.lblNumber1.Location = New System.Drawing.Point(18, 16)
        Me.lblNumber1.Name = "lblNumber1"
        Me.lblNumber1.Size = New System.Drawing.Size(56, 13)
        Me.lblNumber1.TabIndex = 0
        Me.lblNumber1.Text = "Number 1:"
        '
        'lblNumber2
        '
        Me.lblNumber2.AutoSize = True
        Me.lblNumber2.Location = New System.Drawing.Point(18, 45)
        Me.lblNumber2.Name = "lblNumber2"
        Me.lblNumber2.Size = New System.Drawing.Size(56, 13)
        Me.lblNumber2.TabIndex = 1
        Me.lblNumber2.Text = "Number 2:"
        '
        'lblOdd
        '
        Me.lblOdd.Location = New System.Drawing.Point(12, 103)
        Me.lblOdd.Name = "lblOdd"
        Me.lblOdd.Size = New System.Drawing.Size(55, 150)
        Me.lblOdd.TabIndex = 2
        Me.lblOdd.Text = "Odd numbers between both integers:"
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(164, 11)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplay.TabIndex = 4
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(164, 39)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtnumber1
        '
        Me.txtnumber1.Location = New System.Drawing.Point(81, 13)
        Me.txtnumber1.Name = "txtnumber1"
        Me.txtnumber1.Size = New System.Drawing.Size(68, 20)
        Me.txtnumber1.TabIndex = 6
        '
        'txtnumber2
        '
        Me.txtnumber2.Location = New System.Drawing.Point(81, 42)
        Me.txtnumber2.Name = "txtnumber2"
        Me.txtnumber2.Size = New System.Drawing.Size(68, 20)
        Me.txtnumber2.TabIndex = 7
        '
        'pnlInput
        '
        Me.pnlInput.BackColor = System.Drawing.SystemColors.Control
        Me.pnlInput.Controls.Add(Me.txtnumber1)
        Me.pnlInput.Controls.Add(Me.txtnumber2)
        Me.pnlInput.Controls.Add(Me.lblNumber1)
        Me.pnlInput.Controls.Add(Me.lblNumber2)
        Me.pnlInput.Controls.Add(Me.btnExit)
        Me.pnlInput.Controls.Add(Me.btnDisplay)
        Me.pnlInput.Location = New System.Drawing.Point(15, 12)
        Me.pnlInput.Name = "pnlInput"
        Me.pnlInput.Size = New System.Drawing.Size(257, 76)
        Me.pnlInput.TabIndex = 8
        '
        'lstOdd
        '
        Me.lstOdd.FormattingEnabled = True
        Me.lstOdd.Location = New System.Drawing.Point(73, 103)
        Me.lstOdd.Name = "lstOdd"
        Me.lstOdd.Size = New System.Drawing.Size(68, 147)
        Me.lstOdd.TabIndex = 9
        '
        'lstEven
        '
        Me.lstEven.FormattingEnabled = True
        Me.lstEven.Location = New System.Drawing.Point(204, 103)
        Me.lstEven.Name = "lstEven"
        Me.lstEven.Size = New System.Drawing.Size(68, 147)
        Me.lstEven.TabIndex = 11
        '
        'lblEven
        '
        Me.lblEven.Location = New System.Drawing.Point(147, 103)
        Me.lblEven.Name = "lblEven"
        Me.lblEven.Size = New System.Drawing.Size(51, 150)
        Me.lblEven.TabIndex = 10
        Me.lblEven.Text = "Even numbers between both integers:"
        '
        'frmOddEven
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lstEven)
        Me.Controls.Add(Me.lblEven)
        Me.Controls.Add(Me.lstOdd)
        Me.Controls.Add(Me.pnlInput)
        Me.Controls.Add(Me.lblOdd)
        Me.Name = "frmOddEven"
        Me.Text = "Odd and Even Numbers"
        Me.pnlInput.ResumeLayout(False)
        Me.pnlInput.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblNumber1 As System.Windows.Forms.Label
    Friend WithEvents lblNumber2 As System.Windows.Forms.Label
    Friend WithEvents lblOdd As System.Windows.Forms.Label
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtnumber1 As System.Windows.Forms.TextBox
    Friend WithEvents txtnumber2 As System.Windows.Forms.TextBox
    Friend WithEvents pnlInput As System.Windows.Forms.Panel
    Friend WithEvents lstOdd As System.Windows.Forms.ListBox
    Friend WithEvents lstEven As System.Windows.Forms.ListBox
    Friend WithEvents lblEven As System.Windows.Forms.Label

End Class
