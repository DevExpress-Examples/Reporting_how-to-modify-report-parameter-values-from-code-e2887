Imports Microsoft.VisualBasic
Imports System
Namespace Reports
	Partial Public Class ProductReport
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
			Me.ReportHeader1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.xrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
			Me.xrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
			Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
			Me.productsTableAdapter1 = New Reports.nwindDataSetTableAdapters.ProductsTableAdapter()
			Me.nwindDataSet1 = New Reports.nwindDataSet()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
			Me.StyleTitle = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.StyleDetailHeader = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.StyleHeader = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.StyleEvenRow = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.categoriesTableAdapter = New Reports.nwindDataSetTableAdapters.CategoriesTableAdapter()
			Me.Category = New DevExpress.XtraReports.Parameters.Parameter()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' TopMargin
			' 
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabel9
			' 
			Me.xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(350F, 0F)
			Me.xrLabel9.Name = "xrLabel9"
			Me.xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel9.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel9.StyleName = "StyleDetailHeader"
			Me.xrLabel9.Text = "Price"
			Me.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabel3
			' 
			Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.Description")})
			Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(188.9584F, 49.66669F)
			Me.xrLabel3.Name = "xrLabel3"
			Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel3.SizeF = New System.Drawing.SizeF(461.0416F, 40.95831F)
			Me.xrLabel3.Text = "xrLabel3"
			' 
			' ReportHeader1
			' 
			Me.ReportHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBox2, Me.xrLabel10, Me.xrLabel11, Me.xrLabel8, Me.xrLabel9})
			Me.ReportHeader1.HeightF = 23F
			Me.ReportHeader1.Name = "ReportHeader1"
			' 
			' xrPictureBox2
			' 
			Me.xrPictureBox2.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
			Me.xrPictureBox2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Categories.Icon_17")})
			Me.xrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(23.95833F, 0F)
			Me.xrPictureBox2.Name = "xrPictureBox2"
			Me.xrPictureBox2.SizeF = New System.Drawing.SizeF(33.33334F, 23F)
			Me.xrPictureBox2.StyleName = "StyleDetailHeader"
			' 
			' xrLabel10
			' 
			Me.xrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(550F, 0F)
			Me.xrLabel10.Name = "xrLabel10"
			Me.xrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel10.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel10.StyleName = "StyleDetailHeader"
			Me.xrLabel10.Text = "In Stock"
			Me.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' xrLabel11
			' 
			Me.xrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(450F, 0F)
			Me.xrLabel11.Name = "xrLabel11"
			Me.xrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel11.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel11.StyleName = "StyleDetailHeader"
			Me.xrLabel11.Text = "Ordered"
			Me.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' xrLabel8
			' 
			Me.xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(57.29168F, 0F)
			Me.xrLabel8.Name = "xrLabel8"
			Me.xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel8.SizeF = New System.Drawing.SizeF(292.7083F, 23F)
			Me.xrLabel8.StyleName = "StyleDetailHeader"
			Me.xrLabel8.StylePriority.UseTextAlignment = False
			Me.xrLabel8.Text = "Product Name"
			Me.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrPageInfo1
			' 
			Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 9.999974F)
			Me.xrPageInfo1.Name = "xrPageInfo1"
			Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
			Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(198.9583F, 23F)
			' 
			' DetailReport
			' 
			Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail1, Me.ReportHeader1})
			Me.DetailReport.DataAdapter = Me.productsTableAdapter1
			Me.DetailReport.DataMember = "Categories.CategoriesProducts"
			Me.DetailReport.DataSource = Me.nwindDataSet1
			Me.DetailReport.Level = 0
			Me.DetailReport.Name = "DetailReport"
			' 
			' Detail1
			' 
			Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel7, Me.xrLabel6, Me.xrLabel5, Me.xrLabel4})
			Me.Detail1.HeightF = 23F
			Me.Detail1.Name = "Detail1"
			' 
			' xrLabel7
			' 
			Me.xrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.UnitsOnOrder")})
			Me.xrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(450F, 0F)
			Me.xrLabel7.Name = "xrLabel7"
			Me.xrLabel7.OddStyleName = "StyleEvenRow"
			Me.xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel7.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel7.StylePriority.UseTextAlignment = False
			Me.xrLabel7.Text = "xrLabel7"
			Me.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' xrLabel6
			' 
			Me.xrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.UnitsInStock")})
			Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(550F, 0F)
			Me.xrLabel6.Name = "xrLabel6"
			Me.xrLabel6.OddStyleName = "StyleEvenRow"
			Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel6.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel6.StylePriority.UseTextAlignment = False
			Me.xrLabel6.Text = "xrLabel6"
			Me.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' xrLabel5
			' 
			Me.xrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.UnitPrice", "{0:c}")})
			Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(350F, 0F)
			Me.xrLabel5.Name = "xrLabel5"
			Me.xrLabel5.OddStyleName = "StyleEvenRow"
			Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel5.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel5.StylePriority.UseTextAlignment = False
			Me.xrLabel5.Text = "xrLabel5"
			Me.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' xrLabel4
			' 
			Me.xrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.ProductName")})
			Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(23.95833F, 0F)
			Me.xrLabel4.Name = "xrLabel4"
			Me.xrLabel4.OddStyleName = "StyleEvenRow"
			Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel4.SizeF = New System.Drawing.SizeF(326.0417F, 23F)
			Me.xrLabel4.StylePriority.UseTextAlignment = False
			Me.xrLabel4.Text = "xrLabel4"
			Me.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' productsTableAdapter1
			' 
			Me.productsTableAdapter1.ClearBeforeFill = True
			' 
			' nwindDataSet1
			' 
			Me.nwindDataSet1.DataSetName = "nwindDataSet"
			Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' xrLabel2
			' 
			Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryName")})
			Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(188.9584F, 10.00001F)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel2.SizeF = New System.Drawing.SizeF(461.0416F, 39.66667F)
			Me.xrLabel2.StyleName = "StyleHeader"
			Me.xrLabel2.StylePriority.UseTextAlignment = False
			Me.xrLabel2.Text = "xrLabel2"
			Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel3, Me.xrLabel2, Me.xrPictureBox1})
			Me.Detail.HeightF = 123.3333F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrPictureBox1
			' 
			Me.xrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Categories.Picture")})
			Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(23.95833F, 8.75F)
			Me.xrPictureBox1.Name = "xrPictureBox1"
			Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(140F, 104.5833F)
			' 
			' StyleTitle
			' 
			Me.StyleTitle.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(61))))), (CInt(Fix((CByte(60))))), (CInt(Fix((CByte(51))))))
			Me.StyleTitle.Font = New System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.StyleTitle.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(242))))), (CInt(Fix((CByte(240))))), (CInt(Fix((CByte(206))))))
			Me.StyleTitle.Name = "StyleTitle"
			Me.StyleTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
			Me.ReportHeader.HeightF = 51.125F
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' xrLabel1
			' 
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(650F, 51.125F)
			Me.xrLabel1.StyleName = "StyleTitle"
			Me.xrLabel1.Text = "Northwind Products"
			' 
			' StyleDetailHeader
			' 
			Me.StyleDetailHeader.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(61))))), (CInt(Fix((CByte(60))))), (CInt(Fix((CByte(51))))))
			Me.StyleDetailHeader.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
			Me.StyleDetailHeader.BorderWidth = 2
			Me.StyleDetailHeader.Font = New System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.StyleDetailHeader.Name = "StyleDetailHeader"
			Me.StyleDetailHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
			' 
			' xrPageInfo2
			' 
			Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(539.9999F, 9.999974F)
			Me.xrPageInfo2.Name = "xrPageInfo2"
			Me.xrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrPageInfo2.StylePriority.UseTextAlignment = False
			Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			' 
			' StyleHeader
			' 
			Me.StyleHeader.BackColor = System.Drawing.Color.Empty
			Me.StyleHeader.Font = New System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.StyleHeader.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(174))))), (CInt(Fix((CByte(49))))), (CInt(Fix((CByte(53))))))
			Me.StyleHeader.Name = "StyleHeader"
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageInfo2, Me.xrPageInfo1})
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' StyleEvenRow
			' 
			Me.StyleEvenRow.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(242))))), (CInt(Fix((CByte(240))))), (CInt(Fix((CByte(206))))))
			Me.StyleEvenRow.Name = "StyleEvenRow"
			' 
			' categoriesTableAdapter
			' 
			Me.categoriesTableAdapter.ClearBeforeFill = True
			' 
			' Category
			' 
			Me.Category.Name = "Category"
			Me.Category.Value = ""
			Me.Category.Visible = False
			' 
			' ProductReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.DetailReport})
			Me.DataAdapter = Me.categoriesTableAdapter
			Me.DataMember = "Categories"
			Me.DataSource = Me.nwindDataSet1
			Me.FilterString = "[CategoryName] Like Concat(?Category, '%')"
			Me.Font = New System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(61))))), (CInt(Fix((CByte(60))))), (CInt(Fix((CByte(51))))))
			Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.Category})
			Me.RequestParameters = False
			Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.StyleTitle, Me.StyleHeader, Me.StyleDetailHeader, Me.StyleEvenRow})
			Me.Version = "10.2"
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private xrLabel9 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
		Private ReportHeader1 As DevExpress.XtraReports.UI.ReportHeaderBand
		Private xrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
		Private xrLabel10 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel11 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel8 As DevExpress.XtraReports.UI.XRLabel
		Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
		Private DetailReport As DevExpress.XtraReports.UI.DetailReportBand
		Private Detail1 As DevExpress.XtraReports.UI.DetailBand
		Private xrLabel7 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel6 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel5 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel
		Private productsTableAdapter1 As nwindDataSetTableAdapters.ProductsTableAdapter
		Private nwindDataSet1 As nwindDataSet
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
		Private StyleTitle As DevExpress.XtraReports.UI.XRControlStyle
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private StyleDetailHeader As DevExpress.XtraReports.UI.XRControlStyle
		Private xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
		Private StyleHeader As DevExpress.XtraReports.UI.XRControlStyle
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private StyleEvenRow As DevExpress.XtraReports.UI.XRControlStyle
		Private categoriesTableAdapter As nwindDataSetTableAdapters.CategoriesTableAdapter
		Private Category As DevExpress.XtraReports.Parameters.Parameter


	End Class
End Namespace
