using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using PlumberManagementApp.DAL.Interfaces;

namespace PlumberManagementApp.DAL.Services
{
    public class PlumberRepository : Interfaces.IPlumberRepository
    {
        private PlumberDbContext _context;

        public PlumberRepository(PlumberDbContext context)
        {
            _context = context;
        }

        public Model.PlumberModel GetById(string id)
        {
            return _context.PlumberModels.FirstOrDefault(t => t.Id == int.Parse(id));
        }

        public string GetAll()
        {
            string qry = "select* from PlumberModels";
            return qry;
        }

        public string Add()
        {
            string qry = "insert into PlumberModels(Title, IsCompleted, DueDate)" +
                "values('";
            return qry;
        }

        public string Update()
        {
            var query = "update PlumberModels set Title='";
            return query;
        }

        public string Delete()
        {
            var query = "delete from PlumberModels where Id='";
            return query;
        }
    }
}