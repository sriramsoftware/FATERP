// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Dec-2012, 02:43:44




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class INVTransactionBuilder : IEntityBuilder<INVTransactionEntity>
    {
        IList<INVTransactionEntity> IEntityBuilder<INVTransactionEntity>.BuildEntities(IDataReader reader)
        {
            List<INVTransactionEntity> INVTransactionEntityList = new List<INVTransactionEntity>();

            while (reader.Read())
            {
                INVTransactionEntityList.Add(((IEntityBuilder<INVTransactionEntity>)this).BuildEntity(reader));
            }

            return (INVTransactionEntityList.Count > 0) ? INVTransactionEntityList : null;
        }

        INVTransactionEntity IEntityBuilder<INVTransactionEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_TRANSACTIONID = 0;
            const Int32 FLD_ITEMID = 1;
            const Int32 FLD_BRANDID = 2;
            const Int32 FLD_REGIONID = 3;
            const Int32 FLD_COUNTRYID = 4;
            const Int32 FLD_BATCHNUMBER = 5;
            const Int32 FLD_TRANSACTIONQTY = 6;
            const Int32 FLD_TRANSACTIONDATE = 7;
            const Int32 FLD_TRANSACTIONDIRECTION = 8;
            const Int32 FLD_IPADDRESS = 9;
            const Int32 FLD_EMPLOYEEID = 10;
            const Int32 FLD_UNITPRICE = 11;
            const Int32 FLD_REQUISITIONNUMBER = 12;
            const Int32 FLD_WORDORDERNUMBER = 13;
            const Int32 FLD_MRRNUMBER = 14;
            const Int32 FLD_BILLNUMBER = 15;
            const Int32 FLD_ISTRANSFER = 16;
            const Int32 FLD_PROJECTID = 17;
            const Int32 FLD_STOREID = 18;
            const Int32 FLD_STOREUNITID = 19;

            INVTransactionEntity iNVTransactionEntity = new INVTransactionEntity();

            iNVTransactionEntity.TransactionID = reader.GetInt64(FLD_TRANSACTIONID);
            iNVTransactionEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            iNVTransactionEntity.BrandID = reader.GetInt64(FLD_BRANDID);
            iNVTransactionEntity.RegionID = reader.GetInt64(FLD_REGIONID);
            iNVTransactionEntity.CountryID = reader.GetInt64(FLD_COUNTRYID);
            iNVTransactionEntity.BatchNumber = reader.GetString(FLD_BATCHNUMBER);
            iNVTransactionEntity.TransactionQty = reader.GetInt64(FLD_TRANSACTIONQTY);
            iNVTransactionEntity.TransactionDate = reader.GetDateTime(FLD_TRANSACTIONDATE);
            iNVTransactionEntity.TransactionDirection = reader.GetBoolean(FLD_TRANSACTIONDIRECTION);
            iNVTransactionEntity.IPAddress = reader.GetString(FLD_IPADDRESS);
            iNVTransactionEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            iNVTransactionEntity.UnitPrice = reader.GetDecimal(FLD_UNITPRICE);
            if (reader.IsDBNull(FLD_REQUISITIONNUMBER)) { iNVTransactionEntity.RequisitionNumber = String.Empty; } else { iNVTransactionEntity.RequisitionNumber = reader.GetString(FLD_REQUISITIONNUMBER); }
            if (reader.IsDBNull(FLD_WORDORDERNUMBER)) { iNVTransactionEntity.WordOrderNumber = String.Empty; } else { iNVTransactionEntity.WordOrderNumber = reader.GetString(FLD_WORDORDERNUMBER); }
            if (reader.IsDBNull(FLD_MRRNUMBER)) { iNVTransactionEntity.MRRNumber = String.Empty; } else { iNVTransactionEntity.MRRNumber = reader.GetString(FLD_MRRNUMBER); }
            if (reader.IsDBNull(FLD_BILLNUMBER)) { iNVTransactionEntity.BillNumber = String.Empty; } else { iNVTransactionEntity.BillNumber = reader.GetString(FLD_BILLNUMBER); }
            iNVTransactionEntity.IsTransfer = reader.GetBoolean(FLD_ISTRANSFER);
            if (reader.IsDBNull(FLD_PROJECTID)) { iNVTransactionEntity.ProjectID = null; } else { iNVTransactionEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            if (reader.IsDBNull(FLD_STOREID)) { iNVTransactionEntity.StoreID = null; } else { iNVTransactionEntity.StoreID = reader.GetInt64(FLD_STOREID); }
            if (reader.IsDBNull(FLD_STOREUNITID)) { iNVTransactionEntity.StoreUnitID = null; } else { iNVTransactionEntity.StoreUnitID = reader.GetInt64(FLD_STOREUNITID); }

            return iNVTransactionEntity;
        }
    }
}
