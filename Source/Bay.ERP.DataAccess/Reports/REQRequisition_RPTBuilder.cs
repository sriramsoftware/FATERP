// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Oct-2013, 10:33:28




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class REQRequisition_RPTBuilder : IEntityBuilder<REQRequisition_RPTEntity>
    {
        IList<REQRequisition_RPTEntity> IEntityBuilder<REQRequisition_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<REQRequisition_RPTEntity> REQRequisition_RPTEntityList = new List<REQRequisition_RPTEntity>();

            while (reader.Read())
            {
                REQRequisition_RPTEntityList.Add(((IEntityBuilder<REQRequisition_RPTEntity>)this).BuildEntity(reader));
            }

            return (REQRequisition_RPTEntityList.Count > 0) ? REQRequisition_RPTEntityList : null;
        }

        REQRequisition_RPTEntity IEntityBuilder<REQRequisition_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_REQUISITIONID = 0;
            const Int32 FLD_REQUISITIONNO = 1;
            const Int32 FLD_REQUISITIONDATE = 2;
            const Int32 FLD_REQUISITIONSTATUSID = 3;
            const Int32 FLD_PREPAREDBYMEMBERID = 4;
            const Int32 FLD_INITIATEDBY = 5;
            const Int32 FLD_REMARKS = 6;
            const Int32 FLD_ISCASHPAYMENT = 7;
            const Int32 FLD_ISRCS = 8;
            const Int32 FLD_ACCOUNTSCODE = 9;
            const Int32 FLD_PROJECTID = 10;
            const Int32 FLD_ITEMCATEGORY = 11;
            const Int32 FLD_ITEMNAME = 12;
            const Int32 FLD_UNITNAME = 13;
            const Int32 FLD_REQUISITIONITEMID = 14;
            const Int32 FLD_ITEMID = 15;
            const Int32 FLD_TOTALREQUIREDQTYFROMBOQORPROJECTCOST = 16;
            const Int32 FLD_TOTALREQUIREDQTY = 17;
            const Int32 FLD_PURCHASEDQTYTILLTODATE = 18;
            const Int32 FLD_PURCHASEDQTYTILLTODATENEW = 19;
            const Int32 FLD_PRESENTREQUIREDQTY = 20;
            const Int32 FLD_RATE = 21;
            const Int32 FLD_REQUIREDDATE = 22;
            const Int32 FLD_BRANDID = 23;
            const Int32 FLD_SUPPLIERID = 24;
            const Int32 FLD_REGIONID = 25;
            const Int32 FLD_COUNTRYID = 26;
            const Int32 FLD_REQUISITIONITEMREMARKS = 27;
            const Int32 FLD_PROJECTCODE = 28;
            const Int32 FLD_PROJECTNAME = 29;
            const Int32 FLD_PARENTITEMCATEGORYID = 30;
            const Int32 FLD_BRANDNAME = 31;
            const Int32 FLD_ORIGINREGIONNAME = 32;
            const Int32 FLD_ORIGINCOUNTRYNAME = 33;

            REQRequisition_RPTEntity rEQRequisition_RPTEntity = new REQRequisition_RPTEntity();

            rEQRequisition_RPTEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID);
            rEQRequisition_RPTEntity.RequisitionNo = reader.GetString(FLD_REQUISITIONNO);
            rEQRequisition_RPTEntity.RequisitionDate = reader.GetDateTime(FLD_REQUISITIONDATE);
            rEQRequisition_RPTEntity.RequisitionStatusID = reader.GetInt64(FLD_REQUISITIONSTATUSID);
            rEQRequisition_RPTEntity.PreparedByMemberID = reader.GetInt64(FLD_PREPAREDBYMEMBERID);
            if (reader.IsDBNull(FLD_INITIATEDBY)) { rEQRequisition_RPTEntity.InitiatedBy = String.Empty; } else { rEQRequisition_RPTEntity.InitiatedBy = reader.GetString(FLD_INITIATEDBY); }
            if (reader.IsDBNull(FLD_REMARKS)) { rEQRequisition_RPTEntity.Remarks = String.Empty; } else { rEQRequisition_RPTEntity.Remarks = reader.GetString(FLD_REMARKS); }
            rEQRequisition_RPTEntity.IsCashPayment = reader.GetBoolean(FLD_ISCASHPAYMENT);
            rEQRequisition_RPTEntity.IsRCS = reader.GetBoolean(FLD_ISRCS);
            if (reader.IsDBNull(FLD_ACCOUNTSCODE)) { rEQRequisition_RPTEntity.accountsCode = String.Empty; } else { rEQRequisition_RPTEntity.accountsCode = reader.GetString(FLD_ACCOUNTSCODE); }
            rEQRequisition_RPTEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            if (reader.IsDBNull(FLD_ITEMCATEGORY)) { rEQRequisition_RPTEntity.ItemCategory = String.Empty; } else { rEQRequisition_RPTEntity.ItemCategory = reader.GetString(FLD_ITEMCATEGORY); }
            if (reader.IsDBNull(FLD_ITEMNAME)) { rEQRequisition_RPTEntity.ItemName = String.Empty; } else { rEQRequisition_RPTEntity.ItemName = reader.GetString(FLD_ITEMNAME); }
            if (reader.IsDBNull(FLD_UNITNAME)) { rEQRequisition_RPTEntity.UnitName = String.Empty; } else { rEQRequisition_RPTEntity.UnitName = reader.GetString(FLD_UNITNAME); }
            if (reader.IsDBNull(FLD_REQUISITIONITEMID)) { rEQRequisition_RPTEntity.RequisitionItemID = null; } else { rEQRequisition_RPTEntity.RequisitionItemID = reader.GetInt64(FLD_REQUISITIONITEMID); }
            if (reader.IsDBNull(FLD_ITEMID)) { rEQRequisition_RPTEntity.ItemID = null; } else { rEQRequisition_RPTEntity.ItemID = reader.GetInt64(FLD_ITEMID); }
            if (reader.IsDBNull(FLD_TOTALREQUIREDQTYFROMBOQORPROJECTCOST)) { rEQRequisition_RPTEntity.TotalRequiredQtyFromBOQorProjectCost = null; } else { rEQRequisition_RPTEntity.TotalRequiredQtyFromBOQorProjectCost = reader.GetDecimal(FLD_TOTALREQUIREDQTYFROMBOQORPROJECTCOST); }
            if (reader.IsDBNull(FLD_TOTALREQUIREDQTY)) { rEQRequisition_RPTEntity.TotalRequiredQty = null; } else { rEQRequisition_RPTEntity.TotalRequiredQty = reader.GetDecimal(FLD_TOTALREQUIREDQTY); }
            if (reader.IsDBNull(FLD_PURCHASEDQTYTILLTODATE)) { rEQRequisition_RPTEntity.PurchasedQtyTillToDate = null; } else { rEQRequisition_RPTEntity.PurchasedQtyTillToDate = reader.GetDecimal(FLD_PURCHASEDQTYTILLTODATE); }
            if (reader.IsDBNull(FLD_PURCHASEDQTYTILLTODATENEW)) { rEQRequisition_RPTEntity.PurchasedQtyTillToDateNew = null; } else { rEQRequisition_RPTEntity.PurchasedQtyTillToDateNew = reader.GetDecimal(FLD_PURCHASEDQTYTILLTODATENEW); }
            if (reader.IsDBNull(FLD_PRESENTREQUIREDQTY)) { rEQRequisition_RPTEntity.PresentRequiredQty = null; } else { rEQRequisition_RPTEntity.PresentRequiredQty = reader.GetDecimal(FLD_PRESENTREQUIREDQTY); }
            if (reader.IsDBNull(FLD_RATE)) { rEQRequisition_RPTEntity.Rate = null; } else { rEQRequisition_RPTEntity.Rate = reader.GetDecimal(FLD_RATE); }
            if (reader.IsDBNull(FLD_REQUIREDDATE)) { rEQRequisition_RPTEntity.RequiredDate = null; } else { rEQRequisition_RPTEntity.RequiredDate = reader.GetDateTime(FLD_REQUIREDDATE); }
            if (reader.IsDBNull(FLD_BRANDID)) { rEQRequisition_RPTEntity.BrandID = null; } else { rEQRequisition_RPTEntity.BrandID = reader.GetInt64(FLD_BRANDID); }
            if (reader.IsDBNull(FLD_SUPPLIERID)) { rEQRequisition_RPTEntity.SupplierID = null; } else { rEQRequisition_RPTEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID); }
            if (reader.IsDBNull(FLD_REGIONID)) { rEQRequisition_RPTEntity.RegionID = null; } else { rEQRequisition_RPTEntity.RegionID = reader.GetInt64(FLD_REGIONID); }
            if (reader.IsDBNull(FLD_COUNTRYID)) { rEQRequisition_RPTEntity.CountryID = null; } else { rEQRequisition_RPTEntity.CountryID = reader.GetInt64(FLD_COUNTRYID); }
            if (reader.IsDBNull(FLD_REQUISITIONITEMREMARKS)) { rEQRequisition_RPTEntity.RequisitionItemRemarks = String.Empty; } else { rEQRequisition_RPTEntity.RequisitionItemRemarks = reader.GetString(FLD_REQUISITIONITEMREMARKS); }
            rEQRequisition_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE);
            rEQRequisition_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME);
            if (reader.IsDBNull(FLD_PARENTITEMCATEGORYID)) { rEQRequisition_RPTEntity.ParentItemCategoryID = null; } else { rEQRequisition_RPTEntity.ParentItemCategoryID = reader.GetInt64(FLD_PARENTITEMCATEGORYID); }
            if (reader.IsDBNull(FLD_BRANDNAME)) { rEQRequisition_RPTEntity.BrandName = String.Empty; } else { rEQRequisition_RPTEntity.BrandName = reader.GetString(FLD_BRANDNAME); }
            if (reader.IsDBNull(FLD_ORIGINREGIONNAME)) { rEQRequisition_RPTEntity.OriginRegionName = String.Empty; } else { rEQRequisition_RPTEntity.OriginRegionName = reader.GetString(FLD_ORIGINREGIONNAME); }
            if (reader.IsDBNull(FLD_ORIGINCOUNTRYNAME)) { rEQRequisition_RPTEntity.OriginCountryName = String.Empty; } else { rEQRequisition_RPTEntity.OriginCountryName = reader.GetString(FLD_ORIGINCOUNTRYNAME); }

            return rEQRequisition_RPTEntity;
        }
    }
}
