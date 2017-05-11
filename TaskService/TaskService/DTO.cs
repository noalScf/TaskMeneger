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
        public string textHeader { get; set; }
        [DataMember]
        public string text { get; set; }
    }

}