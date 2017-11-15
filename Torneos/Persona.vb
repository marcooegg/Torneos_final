Public Class Persona
    Private _fechaNacimiento As Date
    Private _nombre As String
    Public Property FechaNacimiento As Date
        Set(value As Date)
            If calcularEdad(value) < 16 Then
                Throw New Exception("La persona es demasiado joven")
            End If
            _fechaNacimiento = value
        End Set
        Get
            Return _fechaNacimiento
        End Get
    End Property
    Public Property Nombre As String
        Set(value As String)
            If value Is Nothing Then
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
    Public ReadOnly Property Edad As UShort
        Get
            Return calcularEdad(FechaNacimiento)
        End Get
    End Property

    Public Sub New()
        _fechaNacimiento = Nothing
        _nombre = ""
    End Sub
    Public Sub New(FechaNacimiento As Date, Nombre As String)
        Me.New()
        Me.FechaNacimiento = FechaNacimiento
        Me.Nombre = Nombre
    End Sub
    Private Function calcularEdad() As UShort
        Return calcularEdad(FechaNacimiento)
    End Function
    Private Function calcularEdad(fecha As Date) As UShort
        If Date.Today.Month < fecha.Month Or (Date.Today.Month = fecha.Month And Date.Today.Day < fecha.Day) Then
            Return DateDiff(DateInterval.Year, fecha, Date.Today) - 1
        End If
        Return DateDiff(DateInterval.Year, fecha, Date.Today)
    End Function
End Class
