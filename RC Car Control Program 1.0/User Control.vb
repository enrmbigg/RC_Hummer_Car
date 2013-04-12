Public Class User_Control

    Private Declare Function OpenDevice Lib "K8055D.dll" (ByVal CardAddress As Integer) As Integer
    Private Declare Sub SetDigitalChannel Lib "K8055D.dll" (ByVal Channel As Integer)
    Private Declare Sub ClearDigitalChannel Lib "K8055D.dll" (ByVal Channel As Integer)
    Public time


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim CardAddress As Integer
        Dim h As Integer
        CardAddress = 3

        h = OpenDevice(CardAddress)
        Label1.Text = "Card " + Str(h) + " connected"

    End Sub

    ''Private Sub User_Control_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
    '' Select Case e.KeyData
    ''   Case Keys.A : SetDigitalChannel(1) : Label5.ForeColor = Color.Red
    ''  Case Keys.L : SetDigitalChannel(2) : Label4.ForeColor = Color.Red
    ''  Case Keys.Z : SetDigitalChannel(3) : Label2.ForeColor = Color.Red
    ''   Case Keys.K : SetDigitalChannel(4) : Label3.ForeColor = Color.Red
    '' End Select

    ''End Sub

    '' Private Sub MainForm_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp

    ''Select Case e.KeyCode
    ''Case Keys.A : ClearDigitalChannel(1) : Label5.ForeColor = Color.Black
    ''Case Keys.L : ClearDigitalChannel(2) : Label4.ForeColor = Color.Black
    ''Case Keys.Z : ClearDigitalChannel(3) : Label2.ForeColor = Color.Black
    ''Case Keys.K : ClearDigitalChannel(4) : Label3.ForeColor = Color.Black
    ''End Select

    ''End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        System.Diagnostics.Process.Start("")
        'using the start method of system.diagnostics.process class
        'process class gives access to local and remote processes
    End Sub

    Private Sub User_Control_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Menu_a.Close()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Menu_a.Show()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        UserControlAboutBox.Show()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Forward_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Control.KeyDown

        Select Case e.KeyData
            Case Keys.W
                : SetDigitalChannel(1) : Label5.ForeColor = Color.Red
            Case Keys.D
                : SetDigitalChannel(2) : Label4.ForeColor = Color.Red
            Case Keys.S
                : SetDigitalChannel(3) : Label2.ForeColor = Color.Red
            Case Keys.A
                : SetDigitalChannel(4) : Label3.ForeColor = Color.Red
        End Select
    End Sub

    Private Sub Forward_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Control.KeyUp

        Select Case e.KeyCode
            Case Keys.W
                : ClearDigitalChannel(1) : Label5.ForeColor = Color.Black
            Case Keys.D
                : ClearDigitalChannel(2) : Label4.ForeColor = Color.Black
            Case Keys.S
                : ClearDigitalChannel(3) : Label2.ForeColor = Color.Black
            Case Keys.A
                : ClearDigitalChannel(4) : Label3.ForeColor = Color.Black
        End Select
    End Sub
End Class