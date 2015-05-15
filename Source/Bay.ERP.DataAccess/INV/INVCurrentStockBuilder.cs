// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Dec-2012, 12:52:14




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class INVCurrentStockBuilder : IEntityBuilder<INVCurrentStockEntity>
    {
        IList<INVCurrentStockEntity> IEntityBuilder<INVCurrentStockEntity>.BuildEntities(IDataReader reader)
        {
            List<INVCurrentStockEntity> INVCurrentStockEntityList = new List<INVCurrentStockEntity>();

            while (reader.Read())
            {
                INVCurrentStockEntityList.Add(((IEntityBuilder<INVCurrentStockEntity>)this).BuildEntity(reader));
            }

            return (INVCurrentStockEntityList.Count > 0) ? INVCurrentStockEntityList : null;
        }

        INVCurrentStockEntity IEntityBuilder<INVCurrentStockEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CURRENTSTOCKID = 0;
            const Int32 FLD_ITEMID = 1;
            const Int32 FLD_BRANDID = 2;
            const Int32 FLD_REGIONID = 3;
            const Int32 FLD_COUNTRYID = 4;
            const Int32 FLD_UNITCURRENTSTOCK = 5;

            INVCurrentStockEntity iNVCurrentStockEntity = new INVCurrentStockEntity();

            iNVCurrentStockEntity.CurrentStockID = reader.GetInt64(FLD_CURRENTSTOCKID);
            iNVCurrentStockEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            iNVCurrentStockEntity.BrandID = reader.GetInt64(FLD_BRANDID);
            iNVCurrentStockEntity.RegionID = reader.GetInt64(FLD_REGIONID);
            iNVCurrentStockEntity.CountryID = reader.GetInt64(FLD_COUNTRYID);
            iNVCurrentStockEntity.UnitCurrentStock = reader.GetInt64(FLD_UNITCURRENTSTOCK);

            return iNVCurrentStockEntity;
        }
    }
}
