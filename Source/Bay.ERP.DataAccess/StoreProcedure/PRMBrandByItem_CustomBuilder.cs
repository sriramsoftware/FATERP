// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 11-Jul-2012, 02:21:44




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMBrandByItem_CustomBuilder : IEntityBuilder<PRMBrandByItem_CustomEntity>
    {
        IList<PRMBrandByItem_CustomEntity> IEntityBuilder<PRMBrandByItem_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMBrandByItem_CustomEntity> PRMBrandByItem_CustomEntityList = new List<PRMBrandByItem_CustomEntity>();

            while (reader.Read())
            {
                PRMBrandByItem_CustomEntityList.Add(((IEntityBuilder<PRMBrandByItem_CustomEntity>)this).BuildEntity(reader));
            }

            return (PRMBrandByItem_CustomEntityList.Count > 0) ? PRMBrandByItem_CustomEntityList : null;
        }

        PRMBrandByItem_CustomEntity IEntityBuilder<PRMBrandByItem_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ITEMBRANDMAPID = 0;
            const Int32 FLD_BRANDID = 1;
            const Int32 FLD_ITEMID = 2;
            const Int32 FLD_BRANDNAME = 3;

            PRMBrandByItem_CustomEntity pRMBrandByItem_CustomEntity = new PRMBrandByItem_CustomEntity();

            pRMBrandByItem_CustomEntity.ItemBrandMapID = reader.GetInt64(FLD_ITEMBRANDMAPID);
            pRMBrandByItem_CustomEntity.BrandID = reader.GetInt64(FLD_BRANDID);
            pRMBrandByItem_CustomEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            if (reader.IsDBNull(FLD_BRANDNAME)) { pRMBrandByItem_CustomEntity.BrandName = String.Empty; } else { pRMBrandByItem_CustomEntity.BrandName = reader.GetString(FLD_BRANDNAME); }

            return pRMBrandByItem_CustomEntity;
        }
    }
}
