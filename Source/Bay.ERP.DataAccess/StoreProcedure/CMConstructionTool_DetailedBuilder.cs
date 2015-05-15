// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Feb-2012, 11:55:12




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMConstructionTool_DetailedBuilder : IEntityBuilder<CMConstructionTool_DetailedEntity>
    {
        IList<CMConstructionTool_DetailedEntity> IEntityBuilder<CMConstructionTool_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<CMConstructionTool_DetailedEntity> CMConstructionTool_DetailedEntityList = new List<CMConstructionTool_DetailedEntity>();

            while (reader.Read())
            {
                CMConstructionTool_DetailedEntityList.Add(((IEntityBuilder<CMConstructionTool_DetailedEntity>)this).BuildEntity(reader));
            }

            return (CMConstructionTool_DetailedEntityList.Count > 0) ? CMConstructionTool_DetailedEntityList : null;
        }

        CMConstructionTool_DetailedEntity IEntityBuilder<CMConstructionTool_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CONSTRUCTIONTOOLID = 0;
            const Int32 FLD_CONSTRUCTIONTOOLCATEGORYID = 1;
            const Int32 FLD_TOOLNAME = 2;
            const Int32 FLD_UNITID = 3;
            const Int32 FLD_ISREMOVED = 4;
            const Int32 FLD_CONSTRUCTIONTOOLCATEGORYNAME = 5;
            const Int32 FLD_UNITNAME = 6;
            const Int32 FLD_ROWNUMBER = 7;

            CMConstructionTool_DetailedEntity cMConstructionTool_DetailedEntity = new CMConstructionTool_DetailedEntity();

            cMConstructionTool_DetailedEntity.ConstructionToolID = reader.GetInt64(FLD_CONSTRUCTIONTOOLID);
            if (reader.IsDBNull(FLD_CONSTRUCTIONTOOLCATEGORYID)) { cMConstructionTool_DetailedEntity.ConstructionToolCategoryID = null; } else { cMConstructionTool_DetailedEntity.ConstructionToolCategoryID = reader.GetInt64(FLD_CONSTRUCTIONTOOLCATEGORYID); }
            cMConstructionTool_DetailedEntity.ToolName = reader.GetString(FLD_TOOLNAME);
            if (reader.IsDBNull(FLD_UNITID)) { cMConstructionTool_DetailedEntity.UnitID = null; } else { cMConstructionTool_DetailedEntity.UnitID = reader.GetInt64(FLD_UNITID); }
            cMConstructionTool_DetailedEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            if (reader.IsDBNull(FLD_CONSTRUCTIONTOOLCATEGORYNAME)) { cMConstructionTool_DetailedEntity.ConstructionToolCategoryName = String.Empty; } else { cMConstructionTool_DetailedEntity.ConstructionToolCategoryName = reader.GetString(FLD_CONSTRUCTIONTOOLCATEGORYNAME); }
            if (reader.IsDBNull(FLD_UNITNAME)) { cMConstructionTool_DetailedEntity.UnitName = String.Empty; } else { cMConstructionTool_DetailedEntity.UnitName = reader.GetString(FLD_UNITNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { cMConstructionTool_DetailedEntity.RowNumber = null; } else { cMConstructionTool_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return cMConstructionTool_DetailedEntity;
        }
    }
}
