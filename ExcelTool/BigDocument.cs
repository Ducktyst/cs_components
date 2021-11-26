using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Office2013.Excel;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using OfficeOpenXml;

namespace ExcelTool
{
    public class BigDocument : Component
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="path">Полный путь до файла</param>
        /// <param name="header">Заголовок в документе</param>
        /// <param name="txt">Абзацы текста</param>
      public static void Fill(string path, string header, string[] txt)
        {

            // запись в файл
            using (FileStream fstream = new FileStream(path, FileMode.Create))
            {
                foreach (string text in txt)
                {
                    // преобразуем строку в байты
                    byte[] array = System.Text.Encoding.Default.GetBytes(text);
                    // запись массива байтов в файл
                    fstream.Write(array, 0, array.Length);
                }
                
                Console.WriteLine("Текст записан в файл");
            }
        }
        public static void CreateSpreadsheetWorkbook(string filepath)
        {
            // Create a spreadsheet document by supplying the filepath.
            // By default, AutoSave = true, Editable = true, and Type = xlsx.
            SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Create(filepath, SpreadsheetDocumentType.Workbook);

            // Add a WorkbookPart to the document.
            WorkbookPart workbookpart = spreadsheetDocument.AddWorkbookPart();
            workbookpart.Workbook = new Workbook();

            // Add a WorksheetPart to the WorkbookPart.
            WorksheetPart worksheetPart = workbookpart.AddNewPart<WorksheetPart>();
            worksheetPart.Worksheet = new Worksheet(new SheetData());

            // Add Sheets to the Workbook.
            Sheets sheets = spreadsheetDocument.WorkbookPart.Workbook.AppendChild<Sheets>(new Sheets());

            // Append a new worksheet and associate it with the workbook.
            Sheet sheet = new Sheet() { Id = spreadsheetDocument.WorkbookPart.GetIdOfPart(worksheetPart), SheetId = 1, Name = "mySheet" };
            sheet.Name = "Лист 1";
            sheets.Append(sheet);

            // Get the sheetData cell table.
            SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();

            // Add a row to the cell table.
            Row row;
            row = new Row() { RowIndex = 1 };
            sheetData.Append(row);

            // In the new row, find the column location to insert a cell in A1.  
            Cell refCell = null;
            foreach (Cell cell in row.Elements<Cell>())
            {
                if (string.Compare(cell.CellReference.Value, "A1", true) > 0)
                {
                    refCell = cell;
                    break;
                }
            }

            // Add the cell to the cell table at A1.
            Cell newCell = new Cell() { CellReference = "A1" };
            row.InsertBefore(newCell, refCell);

            // Set the cell value to be a numeric value of 100.
            newCell.CellValue = new CellValue("100");
            newCell.DataType = new EnumValue<CellValues>(CellValues.Number);

            // Close the document.
            spreadsheetDocument.Close();
        }

        public static void CreateSpreadsheetWorkbook(string filepath, string header, string[] paragraphs)
        {
            // Create a spreadsheet document by supplying the filepath.
            // By default, AutoSave = true, Editable = true, and Type = xlsx.
            SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Create(filepath, SpreadsheetDocumentType.Workbook);

            // Add a WorkbookPart to the document.
            WorkbookPart workbookpart = spreadsheetDocument.AddWorkbookPart();
            workbookpart.Workbook = new Workbook();

            // Add a WorksheetPart to the WorkbookPart.
            WorksheetPart worksheetPart = workbookpart.AddNewPart<WorksheetPart>();
            worksheetPart.Worksheet = new Worksheet(new SheetData());

            // Add Sheets to the Workbook.
            Sheets sheets = spreadsheetDocument.WorkbookPart.Workbook.AppendChild<Sheets>(new Sheets());

            // Append a new worksheet and associate it with the workbook.
            Sheet sheet = new Sheet() 
            {
                Id = spreadsheetDocument.WorkbookPart.GetIdOfPart(worksheetPart),
                SheetId = 1,
                Name = "Лист 1" 
            };
            sheets.Append(sheet);

            // Get the sheetData cell table.
            SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();


            // Add a row to the cell table.
            Row row;
            row = new Row() { RowIndex = 1 };
            sheetData.Append(row);

            Cell refCell = null;
            foreach (Cell cell in row.Elements<Cell>())
            {
                if (string.Compare(cell.CellReference.Value, "A1", true) > 0)
                {
                    refCell = cell;
                    break;
                }
            }

            Cell newCell = new Cell() { CellReference = "A1" };
            row.InsertBefore(newCell, refCell);
            newCell.CellValue = new CellValue(header);
            newCell.DataType = new EnumValue<CellValues>(CellValues.String);


            // Add a row to the cell table.
            for (UInt32Value i = 0; i < paragraphs.Length; i++)
            {
                int paragraphNo = (int)(i + 2);
                row = new Row() { RowIndex = i+2 };
                sheetData.Append(row);

                string cellCode = "A" + paragraphNo;
                refCell = null;
                foreach (Cell cell in row.Elements<Cell>())
                { 
                    Console.WriteLine(cellCode);
                    if (string.Compare(cell.CellReference.Value, cellCode, true) > 0)
                    {
                        refCell = cell;
                        break;
                    }
                }

                // Add the cell to the cell table
                newCell = new Cell() { CellReference = cellCode};
                row.InsertBefore(newCell, refCell);
                
                newCell.CellValue = new CellValue(paragraphs[i]);
                newCell.DataType = new EnumValue<CellValues>(CellValues.String);
            }

            // Close the document.
            spreadsheetDocument.Close();
        }

