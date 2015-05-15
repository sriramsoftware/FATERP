// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Mar-2013, 02:25:48




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACCPostPayableStatementDetail_DetailedBuilder : IEntityBuilder<ACCPostPayableStatementDetail_DetailedEntity>
    {
        IList<ACCPostPayableStatementDetail_DetailedEntity> IEntityBuilder<ACCPostPayableStatementDetail_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<ACCPostPayableStatementDetail_DetailedEntity> ACCPostPayableStatementDetail_DetailedEntityList = new List<ACCPostPayableStatementDetail_DetailedEntity>();

            while (reader.Read())
            {
                ACCPostPayableStatementDetail_DetailedEntityList.Add(((IEntityBuilder<ACCPostPayableStatementDetail_DetailedEntity>)this).BuildEntity(reader));
            }

            return (ACCPostPayableStatementDetail_DetailedEntityList.Count > 0) ? ACCPostPayableStatementDetail_DetailedEntityList : null;
        }

        ACCPostPayableStatementDetail_DetailedEntity IEntityBuilder<ACCPostPayableStatementDetail_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_POSTPAYABLESTATEMENTDETAILID = 0;
            const Int32 FLD_POSTPAYABLESTATEMENTID = 1;
            const Int32 FLD_PROJECTCODE = 2;
            const Int32 FLD_WORKORDERNO = 3;
            const Int32 FLD_WORKORDERAMOUNT = 4;
            const Int32 FLD_WORKORDERDATE = 5;
            const Int32 FLD_PAIDAMOUNT = 6;
            const Int32 FLD_SECURITYMONEY = 7;
            const Int32 FLD_TDSAMOUNT = 8;
            const Int32 FLD_PAYABLEAGAINSTWORKORDER = 9;
            const Int32 FLD_APPROVEDBILLAMOUNT = 10;
            const Int32 FLD_NETPAYABLECONSIDERINGBILLANDSECURITY = 11;
            const Int32 FLD_PARTYRECONCILE = 12;
            const Int32 FLD_REQUISITIONNO = 13;
            const Int32 FLD_REQUISITIONDATE = 14;
            const Int32 FLD_BILLNO = 15;
            const Int32 FLD_BILLDATE = 16;
            const Int32 FLD_REF = 17;
            const Int32 FLD_ACCPOSTPAYABLESTATEMENTREF = 18;
            const Int32 FLD_ACCPREPAYABLESTATEMENTDETAILPREPAYABLESTATEMENTID = 19;
            const Int32 FLD_BDPROJECTPROJECTNAME = 20;
            const Int32 FLD_PAYMENTSTATUSNAME = 21;
            const Int32 FLD_PAYABLEAPPROVALSTATUSNAME = 22;
            const Int32 FLD_ACCOUNTPAYBLESTATEMENTDETAILCATEGORYNAME = 23;
            const Int32 FLD_PAYABLECLASSIFICATIONNAME = 24;
            const Int32 FLD_MEMBERFULLNAME = 25;
            const Int32 FLD_APPANELNAME = 26;
            const Int32 FLD_SUPPLIERNAME = 27;
            const Int32 FLD_ROWNUMBER = 28;

            ACCPostPayableStatementDetail_DetailedEntity aCCPostPayableStatementDetail_DetailedEntity = new ACCPostPayableStatementDetail_DetailedEntity();

            aCCPostPayableStatementDetail_DetailedEntity.PostPayableStatementDetailID = reader.GetInt64(FLD_POSTPAYABLESTATEMENTDETAILID);
            aCCPostPayableStatementDetail_DetailedEntity.PostPayableStatementID = reader.GetInt64(FLD_POSTPAYABLESTATEMENTID);
            if (reader.IsDBNull(FLD_PROJECTCODE)) { aCCPostPayableStatementDetail_DetailedEntity.ProjectCode = String.Empty; } else { aCCPostPayableStatementDetail_DetailedEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_WORKORDERNO)) { aCCPostPayableStatementDetail_DetailedEntity.WorkOrderNo = String.Empty; } else { aCCPostPayableStatementDetail_DetailedEntity.WorkOrderNo = reader.GetString(FLD_WORKORDERNO); }
            if (reader.IsDBNull(FLD_WORKORDERAMOUNT)) { aCCPostPayableStatementDetail_DetailedEntity.WorkOrderAmount = null; } else { aCCPostPayableStatementDetail_DetailedEntity.WorkOrderAmount = reader.GetDecimal(FLD_WORKORDERAMOUNT); }
            if (reader.IsDBNull(FLD_WORKORDERDATE)) { aCCPostPayableStatementDetail_DetailedEntity.WorkOrderDate = null; } else { aCCPostPayableStatementDetail_DetailedEntity.WorkOrderDate = reader.GetDateTime(FLD_WORKORDERDATE); }
            if (reader.IsDBNull(FLD_PAIDAMOUNT)) { aCCPostPayableStatementDetail_DetailedEntity.PaidAmount = null; } else { aCCPostPayableStatementDetail_DetailedEntity.PaidAmount = reader.GetDecimal(FLD_PAIDAMOUNT); }
            if (reader.IsDBNull(FLD_SECURITYMONEY)) { aCCPostPayableStatementDetail_DetailedEntity.SecurityMoney = null; } else { aCCPostPayableStatementDetail_DetailedEntity.SecurityMoney = reader.GetDecimal(FLD_SECURITYMONEY); }
            if (reader.IsDBNull(FLD_TDSAMOUNT)) { aCCPostPayableStatementDetail_DetailedEntity.TDSAmount = null; } else { aCCPostPayableStatementDetail_DetailedEntity.TDSAmount = reader.GetDecimal(FLD_TDSAMOUNT); }
            if (reader.IsDBNull(FLD_PAYABLEAGAINSTWORKORDER)) { aCCPostPayableStatementDetail_DetailedEntity.PayableAgainstWorkOrder = null; } else { aCCPostPayableStatementDetail_DetailedEntity.PayableAgainstWorkOrder = reader.GetDecimal(FLD_PAYABLEAGAINSTWORKORDER); }
            if (reader.IsDBNull(FLD_APPROVEDBILLAMOUNT)) { aCCPostPayableStatementDetail_DetailedEntity.ApprovedBillAmount = null; } else { aCCPostPayableStatementDetail_DetailedEntity.ApprovedBillAmount = reader.GetDecimal(FLD_APPROVEDBILLAMOUNT); }
            if (reader.IsDBNull(FLD_NETPAYABLECONSIDERINGBILLANDSECURITY)) { aCCPostPayableStatementDetail_DetailedEntity.NetPayableConsideringBillAndSecurity = null; } else { aCCPostPayableStatementDetail_DetailedEntity.NetPayableConsideringBillAndSecurity = reader.GetDecimal(FLD_NETPAYABLECONSIDERINGBILLANDSECURITY); }
            aCCPostPayableStatementDetail_DetailedEntity.PartyReconcile = reader.GetBoolean(FLD_PARTYRECONCILE);
            if (reader.IsDBNull(FLD_REQUISITIONNO)) { aCCPostPayableStatementDetail_DetailedEntity.RequisitionNo = String.Empty; } else { aCCPostPayableStatementDetail_DetailedEntity.RequisitionNo = reader.GetString(FLD_REQUISITIONNO); }
            if (reader.IsDBNull(FLD_REQUISITIONDATE)) { aCCPostPayableStatementDetail_DetailedEntity.RequisitionDate = null; } else { aCCPostPayableStatementDetail_DetailedEntity.RequisitionDate = reader.GetDateTime(FLD_REQUISITIONDATE); }
            if (reader.IsDBNull(FLD_BILLNO)) { aCCPostPayableStatementDetail_DetailedEntity.BillNo = String.Empty; } else { aCCPostPayableStatementDetail_DetailedEntity.BillNo = reader.GetString(FLD_BILLNO); }
            if (reader.IsDBNull(FLD_BILLDATE)) { aCCPostPayableStatementDetail_DetailedEntity.BillDate = null; } else { aCCPostPayableStatementDetail_DetailedEntity.BillDate = reader.GetDateTime(FLD_BILLDATE); }
            if (reader.IsDBNull(FLD_REF)) { aCCPostPayableStatementDetail_DetailedEntity.Ref = String.Empty; } else { aCCPostPayableStatementDetail_DetailedEntity.Ref = reader.GetString(FLD_REF); }
            if (reader.IsDBNull(FLD_ACCPOSTPAYABLESTATEMENTREF)) { aCCPostPayableStatementDetail_DetailedEntity.ACCPostPayableStatementRef = String.Empty; } else { aCCPostPayableStatementDetail_DetailedEntity.ACCPostPayableStatementRef = reader.GetString(FLD_ACCPOSTPAYABLESTATEMENTREF); }
            if (reader.IsDBNull(FLD_ACCPREPAYABLESTATEMENTDETAILPREPAYABLESTATEMENTID)) { aCCPostPayableStatementDetail_DetailedEntity.ACCPrePayableStatementDetailPrePayableStatementID = null; } else { aCCPostPayableStatementDetail_DetailedEntity.ACCPrePayableStatementDetailPrePayableStatementID = reader.GetInt64(FLD_ACCPREPAYABLESTATEMENTDETAILPREPAYABLESTATEMENTID); }
            if (reader.IsDBNull(FLD_BDPROJECTPROJECTNAME)) { aCCPostPayableStatementDetail_DetailedEntity.BDProjectProjectName = String.Empty; } else { aCCPostPayableStatementDetail_DetailedEntity.BDProjectProjectName = reader.GetString(FLD_BDPROJECTPROJECTNAME); }
            if (reader.IsDBNull(FLD_PAYMENTSTATUSNAME)) { aCCPostPayableStatementDetail_DetailedEntity.PaymentStatusName = String.Empty; } else { aCCPostPayableStatementDetail_DetailedEntity.PaymentStatusName = reader.GetString(FLD_PAYMENTSTATUSNAME); }
            if (reader.IsDBNull(FLD_PAYABLEAPPROVALSTATUSNAME)) { aCCPostPayableStatementDetail_DetailedEntity.PayableApprovalStatusName = String.Empty; } else { aCCPostPayableStatementDetail_DetailedEntity.PayableApprovalStatusName = reader.GetString(FLD_PAYABLEAPPROVALSTATUSNAME); }
            if (reader.IsDBNull(FLD_ACCOUNTPAYBLESTATEMENTDETAILCATEGORYNAME)) { aCCPostPayableStatementDetail_DetailedEntity.AccountPaybleStatementDetailCategoryName = String.Empty; } else { aCCPostPayableStatementDetail_DetailedEntity.AccountPaybleStatementDetailCategoryName = reader.GetString(FLD_ACCOUNTPAYBLESTATEMENTDETAILCATEGORYNAME); }
            if (reader.IsDBNull(FLD_PAYABLECLASSIFICATIONNAME)) { aCCPostPayableStatementDetail_DetailedEntity.PayableClassificationName = String.Empty; } else { aCCPostPayableStatementDetail_DetailedEntity.PayableClassificationName = reader.GetString(FLD_PAYABLECLASSIFICATIONNAME); }
            if (reader.IsDBNull(FLD_MEMBERFULLNAME)) { aCCPostPayableStatementDetail_DetailedEntity.MemberFullName = String.Empty; } else { aCCPostPayableStatementDetail_DetailedEntity.MemberFullName = reader.GetString(FLD_MEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_APPANELNAME)) { aCCPostPayableStatementDetail_DetailedEntity.APPanelName = String.Empty; } else { aCCPostPayableStatementDetail_DetailedEntity.APPanelName = reader.GetString(FLD_APPANELNAME); }
            if (reader.IsDBNull(FLD_SUPPLIERNAME)) { aCCPostPayableStatementDetail_DetailedEntity.SupplierName = String.Empty; } else { aCCPostPayableStatementDetail_DetailedEntity.SupplierName = reader.GetString(FLD_SUPPLIERNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { aCCPostPayableStatementDetail_DetailedEntity.RowNumber = null; } else { aCCPostPayableStatementDetail_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return aCCPostPayableStatementDetail_DetailedEntity;
        }
    }
}
