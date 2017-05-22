using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TaskService
{

    [DataContract]
    public class TaskDTO
    {
        [DataMember]
        public int idTask { get; set; }
        [DataMember]
        public string TaskHeader { get; set; }
        [DataMember]
        public string TaskText { get; set; }
        [DataMember]
        public string Status { get; set; }
    }
}