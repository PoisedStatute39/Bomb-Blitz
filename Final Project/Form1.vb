Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Hide()
        Label6.Hide()
        Label7.Hide()
        Button1.Hide()
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Label2.Hide()
        Label3.Hide()
        Label4.Hide()
        Label5.Show()
        Label6.Show()
        Label7.Show()
        Button1.Show()

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        MsgBox("Notice! If you encounter a 1 bomb, it's called 'MEGA BOMB'." & vbCrLf & "You need to click continuously until it defuse.")
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        MsgBox("Notice! If you encounter a 1 bomb, it's called 'MEGA BOMB'." & vbCrLf & "You need to click continuously  until it defuse.")
        Form4.Show()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        MsgBox("Notice! If you encounter a 1 bomb, it's called 'MEGA BOMB'." & vbCrLf & "You need to click continuously until it defuse.")
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        MsgBox(":(")
        End
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        MsgBox("Notice! If you encounter a 1 bomb, it's called 'MEGA BOMB'." & vbCrLf & "You need to click continuously until it defuse.")
 Me.Hide()
        Form6.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Label2.Show()
        Label3.Show()
        Label4.Show()
        Label5.Hide()
        Label6.Hide()
        Label7.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Label2.Show()
        Label3.Show()
        Label4.Show()
        Label5.Hide()
        Label6.Hide()
        Label7.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Show()
        Label3.Show()
        Label4.Show()
        Label5.Hide()
        Label6.Hide()
        Label7.Hide()
        Button1.Hide()
    End Sub
End Class
