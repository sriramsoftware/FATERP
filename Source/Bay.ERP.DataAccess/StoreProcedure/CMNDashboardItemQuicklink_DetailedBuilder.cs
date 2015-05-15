// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Mar-2012, 12:28:08




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMNDashboardItemQuicklink_DetailedBuilder : IEntityBuilder<CMNDashboardItemQuicklink_DetailedEntity>
    {
        IList<CMNDashboardItemQuicklink_DetailedEntity> IEntityBuilder<CMNDashboardItemQuicklink_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<CMNDashboardItemQuicklink_DetailedEntity> CMNDashboardItemQuicklink_DetailedEntityList = new List<CMNDashboardItemQuicklink_DetailedEntity>();

            while (reader.Read())
            {
                CMNDashboardItemQuicklink_DetailedEntityList.Add(((IEntityBuilder<CMNDashboardItemQuicklink_DetailedEntity>)this).BuildEntity(reader));
            }

            return (CMNDashboardItemQuicklink_DetailedEntityList.Count > 0) ? CMNDashboardItemQuicklink_DetailedEntityList : null;
        }

        CMNDashboardItemQuicklink_DetailedEntity IEntityBuilder<CMNDashboardItemQuicklink_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_DASHBOARDITEMQUICKLINKID = 0;
            const Int32 FLD_DASHBOARDITEMID = 1;
            const Int32 FLD_NAME = 2;
            const Int32 FLD_NAVIGATIONURL = 3;
            const Int32 FLD_HOVERMESSAGE = 4;
            const Int32 FLD_ISREMOVED = 5;
            const Int32 FLD_DASHBOARDITEMTITLENAME = 6;
            const Int32 FLD_ROWNUMBER = 7;

            CMNDashboardItemQuicklink_DetailedEntity cMNDashboardItemQuicklink_DetailedEntity = new CMNDashboardItemQuicklink_DetailedEntity();

            cMNDashboardItemQuicklink_DetailedEntity.DashboardItemQuicklinkID = reader.GetInt64(FLD_DASHBOARDITEMQUICKLINKID);
            cMNDashboardItemQuicklink_DetailedEntity.DashboardItemID = reader.GetInt64(FLD_DASHBOARDITEMID);
            cMNDashboardItemQuicklink_DetailedEntity.Name = reader.GetString(FLD_NAME);
            cMNDashboardItemQuicklink_DetailedEntity.NavigationUrl = reader.GetString(FLD_NAVIGATIONURL);
            if (reader.IsDBNull(FLD_HOVERMESSAGE)) { cMNDashboardItemQuicklink_DetailedEntity.HoverMessage = String.Empty; } else { cMNDashboardItemQuicklink_DetailedEntity.HoverMessage = reader.GetString(FLD_HOVERMESSAGE); }
            cMNDashboardItemQuicklink_DetailedEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            if (reader.IsDBNull(FLD_DASHBOARDITEMTITLENAME)) { cMNDashboardItemQuicklink_DetailedEntity.DashBoardItemTitleName = String.Empty; } else { cMNDashboardItemQuicklink_DetailedEntity.DashBoardItemTitleName = reader.GetString(FLD_DASHBOARDITEMTITLENAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { cMNDashboardItemQuicklink_DetailedEntity.RowNumber = null; } else { cMNDashboardItemQuicklink_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return cMNDashboardItemQuicklink_DetailedEntity;
        }
    }
}
