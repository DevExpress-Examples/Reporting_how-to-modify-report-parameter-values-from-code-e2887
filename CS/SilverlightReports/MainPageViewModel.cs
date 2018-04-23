using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using DevExpress.Xpf.Core.Commands;
using DevExpress.Xpf.Printing;
// ...

namespace SilverlightReports {
    public class MainPageViewModel : INotifyPropertyChanged {
        readonly ReportPreviewModel _previewModel;
        readonly DelegateCommand<object> _categorySubmitCommand;
        readonly ReadOnlyCollection<string> _categories;
        string _category;

        public IDocumentPreviewModel PreviewModel { get { return _previewModel; } }
        public ICommand CategorySubmitCommand { get { return _categorySubmitCommand; } }

        public string Category {
            get { return _category; }
            set {
                if (value == _category)
                    return;

                _category = value;
                OnPropertyChanged("Category");
            }
        }

        public IEnumerable<string> Categories {
            get {
                return _categories;
            }
        }

        public MainPageViewModel() {
            _previewModel = new ReportPreviewModel() {
                ServiceUri = "../NorthwindReportService.svc",
                ReportName = "Reports.ProductReport"
            };
            _categorySubmitCommand = new DelegateCommand<object>(CategorySubmitted);
            _categories = new ReadOnlyCollection<string>(new string[] { "Beverages", "Condiments", "Seafood" });
        }

        private void CategorySubmitted(object o) {
            _previewModel.Parameters["Category"].Value = Category;
            _previewModel.CreateDocument();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        internal void OnPropertyChanged(string property) {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
