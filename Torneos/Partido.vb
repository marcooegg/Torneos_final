Public Class Partido
    Private _fecha As Date
    Private _minutosGolesLocal As List(Of UShort)
    Private _minutosGolesVisitante As List(Of UShort)
    Private _finalizado As Boolean
    Private _local As Equipo
    Private _visitante As Equipo
    Private _referee As Referee
    Public Property Referee As Referee
        Set(value As Referee)
            If Not _finalizado Then _referee = value
        End Set
        Get
            Return _referee
        End Get
    End Property
    Public Property Local As Equipo
        Set(value As Equipo)
            If Not _finalizado Then _local = value
        End Set
        Get
            Return _local
        End Get
    End Property
    Public Property Visitante As Equipo
        Set(value As Equipo)
            If Not _finalizado Then _visitante = value
        End Set
        Get
            Return _visitante
        End Get
    End Property
    Public Property Fecha As Date
        Set(value As Date)
            If value > Date.Today Then
                Throw New Exception("La fecha del partido no puede ser posterior al dia de hoy")
            End If
            If Not _finalizado Then _fecha = value
        End Set
        Get
            Return _fecha
        End Get
    End Property
    Public ReadOnly Property golesLocal As UShort
        Get
            Return _minutosGolesLocal.Count
        End Get
    End Property
    Public ReadOnly Property golesVisitante As UShort
        Get
            Return _minutosGolesVisitante.Count
        End Get
    End Property
    Public ReadOnly Property minutosGolesLocal As List(Of UShort)
        Get
            Return _minutosGolesLocal
        End Get
    End Property
    Public ReadOnly Property minutosGolesVisitante As List(Of UShort)
        Get
            Return _minutosGolesVisitante
        End Get
    End Property
    Sub New()
        _fecha = Nothing
        _minutosGolesVisitante = New List(Of UShort)
        _minutosGolesLocal = New List(Of UShort)
        _finalizado = False
    End Sub
    Public Sub nuevoGolLocal(minutos As UShort)
        If Not _finalizado Then _minutosGolesLocal.Add(minutos)
    End Sub
    Public Sub nuevoGolVisitante(minutos As UShort)
        If Not _finalizado Then _minutosGolesVisitante.Add(minutos)
    End Sub
    Public Sub finalizado()
        _finalizado = True
    End Sub
    Public Overrides Function ToString() As String
        Return Local.Nombre & golesLocal & " - " & golesVisitante & Visitante.Nombre
    End Function
End Class
