﻿using Domain.Endpoint.Entities;
using Domain.Endpoint.Interfaces.Repositories;
using Domain.Endpoint.Interfaces.Services;
using System.Collections.Generic;

namespace Domain.Endpoint.Services
{
    public class ToDosService : IToDosService
    {
        private readonly IToDosRepository _repository;
        public ToDosService(IToDosRepository repository)
        {
            _repository = repository;
        }

        public List<ToDo> GetAll()
        {
            return _repository.Get();
        }
    }
}
