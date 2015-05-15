// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Jan-2012, 03:00:49




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMConstructionToolBuilder : IEntityBuilder<CMConstructionToolEntity>
    {
        IList<CMConstructionToolEntity> IEntityBuilder<CMConstructionToolEntity>.BuildEntities(IDataReader reader)
        {
            List<CMConstructionToolEntity> CMConstructionToolEntityList = new List<CMConstructionToolEntity>();

            while (reader.Read())
            {
                CMConstructionToolEntityList.Add(((IEntityBuilder<CMConstructionToolEntity>)this).BuildEntity(reader));
            }

            return (CMConstructionToolEntityList.Count > 0) ? CMConstructionToolEntityList : null;
        }

        CMConstructionToolEntity IEntityBuilder<CMConstructionToolEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CONSTRUCTIONTOOLID = 0;
            const Int32 FLD_CONSTRUCTIONTOOLCATEGORYID = 1;
            const Int32 FLD_TOOLNAME = 2;
            const Int32 FLD_UNITID = 3;
            const Int32 FLD_ISREMOVED = 4;

            CMConstructionToolEntity cMConstructionToolEntity = new CMConstructionToolEntity();

            cMConstructionToolEntity.ConstructionToolID = reader.GetInt64(FLD_CONSTRUCTIONTOOLID);
            if (reader.IsDBNull(FLD_CONSTRUCTIONTOOLCATEGORYID)) { cMConstructionToolEntity.ConstructionToolCategoryID = null; } else { cMConstructionToolEntity.ConstructionToolCategoryID = reader.GetInt64(FLD_CONSTRUCTIONTOOLCATEGORYID); }
            cMConstructionToolEntity.ToolName = reader.GetString(FLD_TOOLNAME);
            if (reader.IsDBNull(FLD_UNITID)) { cMConstructionToolEntity.UnitID = null; } else { cMConstructionToolEntity.UnitID = reader.GetInt64(FLD_UNITID); }
            cMConstructionToolEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return cMConstructionToolEntity;
        }
    }
}
