using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string path;
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.ShowDialog();
            
            path = folder.SelectedPath.ToString();
            MessageBox.Show("Total Number of Files : " + getFileNumber(path));
        }

        string[] filePaths;
        
        int getFileNumber(String path)
        {
            int sum = Directory.GetFiles(path).Length;
            String[] directory = Directory.GetDirectories(path);

            for(int i=0; i<directory.Length; i++)
            {
                sum += getFileNumber(directory[i]);
            }
            return sum;
        }
    }
}
