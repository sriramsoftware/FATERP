// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-May-2012, 10:19:19




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMBOQDetailHistory_CustomBuilder : IEntityBuilder<PRMBOQDetailHistory_CustomEntity>
    {
        IList<PRMBOQDetailHistory_CustomEntity> IEntityBuilder<PRMBOQDetailHistory_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMBOQDetailHistory_CustomEntity> PRMBOQDetailHistory_CustomEntityList = new List<PRMBOQDetailHistory_CustomEntity>();

            while (reader.Read())
            {
                PRMBOQDetailHistory_CustomEntityList.Add(((IEntityBuilder<PRMBOQDetailHistory_CustomEntity>)this).BuildEntity(reader));
            }

            return (PRMBOQDetailHistory_CustomEntityList.Count > 0) ? PRMBOQDetailHistory_CustomEntityList : null;
        }

        PRMBOQDetailHistory_CustomEntity IEntityBuilder<PRMBOQDetailHistory_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BOQDETAILHISTORYID = 0;
            const Int32 FLD_BOQDETAILID = 1;
            const Int32 FLD_RATE = 2;
            const Int32 FLD_TOTALQTY = 3;
            const Int32 FLD_ENTRYDATE = 4;
            const Int32 FLD_BRANDID = 5;
            const Int32 FLD_SUPPLIERID = 6;
            const Int32 FLD_REGIONID = 7;
            const Int32 FLD_COUNTRYID = 8;
            const Int32 FLD_PROJECTID = 9;
            const Int32 FLD_PARENTCATEGORYNAME = 10;
            const Int32 FLD_CATEGORYNAME = 11;
            const Int32 FLD_ITEMID = 12;
            const Int32 FLD_ITEMNAME = 13;
            const Int32 FLD_ITEMCATEGORYID = 14;
            const Int32 FLD_UNITNAME = 15;
            const Int32 FLD_BRANDNAME = 16;
            const Int32 FLD_REGIONNAME = 17;
            const Int32 FLD_SUPPLIERNAME = 18;
            const Int32 FLD_COUNTRYNAME = 19;

            PRMBOQDetailHistory_CustomEntity pRMBOQDetailHistory_CustomEntity = new PRMBOQDetailHistory_CustomEntity();

            pRMBOQDetailHistory_CustomEntity.BOQDetailHistoryID = reader.GetInt64(FLD_BOQDETAILHISTORYID);
            pRMBOQDetailHistory_CustomEntity.BOQDetailID = reader.GetInt64(FLD_BOQDETAILID);
            pRMBOQDetailHistory_CustomEntity.Rate = reader.GetDecimal(FLD_RATE);
            pRMBOQDetailHistory_CustomEntity.TotalQty = reader.GetDecimal(FLD_TOTALQTY);
            pRMBOQDetailHistory_CustomEntity.EntryDate = reader.GetDateTime(FLD_ENTRYDATE);
            pRMBOQDetailHistory_CustomEntity.BrandID = reader.GetInt64(FLD_BRANDID);
            pRMBOQDetailHistory_CustomEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);
            pRMBOQDetailHistory_CustomEntity.RegionID = reader.GetInt64(FLD_REGIONID);
            pRMBOQDetailHistory_CustomEntity.CountryID = reader.GetInt64(FLD_COUNTRYID);
            pRMBOQDetailHistory_CustomEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            if (reader.IsDBNull(FLD_PARENTCATEGORYNAME)) { pRMBOQDetailHistory_CustomEntity.ParentCategoryName = String.Empty; } else { pRMBOQDetailHistory_CustomEntity.ParentCategoryName = reader.GetString(FLD_PARENTCATEGORYNAME); }
            pRMBOQDetailHistory_CustomEntity.CategoryName = reader.GetString(FLD_CATEGORYNAME);
            pRMBOQDetailHistory_CustomEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            pRMBOQDetailHistory_CustomEntity.ItemName = reader.GetString(FLD_ITEMNAME);
            pRMBOQDetailHistory_CustomEntity.ItemCategoryID = reader.GetInt64(FLD_ITEMCATEGORYID);
            if (reader.IsDBNull(FLD_UNITNAME)) { pRMBOQDetailHistory_CustomEntity.UnitName = String.Empty; } else { pRMBOQDetailHistory_CustomEntity.UnitName = reader.GetString(FLD_UNITNAME); }
            pRMBOQDetailHistory_CustomEntity.BrandName = reader.GetString(FLD_BRANDNAME);
            pRMBOQDetailHistory_CustomEntity.RegionName = reader.GetString(FLD_REGIONNAME);
            pRMBOQDetailHistory_CustomEntity.SupplierName = reader.GetString(FLD_SUPPLIERNAME);
            pRMBOQDetailHistory_CustomEntity.CountryName = reader.GetString(FLD_COUNTRYNAME);

            return pRMBOQDetailHistory_CustomEntity;
        }
    }
}
