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
            PopulateListView(selectedServices);
        }
        private void PopulateListView(List<CarService> services)
        {
            listShow.Items.Clear();

            foreach (var service in services)
            {
                ListViewItem item = new ListViewItem(service.Name);
                item.SubItems.Add(service.Duration + " mins");
                listShow.Items.Add(item);
            }
        }
        private void listview()
        {
            listShow.Clear();
            listShow.View = View.Details;
            listShow.Columns.Add("Service", 100);
            listShow.Columns.Add("Duration", 80);
            listShow.GridLines = true;
        }
    }
}
