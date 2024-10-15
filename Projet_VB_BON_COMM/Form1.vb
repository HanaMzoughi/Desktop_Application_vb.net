Imports System.Data.SqlClient

Public Class Form1

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TXT_CLI.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As System.Object, e As System.EventArgs) Handles TXT_QTITE.TextChanged

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles BTN_MODIF.Click
        Try
            cm.ConnectionString = "Data Source=DESKTOP-7IPAE0K;Initial Catalog=Bon_de_commande;Integrated Security=True"
            cm.Open()
            If cm.State = ConnectionState.Open Then
                cmd.Connection = cm
                cmd.CommandText = "update Article1 set PRIX='" + TXT_PRIX.Text + "',QTITE='" + TXT_QTITE.Text + "',MNT='" + TXT_MNT.Text + "' where COD_ART = (' " & (TXT_NUM_ART.Text) & "')"
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()
                MessageBox.Show("modification avec succés")
            Else
                MessageBox.Show("echec de modification")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        TXT_PRIX.Clear()
        TXT_QTITE.Clear()
        TXT_MNT.Clear()
        TXT_NUM_ART.Clear()

        cm.Close()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        remplir_cmb()
        aff_DG()
        connexionbase()
    End Sub
    Private Sub aff_DG()
        cm.ConnectionString = "Data Source=DESKTOP-7IPAE0K;Initial Catalog=Bon_de_commande;Integrated Security=True"
        cm.Open()
        Dim str As String = "Select * from Article1"
        cmd = New SqlCommand(str, cm)
        dr = cmd.ExecuteReader
        DG_LIG_COMM.Rows.Clear()
        While (dr.Read)

            DG_LIG_COMM.Rows.Add(dr("COD_ART"), dr("PRIX"), dr("QTITE"), dr("MNT"))
        End While
        dr.Close()
        cm.Close()
    End Sub
    Private Sub remplir_cmb()
        cm.ConnectionString = "Data Source=DESKTOP-7IPAE0K;Initial Catalog=Bon_de_commande;Integrated Security=True"
        cm.Open()
        Dim str As String = "Select COD_ART from Article1"
        cmd = New SqlCommand(str, cm)
        dr = cmd.ExecuteReader
        While (dr.Read)
            CB_RECH.Items.Add(dr("COD_ART"))
        End While
        dr.Close()
        cm.Close()
    End Sub
    Private Sub Label10_Click(sender As System.Object, e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub BTN_AJOUT_Click(sender As System.Object, e As System.EventArgs) Handles BTN_AJOUT.Click
        DG_LIG_COMM.Rows.Add(TXT_NUM_ART.Text, TXT_PRIX.Text, TXT_QTITE.Text, TXT_MNT.Text)
        TXT_NUM_ART.Clear()
        TXT_PRIX.Clear()
        TXT_QTITE.Clear()
        TXT_MNT.Clear()
    End Sub

    Private Sub GroupBox4_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub BTN_QTE_Click(sender As System.Object, e As System.EventArgs) Handles BTN_QTE.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub

    Private Sub BTN_ENREGI_Click(sender As System.Object, e As System.EventArgs) Handles BTN_ENREGI.Click


        cm.ConnectionString = "Data Source=DESKTOP-7IPAE0K;Initial Catalog=Bon_de_commande;Integrated Security=True"
        cm.Open()

        Dim j As Integer = 0
        Dim sql As String = "select * from Article1 where COD_ART='" & DG_LIG_COMM(0, 0).Value & "'"
        cmd.Connection = cm
        cmd.CommandText = sql
        cmd.CommandType = CommandType.Text
        Try
            dr = cmd.ExecuteReader
            With dr

                If dr.HasRows = 0 Then

                    For i = 0 To DG_LIG_COMM.Rows.Count - 2
                        dr.Close()
                        cmd.Connection = cm
                        cmd.CommandText = "Insert into Article1 (COD_ART,PRIX,QTITE,MNT) values('" & DG_LIG_COMM(0, j).Value & "','" & DG_LIG_COMM(1, j).Value & "','" & DG_LIG_COMM(2, j).Value & "','" & DG_LIG_COMM(3, j).Value & "')"
                        cmd.CommandType = CommandType.Text
                        cmd.ExecuteNonQuery()
                        j = j + 1

                    Next
                    MessageBox.Show("ajout avec succés")

                    Dim sql1 As String = "select * from Article1 where COD_ART='" & DG_LIG_COMM(0, 0).Value & "'"
                    cmd.Connection = cm
                    cmd.CommandText = sql1

                    cmd.CommandType = CommandType.Text
                    dr = cmd.ExecuteReader()

                    TXT_NUM_ART.Clear()
                    TXT_PRIX.Clear()
                    TXT_QTITE.Clear()
                    TXT_MNT.Clear()

                Else
                    MessageBox.Show("cet article existe deja")
                    dr.Read()
                    TXT_NUM_ART.Text = .Item(1)
                    TXT_PRIX.Text = .Item(2)
                    TXT_QTITE.Text = .Item(3)
                    TXT_MNT.Text = .Item(4)
                    dr = cmd.ExecuteReader()

                    TXT_NUM_ART.Clear()
                    TXT_PRIX.Clear()
                    TXT_QTITE.Clear()
                    TXT_MNT.Clear()
                End If
            End With
            dr.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cm.Close()

    End Sub

    Private Sub DG_LIG_COMM_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_LIG_COMM.CellContentClick

    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub BTN_SUPP_Click(sender As System.Object, e As System.EventArgs) Handles BTN_SUPP.Click
        cm.ConnectionString = "Data Source=DESKTOP-7IPAE0K;Initial Catalog=Bon_de_commande;Integrated Security=True"
        cm.Open()
        cmd.Connection = cm
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from Article1 where COD_ART='" + TXT_NUM_ART.Text + "'"
        MessageBox.Show("suppresion effectuée avec succés")
        cmd.ExecuteNonQuery()
        cm.Close()
        aff_DG()
       
    End Sub

    Private Sub CB_RECH_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CB_RECH.SelectedIndexChanged

    End Sub

    Private Sub GB_LIG_COMM_Enter(sender As System.Object, e As System.EventArgs) Handles GB_LIG_COMM.Enter

    End Sub

    Private Sub TXT_NUM_ART_TextChanged(sender As System.Object, e As System.EventArgs) Handles TXT_NUM_ART.TextChanged

    End Sub

    Private Sub GB_LIGHNE_Enter(sender As System.Object, e As System.EventArgs) Handles GB_LIGHNE.Enter

    End Sub

    Private Sub BTN_RECHER_Click(sender As System.Object, e As System.EventArgs) Handles BTN_RECHER.Click
        
    End Sub
End Class