        public SpreadsheetDocument OpenExcel(string filepath) 
        {
            using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Open(filepath, true)) 
            {
                // Attempt to add a new WorksheetPart.
                // The call to AddNewPart generates an exception because the file is read-only.
                WorksheetPart newWorksheetPart = spreadsheetDocument.WorkbookPart.AddNewPart<WorksheetPart>();

                return spreadsheetDocument;
            }
        }

        private static string GetString(object obj)
        {
            try
            {
                return obj.ToString();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

//        /// <summary>
//        /// Конвертировать указанный Excel в DataTable (первый лист Excel)
//        /// </summary>
//        /// <param name = "fullfielpath"> Файл абсолютный путь </ param>
//        /// <returns></returns>
//        public static DataTable WorksheetToTable(string fullFielPath)
//        {
//            try
//            {
//                FileInfo existingFile = new FileInfo(fullFielPath);

//                ExcelPackage package = new ExcelPackage(existingFile);
//                ExcelWorksheet worksheet = package.Workbook.Worksheets[1]; // выберите указанную страницу

//                return WorksheetToTable(worksheet);
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Включите лист на DataTable
//        /// </summary>
//        /// <param name = "Рабочий лист"> Рабочий лист </ param> для обработки
//        /// <returns> Возвращает процесс после datatable </ returns>
//        public static DataTable WorksheetToTable(ExcelWorksheet worksheet)
//        {
//            // Получить количество строк листа
//            int rows = worksheet.Dimension.End.Row;
//            // Получить количество столбцов листа
//            int cols = worksheet.Dimension.End.Column;

//            DataTable dt = new DataTable(worksheet.Name);
//            DataRow dr = null;
//            for (int i = 1; i <= rows; i++)
//            {
//                if (i > 1)
//                    dr = dt.Rows.Add();

//                for (int j = 1; j <= cols; j++)
//                {
////// Первая строка установлена ​​на заголовок DataTable по умолчанию.
//                    if (i == 1)
//                        dt.Columns.Add(GetString(worksheet.Cells[i, j].Value));
//                    // Удалена запись в DataTable
//                    else
//                        dr[j - 1] = GetString(worksheet.Cells[i, j].Value);
//                }
//            }
//            return dt;
//        }
    


    /// <summary>
    /// 
    /// </summary>
    /// <param name="path">Полный путь до файла</param>
    /// <param name="header">Заголовок в документе</param>
    /// <param name="txt">Абзацы текста</param>
    public static void FillTableSheet(string path, string header, string[] txt)
        {
            using (FileStream fstream = new FileStream(path, FileMode.Create))
            {
                foreach (string text in txt)
                {
                    // преобразуем строку в байты
                    byte[] array = System.Text.Encoding.Default.GetBytes(text);
                    // запись массива байтов в файл
                    fstream.Write(array, 0, array.Length);
                }

                Console.WriteLine("Текст записан в файл");
            }
        }



        class ExcelInfo
        {
            public string FileName { get; set; }
            public string Title { get; set; }
            public List<string> paragraphs { get; set; }
        }

        class ExcelCellParameters
        {
            public Worksheet Worksheet { get; set; }
            public string ColumnName { get; set; }
            public uint RowIndex { get; set; }
            public UInt32Value StyleIndex { get; set; }
            public string Text { get; set; }
            public SharedStringTablePart ShareStringPart { get; set; }
            public string CellReference => $"{ColumnName}{RowIndex}";
        }

//        private static void InsertCellInWorksheet(ExcelCellParameters cellParameters)
//        {
//            SheetData sheetData = cellParameters.Worksheet.GetFirstChild<SheetData>();
//            // Ищем строку, либо добавляем ее
//            Row row;
//            if (sheetData.Elements<Row>().Where(r => r.RowIndex ==
//           cellParameters.RowIndex).Count() != 0)
//            {
//                row = sheetData.Elements<Row>().Where(r => r.RowIndex ==
//               cellParameters.RowIndex).First();
//            }
//            else
//            {
//                row = new Row() { RowIndex = cellParameters.RowIndex };
//                sheetData.Append(row);
//            }
//            // Ищем нужную ячейку 
//            Cell cell;

// if (row.Elements<Cell>().Where(c => c.CellReference.Value ==
//cellParameters.CellReference).Count() > 0)
//            {
//                cell = row.Elements<Cell>().Where(c => c.CellReference.Value ==
//               cellParameters.CellReference).First();
//            }
//            else
//            {
//                // Все ячейки должны быть последовательно друг за другом расположены
//                // нужно определить, после какой вставлять
//                Cell refCell = null;
//                foreach (Cell rowCell in row.Elements<Cell>())
//                {
//                    if (string.Compare(rowCell.CellReference.Value,
//                   cellParameters.CellReference, true) > 0)
//                    {
//                        refCell = rowCell;
//                        break;
//                    }
//                }
//                Cell newCell = new Cell()
//                {
//                    CellReference = cellParameters.CellReference
//                };
//                row.InsertBefore(newCell, refCell);
//                cell = newCell;
//            }
//            // вставляем новый текст
//            cellParameters.ShareStringPart.SharedStringTable.AppendChild(new
//           SharedStringItem(new Text(cellParameters.Text)));
//            cellParameters.ShareStringPart.SharedStringTable.Save();
//            cell.CellValue = new
//           CellValue((cellParameters.ShareStringPart.SharedStringTable.Elements<SharedStringItem>().
//           Count() - 1).ToString());
//            cell.DataType = new EnumValue<CellValues>(CellValues.SharedString);
//            cell.StyleIndex = cellParameters.StyleIndex;
//        }

    }
}
 