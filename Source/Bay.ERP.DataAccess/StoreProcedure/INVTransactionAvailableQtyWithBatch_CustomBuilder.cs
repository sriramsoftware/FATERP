// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Jan-2013, 12:40:48




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class INVTransactionAvailableQtyWithBatch_CustomBuilder : IEntityBuilder<INVTransactionAvailableQtyWithBatch_CustomEntity>
    {
        IList<INVTransactionAvailableQtyWithBatch_CustomEntity> IEntityBuilder<INVTransactionAvailableQtyWithBatch_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<INVTransactionAvailableQtyWithBatch_CustomEntity> INVTransactionAvailableQtyWithBatch_CustomEntityList = new List<INVTransactionAvailableQtyWithBatch_CustomEntity>();

            while (reader.Read())
            {
                INVTransactionAvailableQtyWithBatch_CustomEntityList.Add(((IEntityBuilder<INVTransactionAvailableQtyWithBatch_CustomEntity>)this).BuildEntity(reader));
            }

            return (INVTransactionAvailableQtyWithBatch_CustomEntityList.Count > 0) ? INVTransactionAvailableQtyWithBatch_CustomEntityList : null;
        }

        INVTransactionAvailableQtyWithBatch_CustomEntity IEntityBuilder<INVTransactionAvailableQtyWithBatch_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ITEMID = 0;
            const Int32 FLD_BRANDID = 1;
            const Int32 FLD_REGIONID = 2;
            const Int32 FLD_COUNTRYID = 3;
            const Int32 FLD_BATCHNUMBER = 4;
            const Int32 FLD_TOTALINQTY = 5;
            const Int32 FLD_UNITPRICE = 6;
            const Int32 FLD_TOTALOUTQTY = 7;
            const Int32 FLD_AVAILABLEQTY = 8;
            const Int32 FLD_STOREID = 9;
            const Int32 FLD_STOREUNITID = 10;

            INVTransactionAvailableQtyWithBatch_CustomEntity iNVTransactionAvailableQtyWithBatch_CustomEntity = new INVTransactionAvailableQtyWithBatch_CustomEntity();

            iNVTransactionAvailableQtyWithBatch_CustomEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            iNVTransactionAvailableQtyWithBatch_CustomEntity.BrandID = reader.GetInt64(FLD_BRANDID);
            iNVTransactionAvailableQtyWithBatch_CustomEntity.RegionID = reader.GetInt64(FLD_REGIONID);
            iNVTransactionAvailableQtyWithBatch_CustomEntity.CountryID = reader.GetInt64(FLD_COUNTRYID);
            iNVTransactionAvailableQtyWithBatch_CustomEntity.BatchNumber = reader.GetString(FLD_BATCHNUMBER);
            if (reader.IsDBNull(FLD_TOTALINQTY)) { iNVTransactionAvailableQtyWithBatch_CustomEntity.TotalINQty = null; } else { iNVTransactionAvailableQtyWithBatch_CustomEntity.TotalINQty = reader.GetInt64(FLD_TOTALINQTY); }
            iNVTransactionAvailableQtyWithBatch_CustomEntity.UnitPrice = reader.GetDecimal(FLD_UNITPRICE);
            if (reader.IsDBNull(FLD_TOTALOUTQTY)) { iNVTransactionAvailableQtyWithBatch_CustomEntity.TotalOUTQty = null; } else { iNVTransactionAvailableQtyWithBatch_CustomEntity.TotalOUTQty = reader.GetInt64(FLD_TOTALOUTQTY); }
            if (reader.IsDBNull(FLD_AVAILABLEQTY)) { iNVTransactionAvailableQtyWithBatch_CustomEntity.AvailableQty = null; } else { iNVTransactionAvailableQtyWithBatch_CustomEntity.AvailableQty = reader.GetInt64(FLD_AVAILABLEQTY); }
            if (reader.IsDBNull(FLD_STOREID)) { iNVTransactionAvailableQtyWithBatch_CustomEntity.StoreID = null; } else { iNVTransactionAvailableQtyWithBatch_CustomEntity.StoreID = reader.GetInt64(FLD_STOREID); }
            if (reader.IsDBNull(FLD_STOREUNITID)) { iNVTransactionAvailableQtyWithBatch_CustomEntity.StoreUnitID = null; } else { iNVTransactionAvailableQtyWithBatch_CustomEntity.StoreUnitID = reader.GetInt64(FLD_STOREUNITID); }

            return iNVTransactionAvailableQtyWithBatch_CustomEntity;
        }
    }
}
