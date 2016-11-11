using Syncfusion.SfKanban.XForms;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace GettingStartedKanban
{
    public class KanbanItemTappedToCommandBehavior : Behavior<SfKanban>
    {
        public static readonly BindableProperty CommandProperty =
                    BindableProperty.Create("Command", typeof(ICommand), typeof(KanbanItemTappedToCommandBehavior), null);

        public SfKanban AssociatedObject { get; private set; }

        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        protected override void OnAttachedTo(SfKanban bindable)
        {
            base.OnAttachedTo(bindable);
            AssociatedObject = bindable;
            bindable.BindingContextChanged += OnBindingContextChanged;
            bindable.ItemTapped += OnKanbantemTapped;
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            BindingContext = AssociatedObject.BindingContext;
        }

        protected override void OnDetachingFrom(SfKanban bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.BindingContextChanged -= OnBindingContextChanged;
            bindable.ItemTapped -= OnKanbantemTapped;
            AssociatedObject = null;
        }

        private void OnBindingContextChanged(object sender, EventArgs e)
        {
            OnBindingContextChanged();
        }

        private void OnKanbantemTapped(object sender, KanbanTappedEventArgs e)
        {
            if (Command == null)
            {
                return;
            }

            object parameter = e.Data;
            if (Command.CanExecute(parameter))
            {
                Command.Execute(parameter);
            }
        }
    }
}