
Public Class Referee
    Inherits Persona
    Private _internacional As Boolean
    Public Property Internacional As Boolean
        Set(value As Boolean)
            _internacional = value
        End Set
        Get
            Return _internacional
        End Get
    End Property
    Sub New()
        MyBase.New()
        _internacional = False
    End Sub
    Sub New(Nombre As String, FechaNacimiento As Date, Internacional As Boolean)
        MyBase.New(Nombre, FechaNacimiento)
        Me.Internacional = Internacional
    End Sub
    Public Overrides Function ToString() As String
        If Internacional = True Then
            Return Nombre & "i"
        Else
            Return Nombre
        End If
    End Function
End Class
