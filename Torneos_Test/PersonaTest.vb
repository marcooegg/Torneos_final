Imports Torneos
Module PersonaTest

    Sub Main()
        Dim persona1 As Persona
        persona1 = New Persona()
        Do
            Try
                Console.WriteLine("Ingrese fecha de nacimiento")
                persona1.FechaNacimiento = Console.ReadLine()
                Console.WriteLine(persona1.FechaNacimiento)
                Console.WriteLine(persona1.Edad)
                Console.WriteLine(DateDiff(DateInterval.Month, persona1.FechaNacimiento, Date.Today))
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        Loop While persona1.FechaNacimiento = Nothing
        Console.ReadKey()
    End Sub

End Module
