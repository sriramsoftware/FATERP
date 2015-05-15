// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-May-2012, 04:17:30




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMBOQDetail_DetailedCustomBuilder : IEntityBuilder<PRMBOQDetail_DetailedCustomEntity>
    {
        IList<PRMBOQDetail_DetailedCustomEntity> IEntityBuilder<PRMBOQDetail_DetailedCustomEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMBOQDetail_DetailedCustomEntity> PRMBOQDetail_DetailedCustomEntityList = new List<PRMBOQDetail_DetailedCustomEntity>();

            while (reader.Read())
            {
                PRMBOQDetail_DetailedCustomEntityList.Add(((IEntityBuilder<PRMBOQDetail_DetailedCustomEntity>)this).BuildEntity(reader));
            }

            return (PRMBOQDetail_DetailedCustomEntityList.Count > 0) ? PRMBOQDetail_DetailedCustomEntityList : null;
        }

        PRMBOQDetail_DetailedCustomEntity IEntityBuilder<PRMBOQDetail_DetailedCustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BOQDETAILID = 0;
            const Int32 FLD_BOQID = 1;
            const Int32 FLD_ITEMID = 2;
            const Int32 FLD_RATE = 3;
            const Int32 FLD_TOTALQTY = 4;
            const Int32 FLD_REMARKS = 5;
            const Int32 FLD_ISREMOVED = 6;
            const Int32 FLD_ENTRYDATE = 7;
            const Int32 FLD_BRANDID = 8;
            const Int32 FLD_SUPPLIERID = 9;
            const Int32 FLD_REGIONID = 10;
            const Int32 FLD_COUNTRYID = 11;
            const Int32 FLD_PREBOQID = 12;
            const Int32 FLD_ITEMNAME = 13;
            const Int32 FLD_BRANDNAME = 14;
            const Int32 FLD_SUPPLIERNAME = 15;
            const Int32 FLD_MDREGIONNAME = 16;
            const Int32 FLD_MDCOUNTRYNAME = 17;

            PRMBOQDetail_DetailedCustomEntity pRMBOQDetail_DetailedCustomEntity = new PRMBOQDetail_DetailedCustomEntity();

            pRMBOQDetail_DetailedCustomEntity.BOQDetailID = reader.GetInt64(FLD_BOQDETAILID);
            pRMBOQDetail_DetailedCustomEntity.BOQID = reader.GetInt64(FLD_BOQID);
            pRMBOQDetail_DetailedCustomEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            pRMBOQDetail_DetailedCustomEntity.Rate = reader.GetDecimal(FLD_RATE);
            pRMBOQDetail_DetailedCustomEntity.TotalQty = reader.GetDecimal(FLD_TOTALQTY);
            if (reader.IsDBNull(FLD_REMARKS)) { pRMBOQDetail_DetailedCustomEntity.Remarks = String.Empty; } else { pRMBOQDetail_DetailedCustomEntity.Remarks = reader.GetString(FLD_REMARKS); }
            pRMBOQDetail_DetailedCustomEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            pRMBOQDetail_DetailedCustomEntity.EntryDate = reader.GetDateTime(FLD_ENTRYDATE);
            pRMBOQDetail_DetailedCustomEntity.BrandID = reader.GetInt64(FLD_BRANDID);
            pRMBOQDetail_DetailedCustomEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);
            pRMBOQDetail_DetailedCustomEntity.RegionID = reader.GetInt64(FLD_REGIONID);
            pRMBOQDetail_DetailedCustomEntity.CountryID = reader.GetInt64(FLD_COUNTRYID);
            if (reader.IsDBNull(FLD_PREBOQID)) { pRMBOQDetail_DetailedCustomEntity.PreBOQID = null; } else { pRMBOQDetail_DetailedCustomEntity.PreBOQID = reader.GetInt64(FLD_PREBOQID); }
            if (reader.IsDBNull(FLD_ITEMNAME)) { pRMBOQDetail_DetailedCustomEntity.ItemName = String.Empty; } else { pRMBOQDetail_DetailedCustomEntity.ItemName = reader.GetString(FLD_ITEMNAME); }
            if (reader.IsDBNull(FLD_BRANDNAME)) { pRMBOQDetail_DetailedCustomEntity.BrandName = String.Empty; } else { pRMBOQDetail_DetailedCustomEntity.BrandName = reader.GetString(FLD_BRANDNAME); }
            if (reader.IsDBNull(FLD_SUPPLIERNAME)) { pRMBOQDetail_DetailedCustomEntity.SupplierName = String.Empty; } else { pRMBOQDetail_DetailedCustomEntity.SupplierName = reader.GetString(FLD_SUPPLIERNAME); }
            if (reader.IsDBNull(FLD_MDREGIONNAME)) { pRMBOQDetail_DetailedCustomEntity.MDRegionName = String.Empty; } else { pRMBOQDetail_DetailedCustomEntity.MDRegionName = reader.GetString(FLD_MDREGIONNAME); }
            if (reader.IsDBNull(FLD_MDCOUNTRYNAME)) { pRMBOQDetail_DetailedCustomEntity.MDCountryName = String.Empty; } else { pRMBOQDetail_DetailedCustomEntity.MDCountryName = reader.GetString(FLD_MDCOUNTRYNAME); }

            return pRMBOQDetail_DetailedCustomEntity;
        }
    }
}
