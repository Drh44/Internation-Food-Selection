Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        PictureBox1.Visible = True

        If RadioButton1.Checked = False Then
            PictureBox1.Visible = False
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        PictureBox2.Visible = True
        If RadioButton3.Checked = False Then
            PictureBox2.Visible = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        PictureBox3.Visible = True
        If RadioButton2.Checked = False Then
            PictureBox3.Visible = False
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        PictureBox4.Visible = True
        If RadioButton4.Checked = False Then
            PictureBox4.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Your Choice will be delivered to you shortly. Have a Great Day!")
    End Sub
End Class
