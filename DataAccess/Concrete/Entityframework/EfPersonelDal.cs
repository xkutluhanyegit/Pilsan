using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Constant;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;

namespace DataAccess.Concrete.Entityframework
{
    public class EfPersonelDal : EfEntityRepositoryBase<Personel1, PersonelCIContext>, IPersonelDal
    {
        public List<DepartmentPersonelDetailDto> GetAllDepartmentPersonelDetailDto(int week, string departmentID,string overtimeDay)
        {
            using (var context = new PersonelCIContext())
            {
                var personelList = context.Personel1s.Where(p => p.Iscikt == null & p.Depart == departmentID & p.Masraf == "501" || p.Masraf == "1002");
                var shiftList = context.Personelshifts.Where(p => p.WeekOfYear == week);
                var overtimeList = context.Personelovertimes.Where(p => p.Overtimeday == overtimeDay);

                var result = from personel in personelList
                             join kimlik in context.Kimlik1s
                             on personel.Sicilno equals kimlik.Prsicil into t1
                             from personelKimlik in t1.DefaultIfEmpty()

                             join departman in context.Departmen
                             on personel.Depart equals departman.Kodu into t2
                             from personelDepartman in t2.DefaultIfEmpty()

                             join service in context.Servis
                             on personel.Servis equals service.Kodu into t3
                             from personelService in t3.DefaultIfEmpty()

                             join durak in context.Duraks
                             on personel.Durak equals durak.DurakKodu into t4
                             from personelDurak in t4.DefaultIfEmpty()

                             join personelShift in shiftList
                             on personel.Sicilno equals personelShift.Sicilno into t5
                             from personelShifts in t5.DefaultIfEmpty()

                             join shift in context.Shifts
                             on personelShifts.Shiftid equals shift.Shiftid into t6
                             from personelShiftsID in t6.DefaultIfEmpty()

                             join overtime in overtimeList
                             on personel.Sicilno equals overtime.Sicilno into t7
                             from personelOvertimeList in t7.DefaultIfEmpty()

                             join overtimeID in context.Overtimes
                             on personelOvertimeList.Overtimeid equals overtimeID.Overtimeid into t8
                             from personelOvertimeID in t8.DefaultIfEmpty()

                             select new DepartmentPersonelDetailDto
                             {
                                 Name = personel.Adi,
                                 Surname = personel.Soyadi,
                                 RegisterNo = personel.Sicilno,
                                 TCKN = personelKimlik.Tckmno,
                                 DepartmanID = personelDepartman.Kodu,
                                 DepartmanName = personelDepartman.Adi,
                                 ServiceID = personelService.Kodu,
                                 ServiceName = personelService.Turu,
                                 StationID = personelDurak.DurakKodu,
                                 StationName = personelDurak.DurakAdi,
                                 ShiftID = personelShifts.Shiftid,
                                 ShiftName = personelShiftsID.Shiftname,
                                 OvertimeID = personelOvertimeID.Overtimeid,
                                 OvertimeName = personelOvertimeID.Overtimename,
                                 WeekofYear = personelShifts.WeekOfYear,
                                 OvertimeDay = personelOvertimeList.Overtimeday

                             };
                return result.ToList();
            }
        }

        public List<HRPersonelDetailDto> GetAllHRPersonelDetailDto(int week,string overtimeDay)
        {
            using (var context = new PersonelCIContext())
            {
                var personelList = context.Personel1s.Where(p => p.Iscikt == null & p.Masraf == "501" || p.Masraf == "1002" );
                var shiftList = context.Personelshifts.Where(p => p.WeekOfYear == week);
                var overtimeList = context.Personelovertimes.Where(p => p.Overtimeday == overtimeDay);

                var result = from personel in personelList
                             join kimlik in context.Kimlik1s
                             on personel.Sicilno equals kimlik.Prsicil into t1
                             from personelKimlik in t1.DefaultIfEmpty()

                             join departman in context.Departmen
                             on personel.Depart equals departman.Kodu into t2
                             from personelDepartman in t2.DefaultIfEmpty()

                             join service in context.Servis
                             on personel.Servis equals service.Kodu into t3
                             from personelService in t3.DefaultIfEmpty()

                             join durak in context.Duraks
                             on personel.Durak equals durak.DurakKodu into t4
                             from personelDurak in t4.DefaultIfEmpty()

                             join personelShift in shiftList
                             on personel.Sicilno equals personelShift.Sicilno into t5
                             from personelShifts in t5.DefaultIfEmpty()

                             join shift in context.Shifts
                             on personelShifts.Shiftid equals shift.Shiftid into t6
                             from personelShiftsID in t6.DefaultIfEmpty()

                             join overtime in overtimeList
                             on personel.Sicilno equals overtime.Sicilno into t7
                             from personelOvertimeList in t7.DefaultIfEmpty()

                             join overtimeID in context.Overtimes
                             on personelOvertimeList.Overtimeid equals overtimeID.Overtimeid into t8
                             from personelOvertimeID in t8.DefaultIfEmpty()

                             select new HRPersonelDetailDto
                             {
                                 Name = personel.Adi,
                                 Surname = personel.Soyadi,
                                 RegisterNo = personel.Sicilno,
                                 TCKN = personelKimlik.Tckmno,
                                 DepartmanID = personelDepartman.Kodu,
                                 DepartmanName = personelDepartman.Adi,
                                 ServiceID = personelService.Kodu,
                                 ServiceName = personelService.Turu,
                                 StationID = personelDurak.DurakKodu,
                                 StationName = personelDurak.DurakAdi,
                                 ShiftID = personelShifts.Shiftid,
                                 ShiftName = personelShiftsID.Shiftname,
                                 OvertimeID = personelOvertimeID.Overtimeid,
                                 OvertimeName = personelOvertimeID.Overtimename,
                                 WeekofYear = personelShifts.WeekOfYear,
                                 OvertimeDay = personelOvertimeList.Overtimeday

                             };
                return result.ToList();
            }
        }
    }
}