Public Class coverte
    Protected convertFrom As Integer
    Protected convertTO As Integer
    Public Sub New()
    End Sub
End Class

'/// {"°C", "°F"}
Public Class temperatur : Inherits coverte
    Public Sub New(ByVal convertF As Integer, ByVal convertT As Integer)
        convertFrom = convertF
        convertTO = convertT
    End Sub
    Private Function getTemperatur_celsius(ByVal valConvertF As Double) As Double
        Dim resulta As Double = Nothing
        Select Case convertFrom
            Case 0
                Return valConvertF
            Case 1
                Return (valConvertF - 32) * (9.0 / 5.0)
            Case Else
                MsgBox("error", MsgBoxStyle.Information)
        End Select
        Return Nothing
    End Function
    Public Function getTemperatur(ByVal valConvertFrom As Double) As Double
        Select Case convertTO
            Case 0
                Return getTemperatur_celsius(valConvertFrom)
            Case 1
                Return (getTemperatur_celsius(valConvertFrom) * (9.0 / 5.0) + 32)
            Case Else
                MsgBox("error", MsgBoxStyle.Information)
        End Select
        Return Nothing
    End Function

End Class

'/// {"km", "m", "cm", "mm"}
Public Class distence : Inherits coverte
    Public Sub New(ByVal convertF As Integer, ByVal convertT As Integer)
        convertFrom = convertF
        convertTO = convertT
    End Sub
    '//
    Private Function getDest_METTRE(ByVal valConvertF As Double) As Double

        Select Case convertFrom
            Case 0
                Return valConvertF * 1000
            Case 1
                Return valConvertF
            Case 0
                Return valConvertF / 100
            Case 0
                Return valConvertF / 1000
            Case Else
                MsgBox("error", MsgBoxStyle.Information)
        End Select
        Return Nothing
    End Function
    Public Function getDistence(ByVal valConvertFrom As Double) As Double
        Select Case convertTO
            Case 0
                Return (getDest_METTRE(valConvertFrom) / 1000)
            Case 1
                Return (getDest_METTRE(valConvertFrom))
            Case 2
                Return (getDest_METTRE(valConvertFrom) * 100)
            Case 3
                Return (getDest_METTRE(valConvertFrom) * 1000)
            Case Else
                MsgBox("error", MsgBoxStyle.Information)
        End Select
        Return Nothing
    End Function


End Class

'/// {"Tonne", "kg", "g", "mg"}
Public Class mass : Inherits coverte
    Public Sub New(ByVal convertF As Integer, ByVal convertT As Integer)
        convertFrom = convertF
        convertTO = convertT
    End Sub
    '//
    Private Function getMass_GRAME(ByVal valConvertF As Double) As Double
        Select Case convertFrom
            Case 0
                Return valConvertF * 1000 * 1000
            Case 1
                Return valConvertF * 1000
            Case 2
                Return valConvertF
            Case 3
                Return valConvertF / 1000
            Case Else
                MsgBox("error", MsgBoxStyle.Information)
        End Select
        Return Nothing
    End Function
    Public Function getMass(ByVal valConvertFrom As Double) As Double
        Select Case convertTO
            Case 0
                Return (getMass_GRAME(valConvertFrom) / (1000 * 1000))
            Case 1
                Return (getMass_GRAME(valConvertFrom) / 1000)
            Case 2
                Return (getMass_GRAME(valConvertFrom))
            Case 3
                Return (getMass_GRAME(valConvertFrom) * 1000)
            Case Else
                MsgBox("error", MsgBoxStyle.Information)
        End Select
        Return Nothing
    End Function


End Class