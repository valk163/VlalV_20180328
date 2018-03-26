using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VlalV_20180323.TaskPane
{
    public partial class TaskPaneView : UserControl
    {
        public TaskPaneView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //vlal20180323: Part2
            var timeNow = DateTime.Now.ToLongTimeString();
            var dateNow = DateTime.Now.ToLongDateString();
            this.label1.Text = dateNow+"@"+timeNow;
        }
    }
}
