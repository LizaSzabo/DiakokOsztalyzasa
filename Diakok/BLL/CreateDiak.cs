using Diakok.DAL;
using Diakok.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diakok.BLL
{
    public class CreateDiak
    {

        private readonly IRepository repository;

        public CreateDiak(IRepository repository)
        {
            this.repository = repository;
        }

        public bool AddDiak(Diak diak)
        {
            if (diak != null && diak.Nev != null)
            {
                repository.InsertDiak(diak);
                return true;
            }
            else return false;  
        }
    }
}
