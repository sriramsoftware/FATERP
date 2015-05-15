// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Feb-2013, 03:00:14



using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACProjectWiseAccountResourceTransaction_CustomBuilder : IEntityBuilder<ACProjectWiseAccountResourceTransaction_CustomEntity>
    {
        IList<ACProjectWiseAccountResourceTransaction_CustomEntity> IEntityBuilder<ACProjectWiseAccountResourceTransaction_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<ACProjectWiseAccountResourceTransaction_CustomEntity> ACProjectWiseAccountResourceTransaction_CustomEntityList = new List<ACProjectWiseAccountResourceTransaction_CustomEntity>();

            while (reader.Read())
            {
                ACProjectWiseAccountResourceTransaction_CustomEntityList.Add(((IEntityBuilder<ACProjectWiseAccountResourceTransaction_CustomEntity>)this).BuildEntity(reader));
            }

            return (ACProjectWiseAccountResourceTransaction_CustomEntityList.Count > 0) ? ACProjectWiseAccountResourceTransaction_CustomEntityList : null;
        }

        ACProjectWiseAccountResourceTransaction_CustomEntity IEntityBuilder<ACProjectWiseAccountResourceTransaction_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ACCOUNTID = 0;
            const Int32 FLD_DEBITAMOUNT = 1;
            const Int32 FLD_CREDITAMOUNT = 2;
            const Int32 FLD_BALANCE = 3;
            const Int32 FLD_ACCOUNTNAME = 4;
            const Int32 FLD_ACCOUNTCODE = 5;
            const Int32 FLD_ACCOUNTGROUPNAME = 6;
            const Int32 FLD_CLASSNAME = 7;
            const Int32 FLD_CLASSTYPENAME = 8;
            const Int32 FLD_ROWNUMBER = 9;

            ACProjectWiseAccountResourceTransaction_CustomEntity aCProjectWiseAccountResourceTransaction_CustomEntity = new ACProjectWiseAccountResourceTransaction_CustomEntity();

            if (reader.IsDBNull(FLD_ACCOUNTID)) { aCProjectWiseAccountResourceTransaction_CustomEntity.AccountID = null; } else { aCProjectWiseAccountResourceTransaction_CustomEntity.AccountID = reader.GetInt64(FLD_ACCOUNTID); }
            aCProjectWiseAccountResourceTransaction_CustomEntity.DebitAmount = reader.GetDecimal(FLD_DEBITAMOUNT);
            aCProjectWiseAccountResourceTransaction_CustomEntity.CreditAmount = reader.GetDecimal(FLD_CREDITAMOUNT);
            if (reader.IsDBNull(FLD_BALANCE)) { aCProjectWiseAccountResourceTransaction_CustomEntity.Balance = null; } else { aCProjectWiseAccountResourceTransaction_CustomEntity.Balance = reader.GetDecimal(FLD_BALANCE); }
            if (reader.IsDBNull(FLD_ACCOUNTNAME)) { aCProjectWiseAccountResourceTransaction_CustomEntity.AccountName = String.Empty; } else { aCProjectWiseAccountResourceTransaction_CustomEntity.AccountName = reader.GetString(FLD_ACCOUNTNAME); }
            if (reader.IsDBNull(FLD_ACCOUNTCODE)) { aCProjectWiseAccountResourceTransaction_CustomEntity.AccountCode = String.Empty; } else { aCProjectWiseAccountResourceTransaction_CustomEntity.AccountCode = reader.GetString(FLD_ACCOUNTCODE); }
            if (reader.IsDBNull(FLD_ACCOUNTGROUPNAME)) { aCProjectWiseAccountResourceTransaction_CustomEntity.AccountGroupName = String.Empty; } else { aCProjectWiseAccountResourceTransaction_CustomEntity.AccountGroupName = reader.GetString(FLD_ACCOUNTGROUPNAME); }
            if (reader.IsDBNull(FLD_CLASSNAME)) { aCProjectWiseAccountResourceTransaction_CustomEntity.ClassName = String.Empty; } else { aCProjectWiseAccountResourceTransaction_CustomEntity.ClassName = reader.GetString(FLD_CLASSNAME); }
            if (reader.IsDBNull(FLD_CLASSTYPENAME)) { aCProjectWiseAccountResourceTransaction_CustomEntity.ClassTypeName = String.Empty; } else { aCProjectWiseAccountResourceTransaction_CustomEntity.ClassTypeName = reader.GetString(FLD_CLASSTYPENAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { aCProjectWiseAccountResourceTransaction_CustomEntity.RowNumber = null; } else { aCProjectWiseAccountResourceTransaction_CustomEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return aCProjectWiseAccountResourceTransaction_CustomEntity;
        }
    }
}
