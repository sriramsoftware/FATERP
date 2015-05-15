// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jan-2013, 02:50:43




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACBankAccountBuilder : IEntityBuilder<ACBankAccountEntity>
    {
        IList<ACBankAccountEntity> IEntityBuilder<ACBankAccountEntity>.BuildEntities(IDataReader reader)
        {
            List<ACBankAccountEntity> ACBankAccountEntityList = new List<ACBankAccountEntity>();

            while (reader.Read())
            {
                ACBankAccountEntityList.Add(((IEntityBuilder<ACBankAccountEntity>)this).BuildEntity(reader));
            }

            return (ACBankAccountEntityList.Count > 0) ? ACBankAccountEntityList : null;
        }

        ACBankAccountEntity IEntityBuilder<ACBankAccountEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BANKACCOUNTID = 0;
            const Int32 FLD_ACCACCOUNTID = 1;
            const Int32 FLD_BANKACCOUNTNAME = 2;
            const Int32 FLD_BANKACCOUNTNUMBER = 3;
            const Int32 FLD_BANKACCOUNTTYPEID = 4;
            const Int32 FLD_CURRENCYID = 5;
            const Int32 FLD_ISDEFAULTCURRENCYACCOUNT = 6;
            const Int32 FLD_BANKNAME = 7;
            const Int32 FLD_BANKADDRESS = 8;

            ACBankAccountEntity aCBankAccountEntity = new ACBankAccountEntity();

            aCBankAccountEntity.BankAccountID = reader.GetInt64(FLD_BANKACCOUNTID);
            aCBankAccountEntity.ACCAccountID = reader.GetInt64(FLD_ACCACCOUNTID);
            aCBankAccountEntity.BankAccountName = reader.GetString(FLD_BANKACCOUNTNAME);
            aCBankAccountEntity.BankAccountNumber = reader.GetString(FLD_BANKACCOUNTNUMBER);
            aCBankAccountEntity.BankAccountTypeID = reader.GetInt64(FLD_BANKACCOUNTTYPEID);
            aCBankAccountEntity.CurrencyID = reader.GetInt64(FLD_CURRENCYID);
            aCBankAccountEntity.IsDefaultCurrencyAccount = reader.GetBoolean(FLD_ISDEFAULTCURRENCYACCOUNT);
            aCBankAccountEntity.BankName = reader.GetString(FLD_BANKNAME);
            if (reader.IsDBNull(FLD_BANKADDRESS)) { aCBankAccountEntity.BankAddress = String.Empty; } else { aCBankAccountEntity.BankAddress = reader.GetString(FLD_BANKADDRESS); }

            return aCBankAccountEntity;
        }
    }
}
