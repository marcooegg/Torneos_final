Imports Torneos
Module PartidoTest
    Sub Main()
        Try
            Dim local As New Equipo("Belgrano")
            Dim visitante As New Equipo
            visitante.Nombre = "Chacarita"
            Dim referee As New Referee("Fulano", #10/10/1960#, True)
            'Dim jugador1 As New Jugador
            'jugador1.Nombre = "Neymar"
            'jugador1.FechaNacimiento = #10/10/1980#
            'local.addJugador(jugador1)
            Dim partido1 As New Partido
            partido1.Local = local
            partido1.Visitante = visitante
            partido1.Referee = referee

            partido1.nuevoGolLocal(10)
            partido1.nuevoGolLocal(20)
            partido1.nuevoGolVisitante(45)
            partido1.nuevoGolVisitante(90)

            Console.WriteLine(partido1.ToString)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            Console.ReadKey()
        End Try

    End Sub
End Module
