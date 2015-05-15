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
    internal sealed class ACBankAccountPaymentDateWise_RPTBuilder : IEntityBuilder<ACBankAccountPaymentDateWise_RPTEntity>
    {
        IList<ACBankAccountPaymentDateWise_RPTEntity> IEntityBuilder<ACBankAccountPaymentDateWise_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<ACBankAccountPaymentDateWise_RPTEntity> ACBankAccountPaymentDateWise_RPTEntityList = new List<ACBankAccountPaymentDateWise_RPTEntity>();

            while (reader.Read())
            {
                ACBankAccountPaymentDateWise_RPTEntityList.Add(((IEntityBuilder<ACBankAccountPaymentDateWise_RPTEntity>)this).BuildEntity(reader));
            }

            return (ACBankAccountPaymentDateWise_RPTEntityList.Count > 0) ? ACBankAccountPaymentDateWise_RPTEntityList : null;
        }

        ACBankAccountPaymentDateWise_RPTEntity IEntityBuilder<ACBankAccountPaymentDateWise_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BANKACCOUNTPAYMENTID = 0;
            const Int32 FLD_PAYMENTDATE = 1;
            const Int32 FLD_PAYTOID = 2;
            const Int32 FLD_REFERENCEID = 3;
            const Int32 FLD_BANKACCOUNTID = 4;
            const Int32 FLD_REFERENCE = 5;
            const Int32 FLD_BANKACCOUNTDEPOSITNAME = 6;
            const Int32 FLD_MEMO = 7;
            const Int32 FLD_BANKACCOUNTPAYMENTAPPROVALSTATUSID = 8;
            const Int32 FLD_PREPAREDBYEMPLOYEEID = 9;
            const Int32 FLD_PAIDFROMNAME = 10;
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
            const Int32 FLD_CREDITAMOUNT = 21;
            const Int32 FLD_DEBITAMOUNT = 22;
            const Int32 FLD_PROJECTID = 23;
            const Int32 FLD_ITEMID = 24;
            const Int32 FLD_REQUISITIONID = 25;
            const Int32 FLD_WORKORDERID = 26;
            const Int32 FLD_BILLID = 27;
            const Int32 FLD_PROJECTFLOORID = 28;
            const Int32 FLD_PROJECTFLOORUNITID = 29;
            const Int32 FLD_BANKACCOUNTDEPOSITITEMMEMO = 30;
            const Int32 FLD_DEPOSITITEMACCOUNTCODE = 31;
            const Int32 FLD_DEPOSITITEMACCOUNTNAME = 32;
            const Int32 FLD_ACCOUNTGROUPNAME = 33;
            const Int32 FLD_SUPPLIERNAME = 34;
            const Int32 FLD_ITEMNAME = 35;
            const Int32 FLD_REQUISITIONNO = 36;
            const Int32 FLD_WORKORDERNO = 37;
            const Int32 FLD_BILLNO = 38;
            const Int32 FLD_PROJECTCODE = 39;
            const Int32 FLD_PROJECTNAME = 40;
            const Int32 FLD_PROJECTFLOORNAME = 41;
            const Int32 FLD_PROJECTFLOORUNITNAME = 42;
            const Int32 FLD_MEMBERFULLNAME = 43;

            ACBankAccountPaymentDateWise_RPTEntity aCBankAccountPaymentDateWise_RPTEntity = new ACBankAccountPaymentDateWise_RPTEntity();

            aCBankAccountPaymentDateWise_RPTEntity.BankAccountPaymentID = reader.GetInt64(FLD_BANKACCOUNTPAYMENTID);
            aCBankAccountPaymentDateWise_RPTEntity.PaymentDate = reader.GetDateTime(FLD_PAYMENTDATE);
            aCBankAccountPaymentDateWise_RPTEntity.PayToID = reader.GetInt64(FLD_PAYTOID);
            if (reader.IsDBNull(FLD_REFERENCEID)) { aCBankAccountPaymentDateWise_RPTEntity.ReferenceID = null; } else { aCBankAccountPaymentDateWise_RPTEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID); }
            aCBankAccountPaymentDateWise_RPTEntity.BankAccountID = reader.GetInt64(FLD_BANKACCOUNTID);
            if (reader.IsDBNull(FLD_REFERENCE)) { aCBankAccountPaymentDateWise_RPTEntity.Reference = String.Empty; } else { aCBankAccountPaymentDateWise_RPTEntity.Reference = reader.GetString(FLD_REFERENCE); }
            if (reader.IsDBNull(FLD_BANKACCOUNTDEPOSITNAME)) { aCBankAccountPaymentDateWise_RPTEntity.BankAccountDepositName = String.Empty; } else { aCBankAccountPaymentDateWise_RPTEntity.BankAccountDepositName = reader.GetString(FLD_BANKACCOUNTDEPOSITNAME); }
            if (reader.IsDBNull(FLD_MEMO)) { aCBankAccountPaymentDateWise_RPTEntity.Memo = String.Empty; } else { aCBankAccountPaymentDateWise_RPTEntity.Memo = reader.GetString(FLD_MEMO); }
            aCBankAccountPaymentDateWise_RPTEntity.BankAccountPaymentApprovalStatusID = reader.GetInt64(FLD_BANKACCOUNTPAYMENTAPPROVALSTATUSID);
            aCBankAccountPaymentDateWise_RPTEntity.PreparedByEmployeeID = reader.GetInt64(FLD_PREPAREDBYEMPLOYEEID);
            aCBankAccountPaymentDateWise_RPTEntity.PaidFromName = reader.GetString(FLD_PAIDFROMNAME);
            if (reader.IsDBNull(FLD_BANKACCOUNTNAME)) { aCBankAccountPaymentDateWise_RPTEntity.BankAccountName = String.Empty; } else { aCBankAccountPaymentDateWise_RPTEntity.BankAccountName = reader.GetString(FLD_BANKACCOUNTNAME); }
            if (reader.IsDBNull(FLD_BANKACCOUNTNUMBER)) { aCBankAccountPaymentDateWise_RPTEntity.BankAccountNumber = String.Empty; } else { aCBankAccountPaymentDateWise_RPTEntity.BankAccountNumber = reader.GetString(FLD_BANKACCOUNTNUMBER); }
            if (reader.IsDBNull(FLD_BANKACCOUNTTYPEID)) { aCBankAccountPaymentDateWise_RPTEntity.BankAccountTypeID = null; } else { aCBankAccountPaymentDateWise_RPTEntity.BankAccountTypeID = reader.GetInt64(FLD_BANKACCOUNTTYPEID); }
            if (reader.IsDBNull(FLD_BANKNAME)) { aCBankAccountPaymentDateWise_RPTEntity.BankName = String.Empty; } else { aCBankAccountPaymentDateWise_RPTEntity.BankName = reader.GetString(FLD_BANKNAME); }
            if (reader.IsDBNull(FLD_BANKADDRESS)) { aCBankAccountPaymentDateWise_RPTEntity.BankAddress = String.Empty; } else { aCBankAccountPaymentDateWise_RPTEntity.BankAddress = reader.GetString(FLD_BANKADDRESS); }
            if (reader.IsDBNull(FLD_BANKACCOUNTTYPENAME)) { aCBankAccountPaymentDateWise_RPTEntity.BankAccountTypeName = String.Empty; } else { aCBankAccountPaymentDateWise_RPTEntity.BankAccountTypeName = reader.GetString(FLD_BANKACCOUNTTYPENAME); }
            if (reader.IsDBNull(FLD_BANKACCOUNTCODE)) { aCBankAccountPaymentDateWise_RPTEntity.BankAccountCode = String.Empty; } else { aCBankAccountPaymentDateWise_RPTEntity.BankAccountCode = reader.GetString(FLD_BANKACCOUNTCODE); }
            if (reader.IsDBNull(FLD_BANKACCOUNTACCOUNTNAME)) { aCBankAccountPaymentDateWise_RPTEntity.BankAccountAccountName = String.Empty; } else { aCBankAccountPaymentDateWise_RPTEntity.BankAccountAccountName = reader.GetString(FLD_BANKACCOUNTACCOUNTNAME); }
            if (reader.IsDBNull(FLD_BANKACCOUNTPAYMENTITEMID)) { aCBankAccountPaymentDateWise_RPTEntity.BankAccountPaymentItemID = null; } else { aCBankAccountPaymentDateWise_RPTEntity.BankAccountPaymentItemID = reader.GetInt64(FLD_BANKACCOUNTPAYMENTITEMID); }
            if (reader.IsDBNull(FLD_DIMENSIONNAME)) { aCBankAccountPaymentDateWise_RPTEntity.DimensionName = String.Empty; } else { aCBankAccountPaymentDateWise_RPTEntity.DimensionName = reader.GetString(FLD_DIMENSIONNAME); }
            if (reader.IsDBNull(FLD_CREDITAMOUNT)) { aCBankAccountPaymentDateWise_RPTEntity.CreditAmount = null; } else { aCBankAccountPaymentDateWise_RPTEntity.CreditAmount = reader.GetDecimal(FLD_CREDITAMOUNT); }
            if (reader.IsDBNull(FLD_DEBITAMOUNT)) { aCBankAccountPaymentDateWise_RPTEntity.DebitAmount = null; } else { aCBankAccountPaymentDateWise_RPTEntity.DebitAmount = reader.GetDecimal(FLD_DEBITAMOUNT); }
            if (reader.IsDBNull(FLD_PROJECTID)) { aCBankAccountPaymentDateWise_RPTEntity.ProjectID = null; } else { aCBankAccountPaymentDateWise_RPTEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            if (reader.IsDBNull(FLD_ITEMID)) { aCBankAccountPaymentDateWise_RPTEntity.ItemID = null; } else { aCBankAccountPaymentDateWise_RPTEntity.ItemID = reader.GetInt64(FLD_ITEMID); }
            if (reader.IsDBNull(FLD_REQUISITIONID)) { aCBankAccountPaymentDateWise_RPTEntity.RequisitionID = null; } else { aCBankAccountPaymentDateWise_RPTEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID); }
            if (reader.IsDBNull(FLD_WORKORDERID)) { aCBankAccountPaymentDateWise_RPTEntity.WorkOrderID = null; } else { aCBankAccountPaymentDateWise_RPTEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID); }
            if (reader.IsDBNull(FLD_BILLID)) { aCBankAccountPaymentDateWise_RPTEntity.BillID = null; } else { aCBankAccountPaymentDateWise_RPTEntity.BillID = reader.GetInt64(FLD_BILLID); }
            if (reader.IsDBNull(FLD_PROJECTFLOORID)) { aCBankAccountPaymentDateWise_RPTEntity.ProjectFloorID = null; } else { aCBankAccountPaymentDateWise_RPTEntity.ProjectFloorID = reader.GetInt64(FLD_PROJECTFLOORID); }
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITID)) { aCBankAccountPaymentDateWise_RPTEntity.ProjectFloorUnitID = null; } else { aCBankAccountPaymentDateWise_RPTEntity.ProjectFloorUnitID = reader.GetInt64(FLD_PROJECTFLOORUNITID); }
            if (reader.IsDBNull(FLD_BANKACCOUNTDEPOSITITEMMEMO)) { aCBankAccountPaymentDateWise_RPTEntity.BankAccountDepositItemMemo = String.Empty; } else { aCBankAccountPaymentDateWise_RPTEntity.BankAccountDepositItemMemo = reader.GetString(FLD_BANKACCOUNTDEPOSITITEMMEMO); }
            if (reader.IsDBNull(FLD_DEPOSITITEMACCOUNTCODE)) { aCBankAccountPaymentDateWise_RPTEntity.DepositItemAccountCode = String.Empty; } else { aCBankAccountPaymentDateWise_RPTEntity.DepositItemAccountCode = reader.GetString(FLD_DEPOSITITEMACCOUNTCODE); }
            if (reader.IsDBNull(FLD_DEPOSITITEMACCOUNTNAME)) { aCBankAccountPaymentDateWise_RPTEntity.DepositItemAccountName = String.Empty; } else { aCBankAccountPaymentDateWise_RPTEntity.DepositItemAccountName = reader.GetString(FLD_DEPOSITITEMACCOUNTNAME); }
            if (reader.IsDBNull(FLD_ACCOUNTGROUPNAME)) { aCBankAccountPaymentDateWise_RPTEntity.AccountGroupName = String.Empty; } else { aCBankAccountPaymentDateWise_RPTEntity.AccountGroupName = reader.GetString(FLD_ACCOUNTGROUPNAME); }
            if (reader.IsDBNull(FLD_SUPPLIERNAME)) { aCBankAccountPaymentDateWise_RPTEntity.SupplierName = String.Empty; } else { aCBankAccountPaymentDateWise_RPTEntity.SupplierName = reader.GetString(FLD_SUPPLIERNAME); }
            if (reader.IsDBNull(FLD_ITEMNAME)) { aCBankAccountPaymentDateWise_RPTEntity.ItemName = String.Empty; } else { aCBankAccountPaymentDateWise_RPTEntity.ItemName = reader.GetString(FLD_ITEMNAME); }
            if (reader.IsDBNull(FLD_REQUISITIONNO)) { aCBankAccountPaymentDateWise_RPTEntity.RequisitionNo = String.Empty; } else { aCBankAccountPaymentDateWise_RPTEntity.RequisitionNo = reader.GetString(FLD_REQUISITIONNO); }
            if (reader.IsDBNull(FLD_WORKORDERNO)) { aCBankAccountPaymentDateWise_RPTEntity.WorkOrderNo = String.Empty; } else { aCBankAccountPaymentDateWise_RPTEntity.WorkOrderNo = reader.GetString(FLD_WORKORDERNO); }
            if (reader.IsDBNull(FLD_BILLNO)) { aCBankAccountPaymentDateWise_RPTEntity.BillNo = String.Empty; } else { aCBankAccountPaymentDateWise_RPTEntity.BillNo = reader.GetString(FLD_BILLNO); }
            if (reader.IsDBNull(FLD_PROJECTCODE)) { aCBankAccountPaymentDateWise_RPTEntity.ProjectCode = String.Empty; } else { aCBankAccountPaymentDateWise_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { aCBankAccountPaymentDateWise_RPTEntity.ProjectName = String.Empty; } else { aCBankAccountPaymentDateWise_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_PROJECTFLOORNAME)) { aCBankAccountPaymentDateWise_RPTEntity.ProjectFloorName = String.Empty; } else { aCBankAccountPaymentDateWise_RPTEntity.ProjectFloorName = reader.GetString(FLD_PROJECTFLOORNAME); }
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITNAME)) { aCBankAccountPaymentDateWise_RPTEntity.ProjectFloorUnitName = String.Empty; } else { aCBankAccountPaymentDateWise_RPTEntity.ProjectFloorUnitName = reader.GetString(FLD_PROJECTFLOORUNITNAME); }
            if (reader.IsDBNull(FLD_MEMBERFULLNAME)) { aCBankAccountPaymentDateWise_RPTEntity.MemberFullName = String.Empty; } else { aCBankAccountPaymentDateWise_RPTEntity.MemberFullName = reader.GetString(FLD_MEMBERFULLNAME); }

            return aCBankAccountPaymentDateWise_RPTEntity;
        }
    }
}
