// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Dec-2012, 01:14:46




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomBuilder : IEntityBuilder<ACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomEntity>
    {
        IList<ACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomEntity> IEntityBuilder<ACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<ACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomEntity> ACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomEntityList = new List<ACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomEntity>();

            while (reader.Read())
            {
                ACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomEntityList.Add(((IEntityBuilder<ACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomEntity>)this).BuildEntity(reader));
            }

            return (ACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomEntityList.Count > 0) ? ACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomEntityList : null;
        }

        ACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomEntity IEntityBuilder<ACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_POSTPAYABLESTATEMENTID = 0;

            ACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomEntity aCCPrePayableStatementtoACCPostPayableStatementMigrate_CustomEntity = new ACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomEntity();

            if (reader.IsDBNull(FLD_POSTPAYABLESTATEMENTID)) { aCCPrePayableStatementtoACCPostPayableStatementMigrate_CustomEntity.POSTPAYABLESTATEMENTID = null; } else { aCCPrePayableStatementtoACCPostPayableStatementMigrate_CustomEntity.POSTPAYABLESTATEMENTID = reader.GetInt64(FLD_POSTPAYABLESTATEMENTID); }

            return aCCPrePayableStatementtoACCPostPayableStatementMigrate_CustomEntity;
        }
    }
}
