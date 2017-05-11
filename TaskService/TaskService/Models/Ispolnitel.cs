using System;
using System.Collections.Generic;

namespace TaskService.Models
{
    public partial class Ispolnitel
    {
        public Ispolnitel()
        {
            this.TaskIspolnitels = new List<TaskIspolnitel>();
        }

        public int idIspolnitel { get; set; }
        public string Name { get; set; }
        public virtual ICollection<TaskIspolnitel> TaskIspolnitels { get; set; }
    }
}
