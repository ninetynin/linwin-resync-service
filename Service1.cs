using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        }

        public void OnDebug()
        {
            OnStart(null);
        }

        protected override void OnStart(string[] args)
        {
            Process.Start("w32tm", "/config /manualpeerlist:time.windows.com /syncfromflags:manual /reliable:yes /update");
        }

        protected override void OnStop()
        {
        }
    }
}
