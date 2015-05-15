// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Sep-2013, 01:19:45




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDEvaluationCriteriaBuilder : IEntityBuilder<MDEvaluationCriteriaEntity>
    {
        IList<MDEvaluationCriteriaEntity> IEntityBuilder<MDEvaluationCriteriaEntity>.BuildEntities(IDataReader reader)
        {
            List<MDEvaluationCriteriaEntity> MDEvaluationCriteriaEntityList = new List<MDEvaluationCriteriaEntity>();

            while (reader.Read())
            {
                MDEvaluationCriteriaEntityList.Add(((IEntityBuilder<MDEvaluationCriteriaEntity>)this).BuildEntity(reader));
            }

            return (MDEvaluationCriteriaEntityList.Count > 0) ? MDEvaluationCriteriaEntityList : null;
        }

        MDEvaluationCriteriaEntity IEntityBuilder<MDEvaluationCriteriaEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EVALUATIONCRITERIAID = 0;
            const Int32 FLD_EVALUATIONCRITERIACATEGORYID = 1;
            const Int32 FLD_SUPERVISORTYPEID = 2;
            const Int32 FLD_EVALUATIONSESSIONCATEGORYID = 3;
            const Int32 FLD_QUESTION = 4;
            const Int32 FLD_DESCRIPTION = 5;
            const Int32 FLD_CORRECTANSWERIFANY = 6;
            const Int32 FLD_CORRECTANSWERMARKORPOINT = 7;
            const Int32 FLD_IMAGEURL = 8;
            const Int32 FLD_QUESTIONORDERINDISPLAY = 9;
            const Int32 FLD_SUPERVISORWILLANSWER = 10;
            const Int32 FLD_ISREMOVED = 11;
            const Int32 FLD_CREATEDBYEMPLOYEEID = 12;
            const Int32 FLD_CREATEDATE = 13;

            MDEvaluationCriteriaEntity mDEvaluationCriteriaEntity = new MDEvaluationCriteriaEntity();

            mDEvaluationCriteriaEntity.EvaluationCriteriaID = reader.GetInt64(FLD_EVALUATIONCRITERIAID);
            mDEvaluationCriteriaEntity.EvaluationCriteriaCategoryID = reader.GetInt64(FLD_EVALUATIONCRITERIACATEGORYID);
            mDEvaluationCriteriaEntity.SupervisorTypeID = reader.GetInt64(FLD_SUPERVISORTYPEID);
            mDEvaluationCriteriaEntity.EvaluationSessionCategoryID = reader.GetInt64(FLD_EVALUATIONSESSIONCATEGORYID);
            mDEvaluationCriteriaEntity.Question = reader.GetString(FLD_QUESTION);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDEvaluationCriteriaEntity.Description = String.Empty; } else { mDEvaluationCriteriaEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            if (reader.IsDBNull(FLD_CORRECTANSWERIFANY)) { mDEvaluationCriteriaEntity.CorrectAnswerIfAny = String.Empty; } else { mDEvaluationCriteriaEntity.CorrectAnswerIfAny = reader.GetString(FLD_CORRECTANSWERIFANY); }
            if (reader.IsDBNull(FLD_CORRECTANSWERMARKORPOINT)) { mDEvaluationCriteriaEntity.CorrectAnswerMarkOrPoint = null; } else { mDEvaluationCriteriaEntity.CorrectAnswerMarkOrPoint = reader.GetInt32(FLD_CORRECTANSWERMARKORPOINT); }
            if (reader.IsDBNull(FLD_IMAGEURL)) { mDEvaluationCriteriaEntity.ImageUrl = String.Empty; } else { mDEvaluationCriteriaEntity.ImageUrl = reader.GetString(FLD_IMAGEURL); }
            if (reader.IsDBNull(FLD_QUESTIONORDERINDISPLAY)) { mDEvaluationCriteriaEntity.QuestionOrderInDisplay = null; } else { mDEvaluationCriteriaEntity.QuestionOrderInDisplay = reader.GetInt32(FLD_QUESTIONORDERINDISPLAY); }
            mDEvaluationCriteriaEntity.SupervisorWillAnswer = reader.GetBoolean(FLD_SUPERVISORWILLANSWER);
            mDEvaluationCriteriaEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            mDEvaluationCriteriaEntity.CreatedByEmployeeID = reader.GetInt64(FLD_CREATEDBYEMPLOYEEID);
            mDEvaluationCriteriaEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);

            return mDEvaluationCriteriaEntity;
        }
    }
}
