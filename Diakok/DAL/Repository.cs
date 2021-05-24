using Diakok.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diakok.DAL
{
    public class Repository:  IRepository
    {
        private readonly DiakDbContext db;

        public Repository(DiakDbContext db)
        {
            this.db = db;
        }

        public IList<Model.Diak> ListStudents()
        {
            return db.Diakok.Select(ToModel).ToList();
        }

        public IList<Model.Osztalyzat> ListOsztalyzatok()
        {
            return db.Osztalyzatok.Select(ToModelOsztalyzat).ToList();
        }

        public Model.Diak InsertDiak(Model.Diak value)
        {
              DbDiak toInsert;
                toInsert = new DbDiak() { Nev = value.Nev, Evfolyam = value.Evfolyam, Szul_datum = value.Szul_datum, Telefon = value.Telefon };
                db.Diakok.Add(toInsert);

                db.SaveChanges();
            

                return new Model.Diak(toInsert.id, toInsert.Nev, toInsert.Evfolyam, value.Szul_datum, value.Telefon);
            
        }


        public Model.Diak AddOsztalyzat(long diakId, int ertek)
        {
           
                var dbRecord = db.Diakok.FirstOrDefault(d => d.id == diakId);
                if (dbRecord == null) return null;
                else
                {
                    
                        var toInsertOsztalyzat = new DbOsztalyzat() { Ertek = ertek, Diak = dbRecord, DiakId = diakId };
                        db.Osztalyzatok.Add(toInsertOsztalyzat);
                        dbRecord.Osztalyzatok.Add(toInsertOsztalyzat);
                   
                    db.SaveChanges();

                    return ToModel(dbRecord);
                
            }
        }

        public Model.Diak FindDiak(long id)
        {
            var dbDiak = db.Diakok.FirstOrDefault(d => d.id == id);
                        
            if (dbDiak != null)
            {
                return ToModel(dbDiak);

            }
            else return null;
        }

        public Model.Diak ToModel(DbDiak value)
        {
           
                var osztalyzatok = db.Osztalyzatok.FirstOrDefault(o => o.DiakId == value.id);

                return new Model.Diak(value.id, value.Nev, value.Evfolyam, value.Szul_datum, value.Telefon);
            
        }

        public Model.Osztalyzat ToModelOsztalyzat(DbOsztalyzat value)
        {

            return new Model.Osztalyzat(value.id, value.Ertek, value.DiakId);

        }


    }
}
