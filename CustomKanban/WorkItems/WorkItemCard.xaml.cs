using System;
using System.Diagnostics;
using CustomKanban.WorkItems;
using Xamarin.Forms;

namespace CustomKanban
{
    public partial class WorkItemCard : ContentView
    {
        public static readonly BindableProperty ValueProperty = BindableProperty.Create("Value", typeof(WorkItem), typeof(WorkItemCard), null);

        public WorkItemCard()
        {
            InitializeComponent();
        }

        public WorkItem Value
        {
            get { return (WorkItem)GetValue(ValueProperty); }
            set
            {
                try
                {
                    SetValue(ValueProperty, value);
                }
                catch (ArgumentException)
                {
                    Debug.WriteLine("Could not bind WorkItemCard.WorkItem Property");
                }
            }
        }
    }
}