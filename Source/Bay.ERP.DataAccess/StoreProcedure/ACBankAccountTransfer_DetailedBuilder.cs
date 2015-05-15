// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Mar-2013, 01:05:16




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACBankAccountTransfer_DetailedBuilder : IEntityBuilder<ACBankAccountTransfer_DetailedEntity>
    {
        IList<ACBankAccountTransfer_DetailedEntity> IEntityBuilder<ACBankAccountTransfer_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<ACBankAccountTransfer_DetailedEntity> ACBankAccountTransfer_DetailedEntityList = new List<ACBankAccountTransfer_DetailedEntity>();

            while (reader.Read())
            {
                ACBankAccountTransfer_DetailedEntityList.Add(((IEntityBuilder<ACBankAccountTransfer_DetailedEntity>)this).BuildEntity(reader));
            }

            return (ACBankAccountTransfer_DetailedEntityList.Count > 0) ? ACBankAccountTransfer_DetailedEntityList : null;
        }

        ACBankAccountTransfer_DetailedEntity IEntityBuilder<ACBankAccountTransfer_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BANKACCOUNTTRANSFERID = 0;
            const Int32 FLD_FROMBANKACCOUNTID = 1;
            const Int32 FLD_TOBANKACCOUNTID = 2;
            const Int32 FLD_TRANSFERDATE = 3;
            const Int32 FLD_AMOUNT = 4;
            const Int32 FLD_BANKCHARGE = 5;
            const Int32 FLD_MEMO = 6;
            const Int32 FLD_REMARKS = 7;
            const Int32 FLD_BANKACCOUNTTRANSFERAPPROVALSTATUSID = 8;
            const Int32 FLD_FROMBANKACCOUNTNAME = 9;
            const Int32 FLD_TOBANKACCOUNTNAME = 10;
            const Int32 FLD_BANKACCOUNTTRANSFERAPPROVALSTATUSNAME = 11;
            const Int32 FLD_ROWNUMBER = 12;

            ACBankAccountTransfer_DetailedEntity aCBankAccountTransfer_DetailedEntity = new ACBankAccountTransfer_DetailedEntity();

            aCBankAccountTransfer_DetailedEntity.BankAccountTransferID = reader.GetInt64(FLD_BANKACCOUNTTRANSFERID);
            aCBankAccountTransfer_DetailedEntity.FromBankAccountID = reader.GetInt64(FLD_FROMBANKACCOUNTID);
            aCBankAccountTransfer_DetailedEntity.ToBankAccountID = reader.GetInt64(FLD_TOBANKACCOUNTID);
            aCBankAccountTransfer_DetailedEntity.TransferDate = reader.GetDateTime(FLD_TRANSFERDATE);
            aCBankAccountTransfer_DetailedEntity.Amount = reader.GetDecimal(FLD_AMOUNT);
            if (reader.IsDBNull(FLD_BANKCHARGE)) { aCBankAccountTransfer_DetailedEntity.BankCharge = null; } else { aCBankAccountTransfer_DetailedEntity.BankCharge = reader.GetDecimal(FLD_BANKCHARGE); }
            if (reader.IsDBNull(FLD_MEMO)) { aCBankAccountTransfer_DetailedEntity.Memo = String.Empty; } else { aCBankAccountTransfer_DetailedEntity.Memo = reader.GetString(FLD_MEMO); }
            if (reader.IsDBNull(FLD_REMARKS)) { aCBankAccountTransfer_DetailedEntity.Remarks = String.Empty; } else { aCBankAccountTransfer_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            aCBankAccountTransfer_DetailedEntity.BankAccountTransferApprovalStatusID = reader.GetInt64(FLD_BANKACCOUNTTRANSFERAPPROVALSTATUSID);
            if (reader.IsDBNull(FLD_FROMBANKACCOUNTNAME)) { aCBankAccountTransfer_DetailedEntity.FromBankAccountName = String.Empty; } else { aCBankAccountTransfer_DetailedEntity.FromBankAccountName = reader.GetString(FLD_FROMBANKACCOUNTNAME); }
            if (reader.IsDBNull(FLD_TOBANKACCOUNTNAME)) { aCBankAccountTransfer_DetailedEntity.ToBankAccountName = String.Empty; } else { aCBankAccountTransfer_DetailedEntity.ToBankAccountName = reader.GetString(FLD_TOBANKACCOUNTNAME); }
            if (reader.IsDBNull(FLD_BANKACCOUNTTRANSFERAPPROVALSTATUSNAME)) { aCBankAccountTransfer_DetailedEntity.BankAccountTransferApprovalStatusName = String.Empty; } else { aCBankAccountTransfer_DetailedEntity.BankAccountTransferApprovalStatusName = reader.GetString(FLD_BANKACCOUNTTRANSFERAPPROVALSTATUSNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { aCBankAccountTransfer_DetailedEntity.RowNumber = null; } else { aCBankAccountTransfer_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return aCBankAccountTransfer_DetailedEntity;
        }
    }
}
