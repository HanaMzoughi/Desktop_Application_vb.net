<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TXT_NUM_COM = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CB_CLIENT = New System.Windows.Forms.ComboBox()
        Me.TXT_CLI = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXT_NUM_ART = New System.Windows.Forms.TextBox()
        Me.TXT_MNT = New System.Windows.Forms.TextBox()
        Me.TXT_QTITE = New System.Windows.Forms.TextBox()
        Me.TXT_PRIX = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.GB_COMM = New System.Windows.Forms.GroupBox()
        Me.GB_LIGHNE = New System.Windows.Forms.GroupBox()
        Me.BTN_AJOUT = New System.Windows.Forms.Button()
        Me.GB_LIG_COMM = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DG_LIG_COMM = New System.Windows.Forms.DataGridView()
        Me.CL_COD_AR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CL_PRIX = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CL_QTITE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CL_MNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CB_RECH = New System.Windows.Forms.ComboBox()
        Me.BTN_QTE = New System.Windows.Forms.Button()
        Me.BTN_RECHER = New System.Windows.Forms.Button()
        Me.BTN_MODIF = New System.Windows.Forms.Button()
        Me.BTN_SUPP = New System.Windows.Forms.Button()
        Me.BTN_ENREGI = New System.Windows.Forms.Button()
        Me.GB_COMM.SuspendLayout()
        Me.GB_LIGHNE.SuspendLayout()
        Me.GB_LIG_COMM.SuspendLayout()
        CType(Me.DG_LIG_COMM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXT_NUM_COM
        '
        Me.TXT_NUM_COM.Location = New System.Drawing.Point(122, 56)
        Me.TXT_NUM_COM.Name = "TXT_NUM_COM"
        Me.TXT_NUM_COM.Size = New System.Drawing.Size(102, 22)
        Me.TXT_NUM_COM.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "N°Commande"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(276, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Date BC"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Client:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Date Livraison:"
        '
        'CB_CLIENT
        '
        Me.CB_CLIENT.FormattingEnabled = True
        Me.CB_CLIENT.Location = New System.Drawing.Point(98, 97)
        Me.CB_CLIENT.Name = "CB_CLIENT"
        Me.CB_CLIENT.Size = New System.Drawing.Size(143, 24)
        Me.CB_CLIENT.TabIndex = 7
        '
        'TXT_CLI
        '
        Me.TXT_CLI.Location = New System.Drawing.Point(279, 100)
        Me.TXT_CLI.Name = "TXT_CLI"
        Me.TXT_CLI.Size = New System.Drawing.Size(266, 22)
        Me.TXT_CLI.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "N°Article"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(196, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 17)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Prix"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(368, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 17)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Quantité"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(572, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 17)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Montant"
        '
        'TXT_NUM_ART
        '
        Me.TXT_NUM_ART.Location = New System.Drawing.Point(75, 34)
        Me.TXT_NUM_ART.Name = "TXT_NUM_ART"
        Me.TXT_NUM_ART.Size = New System.Drawing.Size(115, 22)
        Me.TXT_NUM_ART.TabIndex = 13
        '
        'TXT_MNT
        '
        Me.TXT_MNT.Location = New System.Drawing.Point(642, 31)
        Me.TXT_MNT.Name = "TXT_MNT"
        Me.TXT_MNT.Size = New System.Drawing.Size(128, 22)
        Me.TXT_MNT.TabIndex = 14
        '
        'TXT_QTITE
        '
        Me.TXT_QTITE.Location = New System.Drawing.Point(438, 34)
        Me.TXT_QTITE.Name = "TXT_QTITE"
        Me.TXT_QTITE.Size = New System.Drawing.Size(128, 22)
        Me.TXT_QTITE.TabIndex = 15
        '
        'TXT_PRIX
        '
        Me.TXT_PRIX.Location = New System.Drawing.Point(233, 36)
        Me.TXT_PRIX.Name = "TXT_PRIX"
        Me.TXT_PRIX.Size = New System.Drawing.Size(120, 22)
        Me.TXT_PRIX.TabIndex = 16
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(115, 137)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 18
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(359, 54)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker2.TabIndex = 19
        '
        'GB_COMM
        '
        Me.GB_COMM.Controls.Add(Me.DateTimePicker1)
        Me.GB_COMM.Controls.Add(Me.DateTimePicker2)
        Me.GB_COMM.Controls.Add(Me.Label2)
        Me.GB_COMM.Controls.Add(Me.TXT_NUM_COM)
        Me.GB_COMM.Controls.Add(Me.Label3)
        Me.GB_COMM.Controls.Add(Me.Label4)
        Me.GB_COMM.Controls.Add(Me.CB_CLIENT)
        Me.GB_COMM.Controls.Add(Me.TXT_CLI)
        Me.GB_COMM.Controls.Add(Me.Label5)
        Me.GB_COMM.Location = New System.Drawing.Point(12, 12)
        Me.GB_COMM.Name = "GB_COMM"
        Me.GB_COMM.Size = New System.Drawing.Size(954, 185)
        Me.GB_COMM.TabIndex = 20
        Me.GB_COMM.TabStop = False
        Me.GB_COMM.Text = "Commande"
        '
        'GB_LIGHNE
        '
        Me.GB_LIGHNE.Controls.Add(Me.BTN_AJOUT)
        Me.GB_LIGHNE.Controls.Add(Me.Label7)
        Me.GB_LIGHNE.Controls.Add(Me.TXT_NUM_ART)
        Me.GB_LIGHNE.Controls.Add(Me.Label8)
        Me.GB_LIGHNE.Controls.Add(Me.TXT_MNT)
        Me.GB_LIGHNE.Controls.Add(Me.TXT_PRIX)
        Me.GB_LIGHNE.Controls.Add(Me.Label10)
        Me.GB_LIGHNE.Controls.Add(Me.TXT_QTITE)
        Me.GB_LIGHNE.Controls.Add(Me.Label9)
        Me.GB_LIGHNE.Location = New System.Drawing.Point(12, 203)
        Me.GB_LIGHNE.Name = "GB_LIGHNE"
        Me.GB_LIGHNE.Size = New System.Drawing.Size(954, 87)
        Me.GB_LIGHNE.TabIndex = 20
        Me.GB_LIGHNE.TabStop = False
        Me.GB_LIGHNE.Text = "Ligne"
        '
        'BTN_AJOUT
        '
        Me.BTN_AJOUT.Location = New System.Drawing.Point(788, 26)
        Me.BTN_AJOUT.Name = "BTN_AJOUT"
        Me.BTN_AJOUT.Size = New System.Drawing.Size(145, 32)
        Me.BTN_AJOUT.TabIndex = 0
        Me.BTN_AJOUT.Text = "Ajout"
        Me.BTN_AJOUT.UseVisualStyleBackColor = True
        '
        'GB_LIG_COMM
        '
        Me.GB_LIG_COMM.Controls.Add(Me.Button1)
        Me.GB_LIG_COMM.Controls.Add(Me.DG_LIG_COMM)
        Me.GB_LIG_COMM.Location = New System.Drawing.Point(12, 327)
        Me.GB_LIG_COMM.Name = "GB_LIG_COMM"
        Me.GB_LIG_COMM.Size = New System.Drawing.Size(954, 205)
        Me.GB_LIG_COMM.TabIndex = 17
        Me.GB_LIG_COMM.TabStop = False
        Me.GB_LIG_COMM.Text = "Lignes Commande"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(745, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 39)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Enregistrer article"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DG_LIG_COMM
        '
        Me.DG_LIG_COMM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_LIG_COMM.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CL_COD_AR, Me.CL_PRIX, Me.CL_QTITE, Me.CL_MNT})
        Me.DG_LIG_COMM.Location = New System.Drawing.Point(75, 30)
        Me.DG_LIG_COMM.Name = "DG_LIG_COMM"
        Me.DG_LIG_COMM.RowTemplate.Height = 24
        Me.DG_LIG_COMM.Size = New System.Drawing.Size(590, 169)
        Me.DG_LIG_COMM.TabIndex = 0
        '
        'CL_COD_AR
        '
        Me.CL_COD_AR.HeaderText = "Code Article"
        Me.CL_COD_AR.Name = "CL_COD_AR"
        '
        'CL_PRIX
        '
        Me.CL_PRIX.HeaderText = "Prix"
        Me.CL_PRIX.Name = "CL_PRIX"
        '
        'CL_QTITE
        '
        Me.CL_QTITE.HeaderText = "Quantité"
        Me.CL_QTITE.Name = "CL_QTITE"
        '
        'CL_MNT
        '
        Me.CL_MNT.HeaderText = "Montant "
        Me.CL_MNT.Name = "CL_MNT"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CB_RECH)
        Me.GroupBox4.Controls.Add(Me.BTN_QTE)
        Me.GroupBox4.Controls.Add(Me.BTN_RECHER)
        Me.GroupBox4.Controls.Add(Me.BTN_MODIF)
        Me.GroupBox4.Controls.Add(Me.BTN_SUPP)
        Me.GroupBox4.Controls.Add(Me.BTN_ENREGI)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 538)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(954, 86)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'CB_RECH
        '
        Me.CB_RECH.FormattingEnabled = True
        Me.CB_RECH.Location = New System.Drawing.Point(642, 39)
        Me.CB_RECH.Name = "CB_RECH"
        Me.CB_RECH.Size = New System.Drawing.Size(154, 24)
        Me.CB_RECH.TabIndex = 22
        '
        'BTN_QTE
        '
        Me.BTN_QTE.Location = New System.Drawing.Point(815, 35)
        Me.BTN_QTE.Name = "BTN_QTE"
        Me.BTN_QTE.Size = New System.Drawing.Size(118, 30)
        Me.BTN_QTE.TabIndex = 21
        Me.BTN_QTE.Text = "Quitter"
        Me.BTN_QTE.UseVisualStyleBackColor = True
        '
        'BTN_RECHER
        '
        Me.BTN_RECHER.Location = New System.Drawing.Point(465, 39)
        Me.BTN_RECHER.Name = "BTN_RECHER"
        Me.BTN_RECHER.Size = New System.Drawing.Size(139, 27)
        Me.BTN_RECHER.TabIndex = 20
        Me.BTN_RECHER.Text = "Recherche"
        Me.BTN_RECHER.UseVisualStyleBackColor = True
        '
        'BTN_MODIF
        '
        Me.BTN_MODIF.Location = New System.Drawing.Point(306, 40)
        Me.BTN_MODIF.Name = "BTN_MODIF"
        Me.BTN_MODIF.Size = New System.Drawing.Size(134, 26)
        Me.BTN_MODIF.TabIndex = 19
        Me.BTN_MODIF.Text = "Modifier"
        Me.BTN_MODIF.UseVisualStyleBackColor = True
        '
        'BTN_SUPP
        '
        Me.BTN_SUPP.Location = New System.Drawing.Point(147, 40)
        Me.BTN_SUPP.Name = "BTN_SUPP"
        Me.BTN_SUPP.Size = New System.Drawing.Size(137, 29)
        Me.BTN_SUPP.TabIndex = 18
        Me.BTN_SUPP.Text = "Supprimer"
        Me.BTN_SUPP.UseVisualStyleBackColor = True
        '
        'BTN_ENREGI
        '
        Me.BTN_ENREGI.Location = New System.Drawing.Point(6, 41)
        Me.BTN_ENREGI.Name = "BTN_ENREGI"
        Me.BTN_ENREGI.Size = New System.Drawing.Size(132, 26)
        Me.BTN_ENREGI.TabIndex = 17
        Me.BTN_ENREGI.Text = "Enregistrer"
        Me.BTN_ENREGI.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 636)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GB_LIG_COMM)
        Me.Controls.Add(Me.GB_LIGHNE)
        Me.Controls.Add(Me.GB_COMM)
        Me.Name = "Form1"
        Me.Text = "Bon Commande"
        Me.GB_COMM.ResumeLayout(False)
        Me.GB_COMM.PerformLayout()
        Me.GB_LIGHNE.ResumeLayout(False)
        Me.GB_LIGHNE.PerformLayout()
        Me.GB_LIG_COMM.ResumeLayout(False)
        CType(Me.DG_LIG_COMM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TXT_NUM_COM As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CB_CLIENT As System.Windows.Forms.ComboBox
    Friend WithEvents TXT_CLI As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TXT_NUM_ART As System.Windows.Forms.TextBox
    Friend WithEvents TXT_MNT As System.Windows.Forms.TextBox
    Friend WithEvents TXT_QTITE As System.Windows.Forms.TextBox
    Friend WithEvents TXT_PRIX As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GB_COMM As System.Windows.Forms.GroupBox
    Friend WithEvents GB_LIGHNE As System.Windows.Forms.GroupBox
    Friend WithEvents BTN_AJOUT As System.Windows.Forms.Button
    Friend WithEvents GB_LIG_COMM As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents CB_RECH As System.Windows.Forms.ComboBox
    Friend WithEvents BTN_QTE As System.Windows.Forms.Button
    Friend WithEvents BTN_RECHER As System.Windows.Forms.Button
    Friend WithEvents BTN_MODIF As System.Windows.Forms.Button
    Friend WithEvents BTN_SUPP As System.Windows.Forms.Button
    Friend WithEvents BTN_ENREGI As System.Windows.Forms.Button
    Friend WithEvents DG_LIG_COMM As System.Windows.Forms.DataGridView
    Friend WithEvents CL_COD_AR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CL_PRIX As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CL_QTITE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CL_MNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
