Imports System.Data
Imports System.Data.SqlClient

Public Class Form2

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles btn_quit2.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        remplir_cmb()
        connexionbase()
    End Sub

    Private Sub remplir_cmb()
        cm.ConnectionString = "Data Source=DESKTOP-7IPAE0K;Initial Catalog=Bon_de_commande;Integrated Security=True"
        cm.Open()
        Dim str As String = "Select COD_ART from Article1"
        cmd = New SqlCommand(str, cm)
        dr = cmd.ExecuteReader
        While (dr.Read)
            cb_rech2.Items.Add(dr("COD_ART"))
        End While
        dr.Close()
        cm.Close()
    End Sub

    Private Sub btn_en2_Click(sender As System.Object, e As System.EventArgs) Handles btn_en2.Click
        Try
            cm.ConnectionString = "Data Source=DESKTOP-7IPAE0K;Initial Catalog=Bon_de_commande;Integrated Security=True"
            cm.Open()
            If cm.State = ConnectionState.Open Then
                cmd.Connection = cm
                cmd.CommandText = "Insert into Article1 (COD_ART,PRIX,QTITE,MNT) values (' " & (TextBox1.Text) & "','" & (TextBox2.Text) & "','" & (TextBox3.Text) & "','" & (TextBox4.Text) & "')"
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()
                MessageBox.Show("ajout avec succés")
            Else
                MessageBox.Show("echec d'ajout")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

        cm.Close()
    End Sub

    Private Sub btn_supp2_Click(sender As System.Object, e As System.EventArgs) Handles btn_supp2.Click
        Try
            cm.ConnectionString = "Data Source=DESKTOP-7IPAE0K;Initial Catalog=Bon_de_commande;Integrated Security=True"
            cm.Open()
            cmd.Connection = cm
            cmd.CommandText = "Delete From Article1 where COD_ART = (' " & (TextBox1.Text) & "')"
            cmd.ExecuteNonQuery()
            If MessageBox.Show("voulez-vous vraiment supprimer cet article?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then

                MessageBox.Show("suppression annuler")
            Else
                MessageBox.Show("Suppression terminée avec succès")
                Exit Sub

            End If
        Catch ex As Exception
            MessageBox.Show("erreur de suppression..." & ex.Message, "Delete Records")

        Finally

            cm.Close()
        End Try
    End Sub

    Private Sub btn_modif2_Click(sender As System.Object, e As System.EventArgs) Handles btn_modif2.Click
        Try
            cm.ConnectionString = "Data Source=DESKTOP-7IPAE0K;Initial Catalog=Bon_de_commande;Integrated Security=True"
            cm.Open()
            If cm.State = ConnectionState.Open Then
                cmd.Connection = cm
                cmd.CommandText = "update Article1 set PRIX='" + TextBox2.Text + "',QTITE='" + TextBox3.Text + "',MNT='" + TextBox4.Text + "' where COD_ART = (' " & (TextBox1.Text) & "')"
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()
                MessageBox.Show("modification avec succés")
            Else
                MessageBox.Show("echec de modification")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

        cm.Close()
    End Sub

    Private Sub btn_rech2_Click(sender As System.Object, e As System.EventArgs) Handles btn_rech2.Click
        Try
            Dim sql As String = "select * from Article1 where COD_ART= '" & cb_rech2.SelectedItem & "'"
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            Dim di As DialogResult
            di = MessageBox.Show("vous êtes sur de chercher cet auteur ", "attention", MessageBoxButtons.YesNo)
            If (di = Windows.Forms.DialogResult.Yes) Then
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    TextBox1.Text = dr.GetValue(0)
                    TextBox2.Text = dr.GetValue(1)
                    TextBox3.Text = dr.GetValue(2)
                    TextBox4.Text = dr.GetValue(3)

                    MessageBox.Show("recherche effectué par succés")
                Else
                    MessageBox.Show("l'article rechercher n'existe pas ")
                End If
                dr.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class