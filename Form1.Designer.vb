<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.trajetLabel = New System.Windows.Forms.Label()
        Me.nidsLabel = New System.Windows.Forms.Label()
        Me.nidsListBox = New System.Windows.Forms.ListBox()
        Me.nidsCompListBox = New System.Windows.Forms.ListBox()
        Me.nidsCompLabel = New System.Windows.Forms.Label()
        Me.titreLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'trajetLabel
        '
        Me.trajetLabel.AutoSize = True
        Me.trajetLabel.Font = New System.Drawing.Font("Sans Serif Collection", 7.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trajetLabel.Location = New System.Drawing.Point(103, 431)
        Me.trajetLabel.Name = "trajetLabel"
        Me.trajetLabel.Size = New System.Drawing.Size(93, 39)
        Me.trajetLabel.TabIndex = 1
        Me.trajetLabel.Text = "Trajet"
        '
        'nidsLabel
        '
        Me.nidsLabel.AutoSize = True
        Me.nidsLabel.Font = New System.Drawing.Font("Sans Serif Collection", 7.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nidsLabel.Location = New System.Drawing.Point(103, 145)
        Me.nidsLabel.Name = "nidsLabel"
        Me.nidsLabel.Size = New System.Drawing.Size(346, 39)
        Me.nidsLabel.TabIndex = 2
        Me.nidsLabel.Text = "Nids de Poule à compléter"
        '
        'nidsListBox
        '
        Me.nidsListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nidsListBox.FormattingEnabled = True
        Me.nidsListBox.ItemHeight = 25
        Me.nidsListBox.Location = New System.Drawing.Point(65, 187)
        Me.nidsListBox.Name = "nidsListBox"
        Me.nidsListBox.Size = New System.Drawing.Size(1525, 204)
        Me.nidsListBox.TabIndex = 3
        '
        'nidsCompListBox
        '
        Me.nidsCompListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nidsCompListBox.FormattingEnabled = True
        Me.nidsCompListBox.ItemHeight = 25
        Me.nidsCompListBox.Location = New System.Drawing.Point(65, 952)
        Me.nidsCompListBox.Name = "nidsCompListBox"
        Me.nidsCompListBox.Size = New System.Drawing.Size(1525, 204)
        Me.nidsCompListBox.TabIndex = 5
        '
        'nidsCompLabel
        '
        Me.nidsCompLabel.AutoSize = True
        Me.nidsCompLabel.Font = New System.Drawing.Font("Sans Serif Collection", 7.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nidsCompLabel.Location = New System.Drawing.Point(103, 910)
        Me.nidsCompLabel.Name = "nidsCompLabel"
        Me.nidsCompLabel.Size = New System.Drawing.Size(330, 39)
        Me.nidsCompLabel.TabIndex = 4
        Me.nidsCompLabel.Text = "Nids de Poule complétés"
        '
        'titreLabel
        '
        Me.titreLabel.AutoSize = True
        Me.titreLabel.BackColor = System.Drawing.Color.White
        Me.titreLabel.Font = New System.Drawing.Font("Sans Serif Collection", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titreLabel.Location = New System.Drawing.Point(438, 145)
        Me.titreLabel.Name = "titreLabel"
        Me.titreLabel.Size = New System.Drawing.Size(1320, 59)
        Me.titreLabel.TabIndex = 6
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
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2244, 125)
        Me.Panel1.TabIndex = 9
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
        Me.Panel2.Location = New System.Drawing.Point(0, 1300)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(2244, 40)
        Me.Panel2.TabIndex = 11
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.nidsCompListBox)
        Me.Panel3.Controls.Add(Me.nidsCompLabel)
        Me.Panel3.Controls.Add(Me.nidsListBox)
        Me.Panel3.Controls.Add(Me.nidsLabel)
        Me.Panel3.Controls.Add(Me.trajetLabel)
        Me.Panel3.Location = New System.Drawing.Point(166, 92)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1910, 1266)
        Me.Panel3.TabIndex = 12
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(65, 473)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(633, 399)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(2244, 1347)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.titreLabel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Gestion Nids de Poule VDG"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents trajetLabel As Label
    Friend WithEvents nidsLabel As Label
    Friend WithEvents nidsListBox As ListBox
    Friend WithEvents nidsCompListBox As ListBox
    Friend WithEvents nidsCompLabel As Label
    Friend WithEvents titreLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
End Class
