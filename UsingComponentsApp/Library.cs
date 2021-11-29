using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingComponentsApp
{
    
    class Library
    {
        public Book[] Books;

        public Library()
        {
            Books = new Book[] { };
        }
        public Library(Book[] books)
        {
            Books = books;
        }

        public Library(List<Book> books)
        {
            Books = books.ToArray();
        }

        public List<Book> BooksList()
        {
            return Books.ToList();
         }

        public void AddBook(Book book)
        {
            Books = (Book[])Books.Append(book);
        }

        /// <summary>
        /// Формировать документ в Excel по
        /// бесплатным книгам(в каждой строке текст с информацией: название
        /// книги и ее описание).
        /// </summary>
        public void CreateExcelFreeBookReport()
        {

        }

        /// <summary>
        /// Формировать отчет в Word с информацией по
        /// всем книгам(шапка: первые столбец и строка). По столбцу идет
        /// заполнение значениями идентификаторов книг. В первой строке
        /// остальные заголовки: название, жанр, стоимость(если пусто, то
        /// строчкой писать «бесплатная»)
        /// </summary>
        public void CreateWordDetailInfoDocument(string filePath)
        {
            using (WordprocessingDocument package = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainDocumentPart1 = package.AddMainDocumentPart();
                GenerateMainDocumentPart1Content(mainDocumentPart1);
            }
        }


        // Generates content of mainDocumentPart1.
        private void GenerateMainDocumentPart1Content(MainDocumentPart mainDocumentPart1)
        {


            Document document1 = new Document() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "w14 w15 w16se wp14" } };
            document1.AddNamespaceDeclaration("wpc", "http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas");
            document1.AddNamespaceDeclaration("cx", "http://schemas.microsoft.com/office/drawing/2014/chartex");
            document1.AddNamespaceDeclaration("cx1", "http://schemas.microsoft.com/office/drawing/2015/9/8/chartex");
            document1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            document1.AddNamespaceDeclaration("o", "urn:schemas-microsoft-com:office:office");
            document1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            document1.AddNamespaceDeclaration("m", "http://schemas.openxmlformats.org/officeDocument/2006/math");
            document1.AddNamespaceDeclaration("v", "urn:schemas-microsoft-com:vml");
            document1.AddNamespaceDeclaration("wp14", "http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing");
            document1.AddNamespaceDeclaration("wp", "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing");
            document1.AddNamespaceDeclaration("w10", "urn:schemas-microsoft-com:office:word");
            document1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            document1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            document1.AddNamespaceDeclaration("w15", "http://schemas.microsoft.com/office/word/2012/wordml");
            document1.AddNamespaceDeclaration("w16se", "http://schemas.microsoft.com/office/word/2015/wordml/symex");
            document1.AddNamespaceDeclaration("wpg", "http://schemas.microsoft.com/office/word/2010/wordprocessingGroup");
            document1.AddNamespaceDeclaration("wpi", "http://schemas.microsoft.com/office/word/2010/wordprocessingInk");
            document1.AddNamespaceDeclaration("wne", "http://schemas.microsoft.com/office/word/2006/wordml");
            document1.AddNamespaceDeclaration("wps", "http://schemas.microsoft.com/office/word/2010/wordprocessingShape");

            Body body1 = new Body();

            Table table1 = new Table();

            TableProperties tableProperties1 = new TableProperties();
            TableStyle tableStyle1 = new TableStyle() { Val = "a3" };
            TableWidth tableWidth1 = new TableWidth() { Width = "0", Type = TableWidthUnitValues.Auto };
            TableLook tableLook1 = new TableLook() { Val = "04A0" };

            tableProperties1.Append(tableStyle1);
            tableProperties1.Append(tableWidth1);
            tableProperties1.Append(tableLook1);

            TableGrid tableGrid1 = new TableGrid();
            GridColumn gridColumn1 = new GridColumn() { Width = "1869" };
            GridColumn gridColumn2 = new GridColumn() { Width = "1869" };
            GridColumn gridColumn3 = new GridColumn() { Width = "1869" };
            GridColumn gridColumn4 = new GridColumn() { Width = "1869" };
            GridColumn gridColumn5 = new GridColumn() { Width = "1869" };

            tableGrid1.Append(gridColumn1);
            tableGrid1.Append(gridColumn2);
            tableGrid1.Append(gridColumn3);
            tableGrid1.Append(gridColumn4);
            tableGrid1.Append(gridColumn5);

            TableRow tableRow1 = new TableRow() { RsidTableRowAddition = "00AA77AB", RsidTableRowProperties = "00AA77AB" };

            TableCell tableCell1 = new TableCell();

            TableCellProperties tableCellProperties1 = new TableCellProperties();
            TableCellWidth tableCellWidth1 = new TableCellWidth() { Width = "1869", Type = TableWidthUnitValues.Dxa };

            tableCellProperties1.Append(tableCellWidth1);

            Paragraph paragraph1 = new Paragraph() { RsidParagraphMarkRevision = "00AA77AB", RsidParagraphAddition = "00AA77AB", RsidRunAdditionDefault = "00AA77AB" };

            ParagraphProperties paragraphProperties1 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties1 = new ParagraphMarkRunProperties();
            Languages languages1 = new Languages() { Val = "en-US" };

            paragraphMarkRunProperties1.Append(languages1);

            paragraphProperties1.Append(paragraphMarkRunProperties1);

            Run run1 = new Run();

            RunProperties runProperties1 = new RunProperties();
            Languages languages2 = new Languages() { Val = "en-US" };

            runProperties1.Append(languages2);
            Text text1 = new Text();
            text1.Text = "ID";

            run1.Append(runProperties1);
            run1.Append(text1);

            paragraph1.Append(paragraphProperties1);
            paragraph1.Append(run1);

            tableCell1.Append(tableCellProperties1);
            tableCell1.Append(paragraph1);

            TableCell tableCell2 = new TableCell();

            TableCellProperties tableCellProperties2 = new TableCellProperties();
            TableCellWidth tableCellWidth2 = new TableCellWidth() { Width = "1869", Type = TableWidthUnitValues.Dxa };

            tableCellProperties2.Append(tableCellWidth2);

            Paragraph paragraph2 = new Paragraph() { RsidParagraphAddition = "00AA77AB", RsidRunAdditionDefault = "00AA77AB" };

            Run run2 = new Run();
            Text text2 = new Text();
            text2.Text = "Название";

            run2.Append(text2);

            paragraph2.Append(run2);

            tableCell2.Append(tableCellProperties2);
            tableCell2.Append(paragraph2);

            TableCell tableCell3 = new TableCell();

            TableCellProperties tableCellProperties3 = new TableCellProperties();
            TableCellWidth tableCellWidth3 = new TableCellWidth() { Width = "1869", Type = TableWidthUnitValues.Dxa };

            tableCellProperties3.Append(tableCellWidth3);

            Paragraph paragraph3 = new Paragraph() { RsidParagraphAddition = "00AA77AB", RsidRunAdditionDefault = "00AA77AB" };
            ProofError proofError1 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run3 = new Run();
            Text text3 = new Text();
            text3.Text = "Описание";

            run3.Append(text3);
            ProofError proofError2 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            paragraph3.Append(proofError1);
            paragraph3.Append(run3);
            paragraph3.Append(proofError2);

            tableCell3.Append(tableCellProperties3);
            tableCell3.Append(paragraph3);

            TableCell tableCell4 = new TableCell();

            TableCellProperties tableCellProperties4 = new TableCellProperties();
            TableCellWidth tableCellWidth4 = new TableCellWidth() { Width = "1869", Type = TableWidthUnitValues.Dxa };

            tableCellProperties4.Append(tableCellWidth4);

            Paragraph paragraph4 = new Paragraph() { RsidParagraphAddition = "00AA77AB", RsidRunAdditionDefault = "00AA77AB" };

            Run run4 = new Run();
            Text text4 = new Text();
            text4.Text = "Жанр";

            run4.Append(text4);

            paragraph4.Append(run4);

            tableCell4.Append(tableCellProperties4);
            tableCell4.Append(paragraph4);

            TableCell tableCell5 = new TableCell();

            TableCellProperties tableCellProperties5 = new TableCellProperties();
            TableCellWidth tableCellWidth5 = new TableCellWidth() { Width = "1869", Type = TableWidthUnitValues.Dxa };

            tableCellProperties5.Append(tableCellWidth5);

            Paragraph paragraph5 = new Paragraph() { RsidParagraphAddition = "00AA77AB", RsidRunAdditionDefault = "00AA77AB" };

            Run run5 = new Run();
            Text text5 = new Text();
            text5.Text = "Цена";

            run5.Append(text5);

            paragraph5.Append(run5);

            tableCell5.Append(tableCellProperties5);
            tableCell5.Append(paragraph5);

            tableRow1.Append(tableCell1);
            tableRow1.Append(tableCell2);
            tableRow1.Append(tableCell3);
            tableRow1.Append(tableCell4);
            tableRow1.Append(tableCell5);

            // Добавление таблицы, строки шапки
            table1.Append(tableProperties1);
            table1.Append(tableGrid1);
            table1.Append(tableRow1);

            // Добавление строк с книгами
            foreach (Book book in Books)
            {
                TableRow tableRow2 = new TableRow() { RsidTableRowAddition = "00AA77AB", RsidTableRowProperties = "00AA77AB" };

                TableCell tableCell6 = CreateTableCell(book.Id.ToString());

                // Вторая ячейка второй строки

                TableCell tableCell7 = CreateTableCell(book.Name);

                TableCell tableCell8 = CreateTableCell(book.Description);

                TableCell tableCell9 = CreateTableCell(book.Genre);
                
                TableCell tableCell10 = CreateTableCell(book.Price.ToString());

                tableRow2.Append(tableCell6);
                tableRow2.Append(tableCell7);
                tableRow2.Append(tableCell8);
                tableRow2.Append(tableCell9);
                tableRow2.Append(tableCell10);
                table1.Append(tableRow2);
            }

            // ???
            Paragraph paragraph11 = new Paragraph() { RsidParagraphAddition = "005B1530", RsidRunAdditionDefault = "005B1530" };

            SectionProperties sectionProperties1 = new SectionProperties() { RsidR = "005B1530" };


            PageSize pageSize1 = new PageSize() { Width = (UInt32Value)11906U, Height = (UInt32Value)16838U };
            PageMargin pageMargin1 = new PageMargin() { Top = 1134, Right = (UInt32Value)850U, Bottom = 1134, Left = (UInt32Value)1701U, Header = (UInt32Value)708U, Footer = (UInt32Value)708U, Gutter = (UInt32Value)0U };
            Columns columns1 = new Columns() { Space = "708" };
            DocGrid docGrid1 = new DocGrid() { LinePitch = 360 };
            // ???^^^

            sectionProperties1.Append(pageSize1);
            sectionProperties1.Append(pageMargin1);
            sectionProperties1.Append(columns1);
            sectionProperties1.Append(docGrid1);

            body1.Append(table1);
            body1.Append(paragraph11);
            body1.Append(sectionProperties1);

            document1.Append(body1);

            mainDocumentPart1.Document = document1;
        }

        private TableCell CreateTableCell(string value)
        {
            TableCell tableCell = new TableCell();

            TableCellProperties tableCellProperties6 = new TableCellProperties();
            TableCellWidth tableCellWidth6 = new TableCellWidth() { Width = "1869", Type = TableWidthUnitValues.Dxa };

            tableCellProperties6.Append(tableCellWidth6);

            Paragraph paragraph6 = new Paragraph() { RsidParagraphMarkRevision = "00AA77AB", RsidParagraphAddition = "00AA77AB", RsidRunAdditionDefault = "00AA77AB" };

            Run run6 = new Run();
            Text text6 = new Text();
            text6.Text = value;

            run6.Append(text6);
            BookmarkStart bookmarkStart1 = new BookmarkStart() { Name = "_GoBack", Id = "0" };
            BookmarkEnd bookmarkEnd1 = new BookmarkEnd() { Id = "0" };

            paragraph6.Append(run6);
            paragraph6.Append(bookmarkStart1);
            paragraph6.Append(bookmarkEnd1);

            tableCell.Append(tableCellProperties6);
            tableCell.Append(paragraph6);
            
            return tableCell;
        }


        /// <summary>
        /// Круговая диаграмма в Pdf, сколько бесплатных книг какого жанра
        /// </summary>
        public void CreatePdfFreeBookByGenreDiagram()
        {

        }
    }
}
