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
    internal sealed class CRMAdvertisementRequisition_RPTBuilder : IEntityBuilder<CRMAdvertisementRequisition_RPTEntity>
    {
        IList<CRMAdvertisementRequisition_RPTEntity> IEntityBuilder<CRMAdvertisementRequisition_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMAdvertisementRequisition_RPTEntity> CRMAdvertisementRequisition_RPTEntityList = new List<CRMAdvertisementRequisition_RPTEntity>();

            while (reader.Read())
            {
                CRMAdvertisementRequisition_RPTEntityList.Add(((IEntityBuilder<CRMAdvertisementRequisition_RPTEntity>)this).BuildEntity(reader));
            }

            return (CRMAdvertisementRequisition_RPTEntityList.Count > 0) ? CRMAdvertisementRequisition_RPTEntityList : null;
        }

        CRMAdvertisementRequisition_RPTEntity IEntityBuilder<CRMAdvertisementRequisition_RPTEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_DISCOUNTPERCENTAGE = 34;
            const Int32 FLD_ACTUALPRICE = 35;

            CRMAdvertisementRequisition_RPTEntity cRMAdvertisementRequisition_RPTEntity = new CRMAdvertisementRequisition_RPTEntity();

            cRMAdvertisementRequisition_RPTEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID);
            cRMAdvertisementRequisition_RPTEntity.RequisitionNo = reader.GetString(FLD_REQUISITIONNO);
            cRMAdvertisementRequisition_RPTEntity.RequisitionDate = reader.GetDateTime(FLD_REQUISITIONDATE);
            cRMAdvertisementRequisition_RPTEntity.RequisitionStatusID = reader.GetInt64(FLD_REQUISITIONSTATUSID);
            cRMAdvertisementRequisition_RPTEntity.PreparedByMemberID = reader.GetInt64(FLD_PREPAREDBYMEMBERID);
            if (reader.IsDBNull(FLD_INITIATEDBY)) { cRMAdvertisementRequisition_RPTEntity.InitiatedBy = String.Empty; } else { cRMAdvertisementRequisition_RPTEntity.InitiatedBy = reader.GetString(FLD_INITIATEDBY); }
            if (reader.IsDBNull(FLD_REMARKS)) { cRMAdvertisementRequisition_RPTEntity.Remarks = String.Empty; } else { cRMAdvertisementRequisition_RPTEntity.Remarks = reader.GetString(FLD_REMARKS); }
            cRMAdvertisementRequisition_RPTEntity.IsCashPayment = reader.GetBoolean(FLD_ISCASHPAYMENT);
            cRMAdvertisementRequisition_RPTEntity.IsRCS = reader.GetBoolean(FLD_ISRCS);
            if (reader.IsDBNull(FLD_ACCOUNTSCODE)) { cRMAdvertisementRequisition_RPTEntity.accountsCode = String.Empty; } else { cRMAdvertisementRequisition_RPTEntity.accountsCode = reader.GetString(FLD_ACCOUNTSCODE); }
            cRMAdvertisementRequisition_RPTEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            if (reader.IsDBNull(FLD_ITEMCATEGORY)) { cRMAdvertisementRequisition_RPTEntity.ItemCategory = String.Empty; } else { cRMAdvertisementRequisition_RPTEntity.ItemCategory = reader.GetString(FLD_ITEMCATEGORY); }
            if (reader.IsDBNull(FLD_ITEMNAME)) { cRMAdvertisementRequisition_RPTEntity.ItemName = String.Empty; } else { cRMAdvertisementRequisition_RPTEntity.ItemName = reader.GetString(FLD_ITEMNAME); }
            if (reader.IsDBNull(FLD_UNITNAME)) { cRMAdvertisementRequisition_RPTEntity.UnitName = String.Empty; } else { cRMAdvertisementRequisition_RPTEntity.UnitName = reader.GetString(FLD_UNITNAME); }
            if (reader.IsDBNull(FLD_REQUISITIONITEMID)) { cRMAdvertisementRequisition_RPTEntity.RequisitionItemID = null; } else { cRMAdvertisementRequisition_RPTEntity.RequisitionItemID = reader.GetInt64(FLD_REQUISITIONITEMID); }
            if (reader.IsDBNull(FLD_ITEMID)) { cRMAdvertisementRequisition_RPTEntity.ItemID = null; } else { cRMAdvertisementRequisition_RPTEntity.ItemID = reader.GetInt64(FLD_ITEMID); }
            if (reader.IsDBNull(FLD_TOTALREQUIREDQTYFROMBOQORPROJECTCOST)) { cRMAdvertisementRequisition_RPTEntity.TotalRequiredQtyFromBOQorProjectCost = null; } else { cRMAdvertisementRequisition_RPTEntity.TotalRequiredQtyFromBOQorProjectCost = reader.GetDecimal(FLD_TOTALREQUIREDQTYFROMBOQORPROJECTCOST); }
            if (reader.IsDBNull(FLD_TOTALREQUIREDQTY)) { cRMAdvertisementRequisition_RPTEntity.TotalRequiredQty = null; } else { cRMAdvertisementRequisition_RPTEntity.TotalRequiredQty = reader.GetDecimal(FLD_TOTALREQUIREDQTY); }
            if (reader.IsDBNull(FLD_PURCHASEDQTYTILLTODATE)) { cRMAdvertisementRequisition_RPTEntity.PurchasedQtyTillToDate = null; } else { cRMAdvertisementRequisition_RPTEntity.PurchasedQtyTillToDate = reader.GetDecimal(FLD_PURCHASEDQTYTILLTODATE); }
            if (reader.IsDBNull(FLD_PURCHASEDQTYTILLTODATENEW)) { cRMAdvertisementRequisition_RPTEntity.PurchasedQtyTillToDateNew = null; } else { cRMAdvertisementRequisition_RPTEntity.PurchasedQtyTillToDateNew = reader.GetDecimal(FLD_PURCHASEDQTYTILLTODATENEW); }
            if (reader.IsDBNull(FLD_PRESENTREQUIREDQTY)) { cRMAdvertisementRequisition_RPTEntity.PresentRequiredQty = null; } else { cRMAdvertisementRequisition_RPTEntity.PresentRequiredQty = reader.GetDecimal(FLD_PRESENTREQUIREDQTY); }
            if (reader.IsDBNull(FLD_RATE)) { cRMAdvertisementRequisition_RPTEntity.Rate = null; } else { cRMAdvertisementRequisition_RPTEntity.Rate = reader.GetDecimal(FLD_RATE); }
            if (reader.IsDBNull(FLD_REQUIREDDATE)) { cRMAdvertisementRequisition_RPTEntity.RequiredDate = null; } else { cRMAdvertisementRequisition_RPTEntity.RequiredDate = reader.GetDateTime(FLD_REQUIREDDATE); }
            if (reader.IsDBNull(FLD_BRANDID)) { cRMAdvertisementRequisition_RPTEntity.BrandID = null; } else { cRMAdvertisementRequisition_RPTEntity.BrandID = reader.GetInt64(FLD_BRANDID); }
            if (reader.IsDBNull(FLD_SUPPLIERID)) { cRMAdvertisementRequisition_RPTEntity.SupplierID = null; } else { cRMAdvertisementRequisition_RPTEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID); }
            if (reader.IsDBNull(FLD_REGIONID)) { cRMAdvertisementRequisition_RPTEntity.RegionID = null; } else { cRMAdvertisementRequisition_RPTEntity.RegionID = reader.GetInt64(FLD_REGIONID); }
            if (reader.IsDBNull(FLD_COUNTRYID)) { cRMAdvertisementRequisition_RPTEntity.CountryID = null; } else { cRMAdvertisementRequisition_RPTEntity.CountryID = reader.GetInt64(FLD_COUNTRYID); }
            if (reader.IsDBNull(FLD_REQUISITIONITEMREMARKS)) { cRMAdvertisementRequisition_RPTEntity.RequisitionItemRemarks = String.Empty; } else { cRMAdvertisementRequisition_RPTEntity.RequisitionItemRemarks = reader.GetString(FLD_REQUISITIONITEMREMARKS); }
            cRMAdvertisementRequisition_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE);
            cRMAdvertisementRequisition_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME);
            if (reader.IsDBNull(FLD_PARENTITEMCATEGORYID)) { cRMAdvertisementRequisition_RPTEntity.ParentItemCategoryID = null; } else { cRMAdvertisementRequisition_RPTEntity.ParentItemCategoryID = reader.GetInt64(FLD_PARENTITEMCATEGORYID); }
            if (reader.IsDBNull(FLD_BRANDNAME)) { cRMAdvertisementRequisition_RPTEntity.BrandName = String.Empty; } else { cRMAdvertisementRequisition_RPTEntity.BrandName = reader.GetString(FLD_BRANDNAME); }
            if (reader.IsDBNull(FLD_ORIGINREGIONNAME)) { cRMAdvertisementRequisition_RPTEntity.OriginRegionName = String.Empty; } else { cRMAdvertisementRequisition_RPTEntity.OriginRegionName = reader.GetString(FLD_ORIGINREGIONNAME); }
            if (reader.IsDBNull(FLD_ORIGINCOUNTRYNAME)) { cRMAdvertisementRequisition_RPTEntity.OriginCountryName = String.Empty; } else { cRMAdvertisementRequisition_RPTEntity.OriginCountryName = reader.GetString(FLD_ORIGINCOUNTRYNAME); }
            if (reader.IsDBNull(FLD_DISCOUNTPERCENTAGE)) { cRMAdvertisementRequisition_RPTEntity.DiscountPercentage = String.Empty; } else { cRMAdvertisementRequisition_RPTEntity.DiscountPercentage = reader.GetString(FLD_DISCOUNTPERCENTAGE); }
            cRMAdvertisementRequisition_RPTEntity.ActualPrice = reader.GetDecimal(FLD_ACTUALPRICE);

            return cRMAdvertisementRequisition_RPTEntity;
        }
    }
}
