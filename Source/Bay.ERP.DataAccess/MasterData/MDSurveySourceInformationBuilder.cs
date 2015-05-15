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
    internal sealed class MDSurveySourceInformationBuilder : IEntityBuilder<MDSurveySourceInformationEntity>
    {
        IList<MDSurveySourceInformationEntity> IEntityBuilder<MDSurveySourceInformationEntity>.BuildEntities(IDataReader reader)
        {
            List<MDSurveySourceInformationEntity> MDSurveySourceInformationEntityList = new List<MDSurveySourceInformationEntity>();

            while (reader.Read())
            {
                MDSurveySourceInformationEntityList.Add(((IEntityBuilder<MDSurveySourceInformationEntity>)this).BuildEntity(reader));
            }

            return (MDSurveySourceInformationEntityList.Count > 0) ? MDSurveySourceInformationEntityList : null;
        }

        MDSurveySourceInformationEntity IEntityBuilder<MDSurveySourceInformationEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SURVEYSOURCEINFORMATIONID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDSurveySourceInformationEntity mDSurveySourceInformationEntity = new MDSurveySourceInformationEntity();

            mDSurveySourceInformationEntity.SurveySourceInformationID = reader.GetInt64(FLD_SURVEYSOURCEINFORMATIONID);
            mDSurveySourceInformationEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDSurveySourceInformationEntity.Description = String.Empty; } else { mDSurveySourceInformationEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDSurveySourceInformationEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDSurveySourceInformationEntity;
        }
    }
}
