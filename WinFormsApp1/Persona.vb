Public Class Persona
    Protected Nombre As String
    Protected FechaDenacimiento As DateTime?

    Public Property Nombre_ As String
        Get
            Return Nombre

        End Get
        Set(value As String)
            Nombre = value
        End Set
    End Property
    Public Property FechaDenacimiento_ As DateTime

        Get
            Return FechaDenacimiento

        End Get
        Set(value As DateTime)
            FechaDenacimiento = value

        End Set
    End Property
    Public ReadOnly Property Edad() As String
        Get
            Dim Edad_ As String
            Edad = DateTime.Now.Year - FechaDenacimiento.Value.Year
            Return Edad
        End Get
    End Property
    Sub Persona(nombre_, fechaDenacimento_)
        Nombre = nombre_
        FechaDenacimiento = fechaDenacimento_

    End Sub

    Public Overrides Function ToString() As String

        Return Nombre.ToUpper() + " " + Edad
    End Function
End Class
