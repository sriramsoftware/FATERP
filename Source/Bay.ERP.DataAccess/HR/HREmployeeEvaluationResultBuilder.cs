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
    internal sealed class HREmployeeEvaluationResultBuilder : IEntityBuilder<HREmployeeEvaluationResultEntity>
    {
        IList<HREmployeeEvaluationResultEntity> IEntityBuilder<HREmployeeEvaluationResultEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeEvaluationResultEntity> HREmployeeEvaluationResultEntityList = new List<HREmployeeEvaluationResultEntity>();

            while (reader.Read())
            {
                HREmployeeEvaluationResultEntityList.Add(((IEntityBuilder<HREmployeeEvaluationResultEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeEvaluationResultEntityList.Count > 0) ? HREmployeeEvaluationResultEntityList : null;
        }

        HREmployeeEvaluationResultEntity IEntityBuilder<HREmployeeEvaluationResultEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEEEVALUATIONRESULTID = 0;
            const Int32 FLD_EVALUATIONCRITERIACATEGORYID = 1;
            const Int32 FLD_QUESTION = 2;
            const Int32 FLD_DESCRIPTION = 3;
            const Int32 FLD_EMPLOYEEEVALUATIONID = 4;
            const Int32 FLD_EMPLOYEEEVALUATIONCRITERIAID = 5;
            const Int32 FLD_ANSWERGIVENBYEMPLOYEEDEPARTMENTNAME = 6;
            const Int32 FLD_EMPLOYEEFULLNAME = 7;
            const Int32 FLD_EMPLOYEECODE = 8;
            const Int32 FLD_SUPERVISOREVALUATIONCRITERIAID = 9;
            const Int32 FLD_SUPERVISORDEPARTMENTNAME = 10;
            const Int32 FLD_ANSWERGIVENBYSUPERVISOREMPLOYEEFULLNAME = 11;
            const Int32 FLD_SUPERVISOREMPLOYEECODE = 12;
            const Int32 FLD_EMPLOYEERESULT = 13;
            const Int32 FLD_RESULT = 14;
            const Int32 FLD_POINTINTHISQUESTION = 15;
            const Int32 FLD_REMARKS = 16;
            const Int32 FLD_EXTRA1 = 17;
            const Int32 FLD_EXTRA2 = 18;

            HREmployeeEvaluationResultEntity hREmployeeEvaluationResultEntity = new HREmployeeEvaluationResultEntity();

            hREmployeeEvaluationResultEntity.EmployeeEvaluationResultID = reader.GetInt64(FLD_EMPLOYEEEVALUATIONRESULTID);
            hREmployeeEvaluationResultEntity.EvaluationCriteriaCategoryID = reader.GetInt64(FLD_EVALUATIONCRITERIACATEGORYID);
            if (reader.IsDBNull(FLD_QUESTION)) { hREmployeeEvaluationResultEntity.Question = String.Empty; } else { hREmployeeEvaluationResultEntity.Question = reader.GetString(FLD_QUESTION); }
            if (reader.IsDBNull(FLD_DESCRIPTION)) { hREmployeeEvaluationResultEntity.Description = String.Empty; } else { hREmployeeEvaluationResultEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            if (reader.IsDBNull(FLD_EMPLOYEEEVALUATIONID)) { hREmployeeEvaluationResultEntity.EmployeeEvaluationID = null; } else { hREmployeeEvaluationResultEntity.EmployeeEvaluationID = reader.GetInt64(FLD_EMPLOYEEEVALUATIONID); }
            hREmployeeEvaluationResultEntity.EmployeeEvaluationCriteriaID = reader.GetInt64(FLD_EMPLOYEEEVALUATIONCRITERIAID);
            if (reader.IsDBNull(FLD_ANSWERGIVENBYEMPLOYEEDEPARTMENTNAME)) { hREmployeeEvaluationResultEntity.AnswerGivenByEmployeeDepartmentName = String.Empty; } else { hREmployeeEvaluationResultEntity.AnswerGivenByEmployeeDepartmentName = reader.GetString(FLD_ANSWERGIVENBYEMPLOYEEDEPARTMENTNAME); }
            if (reader.IsDBNull(FLD_EMPLOYEEFULLNAME)) { hREmployeeEvaluationResultEntity.EmployeeFullName = String.Empty; } else { hREmployeeEvaluationResultEntity.EmployeeFullName = reader.GetString(FLD_EMPLOYEEFULLNAME); }
            if (reader.IsDBNull(FLD_EMPLOYEECODE)) { hREmployeeEvaluationResultEntity.EmployeeCode = String.Empty; } else { hREmployeeEvaluationResultEntity.EmployeeCode = reader.GetString(FLD_EMPLOYEECODE); }
            if (reader.IsDBNull(FLD_SUPERVISOREVALUATIONCRITERIAID)) { hREmployeeEvaluationResultEntity.SupervisorEvaluationCriteriaID = null; } else { hREmployeeEvaluationResultEntity.SupervisorEvaluationCriteriaID = reader.GetInt64(FLD_SUPERVISOREVALUATIONCRITERIAID); }
            if (reader.IsDBNull(FLD_SUPERVISORDEPARTMENTNAME)) { hREmployeeEvaluationResultEntity.SupervisorDepartmentName = String.Empty; } else { hREmployeeEvaluationResultEntity.SupervisorDepartmentName = reader.GetString(FLD_SUPERVISORDEPARTMENTNAME); }
            if (reader.IsDBNull(FLD_ANSWERGIVENBYSUPERVISOREMPLOYEEFULLNAME)) { hREmployeeEvaluationResultEntity.AnswerGivenBySupervisorEmployeeFullName = String.Empty; } else { hREmployeeEvaluationResultEntity.AnswerGivenBySupervisorEmployeeFullName = reader.GetString(FLD_ANSWERGIVENBYSUPERVISOREMPLOYEEFULLNAME); }
            if (reader.IsDBNull(FLD_SUPERVISOREMPLOYEECODE)) { hREmployeeEvaluationResultEntity.SupervisorEmployeeCode = String.Empty; } else { hREmployeeEvaluationResultEntity.SupervisorEmployeeCode = reader.GetString(FLD_SUPERVISOREMPLOYEECODE); }
            if (reader.IsDBNull(FLD_EMPLOYEERESULT)) { hREmployeeEvaluationResultEntity.EmployeeResult = null; } else { hREmployeeEvaluationResultEntity.EmployeeResult = reader.GetInt32(FLD_EMPLOYEERESULT); }
            if (reader.IsDBNull(FLD_RESULT)) { hREmployeeEvaluationResultEntity.Result = null; } else { hREmployeeEvaluationResultEntity.Result = reader.GetInt32(FLD_RESULT); }
            if (reader.IsDBNull(FLD_POINTINTHISQUESTION)) { hREmployeeEvaluationResultEntity.PointInThisQuestion = null; } else { hREmployeeEvaluationResultEntity.PointInThisQuestion = reader.GetInt32(FLD_POINTINTHISQUESTION); }
            if (reader.IsDBNull(FLD_REMARKS)) { hREmployeeEvaluationResultEntity.Remarks = String.Empty; } else { hREmployeeEvaluationResultEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_EXTRA1)) { hREmployeeEvaluationResultEntity.Extra1 = String.Empty; } else { hREmployeeEvaluationResultEntity.Extra1 = reader.GetString(FLD_EXTRA1); }
            if (reader.IsDBNull(FLD_EXTRA2)) { hREmployeeEvaluationResultEntity.Extra2 = String.Empty; } else { hREmployeeEvaluationResultEntity.Extra2 = reader.GetString(FLD_EXTRA2); }

            return hREmployeeEvaluationResultEntity;
        }
    }
}
