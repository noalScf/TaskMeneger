using System;
using System.Collections.Generic;

namespace TaskService.Models
{
    public partial class Status
    {
        public Status()
        {
            this.TaskStatus = new List<TaskStatu>();
        }

        public int idStatus { get; set; }
        public string Name { get; set; }
        public virtual ICollection<TaskStatu> TaskStatus { get; set; }
    }
}
