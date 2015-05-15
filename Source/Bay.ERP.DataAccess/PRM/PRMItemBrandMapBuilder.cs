// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Apr-2012, 04:09:50




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMItemBrandMapBuilder : IEntityBuilder<PRMItemBrandMapEntity>
    {
        IList<PRMItemBrandMapEntity> IEntityBuilder<PRMItemBrandMapEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMItemBrandMapEntity> PRMItemBrandMapEntityList = new List<PRMItemBrandMapEntity>();

            while (reader.Read())
            {
                PRMItemBrandMapEntityList.Add(((IEntityBuilder<PRMItemBrandMapEntity>)this).BuildEntity(reader));
            }

            return (PRMItemBrandMapEntityList.Count > 0) ? PRMItemBrandMapEntityList : null;
        }

        PRMItemBrandMapEntity IEntityBuilder<PRMItemBrandMapEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ITEMBRANDMAPID = 0;
            const Int32 FLD_ITEMID = 1;
            const Int32 FLD_BRANDID = 2;

            PRMItemBrandMapEntity pRMItemBrandMapEntity = new PRMItemBrandMapEntity();

            pRMItemBrandMapEntity.ItemBrandMapID = reader.GetInt64(FLD_ITEMBRANDMAPID);
            pRMItemBrandMapEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            pRMItemBrandMapEntity.BrandID = reader.GetInt64(FLD_BRANDID);

            return pRMItemBrandMapEntity;
        }
    }
}
