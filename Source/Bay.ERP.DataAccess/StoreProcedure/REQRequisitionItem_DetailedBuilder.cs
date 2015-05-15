// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Jul-2013, 02:38:57




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class REQRequisitionItem_DetailedBuilder : IEntityBuilder<REQRequisitionItem_DetailedEntity>
    {
        IList<REQRequisitionItem_DetailedEntity> IEntityBuilder<REQRequisitionItem_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<REQRequisitionItem_DetailedEntity> REQRequisitionItem_DetailedEntityList = new List<REQRequisitionItem_DetailedEntity>();

            while (reader.Read())
            {
                REQRequisitionItem_DetailedEntityList.Add(((IEntityBuilder<REQRequisitionItem_DetailedEntity>)this).BuildEntity(reader));
            }

            return (REQRequisitionItem_DetailedEntityList.Count > 0) ? REQRequisitionItem_DetailedEntityList : null;
        }

        REQRequisitionItem_DetailedEntity IEntityBuilder<REQRequisitionItem_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_REQUISITIONITEMID = 0;
            const Int32 FLD_REQUISITIONID = 1;
            const Int32 FLD_ACCOUNTSCODE = 2;
            const Int32 FLD_ITEMID = 3;
            const Int32 FLD_RATE = 4;
            const Int32 FLD_TOTALREQUIREDQTY = 5;
            const Int32 FLD_PURCHASEDQTYTILLTODATE = 6;
            const Int32 FLD_PURCHASEDQTYTILLTODATENEW = 7;
            const Int32 FLD_AVAILABLEQTYFORREQISITION = 8;
            const Int32 FLD_PRESENTREQUIREDQTY = 9;
            const Int32 FLD_REQUIREDDATE = 10;
            const Int32 FLD_REMARKS = 11;
            const Int32 FLD_REQREQUISITIONPROJECTID = 12;
            const Int32 FLD_MDITEMITEMNAME = 13;
            const Int32 FLD_ITEMCATEGORYID = 14;
            const Int32 FLD_UNITNAME = 15;
            const Int32 FLD_BRANDID = 16;
            const Int32 FLD_BRANDNAME = 17;
            const Int32 FLD_SUPPLIERID = 18;
            const Int32 FLD_SUPPLIERNAME = 19;
            const Int32 FLD_REGIONID = 20;
            const Int32 FLD_REGIONNAME = 21;
            const Int32 FLD_COUNTRYID = 22;
            const Int32 FLD_COUNTRYNAME = 23;
            const Int32 FLD_CATEGORYNAME = 24;
            const Int32 FLD_PARENTITEMCATEGORYID = 25;
            const Int32 FLD_PARENTCATEGORYNAME = 26;
            const Int32 FLD_ROWNUMBER = 27;

            REQRequisitionItem_DetailedEntity rEQRequisitionItem_DetailedEntity = new REQRequisitionItem_DetailedEntity();

            rEQRequisitionItem_DetailedEntity.RequisitionItemID = reader.GetInt64(FLD_REQUISITIONITEMID);
            rEQRequisitionItem_DetailedEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID);
            rEQRequisitionItem_DetailedEntity.AccountsCode = reader.GetString(FLD_ACCOUNTSCODE);
            rEQRequisitionItem_DetailedEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            rEQRequisitionItem_DetailedEntity.Rate = reader.GetDecimal(FLD_RATE);
            rEQRequisitionItem_DetailedEntity.TotalRequiredQty = reader.GetDecimal(FLD_TOTALREQUIREDQTY);
            if (reader.IsDBNull(FLD_PURCHASEDQTYTILLTODATE)) { rEQRequisitionItem_DetailedEntity.PurchasedQtyTillToDate = null; } else { rEQRequisitionItem_DetailedEntity.PurchasedQtyTillToDate = reader.GetDecimal(FLD_PURCHASEDQTYTILLTODATE); }
            if (reader.IsDBNull(FLD_PURCHASEDQTYTILLTODATENEW)) { rEQRequisitionItem_DetailedEntity.PurchasedQtyTillToDateNew = null; } else { rEQRequisitionItem_DetailedEntity.PurchasedQtyTillToDateNew = reader.GetDecimal(FLD_PURCHASEDQTYTILLTODATENEW); }
            if (reader.IsDBNull(FLD_AVAILABLEQTYFORREQISITION)) { rEQRequisitionItem_DetailedEntity.AvailableQtyForReqisition = null; } else { rEQRequisitionItem_DetailedEntity.AvailableQtyForReqisition = reader.GetDecimal(FLD_AVAILABLEQTYFORREQISITION); }
            rEQRequisitionItem_DetailedEntity.PresentRequiredQty = reader.GetDecimal(FLD_PRESENTREQUIREDQTY);
            rEQRequisitionItem_DetailedEntity.RequiredDate = reader.GetDateTime(FLD_REQUIREDDATE);
            if (reader.IsDBNull(FLD_REMARKS)) { rEQRequisitionItem_DetailedEntity.Remarks = String.Empty; } else { rEQRequisitionItem_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_REQREQUISITIONPROJECTID)) { rEQRequisitionItem_DetailedEntity.REQRequisitionProjectID = null; } else { rEQRequisitionItem_DetailedEntity.REQRequisitionProjectID = reader.GetInt64(FLD_REQREQUISITIONPROJECTID); }
            if (reader.IsDBNull(FLD_MDITEMITEMNAME)) { rEQRequisitionItem_DetailedEntity.MDItemItemName = String.Empty; } else { rEQRequisitionItem_DetailedEntity.MDItemItemName = reader.GetString(FLD_MDITEMITEMNAME); }
            if (reader.IsDBNull(FLD_ITEMCATEGORYID)) { rEQRequisitionItem_DetailedEntity.ItemCategoryID = null; } else { rEQRequisitionItem_DetailedEntity.ItemCategoryID = reader.GetInt64(FLD_ITEMCATEGORYID); }
            if (reader.IsDBNull(FLD_UNITNAME)) { rEQRequisitionItem_DetailedEntity.UnitName = String.Empty; } else { rEQRequisitionItem_DetailedEntity.UnitName = reader.GetString(FLD_UNITNAME); }
            if (reader.IsDBNull(FLD_BRANDID)) { rEQRequisitionItem_DetailedEntity.BrandID = null; } else { rEQRequisitionItem_DetailedEntity.BrandID = reader.GetInt64(FLD_BRANDID); }
            if (reader.IsDBNull(FLD_BRANDNAME)) { rEQRequisitionItem_DetailedEntity.BrandName = String.Empty; } else { rEQRequisitionItem_DetailedEntity.BrandName = reader.GetString(FLD_BRANDNAME); }
            if (reader.IsDBNull(FLD_SUPPLIERID)) { rEQRequisitionItem_DetailedEntity.SupplierID = null; } else { rEQRequisitionItem_DetailedEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID); }
            if (reader.IsDBNull(FLD_SUPPLIERNAME)) { rEQRequisitionItem_DetailedEntity.SupplierName = String.Empty; } else { rEQRequisitionItem_DetailedEntity.SupplierName = reader.GetString(FLD_SUPPLIERNAME); }
            if (reader.IsDBNull(FLD_REGIONID)) { rEQRequisitionItem_DetailedEntity.RegionID = null; } else { rEQRequisitionItem_DetailedEntity.RegionID = reader.GetInt64(FLD_REGIONID); }
            if (reader.IsDBNull(FLD_REGIONNAME)) { rEQRequisitionItem_DetailedEntity.RegionName = String.Empty; } else { rEQRequisitionItem_DetailedEntity.RegionName = reader.GetString(FLD_REGIONNAME); }
            if (reader.IsDBNull(FLD_COUNTRYID)) { rEQRequisitionItem_DetailedEntity.CountryID = null; } else { rEQRequisitionItem_DetailedEntity.CountryID = reader.GetInt64(FLD_COUNTRYID); }
            if (reader.IsDBNull(FLD_COUNTRYNAME)) { rEQRequisitionItem_DetailedEntity.CountryName = String.Empty; } else { rEQRequisitionItem_DetailedEntity.CountryName = reader.GetString(FLD_COUNTRYNAME); }
            if (reader.IsDBNull(FLD_CATEGORYNAME)) { rEQRequisitionItem_DetailedEntity.CategoryName = String.Empty; } else { rEQRequisitionItem_DetailedEntity.CategoryName = reader.GetString(FLD_CATEGORYNAME); }
            if (reader.IsDBNull(FLD_PARENTITEMCATEGORYID)) { rEQRequisitionItem_DetailedEntity.ParentItemCategoryID = null; } else { rEQRequisitionItem_DetailedEntity.ParentItemCategoryID = reader.GetInt64(FLD_PARENTITEMCATEGORYID); }
            if (reader.IsDBNull(FLD_PARENTCATEGORYNAME)) { rEQRequisitionItem_DetailedEntity.ParentCategoryName = String.Empty; } else { rEQRequisitionItem_DetailedEntity.ParentCategoryName = reader.GetString(FLD_PARENTCATEGORYNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { rEQRequisitionItem_DetailedEntity.RowNumber = null; } else { rEQRequisitionItem_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return rEQRequisitionItem_DetailedEntity;
        }
    }
}
