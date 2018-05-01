using System.Collections.ObjectModel;
using VlalV_20180323.TaskPane.TreeView;

namespace VlalV_20180323.TaskPane.TreeView
{
    public class WorkbookViewModel
    {
        private ObservableCollection<WorksheetViewModel> worksheetViewModels;

        internal WorkbookViewModel()
        {
            this.worksheetViewModels = new ObservableCollection<WorksheetViewModel>();
            var fakeWorksheetViewModel1 = new WorksheetViewModel();
            var fakeWorksheetViewModel2 = new WorksheetViewModel();
            this.worksheetViewModels.Add(fakeWorksheetViewModel1);
            this.worksheetViewModels.Add(fakeWorksheetViewModel2);
        }
        public ObservableCollection<WorksheetViewModel> Worksheets
        {
            get
            {
                return this.worksheetViewModels;
            }
        }
        public string Name
        {
            get
            {
                return "My Workbook";
            }
        }
    }
}
