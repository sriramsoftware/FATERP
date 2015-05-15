// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Oct-2013, 03:32:47




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDProjectUnitLocationBuilder : IEntityBuilder<BDProjectUnitLocationEntity>
    {
        IList<BDProjectUnitLocationEntity> IEntityBuilder<BDProjectUnitLocationEntity>.BuildEntities(IDataReader reader)
        {
            List<BDProjectUnitLocationEntity> BDProjectUnitLocationEntityList = new List<BDProjectUnitLocationEntity>();

            while (reader.Read())
            {
                BDProjectUnitLocationEntityList.Add(((IEntityBuilder<BDProjectUnitLocationEntity>)this).BuildEntity(reader));
            }

            return (BDProjectUnitLocationEntityList.Count > 0) ? BDProjectUnitLocationEntityList : null;
        }

        BDProjectUnitLocationEntity IEntityBuilder<BDProjectUnitLocationEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTUNITLOCATIONID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_PROJECTFLOORID = 2;
            const Int32 FLD_PROJECTFLOORUNITID = 3;
            const Int32 FLD_FLOORUNITLOCATIONCATEGORYID = 4;
            const Int32 FLD_NAME = 5;
            const Int32 FLD_NETAREASFT = 6;
            const Int32 FLD_GROSSAREASFT = 7;
            const Int32 FLD_MEASUREMENT = 8;
            const Int32 FLD_FACING = 9;
            const Int32 FLD_DIMENSION = 10;
            const Int32 FLD_DESCRIPTION = 11;
            const Int32 FLD_MODIFICATIONDATE = 12;
            const Int32 FLD_MODIFICATIONNOTE = 13;
            const Int32 FLD_SPECIALFEATURES = 14;
            const Int32 FLD_EXTRA1 = 15;
            const Int32 FLD_EXTRA2 = 16;

            BDProjectUnitLocationEntity bDProjectUnitLocationEntity = new BDProjectUnitLocationEntity();

            bDProjectUnitLocationEntity.ProjectUnitLocationID = reader.GetInt64(FLD_PROJECTUNITLOCATIONID);
            bDProjectUnitLocationEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            if (reader.IsDBNull(FLD_PROJECTFLOORID)) { bDProjectUnitLocationEntity.ProjectFloorID = null; } else { bDProjectUnitLocationEntity.ProjectFloorID = reader.GetInt64(FLD_PROJECTFLOORID); }
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITID)) { bDProjectUnitLocationEntity.ProjectFloorUnitID = null; } else { bDProjectUnitLocationEntity.ProjectFloorUnitID = reader.GetInt64(FLD_PROJECTFLOORUNITID); }
            bDProjectUnitLocationEntity.FloorUnitLocationCategoryID = reader.GetInt64(FLD_FLOORUNITLOCATIONCATEGORYID);
            bDProjectUnitLocationEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_NETAREASFT)) { bDProjectUnitLocationEntity.NetAreaSft = null; } else { bDProjectUnitLocationEntity.NetAreaSft = reader.GetDecimal(FLD_NETAREASFT); }
            if (reader.IsDBNull(FLD_GROSSAREASFT)) { bDProjectUnitLocationEntity.GrossAreaSft = null; } else { bDProjectUnitLocationEntity.GrossAreaSft = reader.GetDecimal(FLD_GROSSAREASFT); }
            if (reader.IsDBNull(FLD_MEASUREMENT)) { bDProjectUnitLocationEntity.Measurement = String.Empty; } else { bDProjectUnitLocationEntity.Measurement = reader.GetString(FLD_MEASUREMENT); }
            if (reader.IsDBNull(FLD_FACING)) { bDProjectUnitLocationEntity.Facing = String.Empty; } else { bDProjectUnitLocationEntity.Facing = reader.GetString(FLD_FACING); }
            if (reader.IsDBNull(FLD_DIMENSION)) { bDProjectUnitLocationEntity.Dimension = String.Empty; } else { bDProjectUnitLocationEntity.Dimension = reader.GetString(FLD_DIMENSION); }
            if (reader.IsDBNull(FLD_DESCRIPTION)) { bDProjectUnitLocationEntity.Description = String.Empty; } else { bDProjectUnitLocationEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            if (reader.IsDBNull(FLD_MODIFICATIONDATE)) { bDProjectUnitLocationEntity.ModificationDate = null; } else { bDProjectUnitLocationEntity.ModificationDate = reader.GetDateTime(FLD_MODIFICATIONDATE); }
            if (reader.IsDBNull(FLD_MODIFICATIONNOTE)) { bDProjectUnitLocationEntity.ModificationNote = String.Empty; } else { bDProjectUnitLocationEntity.ModificationNote = reader.GetString(FLD_MODIFICATIONNOTE); }
            if (reader.IsDBNull(FLD_SPECIALFEATURES)) { bDProjectUnitLocationEntity.SpecialFeatures = String.Empty; } else { bDProjectUnitLocationEntity.SpecialFeatures = reader.GetString(FLD_SPECIALFEATURES); }
            if (reader.IsDBNull(FLD_EXTRA1)) { bDProjectUnitLocationEntity.Extra1 = String.Empty; } else { bDProjectUnitLocationEntity.Extra1 = reader.GetString(FLD_EXTRA1); }
            if (reader.IsDBNull(FLD_EXTRA2)) { bDProjectUnitLocationEntity.Extra2 = String.Empty; } else { bDProjectUnitLocationEntity.Extra2 = reader.GetString(FLD_EXTRA2); }

            return bDProjectUnitLocationEntity;
        }
    }
}
