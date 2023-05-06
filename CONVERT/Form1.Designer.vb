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
        Me.RadioButtonTemperature = New System.Windows.Forms.RadioButton()
        Me.ComboBoxTo = New System.Windows.Forms.ComboBox()
        Me.ButtonConverte = New System.Windows.Forms.Button()
        Me.ComboBoxFrom = New System.Windows.Forms.ComboBox()
        Me.RadioButtonDistince = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMass = New System.Windows.Forms.RadioButton()
        Me.LabelAffichConvert = New System.Windows.Forms.Label()
        Me.TextBoxFrom = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(191, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 51)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CONVERT"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadioButtonTemperature
        '
        Me.RadioButtonTemperature.AutoSize = True
        Me.RadioButtonTemperature.Location = New System.Drawing.Point(29, 148)
        Me.RadioButtonTemperature.Name = "RadioButtonTemperature"
        Me.RadioButtonTemperature.Size = New System.Drawing.Size(84, 17)
        Me.RadioButtonTemperature.TabIndex = 1
        Me.RadioButtonTemperature.TabStop = True
        Me.RadioButtonTemperature.Text = " temperature"
        Me.RadioButtonTemperature.UseVisualStyleBackColor = True
        '
        'ComboBoxTo
        '
        Me.ComboBoxTo.FormattingEnabled = True
        Me.ComboBoxTo.Location = New System.Drawing.Point(365, 150)
        Me.ComboBoxTo.Name = "ComboBoxTo"
        Me.ComboBoxTo.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxTo.TabIndex = 2
        '
        'ButtonConverte
        '
        Me.ButtonConverte.Location = New System.Drawing.Point(365, 230)
        Me.ButtonConverte.Name = "ButtonConverte"
        Me.ButtonConverte.Size = New System.Drawing.Size(121, 46)
        Me.ButtonConverte.TabIndex = 3
        Me.ButtonConverte.Text = "Converte"
        Me.ButtonConverte.UseVisualStyleBackColor = True
        '
        'ComboBoxFrom
        '
        Me.ComboBoxFrom.FormattingEnabled = True
        Me.ComboBoxFrom.Location = New System.Drawing.Point(218, 150)
        Me.ComboBoxFrom.Name = "ComboBoxFrom"
        Me.ComboBoxFrom.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxFrom.TabIndex = 2
        '
        'RadioButtonDistince
        '
        Me.RadioButtonDistince.AutoSize = True
        Me.RadioButtonDistince.Location = New System.Drawing.Point(29, 186)
        Me.RadioButtonDistince.Name = "RadioButtonDistince"
        Me.RadioButtonDistince.Size = New System.Drawing.Size(65, 17)
        Me.RadioButtonDistince.TabIndex = 1
        Me.RadioButtonDistince.TabStop = True
        Me.RadioButtonDistince.Text = "distance"
        Me.RadioButtonDistince.UseVisualStyleBackColor = True
        '
        'RadioButtonMass
        '
        Me.RadioButtonMass.AutoSize = True
        Me.RadioButtonMass.Location = New System.Drawing.Point(29, 224)
        Me.RadioButtonMass.Name = "RadioButtonMass"
        Me.RadioButtonMass.Size = New System.Drawing.Size(50, 17)
        Me.RadioButtonMass.TabIndex = 1
        Me.RadioButtonMass.TabStop = True
        Me.RadioButtonMass.Text = "Mass"
        Me.RadioButtonMass.UseVisualStyleBackColor = True
        '
        'LabelAffichConvert
        '
        Me.LabelAffichConvert.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelAffichConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAffichConvert.Location = New System.Drawing.Point(215, 297)
        Me.LabelAffichConvert.Name = "LabelAffichConvert"
        Me.LabelAffichConvert.Size = New System.Drawing.Size(271, 41)
        Me.LabelAffichConvert.TabIndex = 0
        Me.LabelAffichConvert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxFrom
        '
        Me.TextBoxFrom.Location = New System.Drawing.Point(218, 192)
        Me.TextBoxFrom.Name = "TextBoxFrom"
        Me.TextBoxFrom.Size = New System.Drawing.Size(268, 20)
        Me.TextBoxFrom.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(515, 369)
        Me.Controls.Add(Me.TextBoxFrom)
        Me.Controls.Add(Me.ComboBoxFrom)
        Me.Controls.Add(Me.ButtonConverte)
        Me.Controls.Add(Me.ComboBoxTo)
        Me.Controls.Add(Me.RadioButtonMass)
        Me.Controls.Add(Me.RadioButtonDistince)
        Me.Controls.Add(Me.RadioButtonTemperature)
        Me.Controls.Add(Me.LabelAffichConvert)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Convert"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButtonTemperature As RadioButton
    Friend WithEvents ComboBoxTo As ComboBox
    Friend WithEvents ButtonConverte As Button
    Friend WithEvents ComboBoxFrom As ComboBox
    Friend WithEvents RadioButtonDistince As RadioButton
    Friend WithEvents RadioButtonMass As RadioButton
    Friend WithEvents LabelAffichConvert As Label
    Friend WithEvents TextBoxFrom As TextBox
End Class
