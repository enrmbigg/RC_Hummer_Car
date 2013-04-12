Public Class Menu_a

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        User_Control.Show()
    End Sub

    Private Sub Menu_a_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        User_Control.Close()
    End Sub
End Class
