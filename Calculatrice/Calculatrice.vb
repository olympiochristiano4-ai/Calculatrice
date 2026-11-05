Public Class Calculatrice

    Dim result As Long
    Dim nb2 As Long
    Dim nb1 As Long
    Dim comptOP As Integer
    Dim comptEG As Integer
    Dim str_Op As String
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Text = TextBox1.Text & 3
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text & 5
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text & 7
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text & 0
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox1.Text = TextBox1.Text & 1

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox1.Text = TextBox1.Text & 2

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text = TextBox1.Text & 4
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text & 6

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text & 8
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text & 9
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        str_Op = "-"
        nb1 = CLng(TextBox1.Text)
        TextBox1.Text = TextBox1.Text & " - "

        comptOP = Len(TextBox1.Text)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        str_Op = "+"
        nb1 = CLng(TextBox1.Text)
        TextBox1.Text = TextBox1.Text & " + "

        comptOP = Len(TextBox1.Text)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        str_Op = "/"
        nb1 = CLng(TextBox1.Text)
        TextBox1.Text = TextBox1.Text & " / "

        comptOP = Len(TextBox1.Text)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        str_Op = "*"
        nb1 = CLng(TextBox1.Text)
        TextBox1.Text = TextBox1.Text & " * "

        comptOP = Len(TextBox1.Text)

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        comptEG = Len(TextBox1.Text) - comptOP
        Dim str_nb2 As String = Microsoft.VisualBasic.Strings.Right(TextBox1.Text, comptEG)

        nb2 = CLng(str_nb2)

        If (str_Op = "-") Then
            result = nb1 - nb2
        End If

        If (str_Op = "+") Then
            result = nb1 + nb2
        End If

        If (str_Op = "/") Then
            result = nb1 / nb2
        End If

        If (str_Op = "*") Then
            result = nb1 * nb2
        End If

        TextBox1.Text = CStr(result)

    End Sub

    Private Sub CalcGroupBox1_Enter(sender As Object, e As EventArgs) Handles CalcGroupBox1.Enter

    End Sub
End Class
