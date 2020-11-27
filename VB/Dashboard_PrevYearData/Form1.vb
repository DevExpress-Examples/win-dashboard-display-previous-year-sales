Imports System.Windows.Forms
Imports DevExpress.XtraBars.Ribbon

Namespace Dashboard_PrevYearData
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
			dashboardDesigner1.CreateRibbon()
			dashboardDesigner1.LoadDashboard("..\..\Data\PrevYearData.xml")
		End Sub
	End Class
End Namespace
