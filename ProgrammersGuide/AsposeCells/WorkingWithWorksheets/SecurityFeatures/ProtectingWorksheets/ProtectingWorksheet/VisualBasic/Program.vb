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

Namespace ProtectingWorksheet
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Creating a file stream containing the Excel file to be opened
			Dim fstream As New FileStream(dataDir & "book1.xls", FileMode.Open)

			'Instantiating a Workbook object
			'Opening the Excel file through the file stream
			Dim excel As New Workbook(fstream)

			'Accessing the first worksheet in the Excel file
			Dim worksheet As Worksheet = excel.Worksheets(0)

			'Protecting the worksheet with a password
			worksheet.Protect(ProtectionType.All, "aspose", Nothing)

			'Saving the modified Excel file in default format
			excel.Save(dataDir & "output.xls", SaveFormat.Excel97To2003)

			'Closing the file stream to free all resources
			fstream.Close()

		End Sub
	End Class
End Namespace