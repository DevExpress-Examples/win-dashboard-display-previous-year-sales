Imports System.Windows.Forms

Namespace Dashboard_PrevYearData

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            dashboardDesigner1.CreateRibbon()
            dashboardDesigner1.LoadDashboard("..\..\Data\PrevYearData.xml")
        End Sub
    End Class
End Namespace
