Imports System.Data.SqlClient

Public Class fcolor
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar(ByVal dts As vcolor) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_color")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@idetiqueta", dts.gidetiqueta)

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

    Public Function ingresar(ByVal dts As vcolor) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("ingresar_color")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@idetiqueta", dts.gidetiqueta)
            cmd.Parameters.AddWithValue("@codigoColor", dts.gcodigoColor)


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

    Public Function editar(ByVal dts As vcolor) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_color")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@idcolor", dts.gidcolor)
            cmd.Parameters.AddWithValue("@idetiqueta", dts.gidetiqueta)
            cmd.Parameters.AddWithValue("@codigoColor", dts.gcodigoColor)

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

    Public Function eliminar(ByVal dts As vcolor) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_color")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@idcolor", dts.gidcolor)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            If ex.Message.ToString = "The DELETE statement conflicted with the REFERENCE constraint ""FK__detalle_p__idven__3E1D39E1"". The conflict occurred in database ""dbGabinete"", table ""dbo.detalle_producto"", column 'idventa'." & vbNewLine & "The statement has been terminated." Then
                MessageBox.Show("No se puede eliminar la venta. Existen registros de productos y/o servicios.", "Eliminando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MsgBox(ex.Message)
            End If
            Return False
        Finally
            desconectado()
        End Try
    End Function
End Class
