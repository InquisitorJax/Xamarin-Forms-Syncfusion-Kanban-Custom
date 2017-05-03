using Prism.Mvvm;

namespace CustomKanban.WorkItems
{
    public class WorkItem : BindableBase
    {
        private string _id;

        private string _pictureName;

        private string _workDescription;

        private string _workerName;

        private string _workItemStatus;

        #region Properties

        public string Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        public string PictureName
        {
            get { return _pictureName; }
            set { SetProperty(ref _pictureName, value); }
        }

        public string WorkDescription
        {
            get { return _workDescription; }
            set { SetProperty(ref _workDescription, value); }
        }

        public string WorkerName
        {
            get { return _workerName; }
            set { SetProperty(ref _workerName, value); }
        }

        public string WorkItemStatus
        {
            get { return _workItemStatus; }
            set { SetProperty(ref _workItemStatus, value); }
        }

        #endregion
    }
}