Public Class Form1


    Private Sub updateTriangleLocation(b As Control)
        Dim y As Integer = b.Location.Y + 64
        y += (b.Height / 2) - (GunaTransfarantPictureBox1.Height / 2)
        GunaTransfarantPictureBox1.Location = New Point(119, y)
        GunaTransfarantPictureBox1.Refresh()
        GunaTransfarantPictureBox1.BringToFront()
    End Sub

    Private Sub GunaImageButton1_Click(sender As Object, e As EventArgs) Handles GunaImageButton1.Click
        Close()
    End Sub

    Private Sub GunaImageButton2_Click(sender As Object, e As EventArgs) Handles GunaImageButton2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub nav_status_CheckedChanged(sender As Object, e As EventArgs) Handles nav_status.CheckedChanged
        updateTriangleLocation(sender)
    End Sub

    Private Sub nav_scan_CheckedChanged(sender As Object, e As EventArgs) Handles nav_scan.CheckedChanged
        updateTriangleLocation(sender)
    End Sub

    Private Sub nav_quarantine_CheckedChanged(sender As Object, e As EventArgs) Handles nav_quarantine.CheckedChanged
        updateTriangleLocation(sender)
    End Sub

    Private Sub nav_modules_CheckedChanged(sender As Object, e As EventArgs) Handles nav_modules.CheckedChanged
        updateTriangleLocation(sender)
    End Sub

    Private Sub nav_activity_CheckedChanged(sender As Object, e As EventArgs) Handles nav_activity.CheckedChanged
        updateTriangleLocation(sender)
    End Sub
End Class
