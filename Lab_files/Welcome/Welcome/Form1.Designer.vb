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
        Label1 = New Label()
        Suubmit_btn = New Button()
        name_tbx = New TextBox()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Symbol", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(119, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(196, 50)
        Label1.TabIndex = 0
        Label1.Text = "WELCOME"
        ' 
        ' Suubmit_btn
        ' 
        Suubmit_btn.Location = New Point(170, 262)
        Suubmit_btn.Name = "Suubmit_btn"
        Suubmit_btn.Size = New Size(75, 23)
        Suubmit_btn.TabIndex = 1
        Suubmit_btn.Text = "Submit"
        Suubmit_btn.UseVisualStyleBackColor = True
        ' 
        ' name_tbx
        ' 
        name_tbx.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        name_tbx.ForeColor = SystemColors.ScrollBar
        name_tbx.Location = New Point(117, 172)
        name_tbx.Name = "name_tbx"
        name_tbx.Size = New Size(198, 23)
        name_tbx.TabIndex = 2
        name_tbx.Text = "enter name here"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(170, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 15)
        Label2.TabIndex = 3
        Label2.Text = "Enter your name"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(441, 356)
        Controls.Add(Label2)
        Controls.Add(name_tbx)
        Controls.Add(Suubmit_btn)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Suubmit_btn As Button
    Friend WithEvents name_tbx As TextBox
    Friend WithEvents Label2 As Label

End Class
