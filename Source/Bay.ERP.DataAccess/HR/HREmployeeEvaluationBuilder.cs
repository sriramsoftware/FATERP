// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Sep-2013, 01:42:20




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREmployeeEvaluationBuilder : IEntityBuilder<HREmployeeEvaluationEntity>
    {
        IList<HREmployeeEvaluationEntity> IEntityBuilder<HREmployeeEvaluationEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeEvaluationEntity> HREmployeeEvaluationEntityList = new List<HREmployeeEvaluationEntity>();

            while (reader.Read())
            {
                HREmployeeEvaluationEntityList.Add(((IEntityBuilder<HREmployeeEvaluationEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeEvaluationEntityList.Count > 0) ? HREmployeeEvaluationEntityList : null;
        }

        HREmployeeEvaluationEntity IEntityBuilder<HREmployeeEvaluationEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEEEVALUATIONID = 0;
            const Int32 FLD_SESSIONID = 1;
            const Int32 FLD_EVALUATIONNAME = 2;
            const Int32 FLD_EMPLOYEEID = 3;
            const Int32 FLD_EMPLOYEEFULLNAME = 4;
            const Int32 FLD_EMPLOYEECODE = 5;
            const Int32 FLD_EMPLOYEEDEPARTMENTNAME = 6;
            const Int32 FLD_EMPLOYEELEVEL = 7;
            const Int32 FLD_SUPERVISOREMPLOYEEID = 8;
            const Int32 FLD_SUPERVISORFULLNAME = 9;
            const Int32 FLD_SUPERVISOREMPLOYEECODE = 10;
            const Int32 FLD_SUPERVISOREMPLOYEEDEPARTMENTNAME = 11;
            const Int32 FLD_SUPERVISOREMPLOYEELEVEL = 12;
            const Int32 FLD_EMPLOYEESUBMITDATE = 13;
            const Int32 FLD_SUPERVISORSUBMITDATE = 14;
            const Int32 FLD_CREATEDATE = 15;
            const Int32 FLD_EVALUATEDBYID = 16;
            const Int32 FLD_REMARKS = 17;
            const Int32 FLD_EXTRA = 18;

            HREmployeeEvaluationEntity hREmployeeEvaluationEntity = new HREmployeeEvaluationEntity();

            hREmployeeEvaluationEntity.EmployeeEvaluationID = reader.GetInt64(FLD_EMPLOYEEEVALUATIONID);
            hREmployeeEvaluationEntity.SessionID = reader.GetInt64(FLD_SESSIONID);
            hREmployeeEvaluationEntity.EvaluationName = reader.GetString(FLD_EVALUATIONNAME);
            if (reader.IsDBNull(FLD_EMPLOYEEID)) { hREmployeeEvaluationEntity.EmployeeID = null; } else { hREmployeeEvaluationEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID); }
            if (reader.IsDBNull(FLD_EMPLOYEEFULLNAME)) { hREmployeeEvaluationEntity.EmployeeFullName = String.Empty; } else { hREmployeeEvaluationEntity.EmployeeFullName = reader.GetString(FLD_EMPLOYEEFULLNAME); }
            if (reader.IsDBNull(FLD_EMPLOYEECODE)) { hREmployeeEvaluationEntity.EmployeeCode = String.Empty; } else { hREmployeeEvaluationEntity.EmployeeCode = reader.GetString(FLD_EMPLOYEECODE); }
            if (reader.IsDBNull(FLD_EMPLOYEEDEPARTMENTNAME)) { hREmployeeEvaluationEntity.EmployeeDepartmentName = String.Empty; } else { hREmployeeEvaluationEntity.EmployeeDepartmentName = reader.GetString(FLD_EMPLOYEEDEPARTMENTNAME); }
            if (reader.IsDBNull(FLD_EMPLOYEELEVEL)) { hREmployeeEvaluationEntity.EmployeeLevel = String.Empty; } else { hREmployeeEvaluationEntity.EmployeeLevel = reader.GetString(FLD_EMPLOYEELEVEL); }
            if (reader.IsDBNull(FLD_SUPERVISOREMPLOYEEID)) { hREmployeeEvaluationEntity.SupervisorEmployeeID = null; } else { hREmployeeEvaluationEntity.SupervisorEmployeeID = reader.GetInt64(FLD_SUPERVISOREMPLOYEEID); }
            if (reader.IsDBNull(FLD_SUPERVISORFULLNAME)) { hREmployeeEvaluationEntity.SupervisorFullName = String.Empty; } else { hREmployeeEvaluationEntity.SupervisorFullName = reader.GetString(FLD_SUPERVISORFULLNAME); }
            if (reader.IsDBNull(FLD_SUPERVISOREMPLOYEECODE)) { hREmployeeEvaluationEntity.SupervisorEmployeeCode = String.Empty; } else { hREmployeeEvaluationEntity.SupervisorEmployeeCode = reader.GetString(FLD_SUPERVISOREMPLOYEECODE); }
            if (reader.IsDBNull(FLD_SUPERVISOREMPLOYEEDEPARTMENTNAME)) { hREmployeeEvaluationEntity.SupervisorEmployeeDepartmentName = String.Empty; } else { hREmployeeEvaluationEntity.SupervisorEmployeeDepartmentName = reader.GetString(FLD_SUPERVISOREMPLOYEEDEPARTMENTNAME); }
            if (reader.IsDBNull(FLD_SUPERVISOREMPLOYEELEVEL)) { hREmployeeEvaluationEntity.SupervisorEmployeeLevel = String.Empty; } else { hREmployeeEvaluationEntity.SupervisorEmployeeLevel = reader.GetString(FLD_SUPERVISOREMPLOYEELEVEL); }
            if (reader.IsDBNull(FLD_EMPLOYEESUBMITDATE)) { hREmployeeEvaluationEntity.EmployeeSubmitDate = null; } else { hREmployeeEvaluationEntity.EmployeeSubmitDate = reader.GetDateTime(FLD_EMPLOYEESUBMITDATE); }
            if (reader.IsDBNull(FLD_SUPERVISORSUBMITDATE)) { hREmployeeEvaluationEntity.SupervisorSubmitDate = null; } else { hREmployeeEvaluationEntity.SupervisorSubmitDate = reader.GetDateTime(FLD_SUPERVISORSUBMITDATE); }
            if (reader.IsDBNull(FLD_CREATEDATE)) { hREmployeeEvaluationEntity.CreateDate = null; } else { hREmployeeEvaluationEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE); }
            hREmployeeEvaluationEntity.EvaluatedByID = reader.GetInt64(FLD_EVALUATEDBYID);
            if (reader.IsDBNull(FLD_REMARKS)) { hREmployeeEvaluationEntity.Remarks = String.Empty; } else { hREmployeeEvaluationEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_EXTRA)) { hREmployeeEvaluationEntity.Extra = String.Empty; } else { hREmployeeEvaluationEntity.Extra = reader.GetString(FLD_EXTRA); }

            return hREmployeeEvaluationEntity;
        }
    }
}
