// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jan-2013, 04:44:22




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACBankAccount_DetailedBuilder : IEntityBuilder<ACBankAccount_DetailedEntity>
    {
        IList<ACBankAccount_DetailedEntity> IEntityBuilder<ACBankAccount_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<ACBankAccount_DetailedEntity> ACBankAccount_DetailedEntityList = new List<ACBankAccount_DetailedEntity>();

            while (reader.Read())
            {
                ACBankAccount_DetailedEntityList.Add(((IEntityBuilder<ACBankAccount_DetailedEntity>)this).BuildEntity(reader));
            }

            return (ACBankAccount_DetailedEntityList.Count > 0) ? ACBankAccount_DetailedEntityList : null;
        }

        ACBankAccount_DetailedEntity IEntityBuilder<ACBankAccount_DetailedEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_ACCOUNTNAME = 9;
            const Int32 FLD_BANKACCOUNTTYPENAME = 10;
            const Int32 FLD_CURRENCYNAME = 11;
            const Int32 FLD_ROWNUMBER = 12;

            ACBankAccount_DetailedEntity aCBankAccount_DetailedEntity = new ACBankAccount_DetailedEntity();

            aCBankAccount_DetailedEntity.BankAccountID = reader.GetInt64(FLD_BANKACCOUNTID);
            aCBankAccount_DetailedEntity.ACCAccountID = reader.GetInt64(FLD_ACCACCOUNTID);
            aCBankAccount_DetailedEntity.BankAccountName = reader.GetString(FLD_BANKACCOUNTNAME);
            aCBankAccount_DetailedEntity.BankAccountNumber = reader.GetString(FLD_BANKACCOUNTNUMBER);
            aCBankAccount_DetailedEntity.BankAccountTypeID = reader.GetInt64(FLD_BANKACCOUNTTYPEID);
            aCBankAccount_DetailedEntity.CurrencyID = reader.GetInt64(FLD_CURRENCYID);
            aCBankAccount_DetailedEntity.IsDefaultCurrencyAccount = reader.GetBoolean(FLD_ISDEFAULTCURRENCYACCOUNT);
            aCBankAccount_DetailedEntity.BankName = reader.GetString(FLD_BANKNAME);
            if (reader.IsDBNull(FLD_BANKADDRESS)) { aCBankAccount_DetailedEntity.BankAddress = String.Empty; } else { aCBankAccount_DetailedEntity.BankAddress = reader.GetString(FLD_BANKADDRESS); }
            if (reader.IsDBNull(FLD_ACCOUNTNAME)) { aCBankAccount_DetailedEntity.AccountName = String.Empty; } else { aCBankAccount_DetailedEntity.AccountName = reader.GetString(FLD_ACCOUNTNAME); }
            if (reader.IsDBNull(FLD_BANKACCOUNTTYPENAME)) { aCBankAccount_DetailedEntity.BankAccountTypeName = String.Empty; } else { aCBankAccount_DetailedEntity.BankAccountTypeName = reader.GetString(FLD_BANKACCOUNTTYPENAME); }
            if (reader.IsDBNull(FLD_CURRENCYNAME)) { aCBankAccount_DetailedEntity.CurrencyName = String.Empty; } else { aCBankAccount_DetailedEntity.CurrencyName = reader.GetString(FLD_CURRENCYNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { aCBankAccount_DetailedEntity.RowNumber = null; } else { aCBankAccount_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return aCBankAccount_DetailedEntity;
        }
    }
}
