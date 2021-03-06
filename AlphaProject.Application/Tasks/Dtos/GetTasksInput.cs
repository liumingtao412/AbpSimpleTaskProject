﻿using Abp.Application.Services.Dto;
using AlphaProject.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProject.Tasks.Dtos
{
    public class GetTasksInput : IInputDto
    {
        public TaskState? State { get; set; }

        public int? AssignedPersonId { get; set; }
    }
}
