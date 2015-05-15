// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Dec-2012, 11:55:46




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACCPrePayableStatementDetailBuilder : IEntityBuilder<ACCPrePayableStatementDetailEntity>
    {
        IList<ACCPrePayableStatementDetailEntity> IEntityBuilder<ACCPrePayableStatementDetailEntity>.BuildEntities(IDataReader reader)
        {
            List<ACCPrePayableStatementDetailEntity> ACCPrePayableStatementDetailEntityList = new List<ACCPrePayableStatementDetailEntity>();

            while (reader.Read())
            {
                ACCPrePayableStatementDetailEntityList.Add(((IEntityBuilder<ACCPrePayableStatementDetailEntity>)this).BuildEntity(reader));
            }

            return (ACCPrePayableStatementDetailEntityList.Count > 0) ? ACCPrePayableStatementDetailEntityList : null;
        }

        ACCPrePayableStatementDetailEntity IEntityBuilder<ACCPrePayableStatementDetailEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PREPAYABLESTATEMENTDETAILID = 0;
            const Int32 FLD_PREPAYABLESTATEMENTID = 1;
            const Int32 FLD_PROJECTID = 2;
            const Int32 FLD_PROJECTCODE = 3;
            const Int32 FLD_WORKORDERID = 4;
            const Int32 FLD_WORKORDERNO = 5;
            const Int32 FLD_WORKORDERAMOUNT = 6;
            const Int32 FLD_WORKORDERDATE = 7;
            const Int32 FLD_PAIDAMOUNT = 8;
            const Int32 FLD_SECURITYMONEY = 9;
            const Int32 FLD_TDSAMOUNT = 10;
            const Int32 FLD_PAYABLEAGAINSTWORKORDER = 11;
            const Int32 FLD_APPROVEDBILLAMOUNT = 12;
            const Int32 FLD_NETPAYABLECONSIDERINGBILLANDSECURITY = 13;
            const Int32 FLD_PARTYRECONCILE = 14;
            const Int32 FLD_REQUISITIONID = 15;
            const Int32 FLD_REQUISITIONNO = 16;
            const Int32 FLD_REQUISITIONDATE = 17;
            const Int32 FLD_BILLID = 18;
            const Int32 FLD_BILLNO = 19;
            const Int32 FLD_BILLDATE = 20;
            const Int32 FLD_REMARKS = 21;
            const Int32 FLD_REF = 22;
            const Int32 FLD_VENDORCATEGORYID = 23;
            const Int32 FLD_FROMVENDORID = 24;
            const Int32 FLD_CREATEDATE = 25;
            const Int32 FLD_DUEDATE = 26;
            const Int32 FLD_PLANNEDDATE = 27;
            const Int32 FLD_ADDITIONALREMARKS = 28;
            const Int32 FLD_ACCPAYABLEPAYMENTSTATUSID = 29;
            const Int32 FLD_ACCPAYABLEAPPROVALSTATUSID = 30;
            const Int32 FLD_ACCOUNTPAYBLESTATEMENTDETAILCATEGORYID = 31;
            const Int32 FLD_PAYABLECLASSIFICATIONID = 32;
            const Int32 FLD_CREATEBYEMPLOYEEID = 33;
            const Int32 FLD_APPANELID = 34;
            const Int32 FLD_IPADDRESS = 35;
            const Int32 FLD_ISREMOVED = 36;
            const Int32 FLD_ISLOCKED = 37;

            ACCPrePayableStatementDetailEntity aCCPrePayableStatementDetailEntity = new ACCPrePayableStatementDetailEntity();

            aCCPrePayableStatementDetailEntity.PrePayableStatementDetailID = reader.GetInt64(FLD_PREPAYABLESTATEMENTDETAILID);
            aCCPrePayableStatementDetailEntity.PrePayableStatementID = reader.GetInt64(FLD_PREPAYABLESTATEMENTID);
            aCCPrePayableStatementDetailEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            if (reader.IsDBNull(FLD_PROJECTCODE)) { aCCPrePayableStatementDetailEntity.ProjectCode = String.Empty; } else { aCCPrePayableStatementDetailEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_WORKORDERID)) { aCCPrePayableStatementDetailEntity.WorkOrderID = null; } else { aCCPrePayableStatementDetailEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID); }
            if (reader.IsDBNull(FLD_WORKORDERNO)) { aCCPrePayableStatementDetailEntity.WorkOrderNo = String.Empty; } else { aCCPrePayableStatementDetailEntity.WorkOrderNo = reader.GetString(FLD_WORKORDERNO); }
            if (reader.IsDBNull(FLD_WORKORDERAMOUNT)) { aCCPrePayableStatementDetailEntity.WorkOrderAmount = null; } else { aCCPrePayableStatementDetailEntity.WorkOrderAmount = reader.GetDecimal(FLD_WORKORDERAMOUNT); }
            if (reader.IsDBNull(FLD_WORKORDERDATE)) { aCCPrePayableStatementDetailEntity.WorkOrderDate = null; } else { aCCPrePayableStatementDetailEntity.WorkOrderDate = reader.GetDateTime(FLD_WORKORDERDATE); }
            if (reader.IsDBNull(FLD_PAIDAMOUNT)) { aCCPrePayableStatementDetailEntity.PaidAmount = null; } else { aCCPrePayableStatementDetailEntity.PaidAmount = reader.GetDecimal(FLD_PAIDAMOUNT); }
            if (reader.IsDBNull(FLD_SECURITYMONEY)) { aCCPrePayableStatementDetailEntity.SecurityMoney = null; } else { aCCPrePayableStatementDetailEntity.SecurityMoney = reader.GetDecimal(FLD_SECURITYMONEY); }
            if (reader.IsDBNull(FLD_TDSAMOUNT)) { aCCPrePayableStatementDetailEntity.TDSAmount = null; } else { aCCPrePayableStatementDetailEntity.TDSAmount = reader.GetDecimal(FLD_TDSAMOUNT); }
            if (reader.IsDBNull(FLD_PAYABLEAGAINSTWORKORDER)) { aCCPrePayableStatementDetailEntity.PayableAgainstWorkOrder = null; } else { aCCPrePayableStatementDetailEntity.PayableAgainstWorkOrder = reader.GetDecimal(FLD_PAYABLEAGAINSTWORKORDER); }
            if (reader.IsDBNull(FLD_APPROVEDBILLAMOUNT)) { aCCPrePayableStatementDetailEntity.ApprovedBillAmount = null; } else { aCCPrePayableStatementDetailEntity.ApprovedBillAmount = reader.GetDecimal(FLD_APPROVEDBILLAMOUNT); }
            if (reader.IsDBNull(FLD_NETPAYABLECONSIDERINGBILLANDSECURITY)) { aCCPrePayableStatementDetailEntity.NetPayableConsideringBillAndSecurity = null; } else { aCCPrePayableStatementDetailEntity.NetPayableConsideringBillAndSecurity = reader.GetDecimal(FLD_NETPAYABLECONSIDERINGBILLANDSECURITY); }
            aCCPrePayableStatementDetailEntity.PartyReconcile = reader.GetBoolean(FLD_PARTYRECONCILE);
            if (reader.IsDBNull(FLD_REQUISITIONID)) { aCCPrePayableStatementDetailEntity.RequisitionID = null; } else { aCCPrePayableStatementDetailEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID); }
            if (reader.IsDBNull(FLD_REQUISITIONNO)) { aCCPrePayableStatementDetailEntity.RequisitionNo = String.Empty; } else { aCCPrePayableStatementDetailEntity.RequisitionNo = reader.GetString(FLD_REQUISITIONNO); }
            if (reader.IsDBNull(FLD_REQUISITIONDATE)) { aCCPrePayableStatementDetailEntity.RequisitionDate = null; } else { aCCPrePayableStatementDetailEntity.RequisitionDate = reader.GetDateTime(FLD_REQUISITIONDATE); }
            if (reader.IsDBNull(FLD_BILLID)) { aCCPrePayableStatementDetailEntity.BillID = null; } else { aCCPrePayableStatementDetailEntity.BillID = reader.GetInt64(FLD_BILLID); }
            if (reader.IsDBNull(FLD_BILLNO)) { aCCPrePayableStatementDetailEntity.BillNo = String.Empty; } else { aCCPrePayableStatementDetailEntity.BillNo = reader.GetString(FLD_BILLNO); }
            if (reader.IsDBNull(FLD_BILLDATE)) { aCCPrePayableStatementDetailEntity.BillDate = null; } else { aCCPrePayableStatementDetailEntity.BillDate = reader.GetDateTime(FLD_BILLDATE); }
            if (reader.IsDBNull(FLD_REMARKS)) { aCCPrePayableStatementDetailEntity.Remarks = String.Empty; } else { aCCPrePayableStatementDetailEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_REF)) { aCCPrePayableStatementDetailEntity.Ref = String.Empty; } else { aCCPrePayableStatementDetailEntity.Ref = reader.GetString(FLD_REF); }
            aCCPrePayableStatementDetailEntity.VendorCategoryID = reader.GetInt64(FLD_VENDORCATEGORYID);
            aCCPrePayableStatementDetailEntity.FromVendorID = reader.GetInt64(FLD_FROMVENDORID);
            aCCPrePayableStatementDetailEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            aCCPrePayableStatementDetailEntity.DueDate = reader.GetDateTime(FLD_DUEDATE);
            if (reader.IsDBNull(FLD_PLANNEDDATE)) { aCCPrePayableStatementDetailEntity.PlannedDate = null; } else { aCCPrePayableStatementDetailEntity.PlannedDate = reader.GetDateTime(FLD_PLANNEDDATE); }
            if (reader.IsDBNull(FLD_ADDITIONALREMARKS)) { aCCPrePayableStatementDetailEntity.AdditionalRemarks = String.Empty; } else { aCCPrePayableStatementDetailEntity.AdditionalRemarks = reader.GetString(FLD_ADDITIONALREMARKS); }
            aCCPrePayableStatementDetailEntity.ACCPayablePaymentStatusID = reader.GetInt64(FLD_ACCPAYABLEPAYMENTSTATUSID);
            aCCPrePayableStatementDetailEntity.ACCPayableApprovalStatusID = reader.GetInt64(FLD_ACCPAYABLEAPPROVALSTATUSID);
            if (reader.IsDBNull(FLD_ACCOUNTPAYBLESTATEMENTDETAILCATEGORYID)) { aCCPrePayableStatementDetailEntity.AccountPaybleStatementDetailCategoryID = null; } else { aCCPrePayableStatementDetailEntity.AccountPaybleStatementDetailCategoryID = reader.GetInt64(FLD_ACCOUNTPAYBLESTATEMENTDETAILCATEGORYID); }
            if (reader.IsDBNull(FLD_PAYABLECLASSIFICATIONID)) { aCCPrePayableStatementDetailEntity.PayableClassificationID = null; } else { aCCPrePayableStatementDetailEntity.PayableClassificationID = reader.GetInt64(FLD_PAYABLECLASSIFICATIONID); }
            aCCPrePayableStatementDetailEntity.CreateByEmployeeID = reader.GetInt64(FLD_CREATEBYEMPLOYEEID);
            aCCPrePayableStatementDetailEntity.APPanelID = reader.GetInt64(FLD_APPANELID);
            if (reader.IsDBNull(FLD_IPADDRESS)) { aCCPrePayableStatementDetailEntity.IPAddress = String.Empty; } else { aCCPrePayableStatementDetailEntity.IPAddress = reader.GetString(FLD_IPADDRESS); }
            aCCPrePayableStatementDetailEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            aCCPrePayableStatementDetailEntity.IsLocked = reader.GetBoolean(FLD_ISLOCKED);

            return aCCPrePayableStatementDetailEntity;
        }
    }
}
