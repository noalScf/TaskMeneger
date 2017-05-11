using System;
using System.Collections.Generic;

namespace TaskService.Models
{
    public partial class Task
    {
        public Task()
        {
            this.TaskIspolnitels = new List<TaskIspolnitel>();
            this.TaskStatus = new List<TaskStatu>();
        }

        public int idTask { get; set; }
        public string TextHeader { get; set; }
        public string Text { get; set; }
        public virtual ICollection<TaskIspolnitel> TaskIspolnitels { get; set; }
        public virtual ICollection<TaskStatu> TaskStatus { get; set; }
    }
}
