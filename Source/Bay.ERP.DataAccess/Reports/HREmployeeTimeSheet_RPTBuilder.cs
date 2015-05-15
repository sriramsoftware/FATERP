// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Dec-2013, 06:16:34




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREmployeeTimeSheet_RPTBuilder : IEntityBuilder<HREmployeeTimeSheet_RPTEntity>
    {
        IList<HREmployeeTimeSheet_RPTEntity> IEntityBuilder<HREmployeeTimeSheet_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeTimeSheet_RPTEntity> HREmployeeTimeSheet_RPTEntityList = new List<HREmployeeTimeSheet_RPTEntity>();

            while (reader.Read())
            {
                HREmployeeTimeSheet_RPTEntityList.Add(((IEntityBuilder<HREmployeeTimeSheet_RPTEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeTimeSheet_RPTEntityList.Count > 0) ? HREmployeeTimeSheet_RPTEntityList : null;
        }

        HREmployeeTimeSheet_RPTEntity IEntityBuilder<HREmployeeTimeSheet_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEEID = 0;
            const Int32 FLD_MEMBERID = 1;
            const Int32 FLD_PROJECTID = 2;
            const Int32 FLD_DESIGNATIONID = 3;
            const Int32 FLD_EMPLOYEECODE = 4;
            const Int32 FLD_EMPLOYEEJOBTYPEID = 5;
            const Int32 FLD_CONFIRMDATE = 6;
            const Int32 FLD_JOINDATE = 7;
            const Int32 FLD_SALARYLEVEL = 8;
            const Int32 FLD_PRIMARYEMAIL = 9;
            const Int32 FLD_DEPARTMENTID = 10;
            const Int32 FLD_EMPLOYMENTSTATUSID = 11;
            const Int32 FLD_INITIALS = 12;
            const Int32 FLD_SECONDARYEMAIL = 13;
            const Int32 FLD_EMPLOYEEFULLNAME = 14;
            const Int32 FLD_PROJECTCODE = 15;
            const Int32 FLD_PROJECTNAME = 16;
            const Int32 FLD_DEPARTMENTCODE = 17;
            const Int32 FLD_NAME = 18;
            const Int32 FLD_DESIGNATIONNAME = 19;
            const Int32 FLD_EMPLOYMENTSTATUSNAME = 20;

            HREmployeeTimeSheet_RPTEntity hREmployeeTimeSheet_RPTEntity = new HREmployeeTimeSheet_RPTEntity();

            hREmployeeTimeSheet_RPTEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeTimeSheet_RPTEntity.MemberID = reader.GetInt64(FLD_MEMBERID);
            if (reader.IsDBNull(FLD_PROJECTID)) { hREmployeeTimeSheet_RPTEntity.ProjectID = null; } else { hREmployeeTimeSheet_RPTEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            if (reader.IsDBNull(FLD_DESIGNATIONID)) { hREmployeeTimeSheet_RPTEntity.DesignationID = null; } else { hREmployeeTimeSheet_RPTEntity.DesignationID = reader.GetInt64(FLD_DESIGNATIONID); }
            hREmployeeTimeSheet_RPTEntity.EmployeeCode = reader.GetString(FLD_EMPLOYEECODE);
            hREmployeeTimeSheet_RPTEntity.EmployeeJobTypeID = reader.GetInt64(FLD_EMPLOYEEJOBTYPEID);
            if (reader.IsDBNull(FLD_CONFIRMDATE)) { hREmployeeTimeSheet_RPTEntity.ConfirmDate = null; } else { hREmployeeTimeSheet_RPTEntity.ConfirmDate = reader.GetDateTime(FLD_CONFIRMDATE); }
            if (reader.IsDBNull(FLD_JOINDATE)) { hREmployeeTimeSheet_RPTEntity.JoinDate = null; } else { hREmployeeTimeSheet_RPTEntity.JoinDate = reader.GetDateTime(FLD_JOINDATE); }
            if (reader.IsDBNull(FLD_SALARYLEVEL)) { hREmployeeTimeSheet_RPTEntity.SalaryLevel = null; } else { hREmployeeTimeSheet_RPTEntity.SalaryLevel = reader.GetInt32(FLD_SALARYLEVEL); }
            hREmployeeTimeSheet_RPTEntity.PrimaryEmail = reader.GetString(FLD_PRIMARYEMAIL);
            if (reader.IsDBNull(FLD_DEPARTMENTID)) { hREmployeeTimeSheet_RPTEntity.DepartmentID = null; } else { hREmployeeTimeSheet_RPTEntity.DepartmentID = reader.GetInt64(FLD_DEPARTMENTID); }
            if (reader.IsDBNull(FLD_EMPLOYMENTSTATUSID)) { hREmployeeTimeSheet_RPTEntity.EmploymentStatusID = null; } else { hREmployeeTimeSheet_RPTEntity.EmploymentStatusID = reader.GetInt64(FLD_EMPLOYMENTSTATUSID); }
            if (reader.IsDBNull(FLD_INITIALS)) { hREmployeeTimeSheet_RPTEntity.Initials = String.Empty; } else { hREmployeeTimeSheet_RPTEntity.Initials = reader.GetString(FLD_INITIALS); }
            if (reader.IsDBNull(FLD_SECONDARYEMAIL)) { hREmployeeTimeSheet_RPTEntity.SecondaryEmail = String.Empty; } else { hREmployeeTimeSheet_RPTEntity.SecondaryEmail = reader.GetString(FLD_SECONDARYEMAIL); }
            if (reader.IsDBNull(FLD_EMPLOYEEFULLNAME)) { hREmployeeTimeSheet_RPTEntity.EmployeeFullName = String.Empty; } else { hREmployeeTimeSheet_RPTEntity.EmployeeFullName = reader.GetString(FLD_EMPLOYEEFULLNAME); }
            if (reader.IsDBNull(FLD_PROJECTCODE)) { hREmployeeTimeSheet_RPTEntity.ProjectCode = String.Empty; } else { hREmployeeTimeSheet_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { hREmployeeTimeSheet_RPTEntity.ProjectName = String.Empty; } else { hREmployeeTimeSheet_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_DEPARTMENTCODE)) { hREmployeeTimeSheet_RPTEntity.DepartmentCode = String.Empty; } else { hREmployeeTimeSheet_RPTEntity.DepartmentCode = reader.GetString(FLD_DEPARTMENTCODE); }
            if (reader.IsDBNull(FLD_NAME)) { hREmployeeTimeSheet_RPTEntity.Name = String.Empty; } else { hREmployeeTimeSheet_RPTEntity.Name = reader.GetString(FLD_NAME); }
            if (reader.IsDBNull(FLD_DESIGNATIONNAME)) { hREmployeeTimeSheet_RPTEntity.DesignationName = String.Empty; } else { hREmployeeTimeSheet_RPTEntity.DesignationName = reader.GetString(FLD_DESIGNATIONNAME); }
            if (reader.IsDBNull(FLD_EMPLOYMENTSTATUSNAME)) { hREmployeeTimeSheet_RPTEntity.EmploymentStatusName = String.Empty; } else { hREmployeeTimeSheet_RPTEntity.EmploymentStatusName = reader.GetString(FLD_EMPLOYMENTSTATUSNAME); }

            return hREmployeeTimeSheet_RPTEntity;
        }
    }
}
