using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Core.Utilities.Results.Abstract;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPersonelDal : EfEntityRepositoryBase<Personel1, PersonelCIContext>, IPersonelDal
    {
        public List<PersonelDetailDto> GetAllPersonelDetailDto()
        {
            using (var context = new PersonelCIContext())
            {
                var res = from p in context.Personel1s
                          join d in context.Duraks
                          on p.Durak equals d.DurakKodu

                          join s in context.Servis
                          on p.Servis equals s.Kodu

                          join dep in context.Departmen
                          on p.Depart equals dep.Kodu

                          join sh in context.Shifts
                          on p.Shiftid equals sh.ShiftCode into temp
                          from shp in temp.DefaultIfEmpty()

                          where p.Iscikt == null

                          select new PersonelDetailDto
                          {
                              Name = p.Adi,
                              Surname = p.Soyadi,
                              SicilNo = p.Sicilno,
                              ShiftName = shp.ShiftName,
                              DepId = dep.Kodu,
                              DepartmanName = dep.Adi,
                              ShiftId = shp.ShiftCode,
                              ServiceId = s.Kodu,
                              ServiceName = s.Turu,
                              StationId = d.DurakKodu,
                              StationName = d.DurakAdi,
                              WeekOfYear = p.Weekofyear

                          };

                return res.ToList();

            }
        }
    }
}
