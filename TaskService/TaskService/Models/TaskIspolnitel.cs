using System;
using System.Collections.Generic;

namespace TaskService.Models
{
    public partial class TaskIspolnitel
    {
        public int id { get; set; }
        public int idTask { get; set; }
        public int idIspolnitel { get; set; }
        public virtual Ispolnitel Ispolnitel { get; set; }
        public virtual Task Task { get; set; }
    }
}
