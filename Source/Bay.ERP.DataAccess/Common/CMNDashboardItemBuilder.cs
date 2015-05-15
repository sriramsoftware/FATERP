// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Feb-2012, 06:02:47




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMNDashboardItemBuilder : IEntityBuilder<CMNDashboardItemEntity>
    {
        IList<CMNDashboardItemEntity> IEntityBuilder<CMNDashboardItemEntity>.BuildEntities(IDataReader reader)
        {
            List<CMNDashboardItemEntity> CMNDashboardItemEntityList = new List<CMNDashboardItemEntity>();

            while (reader.Read())
            {
                CMNDashboardItemEntityList.Add(((IEntityBuilder<CMNDashboardItemEntity>)this).BuildEntity(reader));
            }

            return (CMNDashboardItemEntityList.Count > 0) ? CMNDashboardItemEntityList : null;
        }

        CMNDashboardItemEntity IEntityBuilder<CMNDashboardItemEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_DASHBOARDITEMID = 0;
            const Int32 FLD_PARENTDASHBOARDITEMID = 1;
            const Int32 FLD_TITLE = 2;
            const Int32 FLD_TITTLECOLOR = 3;
            const Int32 FLD_DESCRIPTION = 4;
            const Int32 FLD_DESCRIPTIONCOLOR = 5;
            const Int32 FLD_IMAGEURL = 6;
            const Int32 FLD_HOVERIMAGEURL = 7;
            const Int32 FLD_NAVIGATIONURL = 8;
            const Int32 FLD_ISPOPUP = 9;
            const Int32 FLD_HOVERMESSAGE = 10;
            const Int32 FLD_SEQUENCEID = 11;
            const Int32 FLD_IMAGEWIDTH = 12;
            const Int32 FLD_IMAGEHEIGHT = 13;
            const Int32 FLD_DASHBOARDITEMWIDTH = 14;
            const Int32 FLD_DASHBOARDITEMHEIGHT = 15;
            const Int32 FLD_ISREMOVED = 16;

            CMNDashboardItemEntity cMNDashboardItemEntity = new CMNDashboardItemEntity();

            cMNDashboardItemEntity.DashboardItemID = reader.GetInt64(FLD_DASHBOARDITEMID);
            if (reader.IsDBNull(FLD_PARENTDASHBOARDITEMID)) { cMNDashboardItemEntity.ParentDashboardItemID = null; } else { cMNDashboardItemEntity.ParentDashboardItemID = reader.GetInt64(FLD_PARENTDASHBOARDITEMID); }
            cMNDashboardItemEntity.Title = reader.GetString(FLD_TITLE);
            cMNDashboardItemEntity.TittleColor = reader.GetString(FLD_TITTLECOLOR);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { cMNDashboardItemEntity.Description = String.Empty; } else { cMNDashboardItemEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            cMNDashboardItemEntity.DescriptionColor = reader.GetString(FLD_DESCRIPTIONCOLOR);
            cMNDashboardItemEntity.ImageUrl = reader.GetString(FLD_IMAGEURL);
            if (reader.IsDBNull(FLD_HOVERIMAGEURL)) { cMNDashboardItemEntity.HoverImageUrl = String.Empty; } else { cMNDashboardItemEntity.HoverImageUrl = reader.GetString(FLD_HOVERIMAGEURL); }
            cMNDashboardItemEntity.NavigationUrl = reader.GetString(FLD_NAVIGATIONURL);
            cMNDashboardItemEntity.IsPopup = reader.GetBoolean(FLD_ISPOPUP);
            if (reader.IsDBNull(FLD_HOVERMESSAGE)) { cMNDashboardItemEntity.HoverMessage = String.Empty; } else { cMNDashboardItemEntity.HoverMessage = reader.GetString(FLD_HOVERMESSAGE); }
            cMNDashboardItemEntity.SequenceID = reader.GetInt32(FLD_SEQUENCEID);
            cMNDashboardItemEntity.ImageWidth = reader.GetInt32(FLD_IMAGEWIDTH);
            cMNDashboardItemEntity.ImageHeight = reader.GetInt32(FLD_IMAGEHEIGHT);
            cMNDashboardItemEntity.DashboardItemWidth = reader.GetInt32(FLD_DASHBOARDITEMWIDTH);
            cMNDashboardItemEntity.DashboardItemHeight = reader.GetInt32(FLD_DASHBOARDITEMHEIGHT);
            cMNDashboardItemEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return cMNDashboardItemEntity;
        }
    }
}
