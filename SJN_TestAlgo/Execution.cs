using SJN_TestAlgo;
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
    public partial class Execution : UserControl
    {
        public Execution(List<CarService> selectedServices)
        {
            InitializeComponent();
            listview(); // Setup columns
            PopulateListView(selectedServices);
            btnExecute.Click += btnExecute_Click;

        }

        private void listview()
        {
            listShow.Clear();
            listShow.View = View.Details;
            listShow.Columns.Add("Service", 150);
            listShow.Columns.Add("Duration", 100);
            listShow.Columns.Add("Status", 100);
            listShow.GridLines = true;
            listShow.FullRowSelect = true;
        }

        private void PopulateListView(List<CarService> services)
        {
            listShow.Items.Clear();

            foreach (var service in services)
            {
                ListViewItem item = new ListViewItem(service.Name);
                item.SubItems.Add(service.Duration + " mins");
                item.SubItems.Add("Pending"); // Initial status
                listShow.Items.Add(item);
            }
        }

        private async void btnExecute_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listShow.Items.Count; i++)
            {
                var item = listShow.Items[i];

                item.SubItems[2].Text = "In Progress";
                listShow.Refresh(); // Force UI update

                int duration = int.Parse(item.SubItems[1].Text.Replace(" mins", "").Trim());
                int delay = Math.Max(500, duration * 100);
                await Task.Delay(delay);

                item.SubItems[2].Text = "Finished";
                listShow.Refresh();
            }

            MessageBox.Show("All services have been completed!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form1 form = this.FindForm() as Form1;
            if (form != null)
            {
                Services services = new Services();
                services.Dock = DockStyle.Fill;

                form.ContainerPanel.Controls.Clear();
                form.ContainerPanel.Controls.Add(services);
            }
        }
    }

}