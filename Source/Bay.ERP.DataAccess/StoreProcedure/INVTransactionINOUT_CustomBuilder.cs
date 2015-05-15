// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-May-2013, 01:11:15




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class INVTransactionINOUT_CustomBuilder : IEntityBuilder<INVTransactionINOUT_CustomEntity>
    {
        IList<INVTransactionINOUT_CustomEntity> IEntityBuilder<INVTransactionINOUT_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<INVTransactionINOUT_CustomEntity> INVTransactionINOUT_CustomEntityList = new List<INVTransactionINOUT_CustomEntity>();

            while (reader.Read())
            {
                INVTransactionINOUT_CustomEntityList.Add(((IEntityBuilder<INVTransactionINOUT_CustomEntity>)this).BuildEntity(reader));
            }

            return (INVTransactionINOUT_CustomEntityList.Count > 0) ? INVTransactionINOUT_CustomEntityList : null;
        }

        INVTransactionINOUT_CustomEntity IEntityBuilder<INVTransactionINOUT_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ITEMID = 0;
            const Int32 FLD_BRANDID = 1;
            const Int32 FLD_REGIONID = 2;
            const Int32 FLD_COUNTRYID = 3;
            const Int32 FLD_TRANSACTIONDIRECTION = 4;
            const Int32 FLD_IN = 5;
            const Int32 FLD_OUT = 6;
            const Int32 FLD_BALANCEQTY = 7;
            const Int32 FLD_ITEMNAME = 8;
            const Int32 FLD_BRANDNAME = 9;
            const Int32 FLD_REGIONNAME = 10;
            const Int32 FLD_COUNTRYNAME = 11;

            INVTransactionINOUT_CustomEntity iNVTransactionINOUT_CustomEntity = new INVTransactionINOUT_CustomEntity();

            iNVTransactionINOUT_CustomEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            iNVTransactionINOUT_CustomEntity.BrandID = reader.GetInt64(FLD_BRANDID);
            iNVTransactionINOUT_CustomEntity.RegionID = reader.GetInt64(FLD_REGIONID);
            iNVTransactionINOUT_CustomEntity.CountryID = reader.GetInt64(FLD_COUNTRYID);
            iNVTransactionINOUT_CustomEntity.TransactionDirection = reader.GetBoolean(FLD_TRANSACTIONDIRECTION);
            if (reader.IsDBNull(FLD_IN)) { iNVTransactionINOUT_CustomEntity.IN = null; } else { iNVTransactionINOUT_CustomEntity.IN = reader.GetInt64(FLD_IN); }
            iNVTransactionINOUT_CustomEntity.OUT = reader.GetInt64(FLD_OUT);
            iNVTransactionINOUT_CustomEntity.BalanceQty = reader.GetInt64(FLD_BALANCEQTY);
            iNVTransactionINOUT_CustomEntity.ItemName = reader.GetString(FLD_ITEMNAME);
            iNVTransactionINOUT_CustomEntity.BrandName = reader.GetString(FLD_BRANDNAME);
            iNVTransactionINOUT_CustomEntity.RegionName = reader.GetString(FLD_REGIONNAME);
            iNVTransactionINOUT_CustomEntity.CountryName = reader.GetString(FLD_COUNTRYNAME);

            return iNVTransactionINOUT_CustomEntity;
        }
    }
}
