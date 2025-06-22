using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SJN_TestAlgo.Form1;

namespace SJN_TestAlgo
{
    public partial class Services : UserControl
    {
        //Execution execution = new Execution();
        public Services()
        {
            InitializeComponent();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            Form1 form = this.FindForm() as Form1;

            if (form != null)
            {
                List<CarService> selectedServices = new List<CarService>();

                // Check selected services
                if (chkOilChange.Checked)
                {
                    selectedServices.Add(new CarService("Oil Change", 25));
                }
                if (chkTireRotation.Checked)
                {
                    selectedServices.Add(new CarService("Tire Rotation", 25));
                }
                if (chkBrakePadReplacement.Checked)
                {
                    selectedServices.Add(new CarService("Brake Pad Replacement", 60));
                }
                if (chkEngineDiagnostics.Checked)
                {
                    selectedServices.Add(new CarService("Engine Diagnostics", 45));
                }
                if (chkPaintJob.Checked)
                {
                    selectedServices.Add(new CarService("Paint Job", 480));
                }
                if (chkCarWash.Checked)
                {
                    selectedServices.Add(new CarService("Car Wash", 15));
                }

                // Apply SJN (Shortest Job Next) sorting by duration
                var sortedBySJN = selectedServices.OrderBy(s => s.Duration).ToList();

                // Load Execution screen with sorted services
                Execution execution = new Execution(sortedBySJN);

                form.ContainerPanel.Controls.Clear();
                execution.Dock = DockStyle.Fill;
                form.ContainerPanel.Controls.Add(execution);
            }
        }
    }
}
