Public Class Jugador
    Inherits Persona
    Private _numero As UShort
    Private _equipo As Equipo
    Public Property Equipo As Equipo
        Set(value As Equipo)
            _equipo = value
        End Set
        Get
            Return _equipo
        End Get
    End Property
    Public Property Numero As UShort
        Set(value As UShort)
            If value < 0 Or value > 99 Then
                Throw New Exception("valor invalido, debe estar entre 0 y 99")
            End If
            _numero = value
        End Set
        Get
            Return _numero
        End Get
    End Property
    Sub New()
        MyBase.New()
        _numero = 0
    End Sub
    Sub New(Nombre As String, FechaNacimiento As Date, Numero As UShort)
        MyBase.New(Nombre, FechaNacimiento)
        Me.Numero = Numero
    End Sub
    Public Overrides Function ToString() As String
        Return Nombre & "(" & Numero & ")"
    End Function
End Class
