Public Class Loro
    Private _memoria As Queue(Of String)
    Private _fechaNacimiento As Date
    Private _Nombre As String
    Private _texto As String

    Sub New()
        _memoria = New Queue(Of String)
        _fechaNacimiento = Nothing
        _Nombre = ""
        _texto = ""
    End Sub

    Public Property FechaNacimiento As Date
        Get
            'get: devuelve el valor del campo.
            Return _fechaNacimiento
        End Get
        Set(value As Date)
            'set: asigna un valor al campo.
            _fechaNacimiento = value
        End Set
    End Property
    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Private Function CalcularEdad(fechanacimeinto As Date) As UShort
        Return DateDiff(DateInterval.Year, fechanacimeinto, Today)
    End Function
    Public Sub Escuchar(frase As String)
        _memoria.Enqueue(frase)
    End Sub
    Public Overrides Function ToString() As String
        Return Nombre
    End Function

    Public Function Hablar() As String
        If _memoria.Count > 0 Then
            _texto += _memoria.Dequeue + " "
        End If
        Return _texto
    End Function

    Public ReadOnly Property Edad() As UShort
        Get
            Return CalcularEdad(FechaNacimiento)
        End Get
    End Property


End Class
