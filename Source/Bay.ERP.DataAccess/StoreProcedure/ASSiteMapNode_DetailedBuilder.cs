// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 03:34:29




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ASSiteMapNode_DetailedBuilder : IEntityBuilder<ASSiteMapNode_DetailedEntity>
    {
        IList<ASSiteMapNode_DetailedEntity> IEntityBuilder<ASSiteMapNode_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<ASSiteMapNode_DetailedEntity> ASSiteMapNode_DetailedEntityList = new List<ASSiteMapNode_DetailedEntity>();

            while (reader.Read())
            {
                ASSiteMapNode_DetailedEntityList.Add(((IEntityBuilder<ASSiteMapNode_DetailedEntity>)this).BuildEntity(reader));
            }

            return (ASSiteMapNode_DetailedEntityList.Count > 0) ? ASSiteMapNode_DetailedEntityList : null;
        }

        ASSiteMapNode_DetailedEntity IEntityBuilder<ASSiteMapNode_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ASSITEMAPNODEID = 0;
            const Int32 FLD_ASSITEMAPID = 1;
            const Int32 FLD_ASPHYSICALSITEMAPID = 2;
            const Int32 FLD_MENUTITLE = 3;
            const Int32 FLD_TOOLTIP = 4;
            const Int32 FLD_UNIQUEKEY = 5;
            const Int32 FLD_PARENTASSITEMAPNODEID = 6;
            const Int32 FLD_SEQUENCENUMBER = 7;
            const Int32 FLD_SITEMAPNAME = 8;
            const Int32 FLD_ASPHYSICALSITEMAPNAME = 9;
            const Int32 FLD_PHYSICALPATH = 10;
            const Int32 FLD_NAVIGATIONURL = 11;
            const Int32 FLD_ASPHYSICALSITEMAPUNIQUEKEY = 12;
            const Int32 FLD_MDASNODETYPEID = 13;
            const Int32 FLD_PARENTASPHYSICALSITEMAPID = 14;
            const Int32 FLD_ROWNUMBER = 15;

            ASSiteMapNode_DetailedEntity aSSiteMapNode_DetailedEntity = new ASSiteMapNode_DetailedEntity();

            aSSiteMapNode_DetailedEntity.ASSiteMapNodeID = reader.GetInt64(FLD_ASSITEMAPNODEID);
            aSSiteMapNode_DetailedEntity.ASSiteMapID = reader.GetInt64(FLD_ASSITEMAPID);
            if (reader.IsDBNull(FLD_ASPHYSICALSITEMAPID)) { aSSiteMapNode_DetailedEntity.ASPhysicalSiteMapID = null; } else { aSSiteMapNode_DetailedEntity.ASPhysicalSiteMapID = reader.GetInt64(FLD_ASPHYSICALSITEMAPID); }
            aSSiteMapNode_DetailedEntity.MenuTitle = reader.GetString(FLD_MENUTITLE);
            if (reader.IsDBNull(FLD_TOOLTIP)) { aSSiteMapNode_DetailedEntity.ToolTip = String.Empty; } else { aSSiteMapNode_DetailedEntity.ToolTip = reader.GetString(FLD_TOOLTIP); }
            if (reader.IsDBNull(FLD_UNIQUEKEY)) { aSSiteMapNode_DetailedEntity.UniqueKey = String.Empty; } else { aSSiteMapNode_DetailedEntity.UniqueKey = reader.GetString(FLD_UNIQUEKEY); }
            if (reader.IsDBNull(FLD_PARENTASSITEMAPNODEID)) { aSSiteMapNode_DetailedEntity.ParentASSiteMapNodeID = null; } else { aSSiteMapNode_DetailedEntity.ParentASSiteMapNodeID = reader.GetInt64(FLD_PARENTASSITEMAPNODEID); }
            aSSiteMapNode_DetailedEntity.SequenceNumber = reader.GetInt64(FLD_SEQUENCENUMBER);
            aSSiteMapNode_DetailedEntity.SiteMapName = reader.GetString(FLD_SITEMAPNAME);
            if (reader.IsDBNull(FLD_ASPHYSICALSITEMAPNAME)) { aSSiteMapNode_DetailedEntity.ASPhysicalSiteMapName = String.Empty; } else { aSSiteMapNode_DetailedEntity.ASPhysicalSiteMapName = reader.GetString(FLD_ASPHYSICALSITEMAPNAME); }
            if (reader.IsDBNull(FLD_PHYSICALPATH)) { aSSiteMapNode_DetailedEntity.PhysicalPath = String.Empty; } else { aSSiteMapNode_DetailedEntity.PhysicalPath = reader.GetString(FLD_PHYSICALPATH); }
            if (reader.IsDBNull(FLD_NAVIGATIONURL)) { aSSiteMapNode_DetailedEntity.NavigationURL = String.Empty; } else { aSSiteMapNode_DetailedEntity.NavigationURL = reader.GetString(FLD_NAVIGATIONURL); }
            if (reader.IsDBNull(FLD_ASPHYSICALSITEMAPUNIQUEKEY)) { aSSiteMapNode_DetailedEntity.ASPhysicalSiteMapUniqueKey = String.Empty; } else { aSSiteMapNode_DetailedEntity.ASPhysicalSiteMapUniqueKey = reader.GetString(FLD_ASPHYSICALSITEMAPUNIQUEKEY); }
            if (reader.IsDBNull(FLD_MDASNODETYPEID)) { aSSiteMapNode_DetailedEntity.MDASNodeTypeID = null; } else { aSSiteMapNode_DetailedEntity.MDASNodeTypeID = reader.GetInt64(FLD_MDASNODETYPEID); }
            if (reader.IsDBNull(FLD_PARENTASPHYSICALSITEMAPID)) { aSSiteMapNode_DetailedEntity.ParentASPhysicalSiteMapID = null; } else { aSSiteMapNode_DetailedEntity.ParentASPhysicalSiteMapID = reader.GetInt64(FLD_PARENTASPHYSICALSITEMAPID); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { aSSiteMapNode_DetailedEntity.RowNumber = null; } else { aSSiteMapNode_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return aSSiteMapNode_DetailedEntity;
        }
    }
}
