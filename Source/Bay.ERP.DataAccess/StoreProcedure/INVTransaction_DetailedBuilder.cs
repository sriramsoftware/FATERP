// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2012, 12:03:10




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class INVTransaction_DetailedBuilder : IEntityBuilder<INVTransaction_DetailedEntity>
    {
        IList<INVTransaction_DetailedEntity> IEntityBuilder<INVTransaction_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<INVTransaction_DetailedEntity> INVTransaction_DetailedEntityList = new List<INVTransaction_DetailedEntity>();

            while (reader.Read())
            {
                INVTransaction_DetailedEntityList.Add(((IEntityBuilder<INVTransaction_DetailedEntity>)this).BuildEntity(reader));
            }

            return (INVTransaction_DetailedEntityList.Count > 0) ? INVTransaction_DetailedEntityList : null;
        }

        INVTransaction_DetailedEntity IEntityBuilder<INVTransaction_DetailedEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_STOREID = 17;
            const Int32 FLD_STOREUNITID = 18;
            const Int32 FLD_MDITEMNAME = 19;
            const Int32 FLD_MDBRANDBRANDNAME = 20;
            const Int32 FLD_MDREGIONNAME = 21;
            const Int32 FLD_MDCOUNTRYNAME = 22;
            const Int32 FLD_UNITNAME = 23;
            const Int32 FLD_PROJECTNAME = 24;
            const Int32 FLD_STORENAME = 25;
            const Int32 FLD_STOREUNITNAME = 26;
            const Int32 FLD_MEMBERFULLNAME = 27;
            const Int32 FLD_PROJECTID = 28;
            const Int32 FLD_ROWNUMBER = 29;

            INVTransaction_DetailedEntity iNVTransaction_DetailedEntity = new INVTransaction_DetailedEntity();

            iNVTransaction_DetailedEntity.TransactionID = reader.GetInt64(FLD_TRANSACTIONID);
            iNVTransaction_DetailedEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            iNVTransaction_DetailedEntity.BrandID = reader.GetInt64(FLD_BRANDID);
            iNVTransaction_DetailedEntity.RegionID = reader.GetInt64(FLD_REGIONID);
            iNVTransaction_DetailedEntity.CountryID = reader.GetInt64(FLD_COUNTRYID);
            iNVTransaction_DetailedEntity.BatchNumber = reader.GetString(FLD_BATCHNUMBER);
            iNVTransaction_DetailedEntity.TransactionQty = reader.GetInt64(FLD_TRANSACTIONQTY);
            iNVTransaction_DetailedEntity.TransactionDate = reader.GetDateTime(FLD_TRANSACTIONDATE);
            iNVTransaction_DetailedEntity.TransactionDirection = reader.GetBoolean(FLD_TRANSACTIONDIRECTION);
            iNVTransaction_DetailedEntity.IPAddress = reader.GetString(FLD_IPADDRESS);
            iNVTransaction_DetailedEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            iNVTransaction_DetailedEntity.UnitPrice = reader.GetDecimal(FLD_UNITPRICE);
            if (reader.IsDBNull(FLD_REQUISITIONNUMBER)) { iNVTransaction_DetailedEntity.RequisitionNumber = String.Empty; } else { iNVTransaction_DetailedEntity.RequisitionNumber = reader.GetString(FLD_REQUISITIONNUMBER); }
            if (reader.IsDBNull(FLD_WORDORDERNUMBER)) { iNVTransaction_DetailedEntity.WordOrderNumber = String.Empty; } else { iNVTransaction_DetailedEntity.WordOrderNumber = reader.GetString(FLD_WORDORDERNUMBER); }
            if (reader.IsDBNull(FLD_MRRNUMBER)) { iNVTransaction_DetailedEntity.MRRNumber = String.Empty; } else { iNVTransaction_DetailedEntity.MRRNumber = reader.GetString(FLD_MRRNUMBER); }
            if (reader.IsDBNull(FLD_BILLNUMBER)) { iNVTransaction_DetailedEntity.BillNumber = String.Empty; } else { iNVTransaction_DetailedEntity.BillNumber = reader.GetString(FLD_BILLNUMBER); }
            iNVTransaction_DetailedEntity.IsTransfer = reader.GetBoolean(FLD_ISTRANSFER);
            if (reader.IsDBNull(FLD_STOREID)) { iNVTransaction_DetailedEntity.StoreID = null; } else { iNVTransaction_DetailedEntity.StoreID = reader.GetInt64(FLD_STOREID); }
            if (reader.IsDBNull(FLD_STOREUNITID)) { iNVTransaction_DetailedEntity.StoreUnitID = null; } else { iNVTransaction_DetailedEntity.StoreUnitID = reader.GetInt64(FLD_STOREUNITID); }
            if (reader.IsDBNull(FLD_MDITEMNAME)) { iNVTransaction_DetailedEntity.MDItemName = String.Empty; } else { iNVTransaction_DetailedEntity.MDItemName = reader.GetString(FLD_MDITEMNAME); }
            if (reader.IsDBNull(FLD_MDBRANDBRANDNAME)) { iNVTransaction_DetailedEntity.MDBrandBrandName = String.Empty; } else { iNVTransaction_DetailedEntity.MDBrandBrandName = reader.GetString(FLD_MDBRANDBRANDNAME); }
            if (reader.IsDBNull(FLD_MDREGIONNAME)) { iNVTransaction_DetailedEntity.MDRegionName = String.Empty; } else { iNVTransaction_DetailedEntity.MDRegionName = reader.GetString(FLD_MDREGIONNAME); }
            if (reader.IsDBNull(FLD_MDCOUNTRYNAME)) { iNVTransaction_DetailedEntity.MDCountryName = String.Empty; } else { iNVTransaction_DetailedEntity.MDCountryName = reader.GetString(FLD_MDCOUNTRYNAME); }
            if (reader.IsDBNull(FLD_UNITNAME)) { iNVTransaction_DetailedEntity.UnitName = String.Empty; } else { iNVTransaction_DetailedEntity.UnitName = reader.GetString(FLD_UNITNAME); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { iNVTransaction_DetailedEntity.ProjectName = String.Empty; } else { iNVTransaction_DetailedEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_STORENAME)) { iNVTransaction_DetailedEntity.StoreName = String.Empty; } else { iNVTransaction_DetailedEntity.StoreName = reader.GetString(FLD_STORENAME); }
            if (reader.IsDBNull(FLD_STOREUNITNAME)) { iNVTransaction_DetailedEntity.StoreUnitName = String.Empty; } else { iNVTransaction_DetailedEntity.StoreUnitName = reader.GetString(FLD_STOREUNITNAME); }
            if (reader.IsDBNull(FLD_MEMBERFULLNAME)) { iNVTransaction_DetailedEntity.MemberFullName = String.Empty; } else { iNVTransaction_DetailedEntity.MemberFullName = reader.GetString(FLD_MEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_PROJECTID)) { iNVTransaction_DetailedEntity.ProjectID = null; } else { iNVTransaction_DetailedEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { iNVTransaction_DetailedEntity.RowNumber = null; } else { iNVTransaction_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return iNVTransaction_DetailedEntity;
        }
    }
}
