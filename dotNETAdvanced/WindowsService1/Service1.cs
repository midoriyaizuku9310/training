using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;


namespace WindowsService1
{
    public partial class Service1 : ServiceBase
    {
       
        public Service1()
        {
            InitializeComponent();
            if(
            !File.Exists("C:\\Users\\mdanish\\Documents\\test5.txt"));
            File.Create("C:\\Users\\mdanish\\Documents\\test5.txt");

        }

        protected override void OnStart(string[] args)
        {
            if(File.Exists("C:\\Users\\mdanish\\Documents\\test5.txt"))
            {
                File.AppendAllText("C:\\Users\\mdanish\\Documents\\test5.txt", "started at" + DateTime.Now.ToString());
            }

        }

        protected override void OnStop()
        {
        }
        
    }
}
