Public Class Libreria


    Public Function calprom(ByVal cal1 As Int16, ByVal cal2 As Int16, ByVal cal3 As Int16) As Decimal
        Dim W As Decimal
        W = (cal1 + cal2 + cal3) / 3
        Return W
    End Function

    Public Sub muestrarProm(ByVal prom As Decimal)
        Console.Write("El promedio es: ")
        Console.Write(prom)
        Console.ReadLine()
        Return
    End Sub

    Public Function CalPromProms(ByRef vector As Decimal(), ByVal k As Int16) As Decimal
        Dim prom As Decimal = 0, resp As Decimal = 0
        Dim ciclo As Int16
        For ciclo = 0 To k - 1
            resp += vector(ciclo)
        Next

        prom = resp / k
        Return prom
    End Function

    Public Sub DespliegaPromProms(ByVal promprom As Decimal)
        Console.WriteLine("El promedio general es: {0}", promprom)
        Return
    End Sub


End Class
