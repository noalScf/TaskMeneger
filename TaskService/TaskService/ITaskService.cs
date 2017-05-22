using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TaskService.Models;

namespace TaskService
{
    /// <summary>
    /// Контракт сервиса
    /// </summary>
    [ServiceContract]
    public interface ITaskService
    {
        /// <summary>
        /// вызов OPTIONS при CORS
        /// </summary>
        [OperationContract]
        [WebInvoke(Method = "OPTIONS", UriTemplate = "*")]
        void GetOptions();

        /// <summary>
        /// Получение всех Task
        /// </summary>
        /// <returns>List Tasks</returns>
        [OperationContract]
        [WebGet(UriTemplate = "/Tasks", ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<TaskStatusView> GetTasks();

        /// <summary>
        /// Получение Таска по его id
        /// </summary>
        /// <param name="idTask"> id Таска</param>
        /// <returns>Конкретный таск по id</returns>
        [OperationContract]
        [WebGet(UriTemplate = "/Tasks/{idTask}", ResponseFormat = WebMessageFormat.Json)]
        TaskStatusView GetTask(string idTask);

        /// <summary>
        /// Добавление нового Таска
        /// </summary>
        /// <param name="addTaskDto">Новый Таск</param>
        [OperationContract]
        [WebInvoke(UriTemplate = "/AddTask", Method = "*", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        TaskStatusView AddTask(TaskStatusView addTaskDto);

    } 
}
