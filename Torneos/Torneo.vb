Public Class Torneo
    Private _nombre As String
    Private _partidos As List(Of Partido)
    Public Property Nombre As String
        Set(value As String)
            If value = "" Then
                Throw New Exception("No ingresaste nada")
            End If
            If value.Length > 50 Then
                Throw New Exception("Cadena de caracteres demasiado larga")
            End If
            _nombre = value
        End Set
        Get
            Return _nombre
        End Get
    End Property
    Sub New()
        _nombre = ""
        _partidos = New List(Of Partido)
    End Sub
    Sub New(nombre As String)
        MyBase.New()
        Me.Nombre = nombre
    End Sub
    Public Sub addPartido(partido As Partido)
        _partidos.Add(partido)
    End Sub
    Public Sub removePartido(partido As Partido)
        _partidos.Remove(partido)
    End Sub
    Public Function getAllPartidos() As List(Of Partido)
        Return _partidos
    End Function

End Class
