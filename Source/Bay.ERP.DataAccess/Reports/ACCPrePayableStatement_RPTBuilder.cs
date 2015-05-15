// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Dec-2012, 12:17:40




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACCPrePayableStatement_RPTBuilder : IEntityBuilder<ACCPrePayableStatement_RPTEntity>
    {
        IList<ACCPrePayableStatement_RPTEntity> IEntityBuilder<ACCPrePayableStatement_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<ACCPrePayableStatement_RPTEntity> ACCPrePayableStatement_RPTEntityList = new List<ACCPrePayableStatement_RPTEntity>();

            while (reader.Read())
            {
                ACCPrePayableStatement_RPTEntityList.Add(((IEntityBuilder<ACCPrePayableStatement_RPTEntity>)this).BuildEntity(reader));
            }

            return (ACCPrePayableStatement_RPTEntityList.Count > 0) ? ACCPrePayableStatement_RPTEntityList : null;
        }

        ACCPrePayableStatement_RPTEntity IEntityBuilder<ACCPrePayableStatement_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PREPAYABLESTATEMENTDETAILID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_PROJECTCODE = 2;
            const Int32 FLD_WORKORDERID = 3;
            const Int32 FLD_WORKORDERNO = 4;
            const Int32 FLD_WORKORDERAMOUNT = 5;
            const Int32 FLD_WORKORDERDATE = 6;
            const Int32 FLD_PAIDAMOUNT = 7;
            const Int32 FLD_SECURITYMONEY = 8;
            const Int32 FLD_TDSAMOUNT = 9;
            const Int32 FLD_PAYABLEAGAINSTWORKORDER = 10;
            const Int32 FLD_APPROVEDBILLAMOUNT = 11;
            const Int32 FLD_NETPAYABLECONSIDERINGBILLANDSECURITY = 12;
            const Int32 FLD_PARTYRECONCILE = 13;
            const Int32 FLD_REQUISITIONID = 14;
            const Int32 FLD_REQUISITIONNO = 15;
            const Int32 FLD_REQUISITIONDATE = 16;
            const Int32 FLD_BILLID = 17;
            const Int32 FLD_BILLNO = 18;
            const Int32 FLD_BILLDATE = 19;
            const Int32 FLD_REMARKS = 20;
            const Int32 FLD_ACCPREPAYABLESTATEMENTDETAILREF = 21;
            const Int32 FLD_VENDORCATEGORYID = 22;
            const Int32 FLD_FROMVENDORID = 23;
            const Int32 FLD_CREATEDATE = 24;
            const Int32 FLD_DUEDATE = 25;
            const Int32 FLD_PLANNEDDATE = 26;
            const Int32 FLD_ADDITIONALREMARKS = 27;
            const Int32 FLD_ACCPAYABLEPAYMENTSTATUSID = 28;
            const Int32 FLD_ACCPAYABLEAPPROVALSTATUSID = 29;
            const Int32 FLD_ACCOUNTPAYBLESTATEMENTDETAILCATEGORYID = 30;
            const Int32 FLD_PAYABLECLASSIFICATIONID = 31;
            const Int32 FLD_CREATEBYEMPLOYEEID = 32;
            const Int32 FLD_APPANELID = 33;
            const Int32 FLD_IPADDRESS = 34;
            const Int32 FLD_ISREMOVED = 35;
            const Int32 FLD_ISLOCKED = 36;
            const Int32 FLD_ACCPREPAYABLESTATEMENTID = 37;
            const Int32 FLD_STARTDATE = 38;
            const Int32 FLD_ENDDATE = 39;
            const Int32 FLD_ACCPREPAYABLESTATEMENTREF = 40;
            const Int32 FLD_ACCPREPAYABLESTATEMENTDETAILPREPAYABLESTATEMENTID = 41;
            const Int32 FLD_BDPROJECTPROJECTNAME = 42;
            const Int32 FLD_SUPPLIERNAME = 43;
            const Int32 FLD_MDACCPAYABLEPAYMENTSTATUSNAME = 44;
            const Int32 FLD_MDACCPAYABLEAPPROVALSTATUSNAME = 45;
            const Int32 FLD_MDACCOUNTPAYBLESTATEMENTDETAILCATEGORYNAME = 46;
            const Int32 FLD_MDPAYABLECLASSIFICATIONNAME = 47;
            const Int32 FLD_EMPLOYEEMEMBERFULLNAME = 48;
            const Int32 FLD_ROWNUMBER = 49;

            ACCPrePayableStatement_RPTEntity aCCPrePayableStatement_RPTEntity = new ACCPrePayableStatement_RPTEntity();

            aCCPrePayableStatement_RPTEntity.PrePayableStatementDetailID = reader.GetInt64(FLD_PREPAYABLESTATEMENTDETAILID);
            aCCPrePayableStatement_RPTEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            if (reader.IsDBNull(FLD_PROJECTCODE)) { aCCPrePayableStatement_RPTEntity.ProjectCode = String.Empty; } else { aCCPrePayableStatement_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_WORKORDERID)) { aCCPrePayableStatement_RPTEntity.WorkOrderID = null; } else { aCCPrePayableStatement_RPTEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID); }
            if (reader.IsDBNull(FLD_WORKORDERNO)) { aCCPrePayableStatement_RPTEntity.WorkOrderNo = String.Empty; } else { aCCPrePayableStatement_RPTEntity.WorkOrderNo = reader.GetString(FLD_WORKORDERNO); }
            if (reader.IsDBNull(FLD_WORKORDERAMOUNT)) { aCCPrePayableStatement_RPTEntity.WorkOrderAmount = null; } else { aCCPrePayableStatement_RPTEntity.WorkOrderAmount = reader.GetDecimal(FLD_WORKORDERAMOUNT); }
            if (reader.IsDBNull(FLD_WORKORDERDATE)) { aCCPrePayableStatement_RPTEntity.WorkOrderDate = null; } else { aCCPrePayableStatement_RPTEntity.WorkOrderDate = reader.GetDateTime(FLD_WORKORDERDATE); }
            if (reader.IsDBNull(FLD_PAIDAMOUNT)) { aCCPrePayableStatement_RPTEntity.PaidAmount = null; } else { aCCPrePayableStatement_RPTEntity.PaidAmount = reader.GetDecimal(FLD_PAIDAMOUNT); }
            if (reader.IsDBNull(FLD_SECURITYMONEY)) { aCCPrePayableStatement_RPTEntity.SecurityMoney = null; } else { aCCPrePayableStatement_RPTEntity.SecurityMoney = reader.GetDecimal(FLD_SECURITYMONEY); }
            if (reader.IsDBNull(FLD_TDSAMOUNT)) { aCCPrePayableStatement_RPTEntity.TDSAmount = null; } else { aCCPrePayableStatement_RPTEntity.TDSAmount = reader.GetDecimal(FLD_TDSAMOUNT); }
            if (reader.IsDBNull(FLD_PAYABLEAGAINSTWORKORDER)) { aCCPrePayableStatement_RPTEntity.PayableAgainstWorkOrder = null; } else { aCCPrePayableStatement_RPTEntity.PayableAgainstWorkOrder = reader.GetDecimal(FLD_PAYABLEAGAINSTWORKORDER); }
            if (reader.IsDBNull(FLD_APPROVEDBILLAMOUNT)) { aCCPrePayableStatement_RPTEntity.ApprovedBillAmount = null; } else { aCCPrePayableStatement_RPTEntity.ApprovedBillAmount = reader.GetDecimal(FLD_APPROVEDBILLAMOUNT); }
            if (reader.IsDBNull(FLD_NETPAYABLECONSIDERINGBILLANDSECURITY)) { aCCPrePayableStatement_RPTEntity.NetPayableConsideringBillAndSecurity = null; } else { aCCPrePayableStatement_RPTEntity.NetPayableConsideringBillAndSecurity = reader.GetDecimal(FLD_NETPAYABLECONSIDERINGBILLANDSECURITY); }
            aCCPrePayableStatement_RPTEntity.PartyReconcile = reader.GetBoolean(FLD_PARTYRECONCILE);
            if (reader.IsDBNull(FLD_REQUISITIONID)) { aCCPrePayableStatement_RPTEntity.RequisitionID = null; } else { aCCPrePayableStatement_RPTEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID); }
            if (reader.IsDBNull(FLD_REQUISITIONNO)) { aCCPrePayableStatement_RPTEntity.RequisitionNo = String.Empty; } else { aCCPrePayableStatement_RPTEntity.RequisitionNo = reader.GetString(FLD_REQUISITIONNO); }
            if (reader.IsDBNull(FLD_REQUISITIONDATE)) { aCCPrePayableStatement_RPTEntity.RequisitionDate = null; } else { aCCPrePayableStatement_RPTEntity.RequisitionDate = reader.GetDateTime(FLD_REQUISITIONDATE); }
            if (reader.IsDBNull(FLD_BILLID)) { aCCPrePayableStatement_RPTEntity.BillID = null; } else { aCCPrePayableStatement_RPTEntity.BillID = reader.GetInt64(FLD_BILLID); }
            if (reader.IsDBNull(FLD_BILLNO)) { aCCPrePayableStatement_RPTEntity.BillNo = String.Empty; } else { aCCPrePayableStatement_RPTEntity.BillNo = reader.GetString(FLD_BILLNO); }
            if (reader.IsDBNull(FLD_BILLDATE)) { aCCPrePayableStatement_RPTEntity.BillDate = null; } else { aCCPrePayableStatement_RPTEntity.BillDate = reader.GetDateTime(FLD_BILLDATE); }
            if (reader.IsDBNull(FLD_REMARKS)) { aCCPrePayableStatement_RPTEntity.Remarks = String.Empty; } else { aCCPrePayableStatement_RPTEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_ACCPREPAYABLESTATEMENTDETAILREF)) { aCCPrePayableStatement_RPTEntity.ACCPrePayableStatementDetailRef = String.Empty; } else { aCCPrePayableStatement_RPTEntity.ACCPrePayableStatementDetailRef = reader.GetString(FLD_ACCPREPAYABLESTATEMENTDETAILREF); }
            aCCPrePayableStatement_RPTEntity.VendorCategoryID = reader.GetInt64(FLD_VENDORCATEGORYID);
            aCCPrePayableStatement_RPTEntity.FromVendorID = reader.GetInt64(FLD_FROMVENDORID);
            aCCPrePayableStatement_RPTEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            aCCPrePayableStatement_RPTEntity.DueDate = reader.GetDateTime(FLD_DUEDATE);
            if (reader.IsDBNull(FLD_PLANNEDDATE)) { aCCPrePayableStatement_RPTEntity.PlannedDate = null; } else { aCCPrePayableStatement_RPTEntity.PlannedDate = reader.GetDateTime(FLD_PLANNEDDATE); }
            if (reader.IsDBNull(FLD_ADDITIONALREMARKS)) { aCCPrePayableStatement_RPTEntity.AdditionalRemarks = String.Empty; } else { aCCPrePayableStatement_RPTEntity.AdditionalRemarks = reader.GetString(FLD_ADDITIONALREMARKS); }
            aCCPrePayableStatement_RPTEntity.ACCPayablePaymentStatusID = reader.GetInt64(FLD_ACCPAYABLEPAYMENTSTATUSID);
            aCCPrePayableStatement_RPTEntity.ACCPayableApprovalStatusID = reader.GetInt64(FLD_ACCPAYABLEAPPROVALSTATUSID);
            if (reader.IsDBNull(FLD_ACCOUNTPAYBLESTATEMENTDETAILCATEGORYID)) { aCCPrePayableStatement_RPTEntity.AccountPaybleStatementDetailCategoryID = null; } else { aCCPrePayableStatement_RPTEntity.AccountPaybleStatementDetailCategoryID = reader.GetInt64(FLD_ACCOUNTPAYBLESTATEMENTDETAILCATEGORYID); }
            if (reader.IsDBNull(FLD_PAYABLECLASSIFICATIONID)) { aCCPrePayableStatement_RPTEntity.PayableClassificationID = null; } else { aCCPrePayableStatement_RPTEntity.PayableClassificationID = reader.GetInt64(FLD_PAYABLECLASSIFICATIONID); }
            aCCPrePayableStatement_RPTEntity.CreateByEmployeeID = reader.GetInt64(FLD_CREATEBYEMPLOYEEID);
            aCCPrePayableStatement_RPTEntity.APPanelID = reader.GetInt64(FLD_APPANELID);
            if (reader.IsDBNull(FLD_IPADDRESS)) { aCCPrePayableStatement_RPTEntity.IPAddress = String.Empty; } else { aCCPrePayableStatement_RPTEntity.IPAddress = reader.GetString(FLD_IPADDRESS); }
            aCCPrePayableStatement_RPTEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            aCCPrePayableStatement_RPTEntity.IsLocked = reader.GetBoolean(FLD_ISLOCKED);
            aCCPrePayableStatement_RPTEntity.ACCPrePayableStatementID = reader.GetInt64(FLD_ACCPREPAYABLESTATEMENTID);
            aCCPrePayableStatement_RPTEntity.StartDate = reader.GetDateTime(FLD_STARTDATE);
            aCCPrePayableStatement_RPTEntity.EndDate = reader.GetDateTime(FLD_ENDDATE);
            aCCPrePayableStatement_RPTEntity.ACCPrePayableStatementRef = reader.GetString(FLD_ACCPREPAYABLESTATEMENTREF);
            aCCPrePayableStatement_RPTEntity.ACCPrePayableStatementDetailPrePayableStatementID = reader.GetInt64(FLD_ACCPREPAYABLESTATEMENTDETAILPREPAYABLESTATEMENTID);
            if (reader.IsDBNull(FLD_BDPROJECTPROJECTNAME)) { aCCPrePayableStatement_RPTEntity.BDProjectProjectName = String.Empty; } else { aCCPrePayableStatement_RPTEntity.BDProjectProjectName = reader.GetString(FLD_BDPROJECTPROJECTNAME); }
            if (reader.IsDBNull(FLD_SUPPLIERNAME)) { aCCPrePayableStatement_RPTEntity.SupplierName = String.Empty; } else { aCCPrePayableStatement_RPTEntity.SupplierName = reader.GetString(FLD_SUPPLIERNAME); }
            if (reader.IsDBNull(FLD_MDACCPAYABLEPAYMENTSTATUSNAME)) { aCCPrePayableStatement_RPTEntity.MDACCPayablePaymentStatusName = String.Empty; } else { aCCPrePayableStatement_RPTEntity.MDACCPayablePaymentStatusName = reader.GetString(FLD_MDACCPAYABLEPAYMENTSTATUSNAME); }
            if (reader.IsDBNull(FLD_MDACCPAYABLEAPPROVALSTATUSNAME)) { aCCPrePayableStatement_RPTEntity.MDACCPayableApprovalStatusName = String.Empty; } else { aCCPrePayableStatement_RPTEntity.MDACCPayableApprovalStatusName = reader.GetString(FLD_MDACCPAYABLEAPPROVALSTATUSNAME); }
            if (reader.IsDBNull(FLD_MDACCOUNTPAYBLESTATEMENTDETAILCATEGORYNAME)) { aCCPrePayableStatement_RPTEntity.MDAccountPaybleStatementDetailCategoryName = String.Empty; } else { aCCPrePayableStatement_RPTEntity.MDAccountPaybleStatementDetailCategoryName = reader.GetString(FLD_MDACCOUNTPAYBLESTATEMENTDETAILCATEGORYNAME); }
            if (reader.IsDBNull(FLD_MDPAYABLECLASSIFICATIONNAME)) { aCCPrePayableStatement_RPTEntity.MDPayableClassificationName = String.Empty; } else { aCCPrePayableStatement_RPTEntity.MDPayableClassificationName = reader.GetString(FLD_MDPAYABLECLASSIFICATIONNAME); }
            if (reader.IsDBNull(FLD_EMPLOYEEMEMBERFULLNAME)) { aCCPrePayableStatement_RPTEntity.EmployeeMemberFullName = String.Empty; } else { aCCPrePayableStatement_RPTEntity.EmployeeMemberFullName = reader.GetString(FLD_EMPLOYEEMEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { aCCPrePayableStatement_RPTEntity.RowNumber = null; } else { aCCPrePayableStatement_RPTEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return aCCPrePayableStatement_RPTEntity;
        }
    }
}
