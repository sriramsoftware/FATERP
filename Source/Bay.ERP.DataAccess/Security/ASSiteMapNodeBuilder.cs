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
    internal sealed class ASSiteMapNodeBuilder : IEntityBuilder<ASSiteMapNodeEntity>
    {
        IList<ASSiteMapNodeEntity> IEntityBuilder<ASSiteMapNodeEntity>.BuildEntities(IDataReader reader)
        {
            List<ASSiteMapNodeEntity> ASSiteMapNodeEntityList = new List<ASSiteMapNodeEntity>();

            while (reader.Read())
            {
                ASSiteMapNodeEntityList.Add(((IEntityBuilder<ASSiteMapNodeEntity>)this).BuildEntity(reader));
            }

            return (ASSiteMapNodeEntityList.Count > 0) ? ASSiteMapNodeEntityList : null;
        }

        ASSiteMapNodeEntity IEntityBuilder<ASSiteMapNodeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ASSITEMAPNODEID = 0;
            const Int32 FLD_ASSITEMAPID = 1;
            const Int32 FLD_ASPHYSICALSITEMAPID = 2;
            const Int32 FLD_MENUTITLE = 3;
            const Int32 FLD_TOOLTIP = 4;
            const Int32 FLD_UNIQUEKEY = 5;
            const Int32 FLD_PARENTASSITEMAPNODEID = 6;
            const Int32 FLD_SEQUENCENUMBER = 7;

            ASSiteMapNodeEntity aSSiteMapNodeEntity = new ASSiteMapNodeEntity();

            aSSiteMapNodeEntity.ASSiteMapNodeID = reader.GetInt64(FLD_ASSITEMAPNODEID);
            aSSiteMapNodeEntity.ASSiteMapID = reader.GetInt64(FLD_ASSITEMAPID);
            if (reader.IsDBNull(FLD_ASPHYSICALSITEMAPID)) { aSSiteMapNodeEntity.ASPhysicalSiteMapID = null; } else { aSSiteMapNodeEntity.ASPhysicalSiteMapID = reader.GetInt64(FLD_ASPHYSICALSITEMAPID); }
            aSSiteMapNodeEntity.MenuTitle = reader.GetString(FLD_MENUTITLE);
            if (reader.IsDBNull(FLD_TOOLTIP)) { aSSiteMapNodeEntity.ToolTip = String.Empty; } else { aSSiteMapNodeEntity.ToolTip = reader.GetString(FLD_TOOLTIP); }
            if (reader.IsDBNull(FLD_UNIQUEKEY)) { aSSiteMapNodeEntity.UniqueKey = String.Empty; } else { aSSiteMapNodeEntity.UniqueKey = reader.GetString(FLD_UNIQUEKEY); }
            if (reader.IsDBNull(FLD_PARENTASSITEMAPNODEID)) { aSSiteMapNodeEntity.ParentASSiteMapNodeID = null; } else { aSSiteMapNodeEntity.ParentASSiteMapNodeID = reader.GetInt64(FLD_PARENTASSITEMAPNODEID); }
            aSSiteMapNodeEntity.SequenceNumber = reader.GetInt64(FLD_SEQUENCENUMBER);

            return aSSiteMapNodeEntity;
        }
    }
}
