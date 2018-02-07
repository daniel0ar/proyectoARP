Imports System.Data.SqlClient

Public Class fusuario
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function validar_usuario(ByVal dts As vusuario)
        Try
            conectado()
            cmd = New SqlCommand("iniciar_sesion")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@usuario", dts.gusuario)
            cmd.Parameters.AddWithValue("@password", dts.gpassword)

            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            If dr.HasRows = True Then
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


    Public Function editar(ByVal dts As vusuario) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_usuario")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@idusuario", dts.gidusuario)
            cmd.Parameters.AddWithValue("@nombre", dts.gusuario)
            cmd.Parameters.AddWithValue("@password", dts.gpassword)

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

End Class
