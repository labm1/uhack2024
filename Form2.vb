Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(13, 72, 127)
        PictureBox1.BackColor = Color.FromArgb(13, 72, 127)
        Panel2.BackColor = Color.FromArgb(13, 72, 127)

        titreLabel.Text = Form1.titreLabel.Text

        Dim nid As String = Form1.nidsListBox.SelectedItem
        nidsLabel.Text = nid
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form1.Show()
        Form1.titreLabel.Text = titreLabel.Text
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