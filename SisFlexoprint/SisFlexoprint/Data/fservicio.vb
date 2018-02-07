Imports System.Data.SqlClient

Public Class fservicio
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_etiqueta")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function ingresar(ByVal dts As vservicio) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("ingresar_etiqueta")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@arte", dts.garte)
            cmd.Parameters.AddWithValue("@precioventa", dts.gprecioventa)
            cmd.Parameters.AddWithValue("@medidax", dts.gmedidax)
            cmd.Parameters.AddWithValue("@mediday", dts.gmediday)
            cmd.Parameters.AddWithValue("@diametro", dts.gdiametro)
            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@idcliente", dts.gidcliente)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function editar(ByVal dts As vservicio) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_etiqueta")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@idetiqueta", dts.gidetiqueta)
            cmd.Parameters.AddWithValue("@arte", dts.garte)
            cmd.Parameters.AddWithValue("@precioventa", dts.gprecioventa)
            cmd.Parameters.AddWithValue("@medidax", dts.gmedidax)
            cmd.Parameters.AddWithValue("@mediday", dts.gmediday)
            cmd.Parameters.AddWithValue("@diametro", dts.gdiametro)
            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@idcliente", dts.gidcliente)


            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function eliminar(ByVal dts As vservicio) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_etiqueta")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@idetiqueta", dts.gidetiqueta)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            If ex.Message.ToString = "The DELETE statement conflicted with the REFERENCE constraint ""FK__detalle_p__idpro__3F115E1A"". The conflict occurred in database ""dbFlexoprint"", table ""dbo.detalle_producto"", column 'idproducto'." & vbNewLine & "The statement has been terminated." Then
                MessageBox.Show("No se puede eliminar el producto. Existe en ventas registradas.", "Eliminando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MsgBox(ex.Message)
            End If
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function obtenerid(nombrecliente As String) As Integer
        Try
            conectado()
            cmd = New SqlCommand("SELECT idcliente FROM cliente WHERE nombre = @nombrecliente")
            cmd.Parameters.AddWithValue("@nombrecliente", nombrecliente)

            cmd.Connection = cn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt.Rows(0)(0).ToString
            Else
                Return 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function obtenernombre(idcliente As Integer) As String
        Try
            conectado()
            cmd = New SqlCommand("SELECT nombre FROM cliente WHERE idcliente = @idcliente")
            cmd.Parameters.AddWithValue("@idcliente", idcliente)

            cmd.Connection = cn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt.Rows(0)(0).ToString
            Else
                Return 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function
End Class