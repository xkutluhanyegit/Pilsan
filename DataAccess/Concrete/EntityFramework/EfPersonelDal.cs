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
                          on p.Durak equals d.DurakKodu into temps
                          from pd in temps.DefaultIfEmpty()

                          join s in context.Servis
                          on p.Servis equals s.Kodu into tempss
                          from sp in tempss.DefaultIfEmpty()

                          join dep in context.Departmen
                          on p.Depart equals dep.Kodu into tempsss
                          from depp in tempsss.DefaultIfEmpty()

                          join sh in context.Shifts
                          on p.Shiftid equals sh.ShiftCode into temp
                          from shp in temp.DefaultIfEmpty()

                          join k in context.Kimlik1s
                          on p.Sicilno equals k.Prsicil into tempssss
                          from kp in tempssss.DefaultIfEmpty()

                          join ps in context.Personelshifts
                          on p.Sicilno equals ps.SicilNo into tempsssss
                          from psp in tempsssss.DefaultIfEmpty()

                          where p.Iscikt == null

                          select new PersonelDetailDto
                          {
                              Name = p.Adi,
                              Surname = p.Soyadi,
                              SicilNo = p.Sicilno,
                              ShiftName = shp.ShiftName,
                              DepId = depp.Kodu,
                              DepartmanName = depp.Adi,
                              ShiftId = shp.ShiftCode,
                              ServiceId = sp.Kodu,
                              ServiceName = sp.Turu,
                              StationId = pd.DurakKodu,
                              StationName = pd.DurakAdi,
                              TCKN = kp.Tckmno,
                              WeekOfYear = psp.WeekOfYear

                          };

                return res.ToList();

            }
        }
    }
}
