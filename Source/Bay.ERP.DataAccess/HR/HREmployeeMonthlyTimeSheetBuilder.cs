// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Jan-2014, 03:42:17




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREmployeeMonthlyTimeSheetBuilder : IEntityBuilder<HREmployeeMonthlyTimeSheetEntity>
    {
        IList<HREmployeeMonthlyTimeSheetEntity> IEntityBuilder<HREmployeeMonthlyTimeSheetEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeMonthlyTimeSheetEntity> HREmployeeMonthlyTimeSheetEntityList = new List<HREmployeeMonthlyTimeSheetEntity>();

            while (reader.Read())
            {
                HREmployeeMonthlyTimeSheetEntityList.Add(((IEntityBuilder<HREmployeeMonthlyTimeSheetEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeMonthlyTimeSheetEntityList.Count > 0) ? HREmployeeMonthlyTimeSheetEntityList : null;
        }

        HREmployeeMonthlyTimeSheetEntity IEntityBuilder<HREmployeeMonthlyTimeSheetEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEEMONTHLYTIMESHEETID = 0;
            const Int32 FLD_FISCALYEARID = 1;
            const Int32 FLD_SALARYSESSIONID = 2;
            const Int32 FLD_ATTENDANCELEAVEANDHOLIDAYCATEGORYID = 3;
            const Int32 FLD_NOTE = 4;
            const Int32 FLD_WORKINGDAY = 5;
            const Int32 FLD_YEAR = 6;
            const Int32 FLD_MONTH = 7;
            const Int32 FLD_DAY = 8;
            const Int32 FLD_REMARKS = 9;
            const Int32 FLD_DATE = 10;
            const Int32 FLD_ISREMOVED = 11;

            HREmployeeMonthlyTimeSheetEntity hREmployeeMonthlyTimeSheetEntity = new HREmployeeMonthlyTimeSheetEntity();

            hREmployeeMonthlyTimeSheetEntity.EmployeeMonthlyTimeSheetID = reader.GetInt64(FLD_EMPLOYEEMONTHLYTIMESHEETID);
            hREmployeeMonthlyTimeSheetEntity.FiscalYearID = reader.GetInt64(FLD_FISCALYEARID);
            hREmployeeMonthlyTimeSheetEntity.SalarySessionID = reader.GetInt64(FLD_SALARYSESSIONID);
            hREmployeeMonthlyTimeSheetEntity.AttendanceLeaveAndHolidayCategoryID = reader.GetInt64(FLD_ATTENDANCELEAVEANDHOLIDAYCATEGORYID);
            hREmployeeMonthlyTimeSheetEntity.Note = reader.GetString(FLD_NOTE);
            hREmployeeMonthlyTimeSheetEntity.WorkingDay = reader.GetDateTime(FLD_WORKINGDAY);
            hREmployeeMonthlyTimeSheetEntity.Year = reader.GetInt32(FLD_YEAR);
            hREmployeeMonthlyTimeSheetEntity.Month = reader.GetInt32(FLD_MONTH);
            hREmployeeMonthlyTimeSheetEntity.Day = reader.GetInt32(FLD_DAY);
            if (reader.IsDBNull(FLD_REMARKS)) { hREmployeeMonthlyTimeSheetEntity.Remarks = String.Empty; } else { hREmployeeMonthlyTimeSheetEntity.Remarks = reader.GetString(FLD_REMARKS); }
            hREmployeeMonthlyTimeSheetEntity.Date = reader.GetDateTime(FLD_DATE);
            hREmployeeMonthlyTimeSheetEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return hREmployeeMonthlyTimeSheetEntity;
        }
    }
}
