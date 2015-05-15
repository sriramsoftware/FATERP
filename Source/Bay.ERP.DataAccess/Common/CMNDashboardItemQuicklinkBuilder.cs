// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Mar-2012, 11:45:48




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMNDashboardItemQuicklinkBuilder : IEntityBuilder<CMNDashboardItemQuicklinkEntity>
    {
        IList<CMNDashboardItemQuicklinkEntity> IEntityBuilder<CMNDashboardItemQuicklinkEntity>.BuildEntities(IDataReader reader)
        {
            List<CMNDashboardItemQuicklinkEntity> CMNDashboardItemQuicklinkEntityList = new List<CMNDashboardItemQuicklinkEntity>();

            while (reader.Read())
            {
                CMNDashboardItemQuicklinkEntityList.Add(((IEntityBuilder<CMNDashboardItemQuicklinkEntity>)this).BuildEntity(reader));
            }

            return (CMNDashboardItemQuicklinkEntityList.Count > 0) ? CMNDashboardItemQuicklinkEntityList : null;
        }

        CMNDashboardItemQuicklinkEntity IEntityBuilder<CMNDashboardItemQuicklinkEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_DASHBOARDITEMQUICKLINKID = 0;
            const Int32 FLD_DASHBOARDITEMID = 1;
            const Int32 FLD_NAME = 2;
            const Int32 FLD_NAVIGATIONURL = 3;
            const Int32 FLD_HOVERMESSAGE = 4;
            const Int32 FLD_ISREMOVED = 5;

            CMNDashboardItemQuicklinkEntity cMNDashboardItemQuicklinkEntity = new CMNDashboardItemQuicklinkEntity();

            cMNDashboardItemQuicklinkEntity.DashboardItemQuicklinkID = reader.GetInt64(FLD_DASHBOARDITEMQUICKLINKID);
            cMNDashboardItemQuicklinkEntity.DashboardItemID = reader.GetInt64(FLD_DASHBOARDITEMID);
            cMNDashboardItemQuicklinkEntity.Name = reader.GetString(FLD_NAME);
            cMNDashboardItemQuicklinkEntity.NavigationUrl = reader.GetString(FLD_NAVIGATIONURL);
            if (reader.IsDBNull(FLD_HOVERMESSAGE)) { cMNDashboardItemQuicklinkEntity.HoverMessage = String.Empty; } else { cMNDashboardItemQuicklinkEntity.HoverMessage = reader.GetString(FLD_HOVERMESSAGE); }
            cMNDashboardItemQuicklinkEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return cMNDashboardItemQuicklinkEntity;
        }
    }
}
