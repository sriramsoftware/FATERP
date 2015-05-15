// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Dec-2013, 06:06:24




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HRWorkingDay_RPTBuilder : IEntityBuilder<HRWorkingDay_RPTEntity>
    {
        IList<HRWorkingDay_RPTEntity> IEntityBuilder<HRWorkingDay_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<HRWorkingDay_RPTEntity> HRWorkingDay_RPTEntityList = new List<HRWorkingDay_RPTEntity>();

            while (reader.Read())
            {
                HRWorkingDay_RPTEntityList.Add(((IEntityBuilder<HRWorkingDay_RPTEntity>)this).BuildEntity(reader));
            }

            return (HRWorkingDay_RPTEntityList.Count > 0) ? HRWorkingDay_RPTEntityList : null;
        }

        HRWorkingDay_RPTEntity IEntityBuilder<HRWorkingDay_RPTEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_BEGINDATE = 12;
            const Int32 FLD_ENDDATE = 13;
            const Int32 FLD_ISCLOSED = 14;
            const Int32 FLD_ISLOCKED = 15;
            const Int32 FLD_NAME = 16;
            const Int32 FLD_SESSIONSTARTDATE = 17;
            const Int32 FLD_SESSIONENDDATE = 18;
            const Int32 FLD_SALARYSESSIONREMARKS = 19;
            const Int32 FLD_SALARYSESSIONSTATUSID = 20;
            const Int32 FLD_ISCURRENTSESSION = 21;
            const Int32 FLD_ATTENDANCELEAVEANDHOLIDAYCATEGORYNAME = 22;
            const Int32 FLD_DESCRIPTION = 23;
            const Int32 FLD_SALARYSESSIONSTATUSNAME = 24;

            HRWorkingDay_RPTEntity hRWorkingDay_RPTEntity = new HRWorkingDay_RPTEntity();

            hRWorkingDay_RPTEntity.WorkingDayID = reader.GetInt64(FLD_WORKINGDAYID);
            hRWorkingDay_RPTEntity.FiscalYearID = reader.GetInt64(FLD_FISCALYEARID);
            hRWorkingDay_RPTEntity.SalarySessionID = reader.GetInt64(FLD_SALARYSESSIONID);
            hRWorkingDay_RPTEntity.AttendanceLeaveAndHolidayCategoryID = reader.GetInt64(FLD_ATTENDANCELEAVEANDHOLIDAYCATEGORYID);
            hRWorkingDay_RPTEntity.Note = reader.GetString(FLD_NOTE);
            hRWorkingDay_RPTEntity.WorkingDay = reader.GetDateTime(FLD_WORKINGDAY);
            hRWorkingDay_RPTEntity.Year = reader.GetInt32(FLD_YEAR);
            hRWorkingDay_RPTEntity.Month = reader.GetInt32(FLD_MONTH);
            hRWorkingDay_RPTEntity.Day = reader.GetInt32(FLD_DAY);
            if (reader.IsDBNull(FLD_REMARKS)) { hRWorkingDay_RPTEntity.Remarks = String.Empty; } else { hRWorkingDay_RPTEntity.Remarks = reader.GetString(FLD_REMARKS); }
            hRWorkingDay_RPTEntity.Date = reader.GetDateTime(FLD_DATE);
            hRWorkingDay_RPTEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            if (reader.IsDBNull(FLD_BEGINDATE)) { hRWorkingDay_RPTEntity.BeginDate = null; } else { hRWorkingDay_RPTEntity.BeginDate = reader.GetDateTime(FLD_BEGINDATE); }
            if (reader.IsDBNull(FLD_ENDDATE)) { hRWorkingDay_RPTEntity.EndDate = null; } else { hRWorkingDay_RPTEntity.EndDate = reader.GetDateTime(FLD_ENDDATE); }
            if (reader.IsDBNull(FLD_ISCLOSED)) { hRWorkingDay_RPTEntity.IsClosed = false; } else { hRWorkingDay_RPTEntity.IsClosed = reader.GetBoolean(FLD_ISCLOSED); }
            if (reader.IsDBNull(FLD_ISLOCKED)) { hRWorkingDay_RPTEntity.IsLocked = false; } else { hRWorkingDay_RPTEntity.IsLocked = reader.GetBoolean(FLD_ISLOCKED); }
            if (reader.IsDBNull(FLD_NAME)) { hRWorkingDay_RPTEntity.Name = String.Empty; } else { hRWorkingDay_RPTEntity.Name = reader.GetString(FLD_NAME); }
            if (reader.IsDBNull(FLD_SESSIONSTARTDATE)) { hRWorkingDay_RPTEntity.SessionStartDate = null; } else { hRWorkingDay_RPTEntity.SessionStartDate = reader.GetDateTime(FLD_SESSIONSTARTDATE); }
            if (reader.IsDBNull(FLD_SESSIONENDDATE)) { hRWorkingDay_RPTEntity.SessionEndDate = null; } else { hRWorkingDay_RPTEntity.SessionEndDate = reader.GetDateTime(FLD_SESSIONENDDATE); }
            if (reader.IsDBNull(FLD_SALARYSESSIONREMARKS)) { hRWorkingDay_RPTEntity.SalarySessionRemarks = String.Empty; } else { hRWorkingDay_RPTEntity.SalarySessionRemarks = reader.GetString(FLD_SALARYSESSIONREMARKS); }
            if (reader.IsDBNull(FLD_SALARYSESSIONSTATUSID)) { hRWorkingDay_RPTEntity.SalarySessionStatusID = null; } else { hRWorkingDay_RPTEntity.SalarySessionStatusID = reader.GetInt64(FLD_SALARYSESSIONSTATUSID); }
            if (reader.IsDBNull(FLD_ISCURRENTSESSION)) { hRWorkingDay_RPTEntity.IsCurrentSession = false; } else { hRWorkingDay_RPTEntity.IsCurrentSession = reader.GetBoolean(FLD_ISCURRENTSESSION); }
            if (reader.IsDBNull(FLD_ATTENDANCELEAVEANDHOLIDAYCATEGORYNAME)) { hRWorkingDay_RPTEntity.AttendanceLeaveAndHolidayCategoryName = String.Empty; } else { hRWorkingDay_RPTEntity.AttendanceLeaveAndHolidayCategoryName = reader.GetString(FLD_ATTENDANCELEAVEANDHOLIDAYCATEGORYNAME); }
            if (reader.IsDBNull(FLD_DESCRIPTION)) { hRWorkingDay_RPTEntity.Description = String.Empty; } else { hRWorkingDay_RPTEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            if (reader.IsDBNull(FLD_SALARYSESSIONSTATUSNAME)) { hRWorkingDay_RPTEntity.SalarySessionStatusName = String.Empty; } else { hRWorkingDay_RPTEntity.SalarySessionStatusName = reader.GetString(FLD_SALARYSESSIONSTATUSNAME); }

            return hRWorkingDay_RPTEntity;
        }
    }
}
