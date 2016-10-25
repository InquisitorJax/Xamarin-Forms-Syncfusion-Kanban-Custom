using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace GettingStartedKanban
{
    public partial class CustomCard : ContentView
    {
        public static readonly BindableProperty ValueProperty = BindableProperty.Create("Value", typeof(CustomModel), typeof(CustomCard), null);

        public CustomCard()
        {
            InitializeComponent();
        }

        public CustomModel Value
        {
            get { return (CustomModel)GetValue(ValueProperty); }
            set
            {
                try
                {
                    SetValue(ValueProperty, value);
                }
                catch (ArgumentException)
                {
                    Debug.WriteLine("Could not bind CustomerCard.ServiceProviderCustomer Property");
                }
            }
        }
    }
}