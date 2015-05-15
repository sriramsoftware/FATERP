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
    internal sealed class MDSurveyBuildingStatusBuilder : IEntityBuilder<MDSurveyBuildingStatusEntity>
    {
        IList<MDSurveyBuildingStatusEntity> IEntityBuilder<MDSurveyBuildingStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<MDSurveyBuildingStatusEntity> MDSurveyBuildingStatusEntityList = new List<MDSurveyBuildingStatusEntity>();

            while (reader.Read())
            {
                MDSurveyBuildingStatusEntityList.Add(((IEntityBuilder<MDSurveyBuildingStatusEntity>)this).BuildEntity(reader));
            }

            return (MDSurveyBuildingStatusEntityList.Count > 0) ? MDSurveyBuildingStatusEntityList : null;
        }

        MDSurveyBuildingStatusEntity IEntityBuilder<MDSurveyBuildingStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SURVEYBUILDINGSTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDSurveyBuildingStatusEntity mDSurveyBuildingStatusEntity = new MDSurveyBuildingStatusEntity();

            mDSurveyBuildingStatusEntity.SurveyBuildingStatusID = reader.GetInt64(FLD_SURVEYBUILDINGSTATUSID);
            mDSurveyBuildingStatusEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDSurveyBuildingStatusEntity.Description = String.Empty; } else { mDSurveyBuildingStatusEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDSurveyBuildingStatusEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDSurveyBuildingStatusEntity;
        }
    }
}
