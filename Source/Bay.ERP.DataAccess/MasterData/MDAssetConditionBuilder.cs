// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Oct-2013, 02:28:24




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDAssetConditionBuilder : IEntityBuilder<MDAssetConditionEntity>
    {
        IList<MDAssetConditionEntity> IEntityBuilder<MDAssetConditionEntity>.BuildEntities(IDataReader reader)
        {
            List<MDAssetConditionEntity> MDAssetConditionEntityList = new List<MDAssetConditionEntity>();

            while (reader.Read())
            {
                MDAssetConditionEntityList.Add(((IEntityBuilder<MDAssetConditionEntity>)this).BuildEntity(reader));
            }

            return (MDAssetConditionEntityList.Count > 0) ? MDAssetConditionEntityList : null;
        }

        MDAssetConditionEntity IEntityBuilder<MDAssetConditionEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ASSETCONDITIONID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDAssetConditionEntity mDAssetConditionEntity = new MDAssetConditionEntity();

            mDAssetConditionEntity.AssetConditionID = reader.GetInt64(FLD_ASSETCONDITIONID);
            mDAssetConditionEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDAssetConditionEntity.Description = String.Empty; } else { mDAssetConditionEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDAssetConditionEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDAssetConditionEntity;
        }
    }
}
