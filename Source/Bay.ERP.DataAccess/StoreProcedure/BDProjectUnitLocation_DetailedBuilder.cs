// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Apr-2013, 03:03:13




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDProjectUnitLocation_DetailedBuilder : IEntityBuilder<BDProjectUnitLocation_DetailedEntity>
    {
        IList<BDProjectUnitLocation_DetailedEntity> IEntityBuilder<BDProjectUnitLocation_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<BDProjectUnitLocation_DetailedEntity> bDProjectUnitLocation_DetailedEntityList = new List<BDProjectUnitLocation_DetailedEntity>();

            while (reader.Read())
            {
                bDProjectUnitLocation_DetailedEntityList.Add(((IEntityBuilder<BDProjectUnitLocation_DetailedEntity>)this).BuildEntity(reader));
            }

            return (bDProjectUnitLocation_DetailedEntityList.Count > 0) ? bDProjectUnitLocation_DetailedEntityList : null;
        }

        BDProjectUnitLocation_DetailedEntity IEntityBuilder<BDProjectUnitLocation_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTUNITLOCATIONID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_PROJECTCODE = 2;
            const Int32 FLD_PROJECTNAME = 3;
            const Int32 FLD_PROJECTFLOORID = 4;
            const Int32 FLD_PROJECTFLOORNAME = 5;
            const Int32 FLD_PROJECTFLOORUNITID = 6;
            const Int32 FLD_PROJECTFLOORUNITNAME = 7;
            const Int32 FLD_FLOORUNITLOCATIONCATEGORYID = 8;
            const Int32 FLD_FLOORUNITLOCATIONCATEGORYNAME = 9;
            const Int32 FLD_PROJECTUNITLOCATIONNAME = 10;
            const Int32 FLD_NETAREASFT = 11;
            const Int32 FLD_GROSSAREASFT = 12;
            const Int32 FLD_MEASUREMENT = 13;
            const Int32 FLD_FACING = 14;
            const Int32 FLD_DIMENSION = 15;
            const Int32 FLD_DESCRIPTION = 16;
            const Int32 FLD_MODIFICATIONDATE = 17;
            const Int32 FLD_MODIFICATIONNOTE = 18;
            const Int32 FLD_SPECIALFEATURES = 19;
            const Int32 FLD_EXTRA1 = 20;
            const Int32 FLD_EXTRA2 = 21;
            const Int32 FLD_ROWNUMBER = 22;



            BDProjectUnitLocation_DetailedEntity bDProjectUnitLocation_DetailedEntity = new BDProjectUnitLocation_DetailedEntity();

            bDProjectUnitLocation_DetailedEntity.ProjectUnitLocationID = reader.GetInt64(FLD_PROJECTUNITLOCATIONID);
            bDProjectUnitLocation_DetailedEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            bDProjectUnitLocation_DetailedEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE);
            bDProjectUnitLocation_DetailedEntity.ProjectName = reader.GetString(FLD_PROJECTNAME);
            if (reader.IsDBNull(FLD_PROJECTFLOORID)) { bDProjectUnitLocation_DetailedEntity.ProjectFloorID = null; } else { bDProjectUnitLocation_DetailedEntity.ProjectFloorID = reader.GetInt64(FLD_PROJECTFLOORID); }
            bDProjectUnitLocation_DetailedEntity.ProjectFloorName = reader.GetString(FLD_PROJECTFLOORNAME);
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITID)) { bDProjectUnitLocation_DetailedEntity.ProjectFloorUnitID = null; } else { bDProjectUnitLocation_DetailedEntity.ProjectFloorUnitID = reader.GetInt64(FLD_PROJECTFLOORUNITID); }
            bDProjectUnitLocation_DetailedEntity.ProjectFloorUnitName = reader.GetString(FLD_PROJECTFLOORUNITNAME);
            bDProjectUnitLocation_DetailedEntity.FloorUnitLocationCategoryID = reader.GetInt64(FLD_FLOORUNITLOCATIONCATEGORYID);
            bDProjectUnitLocation_DetailedEntity.FloorUnitLocationCategoryName = reader.GetString(FLD_FLOORUNITLOCATIONCATEGORYNAME);
            bDProjectUnitLocation_DetailedEntity.ProjectUnitLocationName = reader.GetString(FLD_PROJECTUNITLOCATIONNAME);
            if (reader.IsDBNull(FLD_NETAREASFT)) { bDProjectUnitLocation_DetailedEntity.NetAreaSft = null; } else { bDProjectUnitLocation_DetailedEntity.NetAreaSft = reader.GetDecimal(FLD_NETAREASFT); }
            if (reader.IsDBNull(FLD_GROSSAREASFT)) { bDProjectUnitLocation_DetailedEntity.GrossAreaSft = null; } else { bDProjectUnitLocation_DetailedEntity.GrossAreaSft = reader.GetDecimal(FLD_GROSSAREASFT); }
            if (reader.IsDBNull(FLD_MEASUREMENT)) { bDProjectUnitLocation_DetailedEntity.Measurement = String.Empty; } else { bDProjectUnitLocation_DetailedEntity.Measurement = reader.GetString(FLD_MEASUREMENT); }
            if (reader.IsDBNull(FLD_FACING)) { bDProjectUnitLocation_DetailedEntity.Facing = String.Empty; } else { bDProjectUnitLocation_DetailedEntity.Facing = reader.GetString(FLD_FACING); }
            if (reader.IsDBNull(FLD_DIMENSION)) { bDProjectUnitLocation_DetailedEntity.Dimension = String.Empty; } else { bDProjectUnitLocation_DetailedEntity.Dimension = reader.GetString(FLD_DIMENSION); }
            if (reader.IsDBNull(FLD_DESCRIPTION)) { bDProjectUnitLocation_DetailedEntity.Description = String.Empty; } else { bDProjectUnitLocation_DetailedEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            if (reader.IsDBNull(FLD_MODIFICATIONDATE)) { bDProjectUnitLocation_DetailedEntity.ModificationDate = null; } else { bDProjectUnitLocation_DetailedEntity.ModificationDate = reader.GetDateTime(FLD_MODIFICATIONDATE); }
            if (reader.IsDBNull(FLD_MODIFICATIONNOTE)) { bDProjectUnitLocation_DetailedEntity.ModificationNote = String.Empty; } else { bDProjectUnitLocation_DetailedEntity.ModificationNote = reader.GetString(FLD_MODIFICATIONNOTE); }
            if (reader.IsDBNull(FLD_SPECIALFEATURES)) { bDProjectUnitLocation_DetailedEntity.SpecialFeatures = String.Empty; } else { bDProjectUnitLocation_DetailedEntity.SpecialFeatures = reader.GetString(FLD_SPECIALFEATURES); }
            if (reader.IsDBNull(FLD_EXTRA1)) { bDProjectUnitLocation_DetailedEntity.Extra1 = String.Empty; } else { bDProjectUnitLocation_DetailedEntity.Extra1 = reader.GetString(FLD_EXTRA1); }
            if (reader.IsDBNull(FLD_EXTRA2)) { bDProjectUnitLocation_DetailedEntity.Extra2 = String.Empty; } else { bDProjectUnitLocation_DetailedEntity.Extra2 = reader.GetString(FLD_EXTRA2); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { bDProjectUnitLocation_DetailedEntity.RowNumber = null; } else { bDProjectUnitLocation_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return bDProjectUnitLocation_DetailedEntity;
        }
    }
}
