using System;
using System.Collections.Generic;

namespace TaskService.Models
{
    public partial class TaskStatusView
    {
        public int idTask { get; set; }
        public int idTaskStatus { get; set; }
        public int idStatus { get; set; }
        public string TextHeader { get; set; }
        public string Text { get; set; }
        public string Date { get; set; }
        public string Komentarii { get; set; }
        public string Name { get; set; }
    }
}
