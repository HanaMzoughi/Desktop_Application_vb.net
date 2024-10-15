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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.btn_en2 = New System.Windows.Forms.Button()
        Me.btn_supp2 = New System.Windows.Forms.Button()
        Me.btn_modif2 = New System.Windows.Forms.Button()
        Me.btn_rech2 = New System.Windows.Forms.Button()
        Me.btn_quit2 = New System.Windows.Forms.Button()
        Me.cb_rech2 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(422, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Article"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(148, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Code Article"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(148, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Prix"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(148, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Quantité"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(148, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Montant"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(334, 99)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(225, 22)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(334, 152)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(225, 22)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(334, 202)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(225, 22)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(334, 251)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(225, 22)
        Me.TextBox4.TabIndex = 8
        '
        'btn_en2
        '
        Me.btn_en2.Location = New System.Drawing.Point(14, 353)
        Me.btn_en2.Name = "btn_en2"
        Me.btn_en2.Size = New System.Drawing.Size(105, 37)
        Me.btn_en2.TabIndex = 9
        Me.btn_en2.Text = "Enregistrer"
        Me.btn_en2.UseVisualStyleBackColor = True
        '
        'btn_supp2
        '
        Me.btn_supp2.Location = New System.Drawing.Point(125, 352)
        Me.btn_supp2.Name = "btn_supp2"
        Me.btn_supp2.Size = New System.Drawing.Size(112, 36)
        Me.btn_supp2.TabIndex = 10
        Me.btn_supp2.Text = "Supprimer"
        Me.btn_supp2.UseVisualStyleBackColor = True
        '
        'btn_modif2
        '
        Me.btn_modif2.Location = New System.Drawing.Point(252, 353)
        Me.btn_modif2.Name = "btn_modif2"
        Me.btn_modif2.Size = New System.Drawing.Size(125, 38)
        Me.btn_modif2.TabIndex = 11
        Me.btn_modif2.Text = "Modifier"
        Me.btn_modif2.UseVisualStyleBackColor = True
        '
        'btn_rech2
        '
        Me.btn_rech2.Location = New System.Drawing.Point(383, 354)
        Me.btn_rech2.Name = "btn_rech2"
        Me.btn_rech2.Size = New System.Drawing.Size(127, 37)
        Me.btn_rech2.TabIndex = 12
        Me.btn_rech2.Text = "Rechercher"
        Me.btn_rech2.UseVisualStyleBackColor = True
        '
        'btn_quit2
        '
        Me.btn_quit2.Location = New System.Drawing.Point(676, 354)
        Me.btn_quit2.Name = "btn_quit2"
        Me.btn_quit2.Size = New System.Drawing.Size(118, 37)
        Me.btn_quit2.TabIndex = 13
        Me.btn_quit2.Text = "Quitter"
        Me.btn_quit2.UseVisualStyleBackColor = True
        '
        'cb_rech2
        '
        Me.cb_rech2.FormattingEnabled = True
        Me.cb_rech2.Location = New System.Drawing.Point(535, 359)
        Me.cb_rech2.Name = "cb_rech2"
        Me.cb_rech2.Size = New System.Drawing.Size(121, 24)
        Me.cb_rech2.TabIndex = 14
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 455)
        Me.Controls.Add(Me.cb_rech2)
        Me.Controls.Add(Me.btn_quit2)
        Me.Controls.Add(Me.btn_rech2)
        Me.Controls.Add(Me.btn_modif2)
        Me.Controls.Add(Me.btn_supp2)
        Me.Controls.Add(Me.btn_en2)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents btn_en2 As System.Windows.Forms.Button
    Friend WithEvents btn_supp2 As System.Windows.Forms.Button
    Friend WithEvents btn_modif2 As System.Windows.Forms.Button
    Friend WithEvents btn_rech2 As System.Windows.Forms.Button
    Friend WithEvents btn_quit2 As System.Windows.Forms.Button
    Friend WithEvents cb_rech2 As System.Windows.Forms.ComboBox
End Class
