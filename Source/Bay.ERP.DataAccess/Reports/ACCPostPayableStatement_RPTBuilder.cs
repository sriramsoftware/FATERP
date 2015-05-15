// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Dec-2012, 12:10:34




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACCPostPayableStatement_RPTBuilder : IEntityBuilder<ACCPostPayableStatement_RPTEntity>
    {
        IList<ACCPostPayableStatement_RPTEntity> IEntityBuilder<ACCPostPayableStatement_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<ACCPostPayableStatement_RPTEntity> ACCPostPayableStatement_RPTEntityList = new List<ACCPostPayableStatement_RPTEntity>();

            while (reader.Read())
            {
                ACCPostPayableStatement_RPTEntityList.Add(((IEntityBuilder<ACCPostPayableStatement_RPTEntity>)this).BuildEntity(reader));
            }

            return (ACCPostPayableStatement_RPTEntityList.Count > 0) ? ACCPostPayableStatement_RPTEntityList : null;
        }

        ACCPostPayableStatement_RPTEntity IEntityBuilder<ACCPostPayableStatement_RPTEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_ACCPOSTPAYABLESTATEMENTDETAILREF = 23;
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
            const Int32 FLD_IPADDRESS = 35;
            const Int32 FLD_ISREMOVED = 36;
            const Int32 FLD_ISLOCKED = 37;
            const Int32 FLD_ACCPOSTPAYABLESTATEMENTPREPAYABLESTATEMENTID = 38;
            const Int32 FLD_STARTDATE = 39;
            const Int32 FLD_ENDDATE = 40;
            const Int32 FLD_ACCPOSTPAYABLESTATEMENTREF = 41;
            const Int32 FLD_ACCPREPAYABLESTATEMENTDETAILPREPAYABLESTATEMENTID = 42;
            const Int32 FLD_BDPROJECTPROJECTNAME = 43;
            const Int32 FLD_SUPPLIERNAME = 44;
            const Int32 FLD_MDACCPAYABLEPAYMENTSTATUSNAME = 45;
            const Int32 FLD_MDACCPAYABLEAPPROVALSTATUSNAME = 46;
            const Int32 FLD_MDACCOUNTPAYBLESTATEMENTDETAILCATEGORYNAME = 47;
            const Int32 FLD_MDPAYABLECLASSIFICATIONNAME = 48;
            const Int32 FLD_EMPLOYEEMEMBERFULLNAME = 49;
            const Int32 FLD_ROWNUMBER = 50;

            ACCPostPayableStatement_RPTEntity aCCPostPayableStatement_RPTEntity = new ACCPostPayableStatement_RPTEntity();

            aCCPostPayableStatement_RPTEntity.PostPayableStatementDetailID = reader.GetInt64(FLD_POSTPAYABLESTATEMENTDETAILID);
            aCCPostPayableStatement_RPTEntity.PostPayableStatementID = reader.GetInt64(FLD_POSTPAYABLESTATEMENTID);
            if (reader.IsDBNull(FLD_PREPAYABLESTATEMENTDETAILID)) { aCCPostPayableStatement_RPTEntity.PrePayableStatementDetailID = null; } else { aCCPostPayableStatement_RPTEntity.PrePayableStatementDetailID = reader.GetInt64(FLD_PREPAYABLESTATEMENTDETAILID); }
            aCCPostPayableStatement_RPTEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            if (reader.IsDBNull(FLD_PROJECTCODE)) { aCCPostPayableStatement_RPTEntity.ProjectCode = String.Empty; } else { aCCPostPayableStatement_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_WORKORDERID)) { aCCPostPayableStatement_RPTEntity.WorkOrderID = null; } else { aCCPostPayableStatement_RPTEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID); }
            if (reader.IsDBNull(FLD_WORKORDERNO)) { aCCPostPayableStatement_RPTEntity.WorkOrderNo = String.Empty; } else { aCCPostPayableStatement_RPTEntity.WorkOrderNo = reader.GetString(FLD_WORKORDERNO); }
            if (reader.IsDBNull(FLD_WORKORDERAMOUNT)) { aCCPostPayableStatement_RPTEntity.WorkOrderAmount = null; } else { aCCPostPayableStatement_RPTEntity.WorkOrderAmount = reader.GetDecimal(FLD_WORKORDERAMOUNT); }
            if (reader.IsDBNull(FLD_WORKORDERDATE)) { aCCPostPayableStatement_RPTEntity.WorkOrderDate = null; } else { aCCPostPayableStatement_RPTEntity.WorkOrderDate = reader.GetDateTime(FLD_WORKORDERDATE); }
            if (reader.IsDBNull(FLD_PAIDAMOUNT)) { aCCPostPayableStatement_RPTEntity.PaidAmount = null; } else { aCCPostPayableStatement_RPTEntity.PaidAmount = reader.GetDecimal(FLD_PAIDAMOUNT); }
            if (reader.IsDBNull(FLD_SECURITYMONEY)) { aCCPostPayableStatement_RPTEntity.SecurityMoney = null; } else { aCCPostPayableStatement_RPTEntity.SecurityMoney = reader.GetDecimal(FLD_SECURITYMONEY); }
            if (reader.IsDBNull(FLD_TDSAMOUNT)) { aCCPostPayableStatement_RPTEntity.TDSAmount = null; } else { aCCPostPayableStatement_RPTEntity.TDSAmount = reader.GetDecimal(FLD_TDSAMOUNT); }
            if (reader.IsDBNull(FLD_PAYABLEAGAINSTWORKORDER)) { aCCPostPayableStatement_RPTEntity.PayableAgainstWorkOrder = null; } else { aCCPostPayableStatement_RPTEntity.PayableAgainstWorkOrder = reader.GetDecimal(FLD_PAYABLEAGAINSTWORKORDER); }
            if (reader.IsDBNull(FLD_APPROVEDBILLAMOUNT)) { aCCPostPayableStatement_RPTEntity.ApprovedBillAmount = null; } else { aCCPostPayableStatement_RPTEntity.ApprovedBillAmount = reader.GetDecimal(FLD_APPROVEDBILLAMOUNT); }
            if (reader.IsDBNull(FLD_NETPAYABLECONSIDERINGBILLANDSECURITY)) { aCCPostPayableStatement_RPTEntity.NetPayableConsideringBillAndSecurity = null; } else { aCCPostPayableStatement_RPTEntity.NetPayableConsideringBillAndSecurity = reader.GetDecimal(FLD_NETPAYABLECONSIDERINGBILLANDSECURITY); }
            aCCPostPayableStatement_RPTEntity.PartyReconcile = reader.GetBoolean(FLD_PARTYRECONCILE);
            if (reader.IsDBNull(FLD_REQUISITIONID)) { aCCPostPayableStatement_RPTEntity.RequisitionID = null; } else { aCCPostPayableStatement_RPTEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID); }
            if (reader.IsDBNull(FLD_REQUISITIONNO)) { aCCPostPayableStatement_RPTEntity.RequisitionNo = String.Empty; } else { aCCPostPayableStatement_RPTEntity.RequisitionNo = reader.GetString(FLD_REQUISITIONNO); }
            if (reader.IsDBNull(FLD_REQUISITIONDATE)) { aCCPostPayableStatement_RPTEntity.RequisitionDate = null; } else { aCCPostPayableStatement_RPTEntity.RequisitionDate = reader.GetDateTime(FLD_REQUISITIONDATE); }
            if (reader.IsDBNull(FLD_BILLID)) { aCCPostPayableStatement_RPTEntity.BillID = null; } else { aCCPostPayableStatement_RPTEntity.BillID = reader.GetInt64(FLD_BILLID); }
            if (reader.IsDBNull(FLD_BILLNO)) { aCCPostPayableStatement_RPTEntity.BillNo = String.Empty; } else { aCCPostPayableStatement_RPTEntity.BillNo = reader.GetString(FLD_BILLNO); }
            if (reader.IsDBNull(FLD_BILLDATE)) { aCCPostPayableStatement_RPTEntity.BillDate = null; } else { aCCPostPayableStatement_RPTEntity.BillDate = reader.GetDateTime(FLD_BILLDATE); }
            if (reader.IsDBNull(FLD_REMARKS)) { aCCPostPayableStatement_RPTEntity.Remarks = String.Empty; } else { aCCPostPayableStatement_RPTEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_ACCPOSTPAYABLESTATEMENTDETAILREF)) { aCCPostPayableStatement_RPTEntity.ACCPostPayableStatementDetailRef = String.Empty; } else { aCCPostPayableStatement_RPTEntity.ACCPostPayableStatementDetailRef = reader.GetString(FLD_ACCPOSTPAYABLESTATEMENTDETAILREF); }
            aCCPostPayableStatement_RPTEntity.VendorCategoryID = reader.GetInt64(FLD_VENDORCATEGORYID);
            aCCPostPayableStatement_RPTEntity.FromVendorID = reader.GetInt64(FLD_FROMVENDORID);
            aCCPostPayableStatement_RPTEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            aCCPostPayableStatement_RPTEntity.DueDate = reader.GetDateTime(FLD_DUEDATE);
            if (reader.IsDBNull(FLD_PLANNEDDATE)) { aCCPostPayableStatement_RPTEntity.PlannedDate = null; } else { aCCPostPayableStatement_RPTEntity.PlannedDate = reader.GetDateTime(FLD_PLANNEDDATE); }
            if (reader.IsDBNull(FLD_ADDITIONALREMARKS)) { aCCPostPayableStatement_RPTEntity.AdditionalRemarks = String.Empty; } else { aCCPostPayableStatement_RPTEntity.AdditionalRemarks = reader.GetString(FLD_ADDITIONALREMARKS); }
            aCCPostPayableStatement_RPTEntity.ACCPayablePaymentStatusID = reader.GetInt64(FLD_ACCPAYABLEPAYMENTSTATUSID);
            aCCPostPayableStatement_RPTEntity.ACCPayableApprovalStatusID = reader.GetInt64(FLD_ACCPAYABLEAPPROVALSTATUSID);
            if (reader.IsDBNull(FLD_ACCOUNTPAYBLESTATEMENTDETAILCATEGORYID)) { aCCPostPayableStatement_RPTEntity.AccountPaybleStatementDetailCategoryID = null; } else { aCCPostPayableStatement_RPTEntity.AccountPaybleStatementDetailCategoryID = reader.GetInt64(FLD_ACCOUNTPAYBLESTATEMENTDETAILCATEGORYID); }
            if (reader.IsDBNull(FLD_PAYABLECLASSIFICATIONID)) { aCCPostPayableStatement_RPTEntity.PayableClassificationID = null; } else { aCCPostPayableStatement_RPTEntity.PayableClassificationID = reader.GetInt64(FLD_PAYABLECLASSIFICATIONID); }
            aCCPostPayableStatement_RPTEntity.CreateByEmployeeID = reader.GetInt64(FLD_CREATEBYEMPLOYEEID);
            if (reader.IsDBNull(FLD_IPADDRESS)) { aCCPostPayableStatement_RPTEntity.IPAddress = String.Empty; } else { aCCPostPayableStatement_RPTEntity.IPAddress = reader.GetString(FLD_IPADDRESS); }
            aCCPostPayableStatement_RPTEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            aCCPostPayableStatement_RPTEntity.IsLocked = reader.GetBoolean(FLD_ISLOCKED);
            if (reader.IsDBNull(FLD_ACCPOSTPAYABLESTATEMENTPREPAYABLESTATEMENTID)) { aCCPostPayableStatement_RPTEntity.ACCPostPayableStatementPrePayableStatementID = null; } else { aCCPostPayableStatement_RPTEntity.ACCPostPayableStatementPrePayableStatementID = reader.GetInt64(FLD_ACCPOSTPAYABLESTATEMENTPREPAYABLESTATEMENTID); }
            if (reader.IsDBNull(FLD_STARTDATE)) { aCCPostPayableStatement_RPTEntity.StartDate = null; } else { aCCPostPayableStatement_RPTEntity.StartDate = reader.GetDateTime(FLD_STARTDATE); }
            if (reader.IsDBNull(FLD_ENDDATE)) { aCCPostPayableStatement_RPTEntity.EndDate = null; } else { aCCPostPayableStatement_RPTEntity.EndDate = reader.GetDateTime(FLD_ENDDATE); }
            if (reader.IsDBNull(FLD_ACCPOSTPAYABLESTATEMENTREF)) { aCCPostPayableStatement_RPTEntity.ACCPostPayableStatementRef = String.Empty; } else { aCCPostPayableStatement_RPTEntity.ACCPostPayableStatementRef = reader.GetString(FLD_ACCPOSTPAYABLESTATEMENTREF); }
            if (reader.IsDBNull(FLD_ACCPREPAYABLESTATEMENTDETAILPREPAYABLESTATEMENTID)) { aCCPostPayableStatement_RPTEntity.ACCPrePayableStatementDetailPrePayableStatementID = null; } else { aCCPostPayableStatement_RPTEntity.ACCPrePayableStatementDetailPrePayableStatementID = reader.GetInt64(FLD_ACCPREPAYABLESTATEMENTDETAILPREPAYABLESTATEMENTID); }
            if (reader.IsDBNull(FLD_BDPROJECTPROJECTNAME)) { aCCPostPayableStatement_RPTEntity.BDProjectProjectName = String.Empty; } else { aCCPostPayableStatement_RPTEntity.BDProjectProjectName = reader.GetString(FLD_BDPROJECTPROJECTNAME); }
            if (reader.IsDBNull(FLD_SUPPLIERNAME)) { aCCPostPayableStatement_RPTEntity.SupplierName = String.Empty; } else { aCCPostPayableStatement_RPTEntity.SupplierName = reader.GetString(FLD_SUPPLIERNAME); }
            if (reader.IsDBNull(FLD_MDACCPAYABLEPAYMENTSTATUSNAME)) { aCCPostPayableStatement_RPTEntity.MDACCPayablePaymentStatusName = String.Empty; } else { aCCPostPayableStatement_RPTEntity.MDACCPayablePaymentStatusName = reader.GetString(FLD_MDACCPAYABLEPAYMENTSTATUSNAME); }
            if (reader.IsDBNull(FLD_MDACCPAYABLEAPPROVALSTATUSNAME)) { aCCPostPayableStatement_RPTEntity.MDACCPayableApprovalStatusName = String.Empty; } else { aCCPostPayableStatement_RPTEntity.MDACCPayableApprovalStatusName = reader.GetString(FLD_MDACCPAYABLEAPPROVALSTATUSNAME); }
            if (reader.IsDBNull(FLD_MDACCOUNTPAYBLESTATEMENTDETAILCATEGORYNAME)) { aCCPostPayableStatement_RPTEntity.MDAccountPaybleStatementDetailCategoryName = String.Empty; } else { aCCPostPayableStatement_RPTEntity.MDAccountPaybleStatementDetailCategoryName = reader.GetString(FLD_MDACCOUNTPAYBLESTATEMENTDETAILCATEGORYNAME); }
            if (reader.IsDBNull(FLD_MDPAYABLECLASSIFICATIONNAME)) { aCCPostPayableStatement_RPTEntity.MDPayableClassificationName = String.Empty; } else { aCCPostPayableStatement_RPTEntity.MDPayableClassificationName = reader.GetString(FLD_MDPAYABLECLASSIFICATIONNAME); }
            if (reader.IsDBNull(FLD_EMPLOYEEMEMBERFULLNAME)) { aCCPostPayableStatement_RPTEntity.EmployeeMemberFullName = String.Empty; } else { aCCPostPayableStatement_RPTEntity.EmployeeMemberFullName = reader.GetString(FLD_EMPLOYEEMEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { aCCPostPayableStatement_RPTEntity.RowNumber = null; } else { aCCPostPayableStatement_RPTEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return aCCPostPayableStatement_RPTEntity;
        }
    }
}
