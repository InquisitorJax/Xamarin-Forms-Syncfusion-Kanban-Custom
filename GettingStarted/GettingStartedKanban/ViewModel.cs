#region Copyright Syncfusion Inc. 2001 - 2016

// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws.

#endregion Copyright Syncfusion Inc. 2001 - 2016

using Syncfusion.SfKanban.XForms;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GettingStartedKanban
{
    //ViewModel for GettingStarted sample

    public class KanbanGettingStartedViewModel
    {
        public List<object> IList;

        public KanbanGettingStartedViewModel()
        {
            Cards = new ObservableCollection<KanbanModel>();

            Cards.Add(new KanbanModel()
            {
                ID = 1,
                Title = "iOS - 1002",
                ImageURL = "Image1.png",
                Category = "Open",
                Description = "Analyze customer requirements",
                ColorKey = "Red",
                Tags = new string[] { "Incident", "Customer" }
            });

            Cards.Add(new KanbanModel()
            {
                ID = 6,
                Title = "Xamarin - 4576",
                ImageURL = "Image2.png",
                Category = "Open",
                Description = "Show the retrieved data from the server in grid control",
                ColorKey = "Green",
                Tags = new string[] { "SfDataGrid", "Customer" }
            });

            Cards.Add(new KanbanModel()
            {
                ID = 13,
                Title = "UWP - 13",
                ImageURL = "Image4.png",
                Category = "In Progress",
                Description = "Add responsive support to application",
                ColorKey = "Brown",
                Tags = new string[] { "Story", "Kanban" }
            });

            Cards.Add(new KanbanModel()
            {
                ID = 2543,
                Title = "Xamarin_iOS - 2543",
                Category = "Code Review",
                ImageURL = "Image3.png",
                Description = "Provide swimlane support kanban",
                ColorKey = "Brown",
                Tags = new string[] { "Feature", "SfKanban" }
            });

            Cards.Add(new KanbanModel()
            {
                ID = 1975,
                Title = "iOS - 1975",
                Category = "Done",
                ImageURL = "Image5.png",
                Description = "Fix the issues reported by the customer",
                ColorKey = "Purple",
                Tags = new string[] { "Bug" }
            });
        }

        public ObservableCollection<KanbanModel> Cards { get; set; }
    }
}