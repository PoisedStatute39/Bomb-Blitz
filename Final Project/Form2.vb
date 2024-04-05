Public Class Form2
    Dim rand As New Random()
    Dim num As Integer
    Dim rn(2) As Integer
    Dim correct As Integer = 0
    Dim wrong As Integer
    Dim score As Integer = 0
    Dim dnum As Integer
    Dim track As Integer
    Dim hscore As Integer
    Dim pscore As Integer = 0

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label10.Show()
        Timer2.Start()
        Label15.Hide()

    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label15.Text = Label15.Text + 1
        If Label15.Text = 2 Then
            Label11.Text = "STARTS..."

        End If
        If Label15.Text = 3 Then
            Label11.Text = "NOW!"
        End If
        If Label15.Text = 4 Then
            Timer2.Stop()



            For a = 0 To rn.Length - 1
                num = rand.Next(1, 10)
                rn(a) = num

                If rn(a) = 1 Then
                    Label1.BackColor = Color.Lime
                    Label1.Text = "X"
                ElseIf rn(a) = 2 Then
                    Label2.BackColor = Color.Lime
                    Label2.Text = "X"
                ElseIf rn(a) = 3 Then
                    Label3.BackColor = Color.Lime
                    Label3.Text = "X"
                ElseIf rn(a) = 4 Then
                    Label4.BackColor = Color.Lime
                    Label4.Text = "X"
                ElseIf rn(a) = 5 Then
                    Label5.BackColor = Color.Lime
                    Label5.Text = "X"
                ElseIf rn(a) = 6 Then
                    Label6.BackColor = Color.Lime
                    Label6.Text = "X"
                ElseIf rn(a) = 7 Then
                    Label7.BackColor = Color.Lime
                    Label7.Text = "X"
                ElseIf rn(a) = 8 Then
                    Label8.BackColor = Color.Lime
                    Label8.Text = "X"
                ElseIf rn(a) = 9 Then
                    Label9.BackColor = Color.Lime
                    Label9.Text = "X"
                End If

            Next

            If rn(0) = rn(1) And rn(0) = rn(2) Then
                dnum = 3
            ElseIf rn(0) = rn(1) Then
                correct = 1
            ElseIf rn(0) = rn(2) Then
                correct = 1
            ElseIf rn(1) = rn(2) Then
                correct = 1
            Else
                dnum = 0
            End If



            TableLayoutPanel1.Show()
            Label10.Text = 2
            Timer1.Interval = 500
            Label11.Text = "MEMORIZE THE TILES"
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label10.Text = Label10.Text - 1
        If Label10.Text = 0 Then
            Timer1.Stop()
            Label1.BackColor = Color.PaleGreen
            Label1.Text = " "
            Label2.BackColor = Color.PaleGreen
            Label2.Text = " "
            Label3.BackColor = Color.PaleGreen
            Label3.Text = " "
            Label4.BackColor = Color.PaleGreen
            Label4.Text = " "
            Label5.BackColor = Color.PaleGreen
            Label5.Text = " "
            Label6.BackColor = Color.PaleGreen
            Label6.Text = " "
            Label7.BackColor = Color.PaleGreen
            Label7.Text = " "
            Label8.BackColor = Color.PaleGreen
            Label8.Text = " "
            Label9.BackColor = Color.PaleGreen
            Label9.Text = " "
            ' MsgBox("You Reached The Time Limit!")
            ' MsgBox("your mom doesn't love you!")
            Label13.Show()
            Label14.Show()
            Label10.Text = 10
            Timer3.Start()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim validate As Integer
        For x = 0 To rn.Length - 1
            If 1 = rn(x) Then
                Label1.BackColor = Color.Green
                correct = correct + 1
                validate += 1
                Exit For
            Else
                Label1.BackColor = Color.Red
                wrong += 1
            End If
        Next
        If validate = 1 Then
            score += 1054
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim validate As Integer
        For x = 0 To rn.Length - 1
            If 2 = rn(x) Then
                Label2.BackColor = Color.Green
                correct = correct + 1
                validate += 1
                Exit For
            Else
                Label2.BackColor = Color.Red
                wrong += 1
            End If
        Next
        If validate = 1 Then
            score += 3434
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim validate As Integer
        For x = 0 To rn.Length - 1
            If 3 = rn(x) Then
                Label3.BackColor = Color.Green
                correct = correct + 1
                validate += 1
                Exit For
            Else
                Label3.BackColor = Color.Red
                wrong += 1
            End If
        Next
        If validate = 1 Then
            score += 4244
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim validate As Integer
        For x = 0 To rn.Length - 1
            If 4 = rn(x) Then
                Label4.BackColor = Color.Green
                correct = correct + 1
                validate += 1
                Exit For
            Else
                Label4.BackColor = Color.Red
                wrong += 1
            End If
        Next
        If validate = 1 Then
            score += 1313
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim validate As Integer
        For x = 0 To rn.Length - 1
            If 5 = rn(x) Then
                Label5.BackColor = Color.Green
                correct = correct + 1
                validate += 1
                Exit For
            Else
                Label5.BackColor = Color.Red
                wrong += 1
            End If
        Next
        If validate = 1 Then
            score += 1312
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim validate As Integer
        For x = 0 To rn.Length - 1
            If 6 = rn(x) Then
                Label6.BackColor = Color.Green
                correct = correct + 1
                validate += 1
                Exit For
            Else
                Label6.BackColor = Color.Red
                wrong += 1
            End If
        Next
        If validate = 1 Then
            score += 1313
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Dim validate As Integer
        For x = 0 To rn.Length - 1
            If 7 = rn(x) Then
                Label7.BackColor = Color.Green
                correct = correct + 1
                validate += 1
                Exit For
            Else
                Label7.BackColor = Color.Red
                wrong += 1
            End If
        Next
        If validate = 1 Then
            score += 2313
        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Dim validate As Integer
        For x = 0 To rn.Length - 1
            If 8 = rn(x) Then
                Label8.BackColor = Color.Green
                correct = correct + 1
                validate += 1
                Exit For
            Else
                Label8.BackColor = Color.Red
                wrong += 1
            End If
        Next
        If validate = 1 Then
            score += 4324
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Dim validate As Integer
        For x = 0 To rn.Length - 1
            If 9 = rn(x) Then
                Label9.BackColor = Color.Green
                correct = correct + 1
                validate += 1
                Exit For
            Else
                Label9.BackColor = Color.Red
                wrong += 1
            End If
        Next

        If validate = 1 Then
            score += 3232
        End If

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Label10.Text = Label10.Text - 1
        Label14.Text = score
        Label17.Text = track
        If track < 10 Then
            If correct > 2 Then
                Timer3.Stop()
                correct = 0
                wrong = 0
                Me.Controls.Clear()
                InitializeComponent()
                Form2_Load(e, e)
                Label11.Hide()
                Timer2.Interval = 50
                track += 1
                If track = 10 Then
                    TableLayoutPanel1.Hide()
                    track = 0
                    MsgBox("WELL DONE!" & vbCrLf & "SCORE: " & score)
                    wrong = 0
                    correct = 0
                    score = 0
                    Me.Close()
                    Me.Hide()
                    Form1.Show()

                End If

            ElseIf wrong > 6 Then
                If Label10.Text < 10 Then
                    wrong = 0
                    correct = 0
                    Timer3.Stop()
                    MsgBox("GAME OVER!" & vbCrLf & "SCORE: " & score)
                    track = 0
                    score = 0
                    Me.Close()
                    Me.Hide()
                    Form1.Show()

                End If

            End If
        End If

        If track >= 10 Then
            Timer3.Interval = 100
            TableLayoutPanel1.Visible = False
            If Label10.Text = 9 Then
                Timer3.Enabled = False
                MsgBox("WELL DONE!" & vbCrLf & "SCORE: " & score)
                track = 0
                Me.Close()
                Me.Hide()
                Form1.Show()
            End If
        End If




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        track = 0
        wrong = 0
        correct = 0
        Me.Close()
        Me.Hide()
        Form1.Show()
    End Sub
End Class