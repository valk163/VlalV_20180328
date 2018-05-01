using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace VlalV_20180323.Ribbon
{
    public partial class VlalVRibbon
    {
        private void VlalVRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            //vlal20180323: Part2
            Globals.ThisAddIn.TaskPane.Visible = true;

            /*vlal20180323: Part2 custom take on the button
            if (Globals.ThisAddIn.TaskPane.Visible == false)
            {
                Globals.ThisAddIn.TaskPane.Visible = true;
                this.button1.Label = "Hide Task Panel";
            }
            else
            {
                Globals.ThisAddIn.TaskPane.Visible = false;
                this.button1.Label = "Show Task Panel";
            }
            */
        }
    }
}
