#region Copyright Syncfusion Inc. 2001 - 2016

// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws.

#endregion Copyright Syncfusion Inc. 2001 - 2016

using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace CustomKanban
{
    //ViewModel for GettingStarted sample

    public class CustomKanbanViewModel
    {
        public List<object> IList;

        public CustomKanbanViewModel()
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

            OpenSelectedCardCommand = new DelegateCommand(OpenSelectedCard);
        }

        public ObservableCollection<CustomModel> Cards { get; set; }

        public ICommand OpenSelectedCardCommand { get; }

        private async void OpenSelectedCard()
        {
            await App.Current.MainPage.Navigation.PushAsync(new CardPage());
        }
    }
}