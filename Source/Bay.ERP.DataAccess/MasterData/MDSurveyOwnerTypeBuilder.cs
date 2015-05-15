// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Oct-2013, 12:51:37




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDSurveyOwnerTypeBuilder : IEntityBuilder<MDSurveyOwnerTypeEntity>
    {
        IList<MDSurveyOwnerTypeEntity> IEntityBuilder<MDSurveyOwnerTypeEntity>.BuildEntities(IDataReader reader)
        {
            List<MDSurveyOwnerTypeEntity> MDSurveyOwnerTypeEntityList = new List<MDSurveyOwnerTypeEntity>();

            while (reader.Read())
            {
                MDSurveyOwnerTypeEntityList.Add(((IEntityBuilder<MDSurveyOwnerTypeEntity>)this).BuildEntity(reader));
            }

            return (MDSurveyOwnerTypeEntityList.Count > 0) ? MDSurveyOwnerTypeEntityList : null;
        }

        MDSurveyOwnerTypeEntity IEntityBuilder<MDSurveyOwnerTypeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SURVEYOWNERTYPEID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDSurveyOwnerTypeEntity mDSurveyOwnerTypeEntity = new MDSurveyOwnerTypeEntity();

            mDSurveyOwnerTypeEntity.SurveyOwnerTypeID = reader.GetInt64(FLD_SURVEYOWNERTYPEID);
            mDSurveyOwnerTypeEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDSurveyOwnerTypeEntity.Description = String.Empty; } else { mDSurveyOwnerTypeEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDSurveyOwnerTypeEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDSurveyOwnerTypeEntity;
        }
    }
}
