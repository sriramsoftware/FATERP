// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-May-2012, 04:09:55




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMPreBOQDetail_CustomBuilder : IEntityBuilder<PRMPreBOQDetail_CustomEntity>
    {
        IList<PRMPreBOQDetail_CustomEntity> IEntityBuilder<PRMPreBOQDetail_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMPreBOQDetail_CustomEntity> PRMPreBOQDetail_CustomEntityList = new List<PRMPreBOQDetail_CustomEntity>();

            while (reader.Read())
            {
                PRMPreBOQDetail_CustomEntityList.Add(((IEntityBuilder<PRMPreBOQDetail_CustomEntity>)this).BuildEntity(reader));
            }

            return (PRMPreBOQDetail_CustomEntityList.Count > 0) ? PRMPreBOQDetail_CustomEntityList : null;
        }

        PRMPreBOQDetail_CustomEntity IEntityBuilder<PRMPreBOQDetail_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PREBOQDETAILID = 0;
            const Int32 FLD_PREBOQID = 1;
            const Int32 FLD_ITEMID = 2;
            const Int32 FLD_RATE = 3;
            const Int32 FLD_TOTALQTY = 4;
            const Int32 FLD_REMARKS = 5;
            const Int32 FLD_ISREMOVED = 6;
            const Int32 FLD_PRMPREBOQPROJECTID = 7;
            const Int32 FLD_MDITEMITEMNAME = 8;
            const Int32 FLD_ITEMCATEGORYID = 9;
            const Int32 FLD_UNITNAME = 10;
            const Int32 FLD_BRANDID = 11;
            const Int32 FLD_BRANDNAME = 12;
            const Int32 FLD_SUPPLIERID = 13;
            const Int32 FLD_SUPPLIERNAME = 14;
            const Int32 FLD_REGIONID = 15;
            const Int32 FLD_REGIONNAME = 16;
            const Int32 FLD_COUNTRYID = 17;
            const Int32 FLD_COUNTRYNAME = 18;
            const Int32 FLD_CATEGORYNAME = 19;
            const Int32 FLD_PARENTITEMCATEGORYID = 20;
            const Int32 FLD_PARENTCATEGORYNAME = 21;
            const Int32 FLD_ROWNUMBER = 22;

            PRMPreBOQDetail_CustomEntity pRMPreBOQDetail_CustomEntity = new PRMPreBOQDetail_CustomEntity();

            pRMPreBOQDetail_CustomEntity.PreBOQDetailID = reader.GetInt64(FLD_PREBOQDETAILID);
            pRMPreBOQDetail_CustomEntity.PreBOQID = reader.GetInt64(FLD_PREBOQID);
            pRMPreBOQDetail_CustomEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            pRMPreBOQDetail_CustomEntity.Rate = reader.GetDecimal(FLD_RATE);
            pRMPreBOQDetail_CustomEntity.TotalQty = reader.GetDecimal(FLD_TOTALQTY);
            if (reader.IsDBNull(FLD_REMARKS)) { pRMPreBOQDetail_CustomEntity.Remarks = String.Empty; } else { pRMPreBOQDetail_CustomEntity.Remarks = reader.GetString(FLD_REMARKS); }
            pRMPreBOQDetail_CustomEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            if (reader.IsDBNull(FLD_PRMPREBOQPROJECTID)) { pRMPreBOQDetail_CustomEntity.PRMPreBOQProjectID = null; } else { pRMPreBOQDetail_CustomEntity.PRMPreBOQProjectID = reader.GetInt64(FLD_PRMPREBOQPROJECTID); }
            if (reader.IsDBNull(FLD_MDITEMITEMNAME)) { pRMPreBOQDetail_CustomEntity.MDItemItemName = String.Empty; } else { pRMPreBOQDetail_CustomEntity.MDItemItemName = reader.GetString(FLD_MDITEMITEMNAME); }
            if (reader.IsDBNull(FLD_ITEMCATEGORYID)) { pRMPreBOQDetail_CustomEntity.ItemCategoryID = null; } else { pRMPreBOQDetail_CustomEntity.ItemCategoryID = reader.GetInt64(FLD_ITEMCATEGORYID); }
            if (reader.IsDBNull(FLD_UNITNAME)) { pRMPreBOQDetail_CustomEntity.UnitName = String.Empty; } else { pRMPreBOQDetail_CustomEntity.UnitName = reader.GetString(FLD_UNITNAME); }
            if (reader.IsDBNull(FLD_BRANDID)) { pRMPreBOQDetail_CustomEntity.BrandID = null; } else { pRMPreBOQDetail_CustomEntity.BrandID = reader.GetInt64(FLD_BRANDID); }
            if (reader.IsDBNull(FLD_BRANDNAME)) { pRMPreBOQDetail_CustomEntity.BrandName = String.Empty; } else { pRMPreBOQDetail_CustomEntity.BrandName = reader.GetString(FLD_BRANDNAME); }
            if (reader.IsDBNull(FLD_SUPPLIERID)) { pRMPreBOQDetail_CustomEntity.SupplierID = null; } else { pRMPreBOQDetail_CustomEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID); }
            if (reader.IsDBNull(FLD_SUPPLIERNAME)) { pRMPreBOQDetail_CustomEntity.SupplierName = String.Empty; } else { pRMPreBOQDetail_CustomEntity.SupplierName = reader.GetString(FLD_SUPPLIERNAME); }
            if (reader.IsDBNull(FLD_REGIONID)) { pRMPreBOQDetail_CustomEntity.RegionID = null; } else { pRMPreBOQDetail_CustomEntity.RegionID = reader.GetInt64(FLD_REGIONID); }
            if (reader.IsDBNull(FLD_REGIONNAME)) { pRMPreBOQDetail_CustomEntity.RegionName = String.Empty; } else { pRMPreBOQDetail_CustomEntity.RegionName = reader.GetString(FLD_REGIONNAME); }
            if (reader.IsDBNull(FLD_COUNTRYID)) { pRMPreBOQDetail_CustomEntity.CountryID = null; } else { pRMPreBOQDetail_CustomEntity.CountryID = reader.GetInt64(FLD_COUNTRYID); }
            if (reader.IsDBNull(FLD_COUNTRYNAME)) { pRMPreBOQDetail_CustomEntity.CountryName = String.Empty; } else { pRMPreBOQDetail_CustomEntity.CountryName = reader.GetString(FLD_COUNTRYNAME); }
            if (reader.IsDBNull(FLD_CATEGORYNAME)) { pRMPreBOQDetail_CustomEntity.CategoryName = String.Empty; } else { pRMPreBOQDetail_CustomEntity.CategoryName = reader.GetString(FLD_CATEGORYNAME); }
            if (reader.IsDBNull(FLD_PARENTITEMCATEGORYID)) { pRMPreBOQDetail_CustomEntity.ParentItemCategoryID = null; } else { pRMPreBOQDetail_CustomEntity.ParentItemCategoryID = reader.GetInt64(FLD_PARENTITEMCATEGORYID); }
            if (reader.IsDBNull(FLD_PARENTCATEGORYNAME)) { pRMPreBOQDetail_CustomEntity.ParentCategoryName = String.Empty; } else { pRMPreBOQDetail_CustomEntity.ParentCategoryName = reader.GetString(FLD_PARENTCATEGORYNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { pRMPreBOQDetail_CustomEntity.RowNumber = null; } else { pRMPreBOQDetail_CustomEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return pRMPreBOQDetail_CustomEntity;
        }
    }
}
