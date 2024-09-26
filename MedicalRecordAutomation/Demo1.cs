using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;


namespace TR.MedicalRecordAutomation
{
    public class Demo1
    {
        [Test]
        public void Exceldata()
        {
            var book = new XLWorkbook(@"C:\SeleniumProjects\AutomationFrameworkSolution\MedicalRecordAutomation\TestData\Medical_Records.xlsx");
            var sheet = book.Worksheet("ValidData");
            var range = sheet.RangeUsed();
           

            for (int r = 2; r <= 3; r++)
            {
                
                for (int c = 1; c <= 3; c++)
                {
                    string value = range.Cell(r, c).GetString();
                    Console.WriteLine(value);

                }
            }
            book.Dispose();
        }
    }
}