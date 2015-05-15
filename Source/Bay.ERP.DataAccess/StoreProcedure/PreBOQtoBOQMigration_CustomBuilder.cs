// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-May-2012, 04:28:13




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PreBOQtoBOQMigration_CustomBuilder : IEntityBuilder<PreBOQtoBOQMigration_CustomEntity>
    {
        IList<PreBOQtoBOQMigration_CustomEntity> IEntityBuilder<PreBOQtoBOQMigration_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<PreBOQtoBOQMigration_CustomEntity> PreBOQtoBOQMigration_CustomEntityList = new List<PreBOQtoBOQMigration_CustomEntity>();

            while (reader.Read())
            {
                PreBOQtoBOQMigration_CustomEntityList.Add(((IEntityBuilder<PreBOQtoBOQMigration_CustomEntity>)this).BuildEntity(reader));
            }

            return (PreBOQtoBOQMigration_CustomEntityList.Count > 0) ? PreBOQtoBOQMigration_CustomEntityList : null;
        }

        PreBOQtoBOQMigration_CustomEntity IEntityBuilder<PreBOQtoBOQMigration_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BOQID = 0;

            PreBOQtoBOQMigration_CustomEntity preBOQtoBOQMigration_CustomEntity = new PreBOQtoBOQMigration_CustomEntity();

            if (reader.IsDBNull(FLD_BOQID)) { preBOQtoBOQMigration_CustomEntity.BOQID = null; } else { preBOQtoBOQMigration_CustomEntity.BOQID = reader.GetInt64(FLD_BOQID); }

            return preBOQtoBOQMigration_CustomEntity;
        }
    }
}
