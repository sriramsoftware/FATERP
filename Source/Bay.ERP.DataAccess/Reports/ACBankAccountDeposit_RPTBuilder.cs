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
    internal sealed class ACBankAccountDeposit_RPTBuilder : IEntityBuilder<ACBankAccountDeposit_RPTEntity>
    {
        IList<ACBankAccountDeposit_RPTEntity> IEntityBuilder<ACBankAccountDeposit_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<ACBankAccountDeposit_RPTEntity> ACBankAccountDeposit_RPTEntityList = new List<ACBankAccountDeposit_RPTEntity>();

            while (reader.Read())
            {
                ACBankAccountDeposit_RPTEntityList.Add(((IEntityBuilder<ACBankAccountDeposit_RPTEntity>)this).BuildEntity(reader));
            }

            return (ACBankAccountDeposit_RPTEntityList.Count > 0) ? ACBankAccountDeposit_RPTEntityList : null;
        }

        ACBankAccountDeposit_RPTEntity IEntityBuilder<ACBankAccountDeposit_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BANKACCOUNTDEPOSITID = 0;
            const Int32 FLD_DEPOSITDATE = 1;
            const Int32 FLD_PAIDFROMID = 2;
            const Int32 FLD_REFERENCEID = 3;
            const Int32 FLD_BANKACCOUNTID = 4;
            const Int32 FLD_REFERENCE = 5;
            const Int32 FLD_BANKACCOUNTDEPOSITNAME = 6;
            const Int32 FLD_MEMO = 7;
            const Int32 FLD_BANKACCOUNTDEPOSITAPPROVALSTATUSID = 8;
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
            const Int32 FLD_BANKACCOUNTDEPOSITITEMID = 19;
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

            ACBankAccountDeposit_RPTEntity aCBankAccountDeposit_RPTEntity = new ACBankAccountDeposit_RPTEntity();

            aCBankAccountDeposit_RPTEntity.BankAccountDepositID = reader.GetInt64(FLD_BANKACCOUNTDEPOSITID);
            aCBankAccountDeposit_RPTEntity.DepositDate = reader.GetDateTime(FLD_DEPOSITDATE);
            aCBankAccountDeposit_RPTEntity.PaidFromID = reader.GetInt64(FLD_PAIDFROMID);
            if (reader.IsDBNull(FLD_REFERENCEID)) { aCBankAccountDeposit_RPTEntity.ReferenceID = null; } else { aCBankAccountDeposit_RPTEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID); }
            aCBankAccountDeposit_RPTEntity.BankAccountID = reader.GetInt64(FLD_BANKACCOUNTID);
            if (reader.IsDBNull(FLD_REFERENCE)) { aCBankAccountDeposit_RPTEntity.Reference = String.Empty; } else { aCBankAccountDeposit_RPTEntity.Reference = reader.GetString(FLD_REFERENCE); }
            if (reader.IsDBNull(FLD_BANKACCOUNTDEPOSITNAME)) { aCBankAccountDeposit_RPTEntity.BankAccountDepositName = String.Empty; } else { aCBankAccountDeposit_RPTEntity.BankAccountDepositName = reader.GetString(FLD_BANKACCOUNTDEPOSITNAME); }
            if (reader.IsDBNull(FLD_MEMO)) { aCBankAccountDeposit_RPTEntity.Memo = String.Empty; } else { aCBankAccountDeposit_RPTEntity.Memo = reader.GetString(FLD_MEMO); }
            aCBankAccountDeposit_RPTEntity.BankAccountDepositApprovalStatusID = reader.GetInt64(FLD_BANKACCOUNTDEPOSITAPPROVALSTATUSID);
            aCBankAccountDeposit_RPTEntity.PreparedByEmployeeID = reader.GetInt64(FLD_PREPAREDBYEMPLOYEEID);
            aCBankAccountDeposit_RPTEntity.PaidFromName = reader.GetString(FLD_PAIDFROMNAME);
            if (reader.IsDBNull(FLD_BANKACCOUNTNAME)) { aCBankAccountDeposit_RPTEntity.BankAccountName = String.Empty; } else { aCBankAccountDeposit_RPTEntity.BankAccountName = reader.GetString(FLD_BANKACCOUNTNAME); }
            if (reader.IsDBNull(FLD_BANKACCOUNTNUMBER)) { aCBankAccountDeposit_RPTEntity.BankAccountNumber = String.Empty; } else { aCBankAccountDeposit_RPTEntity.BankAccountNumber = reader.GetString(FLD_BANKACCOUNTNUMBER); }
            if (reader.IsDBNull(FLD_BANKACCOUNTTYPEID)) { aCBankAccountDeposit_RPTEntity.BankAccountTypeID = null; } else { aCBankAccountDeposit_RPTEntity.BankAccountTypeID = reader.GetInt64(FLD_BANKACCOUNTTYPEID); }
            if (reader.IsDBNull(FLD_BANKNAME)) { aCBankAccountDeposit_RPTEntity.BankName = String.Empty; } else { aCBankAccountDeposit_RPTEntity.BankName = reader.GetString(FLD_BANKNAME); }
            if (reader.IsDBNull(FLD_BANKADDRESS)) { aCBankAccountDeposit_RPTEntity.BankAddress = String.Empty; } else { aCBankAccountDeposit_RPTEntity.BankAddress = reader.GetString(FLD_BANKADDRESS); }
            if (reader.IsDBNull(FLD_BANKACCOUNTTYPENAME)) { aCBankAccountDeposit_RPTEntity.BankAccountTypeName = String.Empty; } else { aCBankAccountDeposit_RPTEntity.BankAccountTypeName = reader.GetString(FLD_BANKACCOUNTTYPENAME); }
            if (reader.IsDBNull(FLD_BANKACCOUNTCODE)) { aCBankAccountDeposit_RPTEntity.BankAccountCode = String.Empty; } else { aCBankAccountDeposit_RPTEntity.BankAccountCode = reader.GetString(FLD_BANKACCOUNTCODE); }
            if (reader.IsDBNull(FLD_BANKACCOUNTACCOUNTNAME)) { aCBankAccountDeposit_RPTEntity.BankAccountAccountName = String.Empty; } else { aCBankAccountDeposit_RPTEntity.BankAccountAccountName = reader.GetString(FLD_BANKACCOUNTACCOUNTNAME); }
            if (reader.IsDBNull(FLD_BANKACCOUNTDEPOSITITEMID)) { aCBankAccountDeposit_RPTEntity.BankAccountDepositItemID = null; } else { aCBankAccountDeposit_RPTEntity.BankAccountDepositItemID = reader.GetInt64(FLD_BANKACCOUNTDEPOSITITEMID); }
            if (reader.IsDBNull(FLD_DIMENSIONNAME)) { aCBankAccountDeposit_RPTEntity.DimensionName = String.Empty; } else { aCBankAccountDeposit_RPTEntity.DimensionName = reader.GetString(FLD_DIMENSIONNAME); }
            if (reader.IsDBNull(FLD_AMOUNT)) { aCBankAccountDeposit_RPTEntity.Amount = null; } else { aCBankAccountDeposit_RPTEntity.Amount = reader.GetDecimal(FLD_AMOUNT); }
            if (reader.IsDBNull(FLD_PROJECTID)) { aCBankAccountDeposit_RPTEntity.ProjectID = null; } else { aCBankAccountDeposit_RPTEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            if (reader.IsDBNull(FLD_ITEMID)) { aCBankAccountDeposit_RPTEntity.ItemID = null; } else { aCBankAccountDeposit_RPTEntity.ItemID = reader.GetInt64(FLD_ITEMID); }
            if (reader.IsDBNull(FLD_REQUISITIONID)) { aCBankAccountDeposit_RPTEntity.RequisitionID = null; } else { aCBankAccountDeposit_RPTEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID); }
            if (reader.IsDBNull(FLD_WORKORDERID)) { aCBankAccountDeposit_RPTEntity.WorkOrderID = null; } else { aCBankAccountDeposit_RPTEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID); }
            if (reader.IsDBNull(FLD_BILLID)) { aCBankAccountDeposit_RPTEntity.BillID = null; } else { aCBankAccountDeposit_RPTEntity.BillID = reader.GetInt64(FLD_BILLID); }
            if (reader.IsDBNull(FLD_PROJECTFLOORID)) { aCBankAccountDeposit_RPTEntity.ProjectFloorID = null; } else { aCBankAccountDeposit_RPTEntity.ProjectFloorID = reader.GetInt64(FLD_PROJECTFLOORID); }
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITID)) { aCBankAccountDeposit_RPTEntity.ProjectFloorUnitID = null; } else { aCBankAccountDeposit_RPTEntity.ProjectFloorUnitID = reader.GetInt64(FLD_PROJECTFLOORUNITID); }
            if (reader.IsDBNull(FLD_BANKACCOUNTDEPOSITITEMMEMO)) { aCBankAccountDeposit_RPTEntity.BankAccountDepositItemMemo = String.Empty; } else { aCBankAccountDeposit_RPTEntity.BankAccountDepositItemMemo = reader.GetString(FLD_BANKACCOUNTDEPOSITITEMMEMO); }
            if (reader.IsDBNull(FLD_DEPOSITITEMACCOUNTCODE)) { aCBankAccountDeposit_RPTEntity.DepositItemAccountCode = String.Empty; } else { aCBankAccountDeposit_RPTEntity.DepositItemAccountCode = reader.GetString(FLD_DEPOSITITEMACCOUNTCODE); }
            if (reader.IsDBNull(FLD_DEPOSITITEMACCOUNTNAME)) { aCBankAccountDeposit_RPTEntity.DepositItemAccountName = String.Empty; } else { aCBankAccountDeposit_RPTEntity.DepositItemAccountName = reader.GetString(FLD_DEPOSITITEMACCOUNTNAME); }
            if (reader.IsDBNull(FLD_ACCOUNTGROUPNAME)) { aCBankAccountDeposit_RPTEntity.AccountGroupName = String.Empty; } else { aCBankAccountDeposit_RPTEntity.AccountGroupName = reader.GetString(FLD_ACCOUNTGROUPNAME); }
            if (reader.IsDBNull(FLD_SUPPLIERNAME)) { aCBankAccountDeposit_RPTEntity.SupplierName = String.Empty; } else { aCBankAccountDeposit_RPTEntity.SupplierName = reader.GetString(FLD_SUPPLIERNAME); }
            if (reader.IsDBNull(FLD_ITEMNAME)) { aCBankAccountDeposit_RPTEntity.ItemName = String.Empty; } else { aCBankAccountDeposit_RPTEntity.ItemName = reader.GetString(FLD_ITEMNAME); }
            if (reader.IsDBNull(FLD_REQUISITIONNO)) { aCBankAccountDeposit_RPTEntity.RequisitionNo = String.Empty; } else { aCBankAccountDeposit_RPTEntity.RequisitionNo = reader.GetString(FLD_REQUISITIONNO); }
            if (reader.IsDBNull(FLD_WORKORDERNO)) { aCBankAccountDeposit_RPTEntity.WorkOrderNo = String.Empty; } else { aCBankAccountDeposit_RPTEntity.WorkOrderNo = reader.GetString(FLD_WORKORDERNO); }
            if (reader.IsDBNull(FLD_BILLNO)) { aCBankAccountDeposit_RPTEntity.BillNo = String.Empty; } else { aCBankAccountDeposit_RPTEntity.BillNo = reader.GetString(FLD_BILLNO); }
            if (reader.IsDBNull(FLD_PROJECTCODE)) { aCBankAccountDeposit_RPTEntity.ProjectCode = String.Empty; } else { aCBankAccountDeposit_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { aCBankAccountDeposit_RPTEntity.ProjectName = String.Empty; } else { aCBankAccountDeposit_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_PROJECTFLOORNAME)) { aCBankAccountDeposit_RPTEntity.ProjectFloorName = String.Empty; } else { aCBankAccountDeposit_RPTEntity.ProjectFloorName = reader.GetString(FLD_PROJECTFLOORNAME); }
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITNAME)) { aCBankAccountDeposit_RPTEntity.ProjectFloorUnitName = String.Empty; } else { aCBankAccountDeposit_RPTEntity.ProjectFloorUnitName = reader.GetString(FLD_PROJECTFLOORUNITNAME); }
            if (reader.IsDBNull(FLD_MEMBERFULLNAME)) { aCBankAccountDeposit_RPTEntity.MemberFullName = String.Empty; } else { aCBankAccountDeposit_RPTEntity.MemberFullName = reader.GetString(FLD_MEMBERFULLNAME); }

            return aCBankAccountDeposit_RPTEntity;
        }
    }
}
