// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Jul-2013, 11:29:54




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACDayBookJournalDateWise_RPTBuilder : IEntityBuilder<ACDayBookJournalDateWise_RPTEntity>
    {
        IList<ACDayBookJournalDateWise_RPTEntity> IEntityBuilder<ACDayBookJournalDateWise_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<ACDayBookJournalDateWise_RPTEntity> ACDayBookJournalDateWise_RPTEntityList = new List<ACDayBookJournalDateWise_RPTEntity>();

            while (reader.Read())
            {
                ACDayBookJournalDateWise_RPTEntityList.Add(((IEntityBuilder<ACDayBookJournalDateWise_RPTEntity>)this).BuildEntity(reader));
            }

            return (ACDayBookJournalDateWise_RPTEntityList.Count > 0) ? ACDayBookJournalDateWise_RPTEntityList : null;
        }

        ACDayBookJournalDateWise_RPTEntity IEntityBuilder<ACDayBookJournalDateWise_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ID = 0;
            const Int32 FLD_TRANSACTIONDATE = 1;
            const Int32 FLD_PAYTOID = 2;
            const Int32 FLD_REFERENCEID = 3;
            const Int32 FLD_BANKACCOUNTID = 4;
            const Int32 FLD_REFERENCE = 5;
            const Int32 FLD_DETAILACCOUNTNAME = 6;
            const Int32 FLD_MEMO = 7;
            const Int32 FLD_APPROVALSTATUSID = 8;
            const Int32 FLD_PREPAREDBYEMPLOYEEID = 9;
            const Int32 FLD_PAIDNAME = 10;
            const Int32 FLD_BANKACCOUNTNAME = 11;
            const Int32 FLD_BANKACCOUNTNUMBER = 12;
            const Int32 FLD_BANKACCOUNTTYPEID = 13;
            const Int32 FLD_BANKNAME = 14;
            const Int32 FLD_BANKADDRESS = 15;
            const Int32 FLD_BANKACCOUNTTYPENAME = 16;
            const Int32 FLD_BANKACCOUNTCODE = 17;
            const Int32 FLD_BANKACCOUNTACCOUNTNAME = 18;
            const Int32 FLD_BANKACCOUNTPAYMENTITEMID = 19;
            const Int32 FLD_DIMENSIONNAME = 20;
            const Int32 FLD_TOTALAMOUNT = 21;
            const Int32 FLD_ITEMAMOUNT = 22;
            const Int32 FLD_VOUCHERTYPE = 23;
            const Int32 FLD_PROJECTID = 24;
            const Int32 FLD_ITEMID = 25;
            const Int32 FLD_REQUISITIONID = 26;
            const Int32 FLD_WORKORDERID = 27;
            const Int32 FLD_BILLID = 28;
            const Int32 FLD_PROJECTFLOORID = 29;
            const Int32 FLD_PROJECTFLOORUNITID = 30;
            const Int32 FLD_ITEMMEMO = 31;
            const Int32 FLD_ITEMACCOUNTCODE = 32;
            const Int32 FLD_ITEMACCOUNTNAME = 33;
            const Int32 FLD_ACCOUNTGROUPNAME = 34;
            const Int32 FLD_SUPPLIERNAME = 35;
            const Int32 FLD_ITEMNAME = 36;
            const Int32 FLD_REQUISITIONNO = 37;
            const Int32 FLD_WORKORDERNO = 38;
            const Int32 FLD_BILLNO = 39;
            const Int32 FLD_PROJECTCODE = 40;
            const Int32 FLD_PROJECTNAME = 41;
            const Int32 FLD_PROJECTFLOORNAME = 42;
            const Int32 FLD_PROJECTFLOORUNITNAME = 43;
            const Int32 FLD_MEMBERFULLNAME = 44;

            ACDayBookJournalDateWise_RPTEntity aCDayBookJournalDateWise_RPTEntity = new ACDayBookJournalDateWise_RPTEntity();

            aCDayBookJournalDateWise_RPTEntity.ID = reader.GetInt64(FLD_ID);
            aCDayBookJournalDateWise_RPTEntity.TransactionDate = reader.GetDateTime(FLD_TRANSACTIONDATE);
            aCDayBookJournalDateWise_RPTEntity.PayToID = reader.GetInt64(FLD_PAYTOID);
            if (reader.IsDBNull(FLD_REFERENCEID)) { aCDayBookJournalDateWise_RPTEntity.ReferenceID = null; } else { aCDayBookJournalDateWise_RPTEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID); }
            aCDayBookJournalDateWise_RPTEntity.BankAccountID = reader.GetInt64(FLD_BANKACCOUNTID);
            if (reader.IsDBNull(FLD_REFERENCE)) { aCDayBookJournalDateWise_RPTEntity.Reference = String.Empty; } else { aCDayBookJournalDateWise_RPTEntity.Reference = reader.GetString(FLD_REFERENCE); }
            if (reader.IsDBNull(FLD_DETAILACCOUNTNAME)) { aCDayBookJournalDateWise_RPTEntity.DetailAccountName = String.Empty; } else { aCDayBookJournalDateWise_RPTEntity.DetailAccountName = reader.GetString(FLD_DETAILACCOUNTNAME); }
            if (reader.IsDBNull(FLD_MEMO)) { aCDayBookJournalDateWise_RPTEntity.Memo = String.Empty; } else { aCDayBookJournalDateWise_RPTEntity.Memo = reader.GetString(FLD_MEMO); }
            aCDayBookJournalDateWise_RPTEntity.ApprovalStatusID = reader.GetInt64(FLD_APPROVALSTATUSID);
            aCDayBookJournalDateWise_RPTEntity.PreparedByEmployeeID = reader.GetInt64(FLD_PREPAREDBYEMPLOYEEID);
            aCDayBookJournalDateWise_RPTEntity.PaidName = reader.GetString(FLD_PAIDNAME);
            if (reader.IsDBNull(FLD_BANKACCOUNTNAME)) { aCDayBookJournalDateWise_RPTEntity.BankAccountName = String.Empty; } else { aCDayBookJournalDateWise_RPTEntity.BankAccountName = reader.GetString(FLD_BANKACCOUNTNAME); }
            if (reader.IsDBNull(FLD_BANKACCOUNTNUMBER)) { aCDayBookJournalDateWise_RPTEntity.BankAccountNumber = String.Empty; } else { aCDayBookJournalDateWise_RPTEntity.BankAccountNumber = reader.GetString(FLD_BANKACCOUNTNUMBER); }
            if (reader.IsDBNull(FLD_BANKACCOUNTTYPEID)) { aCDayBookJournalDateWise_RPTEntity.BankAccountTypeID = null; } else { aCDayBookJournalDateWise_RPTEntity.BankAccountTypeID = reader.GetInt64(FLD_BANKACCOUNTTYPEID); }
            if (reader.IsDBNull(FLD_BANKNAME)) { aCDayBookJournalDateWise_RPTEntity.BankName = String.Empty; } else { aCDayBookJournalDateWise_RPTEntity.BankName = reader.GetString(FLD_BANKNAME); }
            if (reader.IsDBNull(FLD_BANKADDRESS)) { aCDayBookJournalDateWise_RPTEntity.BankAddress = String.Empty; } else { aCDayBookJournalDateWise_RPTEntity.BankAddress = reader.GetString(FLD_BANKADDRESS); }
            if (reader.IsDBNull(FLD_BANKACCOUNTTYPENAME)) { aCDayBookJournalDateWise_RPTEntity.BankAccountTypeName = String.Empty; } else { aCDayBookJournalDateWise_RPTEntity.BankAccountTypeName = reader.GetString(FLD_BANKACCOUNTTYPENAME); }
            if (reader.IsDBNull(FLD_BANKACCOUNTCODE)) { aCDayBookJournalDateWise_RPTEntity.BankAccountCode = String.Empty; } else { aCDayBookJournalDateWise_RPTEntity.BankAccountCode = reader.GetString(FLD_BANKACCOUNTCODE); }
            if (reader.IsDBNull(FLD_BANKACCOUNTACCOUNTNAME)) { aCDayBookJournalDateWise_RPTEntity.BankAccountAccountName = String.Empty; } else { aCDayBookJournalDateWise_RPTEntity.BankAccountAccountName = reader.GetString(FLD_BANKACCOUNTACCOUNTNAME); }
            if (reader.IsDBNull(FLD_BANKACCOUNTPAYMENTITEMID)) { aCDayBookJournalDateWise_RPTEntity.BankAccountPaymentItemID = null; } else { aCDayBookJournalDateWise_RPTEntity.BankAccountPaymentItemID = reader.GetInt64(FLD_BANKACCOUNTPAYMENTITEMID); }
            if (reader.IsDBNull(FLD_DIMENSIONNAME)) { aCDayBookJournalDateWise_RPTEntity.DimensionName = String.Empty; } else { aCDayBookJournalDateWise_RPTEntity.DimensionName = reader.GetString(FLD_DIMENSIONNAME); }
            if (reader.IsDBNull(FLD_TOTALAMOUNT)) { aCDayBookJournalDateWise_RPTEntity.TotalAmount = null; } else { aCDayBookJournalDateWise_RPTEntity.TotalAmount = reader.GetDecimal(FLD_TOTALAMOUNT); }
            if (reader.IsDBNull(FLD_ITEMAMOUNT)) { aCDayBookJournalDateWise_RPTEntity.ItemAmount = null; } else { aCDayBookJournalDateWise_RPTEntity.ItemAmount = reader.GetDecimal(FLD_ITEMAMOUNT); }
            aCDayBookJournalDateWise_RPTEntity.VoucherType = reader.GetString(FLD_VOUCHERTYPE);
            if (reader.IsDBNull(FLD_PROJECTID)) { aCDayBookJournalDateWise_RPTEntity.ProjectID = null; } else { aCDayBookJournalDateWise_RPTEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            if (reader.IsDBNull(FLD_ITEMID)) { aCDayBookJournalDateWise_RPTEntity.ItemID = null; } else { aCDayBookJournalDateWise_RPTEntity.ItemID = reader.GetInt64(FLD_ITEMID); }
            if (reader.IsDBNull(FLD_REQUISITIONID)) { aCDayBookJournalDateWise_RPTEntity.RequisitionID = null; } else { aCDayBookJournalDateWise_RPTEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID); }
            if (reader.IsDBNull(FLD_WORKORDERID)) { aCDayBookJournalDateWise_RPTEntity.WorkOrderID = null; } else { aCDayBookJournalDateWise_RPTEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID); }
            if (reader.IsDBNull(FLD_BILLID)) { aCDayBookJournalDateWise_RPTEntity.BillID = null; } else { aCDayBookJournalDateWise_RPTEntity.BillID = reader.GetInt64(FLD_BILLID); }
            if (reader.IsDBNull(FLD_PROJECTFLOORID)) { aCDayBookJournalDateWise_RPTEntity.ProjectFloorID = null; } else { aCDayBookJournalDateWise_RPTEntity.ProjectFloorID = reader.GetInt64(FLD_PROJECTFLOORID); }
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITID)) { aCDayBookJournalDateWise_RPTEntity.ProjectFloorUnitID = null; } else { aCDayBookJournalDateWise_RPTEntity.ProjectFloorUnitID = reader.GetInt64(FLD_PROJECTFLOORUNITID); }
            if (reader.IsDBNull(FLD_ITEMMEMO)) { aCDayBookJournalDateWise_RPTEntity.ItemMemo = String.Empty; } else { aCDayBookJournalDateWise_RPTEntity.ItemMemo = reader.GetString(FLD_ITEMMEMO); }
            if (reader.IsDBNull(FLD_ITEMACCOUNTCODE)) { aCDayBookJournalDateWise_RPTEntity.ItemAccountCode = String.Empty; } else { aCDayBookJournalDateWise_RPTEntity.ItemAccountCode = reader.GetString(FLD_ITEMACCOUNTCODE); }
            if (reader.IsDBNull(FLD_ITEMACCOUNTNAME)) { aCDayBookJournalDateWise_RPTEntity.ItemAccountName = String.Empty; } else { aCDayBookJournalDateWise_RPTEntity.ItemAccountName = reader.GetString(FLD_ITEMACCOUNTNAME); }
            if (reader.IsDBNull(FLD_ACCOUNTGROUPNAME)) { aCDayBookJournalDateWise_RPTEntity.AccountGroupName = String.Empty; } else { aCDayBookJournalDateWise_RPTEntity.AccountGroupName = reader.GetString(FLD_ACCOUNTGROUPNAME); }
            if (reader.IsDBNull(FLD_SUPPLIERNAME)) { aCDayBookJournalDateWise_RPTEntity.SupplierName = String.Empty; } else { aCDayBookJournalDateWise_RPTEntity.SupplierName = reader.GetString(FLD_SUPPLIERNAME); }
            if (reader.IsDBNull(FLD_ITEMNAME)) { aCDayBookJournalDateWise_RPTEntity.ItemName = String.Empty; } else { aCDayBookJournalDateWise_RPTEntity.ItemName = reader.GetString(FLD_ITEMNAME); }
            if (reader.IsDBNull(FLD_REQUISITIONNO)) { aCDayBookJournalDateWise_RPTEntity.RequisitionNo = String.Empty; } else { aCDayBookJournalDateWise_RPTEntity.RequisitionNo = reader.GetString(FLD_REQUISITIONNO); }
            if (reader.IsDBNull(FLD_WORKORDERNO)) { aCDayBookJournalDateWise_RPTEntity.WorkOrderNo = String.Empty; } else { aCDayBookJournalDateWise_RPTEntity.WorkOrderNo = reader.GetString(FLD_WORKORDERNO); }
            if (reader.IsDBNull(FLD_BILLNO)) { aCDayBookJournalDateWise_RPTEntity.BillNo = String.Empty; } else { aCDayBookJournalDateWise_RPTEntity.BillNo = reader.GetString(FLD_BILLNO); }
            if (reader.IsDBNull(FLD_PROJECTCODE)) { aCDayBookJournalDateWise_RPTEntity.ProjectCode = String.Empty; } else { aCDayBookJournalDateWise_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { aCDayBookJournalDateWise_RPTEntity.ProjectName = String.Empty; } else { aCDayBookJournalDateWise_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_PROJECTFLOORNAME)) { aCDayBookJournalDateWise_RPTEntity.ProjectFloorName = String.Empty; } else { aCDayBookJournalDateWise_RPTEntity.ProjectFloorName = reader.GetString(FLD_PROJECTFLOORNAME); }
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITNAME)) { aCDayBookJournalDateWise_RPTEntity.ProjectFloorUnitName = String.Empty; } else { aCDayBookJournalDateWise_RPTEntity.ProjectFloorUnitName = reader.GetString(FLD_PROJECTFLOORUNITNAME); }
            if (reader.IsDBNull(FLD_MEMBERFULLNAME)) { aCDayBookJournalDateWise_RPTEntity.MemberFullName = String.Empty; } else { aCDayBookJournalDateWise_RPTEntity.MemberFullName = reader.GetString(FLD_MEMBERFULLNAME); }

            return aCDayBookJournalDateWise_RPTEntity;
        }
    }
}
