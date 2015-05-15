// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Dec-2013, 11:16:35




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREmployee_DetailedBuilder : IEntityBuilder<HREmployee_DetailedEntity>
    {
        IList<HREmployee_DetailedEntity> IEntityBuilder<HREmployee_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployee_DetailedEntity> HREmployee_DetailedEntityList = new List<HREmployee_DetailedEntity>();

            while (reader.Read())
            {
                HREmployee_DetailedEntityList.Add(((IEntityBuilder<HREmployee_DetailedEntity>)this).BuildEntity(reader));
            }

            return (HREmployee_DetailedEntityList.Count > 0) ? HREmployee_DetailedEntityList : null;
        }

        HREmployee_DetailedEntity IEntityBuilder<HREmployee_DetailedEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_DISCONTINUTION = 21;
            const Int32 FLD_SERVICEAGEMONTH = 22;
            const Int32 FLD_ROWNUMBER = 23;

            HREmployee_DetailedEntity hREmployee_DetailedEntity = new HREmployee_DetailedEntity();

            hREmployee_DetailedEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployee_DetailedEntity.MemberID = reader.GetInt64(FLD_MEMBERID);
            if (reader.IsDBNull(FLD_PROJECTID)) { hREmployee_DetailedEntity.ProjectID = null; } else { hREmployee_DetailedEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            if (reader.IsDBNull(FLD_DESIGNATIONID)) { hREmployee_DetailedEntity.DesignationID = null; } else { hREmployee_DetailedEntity.DesignationID = reader.GetInt64(FLD_DESIGNATIONID); }
            hREmployee_DetailedEntity.EmployeeCode = reader.GetString(FLD_EMPLOYEECODE);
            hREmployee_DetailedEntity.EmployeeJobTypeID = reader.GetInt64(FLD_EMPLOYEEJOBTYPEID);
            if (reader.IsDBNull(FLD_CONFIRMDATE)) { hREmployee_DetailedEntity.ConfirmDate = null; } else { hREmployee_DetailedEntity.ConfirmDate = reader.GetDateTime(FLD_CONFIRMDATE); }
            if (reader.IsDBNull(FLD_JOINDATE)) { hREmployee_DetailedEntity.JoinDate = null; } else { hREmployee_DetailedEntity.JoinDate = reader.GetDateTime(FLD_JOINDATE); }
            if (reader.IsDBNull(FLD_SALARYLEVEL)) { hREmployee_DetailedEntity.SalaryLevel = null; } else { hREmployee_DetailedEntity.SalaryLevel = reader.GetInt32(FLD_SALARYLEVEL); }
            hREmployee_DetailedEntity.PrimaryEmail = reader.GetString(FLD_PRIMARYEMAIL);
            if (reader.IsDBNull(FLD_DEPARTMENTID)) { hREmployee_DetailedEntity.DepartmentID = null; } else { hREmployee_DetailedEntity.DepartmentID = reader.GetInt64(FLD_DEPARTMENTID); }
            if (reader.IsDBNull(FLD_EMPLOYMENTSTATUSID)) { hREmployee_DetailedEntity.EmploymentStatusID = null; } else { hREmployee_DetailedEntity.EmploymentStatusID = reader.GetInt64(FLD_EMPLOYMENTSTATUSID); }
            if (reader.IsDBNull(FLD_INITIALS)) { hREmployee_DetailedEntity.Initials = String.Empty; } else { hREmployee_DetailedEntity.Initials = reader.GetString(FLD_INITIALS); }
            if (reader.IsDBNull(FLD_SECONDARYEMAIL)) { hREmployee_DetailedEntity.SecondaryEmail = String.Empty; } else { hREmployee_DetailedEntity.SecondaryEmail = reader.GetString(FLD_SECONDARYEMAIL); }
            if (reader.IsDBNull(FLD_EMPLOYEEFULLNAME)) { hREmployee_DetailedEntity.EmployeeFullName = String.Empty; } else { hREmployee_DetailedEntity.EmployeeFullName = reader.GetString(FLD_EMPLOYEEFULLNAME); }
            if (reader.IsDBNull(FLD_PROJECTCODE)) { hREmployee_DetailedEntity.ProjectCode = String.Empty; } else { hREmployee_DetailedEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { hREmployee_DetailedEntity.ProjectName = String.Empty; } else { hREmployee_DetailedEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_DEPARTMENTCODE)) { hREmployee_DetailedEntity.DepartmentCode = String.Empty; } else { hREmployee_DetailedEntity.DepartmentCode = reader.GetString(FLD_DEPARTMENTCODE); }
            if (reader.IsDBNull(FLD_NAME)) { hREmployee_DetailedEntity.Name = String.Empty; } else { hREmployee_DetailedEntity.Name = reader.GetString(FLD_NAME); }
            if (reader.IsDBNull(FLD_DESIGNATIONNAME)) { hREmployee_DetailedEntity.DesignationName = String.Empty; } else { hREmployee_DetailedEntity.DesignationName = reader.GetString(FLD_DESIGNATIONNAME); }
            if (reader.IsDBNull(FLD_EMPLOYMENTSTATUSNAME)) { hREmployee_DetailedEntity.EmploymentStatusName = String.Empty; } else { hREmployee_DetailedEntity.EmploymentStatusName = reader.GetString(FLD_EMPLOYMENTSTATUSNAME); }
            if (reader.IsDBNull(FLD_DISCONTINUTION)) { hREmployee_DetailedEntity.Discontinution = null; } else { hREmployee_DetailedEntity.Discontinution = reader.GetDateTime(FLD_DISCONTINUTION); }
            if (reader.IsDBNull(FLD_SERVICEAGEMONTH)) { hREmployee_DetailedEntity.ServiceAgeMonth = null; } else { hREmployee_DetailedEntity.ServiceAgeMonth = reader.GetInt32(FLD_SERVICEAGEMONTH); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { hREmployee_DetailedEntity.RowNumber = null; } else { hREmployee_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return hREmployee_DetailedEntity;
        }
    }
}
