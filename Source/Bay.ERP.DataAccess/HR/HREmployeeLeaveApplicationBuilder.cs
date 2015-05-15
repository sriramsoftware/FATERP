// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-Jan-2014, 06:33:35




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREmployeeLeaveApplicationBuilder : IEntityBuilder<HREmployeeLeaveApplicationEntity>
    {
        IList<HREmployeeLeaveApplicationEntity> IEntityBuilder<HREmployeeLeaveApplicationEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeLeaveApplicationEntity> HREmployeeLeaveApplicationEntityList = new List<HREmployeeLeaveApplicationEntity>();

            while (reader.Read())
            {
                HREmployeeLeaveApplicationEntityList.Add(((IEntityBuilder<HREmployeeLeaveApplicationEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeLeaveApplicationEntityList.Count > 0) ? HREmployeeLeaveApplicationEntityList : null;
        }

        HREmployeeLeaveApplicationEntity IEntityBuilder<HREmployeeLeaveApplicationEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEELEAVEAPPLICATIONID = 0;
            const Int32 FLD_EMPLOYEEID = 1;
            const Int32 FLD_APPLICATIONDATE = 2;
            const Int32 FLD_REQUESTSTARTDATE = 3;
            const Int32 FLD_REQUESTENDDATE = 4;
            const Int32 FLD_TOTALLEAVEDAYS = 5;
            const Int32 FLD_DESCRIPTION = 6;
            const Int32 FLD_BACKUPEMPLOYEEID = 7;
            const Int32 FLD_LEAVEAPPLICATIONAPPLICATIONSTATUSID = 8;
            const Int32 FLD_LEAVECATEGORYID = 9;
            const Int32 FLD_SALARYSESSIONID = 10;
            const Int32 FLD_LEAVELOCATION = 11;
            const Int32 FLD_FISCALYEARID = 12;

            HREmployeeLeaveApplicationEntity hREmployeeLeaveApplicationEntity = new HREmployeeLeaveApplicationEntity();

            hREmployeeLeaveApplicationEntity.EmployeeLeaveApplicationID = reader.GetInt64(FLD_EMPLOYEELEAVEAPPLICATIONID);
            hREmployeeLeaveApplicationEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeLeaveApplicationEntity.ApplicationDate = reader.GetDateTime(FLD_APPLICATIONDATE);
            hREmployeeLeaveApplicationEntity.RequestStartDate = reader.GetDateTime(FLD_REQUESTSTARTDATE);
            hREmployeeLeaveApplicationEntity.RequestEndDate = reader.GetDateTime(FLD_REQUESTENDDATE);
            hREmployeeLeaveApplicationEntity.TotalLeaveDays = reader.GetDecimal(FLD_TOTALLEAVEDAYS);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { hREmployeeLeaveApplicationEntity.Description = String.Empty; } else { hREmployeeLeaveApplicationEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            if (reader.IsDBNull(FLD_BACKUPEMPLOYEEID)) { hREmployeeLeaveApplicationEntity.BackupEmployeeID = null; } else { hREmployeeLeaveApplicationEntity.BackupEmployeeID = reader.GetInt64(FLD_BACKUPEMPLOYEEID); }
            hREmployeeLeaveApplicationEntity.LeaveApplicationApplicationStatusID = reader.GetInt64(FLD_LEAVEAPPLICATIONAPPLICATIONSTATUSID);
            if (reader.IsDBNull(FLD_LEAVECATEGORYID)) { hREmployeeLeaveApplicationEntity.LeaveCategoryID = null; } else { hREmployeeLeaveApplicationEntity.LeaveCategoryID = reader.GetInt64(FLD_LEAVECATEGORYID); }
            if (reader.IsDBNull(FLD_SALARYSESSIONID)) { hREmployeeLeaveApplicationEntity.SalarySessionID = null; } else { hREmployeeLeaveApplicationEntity.SalarySessionID = reader.GetInt64(FLD_SALARYSESSIONID); }
            if (reader.IsDBNull(FLD_LEAVELOCATION)) { hREmployeeLeaveApplicationEntity.LeaveLocation = null; } else { hREmployeeLeaveApplicationEntity.LeaveLocation = reader.GetString(FLD_LEAVELOCATION); }
            if (reader.IsDBNull(FLD_FISCALYEARID)) { hREmployeeLeaveApplicationEntity.FiscalYearID = null; } else { hREmployeeLeaveApplicationEntity.FiscalYearID = reader.GetInt64(FLD_FISCALYEARID); }

            return hREmployeeLeaveApplicationEntity;
        }
    }
}
