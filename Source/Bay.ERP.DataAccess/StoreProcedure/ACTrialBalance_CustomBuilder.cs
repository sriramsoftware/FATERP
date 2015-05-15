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
    internal sealed class ACTrialBalance_CustomBuilder : IEntityBuilder<ACTrialBalance_CustomEntity>
    {
        IList<ACTrialBalance_CustomEntity> IEntityBuilder<ACTrialBalance_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<ACTrialBalance_CustomEntity> ACTrialBalance_CustomEntityList = new List<ACTrialBalance_CustomEntity>();

            while (reader.Read())
            {
                ACTrialBalance_CustomEntityList.Add(((IEntityBuilder<ACTrialBalance_CustomEntity>)this).BuildEntity(reader));
            }

            return (ACTrialBalance_CustomEntityList.Count > 0) ? ACTrialBalance_CustomEntityList : null;
        }

        ACTrialBalance_CustomEntity IEntityBuilder<ACTrialBalance_CustomEntity>.BuildEntity(IDataReader reader)
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

            ACTrialBalance_CustomEntity aCTrialBalance_CustomEntity = new ACTrialBalance_CustomEntity();

            if (reader.IsDBNull(FLD_ACCOUNTID)) { aCTrialBalance_CustomEntity.AccountID = null; } else { aCTrialBalance_CustomEntity.AccountID = reader.GetInt64(FLD_ACCOUNTID); }
            aCTrialBalance_CustomEntity.DebitAmount = reader.GetDecimal(FLD_DEBITAMOUNT);
            aCTrialBalance_CustomEntity.CreditAmount = reader.GetDecimal(FLD_CREDITAMOUNT);
            if (reader.IsDBNull(FLD_BALANCE)) { aCTrialBalance_CustomEntity.Balance = null; } else { aCTrialBalance_CustomEntity.Balance = reader.GetDecimal(FLD_BALANCE); }
            if (reader.IsDBNull(FLD_CLASSID)) { aCTrialBalance_CustomEntity.ClassID = null; } else { aCTrialBalance_CustomEntity.ClassID = reader.GetInt64(FLD_CLASSID); }
            if (reader.IsDBNull(FLD_CLASSTYPEID)) { aCTrialBalance_CustomEntity.ClassTypeID = null; } else { aCTrialBalance_CustomEntity.ClassTypeID = reader.GetInt64(FLD_CLASSTYPEID); }
            if (reader.IsDBNull(FLD_PROJECTID)) { aCTrialBalance_CustomEntity.ProjectID = null; } else { aCTrialBalance_CustomEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            aCTrialBalance_CustomEntity.AccountCode = reader.GetString(FLD_ACCOUNTCODE);
            aCTrialBalance_CustomEntity.AccountName = reader.GetString(FLD_ACCOUNTNAME);
            aCTrialBalance_CustomEntity.AccountGroupName = reader.GetString(FLD_ACCOUNTGROUPNAME);
            if (reader.IsDBNull(FLD_ACCOUNTGROUPID)) { aCTrialBalance_CustomEntity.AccountGroupID = null; } else { aCTrialBalance_CustomEntity.AccountGroupID = reader.GetInt64(FLD_ACCOUNTGROUPID); }
            aCTrialBalance_CustomEntity.ClassName = reader.GetString(FLD_CLASSNAME);
            aCTrialBalance_CustomEntity.ClassTypeName = reader.GetString(FLD_CLASSTYPENAME);
            if (reader.IsDBNull(FLD_PROJECTCODE)) { aCTrialBalance_CustomEntity.ProjectCode = String.Empty; } else { aCTrialBalance_CustomEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { aCTrialBalance_CustomEntity.ProjectName = String.Empty; } else { aCTrialBalance_CustomEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }

            return aCTrialBalance_CustomEntity;
        }
    }
}
