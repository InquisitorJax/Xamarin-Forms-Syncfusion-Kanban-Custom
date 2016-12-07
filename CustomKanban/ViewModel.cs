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
                Title = "Superman",
                Category = "Beginner",
                SuperPower = "Beginner",
                Description = "The Man of Steel",
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