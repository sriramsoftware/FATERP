// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Apr-2013, 01:13:55




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACBalanceSheet_RPTBuilder : IEntityBuilder<ACBalanceSheet_RPTEntity>
    {
        IList<ACBalanceSheet_RPTEntity> IEntityBuilder<ACBalanceSheet_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<ACBalanceSheet_RPTEntity> ACBalanceSheet_RPTEntityList = new List<ACBalanceSheet_RPTEntity>();

            while (reader.Read())
            {
                ACBalanceSheet_RPTEntityList.Add(((IEntityBuilder<ACBalanceSheet_RPTEntity>)this).BuildEntity(reader));
            }

            return (ACBalanceSheet_RPTEntityList.Count > 0) ? ACBalanceSheet_RPTEntityList : null;
        }

        ACBalanceSheet_RPTEntity IEntityBuilder<ACBalanceSheet_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ACCOUNTID = 0;
            const Int32 FLD_DEBITAMOUNT = 1;
            const Int32 FLD_CREDITAMOUNT = 2;
            const Int32 FLD_BALANCE = 3;
            const Int32 FLD_OPENINGBALANCE = 4;
            const Int32 FLD_ACCOUNTGROUPID = 5;
            const Int32 FLD_CLASSID = 6;
            const Int32 FLD_CLASSTYPEID = 7;
            const Int32 FLD_PROJECTID = 8;
            const Int32 FLD_ACCOUNTCODE = 9;
            const Int32 FLD_ACCOUNTNAME = 10;
            const Int32 FLD_ACCOUNTGROUPNAME = 11;
            const Int32 FLD_CLASSNAME = 12;
            const Int32 FLD_CLASSTYPENAME = 13;
            const Int32 FLD_PROJECTCODE = 14;
            const Int32 FLD_PROJECTNAME = 15;

            ACBalanceSheet_RPTEntity aCBalanceSheet_RPTEntity = new ACBalanceSheet_RPTEntity();

            if (reader.IsDBNull(FLD_ACCOUNTID)) { aCBalanceSheet_RPTEntity.AccountID = null; } else { aCBalanceSheet_RPTEntity.AccountID = reader.GetInt64(FLD_ACCOUNTID); }
            aCBalanceSheet_RPTEntity.DebitAmount = reader.GetDecimal(FLD_DEBITAMOUNT);
            aCBalanceSheet_RPTEntity.CreditAmount = reader.GetDecimal(FLD_CREDITAMOUNT);
            if (reader.IsDBNull(FLD_BALANCE)) { aCBalanceSheet_RPTEntity.Balance = null; } else { aCBalanceSheet_RPTEntity.Balance = reader.GetDecimal(FLD_BALANCE); }
            aCBalanceSheet_RPTEntity.OpeningBalance = reader.GetDecimal(FLD_OPENINGBALANCE);
            if (reader.IsDBNull(FLD_ACCOUNTGROUPID)) { aCBalanceSheet_RPTEntity.AccountGroupID = null; } else { aCBalanceSheet_RPTEntity.AccountGroupID = reader.GetInt64(FLD_ACCOUNTGROUPID); }
            if (reader.IsDBNull(FLD_CLASSID)) { aCBalanceSheet_RPTEntity.ClassID = null; } else { aCBalanceSheet_RPTEntity.ClassID = reader.GetInt64(FLD_CLASSID); }
            if (reader.IsDBNull(FLD_CLASSTYPEID)) { aCBalanceSheet_RPTEntity.ClassTypeID = null; } else { aCBalanceSheet_RPTEntity.ClassTypeID = reader.GetInt64(FLD_CLASSTYPEID); }
            if (reader.IsDBNull(FLD_PROJECTID)) { aCBalanceSheet_RPTEntity.ProjectID = null; } else { aCBalanceSheet_RPTEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            aCBalanceSheet_RPTEntity.AccountCode = reader.GetString(FLD_ACCOUNTCODE);
            aCBalanceSheet_RPTEntity.AccountName = reader.GetString(FLD_ACCOUNTNAME);
            aCBalanceSheet_RPTEntity.AccountGroupName = reader.GetString(FLD_ACCOUNTGROUPNAME);
            aCBalanceSheet_RPTEntity.ClassName = reader.GetString(FLD_CLASSNAME);
            aCBalanceSheet_RPTEntity.ClassTypeName = reader.GetString(FLD_CLASSTYPENAME);
            if (reader.IsDBNull(FLD_PROJECTCODE)) { aCBalanceSheet_RPTEntity.ProjectCode = String.Empty; } else { aCBalanceSheet_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { aCBalanceSheet_RPTEntity.ProjectName = String.Empty; } else { aCBalanceSheet_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }

            return aCBalanceSheet_RPTEntity;
        }
    }
}
