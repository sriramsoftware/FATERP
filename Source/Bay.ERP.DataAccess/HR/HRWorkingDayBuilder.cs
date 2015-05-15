// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Dec-2013, 03:14:39




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HRWorkingDayBuilder : IEntityBuilder<HRWorkingDayEntity>
    {
        IList<HRWorkingDayEntity> IEntityBuilder<HRWorkingDayEntity>.BuildEntities(IDataReader reader)
        {
            List<HRWorkingDayEntity> HRWorkingDayEntityList = new List<HRWorkingDayEntity>();

            while (reader.Read())
            {
                HRWorkingDayEntityList.Add(((IEntityBuilder<HRWorkingDayEntity>)this).BuildEntity(reader));
            }

            return (HRWorkingDayEntityList.Count > 0) ? HRWorkingDayEntityList : null;
        }

        HRWorkingDayEntity IEntityBuilder<HRWorkingDayEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_WORKINGDAYID = 0;
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

            HRWorkingDayEntity hRWorkingDayEntity = new HRWorkingDayEntity();

            hRWorkingDayEntity.WorkingDayID = reader.GetInt64(FLD_WORKINGDAYID);
            hRWorkingDayEntity.FiscalYearID = reader.GetInt64(FLD_FISCALYEARID);
            hRWorkingDayEntity.SalarySessionID = reader.GetInt64(FLD_SALARYSESSIONID);
            hRWorkingDayEntity.AttendanceLeaveAndHolidayCategoryID = reader.GetInt64(FLD_ATTENDANCELEAVEANDHOLIDAYCATEGORYID);
            hRWorkingDayEntity.Note = reader.GetString(FLD_NOTE);
            hRWorkingDayEntity.WorkingDay = reader.GetDateTime(FLD_WORKINGDAY);
            hRWorkingDayEntity.Year = reader.GetInt32(FLD_YEAR);
            hRWorkingDayEntity.Month = reader.GetInt32(FLD_MONTH);
            hRWorkingDayEntity.Day = reader.GetInt32(FLD_DAY);
            if (reader.IsDBNull(FLD_REMARKS)) { hRWorkingDayEntity.Remarks = String.Empty; } else { hRWorkingDayEntity.Remarks = reader.GetString(FLD_REMARKS); }
            hRWorkingDayEntity.Date = reader.GetDateTime(FLD_DATE);
            hRWorkingDayEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return hRWorkingDayEntity;
        }
    }
}
