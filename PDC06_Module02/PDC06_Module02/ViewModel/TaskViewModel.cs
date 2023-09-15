using System;
using System.Collections.Generic;
using System.Text;
using PDC06_Module02.Model;

namespace PDC06_Module02.ViewModel
{
    class TaskViewModel
    {
        public TaskModel TaskModelSet { get; set; }

        public TaskViewModel()
        {
            TaskModelSet = new TaskModel
            {
                SubjectCode = "PDC06",
                SubjectTitle = "Xamarin Mobile Programming",
                Unit = 3,
            };
        }
    }
}
