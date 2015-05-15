// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Jan-2014, 04:20:23




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREmployeeLeaveStatus_RPTBuilder : IEntityBuilder<HREmployeeLeaveStatus_RPTEntity>
    {
        IList<HREmployeeLeaveStatus_RPTEntity> IEntityBuilder<HREmployeeLeaveStatus_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeLeaveStatus_RPTEntity> HREmployeeLeaveStatus_RPTEntityList = new List<HREmployeeLeaveStatus_RPTEntity>();

            while (reader.Read())
            {
                HREmployeeLeaveStatus_RPTEntityList.Add(((IEntityBuilder<HREmployeeLeaveStatus_RPTEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeLeaveStatus_RPTEntityList.Count > 0) ? HREmployeeLeaveStatus_RPTEntityList : null;
        }

        HREmployeeLeaveStatus_RPTEntity IEntityBuilder<HREmployeeLeaveStatus_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEEFULLNAME = 0;
            const Int32 FLD_EMPLOYEECODE = 1;
            const Int32 FLD_CONFIRMDATE = 2;
            const Int32 FLD_JOINDATE = 3;
            const Int32 FLD_SERVICEAGEMONTH = 4;
            const Int32 FLD_PROJECTCODE = 5;
            const Int32 FLD_PROJECTNAME = 6;
            const Int32 FLD_DEPARTMENTCODE = 7;
            const Int32 FLD_DEPARTMENTNAME = 8;
            const Int32 FLD_DESIGNATIONNAME = 9;
            const Int32 FLD_EMPLOYEELEAVEAPPLICATIONID = 10;
            const Int32 FLD_EMPLOYEEID = 11;
            const Int32 FLD_APPLICATIONDATE = 12;
            const Int32 FLD_REQUESTSTARTDATE = 13;
            const Int32 FLD_REQUESTENDDATE = 14;
            const Int32 FLD_TOTALLEAVEDAYS = 15;
            const Int32 FLD_DESCRIPTION = 16;
            const Int32 FLD_LEAVEAPPLICATIONAPPLICATIONSTATUSID = 17;
            const Int32 FLD_LEAVECATEGORYID = 18;
            const Int32 FLD_FISCALYEARID = 19;
            const Int32 FLD_LEAVEAPPLICATIONAPPLICATIONSTATUSNAME = 20;
            const Int32 FLD_LEAVECATEGORYNAME = 21;
            const Int32 FLD_CASUALLEAVEEARNED = 22;
            const Int32 FLD_MEDICALLEAVEEARNED = 23;
            const Int32 FLD_EARNLEAVEEARNED = 24;
            const Int32 FLD_LWPLEAVEEARNED = 25;
            const Int32 FLD_CASUALLEAVEENJOYED = 26;
            const Int32 FLD_MEDICALLEAVEENJOYED = 27;
            const Int32 FLD_EARNLEAVEENJOYED = 28;
            const Int32 FLD_LWPLEAVEENJOYED = 29;

            HREmployeeLeaveStatus_RPTEntity hREmployeeLeaveStatus_RPTEntity = new HREmployeeLeaveStatus_RPTEntity();

            if (reader.IsDBNull(FLD_EMPLOYEEFULLNAME)) { hREmployeeLeaveStatus_RPTEntity.EmployeeFullName = String.Empty; } else { hREmployeeLeaveStatus_RPTEntity.EmployeeFullName = reader.GetString(FLD_EMPLOYEEFULLNAME); }
            if (reader.IsDBNull(FLD_EMPLOYEECODE)) { hREmployeeLeaveStatus_RPTEntity.EmployeeCode = String.Empty; } else { hREmployeeLeaveStatus_RPTEntity.EmployeeCode = reader.GetString(FLD_EMPLOYEECODE); }
            if (reader.IsDBNull(FLD_CONFIRMDATE)) { hREmployeeLeaveStatus_RPTEntity.ConfirmDate = null; } else { hREmployeeLeaveStatus_RPTEntity.ConfirmDate = reader.GetDateTime(FLD_CONFIRMDATE); }
            if (reader.IsDBNull(FLD_JOINDATE)) { hREmployeeLeaveStatus_RPTEntity.JoinDate = null; } else { hREmployeeLeaveStatus_RPTEntity.JoinDate = reader.GetDateTime(FLD_JOINDATE); }
            if (reader.IsDBNull(FLD_SERVICEAGEMONTH)) { hREmployeeLeaveStatus_RPTEntity.ServiceAgeMonth = null; } else { hREmployeeLeaveStatus_RPTEntity.ServiceAgeMonth = reader.GetInt32(FLD_SERVICEAGEMONTH); }
            if (reader.IsDBNull(FLD_PROJECTCODE)) { hREmployeeLeaveStatus_RPTEntity.ProjectCode = String.Empty; } else { hREmployeeLeaveStatus_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { hREmployeeLeaveStatus_RPTEntity.ProjectName = String.Empty; } else { hREmployeeLeaveStatus_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_DEPARTMENTCODE)) { hREmployeeLeaveStatus_RPTEntity.DepartmentCode = String.Empty; } else { hREmployeeLeaveStatus_RPTEntity.DepartmentCode = reader.GetString(FLD_DEPARTMENTCODE); }
            if (reader.IsDBNull(FLD_DEPARTMENTNAME)) { hREmployeeLeaveStatus_RPTEntity.DepartmentName = String.Empty; } else { hREmployeeLeaveStatus_RPTEntity.DepartmentName = reader.GetString(FLD_DEPARTMENTNAME); }
            if (reader.IsDBNull(FLD_DESIGNATIONNAME)) { hREmployeeLeaveStatus_RPTEntity.DesignationName = String.Empty; } else { hREmployeeLeaveStatus_RPTEntity.DesignationName = reader.GetString(FLD_DESIGNATIONNAME); }
            hREmployeeLeaveStatus_RPTEntity.EmployeeLeaveApplicationID = reader.GetInt64(FLD_EMPLOYEELEAVEAPPLICATIONID);
            hREmployeeLeaveStatus_RPTEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeLeaveStatus_RPTEntity.ApplicationDate = reader.GetDateTime(FLD_APPLICATIONDATE);
            hREmployeeLeaveStatus_RPTEntity.RequestStartDate = reader.GetDateTime(FLD_REQUESTSTARTDATE);
            hREmployeeLeaveStatus_RPTEntity.RequestEndDate = reader.GetDateTime(FLD_REQUESTENDDATE);
            hREmployeeLeaveStatus_RPTEntity.TotalLeaveDays = reader.GetDecimal(FLD_TOTALLEAVEDAYS);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { hREmployeeLeaveStatus_RPTEntity.Description = String.Empty; } else { hREmployeeLeaveStatus_RPTEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            hREmployeeLeaveStatus_RPTEntity.LeaveApplicationApplicationStatusID = reader.GetInt64(FLD_LEAVEAPPLICATIONAPPLICATIONSTATUSID);
            if (reader.IsDBNull(FLD_LEAVECATEGORYID)) { hREmployeeLeaveStatus_RPTEntity.LeaveCategoryID = null; } else { hREmployeeLeaveStatus_RPTEntity.LeaveCategoryID = reader.GetInt64(FLD_LEAVECATEGORYID); }
            if (reader.IsDBNull(FLD_FISCALYEARID)) { hREmployeeLeaveStatus_RPTEntity.FiscalYearID = null; } else { hREmployeeLeaveStatus_RPTEntity.FiscalYearID = reader.GetInt64(FLD_FISCALYEARID); }
            if (reader.IsDBNull(FLD_LEAVEAPPLICATIONAPPLICATIONSTATUSNAME)) { hREmployeeLeaveStatus_RPTEntity.LeaveApplicationApplicationStatusName = String.Empty; } else { hREmployeeLeaveStatus_RPTEntity.LeaveApplicationApplicationStatusName = reader.GetString(FLD_LEAVEAPPLICATIONAPPLICATIONSTATUSNAME); }
            if (reader.IsDBNull(FLD_LEAVECATEGORYNAME)) { hREmployeeLeaveStatus_RPTEntity.LeaveCategoryName = String.Empty; } else { hREmployeeLeaveStatus_RPTEntity.LeaveCategoryName = reader.GetString(FLD_LEAVECATEGORYNAME); }
            if (reader.IsDBNull(FLD_CASUALLEAVEEARNED)) { hREmployeeLeaveStatus_RPTEntity.CasualLeaveEarned = null; } else { hREmployeeLeaveStatus_RPTEntity.CasualLeaveEarned = reader.GetDecimal(FLD_CASUALLEAVEEARNED); }
            if (reader.IsDBNull(FLD_MEDICALLEAVEEARNED)) { hREmployeeLeaveStatus_RPTEntity.MedicalLeaveEarned = null; } else { hREmployeeLeaveStatus_RPTEntity.MedicalLeaveEarned = reader.GetDecimal(FLD_MEDICALLEAVEEARNED); }
            if (reader.IsDBNull(FLD_EARNLEAVEEARNED)) { hREmployeeLeaveStatus_RPTEntity.EarnLeaveEarned = null; } else { hREmployeeLeaveStatus_RPTEntity.EarnLeaveEarned = reader.GetDecimal(FLD_EARNLEAVEEARNED); }
            if (reader.IsDBNull(FLD_LWPLEAVEEARNED)) { hREmployeeLeaveStatus_RPTEntity.LWPLeaveEarned = null; } else { hREmployeeLeaveStatus_RPTEntity.LWPLeaveEarned = reader.GetDecimal(FLD_LWPLEAVEEARNED); }
            if (reader.IsDBNull(FLD_CASUALLEAVEENJOYED)) { hREmployeeLeaveStatus_RPTEntity.CasualLeaveEnjoyed = null; } else { hREmployeeLeaveStatus_RPTEntity.CasualLeaveEnjoyed = reader.GetDecimal(FLD_CASUALLEAVEENJOYED); }
            if (reader.IsDBNull(FLD_MEDICALLEAVEENJOYED)) { hREmployeeLeaveStatus_RPTEntity.MedicalLeaveEnjoyed = null; } else { hREmployeeLeaveStatus_RPTEntity.MedicalLeaveEnjoyed = reader.GetDecimal(FLD_MEDICALLEAVEENJOYED); }
            if (reader.IsDBNull(FLD_EARNLEAVEENJOYED)) { hREmployeeLeaveStatus_RPTEntity.EarnLeaveEnjoyed = null; } else { hREmployeeLeaveStatus_RPTEntity.EarnLeaveEnjoyed = reader.GetDecimal(FLD_EARNLEAVEENJOYED); }
            if (reader.IsDBNull(FLD_LWPLEAVEENJOYED)) { hREmployeeLeaveStatus_RPTEntity.LWPLeaveEnjoyed = null; } else { hREmployeeLeaveStatus_RPTEntity.LWPLeaveEnjoyed = reader.GetDecimal(FLD_LWPLEAVEENJOYED); }

            return hREmployeeLeaveStatus_RPTEntity;
        }
    }
}
