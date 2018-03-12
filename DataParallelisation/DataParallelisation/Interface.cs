using System;
using System.Windows.Forms;

namespace DataParallelisation
{
    public partial class Interface : Form
    {
        string store = null;
        string year = null;
        string week = null;

        string keyword = null;
        string filePath = null;
        public Interface()
        {
            InitializeComponent();
        }

        private void idText_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void yearText_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void weekText_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void retrieveInfo_Click(object sender, EventArgs e)
        {
            store = idText.Text;
            year = yearText.Text;
            week = weekText.Text;

            keyword = store + "_" + week + "_" + year;
            filePath = tFilePath.Text;
        }

        private void outputLog_TextChanged(object sender, EventArgs e)
        {
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
        }
        
    }
}
