Public Class Form1
    Dim fx
    Dim last
    Dim fil
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            fil = Me.OpenFileDialog1.FileName
            enrdy()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Bitera Files\Encrypted\")
        My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Bitera Files\Decrypted\")

        Button3.Location = New Point(492, 367)
        Me.Button3.Show()
        Me.Button3.Tag = 5
        Me.Button3.Text = "Show your files"
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        If Not My.Computer.FileSystem.FileExists("run.dll") Then
            Me.ProgressBar1.Hide()
            endop()
        Else
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Timer2.Stop()
        System.Diagnostics.Process.Start("encry.agnt.3.exe")
        last = 1
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.OpenFileDialog2.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Bitera Files\Encrypted\"
        If OpenFileDialog2.ShowDialog = Windows.Forms.DialogResult.OK Then
            fil = Me.OpenFileDialog2.FileName
            derdy()
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Timer3.Stop()
        System.Diagnostics.Process.Start("decry.agnt.3.exe")
        last = 2
    End Sub

    Private Sub enrdy()
        Dim fx1 As New IO.FileInfo(fil)
        If fx1.Extension.ToLower = ".bitera" Then
            MsgBox("File that you selected is already encrypted.", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        Button3.Location = New Point(445, 294)
        Label1.Text = "File is ready to Encrypt !"
        Label2.Text = "Encryped file will be in Document Folder"
        Label3.Text = "The encrypted file extension will be .BITERA"
        Label4.Text = "Remember your password or you will never able to decrypt back."
        Dim x As New IO.FileInfo(fil)
        Label5.Text = x.Name
        Button3.Show()
        Button3.Text = "Start Encryption"
        Me.Button3.Tag = 1
        Button3.Enabled = True
        Me.ProgressBar1.Show()
        Me.ProgressBar1.Style = ProgressBarStyle.Continuous
        Me.ProgressBar1.Value = 0
    End Sub

    Private Sub derdy()
        Button3.Location = New Point(445, 294)
        Label1.Text = "File is ready to Decrypt !"
        Label2.Text = "Decryped file will be in Document Folder."
        Label3.Text = "Press Start Decryption to continue."
        Label4.Text = "Enter the file password."
        Dim x As New IO.FileInfo(fil)
        Label5.Text = x.Name
        Button3.Show()
        Button3.Text = "Start Decryption"
        Me.Button3.Tag = 2
        Button3.Enabled = True
        Me.ProgressBar1.Show()
        Me.ProgressBar1.Style = ProgressBarStyle.Continuous
        Me.ProgressBar1.Value = 0
    End Sub

    Private Sub encry(ByVal fil)

        Dim i = Form2.TextBox1.Text
        If i.ToString.Length < 8 Then
            Exit Sub
        End If
        Me.ProgressBar1.Style = ProgressBarStyle.Marquee
        Button3.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False
        i = i.ToString.ToLower
        If i.ToString.Length > 0 Then
            Dim k = i.ToString
            k = k.Replace("a", "1")
            k = k.Replace("b", "2")
            k = k.Replace("c", "3")
            k = k.Replace("d", "4")
            k = k.Replace("e", "5")
            k = k.Replace("f", "6")
            k = k.Replace("g", "7")
            k = k.Replace("h", "8")
            k = k.Replace("i", "9")
            k = k.Replace("j", "10")
            k = k.Replace("k", "1")
            k = k.Replace("l", "2")
            k = k.Replace("m", "3")
            k = k.Replace("n", "4")
            k = k.Replace("o", "5")
            k = k.Replace("p", "6")
            k = k.Replace("q", "7")
            k = k.Replace("r", "8")
            k = k.Replace("s", "9")
            k = k.Replace("t", "1")
            k = k.Replace("u", "2")
            k = k.Replace("v", "3")
            k = k.Replace("w", "4")
            k = k.Replace("x", "5")
            k = k.Replace("y", "6")
            k = k.Replace("z", "7")
            Dim fx0 As New IO.FileInfo(fil)
            fx = fx0.Name
            My.Computer.FileSystem.WriteAllText("cny.dll", k & " " & fil, False)
            My.Computer.FileSystem.WriteAllText("run.dll", "", False)
            My.Computer.FileSystem.WriteAllText("doc.dll", My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Bitera Files\Encrypted\", False)
            Timer2.Start()
            Timer1.Start()
        End If
    End Sub

    Private Sub decry(ByVal fil)
        Dim i = Form2.TextBox1.Text
        If i.ToString.Length < 8 Then
            Exit Sub
        End If
        Me.ProgressBar1.Style = ProgressBarStyle.Marquee
        Button3.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False
        i = i.ToString.ToLower
        If i.ToString.Length > 0 Then
            Dim k = i.ToString
            k = k.Replace("a", "1")
            k = k.Replace("b", "2")
            k = k.Replace("c", "3")
            k = k.Replace("d", "4")
            k = k.Replace("e", "5")
            k = k.Replace("f", "6")
            k = k.Replace("g", "7")
            k = k.Replace("h", "8")
            k = k.Replace("i", "9")
            k = k.Replace("j", "10")
            k = k.Replace("k", "1")
            k = k.Replace("l", "2")
            k = k.Replace("m", "3")
            k = k.Replace("n", "4")
            k = k.Replace("o", "5")
            k = k.Replace("p", "6")
            k = k.Replace("q", "7")
            k = k.Replace("r", "8")
            k = k.Replace("s", "9")
            k = k.Replace("t", "1")
            k = k.Replace("u", "2")
            k = k.Replace("v", "3")
            k = k.Replace("w", "4")
            k = k.Replace("x", "5")
            k = k.Replace("y", "6")
            k = k.Replace("z", "7")
            Dim fx0 As New IO.FileInfo(fil)
            fx = fx0.Name
            My.Computer.FileSystem.WriteAllText("cny.dll", k & " " & fil, False)
            My.Computer.FileSystem.WriteAllText("run.dll", "", False)
            My.Computer.FileSystem.WriteAllText("doc.dll", My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Bitera Files\Decrypted\", False)

            Timer3.Start()
            Timer1.Start()

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Button3.Tag = 1 Then
            Form2.ShowDialog()
            If Form2.Tag = 1 Then
                encry(fil)
            End If
        End If
        If Button3.Tag = 2 Then
            Form2.ShowDialog()
            If Form2.Tag = 1 Then
                decry(fil)
            End If
        End If
        If Button3.Tag = 3 Then
            System.Diagnostics.Process.Start(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Bitera Files\Encrypted\")
        End If
        If Button3.Tag = 4 Then
            System.Diagnostics.Process.Start(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Bitera Files\Decrypted\")
        End If
        If Button3.Tag = 5 Then
            System.Diagnostics.Process.Start(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Bitera Files\")
        End If
    End Sub
    Private Sub endop()
        If last = 1 Then
            Button3.Location = New Point(492, 367)
            Label1.Text = "Encryption Complete !"
            Label2.Text = "Open Document Folder to see the file."
            Label3.Text = ""
            Label4.Text = ""
            Label5.Text = ""
            Button3.Text = "Open Folder"
            Me.Button3.Tag = 3
            Button3.Enabled = True
            Button1.Enabled = True
            Button2.Enabled = True
            Me.ProgressBar1.Hide()
        End If
        If last = 2 Then
            Button3.Location = New Point(492, 367)
            Label1.Text = "Decryption Complete !"
            Label2.Text = "Open Document Folder to see the file."
            Label3.Text = ""
            Label4.Text = ""
            Label5.Text = ""
            Button3.Text = "Open Folder"
            Me.Button3.Tag = 4
            Button3.Enabled = True
            Button1.Enabled = True
            Button2.Enabled = True
            Me.ProgressBar1.Hide()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MsgBox("Dn Technologies @ Deshan Blog" & Me.Label6.Text & "http://dn-w.blogspot.com/", MsgBoxStyle.Information, "About Bitera")
        System.Diagnostics.Process.Start("http://dn-w.blogspot.com/ ")

    End Sub
End Class
