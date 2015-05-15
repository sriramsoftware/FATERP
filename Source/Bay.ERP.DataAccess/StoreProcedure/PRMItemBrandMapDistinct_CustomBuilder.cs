// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-May-2012, 03:36:37




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMItemBrandMapDistinct_CustomBuilder : IEntityBuilder<PRMItemBrandMapDistinct_CustomEntity>
    {
        IList<PRMItemBrandMapDistinct_CustomEntity> IEntityBuilder<PRMItemBrandMapDistinct_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMItemBrandMapDistinct_CustomEntity> PRMItemBrandMapDistinct_CustomEntityList = new List<PRMItemBrandMapDistinct_CustomEntity>();

            while (reader.Read())
            {
                PRMItemBrandMapDistinct_CustomEntityList.Add(((IEntityBuilder<PRMItemBrandMapDistinct_CustomEntity>)this).BuildEntity(reader));
            }

            return (PRMItemBrandMapDistinct_CustomEntityList.Count > 0) ? PRMItemBrandMapDistinct_CustomEntityList : null;
        }

        PRMItemBrandMapDistinct_CustomEntity IEntityBuilder<PRMItemBrandMapDistinct_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BRANDID = 0;
            const Int32 FLD_BRANDNAME = 1;
            const Int32 FLD_SUPPLIERID = 2;

            PRMItemBrandMapDistinct_CustomEntity pRMItemBrandMapDistinct_CustomEntity = new PRMItemBrandMapDistinct_CustomEntity();

            pRMItemBrandMapDistinct_CustomEntity.BrandID = reader.GetInt64(FLD_BRANDID);
            if (reader.IsDBNull(FLD_BRANDNAME)) { pRMItemBrandMapDistinct_CustomEntity.BrandName = String.Empty; } else { pRMItemBrandMapDistinct_CustomEntity.BrandName = reader.GetString(FLD_BRANDNAME); }
            if (reader.IsDBNull(FLD_SUPPLIERID)) { pRMItemBrandMapDistinct_CustomEntity.SupplierID = null; } else { pRMItemBrandMapDistinct_CustomEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID); }

            return pRMItemBrandMapDistinct_CustomEntity;
        }
    }
}
