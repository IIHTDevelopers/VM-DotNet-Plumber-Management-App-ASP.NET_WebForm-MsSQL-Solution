using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using PlumberManagementApp.DAL.Interfaces;
using PlumberManagementApp.Model;

namespace PlumberManagementApp.DAL.Services
{
    public class PlumberService : Interfaces.IPlumberService
    {
        private Interfaces.IPlumberRepository _repository;

        public PlumberService(Interfaces.IPlumberRepository repository)
        {
            _repository = repository;
        }


        public string GetAll()
        {
            return _repository.GetAll();
        }

        public string Add()
        {
            return _repository.Add();
        }

        public string Update()
        {
            return _repository.Update();
        }

        public string Delete()
        {
            return _repository.Delete();
        }

        public PlumberModel GetById(string id)
        {
            return _repository.GetById(id);
        }
    }
}