// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-Sep-2013, 02:13:02




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMWorkOrder_RPTBuilder : IEntityBuilder<PRMWorkOrder_RPTEntity>
    {
        IList<PRMWorkOrder_RPTEntity> IEntityBuilder<PRMWorkOrder_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMWorkOrder_RPTEntity> PRMWorkOrder_RPTEntityList = new List<PRMWorkOrder_RPTEntity>();

            while (reader.Read())
            {
                PRMWorkOrder_RPTEntityList.Add(((IEntityBuilder<PRMWorkOrder_RPTEntity>)this).BuildEntity(reader));
            }

            return (PRMWorkOrder_RPTEntityList.Count > 0) ? PRMWorkOrder_RPTEntityList : null;
        }

        PRMWorkOrder_RPTEntity IEntityBuilder<PRMWorkOrder_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_WORKORDERID = 0;
            const Int32 FLD_SUPPLIERID = 1;
            const Int32 FLD_WORKORDERNO = 2;
            const Int32 FLD_ATTENTIONID = 3;
            const Int32 FLD_OTHERATTENTION = 4;
            const Int32 FLD_CREATEDATE = 5;
            const Int32 FLD_SUBJECT = 6;
            const Int32 FLD_BODYTITLE = 7;
            const Int32 FLD_STARTDATE = 8;
            const Int32 FLD_COMPLETIONDATE = 9;
            const Int32 FLD_WARRANTY = 10;
            const Int32 FLD_DELAYCHARGE = 11;
            const Int32 FLD_ROWTEXT = 12;
            const Int32 FLD_REMARKS = 13;
            const Int32 FLD_FOOTNOTE = 14;
            const Int32 FLD_PREPAREDBYID = 15;
            const Int32 FLD_ISFINALBILLED = 16;
            const Int32 FLD_VAT = 17;
            const Int32 FLD_TAX = 18;
            const Int32 FLD_CARRYINGCHARGE = 19;
            const Int32 FLD_DISCOUNT = 20;
            const Int32 FLD_AIT = 21;
            const Int32 FLD_GRANDTOTAL = 22;
            const Int32 FLD_WORKORDERSTATUS = 23;
            const Int32 FLD_WORKORDERITEMMAPID = 24;
            const Int32 FLD_REQUISITIONID = 25;
            const Int32 FLD_REQUISITIONITEMID = 26;
            const Int32 FLD_REQUIREDQTY = 27;
            const Int32 FLD_RATE = 28;
            const Int32 FLD_DELIVERYADDRESS = 29;
            const Int32 FLD_ITEMDESCRIPTION = 30;
            const Int32 FLD_WORKORDERITEMMAPSTATUS = 31;
            const Int32 FLD_SUPPLIERCODE = 32;
            const Int32 FLD_SUPPLIERNAME = 33;
            const Int32 FLD_RELATIONSHIP = 34;
            const Int32 FLD_PHONE = 35;
            const Int32 FLD_MOBILENO = 36;
            const Int32 FLD_FAX = 37;
            const Int32 FLD_EMAIL = 38;
            const Int32 FLD_WEBLINK = 39;
            const Int32 FLD_REQUISITIONNO = 40;
            const Int32 FLD_ITEMNAME = 41;
            const Int32 FLD_ORIGINBRANDNAME = 42;
            const Int32 FLD_ORIGINSUPPLIERNAME = 43;
            const Int32 FLD_ORIGINREGIONNAME = 44;
            const Int32 FLD_ORIGINCOUNTRYNAME = 45;
            const Int32 FLD_ATTENTION = 46;
            const Int32 FLD_PREPAREDBYFULLNAME = 47;
            const Int32 FLD_MDWORKORDERSTATUS = 48;
            const Int32 FLD_MDWORKORDERITEMMAPSTATUS = 49;
            const Int32 FLD_ADDRESSLINE1 = 50;
            const Int32 FLD_ADDRESSLINE2 = 51;
            const Int32 FLD_UNITNAME = 52;
            const Int32 FLD_ROWNUMBER = 53;

            PRMWorkOrder_RPTEntity pRMWorkOrder_RPTEntity = new PRMWorkOrder_RPTEntity();

            pRMWorkOrder_RPTEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID);
            pRMWorkOrder_RPTEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);
            pRMWorkOrder_RPTEntity.WorkOrderNo = reader.GetString(FLD_WORKORDERNO);
            if (reader.IsDBNull(FLD_ATTENTIONID)) { pRMWorkOrder_RPTEntity.AttentionID = null; } else { pRMWorkOrder_RPTEntity.AttentionID = reader.GetInt64(FLD_ATTENTIONID); }
            if (reader.IsDBNull(FLD_OTHERATTENTION)) { pRMWorkOrder_RPTEntity.OtherAttention = String.Empty; } else { pRMWorkOrder_RPTEntity.OtherAttention = reader.GetString(FLD_OTHERATTENTION); }
            pRMWorkOrder_RPTEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            pRMWorkOrder_RPTEntity.Subject = reader.GetString(FLD_SUBJECT);
            pRMWorkOrder_RPTEntity.BodyTitle = reader.GetString(FLD_BODYTITLE);
            pRMWorkOrder_RPTEntity.StartDate = reader.GetDateTime(FLD_STARTDATE);
            pRMWorkOrder_RPTEntity.CompletionDate = reader.GetDateTime(FLD_COMPLETIONDATE);
            if (reader.IsDBNull(FLD_WARRANTY)) { pRMWorkOrder_RPTEntity.Warranty = String.Empty; } else { pRMWorkOrder_RPTEntity.Warranty = reader.GetString(FLD_WARRANTY); }
            if (reader.IsDBNull(FLD_DELAYCHARGE)) { pRMWorkOrder_RPTEntity.DelayCharge = String.Empty; } else { pRMWorkOrder_RPTEntity.DelayCharge = reader.GetString(FLD_DELAYCHARGE); }
            if (reader.IsDBNull(FLD_ROWTEXT)) { pRMWorkOrder_RPTEntity.RowText = String.Empty; } else { pRMWorkOrder_RPTEntity.RowText = reader.GetString(FLD_ROWTEXT); }
            if (reader.IsDBNull(FLD_REMARKS)) { pRMWorkOrder_RPTEntity.Remarks = String.Empty; } else { pRMWorkOrder_RPTEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_FOOTNOTE)) { pRMWorkOrder_RPTEntity.FootNote = String.Empty; } else { pRMWorkOrder_RPTEntity.FootNote = reader.GetString(FLD_FOOTNOTE); }
            pRMWorkOrder_RPTEntity.PreparedByID = reader.GetInt64(FLD_PREPAREDBYID);
            pRMWorkOrder_RPTEntity.IsFinalBilled = reader.GetBoolean(FLD_ISFINALBILLED);
            if (reader.IsDBNull(FLD_VAT)) { pRMWorkOrder_RPTEntity.VAT = null; } else { pRMWorkOrder_RPTEntity.VAT = reader.GetDecimal(FLD_VAT); }
            if (reader.IsDBNull(FLD_TAX)) { pRMWorkOrder_RPTEntity.Tax = null; } else { pRMWorkOrder_RPTEntity.Tax = reader.GetDecimal(FLD_TAX); }
            if (reader.IsDBNull(FLD_CARRYINGCHARGE)) { pRMWorkOrder_RPTEntity.CarryingCharge = null; } else { pRMWorkOrder_RPTEntity.CarryingCharge = reader.GetDecimal(FLD_CARRYINGCHARGE); }
            if (reader.IsDBNull(FLD_DISCOUNT)) { pRMWorkOrder_RPTEntity.Discount = null; } else { pRMWorkOrder_RPTEntity.Discount = reader.GetDecimal(FLD_DISCOUNT); }
            if (reader.IsDBNull(FLD_AIT)) { pRMWorkOrder_RPTEntity.AIT = null; } else { pRMWorkOrder_RPTEntity.AIT = reader.GetDecimal(FLD_AIT); }
            if (reader.IsDBNull(FLD_GRANDTOTAL)) { pRMWorkOrder_RPTEntity.GrandTotal = null; } else { pRMWorkOrder_RPTEntity.GrandTotal = reader.GetDecimal(FLD_GRANDTOTAL); }
            pRMWorkOrder_RPTEntity.WorkOrderStatus = reader.GetInt64(FLD_WORKORDERSTATUS);
            if (reader.IsDBNull(FLD_WORKORDERITEMMAPID)) { pRMWorkOrder_RPTEntity.WorkOrderItemMapID = null; } else { pRMWorkOrder_RPTEntity.WorkOrderItemMapID = reader.GetInt64(FLD_WORKORDERITEMMAPID); }
            if (reader.IsDBNull(FLD_REQUISITIONID)) { pRMWorkOrder_RPTEntity.RequisitionID = null; } else { pRMWorkOrder_RPTEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID); }
            if (reader.IsDBNull(FLD_REQUISITIONITEMID)) { pRMWorkOrder_RPTEntity.RequisitionItemID = null; } else { pRMWorkOrder_RPTEntity.RequisitionItemID = reader.GetInt64(FLD_REQUISITIONITEMID); }
            if (reader.IsDBNull(FLD_REQUIREDQTY)) { pRMWorkOrder_RPTEntity.RequiredQty = null; } else { pRMWorkOrder_RPTEntity.RequiredQty = reader.GetDecimal(FLD_REQUIREDQTY); }
            if (reader.IsDBNull(FLD_RATE)) { pRMWorkOrder_RPTEntity.Rate = null; } else { pRMWorkOrder_RPTEntity.Rate = reader.GetDecimal(FLD_RATE); }
            if (reader.IsDBNull(FLD_DELIVERYADDRESS)) { pRMWorkOrder_RPTEntity.DeliveryAddress = String.Empty; } else { pRMWorkOrder_RPTEntity.DeliveryAddress = reader.GetString(FLD_DELIVERYADDRESS); }
            if (reader.IsDBNull(FLD_ITEMDESCRIPTION)) { pRMWorkOrder_RPTEntity.ItemDescription = String.Empty; } else { pRMWorkOrder_RPTEntity.ItemDescription = reader.GetString(FLD_ITEMDESCRIPTION); }
            if (reader.IsDBNull(FLD_WORKORDERITEMMAPSTATUS)) { pRMWorkOrder_RPTEntity.WorkOrderItemMapStatus = null; } else { pRMWorkOrder_RPTEntity.WorkOrderItemMapStatus = reader.GetInt64(FLD_WORKORDERITEMMAPSTATUS); }
            if (reader.IsDBNull(FLD_SUPPLIERCODE)) { pRMWorkOrder_RPTEntity.SupplierCode = String.Empty; } else { pRMWorkOrder_RPTEntity.SupplierCode = reader.GetString(FLD_SUPPLIERCODE); }
            pRMWorkOrder_RPTEntity.SupplierName = reader.GetString(FLD_SUPPLIERNAME);
            if (reader.IsDBNull(FLD_RELATIONSHIP)) { pRMWorkOrder_RPTEntity.Relationship = String.Empty; } else { pRMWorkOrder_RPTEntity.Relationship = reader.GetString(FLD_RELATIONSHIP); }
            if (reader.IsDBNull(FLD_PHONE)) { pRMWorkOrder_RPTEntity.Phone = String.Empty; } else { pRMWorkOrder_RPTEntity.Phone = reader.GetString(FLD_PHONE); }
            if (reader.IsDBNull(FLD_MOBILENO)) { pRMWorkOrder_RPTEntity.MobileNo = String.Empty; } else { pRMWorkOrder_RPTEntity.MobileNo = reader.GetString(FLD_MOBILENO); }
            if (reader.IsDBNull(FLD_FAX)) { pRMWorkOrder_RPTEntity.Fax = String.Empty; } else { pRMWorkOrder_RPTEntity.Fax = reader.GetString(FLD_FAX); }
            if (reader.IsDBNull(FLD_EMAIL)) { pRMWorkOrder_RPTEntity.Email = String.Empty; } else { pRMWorkOrder_RPTEntity.Email = reader.GetString(FLD_EMAIL); }
            if (reader.IsDBNull(FLD_WEBLINK)) { pRMWorkOrder_RPTEntity.WebLink = String.Empty; } else { pRMWorkOrder_RPTEntity.WebLink = reader.GetString(FLD_WEBLINK); }
            if (reader.IsDBNull(FLD_REQUISITIONNO)) { pRMWorkOrder_RPTEntity.RequisitionNo = String.Empty; } else { pRMWorkOrder_RPTEntity.RequisitionNo = reader.GetString(FLD_REQUISITIONNO); }
            if (reader.IsDBNull(FLD_ITEMNAME)) { pRMWorkOrder_RPTEntity.ItemName = String.Empty; } else { pRMWorkOrder_RPTEntity.ItemName = reader.GetString(FLD_ITEMNAME); }
            if (reader.IsDBNull(FLD_ORIGINBRANDNAME)) { pRMWorkOrder_RPTEntity.OriginBrandName = String.Empty; } else { pRMWorkOrder_RPTEntity.OriginBrandName = reader.GetString(FLD_ORIGINBRANDNAME); }
            if (reader.IsDBNull(FLD_ORIGINSUPPLIERNAME)) { pRMWorkOrder_RPTEntity.OriginSupplierName = String.Empty; } else { pRMWorkOrder_RPTEntity.OriginSupplierName = reader.GetString(FLD_ORIGINSUPPLIERNAME); }
            if (reader.IsDBNull(FLD_ORIGINREGIONNAME)) { pRMWorkOrder_RPTEntity.OriginRegionName = String.Empty; } else { pRMWorkOrder_RPTEntity.OriginRegionName = reader.GetString(FLD_ORIGINREGIONNAME); }
            if (reader.IsDBNull(FLD_ORIGINCOUNTRYNAME)) { pRMWorkOrder_RPTEntity.OriginCountryName = String.Empty; } else { pRMWorkOrder_RPTEntity.OriginCountryName = reader.GetString(FLD_ORIGINCOUNTRYNAME); }
            if (reader.IsDBNull(FLD_ATTENTION)) { pRMWorkOrder_RPTEntity.Attention = String.Empty; } else { pRMWorkOrder_RPTEntity.Attention = reader.GetString(FLD_ATTENTION); }
            if (reader.IsDBNull(FLD_PREPAREDBYFULLNAME)) { pRMWorkOrder_RPTEntity.PreparedByFullName = String.Empty; } else { pRMWorkOrder_RPTEntity.PreparedByFullName = reader.GetString(FLD_PREPAREDBYFULLNAME); }
            if (reader.IsDBNull(FLD_MDWORKORDERSTATUS)) { pRMWorkOrder_RPTEntity.MDWorkOrderStatus = String.Empty; } else { pRMWorkOrder_RPTEntity.MDWorkOrderStatus = reader.GetString(FLD_MDWORKORDERSTATUS); }
            if (reader.IsDBNull(FLD_MDWORKORDERITEMMAPSTATUS)) { pRMWorkOrder_RPTEntity.MDWorkOrderItemMapStatus = String.Empty; } else { pRMWorkOrder_RPTEntity.MDWorkOrderItemMapStatus = reader.GetString(FLD_MDWORKORDERITEMMAPSTATUS); }
            if (reader.IsDBNull(FLD_ADDRESSLINE1)) { pRMWorkOrder_RPTEntity.AddressLine1 = String.Empty; } else { pRMWorkOrder_RPTEntity.AddressLine1 = reader.GetString(FLD_ADDRESSLINE1); }
            if (reader.IsDBNull(FLD_ADDRESSLINE2)) { pRMWorkOrder_RPTEntity.AddressLine2 = String.Empty; } else { pRMWorkOrder_RPTEntity.AddressLine2 = reader.GetString(FLD_ADDRESSLINE2); }
            if (reader.IsDBNull(FLD_UNITNAME)) { pRMWorkOrder_RPTEntity.UnitName = String.Empty; } else { pRMWorkOrder_RPTEntity.UnitName = reader.GetString(FLD_UNITNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { pRMWorkOrder_RPTEntity.RowNumber = null; } else { pRMWorkOrder_RPTEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return pRMWorkOrder_RPTEntity;
        }
    }
}
