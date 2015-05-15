// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Sep-2013, 02:21:03




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREmployeeEvaluationIndividual_CustomBuilder : IEntityBuilder<HREmployeeEvaluationIndividual_CustomEntity>
    {
        IList<HREmployeeEvaluationIndividual_CustomEntity> IEntityBuilder<HREmployeeEvaluationIndividual_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeEvaluationIndividual_CustomEntity> HREmployeeEvaluationIndividual_CustomEntityList = new List<HREmployeeEvaluationIndividual_CustomEntity>();

            while (reader.Read())
            {
                HREmployeeEvaluationIndividual_CustomEntityList.Add(((IEntityBuilder<HREmployeeEvaluationIndividual_CustomEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeEvaluationIndividual_CustomEntityList.Count > 0) ? HREmployeeEvaluationIndividual_CustomEntityList : null;
        }

        HREmployeeEvaluationIndividual_CustomEntity IEntityBuilder<HREmployeeEvaluationIndividual_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SESSIONID = 0;
            const Int32 FLD_SESSIONNAME = 1;
            const Int32 FLD_STARTDATE = 2;
            const Int32 FLD_ENDDATE = 3;
            const Int32 FLD_DEADLINEDATE = 4;
            const Int32 FLD_EVALUATIONSESSIONCATEGORYNAME = 5;
            const Int32 FLD_EVALUATIONNAME = 6;
            const Int32 FLD_EMPLOYEEID = 7;
            const Int32 FLD_SUPERVISOREMPLOYEEID = 8;
            const Int32 FLD_EMPLOYEESUBMITDATE = 9;
            const Int32 FLD_SUPERVISORSUBMITDATE = 10;
            const Int32 FLD_EVALUATEDBYID = 11;
            const Int32 FLD_EVALUATIONSESSIONSTATUSID = 12;
            const Int32 FLD_SESSIONCATEGORYID = 13;
            const Int32 FLD_SUPERVISORFULLNAME = 14;
            const Int32 FLD_SUPERVISOREMPLOYEECODE = 15;
            const Int32 FLD_SUPERVISOREMPLOYEEDEPARTMENTNAME = 16;
            const Int32 FLD_SUPERVISOREMPLOYEELEVEL = 17;
            const Int32 FLD_EMPLOYEEFULLNAME = 18;
            const Int32 FLD_EMPLOYEEEVALUATIONID = 19;
            const Int32 FLD_EMPLOYEECODE = 20;
            const Int32 FLD_EMPLOYEEDEPARTMENTNAME = 21;
            const Int32 FLD_EMPLOYEELEVEL = 22;
            const Int32 FLD_EVALUATIONSESSIONSTATUSNAME = 23;

            HREmployeeEvaluationIndividual_CustomEntity hREmployeeEvaluationIndividual_CustomEntity = new HREmployeeEvaluationIndividual_CustomEntity();

            hREmployeeEvaluationIndividual_CustomEntity.SessionID = reader.GetInt64(FLD_SESSIONID);
            hREmployeeEvaluationIndividual_CustomEntity.SessionName = reader.GetString(FLD_SESSIONNAME);
            hREmployeeEvaluationIndividual_CustomEntity.StartDate = reader.GetDateTime(FLD_STARTDATE);
            hREmployeeEvaluationIndividual_CustomEntity.EndDate = reader.GetDateTime(FLD_ENDDATE);
            hREmployeeEvaluationIndividual_CustomEntity.DeadlineDate = reader.GetDateTime(FLD_DEADLINEDATE);
            hREmployeeEvaluationIndividual_CustomEntity.EvaluationSessionCategoryName = reader.GetString(FLD_EVALUATIONSESSIONCATEGORYNAME);
            hREmployeeEvaluationIndividual_CustomEntity.EvaluationName = reader.GetString(FLD_EVALUATIONNAME);
            if (reader.IsDBNull(FLD_EMPLOYEEID)) { hREmployeeEvaluationIndividual_CustomEntity.EmployeeID = null; } else { hREmployeeEvaluationIndividual_CustomEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID); }
            if (reader.IsDBNull(FLD_SUPERVISOREMPLOYEEID)) { hREmployeeEvaluationIndividual_CustomEntity.SupervisorEmployeeID = null; } else { hREmployeeEvaluationIndividual_CustomEntity.SupervisorEmployeeID = reader.GetInt64(FLD_SUPERVISOREMPLOYEEID); }
            if (reader.IsDBNull(FLD_EMPLOYEESUBMITDATE)) { hREmployeeEvaluationIndividual_CustomEntity.EmployeeSubmitDate = null; } else { hREmployeeEvaluationIndividual_CustomEntity.EmployeeSubmitDate = reader.GetDateTime(FLD_EMPLOYEESUBMITDATE); }
            if (reader.IsDBNull(FLD_SUPERVISORSUBMITDATE)) { hREmployeeEvaluationIndividual_CustomEntity.SupervisorSubmitDate = null; } else { hREmployeeEvaluationIndividual_CustomEntity.SupervisorSubmitDate = reader.GetDateTime(FLD_SUPERVISORSUBMITDATE); }
            hREmployeeEvaluationIndividual_CustomEntity.EvaluatedByID = reader.GetInt64(FLD_EVALUATEDBYID);
            hREmployeeEvaluationIndividual_CustomEntity.EvaluationSessionStatusID = reader.GetInt64(FLD_EVALUATIONSESSIONSTATUSID);
            hREmployeeEvaluationIndividual_CustomEntity.SessionCategoryID = reader.GetInt64(FLD_SESSIONCATEGORYID);
            if (reader.IsDBNull(FLD_SUPERVISORFULLNAME)) { hREmployeeEvaluationIndividual_CustomEntity.SupervisorFullName = String.Empty; } else { hREmployeeEvaluationIndividual_CustomEntity.SupervisorFullName = reader.GetString(FLD_SUPERVISORFULLNAME); }
            if (reader.IsDBNull(FLD_SUPERVISOREMPLOYEECODE)) { hREmployeeEvaluationIndividual_CustomEntity.SupervisorEmployeeCode = String.Empty; } else { hREmployeeEvaluationIndividual_CustomEntity.SupervisorEmployeeCode = reader.GetString(FLD_SUPERVISOREMPLOYEECODE); }
            if (reader.IsDBNull(FLD_SUPERVISOREMPLOYEEDEPARTMENTNAME)) { hREmployeeEvaluationIndividual_CustomEntity.SupervisorEmployeeDepartmentName = String.Empty; } else { hREmployeeEvaluationIndividual_CustomEntity.SupervisorEmployeeDepartmentName = reader.GetString(FLD_SUPERVISOREMPLOYEEDEPARTMENTNAME); }
            if (reader.IsDBNull(FLD_SUPERVISOREMPLOYEELEVEL)) { hREmployeeEvaluationIndividual_CustomEntity.SupervisorEmployeeLevel = String.Empty; } else { hREmployeeEvaluationIndividual_CustomEntity.SupervisorEmployeeLevel = reader.GetString(FLD_SUPERVISOREMPLOYEELEVEL); }
            if (reader.IsDBNull(FLD_EMPLOYEEFULLNAME)) { hREmployeeEvaluationIndividual_CustomEntity.EmployeeFullName = String.Empty; } else { hREmployeeEvaluationIndividual_CustomEntity.EmployeeFullName = reader.GetString(FLD_EMPLOYEEFULLNAME); }
            hREmployeeEvaluationIndividual_CustomEntity.EmployeeEvaluationID = reader.GetInt64(FLD_EMPLOYEEEVALUATIONID);
            if (reader.IsDBNull(FLD_EMPLOYEECODE)) { hREmployeeEvaluationIndividual_CustomEntity.EmployeeCode = String.Empty; } else { hREmployeeEvaluationIndividual_CustomEntity.EmployeeCode = reader.GetString(FLD_EMPLOYEECODE); }
            if (reader.IsDBNull(FLD_EMPLOYEEDEPARTMENTNAME)) { hREmployeeEvaluationIndividual_CustomEntity.EmployeeDepartmentName = String.Empty; } else { hREmployeeEvaluationIndividual_CustomEntity.EmployeeDepartmentName = reader.GetString(FLD_EMPLOYEEDEPARTMENTNAME); }
            if (reader.IsDBNull(FLD_EMPLOYEELEVEL)) { hREmployeeEvaluationIndividual_CustomEntity.EmployeeLevel = String.Empty; } else { hREmployeeEvaluationIndividual_CustomEntity.EmployeeLevel = reader.GetString(FLD_EMPLOYEELEVEL); }
            hREmployeeEvaluationIndividual_CustomEntity.EvaluationSessionStatusName = reader.GetString(FLD_EVALUATIONSESSIONSTATUSNAME);

            return hREmployeeEvaluationIndividual_CustomEntity;
        }
    }
}
