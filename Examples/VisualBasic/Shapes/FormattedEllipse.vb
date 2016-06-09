'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Slides. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Slides
Imports Aspose.Slides.Export
Imports System.Drawing

Namespace VisualBasic.Shapes
    Public Class FormattedEllipse
        Public Shared Sub Run()

            ' For complete examples and data files, please go to https://github.com/aspose-slides/Aspose.Slides-for-.NET            ' The path to the documents directory.

            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Shapes()

            ' Instantiate Prseetation class that represents the PPTX
            Using presentation As New Presentation()

                ' Get the first slide
                Dim islide As ISlide = presentation.Slides(0)

                ' Add autoshape of ellipse type
                Dim ishape As IShape = islide.Shapes.AddAutoShape(ShapeType.Ellipse, 50, 150, 150, 50)

                ' Apply some formatting to ellipse shape
                ishape.FillFormat.FillType = FillType.Solid
                ishape.FillFormat.SolidFillColor.Color = Color.Chocolate

                ' Apply some formatting to the line of Ellipse
                ishape.LineFormat.FillFormat.FillType = FillType.Solid
                ishape.LineFormat.FillFormat.SolidFillColor.Color = Color.Black
                ishape.LineFormat.Width = 5

                ' Write the PPTX file to disk
                presentation.Save(dataDir & "EllipseShp2.pptx", SaveFormat.Pptx)

            End Using

        End Sub
    End Class
End Namespace