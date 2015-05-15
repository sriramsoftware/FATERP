// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Feb-2013, 12:02:49




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACAccountOpenCloseBalance_CustomBuilder : IEntityBuilder<ACAccountOpenCloseBalance_CustomEntity>
    {
        IList<ACAccountOpenCloseBalance_CustomEntity> IEntityBuilder<ACAccountOpenCloseBalance_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<ACAccountOpenCloseBalance_CustomEntity> ACAccountOpenCloseBalance_CustomEntityList = new List<ACAccountOpenCloseBalance_CustomEntity>();

            while (reader.Read())
            {
                ACAccountOpenCloseBalance_CustomEntityList.Add(((IEntityBuilder<ACAccountOpenCloseBalance_CustomEntity>)this).BuildEntity(reader));
            }

            return (ACAccountOpenCloseBalance_CustomEntityList.Count > 0) ? ACAccountOpenCloseBalance_CustomEntityList : null;
        }

        ACAccountOpenCloseBalance_CustomEntity IEntityBuilder<ACAccountOpenCloseBalance_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ACCOUNTID = 0;
            const Int32 FLD_CLOSEDEBITAMOUNT = 1;
            const Int32 FLD_CLOSECREDITAMOUNT = 2;
            const Int32 FLD_CLOSEBALANCE = 3;
            const Int32 FLD_ACCOUNTNAME = 4;
            const Int32 FLD_ACCOUNTGROUPNAME = 5;
            const Int32 FLD_CLASSNAME = 6;
            const Int32 FLD_CLASSTYPENAME = 7;
            const Int32 FLD_ACCOUNTCODE = 8;
            const Int32 FLD_OPENBALANCE = 9;
            const Int32 FLD_OPENDEBITAMOUNT = 10;
            const Int32 FLD_OPENCREDITAMOUNT = 11;

            ACAccountOpenCloseBalance_CustomEntity aCAccountOpenCloseBalance_CustomEntity = new ACAccountOpenCloseBalance_CustomEntity();

            if (reader.IsDBNull(FLD_ACCOUNTID)) { aCAccountOpenCloseBalance_CustomEntity.AccountID = null; } else { aCAccountOpenCloseBalance_CustomEntity.AccountID = reader.GetInt64(FLD_ACCOUNTID); }
            aCAccountOpenCloseBalance_CustomEntity.CloseDebitAmount = reader.GetDecimal(FLD_CLOSEDEBITAMOUNT);
            aCAccountOpenCloseBalance_CustomEntity.CloseCreditAmount = reader.GetDecimal(FLD_CLOSECREDITAMOUNT);
            if (reader.IsDBNull(FLD_CLOSEBALANCE)) { aCAccountOpenCloseBalance_CustomEntity.CloseBalance = null; } else { aCAccountOpenCloseBalance_CustomEntity.CloseBalance = reader.GetDecimal(FLD_CLOSEBALANCE); }
            if (reader.IsDBNull(FLD_ACCOUNTNAME)) { aCAccountOpenCloseBalance_CustomEntity.AccountName = String.Empty; } else { aCAccountOpenCloseBalance_CustomEntity.AccountName = reader.GetString(FLD_ACCOUNTNAME); }
            if (reader.IsDBNull(FLD_ACCOUNTGROUPNAME)) { aCAccountOpenCloseBalance_CustomEntity.AccountGroupName = String.Empty; } else { aCAccountOpenCloseBalance_CustomEntity.AccountGroupName = reader.GetString(FLD_ACCOUNTGROUPNAME); }
            if (reader.IsDBNull(FLD_CLASSNAME)) { aCAccountOpenCloseBalance_CustomEntity.ClassName = String.Empty; } else { aCAccountOpenCloseBalance_CustomEntity.ClassName = reader.GetString(FLD_CLASSNAME); }
            if (reader.IsDBNull(FLD_CLASSTYPENAME)) { aCAccountOpenCloseBalance_CustomEntity.ClassTypeName = String.Empty; } else { aCAccountOpenCloseBalance_CustomEntity.ClassTypeName = reader.GetString(FLD_CLASSTYPENAME); }
            if (reader.IsDBNull(FLD_ACCOUNTCODE)) { aCAccountOpenCloseBalance_CustomEntity.AccountCode = String.Empty; } else { aCAccountOpenCloseBalance_CustomEntity.AccountCode = reader.GetString(FLD_ACCOUNTCODE); }
            aCAccountOpenCloseBalance_CustomEntity.OpenBalance = reader.GetDecimal(FLD_OPENBALANCE);
            if (reader.IsDBNull(FLD_OPENDEBITAMOUNT)) { aCAccountOpenCloseBalance_CustomEntity.OpenDebitAmount = null; } else { aCAccountOpenCloseBalance_CustomEntity.OpenDebitAmount = reader.GetDecimal(FLD_OPENDEBITAMOUNT); }
            if (reader.IsDBNull(FLD_OPENCREDITAMOUNT)) { aCAccountOpenCloseBalance_CustomEntity.OpenCreditAmount = null; } else { aCAccountOpenCloseBalance_CustomEntity.OpenCreditAmount = reader.GetDecimal(FLD_OPENCREDITAMOUNT); }

            return aCAccountOpenCloseBalance_CustomEntity;
        }
    }
}
