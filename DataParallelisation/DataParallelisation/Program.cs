using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace DataParallelisation
{
    class Program
    {
        static string folderPath = "StoreData";
        static string storeCodesFile = "StoreCodes.csv";
        static string storeDataFolder = "StoreData";

        static void Main(string[] args)
        {
            LoadData();

            Console.ReadLine();
        }

        class Store
        {
            public string StoreCode { get; set; }
            public string StoreLocation { get; set; }
        }

        class Order
        {
            public Store Store { get; set; }

            public Date Date { get; set; }
            public string SupplierName { get; set; }
            public string SupplierType { get; set; }
            public double Cost { get; set; }
        }

        class Date
        {
            public int Week { get; set; }
            public int Year { get; set; }
        }


        public static void LoadData()
        {
            Dictionary<string, Store> stores = new Dictionary<string, Store>();
            HashSet<Date> dates = new HashSet<Date>();
            List<Order> orders = new List<Order>();

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            string storeCodesFilePath = Directory.GetCurrentDirectory() + @"\" + folderPath + @"\" + storeCodesFile;
            string[] storeCodesData = File.ReadAllLines(storeCodesFilePath);
            foreach (var storeData in storeCodesData)
            {
                string[] storeDataSplit = storeData.Split(',');
                Store store = new Store { StoreCode = storeDataSplit[0], StoreLocation = storeDataSplit[1] };
                if (!stores.ContainsKey(store.StoreCode))
                    stores.Add(store.StoreCode, store);

                //storeDataSplit[0] = store code
                //storeDataSplit[1] = store location
            }

            string[] fileNames = Directory.GetFiles(folderPath + @"\" + storeDataFolder);
            foreach (var filePath in fileNames)
            {
                string fileNameExt = Path.GetFileName(filePath);
                string fileName = Path.GetFileNameWithoutExtension(filePath);

                string[] fileNameSplit = fileName.Split('_');
                Store store = stores[fileNameSplit[0]];
                Date date = new Date { Week = Convert.ToInt32(fileNameSplit[1]), Year = Convert.ToInt32(fileNameSplit[2]) };
                dates.Add(date);
                //fileNameSplit[0] = store code
                //fileNameSplit[1] = week number
                //fileNameSplit[2] = year

                string[] orderData = File.ReadAllLines(folderPath + @"\" + storeDataFolder + @"\" + fileNameExt);
                foreach (var orderInfo in orderData)
                {
                    string[] orderSplit = orderInfo.Split(',');
                    Order order = new Order
                    {
                        Store = store,
                        Date = date,
                        SupplierName = orderSplit[0],
                        SupplierType = orderSplit[1],
                        Cost = Convert.ToDouble(orderSplit[2])
                    };
                    orders.Add(order);
                    //orderSplit[0] = supplier name
                    //orderSplit[1] = supplier type
                    //orderSplit[2] = cost
                }
            }

            stopWatch.Stop();
            Console.WriteLine("TimeToLoad: " + stopWatch.Elapsed.TotalSeconds);
            RetrieveData();
        }

        public static void RetrieveData()
        {
            Console.WriteLine("Enter a Store ID: ");
            string storeID = Console.ReadLine();
            Console.WriteLine(storeID);

            Console.Write("Enter a year: ");
            string year = Console.ReadLine();
            Console.WriteLine(year);

            Console.WriteLine("Enter a week number 1 - 52: ");
            string week = Console.ReadLine();
            Console.WriteLine(week);

            Console.WriteLine(storeID + "_" + week + "_" + year);

            string keyword = storeID + "_" + week + "_" + year;

            //Needs refining because fugly and limited to specific location
            string filePath = @"C:\Users\k017480g\Documents\tbseassignment1\DataParallelisation\DataParallelisation\bin\Debug\StoreData\StoreData\" + keyword + ".csv";

            int counter = 0;
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(filePath);
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                counter++;
            }

            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.  
            System.Console.ReadLine();

            RetrieveData();

        }
    }

}
