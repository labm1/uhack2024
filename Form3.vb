Imports System.Collections.Specialized.BitVector32

Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(13, 72, 127)
        PictureBox1.BackColor = Color.FromArgb(13, 72, 127)
        Panel2.BackColor = Color.FromArgb(13, 72, 127)

        Dim equipe As String = LoginForm1.UsernameTextBox.Text
        LoginForm1.Close()
        nidsLabel.Text = "Nids de poule à compléter aujourd'hui (" & Date.Today & ")"

        nidsListBox.Items.Add("Trou 1")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        LoginForm1.Show()
        Me.Close()
    End Sub

    Private Sub nidsListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles nidsListBox.SelectedIndexChanged
        Form2.Show()
        Form2.equipeLabel.Visible = True
        Form2.equipeTextBox.Visible = True
        Form2.envoyerButton.Visible = False
        Form2.titreLabel.Text = "Gestion des réparations des nids de poules"
    End Sub
End Class