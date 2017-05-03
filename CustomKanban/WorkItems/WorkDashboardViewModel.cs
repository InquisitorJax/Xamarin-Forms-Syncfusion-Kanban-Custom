using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using CustomKanban.WorkItems;
using Prism.Commands;

namespace CustomKanban
{
    //ViewModel for GettingStarted sample

    public class WorkDashboardViewModel
    {
        
        public WorkDashboardViewModel()
        {
            WorkItems = new ObservableCollection<WorkItem>();

            AddDefaultItems();

            OpenSelectedCardCommand = new DelegateCommand<WorkItem>(OpenSelectedCard);
        }

        #region Properties

        public ICommand OpenSelectedCardCommand { get; }

        public ObservableCollection<WorkItem> WorkItems { get; set; }

        #endregion

        #region Methods

        private void AddDefaultItems()
        {
            for (int i = 1; i <= 5; i++)
            {
                string status = WorkItemStatus.NotStarted;
                if (i == 1)
                    status = WorkItemStatus.Started;
                else if (i == 2)
                    status = WorkItemStatus.Completed;
                AddItem("Name " + i, "Image" + i, "Work for Item " + i, status);
            }
        }

        private void AddItem(string name, string pictureName, string workDescription, string workItemStatus)
        {
            WorkItems.Add(new WorkItem
                          {
                              Id = Guid.NewGuid().ToString(),
                              PictureName = pictureName,
                              WorkDescription = workDescription,
                              WorkerName = name,
                              WorkItemStatus = workItemStatus
            });
        }

        private async void OpenSelectedCard(WorkItem item)
        {
            var page = new WorkItemPage();
            page.ViewModel.Model = item;
            await App.Current.MainPage.Navigation.PushAsync(page);
        }

        #endregion
    }
}