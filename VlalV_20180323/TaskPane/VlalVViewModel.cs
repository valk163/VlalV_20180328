using VlalV_20180323.TaskPane.TreeView;

namespace VlalV_20180323.TaskPane
{
    public class VlalVViewModel
    {
        private ExcelViewModel excelViewModel;

        public ExcelViewModel ExcelViewModel
        {
            get
            {
                if (this.excelViewModel == null)
                {
                    this.excelViewModel = new ExcelViewModel();
                }

                return this.excelViewModel;
            }
        }
    }
}
