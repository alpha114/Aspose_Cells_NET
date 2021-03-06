'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Cells. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells

Namespace AddingWorksheetsToNewExcelFile
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Instantiating a Workbook object
			Dim workbook As New Workbook()

			'Adding a new worksheet to the Workbook object
			Dim i As Integer = workbook.Worksheets.Add()

			'Obtaining the reference of the newly added worksheet by passing its sheet index
			Dim worksheet As Worksheet = workbook.Worksheets(i)

			'Setting the name of the newly added worksheet
			worksheet.Name = "My Worksheet"

			'Saving the Excel file
			workbook.Save(dataDir & "output.xls")
		End Sub
	End Class
End Namespace