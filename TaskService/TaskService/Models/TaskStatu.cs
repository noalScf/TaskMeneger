using System;
using System.Collections.Generic;

namespace TaskService.Models
{
    public partial class TaskStatu
    {
        public int idTaskStatus { get; set; }
        public int idTask { get; set; }
        public int idStatus { get; set; }
        public System.DateTime Date { get; set; }
        public string Komentarii { get; set; }
        public virtual Status Status { get; set; }
        public virtual Task Task { get; set; }
    }
}
