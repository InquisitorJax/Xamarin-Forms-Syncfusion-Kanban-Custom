using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace CustomKanban.WorkItems
{
    public class WorkItemViewModel : BindableBase
    {
        private WorkItem _model;

        public WorkItem Model
        {
            get { return _model; }
            set { SetProperty(ref _model, value); }
        }


    }
}
