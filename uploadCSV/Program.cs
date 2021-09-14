using System;
using System.Data;
using System.IO;
using ExcelDataReader;
using System.Collections.Generic;
using System.Text;


//Implement function sequence for units

namespace uploadCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set Encoding to be used in filesstream for Excel sheets
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            var filePath = "/home/darren/Downloads/Data for securities.xlsx";
            FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read);

            //Create Dataset of two workshhets
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            DataSet dataSet = excelReader.AsDataSet();

            //Seperate sheets
            var sheet1 = dataSet.Tables[0];
            var sheet2 = dataSet.Tables[1];

            var equityList = new List<Equity>();
            var bondList = new List<Bond>();

            //Check if first sheet is equity data or second
            if (sheet1.TableName == "Equities")
            {
                //Create List of data from sheet
                equityList = GetEquityDataFromSheet(sheet1);
                bondList = GetBondDataFromSheet(sheet2);
            }
            else
            {
                equityList = GetEquityDataFromSheet(sheet2);
                bondList = GetBondDataFromSheet(sheet1);
            }


            System.Console.WriteLine("Total number of Equities added:{0}", equityList.Count);
            System.Console.WriteLine("Total number of Bonds added:{0}", bondList.Count);
        }

        private static List<Bond> GetBondDataFromSheet(DataTable sheet2)
        {
            //Convert Data from Sheet into List of bond objects and return
            var BondList = new List<Bond>();


            //Create array of string lines from sheet
            string[] xlSheetLines = SeperateTableData(sheet2);

            //Create each object out of row of data
            for (int i = 1; i < xlSheetLines.Length - 1; i++)
            {
                var bond = new Bond(xlSheetLines[i]);
                // var e = new Equity(row);
                System.Console.WriteLine("Created equity row:{0}", i);
                BondList.Add(bond);
            }
            System.Console.WriteLine("Bonds Data Returned");
            return BondList;
        }

        private static List<Equity> GetEquityDataFromSheet(DataTable sheet1)
        {
            var equityList = new List<Equity>();
            string[] xlSheetLines = SeperateTableData(sheet1);

            for (int i = 1; i < xlSheetLines.Length - 1; i++)
            {
                var equity = new Equity(xlSheetLines[i]);
                // var e = new Equity(row);
                System.Console.WriteLine("Created equity row:{0}", i);
                equityList.Add(equity);
            }
            System.Console.WriteLine("Equities From GetEquityData");
            return equityList;
        }

        private static string[] SeperateTableData(DataTable sheet)
        {
            //Returns string array of table data
            StringBuilder sb = new StringBuilder();
            foreach (DataRow dr in sheet.Rows)
            {
                //create an object array of row elements using ItemArray
                object[] arr = dr.ItemArray;
                for (int i = 0; i < arr.Length; i++)
                {
                    sb.Append(Convert.ToString(arr[i]));
                    sb.Append("|");
                }
                sb.Append("\n");
            }
            // System.Console.WriteLine(sb);
            string[] xlSheetLines = sb.ToString().Split('\n');

            System.Console.WriteLine(xlSheetLines.Length);
            return xlSheetLines;
        }
    }
}











// System.Console.WriteLine(oneline[0]);
// System.Console.WriteLine(oneline[1]);
// System.Console.WriteLine(oneline[62]);


// for (int i = 1; i < xlSheetLines.Length; i++)
// {
//     string[] data = xlSheetLines[i].Split('|');
//     for (int j = 0; j < data.Length; j++)
//     {
//         System.Console.WriteLine("{0}:{1}",data[j]);
//     }
//     // var equity = new Equity(data);
// }
// foreach (var item in xlSheetLines)
// {
//     System.Console.WriteLine(item);
// }
// System.Console.WriteLine(sb.ToString());


// var stringArray = sheet1.Rows[1].ItemArray.Cast<string>().ToArray();
// var rowAsString = string.Join(", ", sheet1.Rows[0].ItemArray); 
// foreach (var item in stringArray)
// {
//     System.Console.WriteLine(item);
// }

// 11
// 63

// string[] stringArr = dataSet.Tables[0].Rows[2].ItemArray.Select(x=>x.ToString()).ToArray();
// int i = 0;
// foreach (var item in stringArr)
// {   
//     i++;
//     System.Console.WriteLine(item);
//     System.Console.WriteLine(item.GetType());
//     System.Console.WriteLine(i++);
// }

// System.Console.WriteLine("Before for loop");
// int i=1;    
// foreach (DataRow row in dataSet.Tables[0].Rows)
// {
//     string[] rowDataStringArray = dataSet.Tables[0].Rows[i++].ItemArray.Select(x=>x.ToString()).ToArray();
//     var equity = new Equity(rowDataStringArray);
//     System.Console.WriteLine("{0}:{1}",equity.SecurityName,i);
// }

