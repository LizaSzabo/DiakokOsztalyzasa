using Diakok.DAL;
using Diakok.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diakok.BLL
{
    public class CreateOsztalyzat
    {
        private readonly IRepository repository;
        private const int max_osztalyzat = 5;

        public CreateOsztalyzat(IRepository repository)
        {
            this.repository = repository;
        }

        public bool AddOsztalyzat(long diakId, int value)
        {
            if (value < 1 || value > max_osztalyzat)
            {
                return false;
            }
            else
            {
                repository.AddOsztalyzat(diakId, value);
                return true;
            }
        }

        public Diak FindDiakById(long id)
        {
            return repository.FindDiak(id);
        }
    }
}
