Public Class Equipo
    Private _nombre As String
    Private _jugadores As List(Of Jugador)
    Public Property Nombre As String
        Set(value As String)
            If value = "" Then
                Throw New Exception("No ingresaste nada")
            End If
            If value.Length > 30 Then
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
    End Sub
    Sub New(Nombre As String)
        Me.Nombre = Nombre
    End Sub
    Public Sub addJugador(Jugador As Jugador)
        Jugador.Equipo = Me
        _jugadores.Add(Jugador)
    End Sub
    Public Function getAllJugadores() As List(Of Jugador)
        Return _jugadores
    End Function
    Public Overrides Function ToString() As String
        Return Nombre
    End Function
End Class
