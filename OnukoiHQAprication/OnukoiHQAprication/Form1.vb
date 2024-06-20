Imports Microsoft.VisualBasic.Devices

Public Class Form1
    Dim MID As String = ""
    Dim MKeyword As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim UID As String = TextBox1.Text
        Dim UKeyword As String = TextBox2.Text

        If MID = UID Then
            If MKeyword = UKeyword Then
                MessageBox.Show("ログイン成功、Admin様")
                Dim f2 As New Form2
                f2.Show()
            End If
        End If
    End Sub
End Class
