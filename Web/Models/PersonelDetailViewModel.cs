using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using Entities.DTOs;

namespace Web.Models
{
    public class PersonelDetailViewModel
    {
        public IEnumerable<PersonelDetailDto> personelDetailViewModelList { get; set; }
        public Personel1 personel1 { get; set; }
        public PersonelDetailDto personelDetailViewModel { get; set; }
    }
}