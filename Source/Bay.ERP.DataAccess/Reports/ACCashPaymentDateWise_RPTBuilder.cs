// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Jul-2013, 02:22:23




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACCashPaymentDateWise_RPTBuilder : IEntityBuilder<ACCashPaymentDateWise_RPTEntity>
    {
        IList<ACCashPaymentDateWise_RPTEntity> IEntityBuilder<ACCashPaymentDateWise_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<ACCashPaymentDateWise_RPTEntity> ACCashPaymentDateWise_RPTEntityList = new List<ACCashPaymentDateWise_RPTEntity>();

            while (reader.Read())
            {
                ACCashPaymentDateWise_RPTEntityList.Add(((IEntityBuilder<ACCashPaymentDateWise_RPTEntity>)this).BuildEntity(reader));
            }

            return (ACCashPaymentDateWise_RPTEntityList.Count > 0) ? ACCashPaymentDateWise_RPTEntityList : null;
        }

        ACCashPaymentDateWise_RPTEntity IEntityBuilder<ACCashPaymentDateWise_RPTEntity>.BuildEntity(IDataReader reader)
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

            ACCashPaymentDateWise_RPTEntity aCCashPaymentDateWise_RPTEntity = new ACCashPaymentDateWise_RPTEntity();

            aCCashPaymentDateWise_RPTEntity.BankAccountPaymentID = reader.GetInt64(FLD_BANKACCOUNTPAYMENTID);
            aCCashPaymentDateWise_RPTEntity.PaymentDate = reader.GetDateTime(FLD_PAYMENTDATE);
            aCCashPaymentDateWise_RPTEntity.PayToID = reader.GetInt64(FLD_PAYTOID);
            if (reader.IsDBNull(FLD_REFERENCEID)) { aCCashPaymentDateWise_RPTEntity.ReferenceID = null; } else { aCCashPaymentDateWise_RPTEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID); }
            aCCashPaymentDateWise_RPTEntity.BankAccountID = reader.GetInt64(FLD_BANKACCOUNTID);
            if (reader.IsDBNull(FLD_REFERENCE)) { aCCashPaymentDateWise_RPTEntity.Reference = String.Empty; } else { aCCashPaymentDateWise_RPTEntity.Reference = reader.GetString(FLD_REFERENCE); }
            if (reader.IsDBNull(FLD_BANKACCOUNTDEPOSITNAME)) { aCCashPaymentDateWise_RPTEntity.BankAccountDepositName = String.Empty; } else { aCCashPaymentDateWise_RPTEntity.BankAccountDepositName = reader.GetString(FLD_BANKACCOUNTDEPOSITNAME); }
            if (reader.IsDBNull(FLD_MEMO)) { aCCashPaymentDateWise_RPTEntity.Memo = String.Empty; } else { aCCashPaymentDateWise_RPTEntity.Memo = reader.GetString(FLD_MEMO); }
            aCCashPaymentDateWise_RPTEntity.BankAccountPaymentApprovalStatusID = reader.GetInt64(FLD_BANKACCOUNTPAYMENTAPPROVALSTATUSID);
            aCCashPaymentDateWise_RPTEntity.PreparedByEmployeeID = reader.GetInt64(FLD_PREPAREDBYEMPLOYEEID);
            aCCashPaymentDateWise_RPTEntity.PaidFromName = reader.GetString(FLD_PAIDFROMNAME);
            if (reader.IsDBNull(FLD_BANKACCOUNTNAME)) { aCCashPaymentDateWise_RPTEntity.BankAccountName = String.Empty; } else { aCCashPaymentDateWise_RPTEntity.BankAccountName = reader.GetString(FLD_BANKACCOUNTNAME); }
            if (reader.IsDBNull(FLD_BANKACCOUNTNUMBER)) { aCCashPaymentDateWise_RPTEntity.BankAccountNumber = String.Empty; } else { aCCashPaymentDateWise_RPTEntity.BankAccountNumber = reader.GetString(FLD_BANKACCOUNTNUMBER); }
            if (reader.IsDBNull(FLD_BANKACCOUNTTYPEID)) { aCCashPaymentDateWise_RPTEntity.BankAccountTypeID = null; } else { aCCashPaymentDateWise_RPTEntity.BankAccountTypeID = reader.GetInt64(FLD_BANKACCOUNTTYPEID); }
            if (reader.IsDBNull(FLD_BANKNAME)) { aCCashPaymentDateWise_RPTEntity.BankName = String.Empty; } else { aCCashPaymentDateWise_RPTEntity.BankName = reader.GetString(FLD_BANKNAME); }
            if (reader.IsDBNull(FLD_BANKADDRESS)) { aCCashPaymentDateWise_RPTEntity.BankAddress = String.Empty; } else { aCCashPaymentDateWise_RPTEntity.BankAddress = reader.GetString(FLD_BANKADDRESS); }
            if (reader.IsDBNull(FLD_BANKACCOUNTTYPENAME)) { aCCashPaymentDateWise_RPTEntity.BankAccountTypeName = String.Empty; } else { aCCashPaymentDateWise_RPTEntity.BankAccountTypeName = reader.GetString(FLD_BANKACCOUNTTYPENAME); }
            if (reader.IsDBNull(FLD_BANKACCOUNTCODE)) { aCCashPaymentDateWise_RPTEntity.BankAccountCode = String.Empty; } else { aCCashPaymentDateWise_RPTEntity.BankAccountCode = reader.GetString(FLD_BANKACCOUNTCODE); }
            if (reader.IsDBNull(FLD_BANKACCOUNTACCOUNTNAME)) { aCCashPaymentDateWise_RPTEntity.BankAccountAccountName = String.Empty; } else { aCCashPaymentDateWise_RPTEntity.BankAccountAccountName = reader.GetString(FLD_BANKACCOUNTACCOUNTNAME); }
            if (reader.IsDBNull(FLD_BANKACCOUNTPAYMENTITEMID)) { aCCashPaymentDateWise_RPTEntity.BankAccountPaymentItemID = null; } else { aCCashPaymentDateWise_RPTEntity.BankAccountPaymentItemID = reader.GetInt64(FLD_BANKACCOUNTPAYMENTITEMID); }
            if (reader.IsDBNull(FLD_DIMENSIONNAME)) { aCCashPaymentDateWise_RPTEntity.DimensionName = String.Empty; } else { aCCashPaymentDateWise_RPTEntity.DimensionName = reader.GetString(FLD_DIMENSIONNAME); }
            if (reader.IsDBNull(FLD_CREDITAMOUNT)) { aCCashPaymentDateWise_RPTEntity.CreditAmount = null; } else { aCCashPaymentDateWise_RPTEntity.CreditAmount = reader.GetDecimal(FLD_CREDITAMOUNT); }
            if (reader.IsDBNull(FLD_DEBITAMOUNT)) { aCCashPaymentDateWise_RPTEntity.DebitAmount = null; } else { aCCashPaymentDateWise_RPTEntity.DebitAmount = reader.GetDecimal(FLD_DEBITAMOUNT); }
            if (reader.IsDBNull(FLD_PROJECTID)) { aCCashPaymentDateWise_RPTEntity.ProjectID = null; } else { aCCashPaymentDateWise_RPTEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            if (reader.IsDBNull(FLD_ITEMID)) { aCCashPaymentDateWise_RPTEntity.ItemID = null; } else { aCCashPaymentDateWise_RPTEntity.ItemID = reader.GetInt64(FLD_ITEMID); }
            if (reader.IsDBNull(FLD_REQUISITIONID)) { aCCashPaymentDateWise_RPTEntity.RequisitionID = null; } else { aCCashPaymentDateWise_RPTEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID); }
            if (reader.IsDBNull(FLD_WORKORDERID)) { aCCashPaymentDateWise_RPTEntity.WorkOrderID = null; } else { aCCashPaymentDateWise_RPTEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID); }
            if (reader.IsDBNull(FLD_BILLID)) { aCCashPaymentDateWise_RPTEntity.BillID = null; } else { aCCashPaymentDateWise_RPTEntity.BillID = reader.GetInt64(FLD_BILLID); }
            if (reader.IsDBNull(FLD_PROJECTFLOORID)) { aCCashPaymentDateWise_RPTEntity.ProjectFloorID = null; } else { aCCashPaymentDateWise_RPTEntity.ProjectFloorID = reader.GetInt64(FLD_PROJECTFLOORID); }
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITID)) { aCCashPaymentDateWise_RPTEntity.ProjectFloorUnitID = null; } else { aCCashPaymentDateWise_RPTEntity.ProjectFloorUnitID = reader.GetInt64(FLD_PROJECTFLOORUNITID); }
            if (reader.IsDBNull(FLD_BANKACCOUNTDEPOSITITEMMEMO)) { aCCashPaymentDateWise_RPTEntity.BankAccountDepositItemMemo = String.Empty; } else { aCCashPaymentDateWise_RPTEntity.BankAccountDepositItemMemo = reader.GetString(FLD_BANKACCOUNTDEPOSITITEMMEMO); }
            if (reader.IsDBNull(FLD_DEPOSITITEMACCOUNTCODE)) { aCCashPaymentDateWise_RPTEntity.DepositItemAccountCode = String.Empty; } else { aCCashPaymentDateWise_RPTEntity.DepositItemAccountCode = reader.GetString(FLD_DEPOSITITEMACCOUNTCODE); }
            if (reader.IsDBNull(FLD_DEPOSITITEMACCOUNTNAME)) { aCCashPaymentDateWise_RPTEntity.DepositItemAccountName = String.Empty; } else { aCCashPaymentDateWise_RPTEntity.DepositItemAccountName = reader.GetString(FLD_DEPOSITITEMACCOUNTNAME); }
            if (reader.IsDBNull(FLD_ACCOUNTGROUPNAME)) { aCCashPaymentDateWise_RPTEntity.AccountGroupName = String.Empty; } else { aCCashPaymentDateWise_RPTEntity.AccountGroupName = reader.GetString(FLD_ACCOUNTGROUPNAME); }
            if (reader.IsDBNull(FLD_SUPPLIERNAME)) { aCCashPaymentDateWise_RPTEntity.SupplierName = String.Empty; } else { aCCashPaymentDateWise_RPTEntity.SupplierName = reader.GetString(FLD_SUPPLIERNAME); }
            if (reader.IsDBNull(FLD_ITEMNAME)) { aCCashPaymentDateWise_RPTEntity.ItemName = String.Empty; } else { aCCashPaymentDateWise_RPTEntity.ItemName = reader.GetString(FLD_ITEMNAME); }
            if (reader.IsDBNull(FLD_REQUISITIONNO)) { aCCashPaymentDateWise_RPTEntity.RequisitionNo = String.Empty; } else { aCCashPaymentDateWise_RPTEntity.RequisitionNo = reader.GetString(FLD_REQUISITIONNO); }
            if (reader.IsDBNull(FLD_WORKORDERNO)) { aCCashPaymentDateWise_RPTEntity.WorkOrderNo = String.Empty; } else { aCCashPaymentDateWise_RPTEntity.WorkOrderNo = reader.GetString(FLD_WORKORDERNO); }
            if (reader.IsDBNull(FLD_BILLNO)) { aCCashPaymentDateWise_RPTEntity.BillNo = String.Empty; } else { aCCashPaymentDateWise_RPTEntity.BillNo = reader.GetString(FLD_BILLNO); }
            if (reader.IsDBNull(FLD_PROJECTCODE)) { aCCashPaymentDateWise_RPTEntity.ProjectCode = String.Empty; } else { aCCashPaymentDateWise_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { aCCashPaymentDateWise_RPTEntity.ProjectName = String.Empty; } else { aCCashPaymentDateWise_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_PROJECTFLOORNAME)) { aCCashPaymentDateWise_RPTEntity.ProjectFloorName = String.Empty; } else { aCCashPaymentDateWise_RPTEntity.ProjectFloorName = reader.GetString(FLD_PROJECTFLOORNAME); }
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITNAME)) { aCCashPaymentDateWise_RPTEntity.ProjectFloorUnitName = String.Empty; } else { aCCashPaymentDateWise_RPTEntity.ProjectFloorUnitName = reader.GetString(FLD_PROJECTFLOORUNITNAME); }
            if (reader.IsDBNull(FLD_MEMBERFULLNAME)) { aCCashPaymentDateWise_RPTEntity.MemberFullName = String.Empty; } else { aCCashPaymentDateWise_RPTEntity.MemberFullName = reader.GetString(FLD_MEMBERFULLNAME); }

            return aCCashPaymentDateWise_RPTEntity;
        }
    }
}
