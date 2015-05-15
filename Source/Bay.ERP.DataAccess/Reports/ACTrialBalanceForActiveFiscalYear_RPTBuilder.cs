// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Apr-2013, 11:16:54




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACTrialBalanceForActiveFiscalYear_RPTBuilder : IEntityBuilder<ACTrialBalanceForActiveFiscalYear_RPTEntity>
    {
        IList<ACTrialBalanceForActiveFiscalYear_RPTEntity> IEntityBuilder<ACTrialBalanceForActiveFiscalYear_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<ACTrialBalanceForActiveFiscalYear_RPTEntity> ACTrialBalanceForActiveFiscalYear_RPTEntityList = new List<ACTrialBalanceForActiveFiscalYear_RPTEntity>();

            while (reader.Read())
            {
                ACTrialBalanceForActiveFiscalYear_RPTEntityList.Add(((IEntityBuilder<ACTrialBalanceForActiveFiscalYear_RPTEntity>)this).BuildEntity(reader));
            }

            return (ACTrialBalanceForActiveFiscalYear_RPTEntityList.Count > 0) ? ACTrialBalanceForActiveFiscalYear_RPTEntityList : null;
        }

        ACTrialBalanceForActiveFiscalYear_RPTEntity IEntityBuilder<ACTrialBalanceForActiveFiscalYear_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ACCOUNTID = 0;
            const Int32 FLD_DEBITAMOUNT = 1;
            const Int32 FLD_CREDITAMOUNT = 2;
            const Int32 FLD_BALANCE = 3;
            const Int32 FLD_CLASSID = 4;
            const Int32 FLD_CLASSTYPEID = 5;
            const Int32 FLD_PROJECTID = 6;
            const Int32 FLD_ACCOUNTCODE = 7;
            const Int32 FLD_ACCOUNTNAME = 8;
            const Int32 FLD_ACCOUNTGROUPNAME = 9;
            const Int32 FLD_ACCOUNTGROUPID = 10;
            const Int32 FLD_CLASSNAME = 11;
            const Int32 FLD_CLASSTYPENAME = 12;
            const Int32 FLD_PROJECTCODE = 13;
            const Int32 FLD_PROJECTNAME = 14;

            ACTrialBalanceForActiveFiscalYear_RPTEntity aCTrialBalanceForActiveFiscalYear_RPTEntity = new ACTrialBalanceForActiveFiscalYear_RPTEntity();

            if (reader.IsDBNull(FLD_ACCOUNTID)) { aCTrialBalanceForActiveFiscalYear_RPTEntity.AccountID = null; } else { aCTrialBalanceForActiveFiscalYear_RPTEntity.AccountID = reader.GetInt64(FLD_ACCOUNTID); }
            aCTrialBalanceForActiveFiscalYear_RPTEntity.DebitAmount = reader.GetDecimal(FLD_DEBITAMOUNT);
            aCTrialBalanceForActiveFiscalYear_RPTEntity.CreditAmount = reader.GetDecimal(FLD_CREDITAMOUNT);
            if (reader.IsDBNull(FLD_BALANCE)) { aCTrialBalanceForActiveFiscalYear_RPTEntity.Balance = null; } else { aCTrialBalanceForActiveFiscalYear_RPTEntity.Balance = reader.GetDecimal(FLD_BALANCE); }
            if (reader.IsDBNull(FLD_CLASSID)) { aCTrialBalanceForActiveFiscalYear_RPTEntity.ClassID = null; } else { aCTrialBalanceForActiveFiscalYear_RPTEntity.ClassID = reader.GetInt64(FLD_CLASSID); }
            if (reader.IsDBNull(FLD_CLASSTYPEID)) { aCTrialBalanceForActiveFiscalYear_RPTEntity.ClassTypeID = null; } else { aCTrialBalanceForActiveFiscalYear_RPTEntity.ClassTypeID = reader.GetInt64(FLD_CLASSTYPEID); }
            if (reader.IsDBNull(FLD_PROJECTID)) { aCTrialBalanceForActiveFiscalYear_RPTEntity.ProjectID = null; } else { aCTrialBalanceForActiveFiscalYear_RPTEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            aCTrialBalanceForActiveFiscalYear_RPTEntity.AccountCode = reader.GetString(FLD_ACCOUNTCODE);
            aCTrialBalanceForActiveFiscalYear_RPTEntity.AccountName = reader.GetString(FLD_ACCOUNTNAME);
            aCTrialBalanceForActiveFiscalYear_RPTEntity.AccountGroupName = reader.GetString(FLD_ACCOUNTGROUPNAME);
            if (reader.IsDBNull(FLD_ACCOUNTGROUPID)) { aCTrialBalanceForActiveFiscalYear_RPTEntity.AccountGroupID = null; } else { aCTrialBalanceForActiveFiscalYear_RPTEntity.AccountGroupID = reader.GetInt64(FLD_ACCOUNTGROUPID); }
            aCTrialBalanceForActiveFiscalYear_RPTEntity.ClassName = reader.GetString(FLD_CLASSNAME);
            aCTrialBalanceForActiveFiscalYear_RPTEntity.ClassTypeName = reader.GetString(FLD_CLASSTYPENAME);
            if (reader.IsDBNull(FLD_PROJECTCODE)) { aCTrialBalanceForActiveFiscalYear_RPTEntity.ProjectCode = String.Empty; } else { aCTrialBalanceForActiveFiscalYear_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { aCTrialBalanceForActiveFiscalYear_RPTEntity.ProjectName = String.Empty; } else { aCTrialBalanceForActiveFiscalYear_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }

            return aCTrialBalanceForActiveFiscalYear_RPTEntity;
        }
    }
}
