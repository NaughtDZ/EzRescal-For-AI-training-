Imports System.IO
Imports System.Threading

Public Class Form1
    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(Button1, "确保格式为jpg,jpeg,png,bmp格式！")
        Button3.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FolderBrowserDialog1.ShowDialog()
        If IO.Directory.Exists(FolderBrowserDialog1.SelectedPath) = True Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
            Butt_enableCheck()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FolderBrowserDialog1.ShowDialog()
        If IO.Directory.Exists(FolderBrowserDialog1.SelectedPath) = True Then
            TextBox2.Text = FolderBrowserDialog1.SelectedPath
            Butt_enableCheck()
        End If
    End Sub

    Private Sub Butt_enableCheck()
        If IO.Directory.Exists(TextBox1.Text) And IO.Directory.Exists(TextBox2.Text) Then
            Button3.Enabled = True
            Label2.Text = "准备就绪"
            Label2.ForeColor = Color.Gray
        Else
            Button3.Enabled = False
            Label2.Text = "准备就绪"
            Label2.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button3.Enabled = False
        Label2.Text = "处理中"
        Label2.ForeColor = Color.Green
        Dim loadfiles As String()
        ' 获取指定文件夹中所有文件的名称
        Try
            loadfiles = System.IO.Directory.GetFiles(TextBox1.Text)
        Catch ex As Exception
            MsgBox(ex)
            Exit Sub
        End Try
        For Each img In loadfiles
            Rescale(img, TextBox3.Text, TextBox2.Text & "\" & Path.GetFileName(img))
            Application.DoEvents()
        Next
        Beep()
        Label2.Text = "处理完成"
        Label2.ForeColor = Color.BlueViolet
        Button3.Enabled = True
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Butt_enableCheck()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Butt_enableCheck()
    End Sub

    Public Sub Rescale(ByVal imagePath As String, ByVal maxLength As Integer, ByVal savePath As String)

        ' 读取图片
        Dim image As Image = Image.FromFile(imagePath)

        ' 识别图片方向
        Dim isHorizontal As Boolean = image.Width > image.Height

        ' 计算缩放比例
        Dim scale As Double = 1.0
        If isHorizontal Then
            scale = maxLength / image.Width
        Else
            scale = maxLength / image.Height
        End If

        ' 等比例缩放图片
        Dim newImage As Image = New Bitmap(CType(image.Width * scale, Integer), CType(image.Height * scale, Integer))
        Using graphics As Graphics = Graphics.FromImage(newImage)
            graphics.DrawImage(image, New Rectangle(0, 0, newImage.Width, newImage.Height), New Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel)
        End Using

        ' 另存为图片
        newImage.Save(savePath)
    End Sub



End Class
