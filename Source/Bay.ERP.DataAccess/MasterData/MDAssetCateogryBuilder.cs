// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Oct-2013, 01:39:59




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDAssetCateogryBuilder : IEntityBuilder<MDAssetCateogryEntity>
    {
        IList<MDAssetCateogryEntity> IEntityBuilder<MDAssetCateogryEntity>.BuildEntities(IDataReader reader)
        {
            List<MDAssetCateogryEntity> MDAssetCateogryEntityList = new List<MDAssetCateogryEntity>();

            while (reader.Read())
            {
                MDAssetCateogryEntityList.Add(((IEntityBuilder<MDAssetCateogryEntity>)this).BuildEntity(reader));
            }

            return (MDAssetCateogryEntityList.Count > 0) ? MDAssetCateogryEntityList : null;
        }

        MDAssetCateogryEntity IEntityBuilder<MDAssetCateogryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ASSETCATEOGRYID = 0;
            const Int32 FLD_PARENTASSETCATEOGRYID = 1;
            const Int32 FLD_CATEGORYNAME = 2;
            const Int32 FLD_DESCRIPTION = 3;
            const Int32 FLD_ISREMOVED = 4;

            MDAssetCateogryEntity mDAssetCateogryEntity = new MDAssetCateogryEntity();

            mDAssetCateogryEntity.AssetCateogryID = reader.GetInt64(FLD_ASSETCATEOGRYID);
            if (reader.IsDBNull(FLD_PARENTASSETCATEOGRYID)) { mDAssetCateogryEntity.ParentAssetCateogryID = null; } else { mDAssetCateogryEntity.ParentAssetCateogryID = reader.GetInt64(FLD_PARENTASSETCATEOGRYID); }
            mDAssetCateogryEntity.CategoryName = reader.GetString(FLD_CATEGORYNAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDAssetCateogryEntity.Description = String.Empty; } else { mDAssetCateogryEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDAssetCateogryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDAssetCateogryEntity;
        }
    }
}
