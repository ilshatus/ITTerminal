using System;
using Excel = Microsoft.Office.Interop.Excel;
using Printing = System.Drawing.Printing;
using Drawing = System.Drawing;
using System.Configuration;

namespace ITTerminal
{
    class PrintSheet
    {
        private static Excel.Application excelapp;
        private static Excel.Workbook workbook;
        private static Excel.Worksheet worksheet;

        //DON'T FORGET CHANGE 4th ROW OF ALL EXCEL FILES
        //DONT FORGET CHECK FOR CORECTNESS OF ALL EXCEL TEMPLATES.
        
        public static void PrintGetSheet(User user, Equipment equipment, String date)
        {
            //  INPUT NEEDED INFORMATION
            excelapp = new Excel.Application();
            workbook = excelapp.Workbooks.Open(
                ConfigurationManager.ConnectionStrings["path"].ConnectionString + "GetSheet.xlsx",
                Type.Missing, false, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);
            worksheet = (Excel.Worksheet) workbook.Sheets[1];
            worksheet.Cells[3, 1] = "Дата: " + DateTime.Now.ToString();
            worksheet.Cells[7, 2] = ConfigurationManager.ConnectionStrings["stockName"].ConnectionString;
            worksheet.Cells[9, 2] = user.Name;
            worksheet.Cells[12, 1] = equipment.Name;
            worksheet.Cells[12, 2] = equipment.Type;
            worksheet.Cells[12, 3] = equipment.Id;
            worksheet.Cells[12, 4] = equipment.Serial;
            worksheet.Cells[15, 1] = "Обязуюсь вернуть до: " + date.ToString();

            //  PRINT SHEET
            Drawing.Printing.PrinterSettings settings = new Drawing.Printing.PrinterSettings();
            String printerName = settings.PrinterName.ToString();
            worksheet.PrintOutEx(1, 1, 2, false, printerName,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            workbook.Close(false, Type.Missing, Type.Missing);
            excelapp.Quit();
            GC.Collect();
        }
        
        public static void PrintReturnSheet(User user, Equipment equipment)
        {
            //  INPUT NEEDED INFORMATION
            excelapp = new Excel.Application();
            workbook = excelapp.Workbooks.Open(
                ConfigurationManager.ConnectionStrings["path"].ConnectionString + "ReturnSheet.xlsx",
                Type.Missing, false, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);
            worksheet = (Excel.Worksheet) workbook.Sheets[1];
            worksheet.Cells[3, 1] = "Дата: " + DateTime.Now.ToString();
            worksheet.Cells[7, 2] = ConfigurationManager.ConnectionStrings["stockName"].ConnectionString;
            worksheet.Cells[9, 2] = user.Name;
            worksheet.Cells[12, 1] = equipment.Name;
            worksheet.Cells[12, 2] = equipment.Type;
            worksheet.Cells[12, 3] = equipment.Id;
            worksheet.Cells[12, 4] = equipment.Serial;

            //  PRINT SHEET
            Drawing.Printing.PrinterSettings settings = new Drawing.Printing.PrinterSettings();
            String printerName = settings.PrinterName.ToString();
            worksheet.PrintOutEx(1, 1, 2, false, printerName,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            workbook.Close(false, Type.Missing, Type.Missing);
            excelapp.Quit();
            GC.Collect();
        }
        
        public static void PrintTransferSheet(User fromUser, User toUser, Equipment equipment, String date)
        {
            //  INPUT NEEDED INFORMATION
            excelapp = new Excel.Application();
            workbook = excelapp.Workbooks.Open(
                ConfigurationManager.ConnectionStrings["path"].ConnectionString + "TransferSheet.xlsx",
                Type.Missing, false, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);
            worksheet = (Excel.Worksheet)workbook.Sheets[1];
            worksheet.Cells[3, 1] = "Дата: " + DateTime.Now.ToString();
            worksheet.Cells[7, 2] = toUser.Name;
            worksheet.Cells[9, 2] = fromUser.Name;
            worksheet.Cells[12, 1] = equipment.Name;
            worksheet.Cells[12, 2] = equipment.Type;
            worksheet.Cells[12, 3] = equipment.Id;
            worksheet.Cells[12, 4] = equipment.Serial;
            worksheet.Cells[15, 1] = "Обязуюсь вернуть до: " + date.ToString();

            //  PRINT SHEET
            Drawing.Printing.PrinterSettings settings = new Drawing.Printing.PrinterSettings();
            String printerName = settings.PrinterName.ToString();
            worksheet.PrintOutEx(1, 1, 2, false, printerName,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            workbook.Close(false, Type.Missing, Type.Missing);
            excelapp.Quit();
            GC.Collect();
        }

        public static void PrintExchangeSheet(User user, Equipment oldEquipment, Equipment newEquipment, String date)
        {
            //  INPUT NEEDED INFORMATION
            excelapp = new Excel.Application();
            workbook = excelapp.Workbooks.Open(
                ConfigurationManager.ConnectionStrings["path"].ConnectionString + "ExchangeSheet.xlsx",
                Type.Missing, false, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);
            worksheet = (Excel.Worksheet) workbook.Sheets[1];
            worksheet.Cells[3, 1] = "Дата: " + DateTime.Now.ToString();
            worksheet.Cells[7, 2] = user.Name;
            worksheet.Cells[11, 1] = oldEquipment.Name;
            worksheet.Cells[11, 2] = oldEquipment.Type;
            worksheet.Cells[11, 3] = oldEquipment.Id;
            worksheet.Cells[11, 4] = oldEquipment.Serial;
            worksheet.Cells[16, 1] = newEquipment.Name;
            worksheet.Cells[16, 2] = newEquipment.Type;
            worksheet.Cells[16, 3] = newEquipment.Id;
            worksheet.Cells[16, 4] = newEquipment.Serial;
            worksheet.Cells[19, 1] = "Обязуюсь вернуть до: " + date.ToString();

            //  PRINT SHEET
            Drawing.Printing.PrinterSettings settings = new Drawing.Printing.PrinterSettings();
            String printerName = settings.PrinterName.ToString();
            worksheet.PrintOutEx(1, 1, 2, false, 
                printerName, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            workbook.Close(false, Type.Missing, Type.Missing);
            excelapp.Quit();
            GC.Collect();
        }
        
        public static void PrintLostSheet(User user, Equipment equipment)
        {
            //  INPUT NEEDED INFORMATION
            excelapp = new Excel.Application();
            workbook = excelapp.Workbooks.Open(
                ConfigurationManager.ConnectionStrings["path"].ConnectionString + "LostSheet.xlsx",
                Type.Missing, false, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);
            worksheet = (Excel.Worksheet) workbook.Sheets[1];
            worksheet.Cells[3, 1] = "Дата: " + DateTime.Now.ToString();
            worksheet.Cells[8, 2] = user.Name;
            worksheet.Cells[12, 1] = equipment.Name;
            worksheet.Cells[12, 2] = equipment.Type;
            worksheet.Cells[12, 3] = equipment.Id;
            worksheet.Cells[12, 4] = equipment.Serial;

            //  PRINT SHEET
            Drawing.Printing.PrinterSettings settings = new Drawing.Printing.PrinterSettings();
            String printerName = settings.PrinterName.ToString();
            worksheet.PrintOutEx(1, 1, 2, false, 
                printerName, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            workbook.Save();
            excelapp.Quit();
            GC.Collect();
        }
        
    }
}
