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
    internal sealed class HREmployeeAllowanceCustom_DetailedBuilder : IEntityBuilder<HREmployeeAllowanceCustom_DetailedEntity>
    {
        IList<HREmployeeAllowanceCustom_DetailedEntity> IEntityBuilder<HREmployeeAllowanceCustom_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeAllowanceCustom_DetailedEntity> HREmployeeAllowanceCustom_DetailedEntityList = new List<HREmployeeAllowanceCustom_DetailedEntity>();

            while (reader.Read())
            {
                HREmployeeAllowanceCustom_DetailedEntityList.Add(((IEntityBuilder<HREmployeeAllowanceCustom_DetailedEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeAllowanceCustom_DetailedEntityList.Count > 0) ? HREmployeeAllowanceCustom_DetailedEntityList : null;
        }

        HREmployeeAllowanceCustom_DetailedEntity IEntityBuilder<HREmployeeAllowanceCustom_DetailedEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_ALLOWANCEAMOUNT = 24;
            const Int32 FLD_ALLOWANCENOTE = 25;

            HREmployeeAllowanceCustom_DetailedEntity hREmployeeAllowanceCustom_DetailedEntity = new HREmployeeAllowanceCustom_DetailedEntity();

            hREmployeeAllowanceCustom_DetailedEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeAllowanceCustom_DetailedEntity.MemberID = reader.GetInt64(FLD_MEMBERID);
            if (reader.IsDBNull(FLD_PROJECTID)) { hREmployeeAllowanceCustom_DetailedEntity.ProjectID = null; } else { hREmployeeAllowanceCustom_DetailedEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            if (reader.IsDBNull(FLD_DESIGNATIONID)) { hREmployeeAllowanceCustom_DetailedEntity.DesignationID = null; } else { hREmployeeAllowanceCustom_DetailedEntity.DesignationID = reader.GetInt64(FLD_DESIGNATIONID); }
            hREmployeeAllowanceCustom_DetailedEntity.EmployeeCode = reader.GetString(FLD_EMPLOYEECODE);
            hREmployeeAllowanceCustom_DetailedEntity.EmployeeJobTypeID = reader.GetInt64(FLD_EMPLOYEEJOBTYPEID);
            if (reader.IsDBNull(FLD_CONFIRMDATE)) { hREmployeeAllowanceCustom_DetailedEntity.ConfirmDate = null; } else { hREmployeeAllowanceCustom_DetailedEntity.ConfirmDate = reader.GetDateTime(FLD_CONFIRMDATE); }
            if (reader.IsDBNull(FLD_JOINDATE)) { hREmployeeAllowanceCustom_DetailedEntity.JoinDate = null; } else { hREmployeeAllowanceCustom_DetailedEntity.JoinDate = reader.GetDateTime(FLD_JOINDATE); }
            if (reader.IsDBNull(FLD_SALARYLEVEL)) { hREmployeeAllowanceCustom_DetailedEntity.SalaryLevel = null; } else { hREmployeeAllowanceCustom_DetailedEntity.SalaryLevel = reader.GetInt32(FLD_SALARYLEVEL); }
            hREmployeeAllowanceCustom_DetailedEntity.PrimaryEmail = reader.GetString(FLD_PRIMARYEMAIL);
            if (reader.IsDBNull(FLD_DEPARTMENTID)) { hREmployeeAllowanceCustom_DetailedEntity.DepartmentID = null; } else { hREmployeeAllowanceCustom_DetailedEntity.DepartmentID = reader.GetInt64(FLD_DEPARTMENTID); }
            if (reader.IsDBNull(FLD_EMPLOYMENTSTATUSID)) { hREmployeeAllowanceCustom_DetailedEntity.EmploymentStatusID = null; } else { hREmployeeAllowanceCustom_DetailedEntity.EmploymentStatusID = reader.GetInt64(FLD_EMPLOYMENTSTATUSID); }
            if (reader.IsDBNull(FLD_INITIALS)) { hREmployeeAllowanceCustom_DetailedEntity.Initials = String.Empty; } else { hREmployeeAllowanceCustom_DetailedEntity.Initials = reader.GetString(FLD_INITIALS); }
            if (reader.IsDBNull(FLD_SECONDARYEMAIL)) { hREmployeeAllowanceCustom_DetailedEntity.SecondaryEmail = String.Empty; } else { hREmployeeAllowanceCustom_DetailedEntity.SecondaryEmail = reader.GetString(FLD_SECONDARYEMAIL); }
            if (reader.IsDBNull(FLD_EMPLOYEEFULLNAME)) { hREmployeeAllowanceCustom_DetailedEntity.EmployeeFullName = String.Empty; } else { hREmployeeAllowanceCustom_DetailedEntity.EmployeeFullName = reader.GetString(FLD_EMPLOYEEFULLNAME); }
            if (reader.IsDBNull(FLD_PROJECTCODE)) { hREmployeeAllowanceCustom_DetailedEntity.ProjectCode = String.Empty; } else { hREmployeeAllowanceCustom_DetailedEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { hREmployeeAllowanceCustom_DetailedEntity.ProjectName = String.Empty; } else { hREmployeeAllowanceCustom_DetailedEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_DEPARTMENTCODE)) { hREmployeeAllowanceCustom_DetailedEntity.DepartmentCode = String.Empty; } else { hREmployeeAllowanceCustom_DetailedEntity.DepartmentCode = reader.GetString(FLD_DEPARTMENTCODE); }
            if (reader.IsDBNull(FLD_NAME)) { hREmployeeAllowanceCustom_DetailedEntity.Name = String.Empty; } else { hREmployeeAllowanceCustom_DetailedEntity.Name = reader.GetString(FLD_NAME); }
            if (reader.IsDBNull(FLD_DESIGNATIONNAME)) { hREmployeeAllowanceCustom_DetailedEntity.DesignationName = String.Empty; } else { hREmployeeAllowanceCustom_DetailedEntity.DesignationName = reader.GetString(FLD_DESIGNATIONNAME); }
            if (reader.IsDBNull(FLD_EMPLOYMENTSTATUSNAME)) { hREmployeeAllowanceCustom_DetailedEntity.EmploymentStatusName = String.Empty; } else { hREmployeeAllowanceCustom_DetailedEntity.EmploymentStatusName = reader.GetString(FLD_EMPLOYMENTSTATUSNAME); }
            if (reader.IsDBNull(FLD_DISCONTINUTION)) { hREmployeeAllowanceCustom_DetailedEntity.Discontinution = null; } else { hREmployeeAllowanceCustom_DetailedEntity.Discontinution = reader.GetDateTime(FLD_DISCONTINUTION); }
            if (reader.IsDBNull(FLD_SERVICEAGEMONTH)) { hREmployeeAllowanceCustom_DetailedEntity.ServiceAgeMonth = null; } else { hREmployeeAllowanceCustom_DetailedEntity.ServiceAgeMonth = reader.GetInt32(FLD_SERVICEAGEMONTH); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { hREmployeeAllowanceCustom_DetailedEntity.RowNumber = null; } else { hREmployeeAllowanceCustom_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }
            hREmployeeAllowanceCustom_DetailedEntity.AllowanceAmount = reader.GetDecimal(FLD_ALLOWANCEAMOUNT);
            if (reader.IsDBNull(FLD_ALLOWANCENOTE)) { hREmployeeAllowanceCustom_DetailedEntity.AllowanceNote = String.Empty; } else { hREmployeeAllowanceCustom_DetailedEntity.AllowanceNote = reader.GetString(FLD_ALLOWANCENOTE); }

            return hREmployeeAllowanceCustom_DetailedEntity;
        }
    }
}
