Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(13, 72, 127)
        PictureBox1.BackColor = Color.FromArgb(13, 72, 127)
        Panel2.BackColor = Color.FromArgb(13, 72, 127)

        titreLabel.Text = Form1.titreLabel.Text

        'Dim webClient As New System.Net.WebClient
        'Dim result As String = webClient.DownloadString("http://localhost:8080/data")
        'donneeLabel.Text = "Données reçues: " & vbNewLine & """" & result & """"


        rueTextBox.Text = "Boulevard Alexandre-Taché"
        coordTextBox.Text = "45.422718, -75.741300"
        dateTextBox.Text = "2024-04-27 14:27"
        typeComboBox.SelectedText = typeComboBox.Items.Item(0)
        equipeTextBox.Text = "1"
        dimTextBox.Text = "40 x 35 cm, 10 cm de profondeur"
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub ouiCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles comCheckBox.CheckedChanged
        comTextBox.ReadOnly = Not comCheckBox.Checked
        If comCheckBox.Checked Then
            comDateTextBox.Text = Date.Today & " " & TimeOfDay.Hour & ":" & TimeOfDay.Minute
        End If
    End Sub

    Private Sub envoyerButton_Click(sender As Object, e As EventArgs) Handles envoyerButton.Click
        If comCheckBox.Checked Then
            Form1.nidsCompListBox.Items.Add(Form1.nidsListBox.SelectedItem)
            Form1.nidsListBox.Items.Remove(Form1.nidsListBox.SelectedItem)
            Me.Close()
        End If
    End Sub
End Class