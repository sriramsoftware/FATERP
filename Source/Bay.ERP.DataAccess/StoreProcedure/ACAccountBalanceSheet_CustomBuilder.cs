// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Apr-2013, 12:28:07




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACAccountBalanceSheet_CustomBuilder : IEntityBuilder<ACAccountBalanceSheet_CustomEntity>
    {
        IList<ACAccountBalanceSheet_CustomEntity> IEntityBuilder<ACAccountBalanceSheet_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<ACAccountBalanceSheet_CustomEntity> ACAccountBalanceSheet_CustomEntityList = new List<ACAccountBalanceSheet_CustomEntity>();

            while (reader.Read())
            {
                ACAccountBalanceSheet_CustomEntityList.Add(((IEntityBuilder<ACAccountBalanceSheet_CustomEntity>)this).BuildEntity(reader));
            }

            return (ACAccountBalanceSheet_CustomEntityList.Count > 0) ? ACAccountBalanceSheet_CustomEntityList : null;
        }

        ACAccountBalanceSheet_CustomEntity IEntityBuilder<ACAccountBalanceSheet_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ACCOUNTID = 0;
            const Int32 FLD_DEBITAMOUNT = 1;
            const Int32 FLD_CREDITAMOUNT = 2;
            const Int32 FLD_BALANCE = 3;
            const Int32 FLD_ACCOUNTGROUPID = 4;
            const Int32 FLD_CLASSID = 5;
            const Int32 FLD_CLASSTYPEID = 6;
            const Int32 FLD_PROJECTID = 7;
            const Int32 FLD_ACCOUNTCODE = 8;
            const Int32 FLD_ACCOUNTNAME = 9;
            const Int32 FLD_ACCOUNTGROUPNAME = 10;
            const Int32 FLD_CLASSNAME = 11;
            const Int32 FLD_CLASSTYPENAME = 12;
            const Int32 FLD_PROJECTCODE = 13;
            const Int32 FLD_PROJECTNAME = 14;

            ACAccountBalanceSheet_CustomEntity aCAccountBalanceSheet_CustomEntity = new ACAccountBalanceSheet_CustomEntity();

            if (reader.IsDBNull(FLD_ACCOUNTID)) { aCAccountBalanceSheet_CustomEntity.AccountID = null; } else { aCAccountBalanceSheet_CustomEntity.AccountID = reader.GetInt64(FLD_ACCOUNTID); }
            aCAccountBalanceSheet_CustomEntity.DebitAmount = reader.GetDecimal(FLD_DEBITAMOUNT);
            aCAccountBalanceSheet_CustomEntity.CreditAmount = reader.GetDecimal(FLD_CREDITAMOUNT);
            if (reader.IsDBNull(FLD_BALANCE)) { aCAccountBalanceSheet_CustomEntity.Balance = null; } else { aCAccountBalanceSheet_CustomEntity.Balance = reader.GetDecimal(FLD_BALANCE); }
            if (reader.IsDBNull(FLD_ACCOUNTGROUPID)) { aCAccountBalanceSheet_CustomEntity.AccountGroupID = null; } else { aCAccountBalanceSheet_CustomEntity.AccountGroupID = reader.GetInt64(FLD_ACCOUNTGROUPID); }
            if (reader.IsDBNull(FLD_CLASSID)) { aCAccountBalanceSheet_CustomEntity.ClassID = null; } else { aCAccountBalanceSheet_CustomEntity.ClassID = reader.GetInt64(FLD_CLASSID); }
            if (reader.IsDBNull(FLD_CLASSTYPEID)) { aCAccountBalanceSheet_CustomEntity.ClassTypeID = null; } else { aCAccountBalanceSheet_CustomEntity.ClassTypeID = reader.GetInt64(FLD_CLASSTYPEID); }
            if (reader.IsDBNull(FLD_PROJECTID)) { aCAccountBalanceSheet_CustomEntity.ProjectID = null; } else { aCAccountBalanceSheet_CustomEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            aCAccountBalanceSheet_CustomEntity.AccountCode = reader.GetString(FLD_ACCOUNTCODE);
            aCAccountBalanceSheet_CustomEntity.AccountName = reader.GetString(FLD_ACCOUNTNAME);
            aCAccountBalanceSheet_CustomEntity.AccountGroupName = reader.GetString(FLD_ACCOUNTGROUPNAME);
            aCAccountBalanceSheet_CustomEntity.ClassName = reader.GetString(FLD_CLASSNAME);
            aCAccountBalanceSheet_CustomEntity.ClassTypeName = reader.GetString(FLD_CLASSTYPENAME);
            if (reader.IsDBNull(FLD_PROJECTCODE)) { aCAccountBalanceSheet_CustomEntity.ProjectCode = String.Empty; } else { aCAccountBalanceSheet_CustomEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { aCAccountBalanceSheet_CustomEntity.ProjectName = String.Empty; } else { aCAccountBalanceSheet_CustomEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }

            return aCAccountBalanceSheet_CustomEntity;
        }
    }
}
