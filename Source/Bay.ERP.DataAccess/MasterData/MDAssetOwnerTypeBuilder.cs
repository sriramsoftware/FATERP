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
    internal sealed class MDAssetOwnerTypeBuilder : IEntityBuilder<MDAssetOwnerTypeEntity>
    {
        IList<MDAssetOwnerTypeEntity> IEntityBuilder<MDAssetOwnerTypeEntity>.BuildEntities(IDataReader reader)
        {
            List<MDAssetOwnerTypeEntity> MDAssetOwnerTypeEntityList = new List<MDAssetOwnerTypeEntity>();

            while (reader.Read())
            {
                MDAssetOwnerTypeEntityList.Add(((IEntityBuilder<MDAssetOwnerTypeEntity>)this).BuildEntity(reader));
            }

            return (MDAssetOwnerTypeEntityList.Count > 0) ? MDAssetOwnerTypeEntityList : null;
        }

        MDAssetOwnerTypeEntity IEntityBuilder<MDAssetOwnerTypeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ASSETOWNERTYPEID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDAssetOwnerTypeEntity mDAssetOwnerTypeEntity = new MDAssetOwnerTypeEntity();

            mDAssetOwnerTypeEntity.AssetOwnerTypeID = reader.GetInt64(FLD_ASSETOWNERTYPEID);
            mDAssetOwnerTypeEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDAssetOwnerTypeEntity.Description = String.Empty; } else { mDAssetOwnerTypeEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDAssetOwnerTypeEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDAssetOwnerTypeEntity;
        }
    }
}
