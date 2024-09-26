using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TR.MedicalRecordAutomation.Utilities
{
    public class DataSource
    {
        public static object[] ValidData()
        {
            string[] datavalues1 = new string[3];
            datavalues1[0] = "admin";
            datavalues1[1] = "pass";
            datavalues1[2] = "OpenEMR";

            string[] datavalues2 = new string[3];
            datavalues2[0] = "accountant";
            datavalues2[1] = "accountant";
            datavalues2[2] = "OpenEMR";

            object[] Resultvalues = new object[2];
            Resultvalues[0] = datavalues1;
            Resultvalues[1] = datavalues2;

            return Resultvalues;
        }
        public static object[] ValidLogindata()
        {
            object[] finaldata = ExcelSource.GetSheetIntoObjectArray(@"C:\SeleniumProjects\AutomationFrameworkSolution\MedicalRecordAutomation\TestData\Medical_Records.xlsx", "ValidData");
            return finaldata;
        }
    }
}