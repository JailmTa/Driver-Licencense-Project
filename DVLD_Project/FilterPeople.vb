Imports BussnessLayerForDVLD
Imports System
Imports System.Data
Imports System.Windows.Forms

Namespace DVLD_Project
    Public Partial Class FilterPeople
        Inherits UserControl
        Private _ID As Integer = 0
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub cbFilters_SelectedIndexChanged(sender As Object, e As EventArgs)

        End Sub

        Private Sub guna2TextBox1_TextChanged(sender As Object, e As EventArgs)
            Dim dt As DataTable = New DataTable()
            If Equals(cbFilters.Text, "PersonID") Then
                Dim Num = 0
                If Not Equals(guna2TextBox1.Text, "") Then
                    Integer.TryParse(guna2TextBox1.Text, Num)
                    If Num = 0 Then
                        guna2TextBox1.Text = ""
                    Else
                        dt = clsBussnesLayer.FindWithFilters(Num, "", "")
                        For Each row As DataRow In dt.Rows
                            _ID = Convert.ToInt32(row(0))
                            Exit For
                        Next

                    End If
                End If
            ElseIf Not Equals(cbFilters.Text, "None") Then
                dt = clsBussnesLayer.FindWithFilters(0, cbFilters.Text, guna2TextBox1.Text)
                For Each row As DataRow In dt.Rows
                    _ID = Convert.ToInt32(row(0))
                    Exit For
                Next
            ElseIf Equals(cbFilters.Text, "None") OrElse Equals(guna2TextBox1.Text, "") Then
                dt = clsBussnesLayer.GettAllPersons()
                For Each row As DataRow In dt.Rows
                    _ID = Convert.ToInt32(row(0))
                    Exit For
                Next
            End If
        End Sub

        Public Function getID() As Integer
            Return _ID
        End Function

        Private Sub FilterPeople_Load(sender As Object, e As EventArgs)
            Dim dt As DataTable = clsBussnesLayer.GettAllPersons()
            For Each column As DataColumn In dt.Columns
                cbFilters.Items.Add(column.ColumnName)
            Next
        End Sub
    End Class
End Namespace
