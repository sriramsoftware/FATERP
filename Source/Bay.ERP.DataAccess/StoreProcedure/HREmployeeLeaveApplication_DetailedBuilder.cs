// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Jan-2014, 04:17:08




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREmployeeLeaveApplication_DetailedBuilder : IEntityBuilder<HREmployeeLeaveApplication_DetailedEntity>
    {
        IList<HREmployeeLeaveApplication_DetailedEntity> IEntityBuilder<HREmployeeLeaveApplication_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeLeaveApplication_DetailedEntity> HREmployeeLeaveApplication_DetailedEntityList = new List<HREmployeeLeaveApplication_DetailedEntity>();

            while (reader.Read())
            {
                HREmployeeLeaveApplication_DetailedEntityList.Add(((IEntityBuilder<HREmployeeLeaveApplication_DetailedEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeLeaveApplication_DetailedEntityList.Count > 0) ? HREmployeeLeaveApplication_DetailedEntityList : null;
        }

        HREmployeeLeaveApplication_DetailedEntity IEntityBuilder<HREmployeeLeaveApplication_DetailedEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_EMPLOYEEFULLNAME = 10;
            const Int32 FLD_BACKUPEMPLOYEEFULLNAME = 11;
            const Int32 FLD_NAME = 12;
            const Int32 FLD_LEAVECATEGORYNAME = 13;

            HREmployeeLeaveApplication_DetailedEntity hREmployeeLeaveApplication_DetailedEntity = new HREmployeeLeaveApplication_DetailedEntity();

            hREmployeeLeaveApplication_DetailedEntity.EmployeeLeaveApplicationID = reader.GetInt64(FLD_EMPLOYEELEAVEAPPLICATIONID);
            hREmployeeLeaveApplication_DetailedEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeLeaveApplication_DetailedEntity.ApplicationDate = reader.GetDateTime(FLD_APPLICATIONDATE);
            hREmployeeLeaveApplication_DetailedEntity.RequestStartDate = reader.GetDateTime(FLD_REQUESTSTARTDATE);
            hREmployeeLeaveApplication_DetailedEntity.RequestEndDate = reader.GetDateTime(FLD_REQUESTENDDATE);
            hREmployeeLeaveApplication_DetailedEntity.TotalLeaveDays = reader.GetDecimal(FLD_TOTALLEAVEDAYS);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { hREmployeeLeaveApplication_DetailedEntity.Description = String.Empty; } else { hREmployeeLeaveApplication_DetailedEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            if (reader.IsDBNull(FLD_BACKUPEMPLOYEEID)) { hREmployeeLeaveApplication_DetailedEntity.BackupEmployeeID = null; } else { hREmployeeLeaveApplication_DetailedEntity.BackupEmployeeID = reader.GetInt64(FLD_BACKUPEMPLOYEEID); }
            hREmployeeLeaveApplication_DetailedEntity.LeaveApplicationApplicationStatusID = reader.GetInt64(FLD_LEAVEAPPLICATIONAPPLICATIONSTATUSID);
            if (reader.IsDBNull(FLD_LEAVECATEGORYID)) { hREmployeeLeaveApplication_DetailedEntity.LeaveCategoryID = null; } else { hREmployeeLeaveApplication_DetailedEntity.LeaveCategoryID = reader.GetInt64(FLD_LEAVECATEGORYID); }
            if (reader.IsDBNull(FLD_EMPLOYEEFULLNAME)) { hREmployeeLeaveApplication_DetailedEntity.EmployeeFullName = String.Empty; } else { hREmployeeLeaveApplication_DetailedEntity.EmployeeFullName = reader.GetString(FLD_EMPLOYEEFULLNAME); }
            if (reader.IsDBNull(FLD_BACKUPEMPLOYEEFULLNAME)) { hREmployeeLeaveApplication_DetailedEntity.BackupEmployeeFullName = String.Empty; } else { hREmployeeLeaveApplication_DetailedEntity.BackupEmployeeFullName = reader.GetString(FLD_BACKUPEMPLOYEEFULLNAME); }
            if (reader.IsDBNull(FLD_NAME)) { hREmployeeLeaveApplication_DetailedEntity.Name = String.Empty; } else { hREmployeeLeaveApplication_DetailedEntity.Name = reader.GetString(FLD_NAME); }
            if (reader.IsDBNull(FLD_LEAVECATEGORYNAME)) { hREmployeeLeaveApplication_DetailedEntity.LeaveCategoryName = String.Empty; } else { hREmployeeLeaveApplication_DetailedEntity.LeaveCategoryName = reader.GetString(FLD_LEAVECATEGORYNAME); }

            return hREmployeeLeaveApplication_DetailedEntity;
        }
    }
}
