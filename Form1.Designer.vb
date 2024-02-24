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
        components = New ComponentModel.Container()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label1 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label2 = New Label()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        ToolTip1 = New ToolTip(components)
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(97, 26)
        Button1.TabIndex = 0
        Button1.Text = "图片文件夹"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(12, 44)
        Button2.Name = "Button2"
        Button2.Size = New Size(97, 27)
        Button2.TabIndex = 1
        Button2.Text = "导出文件夹"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(12, 77)
        Button3.Name = "Button3"
        Button3.Size = New Size(351, 27)
        Button3.TabIndex = 2
        Button3.Text = "运行"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 113)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 17)
        Label1.TabIndex = 3
        Label1.Text = "最长边大小"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(115, 12)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(248, 23)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(115, 48)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(248, 23)
        TextBox2.TabIndex = 5
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(86, 110)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(84, 23)
        TextBox3.TabIndex = 6
        TextBox3.Text = "768"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.Gray
        Label2.Location = New Point(242, 113)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 17)
        Label2.TabIndex = 7
        Label2.Text = "准备就绪"
        ' 
        ' ToolTip1
        ' 
        ToolTip1.AutoPopDelay = 5000
        ToolTip1.InitialDelay = 200
        ToolTip1.ReshowDelay = 100
        ToolTip1.ToolTipTitle = "注意检查文件夹内文件格式"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(371, 144)
        Controls.Add(Label2)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "EzRescale"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents ToolTip1 As ToolTip

End Class
