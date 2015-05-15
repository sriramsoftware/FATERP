// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-Sep-2013, 04:18:32




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREmployeeBuilder : IEntityBuilder<HREmployeeEntity>
    {
        IList<HREmployeeEntity> IEntityBuilder<HREmployeeEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeEntity> HREmployeeEntityList = new List<HREmployeeEntity>();

            while (reader.Read())
            {
                HREmployeeEntityList.Add(((IEntityBuilder<HREmployeeEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeEntityList.Count > 0) ? HREmployeeEntityList : null;
        }

        HREmployeeEntity IEntityBuilder<HREmployeeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEEID = 0;
            const Int32 FLD_MEMBERID = 1;
            const Int32 FLD_PROJECTID = 2;
            const Int32 FLD_DEPARTMENTID = 3;
            const Int32 FLD_DESIGNATIONID = 4;
            const Int32 FLD_EMPLOYEECODE = 5;
            const Int32 FLD_EMPLOYEEJOBTYPEID = 6;
            const Int32 FLD_CONFIRMDATE = 7;
            const Int32 FLD_JOINDATE = 8;
            const Int32 FLD_DOB = 9;
            const Int32 FLD_SALARYLEVEL = 10;
            const Int32 FLD_BLOODGROUPID = 11;
            const Int32 FLD_PRIMARYEMAIL = 12;
            const Int32 FLD_SECONDARYEMAIL = 13;
            const Int32 FLD_INITIALS = 14;
            const Int32 FLD_ISREMOVED = 15;
            const Int32 FLD_EMPLOYMENTSTATUSID = 16;
            const Int32 FLD_DISCONTINUEDDATE = 17;

            HREmployeeEntity hREmployeeEntity = new HREmployeeEntity();

            hREmployeeEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeEntity.MemberID = reader.GetInt64(FLD_MEMBERID);
            if (reader.IsDBNull(FLD_PROJECTID)) { hREmployeeEntity.ProjectID = null; } else { hREmployeeEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            if (reader.IsDBNull(FLD_DEPARTMENTID)) { hREmployeeEntity.DepartmentID = null; } else { hREmployeeEntity.DepartmentID = reader.GetInt64(FLD_DEPARTMENTID); }
            if (reader.IsDBNull(FLD_DESIGNATIONID)) { hREmployeeEntity.DesignationID = null; } else { hREmployeeEntity.DesignationID = reader.GetInt64(FLD_DESIGNATIONID); }
            hREmployeeEntity.EmployeeCode = reader.GetString(FLD_EMPLOYEECODE);
            hREmployeeEntity.EmployeeJobTypeID = reader.GetInt64(FLD_EMPLOYEEJOBTYPEID);
            if (reader.IsDBNull(FLD_CONFIRMDATE)) { hREmployeeEntity.ConfirmDate = null; } else { hREmployeeEntity.ConfirmDate = reader.GetDateTime(FLD_CONFIRMDATE); }
            if (reader.IsDBNull(FLD_JOINDATE)) { hREmployeeEntity.JoinDate = null; } else { hREmployeeEntity.JoinDate = reader.GetDateTime(FLD_JOINDATE); }
            if (reader.IsDBNull(FLD_DOB)) { hREmployeeEntity.DOB = null; } else { hREmployeeEntity.DOB = reader.GetDateTime(FLD_DOB); }
            if (reader.IsDBNull(FLD_SALARYLEVEL)) { hREmployeeEntity.SalaryLevel = null; } else { hREmployeeEntity.SalaryLevel = reader.GetInt32(FLD_SALARYLEVEL); }
            if (reader.IsDBNull(FLD_BLOODGROUPID)) { hREmployeeEntity.BloodGroupID = null; } else { hREmployeeEntity.BloodGroupID = reader.GetInt64(FLD_BLOODGROUPID); }
            hREmployeeEntity.PrimaryEmail = reader.GetString(FLD_PRIMARYEMAIL);
            if (reader.IsDBNull(FLD_SECONDARYEMAIL)) { hREmployeeEntity.SecondaryEmail = String.Empty; } else { hREmployeeEntity.SecondaryEmail = reader.GetString(FLD_SECONDARYEMAIL); }
            if (reader.IsDBNull(FLD_INITIALS)) { hREmployeeEntity.Initials = String.Empty; } else { hREmployeeEntity.Initials = reader.GetString(FLD_INITIALS); }
            hREmployeeEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            hREmployeeEntity.EmploymentStatusID = reader.GetInt64(FLD_EMPLOYMENTSTATUSID);
            if (reader.IsDBNull(FLD_DISCONTINUEDDATE)) { hREmployeeEntity.DiscontinuedDate = null; } else { hREmployeeEntity.DiscontinuedDate = reader.GetDateTime(FLD_DISCONTINUEDDATE); }

            return hREmployeeEntity;
        }
    }
}
