// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 31-Oct-2012, 10:36:45




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMPreBOQRequisitionItem_CustomBuilder : IEntityBuilder<PRMPreBOQRequisitionItem_CustomEntity>
    {
        IList<PRMPreBOQRequisitionItem_CustomEntity> IEntityBuilder<PRMPreBOQRequisitionItem_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMPreBOQRequisitionItem_CustomEntity> PRMPreBOQRequisitionItem_CustomEntityList = new List<PRMPreBOQRequisitionItem_CustomEntity>();

            while (reader.Read())
            {
                PRMPreBOQRequisitionItem_CustomEntityList.Add(((IEntityBuilder<PRMPreBOQRequisitionItem_CustomEntity>)this).BuildEntity(reader));
            }

            return (PRMPreBOQRequisitionItem_CustomEntityList.Count > 0) ? PRMPreBOQRequisitionItem_CustomEntityList : null;
        }

        PRMPreBOQRequisitionItem_CustomEntity IEntityBuilder<PRMPreBOQRequisitionItem_CustomEntity>.BuildEntity(IDataReader reader)
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

            PRMPreBOQRequisitionItem_CustomEntity pRMPreBOQRequisitionItem_CustomEntity = new PRMPreBOQRequisitionItem_CustomEntity();

            pRMPreBOQRequisitionItem_CustomEntity.PreBOQDetailID = reader.GetInt64(FLD_PREBOQDETAILID);
            pRMPreBOQRequisitionItem_CustomEntity.PreBOQID = reader.GetInt64(FLD_PREBOQID);
            pRMPreBOQRequisitionItem_CustomEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            pRMPreBOQRequisitionItem_CustomEntity.Rate = reader.GetDecimal(FLD_RATE);
            pRMPreBOQRequisitionItem_CustomEntity.TotalQty = reader.GetDecimal(FLD_TOTALQTY);
            if (reader.IsDBNull(FLD_REMARKS)) { pRMPreBOQRequisitionItem_CustomEntity.Remarks = String.Empty; } else { pRMPreBOQRequisitionItem_CustomEntity.Remarks = reader.GetString(FLD_REMARKS); }
            pRMPreBOQRequisitionItem_CustomEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            if (reader.IsDBNull(FLD_PRMPREBOQPROJECTID)) { pRMPreBOQRequisitionItem_CustomEntity.PRMPreBOQProjectID = null; } else { pRMPreBOQRequisitionItem_CustomEntity.PRMPreBOQProjectID = reader.GetInt64(FLD_PRMPREBOQPROJECTID); }
            if (reader.IsDBNull(FLD_MDITEMITEMNAME)) { pRMPreBOQRequisitionItem_CustomEntity.MDItemItemName = String.Empty; } else { pRMPreBOQRequisitionItem_CustomEntity.MDItemItemName = reader.GetString(FLD_MDITEMITEMNAME); }
            if (reader.IsDBNull(FLD_ITEMCATEGORYID)) { pRMPreBOQRequisitionItem_CustomEntity.ItemCategoryID = null; } else { pRMPreBOQRequisitionItem_CustomEntity.ItemCategoryID = reader.GetInt64(FLD_ITEMCATEGORYID); }
            if (reader.IsDBNull(FLD_UNITNAME)) { pRMPreBOQRequisitionItem_CustomEntity.UnitName = String.Empty; } else { pRMPreBOQRequisitionItem_CustomEntity.UnitName = reader.GetString(FLD_UNITNAME); }
            if (reader.IsDBNull(FLD_BRANDID)) { pRMPreBOQRequisitionItem_CustomEntity.BrandID = null; } else { pRMPreBOQRequisitionItem_CustomEntity.BrandID = reader.GetInt64(FLD_BRANDID); }
            if (reader.IsDBNull(FLD_BRANDNAME)) { pRMPreBOQRequisitionItem_CustomEntity.BrandName = String.Empty; } else { pRMPreBOQRequisitionItem_CustomEntity.BrandName = reader.GetString(FLD_BRANDNAME); }
            if (reader.IsDBNull(FLD_SUPPLIERID)) { pRMPreBOQRequisitionItem_CustomEntity.SupplierID = null; } else { pRMPreBOQRequisitionItem_CustomEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID); }
            if (reader.IsDBNull(FLD_SUPPLIERNAME)) { pRMPreBOQRequisitionItem_CustomEntity.SupplierName = String.Empty; } else { pRMPreBOQRequisitionItem_CustomEntity.SupplierName = reader.GetString(FLD_SUPPLIERNAME); }
            if (reader.IsDBNull(FLD_REGIONID)) { pRMPreBOQRequisitionItem_CustomEntity.RegionID = null; } else { pRMPreBOQRequisitionItem_CustomEntity.RegionID = reader.GetInt64(FLD_REGIONID); }
            if (reader.IsDBNull(FLD_REGIONNAME)) { pRMPreBOQRequisitionItem_CustomEntity.RegionName = String.Empty; } else { pRMPreBOQRequisitionItem_CustomEntity.RegionName = reader.GetString(FLD_REGIONNAME); }
            if (reader.IsDBNull(FLD_COUNTRYID)) { pRMPreBOQRequisitionItem_CustomEntity.CountryID = null; } else { pRMPreBOQRequisitionItem_CustomEntity.CountryID = reader.GetInt64(FLD_COUNTRYID); }
            if (reader.IsDBNull(FLD_COUNTRYNAME)) { pRMPreBOQRequisitionItem_CustomEntity.CountryName = String.Empty; } else { pRMPreBOQRequisitionItem_CustomEntity.CountryName = reader.GetString(FLD_COUNTRYNAME); }
            if (reader.IsDBNull(FLD_CATEGORYNAME)) { pRMPreBOQRequisitionItem_CustomEntity.CategoryName = String.Empty; } else { pRMPreBOQRequisitionItem_CustomEntity.CategoryName = reader.GetString(FLD_CATEGORYNAME); }
            if (reader.IsDBNull(FLD_PARENTITEMCATEGORYID)) { pRMPreBOQRequisitionItem_CustomEntity.ParentItemCategoryID = null; } else { pRMPreBOQRequisitionItem_CustomEntity.ParentItemCategoryID = reader.GetInt64(FLD_PARENTITEMCATEGORYID); }
            if (reader.IsDBNull(FLD_PARENTCATEGORYNAME)) { pRMPreBOQRequisitionItem_CustomEntity.ParentCategoryName = String.Empty; } else { pRMPreBOQRequisitionItem_CustomEntity.ParentCategoryName = reader.GetString(FLD_PARENTCATEGORYNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { pRMPreBOQRequisitionItem_CustomEntity.RowNumber = null; } else { pRMPreBOQRequisitionItem_CustomEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return pRMPreBOQRequisitionItem_CustomEntity;
        }
    }
}
