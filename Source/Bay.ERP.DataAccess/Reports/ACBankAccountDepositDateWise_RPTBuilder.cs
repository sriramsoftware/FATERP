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
    internal sealed class ACBankAccountDepositDateWise_RPTBuilder : IEntityBuilder<ACBankAccountDepositDateWise_RPTEntity>
    {
        IList<ACBankAccountDepositDateWise_RPTEntity> IEntityBuilder<ACBankAccountDepositDateWise_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<ACBankAccountDepositDateWise_RPTEntity> ACBankAccountDepositDateWise_RPTEntityList = new List<ACBankAccountDepositDateWise_RPTEntity>();

            while (reader.Read())
            {
                ACBankAccountDepositDateWise_RPTEntityList.Add(((IEntityBuilder<ACBankAccountDepositDateWise_RPTEntity>)this).BuildEntity(reader));
            }

            return (ACBankAccountDepositDateWise_RPTEntityList.Count > 0) ? ACBankAccountDepositDateWise_RPTEntityList : null;
        }

        ACBankAccountDepositDateWise_RPTEntity IEntityBuilder<ACBankAccountDepositDateWise_RPTEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_CREDITAMOUNT = 21;
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

            ACBankAccountDepositDateWise_RPTEntity aCBankAccountDepositDateWise_RPTEntity = new ACBankAccountDepositDateWise_RPTEntity();

            aCBankAccountDepositDateWise_RPTEntity.BankAccountDepositID = reader.GetInt64(FLD_BANKACCOUNTDEPOSITID);
            aCBankAccountDepositDateWise_RPTEntity.DepositDate = reader.GetDateTime(FLD_DEPOSITDATE);
            aCBankAccountDepositDateWise_RPTEntity.PaidFromID = reader.GetInt64(FLD_PAIDFROMID);
            if (reader.IsDBNull(FLD_REFERENCEID)) { aCBankAccountDepositDateWise_RPTEntity.ReferenceID = null; } else { aCBankAccountDepositDateWise_RPTEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID); }
            aCBankAccountDepositDateWise_RPTEntity.BankAccountID = reader.GetInt64(FLD_BANKACCOUNTID);
            if (reader.IsDBNull(FLD_REFERENCE)) { aCBankAccountDepositDateWise_RPTEntity.Reference = String.Empty; } else { aCBankAccountDepositDateWise_RPTEntity.Reference = reader.GetString(FLD_REFERENCE); }
            if (reader.IsDBNull(FLD_BANKACCOUNTDEPOSITNAME)) { aCBankAccountDepositDateWise_RPTEntity.BankAccountDepositName = String.Empty; } else { aCBankAccountDepositDateWise_RPTEntity.BankAccountDepositName = reader.GetString(FLD_BANKACCOUNTDEPOSITNAME); }
            if (reader.IsDBNull(FLD_MEMO)) { aCBankAccountDepositDateWise_RPTEntity.Memo = String.Empty; } else { aCBankAccountDepositDateWise_RPTEntity.Memo = reader.GetString(FLD_MEMO); }
            aCBankAccountDepositDateWise_RPTEntity.BankAccountDepositApprovalStatusID = reader.GetInt64(FLD_BANKACCOUNTDEPOSITAPPROVALSTATUSID);
            aCBankAccountDepositDateWise_RPTEntity.PreparedByEmployeeID = reader.GetInt64(FLD_PREPAREDBYEMPLOYEEID);
            aCBankAccountDepositDateWise_RPTEntity.PaidFromName = reader.GetString(FLD_PAIDFROMNAME);
            if (reader.IsDBNull(FLD_BANKACCOUNTNAME)) { aCBankAccountDepositDateWise_RPTEntity.BankAccountName = String.Empty; } else { aCBankAccountDepositDateWise_RPTEntity.BankAccountName = reader.GetString(FLD_BANKACCOUNTNAME); }
            if (reader.IsDBNull(FLD_BANKACCOUNTNUMBER)) { aCBankAccountDepositDateWise_RPTEntity.BankAccountNumber = String.Empty; } else { aCBankAccountDepositDateWise_RPTEntity.BankAccountNumber = reader.GetString(FLD_BANKACCOUNTNUMBER); }
            if (reader.IsDBNull(FLD_BANKACCOUNTTYPEID)) { aCBankAccountDepositDateWise_RPTEntity.BankAccountTypeID = null; } else { aCBankAccountDepositDateWise_RPTEntity.BankAccountTypeID = reader.GetInt64(FLD_BANKACCOUNTTYPEID); }
            if (reader.IsDBNull(FLD_BANKNAME)) { aCBankAccountDepositDateWise_RPTEntity.BankName = String.Empty; } else { aCBankAccountDepositDateWise_RPTEntity.BankName = reader.GetString(FLD_BANKNAME); }
            if (reader.IsDBNull(FLD_BANKADDRESS)) { aCBankAccountDepositDateWise_RPTEntity.BankAddress = String.Empty; } else { aCBankAccountDepositDateWise_RPTEntity.BankAddress = reader.GetString(FLD_BANKADDRESS); }
            if (reader.IsDBNull(FLD_BANKACCOUNTTYPENAME)) { aCBankAccountDepositDateWise_RPTEntity.BankAccountTypeName = String.Empty; } else { aCBankAccountDepositDateWise_RPTEntity.BankAccountTypeName = reader.GetString(FLD_BANKACCOUNTTYPENAME); }
            if (reader.IsDBNull(FLD_BANKACCOUNTCODE)) { aCBankAccountDepositDateWise_RPTEntity.BankAccountCode = String.Empty; } else { aCBankAccountDepositDateWise_RPTEntity.BankAccountCode = reader.GetString(FLD_BANKACCOUNTCODE); }
            if (reader.IsDBNull(FLD_BANKACCOUNTACCOUNTNAME)) { aCBankAccountDepositDateWise_RPTEntity.BankAccountAccountName = String.Empty; } else { aCBankAccountDepositDateWise_RPTEntity.BankAccountAccountName = reader.GetString(FLD_BANKACCOUNTACCOUNTNAME); }
            if (reader.IsDBNull(FLD_BANKACCOUNTDEPOSITITEMID)) { aCBankAccountDepositDateWise_RPTEntity.BankAccountDepositItemID = null; } else { aCBankAccountDepositDateWise_RPTEntity.BankAccountDepositItemID = reader.GetInt64(FLD_BANKACCOUNTDEPOSITITEMID); }
            if (reader.IsDBNull(FLD_DIMENSIONNAME)) { aCBankAccountDepositDateWise_RPTEntity.DimensionName = String.Empty; } else { aCBankAccountDepositDateWise_RPTEntity.DimensionName = reader.GetString(FLD_DIMENSIONNAME); }
            if (reader.IsDBNull(FLD_CREDITAMOUNT)) { aCBankAccountDepositDateWise_RPTEntity.CreditAmount = null; } else { aCBankAccountDepositDateWise_RPTEntity.CreditAmount = reader.GetDecimal(FLD_CREDITAMOUNT); }
            if (reader.IsDBNull(FLD_PROJECTID)) { aCBankAccountDepositDateWise_RPTEntity.ProjectID = null; } else { aCBankAccountDepositDateWise_RPTEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            if (reader.IsDBNull(FLD_ITEMID)) { aCBankAccountDepositDateWise_RPTEntity.ItemID = null; } else { aCBankAccountDepositDateWise_RPTEntity.ItemID = reader.GetInt64(FLD_ITEMID); }
            if (reader.IsDBNull(FLD_REQUISITIONID)) { aCBankAccountDepositDateWise_RPTEntity.RequisitionID = null; } else { aCBankAccountDepositDateWise_RPTEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID); }
            if (reader.IsDBNull(FLD_WORKORDERID)) { aCBankAccountDepositDateWise_RPTEntity.WorkOrderID = null; } else { aCBankAccountDepositDateWise_RPTEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID); }
            if (reader.IsDBNull(FLD_BILLID)) { aCBankAccountDepositDateWise_RPTEntity.BillID = null; } else { aCBankAccountDepositDateWise_RPTEntity.BillID = reader.GetInt64(FLD_BILLID); }
            if (reader.IsDBNull(FLD_PROJECTFLOORID)) { aCBankAccountDepositDateWise_RPTEntity.ProjectFloorID = null; } else { aCBankAccountDepositDateWise_RPTEntity.ProjectFloorID = reader.GetInt64(FLD_PROJECTFLOORID); }
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITID)) { aCBankAccountDepositDateWise_RPTEntity.ProjectFloorUnitID = null; } else { aCBankAccountDepositDateWise_RPTEntity.ProjectFloorUnitID = reader.GetInt64(FLD_PROJECTFLOORUNITID); }
            if (reader.IsDBNull(FLD_BANKACCOUNTDEPOSITITEMMEMO)) { aCBankAccountDepositDateWise_RPTEntity.BankAccountDepositItemMemo = String.Empty; } else { aCBankAccountDepositDateWise_RPTEntity.BankAccountDepositItemMemo = reader.GetString(FLD_BANKACCOUNTDEPOSITITEMMEMO); }
            if (reader.IsDBNull(FLD_DEPOSITITEMACCOUNTCODE)) { aCBankAccountDepositDateWise_RPTEntity.DepositItemAccountCode = String.Empty; } else { aCBankAccountDepositDateWise_RPTEntity.DepositItemAccountCode = reader.GetString(FLD_DEPOSITITEMACCOUNTCODE); }
            if (reader.IsDBNull(FLD_DEPOSITITEMACCOUNTNAME)) { aCBankAccountDepositDateWise_RPTEntity.DepositItemAccountName = String.Empty; } else { aCBankAccountDepositDateWise_RPTEntity.DepositItemAccountName = reader.GetString(FLD_DEPOSITITEMACCOUNTNAME); }
            if (reader.IsDBNull(FLD_ACCOUNTGROUPNAME)) { aCBankAccountDepositDateWise_RPTEntity.AccountGroupName = String.Empty; } else { aCBankAccountDepositDateWise_RPTEntity.AccountGroupName = reader.GetString(FLD_ACCOUNTGROUPNAME); }
            if (reader.IsDBNull(FLD_SUPPLIERNAME)) { aCBankAccountDepositDateWise_RPTEntity.SupplierName = String.Empty; } else { aCBankAccountDepositDateWise_RPTEntity.SupplierName = reader.GetString(FLD_SUPPLIERNAME); }
            if (reader.IsDBNull(FLD_ITEMNAME)) { aCBankAccountDepositDateWise_RPTEntity.ItemName = String.Empty; } else { aCBankAccountDepositDateWise_RPTEntity.ItemName = reader.GetString(FLD_ITEMNAME); }
            if (reader.IsDBNull(FLD_REQUISITIONNO)) { aCBankAccountDepositDateWise_RPTEntity.RequisitionNo = String.Empty; } else { aCBankAccountDepositDateWise_RPTEntity.RequisitionNo = reader.GetString(FLD_REQUISITIONNO); }
            if (reader.IsDBNull(FLD_WORKORDERNO)) { aCBankAccountDepositDateWise_RPTEntity.WorkOrderNo = String.Empty; } else { aCBankAccountDepositDateWise_RPTEntity.WorkOrderNo = reader.GetString(FLD_WORKORDERNO); }
            if (reader.IsDBNull(FLD_BILLNO)) { aCBankAccountDepositDateWise_RPTEntity.BillNo = String.Empty; } else { aCBankAccountDepositDateWise_RPTEntity.BillNo = reader.GetString(FLD_BILLNO); }
            if (reader.IsDBNull(FLD_PROJECTCODE)) { aCBankAccountDepositDateWise_RPTEntity.ProjectCode = String.Empty; } else { aCBankAccountDepositDateWise_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { aCBankAccountDepositDateWise_RPTEntity.ProjectName = String.Empty; } else { aCBankAccountDepositDateWise_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_PROJECTFLOORNAME)) { aCBankAccountDepositDateWise_RPTEntity.ProjectFloorName = String.Empty; } else { aCBankAccountDepositDateWise_RPTEntity.ProjectFloorName = reader.GetString(FLD_PROJECTFLOORNAME); }
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITNAME)) { aCBankAccountDepositDateWise_RPTEntity.ProjectFloorUnitName = String.Empty; } else { aCBankAccountDepositDateWise_RPTEntity.ProjectFloorUnitName = reader.GetString(FLD_PROJECTFLOORUNITNAME); }
            if (reader.IsDBNull(FLD_MEMBERFULLNAME)) { aCBankAccountDepositDateWise_RPTEntity.MemberFullName = String.Empty; } else { aCBankAccountDepositDateWise_RPTEntity.MemberFullName = reader.GetString(FLD_MEMBERFULLNAME); }

            return aCBankAccountDepositDateWise_RPTEntity;
        }
    }
}
