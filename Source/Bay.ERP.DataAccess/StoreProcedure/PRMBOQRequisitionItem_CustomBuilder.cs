// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-Oct-2012, 01:09:23




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMBOQRequisitionItem_CustomBuilder : IEntityBuilder<PRMBOQRequisitionItem_CustomEntity>
    {
        IList<PRMBOQRequisitionItem_CustomEntity> IEntityBuilder<PRMBOQRequisitionItem_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMBOQRequisitionItem_CustomEntity> PRMBOQRequisitionItem_CustomEntityList = new List<PRMBOQRequisitionItem_CustomEntity>();

            while (reader.Read())
            {
                PRMBOQRequisitionItem_CustomEntityList.Add(((IEntityBuilder<PRMBOQRequisitionItem_CustomEntity>)this).BuildEntity(reader));
            }

            return (PRMBOQRequisitionItem_CustomEntityList.Count > 0) ? PRMBOQRequisitionItem_CustomEntityList : null;
        }

        PRMBOQRequisitionItem_CustomEntity IEntityBuilder<PRMBOQRequisitionItem_CustomEntity>.BuildEntity(IDataReader reader)
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

            PRMBOQRequisitionItem_CustomEntity pRMBOQRequisitionItem_CustomEntity = new PRMBOQRequisitionItem_CustomEntity();

            pRMBOQRequisitionItem_CustomEntity.BOQDetailID = reader.GetInt64(FLD_BOQDETAILID);
            pRMBOQRequisitionItem_CustomEntity.BOQID = reader.GetInt64(FLD_BOQID);
            pRMBOQRequisitionItem_CustomEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            pRMBOQRequisitionItem_CustomEntity.Rate = reader.GetDecimal(FLD_RATE);
            pRMBOQRequisitionItem_CustomEntity.TotalQty = reader.GetDecimal(FLD_TOTALQTY);
            if (reader.IsDBNull(FLD_REMARKS)) { pRMBOQRequisitionItem_CustomEntity.Remarks = String.Empty; } else { pRMBOQRequisitionItem_CustomEntity.Remarks = reader.GetString(FLD_REMARKS); }
            pRMBOQRequisitionItem_CustomEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            if (reader.IsDBNull(FLD_PREBOQID)) { pRMBOQRequisitionItem_CustomEntity.PreBOQID = null; } else { pRMBOQRequisitionItem_CustomEntity.PreBOQID = reader.GetInt64(FLD_PREBOQID); }
            if (reader.IsDBNull(FLD_PRMPREBOQPROJECTID)) { pRMBOQRequisitionItem_CustomEntity.PRMPreBOQProjectID = null; } else { pRMBOQRequisitionItem_CustomEntity.PRMPreBOQProjectID = reader.GetInt64(FLD_PRMPREBOQPROJECTID); }
            if (reader.IsDBNull(FLD_MDITEMITEMNAME)) { pRMBOQRequisitionItem_CustomEntity.MDItemItemName = String.Empty; } else { pRMBOQRequisitionItem_CustomEntity.MDItemItemName = reader.GetString(FLD_MDITEMITEMNAME); }
            if (reader.IsDBNull(FLD_ITEMCATEGORYID)) { pRMBOQRequisitionItem_CustomEntity.ItemCategoryID = null; } else { pRMBOQRequisitionItem_CustomEntity.ItemCategoryID = reader.GetInt64(FLD_ITEMCATEGORYID); }
            if (reader.IsDBNull(FLD_UNITNAME)) { pRMBOQRequisitionItem_CustomEntity.UnitName = String.Empty; } else { pRMBOQRequisitionItem_CustomEntity.UnitName = reader.GetString(FLD_UNITNAME); }
            if (reader.IsDBNull(FLD_BRANDID)) { pRMBOQRequisitionItem_CustomEntity.BrandID = null; } else { pRMBOQRequisitionItem_CustomEntity.BrandID = reader.GetInt64(FLD_BRANDID); }
            if (reader.IsDBNull(FLD_BRANDNAME)) { pRMBOQRequisitionItem_CustomEntity.BrandName = String.Empty; } else { pRMBOQRequisitionItem_CustomEntity.BrandName = reader.GetString(FLD_BRANDNAME); }
            if (reader.IsDBNull(FLD_SUPPLIERID)) { pRMBOQRequisitionItem_CustomEntity.SupplierID = null; } else { pRMBOQRequisitionItem_CustomEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID); }
            if (reader.IsDBNull(FLD_SUPPLIERNAME)) { pRMBOQRequisitionItem_CustomEntity.SupplierName = String.Empty; } else { pRMBOQRequisitionItem_CustomEntity.SupplierName = reader.GetString(FLD_SUPPLIERNAME); }
            if (reader.IsDBNull(FLD_REGIONID)) { pRMBOQRequisitionItem_CustomEntity.RegionID = null; } else { pRMBOQRequisitionItem_CustomEntity.RegionID = reader.GetInt64(FLD_REGIONID); }
            if (reader.IsDBNull(FLD_REGIONNAME)) { pRMBOQRequisitionItem_CustomEntity.RegionName = String.Empty; } else { pRMBOQRequisitionItem_CustomEntity.RegionName = reader.GetString(FLD_REGIONNAME); }
            if (reader.IsDBNull(FLD_COUNTRYID)) { pRMBOQRequisitionItem_CustomEntity.CountryID = null; } else { pRMBOQRequisitionItem_CustomEntity.CountryID = reader.GetInt64(FLD_COUNTRYID); }
            if (reader.IsDBNull(FLD_COUNTRYNAME)) { pRMBOQRequisitionItem_CustomEntity.CountryName = String.Empty; } else { pRMBOQRequisitionItem_CustomEntity.CountryName = reader.GetString(FLD_COUNTRYNAME); }
            if (reader.IsDBNull(FLD_CATEGORYNAME)) { pRMBOQRequisitionItem_CustomEntity.CategoryName = String.Empty; } else { pRMBOQRequisitionItem_CustomEntity.CategoryName = reader.GetString(FLD_CATEGORYNAME); }
            if (reader.IsDBNull(FLD_PARENTITEMCATEGORYID)) { pRMBOQRequisitionItem_CustomEntity.ParentItemCategoryID = null; } else { pRMBOQRequisitionItem_CustomEntity.ParentItemCategoryID = reader.GetInt64(FLD_PARENTITEMCATEGORYID); }
            if (reader.IsDBNull(FLD_PARENTCATEGORYNAME)) { pRMBOQRequisitionItem_CustomEntity.ParentCategoryName = String.Empty; } else { pRMBOQRequisitionItem_CustomEntity.ParentCategoryName = reader.GetString(FLD_PARENTCATEGORYNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { pRMBOQRequisitionItem_CustomEntity.RowNumber = null; } else { pRMBOQRequisitionItem_CustomEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return pRMBOQRequisitionItem_CustomEntity;
        }
    }
}
