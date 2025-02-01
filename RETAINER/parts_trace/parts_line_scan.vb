Imports MySql.Data.MySqlClient
Public Class parts_line_scan

    Private Sub txtqr_TextChanged(sender As Object, e As EventArgs) Handles txtqr.TextChanged

    End Sub

    Private Sub txtqr_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr.KeyDown
        If e.KeyCode = Keys.Enter Then
            saveparts(txtqr.Text.Trim, 1)

            txtqr.Clear()
            txtqr.Focus()
        End If
    End Sub


    Public Sub loadparts(line As String)
        Try
            reload("SELECT qr_id,type,qty FROM `denso_line_boxes` WHERE line='" & line & "' and type= 1", datagrid_bezel)
            lbl_line.Text = line

        Catch ex As Exception
            show_error(ex.Message, 0)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Private Sub saveparts(qrcode As String, type As Integer)
        Try
            ' Validate QR code
            Dim qr_id As Integer = 0
            Dim qr_partno As String = ""
            Dim qr_qty As Integer = 0
            Dim qr_type As Integer = 0

            ' Query to fetch part details
            Dim query As String = "SELECT id, qty, partno, type FROM `denso_kitting` WHERE qrcode = @qrcode"
            con.Close()
            con.Open()
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@qrcode", qrcode)
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        qr_id = dr.GetInt32("id")
                        qr_partno = dr.GetString("partno")
                        qr_qty = dr.GetInt32("qty")
                        qr_type = dr.GetInt32("type")
                    Else
                        show_error("Please scan to Kitting Stock first!", 1)
                        Exit Sub
                    End If
                End Using
            End Using

            ' Validate type
            If qr_type <> type Then
                Dim typeName As String = GetTypeName(type)
                show_error($"Partcode is not for {typeName}.", 1)
                Exit Sub
            End If

            ' Check for duplicates
            Dim duplicateQuery As String = "SELECT COUNT(*) FROM denso_line_boxes WHERE qr_id = @qr_id AND line = @line"
            Using cmd As New MySqlCommand(duplicateQuery, con)
                cmd.Parameters.AddWithValue("@qr_id", qr_id)
                cmd.Parameters.AddWithValue("@line", lbl_line.Text)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If count > 0 Then
                    show_error("Duplicate item found!", 2)
                    Exit Sub
                End If
            End Using

            ' Insert into denso_line_boxes
            Dim insertQuery As String = "INSERT INTO `denso_line_boxes` (qr_id, line, type, qty) VALUES (@qr_id, @line, @type, @qty)"
            Using cmd As New MySqlCommand(insertQuery, con)
                cmd.Parameters.AddWithValue("@qr_id", qr_id)
                cmd.Parameters.AddWithValue("@line", lbl_line.Text)
                cmd.Parameters.AddWithValue("@type", type)
                cmd.Parameters.AddWithValue("@qty", qr_qty)
                cmd.ExecuteNonQuery()
            End Using

            ' Reload parts
            loadparts(lbl_line.Text)


            ' Clear and focus the QR textbox
            txtqr.Clear()
            txtqr.Focus()
        Catch ex As Exception
            show_error($"An error occurred: {ex.Message}", 0)
        Finally
            con.Close()
        End Try
    End Sub

    Private Function GetTypeName(type As Integer) As String
        Select Case type
            Case 1
                Return "Bezel-Molding"
            Case 2
                Return "Retainer"
            Case 3
                Return "Tape"
            Case Else
                Return "Unknown"
        End Select
    End Function
    Private Sub parts_line_scan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub
End Class