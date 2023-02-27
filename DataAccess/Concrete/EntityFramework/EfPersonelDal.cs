using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPersonelDal : EfEntityRepositoryBase<Personel1, PersonelCIContext>, IPersonelDal
    {
        public List<PersonelInfoDto> GetPersonelInfoDto()
        {
            using (var context = new PersonelCIContext())
            {
                var result = from p in context.Personel1s
                             join d in context.Departmen
                             on p.Depart equals d.Kodu
                             join s in context.Servis
                             on p.Servis equals s.Kodu
                             join d1 in context.Duraks
                             on p.Durak equals d1.DurakKodu
                             where p.Iscikt == null
                             select new PersonelInfoDto
                             {
                                 Name = p.Adi,
                                 Surname = p.Soyadi,
                                 SicilNo = p.Sicilno,
                                 DepartmanName = d.Adi,
                                 Shuttle = s.Turu,
                                 Station = d1.DurakAdi,
                                 DepartmanID = d.Kodu
                             };
                return result.ToList();



            }
        }
    }
}