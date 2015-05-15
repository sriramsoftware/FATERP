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
    internal sealed class ACCPostPayableStatementDetailBuilder : IEntityBuilder<ACCPostPayableStatementDetailEntity>
    {
        IList<ACCPostPayableStatementDetailEntity> IEntityBuilder<ACCPostPayableStatementDetailEntity>.BuildEntities(IDataReader reader)
        {
            List<ACCPostPayableStatementDetailEntity> ACCPostPayableStatementDetailEntityList = new List<ACCPostPayableStatementDetailEntity>();

            while (reader.Read())
            {
                ACCPostPayableStatementDetailEntityList.Add(((IEntityBuilder<ACCPostPayableStatementDetailEntity>)this).BuildEntity(reader));
            }

            return (ACCPostPayableStatementDetailEntityList.Count > 0) ? ACCPostPayableStatementDetailEntityList : null;
        }

        ACCPostPayableStatementDetailEntity IEntityBuilder<ACCPostPayableStatementDetailEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_POSTPAYABLESTATEMENTDETAILID = 0;
            const Int32 FLD_POSTPAYABLESTATEMENTID = 1;
            const Int32 FLD_PREPAYABLESTATEMENTDETAILID = 2;
            const Int32 FLD_PROJECTID = 3;
            const Int32 FLD_PROJECTCODE = 4;
            const Int32 FLD_WORKORDERID = 5;
            const Int32 FLD_WORKORDERNO = 6;
            const Int32 FLD_WORKORDERAMOUNT = 7;
            const Int32 FLD_WORKORDERDATE = 8;
            const Int32 FLD_PAIDAMOUNT = 9;
            const Int32 FLD_SECURITYMONEY = 10;
            const Int32 FLD_TDSAMOUNT = 11;
            const Int32 FLD_PAYABLEAGAINSTWORKORDER = 12;
            const Int32 FLD_APPROVEDBILLAMOUNT = 13;
            const Int32 FLD_NETPAYABLECONSIDERINGBILLANDSECURITY = 14;
            const Int32 FLD_PARTYRECONCILE = 15;
            const Int32 FLD_REQUISITIONID = 16;
            const Int32 FLD_REQUISITIONNO = 17;
            const Int32 FLD_REQUISITIONDATE = 18;
            const Int32 FLD_BILLID = 19;
            const Int32 FLD_BILLNO = 20;
            const Int32 FLD_BILLDATE = 21;
            const Int32 FLD_REMARKS = 22;
            const Int32 FLD_REF = 23;
            const Int32 FLD_VENDORCATEGORYID = 24;
            const Int32 FLD_FROMVENDORID = 25;
            const Int32 FLD_CREATEDATE = 26;
            const Int32 FLD_DUEDATE = 27;
            const Int32 FLD_PLANNEDDATE = 28;
            const Int32 FLD_ADDITIONALREMARKS = 29;
            const Int32 FLD_ACCPAYABLEPAYMENTSTATUSID = 30;
            const Int32 FLD_ACCPAYABLEAPPROVALSTATUSID = 31;
            const Int32 FLD_ACCOUNTPAYBLESTATEMENTDETAILCATEGORYID = 32;
            const Int32 FLD_PAYABLECLASSIFICATIONID = 33;
            const Int32 FLD_CREATEBYEMPLOYEEID = 34;
            const Int32 FLD_APPANELID = 35;
            const Int32 FLD_IPADDRESS = 36;
            const Int32 FLD_ISREMOVED = 37;
            const Int32 FLD_ISLOCKED = 38;

            ACCPostPayableStatementDetailEntity aCCPostPayableStatementDetailEntity = new ACCPostPayableStatementDetailEntity();

            aCCPostPayableStatementDetailEntity.PostPayableStatementDetailID = reader.GetInt64(FLD_POSTPAYABLESTATEMENTDETAILID);
            aCCPostPayableStatementDetailEntity.PostPayableStatementID = reader.GetInt64(FLD_POSTPAYABLESTATEMENTID);
            if (reader.IsDBNull(FLD_PREPAYABLESTATEMENTDETAILID)) { aCCPostPayableStatementDetailEntity.PrePayableStatementDetailID = null; } else { aCCPostPayableStatementDetailEntity.PrePayableStatementDetailID = reader.GetInt64(FLD_PREPAYABLESTATEMENTDETAILID); }
            aCCPostPayableStatementDetailEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            if (reader.IsDBNull(FLD_PROJECTCODE)) { aCCPostPayableStatementDetailEntity.ProjectCode = String.Empty; } else { aCCPostPayableStatementDetailEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_WORKORDERID)) { aCCPostPayableStatementDetailEntity.WorkOrderID = null; } else { aCCPostPayableStatementDetailEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID); }
            if (reader.IsDBNull(FLD_WORKORDERNO)) { aCCPostPayableStatementDetailEntity.WorkOrderNo = String.Empty; } else { aCCPostPayableStatementDetailEntity.WorkOrderNo = reader.GetString(FLD_WORKORDERNO); }
            if (reader.IsDBNull(FLD_WORKORDERAMOUNT)) { aCCPostPayableStatementDetailEntity.WorkOrderAmount = null; } else { aCCPostPayableStatementDetailEntity.WorkOrderAmount = reader.GetDecimal(FLD_WORKORDERAMOUNT); }
            if (reader.IsDBNull(FLD_WORKORDERDATE)) { aCCPostPayableStatementDetailEntity.WorkOrderDate = null; } else { aCCPostPayableStatementDetailEntity.WorkOrderDate = reader.GetDateTime(FLD_WORKORDERDATE); }
            if (reader.IsDBNull(FLD_PAIDAMOUNT)) { aCCPostPayableStatementDetailEntity.PaidAmount = null; } else { aCCPostPayableStatementDetailEntity.PaidAmount = reader.GetDecimal(FLD_PAIDAMOUNT); }
            if (reader.IsDBNull(FLD_SECURITYMONEY)) { aCCPostPayableStatementDetailEntity.SecurityMoney = null; } else { aCCPostPayableStatementDetailEntity.SecurityMoney = reader.GetDecimal(FLD_SECURITYMONEY); }
            if (reader.IsDBNull(FLD_TDSAMOUNT)) { aCCPostPayableStatementDetailEntity.TDSAmount = null; } else { aCCPostPayableStatementDetailEntity.TDSAmount = reader.GetDecimal(FLD_TDSAMOUNT); }
            if (reader.IsDBNull(FLD_PAYABLEAGAINSTWORKORDER)) { aCCPostPayableStatementDetailEntity.PayableAgainstWorkOrder = null; } else { aCCPostPayableStatementDetailEntity.PayableAgainstWorkOrder = reader.GetDecimal(FLD_PAYABLEAGAINSTWORKORDER); }
            if (reader.IsDBNull(FLD_APPROVEDBILLAMOUNT)) { aCCPostPayableStatementDetailEntity.ApprovedBillAmount = null; } else { aCCPostPayableStatementDetailEntity.ApprovedBillAmount = reader.GetDecimal(FLD_APPROVEDBILLAMOUNT); }
            if (reader.IsDBNull(FLD_NETPAYABLECONSIDERINGBILLANDSECURITY)) { aCCPostPayableStatementDetailEntity.NetPayableConsideringBillAndSecurity = null; } else { aCCPostPayableStatementDetailEntity.NetPayableConsideringBillAndSecurity = reader.GetDecimal(FLD_NETPAYABLECONSIDERINGBILLANDSECURITY); }
            aCCPostPayableStatementDetailEntity.PartyReconcile = reader.GetBoolean(FLD_PARTYRECONCILE);
            if (reader.IsDBNull(FLD_REQUISITIONID)) { aCCPostPayableStatementDetailEntity.RequisitionID = null; } else { aCCPostPayableStatementDetailEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID); }
            if (reader.IsDBNull(FLD_REQUISITIONNO)) { aCCPostPayableStatementDetailEntity.RequisitionNo = String.Empty; } else { aCCPostPayableStatementDetailEntity.RequisitionNo = reader.GetString(FLD_REQUISITIONNO); }
            if (reader.IsDBNull(FLD_REQUISITIONDATE)) { aCCPostPayableStatementDetailEntity.RequisitionDate = null; } else { aCCPostPayableStatementDetailEntity.RequisitionDate = reader.GetDateTime(FLD_REQUISITIONDATE); }
            if (reader.IsDBNull(FLD_BILLID)) { aCCPostPayableStatementDetailEntity.BillID = null; } else { aCCPostPayableStatementDetailEntity.BillID = reader.GetInt64(FLD_BILLID); }
            if (reader.IsDBNull(FLD_BILLNO)) { aCCPostPayableStatementDetailEntity.BillNo = String.Empty; } else { aCCPostPayableStatementDetailEntity.BillNo = reader.GetString(FLD_BILLNO); }
            if (reader.IsDBNull(FLD_BILLDATE)) { aCCPostPayableStatementDetailEntity.BillDate = null; } else { aCCPostPayableStatementDetailEntity.BillDate = reader.GetDateTime(FLD_BILLDATE); }
            if (reader.IsDBNull(FLD_REMARKS)) { aCCPostPayableStatementDetailEntity.Remarks = String.Empty; } else { aCCPostPayableStatementDetailEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_REF)) { aCCPostPayableStatementDetailEntity.Ref = String.Empty; } else { aCCPostPayableStatementDetailEntity.Ref = reader.GetString(FLD_REF); }
            aCCPostPayableStatementDetailEntity.VendorCategoryID = reader.GetInt64(FLD_VENDORCATEGORYID);
            aCCPostPayableStatementDetailEntity.FromVendorID = reader.GetInt64(FLD_FROMVENDORID);
            aCCPostPayableStatementDetailEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            aCCPostPayableStatementDetailEntity.DueDate = reader.GetDateTime(FLD_DUEDATE);
            if (reader.IsDBNull(FLD_PLANNEDDATE)) { aCCPostPayableStatementDetailEntity.PlannedDate = null; } else { aCCPostPayableStatementDetailEntity.PlannedDate = reader.GetDateTime(FLD_PLANNEDDATE); }
            if (reader.IsDBNull(FLD_ADDITIONALREMARKS)) { aCCPostPayableStatementDetailEntity.AdditionalRemarks = String.Empty; } else { aCCPostPayableStatementDetailEntity.AdditionalRemarks = reader.GetString(FLD_ADDITIONALREMARKS); }
            aCCPostPayableStatementDetailEntity.ACCPayablePaymentStatusID = reader.GetInt64(FLD_ACCPAYABLEPAYMENTSTATUSID);
            aCCPostPayableStatementDetailEntity.ACCPayableApprovalStatusID = reader.GetInt64(FLD_ACCPAYABLEAPPROVALSTATUSID);
            if (reader.IsDBNull(FLD_ACCOUNTPAYBLESTATEMENTDETAILCATEGORYID)) { aCCPostPayableStatementDetailEntity.AccountPaybleStatementDetailCategoryID = null; } else { aCCPostPayableStatementDetailEntity.AccountPaybleStatementDetailCategoryID = reader.GetInt64(FLD_ACCOUNTPAYBLESTATEMENTDETAILCATEGORYID); }
            if (reader.IsDBNull(FLD_PAYABLECLASSIFICATIONID)) { aCCPostPayableStatementDetailEntity.PayableClassificationID = null; } else { aCCPostPayableStatementDetailEntity.PayableClassificationID = reader.GetInt64(FLD_PAYABLECLASSIFICATIONID); }
            aCCPostPayableStatementDetailEntity.CreateByEmployeeID = reader.GetInt64(FLD_CREATEBYEMPLOYEEID);
            aCCPostPayableStatementDetailEntity.APPanelID = reader.GetInt64(FLD_APPANELID);
            if (reader.IsDBNull(FLD_IPADDRESS)) { aCCPostPayableStatementDetailEntity.IPAddress = String.Empty; } else { aCCPostPayableStatementDetailEntity.IPAddress = reader.GetString(FLD_IPADDRESS); }
            aCCPostPayableStatementDetailEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            aCCPostPayableStatementDetailEntity.IsLocked = reader.GetBoolean(FLD_ISLOCKED);

            return aCCPostPayableStatementDetailEntity;
        }
    }
}
