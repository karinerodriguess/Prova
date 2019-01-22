using Prova.Domain.Arguments;
using Prova.Domain.Arguments.Task;
using Prova.Domain.Entities;
using Prova.Domain.Enums;
using Prova.Domain.Interfaces.Services.Base;
using System;
using System.Collections.Generic;

namespace Prova.Domain.Interfaces.Services
{
    public interface IServiceTask : IServiceBase
    {
        Task GetById(Guid id);
        List<Task> GetAll();
        AddTaskResponse Add(AddTaskRequest request);
        EditTaskResponse Edit(EditTaskRequest request);
        RemoveTaskResponse Remove(RemoveTaskRequest request);
        List<Task> GetByStatus(EnumStatusTask status);
    }
}
