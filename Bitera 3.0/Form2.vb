Public Class Form2

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If Me.TextBox1.Text.Length < 8 Then
            Me.Button1.BackColor = Color.White
            Me.Button1.Enabled = False
        Else
            Me.Button1.BackColor = Form1.Panel1.BackColor
            Me.Button1.Enabled = True
        End If
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tag = 0
        Me.TextBox1.Text = ""
        Me.Button1.Enabled = False
        Me.Timer1.Start()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Tag = 1
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Me.Timer1.Stop()
        Me.TextBox1.Focus()
    End Sub
End Class