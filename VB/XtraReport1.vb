Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
' ...

Namespace PreviewLabelClick
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub xrLabel1_PreviewClick(ByVal sender As Object, ByVal e As PreviewMouseEventArgs) Handles xrLabel1.PreviewClick
			MessageBox.Show(e.Brick.Text)
		End Sub

		Private Sub xrLabel2_PreviewDoubleClick(ByVal sender As Object, ByVal e As PreviewMouseEventArgs) Handles xrLabel2.PreviewDoubleClick
			MessageBox.Show(e.Brick.Text)
		End Sub

	End Class
End Namespace
