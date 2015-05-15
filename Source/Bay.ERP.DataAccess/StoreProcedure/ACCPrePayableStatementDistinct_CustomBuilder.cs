// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Jan-2013, 05:19:48




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACCPrePayableStatementDistinct_CustomBuilder : IEntityBuilder<ACCPrePayableStatementDistinct_CustomEntity>
    {
        IList<ACCPrePayableStatementDistinct_CustomEntity> IEntityBuilder<ACCPrePayableStatementDistinct_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<ACCPrePayableStatementDistinct_CustomEntity> ACCPrePayableStatementDistinct_CustomEntityList = new List<ACCPrePayableStatementDistinct_CustomEntity>();

            while (reader.Read())
            {
                ACCPrePayableStatementDistinct_CustomEntityList.Add(((IEntityBuilder<ACCPrePayableStatementDistinct_CustomEntity>)this).BuildEntity(reader));
            }

            return (ACCPrePayableStatementDistinct_CustomEntityList.Count > 0) ? ACCPrePayableStatementDistinct_CustomEntityList : null;
        }

        ACCPrePayableStatementDistinct_CustomEntity IEntityBuilder<ACCPrePayableStatementDistinct_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PREPAYABLESTATEMENTID = 0;
            const Int32 FLD_REF = 1;
            const Int32 FLD_ISLOCKED = 2;

            ACCPrePayableStatementDistinct_CustomEntity aCCPrePayableStatementDistinct_CustomEntity = new ACCPrePayableStatementDistinct_CustomEntity();

            aCCPrePayableStatementDistinct_CustomEntity.PrePayableStatementID = reader.GetInt64(FLD_PREPAYABLESTATEMENTID);
            aCCPrePayableStatementDistinct_CustomEntity.Ref = reader.GetString(FLD_REF);
            if (reader.IsDBNull(FLD_ISLOCKED)) { aCCPrePayableStatementDistinct_CustomEntity.IsLocked = false; } else { aCCPrePayableStatementDistinct_CustomEntity.IsLocked = reader.GetBoolean(FLD_ISLOCKED); }

            return aCCPrePayableStatementDistinct_CustomEntity;
        }
    }
}
