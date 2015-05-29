// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Jun-2013, 05:04:04




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACResourceBankAccountMapBuilder : IEntityBuilder<ACResourceBankAccountMapEntity>
    {
        IList<ACResourceBankAccountMapEntity> IEntityBuilder<ACResourceBankAccountMapEntity>.BuildEntities(IDataReader reader)
        {
            List<ACResourceBankAccountMapEntity> ACResourceBankAccountMapEntityList = new List<ACResourceBankAccountMapEntity>();

            while (reader.Read())
            {
                ACResourceBankAccountMapEntityList.Add(((IEntityBuilder<ACResourceBankAccountMapEntity>)this).BuildEntity(reader));
            }

            return (ACResourceBankAccountMapEntityList.Count > 0) ? ACResourceBankAccountMapEntityList : null;
        }

        ACResourceBankAccountMapEntity IEntityBuilder<ACResourceBankAccountMapEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_RESOURCEBANKACCOUNTMAPID = 0;
            const Int32 FLD_ACCOUNTRESOURCECATEGORYID = 1;
            const Int32 FLD_REFERENCEID = 2;
            const Int32 FLD_BANKACCOUNTNAME = 3;
            const Int32 FLD_BANKACCOUNTNUMBER = 4;
            const Int32 FLD_ISDEFAULTCURRENCYACCOUNT = 5;
            const Int32 FLD_BANKNAME = 6;
            const Int32 FLD_BANKADDRESS = 7;
            const Int32 FLD_REMARKS = 8;

            ACResourceBankAccountMapEntity aCResourceBankAccountMapEntity = new ACResourceBankAccountMapEntity();

            aCResourceBankAccountMapEntity.ResourceBankAccountMapID = reader.GetInt64(FLD_RESOURCEBANKACCOUNTMAPID);
            aCResourceBankAccountMapEntity.AccountResourceCategoryID = reader.GetInt64(FLD_ACCOUNTRESOURCECATEGORYID);
            aCResourceBankAccountMapEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID);
            aCResourceBankAccountMapEntity.BankAccountName = reader.GetString(FLD_BANKACCOUNTNAME);
            aCResourceBankAccountMapEntity.BankAccountNumber = reader.GetString(FLD_BANKACCOUNTNUMBER);
            aCResourceBankAccountMapEntity.IsDefaultCurrencyAccount = reader.GetBoolean(FLD_ISDEFAULTCURRENCYACCOUNT);
            aCResourceBankAccountMapEntity.BankName = reader.GetString(FLD_BANKNAME);
            if (reader.IsDBNull(FLD_BANKADDRESS)) { aCResourceBankAccountMapEntity.BankAddress = String.Empty; } else { aCResourceBankAccountMapEntity.BankAddress = reader.GetString(FLD_BANKADDRESS); }
            if (reader.IsDBNull(FLD_REMARKS)) { aCResourceBankAccountMapEntity.Remarks = String.Empty; } else { aCResourceBankAccountMapEntity.Remarks = reader.GetString(FLD_REMARKS); }

            return aCResourceBankAccountMapEntity;
        }
    }
}
