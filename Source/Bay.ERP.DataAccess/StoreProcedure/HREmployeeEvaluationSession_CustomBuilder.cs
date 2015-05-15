// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-Sep-2013, 10:27:18




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREmployeeEvaluationSession_CustomBuilder : IEntityBuilder<HREmployeeEvaluationSession_CustomEntity>
    {
        IList<HREmployeeEvaluationSession_CustomEntity> IEntityBuilder<HREmployeeEvaluationSession_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeEvaluationSession_CustomEntity> HREmployeeEvaluationSession_CustomEntityList = new List<HREmployeeEvaluationSession_CustomEntity>();

            while (reader.Read())
            {
                HREmployeeEvaluationSession_CustomEntityList.Add(((IEntityBuilder<HREmployeeEvaluationSession_CustomEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeEvaluationSession_CustomEntityList.Count > 0) ? HREmployeeEvaluationSession_CustomEntityList : null;
        }

        HREmployeeEvaluationSession_CustomEntity IEntityBuilder<HREmployeeEvaluationSession_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SESSIONID = 0;
            const Int32 FLD_SESSIONNAME = 1;
            const Int32 FLD_STARTDATE = 2;
            const Int32 FLD_ENDDATE = 3;
            const Int32 FLD_DEADLINEDATE = 4;
            const Int32 FLD_EVALUATIONSESSIONCATEGORYNAME = 5;
            const Int32 FLD_QUESTION = 6;
            const Int32 FLD_DESCRIPTION = 7;
            const Int32 FLD_EVALUATIONCRITERIAID = 8;
            const Int32 FLD_CORRECTANSWERIFANY = 9;
            const Int32 FLD_CORRECTANSWERMARKORPOINT = 10;
            const Int32 FLD_IMAGEURL = 11;
            const Int32 FLD_QUESTIONORDERINDISPLAY = 12;
            const Int32 FLD_SUPERVISORWILLANSWER = 13;
            const Int32 FLD_EVALUATIONNAME = 14;
            const Int32 FLD_EMPLOYEEID = 15;
            const Int32 FLD_SUPERVISOREMPLOYEEID = 16;
            const Int32 FLD_EMPLOYEESUBMITDATE = 17;
            const Int32 FLD_SUPERVISORSUBMITDATE = 18;
            const Int32 FLD_EVALUATEDBYID = 19;
            const Int32 FLD_EVALUATIONSESSIONSTATUSID = 20;
            const Int32 FLD_EMPLOYEERESULT = 21;
            const Int32 FLD_RESULT = 22;
            const Int32 FLD_POINTINTHISQUESTION = 23;
            const Int32 FLD_REMARKS = 24;
            const Int32 FLD_SUPERVISORREMARKS = 25;
            const Int32 FLD_EVALUATIONCRITERIACATEGORYNAME = 26;
            const Int32 FLD_SESSIONCATEGORYID = 27;
            const Int32 FLD_EVALUATIONCRITERIACATEGORYID = 28;
            const Int32 FLD_EMPLOYEEEVALUATIONRESULTID = 29;
            const Int32 FLD_SUPERVISORFULLNAME = 30;
            const Int32 FLD_SUPERVISOREMPLOYEECODE = 31;
            const Int32 FLD_SUPERVISOREMPLOYEEDEPARTMENTNAME = 32;
            const Int32 FLD_SUPERVISOREMPLOYEELEVEL = 33;
            const Int32 FLD_EMPLOYEEFULLNAME = 34;
            const Int32 FLD_EMPLOYEEEVALUATIONID = 35;
            const Int32 FLD_EMPLOYEECODE = 36;
            const Int32 FLD_EMPLOYEEDEPARTMENTNAME = 37;
            const Int32 FLD_EMPLOYEELEVEL = 38;

            HREmployeeEvaluationSession_CustomEntity hREmployeeEvaluationSession_CustomEntity = new HREmployeeEvaluationSession_CustomEntity();

            hREmployeeEvaluationSession_CustomEntity.SessionID = reader.GetInt64(FLD_SESSIONID);
            hREmployeeEvaluationSession_CustomEntity.SessionName = reader.GetString(FLD_SESSIONNAME);
            hREmployeeEvaluationSession_CustomEntity.StartDate = reader.GetDateTime(FLD_STARTDATE);
            hREmployeeEvaluationSession_CustomEntity.EndDate = reader.GetDateTime(FLD_ENDDATE);
            hREmployeeEvaluationSession_CustomEntity.DeadlineDate = reader.GetDateTime(FLD_DEADLINEDATE);
            hREmployeeEvaluationSession_CustomEntity.EvaluationSessionCategoryName = reader.GetString(FLD_EVALUATIONSESSIONCATEGORYNAME);
            hREmployeeEvaluationSession_CustomEntity.Question = reader.GetString(FLD_QUESTION);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { hREmployeeEvaluationSession_CustomEntity.Description = String.Empty; } else { hREmployeeEvaluationSession_CustomEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            hREmployeeEvaluationSession_CustomEntity.EvaluationCriteriaID = reader.GetInt64(FLD_EVALUATIONCRITERIAID);
            if (reader.IsDBNull(FLD_CORRECTANSWERIFANY)) { hREmployeeEvaluationSession_CustomEntity.CorrectAnswerIfAny = String.Empty; } else { hREmployeeEvaluationSession_CustomEntity.CorrectAnswerIfAny = reader.GetString(FLD_CORRECTANSWERIFANY); }
            if (reader.IsDBNull(FLD_CORRECTANSWERMARKORPOINT)) { hREmployeeEvaluationSession_CustomEntity.CorrectAnswerMarkOrPoint = null; } else { hREmployeeEvaluationSession_CustomEntity.CorrectAnswerMarkOrPoint = reader.GetInt32(FLD_CORRECTANSWERMARKORPOINT); }
            if (reader.IsDBNull(FLD_IMAGEURL)) { hREmployeeEvaluationSession_CustomEntity.ImageUrl = String.Empty; } else { hREmployeeEvaluationSession_CustomEntity.ImageUrl = reader.GetString(FLD_IMAGEURL); }
            if (reader.IsDBNull(FLD_QUESTIONORDERINDISPLAY)) { hREmployeeEvaluationSession_CustomEntity.QuestionOrderInDisplay = null; } else { hREmployeeEvaluationSession_CustomEntity.QuestionOrderInDisplay = reader.GetInt32(FLD_QUESTIONORDERINDISPLAY); }
            hREmployeeEvaluationSession_CustomEntity.SupervisorWillAnswer = reader.GetBoolean(FLD_SUPERVISORWILLANSWER);
            hREmployeeEvaluationSession_CustomEntity.EvaluationName = reader.GetString(FLD_EVALUATIONNAME);
            if (reader.IsDBNull(FLD_EMPLOYEEID)) { hREmployeeEvaluationSession_CustomEntity.EmployeeID = null; } else { hREmployeeEvaluationSession_CustomEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID); }
            if (reader.IsDBNull(FLD_SUPERVISOREMPLOYEEID)) { hREmployeeEvaluationSession_CustomEntity.SupervisorEmployeeID = null; } else { hREmployeeEvaluationSession_CustomEntity.SupervisorEmployeeID = reader.GetInt64(FLD_SUPERVISOREMPLOYEEID); }
            if (reader.IsDBNull(FLD_EMPLOYEESUBMITDATE)) { hREmployeeEvaluationSession_CustomEntity.EmployeeSubmitDate = null; } else { hREmployeeEvaluationSession_CustomEntity.EmployeeSubmitDate = reader.GetDateTime(FLD_EMPLOYEESUBMITDATE); }
            if (reader.IsDBNull(FLD_SUPERVISORSUBMITDATE)) { hREmployeeEvaluationSession_CustomEntity.SupervisorSubmitDate = null; } else { hREmployeeEvaluationSession_CustomEntity.SupervisorSubmitDate = reader.GetDateTime(FLD_SUPERVISORSUBMITDATE); }
            hREmployeeEvaluationSession_CustomEntity.EvaluatedByID = reader.GetInt64(FLD_EVALUATEDBYID);
            hREmployeeEvaluationSession_CustomEntity.EvaluationSessionStatusID = reader.GetInt64(FLD_EVALUATIONSESSIONSTATUSID);
            if (reader.IsDBNull(FLD_EMPLOYEERESULT)) { hREmployeeEvaluationSession_CustomEntity.EmployeeResult = null; } else { hREmployeeEvaluationSession_CustomEntity.EmployeeResult = reader.GetInt32(FLD_EMPLOYEERESULT); }
            if (reader.IsDBNull(FLD_RESULT)) { hREmployeeEvaluationSession_CustomEntity.Result = null; } else { hREmployeeEvaluationSession_CustomEntity.Result = reader.GetInt32(FLD_RESULT); }
            if (reader.IsDBNull(FLD_POINTINTHISQUESTION)) { hREmployeeEvaluationSession_CustomEntity.PointInThisQuestion = null; } else { hREmployeeEvaluationSession_CustomEntity.PointInThisQuestion = reader.GetInt32(FLD_POINTINTHISQUESTION); }
            if (reader.IsDBNull(FLD_REMARKS)) { hREmployeeEvaluationSession_CustomEntity.Remarks = String.Empty; } else { hREmployeeEvaluationSession_CustomEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_SUPERVISORREMARKS)) { hREmployeeEvaluationSession_CustomEntity.SupervisorRemarks = String.Empty; } else { hREmployeeEvaluationSession_CustomEntity.SupervisorRemarks = reader.GetString(FLD_SUPERVISORREMARKS); }
            hREmployeeEvaluationSession_CustomEntity.EvaluationCriteriaCategoryName = reader.GetString(FLD_EVALUATIONCRITERIACATEGORYNAME);
            hREmployeeEvaluationSession_CustomEntity.SessionCategoryID = reader.GetInt64(FLD_SESSIONCATEGORYID);
            hREmployeeEvaluationSession_CustomEntity.EvaluationCriteriaCategoryID = reader.GetInt64(FLD_EVALUATIONCRITERIACATEGORYID);
            if (reader.IsDBNull(FLD_EMPLOYEEEVALUATIONRESULTID)) { hREmployeeEvaluationSession_CustomEntity.EmployeeEvaluationResultID = null; } else { hREmployeeEvaluationSession_CustomEntity.EmployeeEvaluationResultID = reader.GetInt64(FLD_EMPLOYEEEVALUATIONRESULTID); }
            if (reader.IsDBNull(FLD_SUPERVISORFULLNAME)) { hREmployeeEvaluationSession_CustomEntity.SupervisorFullName = String.Empty; } else { hREmployeeEvaluationSession_CustomEntity.SupervisorFullName = reader.GetString(FLD_SUPERVISORFULLNAME); }
            if (reader.IsDBNull(FLD_SUPERVISOREMPLOYEECODE)) { hREmployeeEvaluationSession_CustomEntity.SupervisorEmployeeCode = String.Empty; } else { hREmployeeEvaluationSession_CustomEntity.SupervisorEmployeeCode = reader.GetString(FLD_SUPERVISOREMPLOYEECODE); }
            if (reader.IsDBNull(FLD_SUPERVISOREMPLOYEEDEPARTMENTNAME)) { hREmployeeEvaluationSession_CustomEntity.SupervisorEmployeeDepartmentName = String.Empty; } else { hREmployeeEvaluationSession_CustomEntity.SupervisorEmployeeDepartmentName = reader.GetString(FLD_SUPERVISOREMPLOYEEDEPARTMENTNAME); }
            if (reader.IsDBNull(FLD_SUPERVISOREMPLOYEELEVEL)) { hREmployeeEvaluationSession_CustomEntity.SupervisorEmployeeLevel = String.Empty; } else { hREmployeeEvaluationSession_CustomEntity.SupervisorEmployeeLevel = reader.GetString(FLD_SUPERVISOREMPLOYEELEVEL); }
            if (reader.IsDBNull(FLD_EMPLOYEEFULLNAME)) { hREmployeeEvaluationSession_CustomEntity.EmployeeFullName = String.Empty; } else { hREmployeeEvaluationSession_CustomEntity.EmployeeFullName = reader.GetString(FLD_EMPLOYEEFULLNAME); }
            hREmployeeEvaluationSession_CustomEntity.EmployeeEvaluationID = reader.GetInt64(FLD_EMPLOYEEEVALUATIONID);
            if (reader.IsDBNull(FLD_EMPLOYEECODE)) { hREmployeeEvaluationSession_CustomEntity.EmployeeCode = String.Empty; } else { hREmployeeEvaluationSession_CustomEntity.EmployeeCode = reader.GetString(FLD_EMPLOYEECODE); }
            if (reader.IsDBNull(FLD_EMPLOYEEDEPARTMENTNAME)) { hREmployeeEvaluationSession_CustomEntity.EmployeeDepartmentName = String.Empty; } else { hREmployeeEvaluationSession_CustomEntity.EmployeeDepartmentName = reader.GetString(FLD_EMPLOYEEDEPARTMENTNAME); }
            if (reader.IsDBNull(FLD_EMPLOYEELEVEL)) { hREmployeeEvaluationSession_CustomEntity.EmployeeLevel = String.Empty; } else { hREmployeeEvaluationSession_CustomEntity.EmployeeLevel = reader.GetString(FLD_EMPLOYEELEVEL); }

            return hREmployeeEvaluationSession_CustomEntity;
        }
    }
}
