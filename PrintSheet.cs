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
       
        public static void PrintGetSheet(User user, Equipment equipment, String date)
        {
            //  INPUT NEEDED INFORMATION
            excelapp = new Excel.Application();
            try
            {
                workbook = excelapp.Workbooks.Open(
                ConfigurationManager.ConnectionStrings["path"].ConnectionString + "GetSheet.xlsx",
                Type.Missing, false, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);
            }
            catch (Exception)
            {
                return;
            }
            worksheet = (Excel.Worksheet) workbook.Sheets[1];
            worksheet.Cells[3, 1] = "Дата: " + DateTime.Now.ToString();
            worksheet.Cells[7, 2] = ConfigurationManager.ConnectionStrings["stockName"].ConnectionString;
            worksheet.Cells[9, 2] = user.Name.ToString();
            worksheet.Cells[12, 1] = equipment.Name.ToString();
            worksheet.Cells[12, 4] = equipment.Id.ToString();
            worksheet.Cells[15, 1] = equipment.Type.ToString();
            worksheet.Cells[15, 3] = "№" + equipment.Serial.ToString();
            worksheet.Cells[18, 1] = "Обязуюсь вернуть до: " + date.ToString();

            // SHEETS PRINTING
            Drawing.Printing.PrinterSettings settings = new Drawing.Printing.PrinterSettings();
            String printerName = settings.PrinterName.ToString();
            worksheet.PrintOutEx(1, 1, 2, false, printerName,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            // EXCEL FILE CLOSING
            workbook.Close(false, Type.Missing, Type.Missing);
            excelapp.Quit();
            GC.Collect();
        }
        
        public static void PrintReturnSheet(User user, Equipment equipment)
        {
            //  INPUT NEEDED INFORMATION
            excelapp = new Excel.Application();
            try
            {
                workbook = excelapp.Workbooks.Open(
                ConfigurationManager.ConnectionStrings["path"].ConnectionString + "ReturnSheet.xlsx",
                Type.Missing, false, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);
            }
            catch (Exception)
            {
                return;
            }
            worksheet = (Excel.Worksheet) workbook.Sheets[1];
            worksheet.Cells[3, 1] = "Дата: " + DateTime.Now.ToString();
            worksheet.Cells[7, 2] = ConfigurationManager.ConnectionStrings["stockName"].ConnectionString;
            worksheet.Cells[9, 2] = user.Name.ToString();
            worksheet.Cells[12, 1] = equipment.Name.ToString();
            worksheet.Cells[12, 4] = equipment.Id.ToString();
            worksheet.Cells[15, 1] = equipment.Type.ToString();
            worksheet.Cells[15, 3] = "№" + equipment.Serial.ToString();

            //  PRINT SHEET
            Drawing.Printing.PrinterSettings settings = new Drawing.Printing.PrinterSettings();
            String printerName = settings.PrinterName.ToString();
            worksheet.PrintOutEx(1, 1, 2, false, printerName,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            //  EXCEL FILE CLOSING
            workbook.Close(false, Type.Missing, Type.Missing);
            excelapp.Quit();
            GC.Collect();
        }
        
        public static void PrintTransferSheet(User fromUser, User toUser, Equipment equipment, String date)
        {
            //  INPUT NEEDED INFORMATION
            excelapp = new Excel.Application();
            try
            {
                workbook = excelapp.Workbooks.Open(
                ConfigurationManager.ConnectionStrings["path"].ConnectionString + "TransferSheet.xlsx",
                Type.Missing, false, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);
            }
            catch (Exception)
            {
                return;
            }
            worksheet = (Excel.Worksheet)workbook.Sheets[1];
            worksheet.Cells[3, 1] = "Дата: " + DateTime.Now.ToString();
            worksheet.Cells[7, 2] = toUser.Name.ToString();
            worksheet.Cells[9, 2] = fromUser.Name.ToString();
            worksheet.Cells[12, 1] = equipment.Name.ToString();
            worksheet.Cells[12, 4] = equipment.Id.ToString();
            worksheet.Cells[15, 1] = equipment.Type.ToString();
            worksheet.Cells[15, 3] = "№" + equipment.Serial.ToString();
            worksheet.Cells[17, 1] = "Обязуюсь вернуть до: " + date.ToString();

            //  PRINT SHEET
            Drawing.Printing.PrinterSettings settings = new Drawing.Printing.PrinterSettings();
            String printerName = settings.PrinterName.ToString();
            worksheet.PrintOutEx(1, 1, 2, false, printerName,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            //  EXCEL FILE CLOSING
            workbook.Close(false, Type.Missing, Type.Missing);
            excelapp.Quit();
            GC.Collect();
        }

        public static void PrintExchangeSheet(User user, Equipment oldEquipment, Equipment newEquipment, String date)
        {
            //  INPUT NEEDED INFORMATION
            excelapp = new Excel.Application();
            try
            {
                workbook = excelapp.Workbooks.Open(
                ConfigurationManager.ConnectionStrings["path"].ConnectionString + "ExchangeSheet.xlsx",
                Type.Missing, false, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);
            }
            catch (Exception)
            {
                return;
            }
            worksheet = (Excel.Worksheet) workbook.Sheets[1];
            worksheet.Cells[3, 1] = "Дата: " + DateTime.Now.ToString();
            worksheet.Cells[7, 2] = user.Name.ToString();
            worksheet.Cells[11, 1] = oldEquipment.Name.ToString();
            worksheet.Cells[11, 4] = oldEquipment.Id.ToString();
            worksheet.Cells[14, 1] = oldEquipment.Type.ToString();
            worksheet.Cells[14, 3] = "№" + oldEquipment.Serial.ToString();
            worksheet.Cells[19, 1] = newEquipment.Name.ToString();
            worksheet.Cells[19, 4] = newEquipment.Id.ToString();
            worksheet.Cells[22, 1] = newEquipment.Type.ToString();
            worksheet.Cells[22, 3] = "№" + newEquipment.Serial.ToString();
            worksheet.Cells[24, 1] = "Обязуюсь вернуть до: " + date.ToString();

            //  SHEETS PRINTING
            Drawing.Printing.PrinterSettings settings = new Drawing.Printing.PrinterSettings();
            String printerName = settings.PrinterName.ToString();
            worksheet.PrintOutEx(1, 1, 2, false,
                printerName, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            
            //  EXCEL FILE CLOSING
            workbook.Close(false, Type.Missing, Type.Missing);
            excelapp.Quit();
            GC.Collect();
        }
        
        public static void PrintLostSheet(User user, Equipment equipment)
        {
            //  INPUT NEEDED INFORMATION
            excelapp = new Excel.Application();
            try
            {
                workbook = excelapp.Workbooks.Open(
                ConfigurationManager.ConnectionStrings["path"].ConnectionString + "LostSheet.xlsx",
                Type.Missing, false, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);
            }
            catch (Exception)
            {
                return;
            }
            worksheet = (Excel.Worksheet) workbook.Sheets[1];
            worksheet.Cells[3, 1] = "Дата: " + DateTime.Now.ToString();
            worksheet.Cells[8, 2] = user.Name.ToString();
            worksheet.Cells[11, 1] = equipment.Name.ToString();
            worksheet.Cells[11, 4] = equipment.Id.ToString();
            worksheet.Cells[14, 1] = equipment.Type.ToString();
            worksheet.Cells[14, 3] = "№" + equipment.Serial.ToString();

            //  SHEETS PRINTING
            Drawing.Printing.PrinterSettings settings = new Drawing.Printing.PrinterSettings();
            String printerName = settings.PrinterName.ToString();
            worksheet.PrintOutEx(1, 1, 2, false,
                printerName, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            //  EXCEL FILE CLOSING
            workbook.Close(false, Type.Missing, Type.Missing);
            excelapp.Quit();
            GC.Collect();
        }
        
    }
}
