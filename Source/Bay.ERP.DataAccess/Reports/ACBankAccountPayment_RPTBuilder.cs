// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Jul-2013, 10:23:15




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACBankAccountPayment_RPTBuilder : IEntityBuilder<ACBankAccountPayment_RPTEntity>
    {
        IList<ACBankAccountPayment_RPTEntity> IEntityBuilder<ACBankAccountPayment_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<ACBankAccountPayment_RPTEntity> ACBankAccountPayment_RPTEntityList = new List<ACBankAccountPayment_RPTEntity>();

            while (reader.Read())
            {
                ACBankAccountPayment_RPTEntityList.Add(((IEntityBuilder<ACBankAccountPayment_RPTEntity>)this).BuildEntity(reader));
            }

            return (ACBankAccountPayment_RPTEntityList.Count > 0) ? ACBankAccountPayment_RPTEntityList : null;
        }

        ACBankAccountPayment_RPTEntity IEntityBuilder<ACBankAccountPayment_RPTEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_AMOUNT = 21;
            const Int32 FLD_PROJECTID = 22;
            const Int32 FLD_ITEMID = 23;
            const Int32 FLD_REQUISITIONID = 24;
            const Int32 FLD_WORKORDERID = 25;
            const Int32 FLD_BILLID = 26;
            const Int32 FLD_PROJECTFLOORID = 27;
            const Int32 FLD_PROJECTFLOORUNITID = 28;
            const Int32 FLD_BANKACCOUNTDEPOSITITEMMEMO = 29;
            const Int32 FLD_DEPOSITITEMACCOUNTCODE = 30;
            const Int32 FLD_DEPOSITITEMACCOUNTNAME = 31;
            const Int32 FLD_ACCOUNTGROUPNAME = 32;
            const Int32 FLD_SUPPLIERNAME = 33;
            const Int32 FLD_ITEMNAME = 34;
            const Int32 FLD_REQUISITIONNO = 35;
            const Int32 FLD_WORKORDERNO = 36;
            const Int32 FLD_BILLNO = 37;
            const Int32 FLD_PROJECTCODE = 38;
            const Int32 FLD_PROJECTNAME = 39;
            const Int32 FLD_PROJECTFLOORNAME = 40;
            const Int32 FLD_PROJECTFLOORUNITNAME = 41;
            const Int32 FLD_MEMBERFULLNAME = 42;

            ACBankAccountPayment_RPTEntity aCBankAccountPayment_RPTEntity = new ACBankAccountPayment_RPTEntity();

            aCBankAccountPayment_RPTEntity.BankAccountPaymentID = reader.GetInt64(FLD_BANKACCOUNTPAYMENTID);
            aCBankAccountPayment_RPTEntity.PaymentDate = reader.GetDateTime(FLD_PAYMENTDATE);
            aCBankAccountPayment_RPTEntity.PayToID = reader.GetInt64(FLD_PAYTOID);
            if (reader.IsDBNull(FLD_REFERENCEID)) { aCBankAccountPayment_RPTEntity.ReferenceID = null; } else { aCBankAccountPayment_RPTEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID); }
            aCBankAccountPayment_RPTEntity.BankAccountID = reader.GetInt64(FLD_BANKACCOUNTID);
            if (reader.IsDBNull(FLD_REFERENCE)) { aCBankAccountPayment_RPTEntity.Reference = String.Empty; } else { aCBankAccountPayment_RPTEntity.Reference = reader.GetString(FLD_REFERENCE); }
            if (reader.IsDBNull(FLD_BANKACCOUNTDEPOSITNAME)) { aCBankAccountPayment_RPTEntity.BankAccountDepositName = String.Empty; } else { aCBankAccountPayment_RPTEntity.BankAccountDepositName = reader.GetString(FLD_BANKACCOUNTDEPOSITNAME); }
            if (reader.IsDBNull(FLD_MEMO)) { aCBankAccountPayment_RPTEntity.Memo = String.Empty; } else { aCBankAccountPayment_RPTEntity.Memo = reader.GetString(FLD_MEMO); }
            aCBankAccountPayment_RPTEntity.BankAccountPaymentApprovalStatusID = reader.GetInt64(FLD_BANKACCOUNTPAYMENTAPPROVALSTATUSID);
            aCBankAccountPayment_RPTEntity.PreparedByEmployeeID = reader.GetInt64(FLD_PREPAREDBYEMPLOYEEID);
            aCBankAccountPayment_RPTEntity.PaidFromName = reader.GetString(FLD_PAIDFROMNAME);
            if (reader.IsDBNull(FLD_BANKACCOUNTNAME)) { aCBankAccountPayment_RPTEntity.BankAccountName = String.Empty; } else { aCBankAccountPayment_RPTEntity.BankAccountName = reader.GetString(FLD_BANKACCOUNTNAME); }
            if (reader.IsDBNull(FLD_BANKACCOUNTNUMBER)) { aCBankAccountPayment_RPTEntity.BankAccountNumber = String.Empty; } else { aCBankAccountPayment_RPTEntity.BankAccountNumber = reader.GetString(FLD_BANKACCOUNTNUMBER); }
            if (reader.IsDBNull(FLD_BANKACCOUNTTYPEID)) { aCBankAccountPayment_RPTEntity.BankAccountTypeID = null; } else { aCBankAccountPayment_RPTEntity.BankAccountTypeID = reader.GetInt64(FLD_BANKACCOUNTTYPEID); }
            if (reader.IsDBNull(FLD_BANKNAME)) { aCBankAccountPayment_RPTEntity.BankName = String.Empty; } else { aCBankAccountPayment_RPTEntity.BankName = reader.GetString(FLD_BANKNAME); }
            if (reader.IsDBNull(FLD_BANKADDRESS)) { aCBankAccountPayment_RPTEntity.BankAddress = String.Empty; } else { aCBankAccountPayment_RPTEntity.BankAddress = reader.GetString(FLD_BANKADDRESS); }
            if (reader.IsDBNull(FLD_BANKACCOUNTTYPENAME)) { aCBankAccountPayment_RPTEntity.BankAccountTypeName = String.Empty; } else { aCBankAccountPayment_RPTEntity.BankAccountTypeName = reader.GetString(FLD_BANKACCOUNTTYPENAME); }
            if (reader.IsDBNull(FLD_BANKACCOUNTCODE)) { aCBankAccountPayment_RPTEntity.BankAccountCode = String.Empty; } else { aCBankAccountPayment_RPTEntity.BankAccountCode = reader.GetString(FLD_BANKACCOUNTCODE); }
            if (reader.IsDBNull(FLD_BANKACCOUNTACCOUNTNAME)) { aCBankAccountPayment_RPTEntity.BankAccountAccountName = String.Empty; } else { aCBankAccountPayment_RPTEntity.BankAccountAccountName = reader.GetString(FLD_BANKACCOUNTACCOUNTNAME); }
            if (reader.IsDBNull(FLD_BANKACCOUNTPAYMENTITEMID)) { aCBankAccountPayment_RPTEntity.BankAccountPaymentItemID = null; } else { aCBankAccountPayment_RPTEntity.BankAccountPaymentItemID = reader.GetInt64(FLD_BANKACCOUNTPAYMENTITEMID); }
            if (reader.IsDBNull(FLD_DIMENSIONNAME)) { aCBankAccountPayment_RPTEntity.DimensionName = String.Empty; } else { aCBankAccountPayment_RPTEntity.DimensionName = reader.GetString(FLD_DIMENSIONNAME); }
            if (reader.IsDBNull(FLD_AMOUNT)) { aCBankAccountPayment_RPTEntity.Amount = null; } else { aCBankAccountPayment_RPTEntity.Amount = reader.GetDecimal(FLD_AMOUNT); }
            if (reader.IsDBNull(FLD_PROJECTID)) { aCBankAccountPayment_RPTEntity.ProjectID = null; } else { aCBankAccountPayment_RPTEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            if (reader.IsDBNull(FLD_ITEMID)) { aCBankAccountPayment_RPTEntity.ItemID = null; } else { aCBankAccountPayment_RPTEntity.ItemID = reader.GetInt64(FLD_ITEMID); }
            if (reader.IsDBNull(FLD_REQUISITIONID)) { aCBankAccountPayment_RPTEntity.RequisitionID = null; } else { aCBankAccountPayment_RPTEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID); }
            if (reader.IsDBNull(FLD_WORKORDERID)) { aCBankAccountPayment_RPTEntity.WorkOrderID = null; } else { aCBankAccountPayment_RPTEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID); }
            if (reader.IsDBNull(FLD_BILLID)) { aCBankAccountPayment_RPTEntity.BillID = null; } else { aCBankAccountPayment_RPTEntity.BillID = reader.GetInt64(FLD_BILLID); }
            if (reader.IsDBNull(FLD_PROJECTFLOORID)) { aCBankAccountPayment_RPTEntity.ProjectFloorID = null; } else { aCBankAccountPayment_RPTEntity.ProjectFloorID = reader.GetInt64(FLD_PROJECTFLOORID); }
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITID)) { aCBankAccountPayment_RPTEntity.ProjectFloorUnitID = null; } else { aCBankAccountPayment_RPTEntity.ProjectFloorUnitID = reader.GetInt64(FLD_PROJECTFLOORUNITID); }
            if (reader.IsDBNull(FLD_BANKACCOUNTDEPOSITITEMMEMO)) { aCBankAccountPayment_RPTEntity.BankAccountDepositItemMemo = String.Empty; } else { aCBankAccountPayment_RPTEntity.BankAccountDepositItemMemo = reader.GetString(FLD_BANKACCOUNTDEPOSITITEMMEMO); }
            if (reader.IsDBNull(FLD_DEPOSITITEMACCOUNTCODE)) { aCBankAccountPayment_RPTEntity.DepositItemAccountCode = String.Empty; } else { aCBankAccountPayment_RPTEntity.DepositItemAccountCode = reader.GetString(FLD_DEPOSITITEMACCOUNTCODE); }
            if (reader.IsDBNull(FLD_DEPOSITITEMACCOUNTNAME)) { aCBankAccountPayment_RPTEntity.DepositItemAccountName = String.Empty; } else { aCBankAccountPayment_RPTEntity.DepositItemAccountName = reader.GetString(FLD_DEPOSITITEMACCOUNTNAME); }
            if (reader.IsDBNull(FLD_ACCOUNTGROUPNAME)) { aCBankAccountPayment_RPTEntity.AccountGroupName = String.Empty; } else { aCBankAccountPayment_RPTEntity.AccountGroupName = reader.GetString(FLD_ACCOUNTGROUPNAME); }
            if (reader.IsDBNull(FLD_SUPPLIERNAME)) { aCBankAccountPayment_RPTEntity.SupplierName = String.Empty; } else { aCBankAccountPayment_RPTEntity.SupplierName = reader.GetString(FLD_SUPPLIERNAME); }
            if (reader.IsDBNull(FLD_ITEMNAME)) { aCBankAccountPayment_RPTEntity.ItemName = String.Empty; } else { aCBankAccountPayment_RPTEntity.ItemName = reader.GetString(FLD_ITEMNAME); }
            if (reader.IsDBNull(FLD_REQUISITIONNO)) { aCBankAccountPayment_RPTEntity.RequisitionNo = String.Empty; } else { aCBankAccountPayment_RPTEntity.RequisitionNo = reader.GetString(FLD_REQUISITIONNO); }
            if (reader.IsDBNull(FLD_WORKORDERNO)) { aCBankAccountPayment_RPTEntity.WorkOrderNo = String.Empty; } else { aCBankAccountPayment_RPTEntity.WorkOrderNo = reader.GetString(FLD_WORKORDERNO); }
            if (reader.IsDBNull(FLD_BILLNO)) { aCBankAccountPayment_RPTEntity.BillNo = String.Empty; } else { aCBankAccountPayment_RPTEntity.BillNo = reader.GetString(FLD_BILLNO); }
            if (reader.IsDBNull(FLD_PROJECTCODE)) { aCBankAccountPayment_RPTEntity.ProjectCode = String.Empty; } else { aCBankAccountPayment_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { aCBankAccountPayment_RPTEntity.ProjectName = String.Empty; } else { aCBankAccountPayment_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_PROJECTFLOORNAME)) { aCBankAccountPayment_RPTEntity.ProjectFloorName = String.Empty; } else { aCBankAccountPayment_RPTEntity.ProjectFloorName = reader.GetString(FLD_PROJECTFLOORNAME); }
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITNAME)) { aCBankAccountPayment_RPTEntity.ProjectFloorUnitName = String.Empty; } else { aCBankAccountPayment_RPTEntity.ProjectFloorUnitName = reader.GetString(FLD_PROJECTFLOORUNITNAME); }
            if (reader.IsDBNull(FLD_MEMBERFULLNAME)) { aCBankAccountPayment_RPTEntity.MemberFullName = String.Empty; } else { aCBankAccountPayment_RPTEntity.MemberFullName = reader.GetString(FLD_MEMBERFULLNAME); }

            return aCBankAccountPayment_RPTEntity;
        }
    }
}
