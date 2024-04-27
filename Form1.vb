Imports System.Collections.Specialized.BitVector32

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(13, 72, 127)
        PictureBox1.BackColor = Color.FromArgb(13, 72, 127)
        Panel2.BackColor = Color.FromArgb(13, 72, 127)

        Dim equipe As String = LoginForm1.UsernameTextBox.Text
        LoginForm1.Close()
        titreLabel.Text = "Gestion des réparations des nids de poules - Équipe " & equipe & ", le " & Date.Today

        nidsListBox.Items.Add("Trou 1")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        LoginForm1.Show()
        Me.Close()
    End Sub

    Private Sub nidsListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles nidsListBox.SelectedIndexChanged
        Form2.Show()
    End Sub
End Class