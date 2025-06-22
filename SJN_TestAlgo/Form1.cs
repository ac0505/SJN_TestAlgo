using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SJN_TestAlgo
{
    public partial class Form1 : Form
    {
        Services services = new Services();
        //List<CarService> serviceList = new List<CarService>(); // or real data
        //Execution execution = new Execution(serviceList);
        public Panel ContainerPanel => pnlContainer;
        public Form1()
        {
            InitializeComponent();
            services.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(services);
        }
        
        //private void btnProceed_Click(object sender, EventArgs e)
        //{
        //    execution.Dock = DockStyle.Fill;
        //    pnlContainer.Controls.Add(execution);
        //    execution.BringToFront();
        //}
    }
}
