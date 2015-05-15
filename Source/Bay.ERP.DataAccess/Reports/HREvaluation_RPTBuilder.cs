// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Sep-2013, 12:39:02




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREvaluation_RPTBuilder : IEntityBuilder<HREvaluation_RPTEntity>
    {
        IList<HREvaluation_RPTEntity> IEntityBuilder<HREvaluation_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<HREvaluation_RPTEntity> HREvaluation_RPTEntityList = new List<HREvaluation_RPTEntity>();

            while (reader.Read())
            {
                HREvaluation_RPTEntityList.Add(((IEntityBuilder<HREvaluation_RPTEntity>)this).BuildEntity(reader));
            }

            return (HREvaluation_RPTEntityList.Count > 0) ? HREvaluation_RPTEntityList : null;
        }

        HREvaluation_RPTEntity IEntityBuilder<HREvaluation_RPTEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_EMPLOYEESUBMITDATE = 12;
            const Int32 FLD_SUPERVISORSUBMITDATE = 13;
            const Int32 FLD_CREATEDATE = 14;
            const Int32 FLD_EVALUATEDBYID = 15;
            const Int32 FLD_REMARKS = 16;
            const Int32 FLD_EXTRA = 17;
            const Int32 FLD_SUPERVISOREMPLOYEELEVEL = 18;
            const Int32 FLD_EVALUATIONCRITERIACATEGORYID = 19;
            const Int32 FLD_QUESTION = 20;
            const Int32 FLD_DESCRIPTION = 21;
            const Int32 FLD_EMPLOYEEEVALUATIONCRITERIAID = 22;
            const Int32 FLD_ANSWERGIVENBYEMPLOYEEDEPARTMENTNAME = 23;
            const Int32 FLD_SUPERVISOREVALUATIONCRITERIAID = 24;
            const Int32 FLD_SUPERVISORDEPARTMENTNAME = 25;
            const Int32 FLD_ANSWERGIVENBYSUPERVISOREMPLOYEEFULLNAME = 26;
            const Int32 FLD_EMPLOYEERESULT = 27;
            const Int32 FLD_RESULT = 28;
            const Int32 FLD_POINTINTHISQUESTION = 29;
            const Int32 FLD_HREMPLOYEEEVALUATIONRESULTREMARKS = 30;
            const Int32 FLD_EXTRA1 = 31;
            const Int32 FLD_EXTRA2 = 32;

            HREvaluation_RPTEntity hREvaluation_RPTEntity = new HREvaluation_RPTEntity();

            hREvaluation_RPTEntity.EmployeeEvaluationID = reader.GetInt64(FLD_EMPLOYEEEVALUATIONID);
            hREvaluation_RPTEntity.SessionID = reader.GetInt64(FLD_SESSIONID);
            hREvaluation_RPTEntity.EvaluationName = reader.GetString(FLD_EVALUATIONNAME);
            if (reader.IsDBNull(FLD_EMPLOYEEID)) { hREvaluation_RPTEntity.EmployeeID = null; } else { hREvaluation_RPTEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID); }
            if (reader.IsDBNull(FLD_EMPLOYEEFULLNAME)) { hREvaluation_RPTEntity.EmployeeFullName = String.Empty; } else { hREvaluation_RPTEntity.EmployeeFullName = reader.GetString(FLD_EMPLOYEEFULLNAME); }
            if (reader.IsDBNull(FLD_EMPLOYEECODE)) { hREvaluation_RPTEntity.EmployeeCode = String.Empty; } else { hREvaluation_RPTEntity.EmployeeCode = reader.GetString(FLD_EMPLOYEECODE); }
            if (reader.IsDBNull(FLD_EMPLOYEEDEPARTMENTNAME)) { hREvaluation_RPTEntity.EmployeeDepartmentName = String.Empty; } else { hREvaluation_RPTEntity.EmployeeDepartmentName = reader.GetString(FLD_EMPLOYEEDEPARTMENTNAME); }
            if (reader.IsDBNull(FLD_EMPLOYEELEVEL)) { hREvaluation_RPTEntity.EmployeeLevel = String.Empty; } else { hREvaluation_RPTEntity.EmployeeLevel = reader.GetString(FLD_EMPLOYEELEVEL); }
            if (reader.IsDBNull(FLD_SUPERVISOREMPLOYEEID)) { hREvaluation_RPTEntity.SupervisorEmployeeID = null; } else { hREvaluation_RPTEntity.SupervisorEmployeeID = reader.GetInt64(FLD_SUPERVISOREMPLOYEEID); }
            if (reader.IsDBNull(FLD_SUPERVISORFULLNAME)) { hREvaluation_RPTEntity.SupervisorFullName = String.Empty; } else { hREvaluation_RPTEntity.SupervisorFullName = reader.GetString(FLD_SUPERVISORFULLNAME); }
            if (reader.IsDBNull(FLD_SUPERVISOREMPLOYEECODE)) { hREvaluation_RPTEntity.SupervisorEmployeeCode = String.Empty; } else { hREvaluation_RPTEntity.SupervisorEmployeeCode = reader.GetString(FLD_SUPERVISOREMPLOYEECODE); }
            if (reader.IsDBNull(FLD_SUPERVISOREMPLOYEEDEPARTMENTNAME)) { hREvaluation_RPTEntity.SupervisorEmployeeDepartmentName = String.Empty; } else { hREvaluation_RPTEntity.SupervisorEmployeeDepartmentName = reader.GetString(FLD_SUPERVISOREMPLOYEEDEPARTMENTNAME); }
            if (reader.IsDBNull(FLD_EMPLOYEESUBMITDATE)) { hREvaluation_RPTEntity.EmployeeSubmitDate = null; } else { hREvaluation_RPTEntity.EmployeeSubmitDate = reader.GetDateTime(FLD_EMPLOYEESUBMITDATE); }
            if (reader.IsDBNull(FLD_SUPERVISORSUBMITDATE)) { hREvaluation_RPTEntity.SupervisorSubmitDate = null; } else { hREvaluation_RPTEntity.SupervisorSubmitDate = reader.GetDateTime(FLD_SUPERVISORSUBMITDATE); }
            if (reader.IsDBNull(FLD_CREATEDATE)) { hREvaluation_RPTEntity.CreateDate = null; } else { hREvaluation_RPTEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE); }
            hREvaluation_RPTEntity.EvaluatedByID = reader.GetInt64(FLD_EVALUATEDBYID);
            if (reader.IsDBNull(FLD_REMARKS)) { hREvaluation_RPTEntity.Remarks = String.Empty; } else { hREvaluation_RPTEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_EXTRA)) { hREvaluation_RPTEntity.Extra = String.Empty; } else { hREvaluation_RPTEntity.Extra = reader.GetString(FLD_EXTRA); }
            if (reader.IsDBNull(FLD_SUPERVISOREMPLOYEELEVEL)) { hREvaluation_RPTEntity.SupervisorEmployeeLevel = String.Empty; } else { hREvaluation_RPTEntity.SupervisorEmployeeLevel = reader.GetString(FLD_SUPERVISOREMPLOYEELEVEL); }
            hREvaluation_RPTEntity.EvaluationCriteriaCategoryID = reader.GetInt64(FLD_EVALUATIONCRITERIACATEGORYID);
            if (reader.IsDBNull(FLD_QUESTION)) { hREvaluation_RPTEntity.Question = String.Empty; } else { hREvaluation_RPTEntity.Question = reader.GetString(FLD_QUESTION); }
            if (reader.IsDBNull(FLD_DESCRIPTION)) { hREvaluation_RPTEntity.Description = String.Empty; } else { hREvaluation_RPTEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            hREvaluation_RPTEntity.EmployeeEvaluationCriteriaID = reader.GetInt64(FLD_EMPLOYEEEVALUATIONCRITERIAID);
            hREvaluation_RPTEntity.AnswerGivenByEmployeeDepartmentName = reader.GetString(FLD_ANSWERGIVENBYEMPLOYEEDEPARTMENTNAME);
            if (reader.IsDBNull(FLD_SUPERVISOREVALUATIONCRITERIAID)) { hREvaluation_RPTEntity.SupervisorEvaluationCriteriaID = null; } else { hREvaluation_RPTEntity.SupervisorEvaluationCriteriaID = reader.GetInt64(FLD_SUPERVISOREVALUATIONCRITERIAID); }
            if (reader.IsDBNull(FLD_SUPERVISORDEPARTMENTNAME)) { hREvaluation_RPTEntity.SupervisorDepartmentName = String.Empty; } else { hREvaluation_RPTEntity.SupervisorDepartmentName = reader.GetString(FLD_SUPERVISORDEPARTMENTNAME); }
            if (reader.IsDBNull(FLD_ANSWERGIVENBYSUPERVISOREMPLOYEEFULLNAME)) { hREvaluation_RPTEntity.AnswerGivenBySupervisorEmployeeFullName = String.Empty; } else { hREvaluation_RPTEntity.AnswerGivenBySupervisorEmployeeFullName = reader.GetString(FLD_ANSWERGIVENBYSUPERVISOREMPLOYEEFULLNAME); }
            if (reader.IsDBNull(FLD_EMPLOYEERESULT)) { hREvaluation_RPTEntity.EmployeeResult = null; } else { hREvaluation_RPTEntity.EmployeeResult = reader.GetInt32(FLD_EMPLOYEERESULT); }
            if (reader.IsDBNull(FLD_RESULT)) { hREvaluation_RPTEntity.Result = null; } else { hREvaluation_RPTEntity.Result = reader.GetInt32(FLD_RESULT); }
            if (reader.IsDBNull(FLD_POINTINTHISQUESTION)) { hREvaluation_RPTEntity.PointInThisQuestion = null; } else { hREvaluation_RPTEntity.PointInThisQuestion = reader.GetInt32(FLD_POINTINTHISQUESTION); }
            if (reader.IsDBNull(FLD_HREMPLOYEEEVALUATIONRESULTREMARKS)) { hREvaluation_RPTEntity.HREmployeeEvaluationResultRemarks = String.Empty; } else { hREvaluation_RPTEntity.HREmployeeEvaluationResultRemarks = reader.GetString(FLD_HREMPLOYEEEVALUATIONRESULTREMARKS); }
            if (reader.IsDBNull(FLD_EXTRA1)) { hREvaluation_RPTEntity.Extra1 = String.Empty; } else { hREvaluation_RPTEntity.Extra1 = reader.GetString(FLD_EXTRA1); }
            if (reader.IsDBNull(FLD_EXTRA2)) { hREvaluation_RPTEntity.Extra2 = String.Empty; } else { hREvaluation_RPTEntity.Extra2 = reader.GetString(FLD_EXTRA2); }

            return hREvaluation_RPTEntity;
        }
    }
}
