using System.Collections.ObjectModel;
using Excel = Microsoft.Office.Interop.Excel;


namespace VlalV_20180323.TaskPane.TreeView
{
    public class ExcelViewModel
    {
        private readonly ObservableCollection<WorkbookViewModel> workbookViewModels;

        internal ExcelViewModel()
        {
            this.workbookViewModels = new ObservableCollection<WorkbookViewModel>();
            var fakeWorkbookViewModel1 = new WorkbookViewModel();
            var fakeWorkbookViewModel2 = new WorkbookViewModel();
            this.workbookViewModels.Add(fakeWorkbookViewModel1);
            this.workbookViewModels.Add(fakeWorkbookViewModel2);
        }
        public ObservableCollection<WorkbookViewModel> Workbooks
        {
            get
            {
                return this.workbookViewModels;
            }
        }
    }
}
