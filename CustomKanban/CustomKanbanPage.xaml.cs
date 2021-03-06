﻿using Syncfusion.SfKanban.XForms;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CustomKanban
{
    public partial class CustomKanbanPage : ContentPage
    {
        public CustomKanbanPage()
        {
            InitializeComponent();

            CustomKanbanViewModel model = new CustomKanbanViewModel();
            kanban.BindingContext = model;

            column1.Categories = new List<object>() { "Beginner", "Starting" };
            column2.Categories = new List<object>() { "Intermediate" };
            column3.Categories = new List<object>() { "Super" };

            List<KanbanColorMapping> colormodels = new List<KanbanColorMapping>();
            colormodels.Add(new KanbanColorMapping("Purple", Color.Purple));
            colormodels.Add(new KanbanColorMapping("Red", Color.Red));
            colormodels.Add(new KanbanColorMapping("Orange", Color.FromHex("FF6A00")));
            colormodels.Add(new KanbanColorMapping("Brown", Color.FromHex("A52A2A")));
            kanban.ColorModel = colormodels;

            //List<KanbanWorkflow> keyfield = new List<KanbanWorkflow>();
            //keyfield.Add(new KanbanWorkflow("Open", new List<object> { "In Progress" }));
            //keyfield.Add(new KanbanWorkflow("In Progress", new List<object> { "Postponed", "Validated", "Code Review", "Closed-No Code Changes" }));
            //keyfield.Add(new KanbanWorkflow("Code Review", new List<object> { "Closed", "Resolved" }));
            //keyfield.Add(new KanbanWorkflow("Closed", new List<object> { "Open" }));
            //keyfield.Add(new KanbanWorkflow("Postponed", new List<object> { "In Progress" }));
            //keyfield.Add(new KanbanWorkflow("Validated", new List<object> { "In Progress" }));
            //keyfield.Add(new KanbanWorkflow("Closed-No Code Changes", new List<object> { }));
            //keyfield.Add(new KanbanWorkflow("Resolved", new List<object> { }));
            //kanban.Workflows = keyfield;
        }
    }
}