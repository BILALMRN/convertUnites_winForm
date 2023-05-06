Imports CONVERT.coverte
Imports System.String
Public Class Form1
    Private Sub temperature(sender As Object, e As EventArgs) Handles RadioButtonTemperature.CheckedChanged
        ComboBoxFrom.SelectedItem() = Nothing
        ComboBoxTo.SelectedItem() = Nothing
        ComboBoxFrom.Items.Clear()
        ComboBoxTo.Items.Clear()
        Dim lesItems = New String() {"°C", "°F"}
        ComboBoxFrom.Items.AddRange(lesItems)
        ComboBoxTo.Items.AddRange(lesItems)
    End Sub

    Private Sub distance(sender As Object, e As EventArgs) Handles RadioButtonDistince.CheckedChanged
        ComboBoxFrom.SelectedItem() = Nothing
        ComboBoxTo.SelectedItem() = Nothing
        ComboBoxFrom.Items.Clear()
        ComboBoxTo.Items.Clear()
        Dim lesItems = New String() {"km", "m", "cm", "mm"}
        ComboBoxFrom.Items.AddRange(lesItems)
        ComboBoxTo.Items.AddRange(lesItems)
    End Sub

    Private Sub Mass(sender As Object, e As EventArgs) Handles RadioButtonMass.CheckedChanged
        ComboBoxFrom.SelectedItem() = Nothing
        ComboBoxTo.SelectedItem() = Nothing
        ComboBoxFrom.Items.Clear()
        ComboBoxTo.Items.Clear()
        Dim lesItems = New String() {"Tonne", "kg", "g", "mg"}
        ComboBoxFrom.Items.AddRange(lesItems)
        ComboBoxTo.Items.AddRange(lesItems)
    End Sub

    Private Sub ButtonConverte_Click(sender As Object, e As EventArgs) Handles ButtonConverte.Click

        If ((ComboBoxTo.SelectedItem() <> Nothing) And (ComboBoxTo.SelectedItem() <> Nothing) And (TextBoxFrom.Text <> Nothing)) Then
            If RadioButtonTemperature.Checked Then
                If IsNumeric(CType(TextBoxFrom.Text, Double)) Then
                    Dim convert = New temperatur(ComboBoxFrom.SelectedIndex(), ComboBoxTo.SelectedIndex())
                    Dim t = convert.getTemperatur(CType(TextBoxFrom.Text, Double))
                    LabelAffichConvert.Text = TextBoxFrom.Text + ComboBoxFrom.SelectedItem() + " = " + IIf(t <> Nothing, CType(t, String), "NULL") + ComboBoxTo.SelectedItem()
                Else
                    MsgBox("saisir un nomber", MsgBoxStyle.Information)
                End If
            ElseIf RadioButtonMass.Checked Then
                If IsNumeric(CType(TextBoxFrom.Text, Double)) Then
                    Dim convert = New mass(ComboBoxFrom.SelectedIndex(), ComboBoxTo.SelectedIndex())
                    Dim t = convert.getMass(CType(TextBoxFrom.Text, Double))
                    LabelAffichConvert.Text = TextBoxFrom.Text + ComboBoxFrom.SelectedItem() + " = " + IIf(t <> Nothing, CType(t, String), "NULL") + ComboBoxTo.SelectedItem()
                Else
                    MsgBox("saisir un nomber", MsgBoxStyle.Information)
                End If
            ElseIf RadioButtonDistince.Checked Then
                If IsNumeric(CType(TextBoxFrom.Text, Double)) Then
                    Dim convert = New distence(ComboBoxFrom.SelectedIndex(), ComboBoxTo.SelectedIndex())
                    Dim t = convert.getDistence(CType(TextBoxFrom.Text, Double))
                    LabelAffichConvert.Text = TextBoxFrom.Text + ComboBoxFrom.SelectedItem() + " = " + IIf(t <> Nothing, CType(t, String), "NULL") + ComboBoxTo.SelectedItem()
                Else
                    MsgBox("saisir un nomber", MsgBoxStyle.Information)
                End If
            Else
                MsgBox("select votre choix ", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("select ", MsgBoxStyle.Information)
        End If




    End Sub
End Class
