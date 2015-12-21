Module ModStore
    Public pc_name As String
    Public pc_index As Integer
    Public btn_store As List(Of Store) = New List(Of Store)

    Public Class Store
        Public Name As String
        Public Index As Integer

        Public Sub New( _
            ByVal m_Name As String, _
            ByVal m_Index As Integer)
            Name = m_Name
            Index = m_Index
        End Sub
    End Class
   
    Public Function search_2(ByVal name As Store)
        If name.ToString <> "" Then
            If name.Name = pc_name Then
                Return name.Index
                Exit Function
            End If
        End If
        ' Return name.Index
    End Function
End Module
