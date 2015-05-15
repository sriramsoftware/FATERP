// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Mar-2013, 09:29:16




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACBankAccountTransferBuilder : IEntityBuilder<ACBankAccountTransferEntity>
    {
        IList<ACBankAccountTransferEntity> IEntityBuilder<ACBankAccountTransferEntity>.BuildEntities(IDataReader reader)
        {
            List<ACBankAccountTransferEntity> ACBankAccountTransferEntityList = new List<ACBankAccountTransferEntity>();

            while (reader.Read())
            {
                ACBankAccountTransferEntityList.Add(((IEntityBuilder<ACBankAccountTransferEntity>)this).BuildEntity(reader));
            }

            return (ACBankAccountTransferEntityList.Count > 0) ? ACBankAccountTransferEntityList : null;
        }

        ACBankAccountTransferEntity IEntityBuilder<ACBankAccountTransferEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_CREATEDBYEMPLOYEEID = 9;

            ACBankAccountTransferEntity aCBankAccountTransferEntity = new ACBankAccountTransferEntity();

            aCBankAccountTransferEntity.BankAccountTransferID = reader.GetInt64(FLD_BANKACCOUNTTRANSFERID);
            aCBankAccountTransferEntity.FromBankAccountID = reader.GetInt64(FLD_FROMBANKACCOUNTID);
            aCBankAccountTransferEntity.ToBankAccountID = reader.GetInt64(FLD_TOBANKACCOUNTID);
            aCBankAccountTransferEntity.TransferDate = reader.GetDateTime(FLD_TRANSFERDATE);
            aCBankAccountTransferEntity.Amount = reader.GetDecimal(FLD_AMOUNT);
            if (reader.IsDBNull(FLD_BANKCHARGE)) { aCBankAccountTransferEntity.BankCharge = null; } else { aCBankAccountTransferEntity.BankCharge = reader.GetDecimal(FLD_BANKCHARGE); }
            if (reader.IsDBNull(FLD_MEMO)) { aCBankAccountTransferEntity.Memo = String.Empty; } else { aCBankAccountTransferEntity.Memo = reader.GetString(FLD_MEMO); }
            if (reader.IsDBNull(FLD_REMARKS)) { aCBankAccountTransferEntity.Remarks = String.Empty; } else { aCBankAccountTransferEntity.Remarks = reader.GetString(FLD_REMARKS); }
            aCBankAccountTransferEntity.BankAccountTransferApprovalStatusID = reader.GetInt64(FLD_BANKACCOUNTTRANSFERAPPROVALSTATUSID);
            aCBankAccountTransferEntity.CreatedByEmployeeID = reader.GetInt64(FLD_CREATEDBYEMPLOYEEID);

            return aCBankAccountTransferEntity;
        }
    }
}
