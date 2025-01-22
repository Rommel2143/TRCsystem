﻿Imports MySql.Data.MySqlClient
Module ProcessQR
    Dim QRpartcode As String
    Dim QRlotnumber As String
    Dim QRqty As Integer
    Dim QRremarks As String
    Dim QRsupplier As String

    Private Function ProcessQRcode(qrcode As String) As Boolean
        Try
            ' Split the QR code using the pipe character
            Dim parts() As String = qrcode.Split("|")

            ' Validate the number of parts in the QR code
            If parts.Length >= 5 AndAlso parts.Length <= 8 Then

                ' Assign values to module-level variables
                QRpartcode = parts(0).Remove(0, 2).Trim()
                QRsupplier = parts(1).Remove(0, 2).Trim()
                QRlotnumber = parts(2).Remove(0, 2).Trim()
                QRqty = Convert.ToInt32(parts(3).Remove(0, 2).Trim())
                QRremarks = parts(4).Remove(0, 2).Trim()

                Return True ' Indicate success
            Else
                ' Show an error if the QR code format is invalid
                show_error("Invalid QR format!", 1)
                Return False ' Indicate failure
            End If
        Catch ex As Exception
            ' Handle unexpected errors gracefully
            show_error($"Error processing QR code: {ex.Message}", 1)
            Return False ' Indicate failure
        Finally
            ' Ensure the database connection is properly closed
            If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Function


    Private Sub cleardata()
        QRpartcode = ""
        QRlotnumber = ""
        QRqty = 0
        QRremarks = ""
        QRsupplier = ""
    End Sub

    Private Function CheckPartName(partcode As String) As Boolean
        Try
            If con.State = ConnectionState.Open Then con.Close()
            con.Open()

            Dim query As String = "SELECT id FROM `logistics_masterlist` WHERE partcode = @partcode LIMIT 1"
            Using selectPartName As New MySqlCommand(query, con)
                selectPartName.Parameters.AddWithValue("@partcode", partcode)

                Using dr As MySqlDataReader = selectPartName.ExecuteReader()
                    If dr.HasRows = True Then
                        Return True
                    Else

                        show_error("Partcode Not Registered!", 1)
                        Return False
                    End If
                End Using
            End Using
        Catch ex As Exception

            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function


    Public Function Insert_U1(qrcode As String, batch As String) As Boolean
        cleardata()
        Try
            If ProcessQRcode(qrcode) Then
                If CheckPartName(QRpartcode) Then
                    con.Close()
                    con.Open()
                    Dim query As String = "INSERT INTO `logistics_u1` (`qrcode`, `partcode`, `lotnumber`, `supplier`, `boxno`, `qty`, `remarks`, `batch`, `userin`, `datein`, `pcin`, `batchout`, `dateout`, `userout`, `pcout`, `status`) 
                                   VALUES (@qrcode, @partcode, @lotnumber, @supplier, NULL, @qty, @remarks, @batch, @userin, CURDATE(), @pcin, NULL, NULL, NULL, NULL, 1)"
                    Dim insert As New MySqlCommand(query, con)
                    insert.Parameters.AddWithValue("@qrcode", qrcode)
                    insert.Parameters.AddWithValue("@partcode", QRpartcode)
                    insert.Parameters.AddWithValue("@lotnumber", QRlotnumber)
                    insert.Parameters.AddWithValue("@supplier", QRsupplier)
                    insert.Parameters.AddWithValue("@qty", QRqty)
                    insert.Parameters.AddWithValue("@remarks", QRremarks)
                    insert.Parameters.AddWithValue("@batch", batch)
                    insert.Parameters.AddWithValue("@userin", client.user_idno)
                    insert.Parameters.AddWithValue("@pcin", client.PC_name)
                    insert.ExecuteNonQuery()
                    Return True ' Insert successful
                End If
                End if
        Catch ex As MySqlException When ex.Number = 1062
            show_error("Duplicate entry detected", 2)
            Return False
        Catch ex As Exception
            show_error($"Error on saving: {ex.Message}", 1)
            Return False
        Finally
            If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
        Return False
    End Function

End Module
