using CustomKanban.WorkItems;
using Xamarin.Forms;

namespace CustomKanban
{
    public partial class WorkItemPage : ContentPage
    {
        public WorkItemPage()
        {
            InitializeComponent();
            ViewModel = new WorkItemViewModel();
            BindingContext = ViewModel;
        }


        public WorkItemViewModel ViewModel { get; set; }
    }
}