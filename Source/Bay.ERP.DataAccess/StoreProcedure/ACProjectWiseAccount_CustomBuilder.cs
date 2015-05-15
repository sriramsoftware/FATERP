// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Sep-2013, 04:38:22




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACProjectWiseAccount_CustomBuilder : IEntityBuilder<ACProjectWiseAccount_CustomEntity>
    {
        IList<ACProjectWiseAccount_CustomEntity> IEntityBuilder<ACProjectWiseAccount_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<ACProjectWiseAccount_CustomEntity> ACProjectWiseAccount_CustomEntityList = new List<ACProjectWiseAccount_CustomEntity>();

            while (reader.Read())
            {
                ACProjectWiseAccount_CustomEntityList.Add(((IEntityBuilder<ACProjectWiseAccount_CustomEntity>)this).BuildEntity(reader));
            }

            return (ACProjectWiseAccount_CustomEntityList.Count > 0) ? ACProjectWiseAccount_CustomEntityList : null;
        }

        ACProjectWiseAccount_CustomEntity IEntityBuilder<ACProjectWiseAccount_CustomEntity>.BuildEntity(IDataReader reader)
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

            ACProjectWiseAccount_CustomEntity aCProjectWiseAccount_CustomEntity = new ACProjectWiseAccount_CustomEntity();

            if (reader.IsDBNull(FLD_ACCOUNTID)) { aCProjectWiseAccount_CustomEntity.AccountID = null; } else { aCProjectWiseAccount_CustomEntity.AccountID = reader.GetInt64(FLD_ACCOUNTID); }
            aCProjectWiseAccount_CustomEntity.DebitAmount = reader.GetDecimal(FLD_DEBITAMOUNT);
            aCProjectWiseAccount_CustomEntity.CreditAmount = reader.GetDecimal(FLD_CREDITAMOUNT);
            if (reader.IsDBNull(FLD_BALANCE)) { aCProjectWiseAccount_CustomEntity.Balance = null; } else { aCProjectWiseAccount_CustomEntity.Balance = reader.GetDecimal(FLD_BALANCE); }
            if (reader.IsDBNull(FLD_ACCOUNTGROUPID)) { aCProjectWiseAccount_CustomEntity.AccountGroupID = null; } else { aCProjectWiseAccount_CustomEntity.AccountGroupID = reader.GetInt64(FLD_ACCOUNTGROUPID); }
            if (reader.IsDBNull(FLD_CLASSID)) { aCProjectWiseAccount_CustomEntity.ClassID = null; } else { aCProjectWiseAccount_CustomEntity.ClassID = reader.GetInt64(FLD_CLASSID); }
            if (reader.IsDBNull(FLD_CLASSTYPEID)) { aCProjectWiseAccount_CustomEntity.ClassTypeID = null; } else { aCProjectWiseAccount_CustomEntity.ClassTypeID = reader.GetInt64(FLD_CLASSTYPEID); }
            if (reader.IsDBNull(FLD_PROJECTID)) { aCProjectWiseAccount_CustomEntity.ProjectID = null; } else { aCProjectWiseAccount_CustomEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            aCProjectWiseAccount_CustomEntity.AccountCode = reader.GetString(FLD_ACCOUNTCODE);
            aCProjectWiseAccount_CustomEntity.AccountName = reader.GetString(FLD_ACCOUNTNAME);
            aCProjectWiseAccount_CustomEntity.AccountGroupName = reader.GetString(FLD_ACCOUNTGROUPNAME);
            aCProjectWiseAccount_CustomEntity.ClassName = reader.GetString(FLD_CLASSNAME);
            aCProjectWiseAccount_CustomEntity.ClassTypeName = reader.GetString(FLD_CLASSTYPENAME);
            if (reader.IsDBNull(FLD_PROJECTCODE)) { aCProjectWiseAccount_CustomEntity.ProjectCode = String.Empty; } else { aCProjectWiseAccount_CustomEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { aCProjectWiseAccount_CustomEntity.ProjectName = String.Empty; } else { aCProjectWiseAccount_CustomEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }

            return aCProjectWiseAccount_CustomEntity;
        }
    }
}
