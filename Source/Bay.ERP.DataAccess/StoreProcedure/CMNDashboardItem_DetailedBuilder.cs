// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Feb-2012, 12:56:26




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMNDashboardItem_DetailedBuilder : IEntityBuilder<CMNDashboardItem_DetailedEntity>
    {
        IList<CMNDashboardItem_DetailedEntity> IEntityBuilder<CMNDashboardItem_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<CMNDashboardItem_DetailedEntity> CMNDashboardItem_DetailedEntityList = new List<CMNDashboardItem_DetailedEntity>();

            while (reader.Read())
            {
                CMNDashboardItem_DetailedEntityList.Add(((IEntityBuilder<CMNDashboardItem_DetailedEntity>)this).BuildEntity(reader));
            }

            return (CMNDashboardItem_DetailedEntityList.Count > 0) ? CMNDashboardItem_DetailedEntityList : null;
        }

        CMNDashboardItem_DetailedEntity IEntityBuilder<CMNDashboardItem_DetailedEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_CMNDASHBOARDITEMPARENTDASHBOARDITEMID = 17;
            const Int32 FLD_CMNDASHBOARDITEMPARENTDASHBOARDITEMNAME = 18;
            const Int32 FLD_ROWNUMBER = 19;

            CMNDashboardItem_DetailedEntity cMNDashboardItem_DetailedEntity = new CMNDashboardItem_DetailedEntity();

            cMNDashboardItem_DetailedEntity.DashboardItemID = reader.GetInt64(FLD_DASHBOARDITEMID);
            if (reader.IsDBNull(FLD_PARENTDASHBOARDITEMID)) { cMNDashboardItem_DetailedEntity.ParentDashboardItemID = null; } else { cMNDashboardItem_DetailedEntity.ParentDashboardItemID = reader.GetInt64(FLD_PARENTDASHBOARDITEMID); }
            cMNDashboardItem_DetailedEntity.Title = reader.GetString(FLD_TITLE);
            cMNDashboardItem_DetailedEntity.TittleColor = reader.GetString(FLD_TITTLECOLOR);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { cMNDashboardItem_DetailedEntity.Description = String.Empty; } else { cMNDashboardItem_DetailedEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            cMNDashboardItem_DetailedEntity.DescriptionColor = reader.GetString(FLD_DESCRIPTIONCOLOR);
            cMNDashboardItem_DetailedEntity.ImageUrl = reader.GetString(FLD_IMAGEURL);
            if (reader.IsDBNull(FLD_HOVERIMAGEURL)) { cMNDashboardItem_DetailedEntity.HoverImageUrl = String.Empty; } else { cMNDashboardItem_DetailedEntity.HoverImageUrl = reader.GetString(FLD_HOVERIMAGEURL); }
            cMNDashboardItem_DetailedEntity.NavigationUrl = reader.GetString(FLD_NAVIGATIONURL);
            cMNDashboardItem_DetailedEntity.IsPopup = reader.GetBoolean(FLD_ISPOPUP);
            if (reader.IsDBNull(FLD_HOVERMESSAGE)) { cMNDashboardItem_DetailedEntity.HoverMessage = String.Empty; } else { cMNDashboardItem_DetailedEntity.HoverMessage = reader.GetString(FLD_HOVERMESSAGE); }
            cMNDashboardItem_DetailedEntity.SequenceID = reader.GetInt32(FLD_SEQUENCEID);
            cMNDashboardItem_DetailedEntity.ImageWidth = reader.GetInt32(FLD_IMAGEWIDTH);
            cMNDashboardItem_DetailedEntity.ImageHeight = reader.GetInt32(FLD_IMAGEHEIGHT);
            cMNDashboardItem_DetailedEntity.DashboardItemWidth = reader.GetInt32(FLD_DASHBOARDITEMWIDTH);
            cMNDashboardItem_DetailedEntity.DashboardItemHeight = reader.GetInt32(FLD_DASHBOARDITEMHEIGHT);
            cMNDashboardItem_DetailedEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            if (reader.IsDBNull(FLD_CMNDASHBOARDITEMPARENTDASHBOARDITEMID)) { cMNDashboardItem_DetailedEntity.CMNDashboardItemParentDashboardItemID = null; } else { cMNDashboardItem_DetailedEntity.CMNDashboardItemParentDashboardItemID = reader.GetInt64(FLD_CMNDASHBOARDITEMPARENTDASHBOARDITEMID); }
            if (reader.IsDBNull(FLD_CMNDASHBOARDITEMPARENTDASHBOARDITEMNAME)) { cMNDashboardItem_DetailedEntity.CMNDashboardItemParentDashboardItemName = String.Empty; } else { cMNDashboardItem_DetailedEntity.CMNDashboardItemParentDashboardItemName = reader.GetString(FLD_CMNDASHBOARDITEMPARENTDASHBOARDITEMNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { cMNDashboardItem_DetailedEntity.RowNumber = null; } else { cMNDashboardItem_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return cMNDashboardItem_DetailedEntity;
        }
    }
}
