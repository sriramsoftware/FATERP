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
    internal sealed class PRMSupplierItemMapBuilder : IEntityBuilder<PRMSupplierItemMapEntity>
    {
        IList<PRMSupplierItemMapEntity> IEntityBuilder<PRMSupplierItemMapEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMSupplierItemMapEntity> PRMSupplierItemMapEntityList = new List<PRMSupplierItemMapEntity>();

            while (reader.Read())
            {
                PRMSupplierItemMapEntityList.Add(((IEntityBuilder<PRMSupplierItemMapEntity>)this).BuildEntity(reader));
            }

            return (PRMSupplierItemMapEntityList.Count > 0) ? PRMSupplierItemMapEntityList : null;
        }

        PRMSupplierItemMapEntity IEntityBuilder<PRMSupplierItemMapEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SUPPLIERITEMMAPID = 0;
            const Int32 FLD_SUPPLIERID = 1;
            const Int32 FLD_BRANDID = 2;
            const Int32 FLD_ITEMID = 3;
            const Int32 FLD_ORIGINREGIONID = 4;
            const Int32 FLD_ORIGINCOUNTRYID = 5;
            const Int32 FLD_ACTUALPRICE = 6;
            const Int32 FLD_DISCOUNTPERCENTAGE = 7;
            const Int32 FLD_PRICE = 8;
            const Int32 FLD_MODEL = 9;
            const Int32 FLD_WARRANTYPERIOD = 10;
            const Int32 FLD_ENTRYDATE = 11;
            const Int32 FLD_ISREMOVED = 12;

            PRMSupplierItemMapEntity pRMSupplierItemMapEntity = new PRMSupplierItemMapEntity();

            pRMSupplierItemMapEntity.SupplierItemMapID = reader.GetInt64(FLD_SUPPLIERITEMMAPID);
            pRMSupplierItemMapEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);
            pRMSupplierItemMapEntity.BrandID = reader.GetInt64(FLD_BRANDID);
            pRMSupplierItemMapEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            if (reader.IsDBNull(FLD_ORIGINREGIONID)) { pRMSupplierItemMapEntity.OriginRegionID = null; } else { pRMSupplierItemMapEntity.OriginRegionID = reader.GetInt64(FLD_ORIGINREGIONID); }
            if (reader.IsDBNull(FLD_ORIGINCOUNTRYID)) { pRMSupplierItemMapEntity.OriginCountryID = null; } else { pRMSupplierItemMapEntity.OriginCountryID = reader.GetInt64(FLD_ORIGINCOUNTRYID); }
            pRMSupplierItemMapEntity.ActualPrice = reader.GetDecimal(FLD_ACTUALPRICE);
            pRMSupplierItemMapEntity.DiscountPercentage = reader.GetDecimal(FLD_DISCOUNTPERCENTAGE);
            pRMSupplierItemMapEntity.Price = reader.GetDecimal(FLD_PRICE);
            if (reader.IsDBNull(FLD_MODEL)) { pRMSupplierItemMapEntity.Model = String.Empty; } else { pRMSupplierItemMapEntity.Model = reader.GetString(FLD_MODEL); }
            if (reader.IsDBNull(FLD_WARRANTYPERIOD)) { pRMSupplierItemMapEntity.WarrantyPeriod = null; } else { pRMSupplierItemMapEntity.WarrantyPeriod = reader.GetInt64(FLD_WARRANTYPERIOD); }
            pRMSupplierItemMapEntity.EntryDate = reader.GetDateTime(FLD_ENTRYDATE);
            if (reader.IsDBNull(FLD_ISREMOVED)) { pRMSupplierItemMapEntity.IsRemoved = false; } else { pRMSupplierItemMapEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED); }

            return pRMSupplierItemMapEntity;
        }
    }
}
