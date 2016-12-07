using Prism.Mvvm;

namespace CustomKanban
{
    public class CustomModel : BindableBase
    {
        private string _category;
        private string _description;
        private string _id;

        private byte[] _picture;

        private int _status;

        private string _superPower;
        private string _title;

        public string Category
        {
            get { return _category; }
            set { SetProperty(ref _category, value); }
        }

        public string Description
        {
            get { return _description; }
            set { SetProperty(ref _description, value); }
        }

        public string Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        public byte[] Picture
        {
            get { return _picture; }
            set { SetProperty(ref _picture, value); }
        }

        public int Status
        {
            get { return _status; }
            set { SetProperty(ref _status, value); }
        }

        public string SuperPower
        {
            get { return _superPower; }
            set { SetProperty(ref _superPower, value); }
        }

        public string Title

        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
    }
}