using VlalV_20180323.TaskPane;
using Microsoft.Office.Tools;

namespace VlalV_20180323
{
    public partial class ThisAddIn
    {
        //vlal20180323: Part2
        private CustomTaskPane taskPane;

        internal CustomTaskPane TaskPane
        {
            get
            {
                return this.taskPane;
            }

        }
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            /*vlal20180323: Part1 
            var messageBox = MessageBox.Show("Hello, World!");
            */
            //vlal20180323: Part2
            var taskPaneView = new TaskPaneView();
            this.taskPane = this.CustomTaskPanes.Add(taskPaneView, "VlalV");
            this.taskPane.Visible = false;

            var vlalViewModel = new VlalVViewModel();
            var vlalView = taskPaneView.VlalVView;
            vlalView.DataContext = vlalViewModel;
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            /*vlal20180323: Part1
            var messageBox = MessageBox.Show("Good night, World!");
            */
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
