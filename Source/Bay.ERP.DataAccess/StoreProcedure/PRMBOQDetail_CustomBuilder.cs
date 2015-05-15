// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-May-2012, 04:12:47




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMBOQDetail_CustomBuilder : IEntityBuilder<PRMBOQDetail_CustomEntity>
    {
        IList<PRMBOQDetail_CustomEntity> IEntityBuilder<PRMBOQDetail_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMBOQDetail_CustomEntity> PRMBOQDetail_CustomEntityList = new List<PRMBOQDetail_CustomEntity>();

            while (reader.Read())
            {
                PRMBOQDetail_CustomEntityList.Add(((IEntityBuilder<PRMBOQDetail_CustomEntity>)this).BuildEntity(reader));
            }

            return (PRMBOQDetail_CustomEntityList.Count > 0) ? PRMBOQDetail_CustomEntityList : null;
        }

        PRMBOQDetail_CustomEntity IEntityBuilder<PRMBOQDetail_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BOQDETAILID = 0;
            const Int32 FLD_BOQID = 1;
            const Int32 FLD_ITEMID = 2;
            const Int32 FLD_RATE = 3;
            const Int32 FLD_TOTALQTY = 4;
            const Int32 FLD_REMARKS = 5;
            const Int32 FLD_ISREMOVED = 6;
            const Int32 FLD_PREBOQID = 7;
            const Int32 FLD_PRMPREBOQPROJECTID = 8;
            const Int32 FLD_MDITEMITEMNAME = 9;
            const Int32 FLD_ITEMCATEGORYID = 10;
            const Int32 FLD_UNITNAME = 11;
            const Int32 FLD_BRANDID = 12;
            const Int32 FLD_BRANDNAME = 13;
            const Int32 FLD_SUPPLIERID = 14;
            const Int32 FLD_SUPPLIERNAME = 15;
            const Int32 FLD_REGIONID = 16;
            const Int32 FLD_REGIONNAME = 17;
            const Int32 FLD_COUNTRYID = 18;
            const Int32 FLD_COUNTRYNAME = 19;
            const Int32 FLD_CATEGORYNAME = 20;
            const Int32 FLD_PARENTITEMCATEGORYID = 21;
            const Int32 FLD_PARENTCATEGORYNAME = 22;
            const Int32 FLD_ROWNUMBER = 23;

            PRMBOQDetail_CustomEntity pRMBOQDetail_CustomEntity = new PRMBOQDetail_CustomEntity();

            pRMBOQDetail_CustomEntity.BOQDetailID = reader.GetInt64(FLD_BOQDETAILID);
            pRMBOQDetail_CustomEntity.BOQID = reader.GetInt64(FLD_BOQID);
            pRMBOQDetail_CustomEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            pRMBOQDetail_CustomEntity.Rate = reader.GetDecimal(FLD_RATE);
            pRMBOQDetail_CustomEntity.TotalQty = reader.GetDecimal(FLD_TOTALQTY);
            if (reader.IsDBNull(FLD_REMARKS)) { pRMBOQDetail_CustomEntity.Remarks = String.Empty; } else { pRMBOQDetail_CustomEntity.Remarks = reader.GetString(FLD_REMARKS); }
            pRMBOQDetail_CustomEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            if (reader.IsDBNull(FLD_PREBOQID)) { pRMBOQDetail_CustomEntity.PreBOQID = null; } else { pRMBOQDetail_CustomEntity.PreBOQID = reader.GetInt64(FLD_PREBOQID); }
            if (reader.IsDBNull(FLD_PRMPREBOQPROJECTID)) { pRMBOQDetail_CustomEntity.PRMPreBOQProjectID = null; } else { pRMBOQDetail_CustomEntity.PRMPreBOQProjectID = reader.GetInt64(FLD_PRMPREBOQPROJECTID); }
            if (reader.IsDBNull(FLD_MDITEMITEMNAME)) { pRMBOQDetail_CustomEntity.MDItemItemName = String.Empty; } else { pRMBOQDetail_CustomEntity.MDItemItemName = reader.GetString(FLD_MDITEMITEMNAME); }
            if (reader.IsDBNull(FLD_ITEMCATEGORYID)) { pRMBOQDetail_CustomEntity.ItemCategoryID = null; } else { pRMBOQDetail_CustomEntity.ItemCategoryID = reader.GetInt64(FLD_ITEMCATEGORYID); }
            if (reader.IsDBNull(FLD_UNITNAME)) { pRMBOQDetail_CustomEntity.UnitName = String.Empty; } else { pRMBOQDetail_CustomEntity.UnitName = reader.GetString(FLD_UNITNAME); }
            if (reader.IsDBNull(FLD_BRANDID)) { pRMBOQDetail_CustomEntity.BrandID = null; } else { pRMBOQDetail_CustomEntity.BrandID = reader.GetInt64(FLD_BRANDID); }
            if (reader.IsDBNull(FLD_BRANDNAME)) { pRMBOQDetail_CustomEntity.BrandName = String.Empty; } else { pRMBOQDetail_CustomEntity.BrandName = reader.GetString(FLD_BRANDNAME); }
            if (reader.IsDBNull(FLD_SUPPLIERID)) { pRMBOQDetail_CustomEntity.SupplierID = null; } else { pRMBOQDetail_CustomEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID); }
            if (reader.IsDBNull(FLD_SUPPLIERNAME)) { pRMBOQDetail_CustomEntity.SupplierName = String.Empty; } else { pRMBOQDetail_CustomEntity.SupplierName = reader.GetString(FLD_SUPPLIERNAME); }
            if (reader.IsDBNull(FLD_REGIONID)) { pRMBOQDetail_CustomEntity.RegionID = null; } else { pRMBOQDetail_CustomEntity.RegionID = reader.GetInt64(FLD_REGIONID); }
            if (reader.IsDBNull(FLD_REGIONNAME)) { pRMBOQDetail_CustomEntity.RegionName = String.Empty; } else { pRMBOQDetail_CustomEntity.RegionName = reader.GetString(FLD_REGIONNAME); }
            if (reader.IsDBNull(FLD_COUNTRYID)) { pRMBOQDetail_CustomEntity.CountryID = null; } else { pRMBOQDetail_CustomEntity.CountryID = reader.GetInt64(FLD_COUNTRYID); }
            if (reader.IsDBNull(FLD_COUNTRYNAME)) { pRMBOQDetail_CustomEntity.CountryName = String.Empty; } else { pRMBOQDetail_CustomEntity.CountryName = reader.GetString(FLD_COUNTRYNAME); }
            if (reader.IsDBNull(FLD_CATEGORYNAME)) { pRMBOQDetail_CustomEntity.CategoryName = String.Empty; } else { pRMBOQDetail_CustomEntity.CategoryName = reader.GetString(FLD_CATEGORYNAME); }
            if (reader.IsDBNull(FLD_PARENTITEMCATEGORYID)) { pRMBOQDetail_CustomEntity.ParentItemCategoryID = null; } else { pRMBOQDetail_CustomEntity.ParentItemCategoryID = reader.GetInt64(FLD_PARENTITEMCATEGORYID); }
            if (reader.IsDBNull(FLD_PARENTCATEGORYNAME)) { pRMBOQDetail_CustomEntity.ParentCategoryName = String.Empty; } else { pRMBOQDetail_CustomEntity.ParentCategoryName = reader.GetString(FLD_PARENTCATEGORYNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { pRMBOQDetail_CustomEntity.RowNumber = null; } else { pRMBOQDetail_CustomEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return pRMBOQDetail_CustomEntity;
        }
    }
}
