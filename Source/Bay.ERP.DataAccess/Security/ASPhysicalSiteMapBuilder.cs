// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 03:24:04




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ASPhysicalSiteMapBuilder : IEntityBuilder<ASPhysicalSiteMapEntity>
    {
        IList<ASPhysicalSiteMapEntity> IEntityBuilder<ASPhysicalSiteMapEntity>.BuildEntities(IDataReader reader)
        {
            List<ASPhysicalSiteMapEntity> ASPhysicalSiteMapEntityList = new List<ASPhysicalSiteMapEntity>();

            while (reader.Read())
            {
                ASPhysicalSiteMapEntityList.Add(((IEntityBuilder<ASPhysicalSiteMapEntity>)this).BuildEntity(reader));
            }

            return (ASPhysicalSiteMapEntityList.Count > 0) ? ASPhysicalSiteMapEntityList : null;
        }

        ASPhysicalSiteMapEntity IEntityBuilder<ASPhysicalSiteMapEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ASPHYSICALSITEMAPID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_PHYSICALPATH = 2;
            const Int32 FLD_NAVIGATIONURL = 3;
            const Int32 FLD_UNIQUEKEY = 4;
            const Int32 FLD_MDASNODETYPEID = 5;
            const Int32 FLD_PARENTASPHYSICALSITEMAPID = 6;

            ASPhysicalSiteMapEntity aSPhysicalSiteMapEntity = new ASPhysicalSiteMapEntity();

            aSPhysicalSiteMapEntity.ASPhysicalSiteMapID = reader.GetInt64(FLD_ASPHYSICALSITEMAPID);
            aSPhysicalSiteMapEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_PHYSICALPATH)) { aSPhysicalSiteMapEntity.PhysicalPath = String.Empty; } else { aSPhysicalSiteMapEntity.PhysicalPath = reader.GetString(FLD_PHYSICALPATH); }
            if (reader.IsDBNull(FLD_NAVIGATIONURL)) { aSPhysicalSiteMapEntity.NavigationURL = String.Empty; } else { aSPhysicalSiteMapEntity.NavigationURL = reader.GetString(FLD_NAVIGATIONURL); }
            if (reader.IsDBNull(FLD_UNIQUEKEY)) { aSPhysicalSiteMapEntity.UniqueKey = String.Empty; } else { aSPhysicalSiteMapEntity.UniqueKey = reader.GetString(FLD_UNIQUEKEY); }
            aSPhysicalSiteMapEntity.MDASNodeTypeID = reader.GetInt64(FLD_MDASNODETYPEID);
            if (reader.IsDBNull(FLD_PARENTASPHYSICALSITEMAPID)) { aSPhysicalSiteMapEntity.ParentASPhysicalSiteMapID = null; } else { aSPhysicalSiteMapEntity.ParentASPhysicalSiteMapID = reader.GetInt64(FLD_PARENTASPHYSICALSITEMAPID); }

            return aSPhysicalSiteMapEntity;
        }
    }
}
