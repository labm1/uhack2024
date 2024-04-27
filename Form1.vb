Imports System.Collections.Specialized.BitVector32

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(13, 72, 127)
        PictureBox1.BackColor = Color.FromArgb(13, 72, 127)
        Panel2.BackColor = Color.FromArgb(13, 72, 127)

        Dim equipe As String = LoginForm1.UsernameTextBox.Text
        LoginForm1.Close()
        titreLabel.Text = "Gestion des réparations des nids de poules - Équipe " & equipe & ", le " & Date.Today

        nidsListBox.Items.Add("Nid de poule sur la rue Pharand                      " & vbTab & "Type de route: Rue locale")
        nidsListBox.Items.Add("Nid de poule sur le boulevard Alexandre-Taché        " & vbTab & "Type de route: Artère principale")
        nidsListBox.Items.Add("Nid de poule sur le boulevard Saint-Joseph           " & vbTab & "Type de route: Artère principale")
        nidsListBox.Items.Add("Nid de poule sur la rue Montcalm                     " & vbTab & "Type de route: Rue collectrice")
        nidsListBox.Items.Add("Nid de poule sur la rue Papineau                     " & vbTab & "Type de route: Rue locale")
        nidsListBox.Items.Add("Nid de poule sur la rue de l'Hotel-de-ville          " & vbTab & "Type de route: Rue locale")
        nidsListBox.Items.Add("Nid de poule sur la rue Wright                       " & vbTab & vbTab & "Type de route: Rue locale")
        nidsListBox.Items.Add("Nid de poule sur la rue Wellington                   " & vbTab & "Type de route: Rue locale")
        nidsListBox.Items.Add("Nid de poule sur la Promenade du Portage             " & vbTab & "Type de route: Artère principale")
        nidsListBox.Items.Add("Nid de poule sur la rue Laurier                      " & vbTab & vbTab & "Type de route: Rue collectrice")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        LoginForm1.Show()
        Me.Close()
    End Sub

    Private Sub nidsListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles nidsListBox.SelectedIndexChanged
        Form2.Show()
        Form2.nidsLabel.Text = "Nid de poule sur le boulevard Alexandre-Taché"
    End Sub
End Class