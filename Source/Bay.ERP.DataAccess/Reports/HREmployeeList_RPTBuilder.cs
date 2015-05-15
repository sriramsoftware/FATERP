// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Jan-2014, 01:58:57




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREmployeeList_RPTBuilder : IEntityBuilder<HREmployeeList_RPTEntity>
    {
        IList<HREmployeeList_RPTEntity> IEntityBuilder<HREmployeeList_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeList_RPTEntity> HREmployeeList_RPTEntityList = new List<HREmployeeList_RPTEntity>();

            while (reader.Read())
            {
                HREmployeeList_RPTEntityList.Add(((IEntityBuilder<HREmployeeList_RPTEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeList_RPTEntityList.Count > 0) ? HREmployeeList_RPTEntityList : null;
        }

        HREmployeeList_RPTEntity IEntityBuilder<HREmployeeList_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEEID = 0;
            const Int32 FLD_MEMBERID = 1;
            const Int32 FLD_PROJECTID = 2;
            const Int32 FLD_DESIGNATIONID = 3;
            const Int32 FLD_EMPLOYEECODE = 4;
            const Int32 FLD_CONFIRMDATE = 5;
            const Int32 FLD_JOINDATE = 6;
            const Int32 FLD_SALARYLEVEL = 7;
            const Int32 FLD_EMPLOYEEFULLNAME = 8;
            const Int32 FLD_PROJECTCODE = 9;
            const Int32 FLD_PROJECTNAME = 10;
            const Int32 FLD_DEPARTMENTCODE = 11;
            const Int32 FLD_DEPARTMENTNAME = 12;
            const Int32 FLD_DESIGNATIONNAME = 13;
            const Int32 FLD_DESCRIPTION = 14;
            const Int32 FLD_SALARYAMOUNT = 15;
            const Int32 FLD_ALLOWANCE = 16;
            const Int32 FLD_DISCONTINUATION = 17;

            HREmployeeList_RPTEntity hREmployeeList_RPTEntity = new HREmployeeList_RPTEntity();

            hREmployeeList_RPTEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeList_RPTEntity.MemberID = reader.GetInt64(FLD_MEMBERID);
            if (reader.IsDBNull(FLD_PROJECTID)) { hREmployeeList_RPTEntity.ProjectID = null; } else { hREmployeeList_RPTEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            if (reader.IsDBNull(FLD_DESIGNATIONID)) { hREmployeeList_RPTEntity.DesignationID = null; } else { hREmployeeList_RPTEntity.DesignationID = reader.GetInt64(FLD_DESIGNATIONID); }
            hREmployeeList_RPTEntity.EmployeeCode = reader.GetString(FLD_EMPLOYEECODE);
            if (reader.IsDBNull(FLD_CONFIRMDATE)) { hREmployeeList_RPTEntity.ConfirmDate = null; } else { hREmployeeList_RPTEntity.ConfirmDate = reader.GetDateTime(FLD_CONFIRMDATE); }
            if (reader.IsDBNull(FLD_JOINDATE)) { hREmployeeList_RPTEntity.JoinDate = null; } else { hREmployeeList_RPTEntity.JoinDate = reader.GetDateTime(FLD_JOINDATE); }
            if (reader.IsDBNull(FLD_SALARYLEVEL)) { hREmployeeList_RPTEntity.SalaryLevel = null; } else { hREmployeeList_RPTEntity.SalaryLevel = reader.GetInt32(FLD_SALARYLEVEL); }
            if (reader.IsDBNull(FLD_EMPLOYEEFULLNAME)) { hREmployeeList_RPTEntity.EmployeeFullName = String.Empty; } else { hREmployeeList_RPTEntity.EmployeeFullName = reader.GetString(FLD_EMPLOYEEFULLNAME); }
            if (reader.IsDBNull(FLD_PROJECTCODE)) { hREmployeeList_RPTEntity.ProjectCode = String.Empty; } else { hREmployeeList_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { hREmployeeList_RPTEntity.ProjectName = String.Empty; } else { hREmployeeList_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_DEPARTMENTCODE)) { hREmployeeList_RPTEntity.DepartmentCode = String.Empty; } else { hREmployeeList_RPTEntity.DepartmentCode = reader.GetString(FLD_DEPARTMENTCODE); }
            if (reader.IsDBNull(FLD_DEPARTMENTNAME)) { hREmployeeList_RPTEntity.DepartmentName = String.Empty; } else { hREmployeeList_RPTEntity.DepartmentName = reader.GetString(FLD_DEPARTMENTNAME); }
            if (reader.IsDBNull(FLD_DESIGNATIONNAME)) { hREmployeeList_RPTEntity.DesignationName = String.Empty; } else { hREmployeeList_RPTEntity.DesignationName = reader.GetString(FLD_DESIGNATIONNAME); }
            if (reader.IsDBNull(FLD_DESCRIPTION)) { hREmployeeList_RPTEntity.Description = String.Empty; } else { hREmployeeList_RPTEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            if (reader.IsDBNull(FLD_SALARYAMOUNT)) { hREmployeeList_RPTEntity.SalaryAmount = null; } else { hREmployeeList_RPTEntity.SalaryAmount = reader.GetDecimal(FLD_SALARYAMOUNT); }
            hREmployeeList_RPTEntity.Allowance = reader.GetString(FLD_ALLOWANCE);
            hREmployeeList_RPTEntity.Discontinuation = reader.GetDateTime(FLD_DISCONTINUATION);

            return hREmployeeList_RPTEntity;
        }
    }
}
