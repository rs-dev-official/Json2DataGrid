Imports System.IO
Imports System.Net
Imports Newtonsoft.Json
Imports Json2DataGrid.My
Imports Newtonsoft.Json.Linq
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Public Class Main

    Private Sub BtnReset_Click(sender As System.Object, e As System.EventArgs) Handles BtnReset.Click
        Me.RText.Clear()
        Me.DtGridView.Invalidate()
        Me.DtGridView.DataSource = Nothing
    End Sub

    Private Sub BtnJson_Click(sender As System.Object, e As System.EventArgs) Handles BtnJson.Click
        Me.RText.Text = JArray.Parse(Me.CreateJson()).ToString
    End Sub

    Private Sub BtnGrid_Click(sender As System.Object, e As System.EventArgs) Handles BtnGrid.Click
        If (Me.RText.TextLength <= 0) Then
            Interaction.MsgBox("Create JSON First", MsgBoxStyle.OkOnly, "Warning")
        Else
            Dim dTable As DataTable = Me.DeserializeDataTable(Me.RText.Text)
            DtGridView.DataSource = dTable
        End If
    End Sub

    Public Function DeserializeDataTable(json As String) As DataTable
        Dim dt As DataTable
        dt = TryCast(JsonConvert.DeserializeObject(json, (GetType(DataTable))), DataTable)
        Return dt
    End Function

    Friend Function CreateJson() As String
        Dim Key() As String = Nothing
        Dim Data() As String = Nothing
        Dim Entry As JObject = New JObject
        Dim Persons As JArray = New JArray

        Key = {"ID", "First Name", "Last Name", "Country", "Age", "Payment"}

        Entry = New JObject
        Data = {1, "James", "Smith", "USA", 50, 25532}
        For a = 0 To Key.Length - 1
            Entry.Add(Key(a), Data(a))
        Next
        Persons.Add(Entry)

        Entry = New JObject
        Data = {2, "John", "Johnson", "ENG", 46, 27732}
        For a = 0 To Key.Length - 1
            Entry.Add(Key(a), Data(a))
        Next
        Persons.Add(Entry)

        Entry = New JObject
        Data = {3, "Robert", "Williams", "CAN", 45, 28103}
        For a = 0 To Key.Length - 1
            Entry.Add(Key(a), Data(a))
        Next
        Persons.Add(Entry)

        Entry = New JObject
        Data = {4, "Michael", "Brown", "CAN", 45, 27913}
        For a = 0 To Key.Length - 1
            Entry.Add(Key(a), Data(a))
        Next
        Persons.Add(Entry)

        Entry = New JObject
        Data = {5, "William", "Miller", "GER", 44, 33135}
        For a = 0 To Key.Length - 1
            Entry.Add(Key(a), Data(a))
        Next
        Persons.Add(Entry)

        Entry = New JObject
        Data = {6, "Richard", "Garcia", "IRE", 41, 37698}
        For a = 0 To Key.Length - 1
            Entry.Add(Key(a), Data(a))
        Next
        Persons.Add(Entry)

        Entry = New JObject
        Data = {7, "Jennifer", "Lopez", "USA", 21, 93456}
        For a = 0 To Key.Length - 1
            Entry.Add(Key(a), Data(a))
        Next
        Persons.Add(Entry)

        Return JsonConvert.SerializeObject(Persons)
    End Function

End Class