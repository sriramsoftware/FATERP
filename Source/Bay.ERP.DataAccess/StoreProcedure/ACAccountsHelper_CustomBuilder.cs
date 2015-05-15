// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Feb-2013, 02:12:00




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACAccountsHelper_CustomBuilder : IEntityBuilder<ACAccountsHelper_CustomEntity>
    {
        IList<ACAccountsHelper_CustomEntity> IEntityBuilder<ACAccountsHelper_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<ACAccountsHelper_CustomEntity> ACAccountsHelper_CustomEntityList = new List<ACAccountsHelper_CustomEntity>();

            while (reader.Read())
            {
                ACAccountsHelper_CustomEntityList.Add(((IEntityBuilder<ACAccountsHelper_CustomEntity>)this).BuildEntity(reader));
            }

            return (ACAccountsHelper_CustomEntityList.Count > 0) ? ACAccountsHelper_CustomEntityList : null;
        }

        ACAccountsHelper_CustomEntity IEntityBuilder<ACAccountsHelper_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ACCOUNTID = 0;
            const Int32 FLD_CLASSTYPEID = 1;
            const Int32 FLD_ACCOUNTCODE = 2;
            const Int32 FLD_ACCOUNTCODE2 = 3;
            const Int32 FLD_ACCOUNTNAME = 4;
            const Int32 FLD_DESCRIPTION = 5;
            const Int32 FLD_ACCOUNTSTATUSID = 6;
            const Int32 FLD_TAXTYPEID = 7;
            const Int32 FLD_ISREMOVED = 8;
            const Int32 FLD_ACCOUNTCLASSTYPENAME = 9;
            const Int32 FLD_CLASSID = 10;
            const Int32 FLD_ACCOUNTGROUPID = 11;
            const Int32 FLD_ACCOUNTGROUPNAME = 12;
            const Int32 FLD_ACCOUNTCLASSNAME = 13;
            const Int32 FLD_BANKACCOUNTID = 14;
            const Int32 FLD_BANKACCOUNTNAME = 15;

            ACAccountsHelper_CustomEntity aCAccountsHelper_CustomEntity = new ACAccountsHelper_CustomEntity();

            aCAccountsHelper_CustomEntity.AccountID = reader.GetInt64(FLD_ACCOUNTID);
            aCAccountsHelper_CustomEntity.ClassTypeID = reader.GetInt64(FLD_CLASSTYPEID);
            aCAccountsHelper_CustomEntity.AccountCode = reader.GetString(FLD_ACCOUNTCODE);
            if (reader.IsDBNull(FLD_ACCOUNTCODE2)) { aCAccountsHelper_CustomEntity.AccountCode2 = String.Empty; } else { aCAccountsHelper_CustomEntity.AccountCode2 = reader.GetString(FLD_ACCOUNTCODE2); }
            aCAccountsHelper_CustomEntity.AccountName = reader.GetString(FLD_ACCOUNTNAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { aCAccountsHelper_CustomEntity.Description = String.Empty; } else { aCAccountsHelper_CustomEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            aCAccountsHelper_CustomEntity.AccountStatusID = reader.GetInt64(FLD_ACCOUNTSTATUSID);
            aCAccountsHelper_CustomEntity.TaxTypeID = reader.GetInt64(FLD_TAXTYPEID);
            aCAccountsHelper_CustomEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            aCAccountsHelper_CustomEntity.AccountClassTypeName = reader.GetString(FLD_ACCOUNTCLASSTYPENAME);
            aCAccountsHelper_CustomEntity.ClassID = reader.GetInt64(FLD_CLASSID);
            aCAccountsHelper_CustomEntity.AccountGroupID = reader.GetInt64(FLD_ACCOUNTGROUPID);
            aCAccountsHelper_CustomEntity.AccountGroupName = reader.GetString(FLD_ACCOUNTGROUPNAME);
            aCAccountsHelper_CustomEntity.AccountClassName = reader.GetString(FLD_ACCOUNTCLASSNAME);
            if (reader.IsDBNull(FLD_BANKACCOUNTID)) { aCAccountsHelper_CustomEntity.BankAccountID = null; } else { aCAccountsHelper_CustomEntity.BankAccountID = reader.GetInt64(FLD_BANKACCOUNTID); }
            if (reader.IsDBNull(FLD_BANKACCOUNTNAME)) { aCAccountsHelper_CustomEntity.BankAccountName = String.Empty; } else { aCAccountsHelper_CustomEntity.BankAccountName = reader.GetString(FLD_BANKACCOUNTNAME); }

            return aCAccountsHelper_CustomEntity;
        }
    }
}
