Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Windows.Input
Imports DevExpress.Xpf.Core.Commands
Imports DevExpress.Xpf.Printing
' ...

Namespace SilverlightReports
	Public Class MainPageViewModel
		Implements INotifyPropertyChanged
		Private ReadOnly _previewModel As ReportPreviewModel
		Private ReadOnly _categorySubmitCommand As DelegateCommand(Of Object)
		Private ReadOnly _categories As ReadOnlyCollection(Of String)
		Private _category As String

		Public ReadOnly Property PreviewModel() As IDocumentPreviewModel
			Get
				Return _previewModel
			End Get
		End Property
		Public ReadOnly Property CategorySubmitCommand() As ICommand
			Get
				Return _categorySubmitCommand
			End Get
		End Property

		Public Property Category() As String
			Get
				Return _category
			End Get
			Set(ByVal value As String)
				If value = _category Then
					Return
				End If

				_category = value
				OnPropertyChanged("Category")
			End Set
		End Property

		Public ReadOnly Property Categories() As IEnumerable(Of String)
			Get
				Return _categories
			End Get
		End Property

		Public Sub New()
			_previewModel = New ReportPreviewModel() With {.ServiceUri = "../NorthwindReportService.svc", .ReportName = "Reports.ProductReport"}
			_categorySubmitCommand = New DelegateCommand(Of Object)(AddressOf CategorySubmitted)
			_categories = New ReadOnlyCollection(Of String)(New String() { "Beverages", "Condiments", "Seafood" })
		End Sub

		Private Sub CategorySubmitted(ByVal o As Object)
			_previewModel.Parameters("Category").Value = Category
			_previewModel.CreateDocument()
		End Sub

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
		Friend Sub OnPropertyChanged(ByVal [property] As String)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs([property]))
		End Sub
	End Class
End Namespace
