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
    internal sealed class PRMPreBOQDetailHistory_CustomBuilder : IEntityBuilder<PRMPreBOQDetailHistory_CustomEntity>
    {
        IList<PRMPreBOQDetailHistory_CustomEntity> IEntityBuilder<PRMPreBOQDetailHistory_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMPreBOQDetailHistory_CustomEntity> PRMPreBOQDetailHistory_CustomEntityList = new List<PRMPreBOQDetailHistory_CustomEntity>();

            while (reader.Read())
            {
                PRMPreBOQDetailHistory_CustomEntityList.Add(((IEntityBuilder<PRMPreBOQDetailHistory_CustomEntity>)this).BuildEntity(reader));
            }

            return (PRMPreBOQDetailHistory_CustomEntityList.Count > 0) ? PRMPreBOQDetailHistory_CustomEntityList : null;
        }

        PRMPreBOQDetailHistory_CustomEntity IEntityBuilder<PRMPreBOQDetailHistory_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PRMPREBOQDETAILHISTORYID = 0;
            const Int32 FLD_PREBOQDETAILID = 1;
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

            PRMPreBOQDetailHistory_CustomEntity pRMPreBOQDetailHistory_CustomEntity = new PRMPreBOQDetailHistory_CustomEntity();

            pRMPreBOQDetailHistory_CustomEntity.PRMPreBOQDetailHistoryID = reader.GetInt64(FLD_PRMPREBOQDETAILHISTORYID);
            pRMPreBOQDetailHistory_CustomEntity.PreBOQDetailID = reader.GetInt64(FLD_PREBOQDETAILID);
            pRMPreBOQDetailHistory_CustomEntity.Rate = reader.GetDecimal(FLD_RATE);
            pRMPreBOQDetailHistory_CustomEntity.TotalQty = reader.GetDecimal(FLD_TOTALQTY);
            pRMPreBOQDetailHistory_CustomEntity.EntryDate = reader.GetDateTime(FLD_ENTRYDATE);
            pRMPreBOQDetailHistory_CustomEntity.BrandID = reader.GetInt64(FLD_BRANDID);
            pRMPreBOQDetailHistory_CustomEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);
            pRMPreBOQDetailHistory_CustomEntity.RegionID = reader.GetInt64(FLD_REGIONID);
            pRMPreBOQDetailHistory_CustomEntity.CountryID = reader.GetInt64(FLD_COUNTRYID);
            pRMPreBOQDetailHistory_CustomEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            if (reader.IsDBNull(FLD_PARENTCATEGORYNAME)) { pRMPreBOQDetailHistory_CustomEntity.ParentCategoryName = String.Empty; } else { pRMPreBOQDetailHistory_CustomEntity.ParentCategoryName = reader.GetString(FLD_PARENTCATEGORYNAME); }
            pRMPreBOQDetailHistory_CustomEntity.CategoryName = reader.GetString(FLD_CATEGORYNAME);
            pRMPreBOQDetailHistory_CustomEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            pRMPreBOQDetailHistory_CustomEntity.ItemName = reader.GetString(FLD_ITEMNAME);
            pRMPreBOQDetailHistory_CustomEntity.ItemCategoryID = reader.GetInt64(FLD_ITEMCATEGORYID);
            if (reader.IsDBNull(FLD_UNITNAME)) { pRMPreBOQDetailHistory_CustomEntity.UnitName = String.Empty; } else { pRMPreBOQDetailHistory_CustomEntity.UnitName = reader.GetString(FLD_UNITNAME); }
            pRMPreBOQDetailHistory_CustomEntity.BrandName = reader.GetString(FLD_BRANDNAME);
            pRMPreBOQDetailHistory_CustomEntity.RegionName = reader.GetString(FLD_REGIONNAME);
            pRMPreBOQDetailHistory_CustomEntity.SupplierName = reader.GetString(FLD_SUPPLIERNAME);
            pRMPreBOQDetailHistory_CustomEntity.CountryName = reader.GetString(FLD_COUNTRYNAME);

            return pRMPreBOQDetailHistory_CustomEntity;
        }
    }
}
