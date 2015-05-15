// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Apr-2012, 04:01:11




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMItemBrandMap_CustomBuilder : IEntityBuilder<PRMItemBrandMap_CustomEntity>
    {
        IList<PRMItemBrandMap_CustomEntity> IEntityBuilder<PRMItemBrandMap_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMItemBrandMap_CustomEntity> PRMItemBrandMap_CustomEntityList = new List<PRMItemBrandMap_CustomEntity>();

            while (reader.Read())
            {
                PRMItemBrandMap_CustomEntityList.Add(((IEntityBuilder<PRMItemBrandMap_CustomEntity>)this).BuildEntity(reader));
            }

            return (PRMItemBrandMap_CustomEntityList.Count > 0) ? PRMItemBrandMap_CustomEntityList : null;
        }

        PRMItemBrandMap_CustomEntity IEntityBuilder<PRMItemBrandMap_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ITEMBRANDMAPID = 0;
            const Int32 FLD_ITEMID = 1;
            const Int32 FLD_BRANDID = 2;
            const Int32 FLD_ITEMNAME = 3;
            const Int32 FLD_BRANDNAME = 4;
            const Int32 FLD_ROWNUMBER = 5;

            PRMItemBrandMap_CustomEntity pRMItemBrandMap_CustomEntity = new PRMItemBrandMap_CustomEntity();

            pRMItemBrandMap_CustomEntity.ItemBrandMapID = reader.GetInt64(FLD_ITEMBRANDMAPID);
            pRMItemBrandMap_CustomEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            pRMItemBrandMap_CustomEntity.BrandID = reader.GetInt64(FLD_BRANDID);
            if (reader.IsDBNull(FLD_ITEMNAME)) { pRMItemBrandMap_CustomEntity.ItemName = String.Empty; } else { pRMItemBrandMap_CustomEntity.ItemName = reader.GetString(FLD_ITEMNAME); }
            if (reader.IsDBNull(FLD_BRANDNAME)) { pRMItemBrandMap_CustomEntity.BrandName = String.Empty; } else { pRMItemBrandMap_CustomEntity.BrandName = reader.GetString(FLD_BRANDNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { pRMItemBrandMap_CustomEntity.RowNumber = null; } else { pRMItemBrandMap_CustomEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return pRMItemBrandMap_CustomEntity;
        }
    }
}
