<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.nidsLabel = New System.Windows.Forms.Label()
        Me.titreLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.rueLabel = New System.Windows.Forms.Label()
        Me.rueTextBox = New System.Windows.Forms.TextBox()
        Me.coordTextBox = New System.Windows.Forms.TextBox()
        Me.coordLabel = New System.Windows.Forms.Label()
        Me.dateTextBox = New System.Windows.Forms.TextBox()
        Me.dateLabel = New System.Windows.Forms.Label()
        Me.dimTextBox = New System.Windows.Forms.TextBox()
        Me.dimLabel = New System.Windows.Forms.Label()
        Me.comTextBox = New System.Windows.Forms.TextBox()
        Me.comLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ouiCheckBox = New System.Windows.Forms.CheckBox()
        Me.envoyerButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'nidsLabel
        '
        Me.nidsLabel.AutoSize = True
        Me.nidsLabel.Font = New System.Drawing.Font("Sans Serif Collection", 7.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nidsLabel.Location = New System.Drawing.Point(376, 235)
        Me.nidsLabel.Name = "nidsLabel"
        Me.nidsLabel.Size = New System.Drawing.Size(346, 39)
        Me.nidsLabel.TabIndex = 2
        Me.nidsLabel.Text = "Nids de Poule à compléter"
        '
        'titreLabel
        '
        Me.titreLabel.AutoSize = True
        Me.titreLabel.BackColor = System.Drawing.Color.White
        Me.titreLabel.Font = New System.Drawing.Font("Sans Serif Collection", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titreLabel.Location = New System.Drawing.Point(438, 140)
        Me.titreLabel.Name = "titreLabel"
        Me.titreLabel.Size = New System.Drawing.Size(1320, 59)
        Me.titreLabel.TabIndex = 13
        Me.titreLabel.Text = "Gestion des réparations des nids de poules - Équipe X le XX/XX/XXXX"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Highlight
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(630, 211)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, -6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2244, 125)
        Me.Panel1.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(2130, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 108)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "≡"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel2.Location = New System.Drawing.Point(0, 1295)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(2244, 40)
        Me.Panel2.TabIndex = 15
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.envoyerButton)
        Me.Panel3.Controls.Add(Me.ouiCheckBox)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.comTextBox)
        Me.Panel3.Controls.Add(Me.comLabel)
        Me.Panel3.Controls.Add(Me.dimTextBox)
        Me.Panel3.Controls.Add(Me.dimLabel)
        Me.Panel3.Controls.Add(Me.dateTextBox)
        Me.Panel3.Controls.Add(Me.dateLabel)
        Me.Panel3.Controls.Add(Me.coordTextBox)
        Me.Panel3.Controls.Add(Me.coordLabel)
        Me.Panel3.Controls.Add(Me.rueTextBox)
        Me.Panel3.Controls.Add(Me.rueLabel)
        Me.Panel3.Controls.Add(Me.nidsLabel)
        Me.Panel3.Location = New System.Drawing.Point(166, 87)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1910, 1266)
        Me.Panel3.TabIndex = 16
        '
        'rueLabel
        '
        Me.rueLabel.AutoSize = True
        Me.rueLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rueLabel.Location = New System.Drawing.Point(296, 307)
        Me.rueLabel.Name = "rueLabel"
        Me.rueLabel.Size = New System.Drawing.Size(57, 25)
        Me.rueLabel.TabIndex = 3
        Me.rueLabel.Text = "Rue:"
        '
        'rueTextBox
        '
        Me.rueTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rueTextBox.Location = New System.Drawing.Point(555, 304)
        Me.rueTextBox.Name = "rueTextBox"
        Me.rueTextBox.ReadOnly = True
        Me.rueTextBox.Size = New System.Drawing.Size(328, 30)
        Me.rueTextBox.TabIndex = 4
        '
        'coordTextBox
        '
        Me.coordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coordTextBox.Location = New System.Drawing.Point(555, 385)
        Me.coordTextBox.Name = "coordTextBox"
        Me.coordTextBox.ReadOnly = True
        Me.coordTextBox.Size = New System.Drawing.Size(328, 30)
        Me.coordTextBox.TabIndex = 6
        '
        'coordLabel
        '
        Me.coordLabel.AutoSize = True
        Me.coordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coordLabel.Location = New System.Drawing.Point(296, 388)
        Me.coordLabel.Name = "coordLabel"
        Me.coordLabel.Size = New System.Drawing.Size(149, 25)
        Me.coordLabel.TabIndex = 5
        Me.coordLabel.Text = "Coordonnées:"
        '
        'dateTextBox
        '
        Me.dateTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTextBox.Location = New System.Drawing.Point(555, 468)
        Me.dateTextBox.Name = "dateTextBox"
        Me.dateTextBox.ReadOnly = True
        Me.dateTextBox.Size = New System.Drawing.Size(328, 30)
        Me.dateTextBox.TabIndex = 8
        '
        'dateLabel
        '
        Me.dateLabel.AutoSize = True
        Me.dateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateLabel.Location = New System.Drawing.Point(296, 473)
        Me.dateLabel.Name = "dateLabel"
        Me.dateLabel.Size = New System.Drawing.Size(212, 25)
        Me.dateLabel.TabIndex = 7
        Me.dateLabel.Text = "Date de la demande:"
        '
        'dimTextBox
        '
        Me.dimTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dimTextBox.Location = New System.Drawing.Point(555, 548)
        Me.dimTextBox.Name = "dimTextBox"
        Me.dimTextBox.ReadOnly = True
        Me.dimTextBox.Size = New System.Drawing.Size(328, 30)
        Me.dimTextBox.TabIndex = 10
        '
        'dimLabel
        '
        Me.dimLabel.AutoSize = True
        Me.dimLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dimLabel.Location = New System.Drawing.Point(296, 553)
        Me.dimLabel.Name = "dimLabel"
        Me.dimLabel.Size = New System.Drawing.Size(204, 25)
        Me.dimLabel.TabIndex = 9
        Me.dimLabel.Text = "Dimensions du trou:"
        '
        'comTextBox
        '
        Me.comTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comTextBox.Location = New System.Drawing.Point(1000, 385)
        Me.comTextBox.Multiline = True
        Me.comTextBox.Name = "comTextBox"
        Me.comTextBox.ReadOnly = True
        Me.comTextBox.Size = New System.Drawing.Size(592, 299)
        Me.comTextBox.TabIndex = 12
        '
        'comLabel
        '
        Me.comLabel.AutoSize = True
        Me.comLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comLabel.Location = New System.Drawing.Point(995, 360)
        Me.comLabel.Name = "comLabel"
        Me.comLabel.Size = New System.Drawing.Size(158, 25)
        Me.comLabel.TabIndex = 11
        Me.comLabel.Text = "Commentaires:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(995, 307)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 25)
        Me.Label1.TabIndex = 13
        '
        'ouiCheckBox
        '
        Me.ouiCheckBox.AutoSize = True
        Me.ouiCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ouiCheckBox.Location = New System.Drawing.Point(1000, 303)
        Me.ouiCheckBox.Name = "ouiCheckBox"
        Me.ouiCheckBox.Size = New System.Drawing.Size(130, 29)
        Me.ouiCheckBox.TabIndex = 14
        Me.ouiCheckBox.Text = "Complété"
        Me.ouiCheckBox.UseVisualStyleBackColor = True
        '
        'envoyerButton
        '
        Me.envoyerButton.Location = New System.Drawing.Point(1000, 715)
        Me.envoyerButton.Name = "envoyerButton"
        Me.envoyerButton.Size = New System.Drawing.Size(153, 31)
        Me.envoyerButton.TabIndex = 15
        Me.envoyerButton.Text = "Envoyer"
        Me.envoyerButton.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(2244, 1335)
        Me.Controls.Add(Me.titreLabel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Nid de poule"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nidsLabel As Label
    Friend WithEvents titreLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents rueTextBox As TextBox
    Friend WithEvents rueLabel As Label
    Friend WithEvents dateTextBox As TextBox
    Friend WithEvents dateLabel As Label
    Friend WithEvents coordTextBox As TextBox
    Friend WithEvents coordLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents comTextBox As TextBox
    Friend WithEvents comLabel As Label
    Friend WithEvents dimTextBox As TextBox
    Friend WithEvents dimLabel As Label
    Friend WithEvents envoyerButton As Button
    Friend WithEvents ouiCheckBox As CheckBox
End Class
