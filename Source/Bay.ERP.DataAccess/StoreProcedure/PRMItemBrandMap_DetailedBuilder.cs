// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Apr-2012, 03:52:59




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMItemBrandMap_DetailedBuilder : IEntityBuilder<PRMItemBrandMap_DetailedEntity>
    {
        IList<PRMItemBrandMap_DetailedEntity> IEntityBuilder<PRMItemBrandMap_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMItemBrandMap_DetailedEntity> PRMItemBrandMap_DetailedEntityList = new List<PRMItemBrandMap_DetailedEntity>();

            while (reader.Read())
            {
                PRMItemBrandMap_DetailedEntityList.Add(((IEntityBuilder<PRMItemBrandMap_DetailedEntity>)this).BuildEntity(reader));
            }

            return (PRMItemBrandMap_DetailedEntityList.Count > 0) ? PRMItemBrandMap_DetailedEntityList : null;
        }

        PRMItemBrandMap_DetailedEntity IEntityBuilder<PRMItemBrandMap_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ITEMBRANDMAPID = 0;
            const Int32 FLD_ITEMID = 1;
            const Int32 FLD_BRANDID = 2;
            const Int32 FLD_ITEMNAME = 3;
            const Int32 FLD_BRANDNAME = 4;
            const Int32 FLD_ROWNUMBER = 5;

            PRMItemBrandMap_DetailedEntity pRMItemBrandMap_DetailedEntity = new PRMItemBrandMap_DetailedEntity();

            pRMItemBrandMap_DetailedEntity.ItemBrandMapID = reader.GetInt64(FLD_ITEMBRANDMAPID);
            pRMItemBrandMap_DetailedEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            pRMItemBrandMap_DetailedEntity.BrandID = reader.GetInt64(FLD_BRANDID);
            if (reader.IsDBNull(FLD_ITEMNAME)) { pRMItemBrandMap_DetailedEntity.ItemName = String.Empty; } else { pRMItemBrandMap_DetailedEntity.ItemName = reader.GetString(FLD_ITEMNAME); }
            if (reader.IsDBNull(FLD_BRANDNAME)) { pRMItemBrandMap_DetailedEntity.BrandName = String.Empty; } else { pRMItemBrandMap_DetailedEntity.BrandName = reader.GetString(FLD_BRANDNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { pRMItemBrandMap_DetailedEntity.RowNumber = null; } else { pRMItemBrandMap_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return pRMItemBrandMap_DetailedEntity;
        }
    }
}
