<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        strNumber = New Label()
        btnOutput = New Button()
        txtInput = New TextBox()
        SuspendLayout()
        ' 
        ' strNumber
        ' 
        strNumber.AutoSize = True
        strNumber.Location = New Point(139, 130)
        strNumber.Name = "strNumber"
        strNumber.Size = New Size(122, 25)
        strNumber.TabIndex = 0
        strNumber.Text = "Enter Number"
        ' 
        ' btnOutput
        ' 
        btnOutput.Location = New Point(320, 313)
        btnOutput.Name = "btnOutput"
        btnOutput.Size = New Size(112, 34)
        btnOutput.TabIndex = 1
        btnOutput.Text = "Output"
        btnOutput.UseVisualStyleBackColor = True
        ' 
        ' txtInput
        ' 
        txtInput.Location = New Point(440, 128)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(150, 31)
        txtInput.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtInput)
        Controls.Add(btnOutput)
        Controls.Add(strNumber)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents strNumber As Label
    Friend WithEvents btnOutput As Button
    Friend WithEvents txtInput As TextBox
End Class
