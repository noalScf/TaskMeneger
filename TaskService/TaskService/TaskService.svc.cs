using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Script.Serialization;
using System.Web.UI.WebControls;
using TaskService.Models;

namespace TaskService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы Service1.svc или Service1.svc.cs в обозревателе решений и начните отладку.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class TaskService : ITaskService
    {

        public void GetOptions()
        {
            // Заголовки обработаются в EnableCorsMessageInspector 
        }

        public IEnumerable<TaskStatusView> GetTasks()
        {
            using (var db = new TaskMenegerContext())
            {
                List<TaskStatusView> taskDtos = new List<TaskStatusView>();
                return db.TaskStatusViews.ToList();

            }
        }

        public TaskStatusView GetTask(string idTask)
        {
            using (var db = new TaskMenegerContext())
            {
                return db.TaskStatusViews.SingleOrDefault(t => t.idTask.ToString() == idTask);

            }

        }

        public TaskStatusView AddTask(TaskStatusView addTaskDto)
        {
            using (var db = new TaskMenegerContext())
            {
                if (addTaskDto != null)
                {
                    var TaskStatus=new TaskStatu()
                    {
                        Date = DateTime.Now,
                        idStatus = addTaskDto.idStatus,
                        Task = new Task() {TextHeader = addTaskDto.TextHeader, Text = addTaskDto.Text},
                        Komentarii = addTaskDto.Komentarii
                    };
                    db.TaskStatus.Add(TaskStatus);
                    db.SaveChanges();

                    addTaskDto.idTaskStatus = TaskStatus.idTaskStatus;
                    addTaskDto.idTask = TaskStatus.idTask;
                    addTaskDto.Date = TaskStatus.Date.ToLongDateString();
                    addTaskDto.Name = db.Status.FirstOrDefault(s=>s.idStatus==addTaskDto.idStatus).Name;
                    return addTaskDto;
                }

                throw new NotImplementedException();
            }
            
        }


    }
}
