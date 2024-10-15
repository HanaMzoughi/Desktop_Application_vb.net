<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lab = New System.Windows.Forms.Label()
        Me.lab1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_num_art2 = New System.Windows.Forms.TextBox()
        Me.TXT_PRIX2 = New System.Windows.Forms.TextBox()
        Me.TXT_QTITE2 = New System.Windows.Forms.TextBox()
        Me.TXT_MNT2 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Btn_ajt2 = New System.Windows.Forms.Button()
        Me.Btn_supp2 = New System.Windows.Forms.Button()
        Me.btn_modif2 = New System.Windows.Forms.Button()
        Me.btn_rech2 = New System.Windows.Forms.Button()
        Me.cb_art2 = New System.Windows.Forms.ComboBox()
        Me.btn_quit2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(334, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Article"
        '
        'lab
        '
        Me.lab.AutoSize = True
        Me.lab.Location = New System.Drawing.Point(108, 77)
        Me.lab.Name = "lab"
        Me.lab.Size = New System.Drawing.Size(67, 17)
        Me.lab.TabIndex = 1
        Me.lab.Text = "N° Article"
        '
        'lab1
        '
        Me.lab1.AutoSize = True
        Me.lab1.Location = New System.Drawing.Point(127, 129)
        Me.lab1.Name = "lab1"
        Me.lab1.Size = New System.Drawing.Size(31, 17)
        Me.lab1.TabIndex = 2
        Me.lab1.Text = "Prix"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(116, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "quantité"
        '
        'txt_num_art2
        '
        Me.txt_num_art2.Location = New System.Drawing.Point(288, 77)
        Me.txt_num_art2.Name = "txt_num_art2"
        Me.txt_num_art2.Size = New System.Drawing.Size(170, 22)
        Me.txt_num_art2.TabIndex = 4
        '
        'TXT_PRIX2
        '
        Me.TXT_PRIX2.Location = New System.Drawing.Point(287, 129)
        Me.TXT_PRIX2.Name = "TXT_PRIX2"
        Me.TXT_PRIX2.Size = New System.Drawing.Size(170, 22)
        Me.TXT_PRIX2.TabIndex = 5
        '
        'TXT_QTITE2
        '
        Me.TXT_QTITE2.Location = New System.Drawing.Point(284, 171)
        Me.TXT_QTITE2.Name = "TXT_QTITE2"
        Me.TXT_QTITE2.Size = New System.Drawing.Size(169, 22)
        Me.TXT_QTITE2.TabIndex = 6
        '
        'TXT_MNT2
        '
        Me.TXT_MNT2.AutoSize = True
        Me.TXT_MNT2.Location = New System.Drawing.Point(116, 232)
        Me.TXT_MNT2.Name = "TXT_MNT2"
        Me.TXT_MNT2.Size = New System.Drawing.Size(59, 17)
        Me.TXT_MNT2.TabIndex = 7
        Me.TXT_MNT2.Text = "Montant"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(280, 232)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(173, 22)
        Me.TextBox4.TabIndex = 8
        '
        'Btn_ajt2
        '
        Me.Btn_ajt2.Location = New System.Drawing.Point(15, 334)
        Me.Btn_ajt2.Name = "Btn_ajt2"
        Me.Btn_ajt2.Size = New System.Drawing.Size(98, 22)
        Me.Btn_ajt2.TabIndex = 9
        Me.Btn_ajt2.Text = "Ajouter"
        Me.Btn_ajt2.UseVisualStyleBackColor = True
        '
        'Btn_supp2
        '
        Me.Btn_supp2.Location = New System.Drawing.Point(119, 334)
        Me.Btn_supp2.Name = "Btn_supp2"
        Me.Btn_supp2.Size = New System.Drawing.Size(102, 23)
        Me.Btn_supp2.TabIndex = 10
        Me.Btn_supp2.Text = "Supprimer"
        Me.Btn_supp2.UseVisualStyleBackColor = True
        '
        'btn_modif2
        '
        Me.btn_modif2.Location = New System.Drawing.Point(227, 334)
        Me.btn_modif2.Name = "btn_modif2"
        Me.btn_modif2.Size = New System.Drawing.Size(104, 23)
        Me.btn_modif2.TabIndex = 11
        Me.btn_modif2.Text = "Modifier"
        Me.btn_modif2.UseVisualStyleBackColor = True
        '
        'btn_rech2
        '
        Me.btn_rech2.Location = New System.Drawing.Point(346, 334)
        Me.btn_rech2.Name = "btn_rech2"
        Me.btn_rech2.Size = New System.Drawing.Size(100, 23)
        Me.btn_rech2.TabIndex = 12
        Me.btn_rech2.Text = "Rechercher"
        Me.btn_rech2.UseVisualStyleBackColor = True
        '
        'cb_art2
        '
        Me.cb_art2.FormattingEnabled = True
        Me.cb_art2.Location = New System.Drawing.Point(479, 332)
        Me.cb_art2.Name = "cb_art2"
        Me.cb_art2.Size = New System.Drawing.Size(154, 24)
        Me.cb_art2.TabIndex = 13
        '
        'btn_quit2
        '
        Me.btn_quit2.Location = New System.Drawing.Point(650, 332)
        Me.btn_quit2.Name = "btn_quit2"
        Me.btn_quit2.Size = New System.Drawing.Size(110, 23)
        Me.btn_quit2.TabIndex = 14
        Me.btn_quit2.Text = "Quitter"
        Me.btn_quit2.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 427)
        Me.Controls.Add(Me.btn_quit2)
        Me.Controls.Add(Me.cb_art2)
        Me.Controls.Add(Me.btn_rech2)
        Me.Controls.Add(Me.btn_modif2)
        Me.Controls.Add(Me.Btn_supp2)
        Me.Controls.Add(Me.Btn_ajt2)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TXT_MNT2)
        Me.Controls.Add(Me.TXT_QTITE2)
        Me.Controls.Add(Me.TXT_PRIX2)
        Me.Controls.Add(Me.txt_num_art2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lab1)
        Me.Controls.Add(Me.lab)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Article"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lab As System.Windows.Forms.Label
    Friend WithEvents lab1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_num_art2 As System.Windows.Forms.TextBox
    Friend WithEvents TXT_PRIX2 As System.Windows.Forms.TextBox
    Friend WithEvents TXT_QTITE2 As System.Windows.Forms.TextBox
    Friend WithEvents TXT_MNT2 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Btn_ajt2 As System.Windows.Forms.Button
    Friend WithEvents Btn_supp2 As System.Windows.Forms.Button
    Friend WithEvents btn_modif2 As System.Windows.Forms.Button
    Friend WithEvents btn_rech2 As System.Windows.Forms.Button
    Friend WithEvents cb_art2 As System.Windows.Forms.ComboBox
    Friend WithEvents btn_quit2 As System.Windows.Forms.Button

End Class
