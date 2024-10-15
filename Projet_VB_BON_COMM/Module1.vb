
Imports System.Data
Imports System.Data.SqlClient

Module Module1

    Public cm As New SqlConnection
    Public cmd As New SqlCommand
    Public dr As SqlDataReader

    Public Sub connexionbase()
        Try
            cm.ConnectionString = "Data Source=DESKTOP-7IPAE0K;Initial Catalog=Bon_de_commande;Integrated Security=True"
            cm.Open()
            If cm.State = ConnectionState.Open Then
                MessageBox.Show("connexion avec succés")
            Else

                MessageBox.Show("connexion échouée")
            End If
        Catch Ex As Exception
            MessageBox.Show(Ex.Message)
        End Try
        cm.Close()
    End Sub
    End Module
