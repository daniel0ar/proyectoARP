Imports System.Data.SqlClient

Public Class conexion
    Public cn As New SqlConnection

    Public Function conectado()
        Try
            cn = New SqlConnection("data source=(local);initial catalog=dbFlexoprint;integrated security=true")
            cn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function desconectado()
        Try
            If cn.State = ConnectionState.Open Then
                cn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
