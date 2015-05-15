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
    internal sealed class PRMPreBOQDetail_DetailedCustomBuilder : IEntityBuilder<PRMPreBOQDetail_DetailedCustomEntity>
    {
        IList<PRMPreBOQDetail_DetailedCustomEntity> IEntityBuilder<PRMPreBOQDetail_DetailedCustomEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMPreBOQDetail_DetailedCustomEntity> PRMPreBOQDetail_DetailedCustomEntityList = new List<PRMPreBOQDetail_DetailedCustomEntity>();

            while (reader.Read())
            {
                PRMPreBOQDetail_DetailedCustomEntityList.Add(((IEntityBuilder<PRMPreBOQDetail_DetailedCustomEntity>)this).BuildEntity(reader));
            }

            return (PRMPreBOQDetail_DetailedCustomEntityList.Count > 0) ? PRMPreBOQDetail_DetailedCustomEntityList : null;
        }

        PRMPreBOQDetail_DetailedCustomEntity IEntityBuilder<PRMPreBOQDetail_DetailedCustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PREBOQDETAILID = 0;
            const Int32 FLD_PREBOQID = 1;
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
            const Int32 FLD_PREBOQPROJECTID = 12;
            const Int32 FLD_ITEMNAME = 13;
            const Int32 FLD_BRANDNAME = 14;
            const Int32 FLD_SUPPLIERNAME = 15;
            const Int32 FLD_REGIONNAME = 16;
            const Int32 FLD_COUNTRYNAME = 17;

            PRMPreBOQDetail_DetailedCustomEntity pRMPreBOQDetail_DetailedCustomEntity = new PRMPreBOQDetail_DetailedCustomEntity();

            pRMPreBOQDetail_DetailedCustomEntity.PreBOQDetailID = reader.GetInt64(FLD_PREBOQDETAILID);
            pRMPreBOQDetail_DetailedCustomEntity.PreBOQID = reader.GetInt64(FLD_PREBOQID);
            pRMPreBOQDetail_DetailedCustomEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            pRMPreBOQDetail_DetailedCustomEntity.Rate = reader.GetDecimal(FLD_RATE);
            pRMPreBOQDetail_DetailedCustomEntity.TotalQty = reader.GetDecimal(FLD_TOTALQTY);
            if (reader.IsDBNull(FLD_REMARKS)) { pRMPreBOQDetail_DetailedCustomEntity.Remarks = String.Empty; } else { pRMPreBOQDetail_DetailedCustomEntity.Remarks = reader.GetString(FLD_REMARKS); }
            pRMPreBOQDetail_DetailedCustomEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            pRMPreBOQDetail_DetailedCustomEntity.EntryDate = reader.GetDateTime(FLD_ENTRYDATE);
            pRMPreBOQDetail_DetailedCustomEntity.BrandID = reader.GetInt64(FLD_BRANDID);
            pRMPreBOQDetail_DetailedCustomEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);
            pRMPreBOQDetail_DetailedCustomEntity.RegionID = reader.GetInt64(FLD_REGIONID);
            pRMPreBOQDetail_DetailedCustomEntity.CountryID = reader.GetInt64(FLD_COUNTRYID);
            if (reader.IsDBNull(FLD_PREBOQPROJECTID)) { pRMPreBOQDetail_DetailedCustomEntity.PreBOQProjectID = null; } else { pRMPreBOQDetail_DetailedCustomEntity.PreBOQProjectID = reader.GetInt64(FLD_PREBOQPROJECTID); }
            if (reader.IsDBNull(FLD_ITEMNAME)) { pRMPreBOQDetail_DetailedCustomEntity.ItemName = String.Empty; } else { pRMPreBOQDetail_DetailedCustomEntity.ItemName = reader.GetString(FLD_ITEMNAME); }
            if (reader.IsDBNull(FLD_BRANDNAME)) { pRMPreBOQDetail_DetailedCustomEntity.BrandName = String.Empty; } else { pRMPreBOQDetail_DetailedCustomEntity.BrandName = reader.GetString(FLD_BRANDNAME); }
            if (reader.IsDBNull(FLD_SUPPLIERNAME)) { pRMPreBOQDetail_DetailedCustomEntity.SupplierName = String.Empty; } else { pRMPreBOQDetail_DetailedCustomEntity.SupplierName = reader.GetString(FLD_SUPPLIERNAME); }
            if (reader.IsDBNull(FLD_REGIONNAME)) { pRMPreBOQDetail_DetailedCustomEntity.RegionName = String.Empty; } else { pRMPreBOQDetail_DetailedCustomEntity.RegionName = reader.GetString(FLD_REGIONNAME); }
            if (reader.IsDBNull(FLD_COUNTRYNAME)) { pRMPreBOQDetail_DetailedCustomEntity.CountryName = String.Empty; } else { pRMPreBOQDetail_DetailedCustomEntity.CountryName = reader.GetString(FLD_COUNTRYNAME); }

            return pRMPreBOQDetail_DetailedCustomEntity;
        }
    }
}
