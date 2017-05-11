using System;
using System.Collections.Generic;
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

        public IEnumerable<TaskDTO> GetTasks()
        {
            using (var db = new TaskMenegerContext())
            {
                List<TaskDTO> taskDtos = new List<TaskDTO>();
                var temp = db.Tasks.ToList();
                if (temp.Count() != 0)
                {
                    foreach (var t in temp)
                    {
                        TaskDTO taskDto = new TaskDTO();
                        taskDto.idTask = t.idTask;
                        taskDto.text = t.Text;
                        taskDto.textHeader = t.TextHeader;
                        taskDtos.Add(taskDto);
                    }
                    return taskDtos;
                }
                throw new NotImplementedException();
            }
        }

        public TaskDTO GetTask(string idTask)
        {
            using (var db = new TaskMenegerContext())
            {
                TaskDTO taskDto = new TaskDTO();
                var temp = db.Tasks.SingleOrDefault(t => t.idTask.ToString() == idTask);
                if (temp != null)
                {
                    taskDto.idTask = temp.idTask;
                    taskDto.text = temp.Text;
                    taskDto.textHeader = temp.TextHeader;
                    return taskDto;
                }
                throw new NotImplementedException();
            }

        }

        public TaskDTO AddTask(TaskDTO addTaskDto)
        {
            using (var db = new TaskMenegerContext())
            {
                if (addTaskDto != null)
                {
                    Task task = new Task();
                    task.TextHeader = addTaskDto.textHeader;
                    task.Text = addTaskDto.text;

                    db.Tasks.Add(task);
                    db.SaveChanges();
                    addTaskDto.idTask = task.idTask;
                    return addTaskDto;
                }
                throw new NotImplementedException();
            }
            
        }


    }
}
