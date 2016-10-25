#region Copyright Syncfusion Inc. 2001 - 2016

// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws.

#endregion Copyright Syncfusion Inc. 2001 - 2016

using System;
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
            Cards = new ObservableCollection<CustomModel>();

            Cards.Add(new CustomModel
            {
                Id = Guid.NewGuid().ToString(),
                Title = "The Flash",
                Category = "Beginner",
                Description = "The fastest man alive",
                Picture = null,
                Status = (int)CustomCardStatus.Beginner
            });
        }

        public ObservableCollection<CustomModel> Cards { get; set; }
    }
}