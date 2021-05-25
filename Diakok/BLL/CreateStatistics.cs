using Diakok.DAL;
using Diakok.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diakok.BLL
{
    public class CreateStatistics
    {

        private readonly IRepository repository;
        public IList<Diak> Diakok { get; set; }
        public IList<Osztalyzat> Osztalyzatok { get; set; }
        public List<DiakStatisztika> Statisztikak { get; set; }
        private const int elegseges = 2;

        public CreateStatistics(IRepository repository)
        {
            this.repository = repository;
            Statisztikak = new List<DiakStatisztika>();
        }

        public List<Model.DiakStatisztika> ListAllStatistics()
        {
            Diakok = repository.ListStudents();
            Osztalyzatok = repository.ListOsztalyzatok();


            int osztalyzat_value = 0;
            int osztalyzat_count = 0;
            int elegtelen_count = 0;
            int max_value = 0;
            foreach(var diak in Diakok)
            {
                osztalyzat_value = 0;
                osztalyzat_count = 0;
                elegtelen_count = 0;
                max_value = 0;
                foreach (var osztalyzat in Osztalyzatok)
                {
                    if(osztalyzat.DiakId == diak.DiakID)
                    {
                        osztalyzat_count++;
                        osztalyzat_value += osztalyzat.Ertek;
                        if(osztalyzat.Ertek < elegseges)
                        {
                            elegtelen_count++;
                        }
                        if(osztalyzat.Ertek > max_value)
                        {
                            max_value = osztalyzat.Ertek;
                        }
                    }
                }
                if(osztalyzat_count > 0)
                Statisztikak.Add(new DiakStatisztika(diak.Nev, (double)osztalyzat_value/ (double)osztalyzat_count, elegtelen_count, max_value ));
            }

            Statisztikak = Statisztikak.OrderBy(o => o.Atlag).ToList();
            return Statisztikak;
        }

    }
}
