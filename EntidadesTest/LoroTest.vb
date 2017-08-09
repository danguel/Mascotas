Imports Entidades
Module LoroTest

    Sub Main()
        '1-Dim LoroLPM As New Loro
        '2-Dim loro As Loro
        '  Loro = New Loro
        Dim LoroLPM As New Loro
        LoroLPM.Nombre = "Pito grande"
        LoroLPM.FechaNacimiento = #12/02/2016#

        Console.WriteLine("Nombre: " & LoroLPM.Nombre)
        Console.WriteLine("Fecha Naci: " & LoroLPM.FechaNacimiento)
        Console.WriteLine("to string: " & LoroLPM.ToString)

        LoroLPM.Escuchar("Papita")
        LoroLPM.Escuchar("pa el loro")
        LoroLPM.Escuchar("JUan")

        Console.WriteLine(LoroLPM.Hablar)
        Console.WriteLine(LoroLPM.Hablar)
        Console.WriteLine(LoroLPM.Hablar)
        Console.WriteLine(LoroLPM.Hablar)
        Console.WriteLine(LoroLPM.Hablar)
        Console.WriteLine(LoroLPM.Hablar)
        Console.WriteLine(LoroLPM.Edad)

    End Sub

End Module
