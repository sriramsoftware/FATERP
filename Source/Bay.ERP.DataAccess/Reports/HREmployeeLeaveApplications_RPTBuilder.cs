// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Jul-2013, 09:56:00




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREmployeeLeaveApplications_RPTBuilder : IEntityBuilder<HREmployeeLeaveApplications_RPTEntity>
    {
        IList<HREmployeeLeaveApplications_RPTEntity> IEntityBuilder<HREmployeeLeaveApplications_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeLeaveApplications_RPTEntity> HREmployeeLeaveApplications_RPTEntityList = new List<HREmployeeLeaveApplications_RPTEntity>();

            while (reader.Read())
            {
                HREmployeeLeaveApplications_RPTEntityList.Add(((IEntityBuilder<HREmployeeLeaveApplications_RPTEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeLeaveApplications_RPTEntityList.Count > 0) ? HREmployeeLeaveApplications_RPTEntityList : null;
        }

        HREmployeeLeaveApplications_RPTEntity IEntityBuilder<HREmployeeLeaveApplications_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEEFULLNAME = 0;
            const Int32 FLD_EMPLOYEECODE = 1;
            const Int32 FLD_TOTALLEAVEDAYS = 2;
            const Int32 FLD_LEAVECATEGORYID = 3;
            const Int32 FLD_LEAVEAPPLICATIONSTATUSNAME = 4;
            const Int32 FLD_APPLICATIONDATE = 5;
            const Int32 FLD_REQUESTSTARTDATE = 6;
            const Int32 FLD_REQUESTENDDATE = 7;
            const Int32 FLD_LEAVELOCATION = 8;
            const Int32 FLD_LEAVEPURPOSE = 9;
            const Int32 FLD_SESSIONSTARTDATE = 10;
            const Int32 FLD_SESSIONENDDATE = 11;

            HREmployeeLeaveApplications_RPTEntity hREmployeeLeaveApplications_RPTEntity = new HREmployeeLeaveApplications_RPTEntity();

            hREmployeeLeaveApplications_RPTEntity.EmployeeFullName = reader.GetString(FLD_EMPLOYEEFULLNAME);
            hREmployeeLeaveApplications_RPTEntity.EmployeeCode = reader.GetString(FLD_EMPLOYEECODE);
            hREmployeeLeaveApplications_RPTEntity.TotalLeaveDays= reader.GetDecimal(FLD_TOTALLEAVEDAYS);
            hREmployeeLeaveApplications_RPTEntity.LeaveCategoryID = reader.GetInt64(FLD_LEAVECATEGORYID);
            hREmployeeLeaveApplications_RPTEntity.LeaveApplicationStatusName = reader.GetString(FLD_LEAVEAPPLICATIONSTATUSNAME);
            hREmployeeLeaveApplications_RPTEntity.ApplicationDate = reader.GetDateTime(FLD_APPLICATIONDATE);
            hREmployeeLeaveApplications_RPTEntity.RequestStartDate = reader.GetDateTime(FLD_REQUESTSTARTDATE);
            hREmployeeLeaveApplications_RPTEntity.RequestEndDate = reader.GetDateTime(FLD_REQUESTENDDATE);
            hREmployeeLeaveApplications_RPTEntity.LeavePurpose = reader.GetString(FLD_LEAVEPURPOSE);
            hREmployeeLeaveApplications_RPTEntity.SessionStartDate = reader.GetDateTime(FLD_SESSIONSTARTDATE);
            hREmployeeLeaveApplications_RPTEntity.SessionEndDate = reader.GetDateTime(FLD_SESSIONENDDATE);
            if (reader.IsDBNull(FLD_LEAVELOCATION)) { hREmployeeLeaveApplications_RPTEntity.LeaveLocation = String.Empty; } else { hREmployeeLeaveApplications_RPTEntity.LeaveLocation = reader.GetString(FLD_LEAVELOCATION); }


            return hREmployeeLeaveApplications_RPTEntity;
        }
    }
}
