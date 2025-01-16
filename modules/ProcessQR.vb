Imports MySql.Data.MySqlClient
Module ProcessQR
    Dim QRpartcode As String
    Dim QRlotnumber As String
    Dim QRqty As Integer
    Dim QRremarks As String
    Dim QRsupplier As String

    Public Sub ProcessQRcode(qrcode As String)

        Try
            Dim parts() As String = qrcode.Split("|")
            'CON 1 : QR SPLITING
            If parts.Length >= 5 AndAlso parts.Length <= 8 Then
                QRpartcode = parts(0).Remove(0, 2).Trim
                QRlotnumber = parts(2).Remove(0, 2).Trim
                QRqty = Convert.ToInt32(parts(3).Remove(0, 2).Trim)
                QRremarks = parts(4).Remove(0, 2).Trim
                QRsupplier = parts(1).Remove(0, 2).Trim

            Else  'CON 1 : QR SPLITING
                show_error("INVALID QR FORMAT!", 1)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()

        End Try

    End Sub
End Module
