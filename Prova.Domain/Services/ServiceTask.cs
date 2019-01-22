using prmToolkit.NotificationPattern;
using Prova.Domain.Arguments;
using Prova.Domain.Arguments.Task;
using Prova.Domain.Entities;
using Prova.Domain.Enums;
using Prova.Domain.Interfaces.Repositories;
using Prova.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace Prova.Domain.Services
{
    public class ServiceTask : Notifiable, IServiceTask
    {
        private readonly IRepositoryTask _repositoryTask;

        public ServiceTask(IRepositoryTask repositoryTask)
        {
            _repositoryTask = repositoryTask;
        }

        public List<Task> GetAll()
        {
            return _repositoryTask.GetAll();
        }

        public Task GetById(Guid id)
        {
            return _repositoryTask.GetById(id);
        }

        public List<Task> GetByStatus(EnumStatusTask status)
        {
            return _repositoryTask.GetByStatus(status);
        }

        public AddTaskResponse Add(AddTaskRequest request)
        {
            if (request == null)
            {
                return null;
            }

            var task = new Task(request.Title, request.Description);            

            AddNotifications(task);

            if (this.IsInvalid()) return null;

            try
            {
                task.Status = EnumStatusTask.New;
                _repositoryTask.Add(task);
                return new AddTaskResponse(task.Id);
            }
            catch (Exception ex)
            {
                return new AddTaskResponse(task.Id, ex.Message);
            }
        }

        public EditTaskResponse Edit(EditTaskRequest request)
        {
            if (request == null)
            {
                return null;
            }

            var task = new Task(request.Id, request.Title, request.Description,request.CreatedDate, (EnumStatusTask)request.Status);

            AddNotifications(task);

            if (this.IsInvalid()) return null;

            try
            {
                _repositoryTask.Edit(task);
                return new EditTaskResponse(true);
            }
            catch(Exception ex)
            {
                return new EditTaskResponse(false, ex.Message);
            }            
        }

        public RemoveTaskResponse Remove(RemoveTaskRequest request)
        {
            if (request == null)
            {
                return null;
            }

            var task = this.GetById(request.Id);
            task.Status = EnumStatusTask.Removed;
            task.RemovedDate = DateTime.Now;

            AddNotifications(task);

            if (this.IsInvalid()) return null;

            try
            {
                _repositoryTask.Edit(task);
                return new RemoveTaskResponse(true);
            }
            catch (Exception ex)
            {
                return new RemoveTaskResponse(false, ex.Message);
            }
        }
    }
}
