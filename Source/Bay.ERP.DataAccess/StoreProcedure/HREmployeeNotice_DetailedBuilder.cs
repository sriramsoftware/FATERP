// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-May-2013, 11:39:55




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREmployeeNotice_DetailedBuilder : IEntityBuilder<HREmployeeNotice_DetailedEntity>
    {
        IList<HREmployeeNotice_DetailedEntity> IEntityBuilder<HREmployeeNotice_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeNotice_DetailedEntity> HREmployeeNotice_DetailedEntityList = new List<HREmployeeNotice_DetailedEntity>();

            while (reader.Read())
            {
                HREmployeeNotice_DetailedEntityList.Add(((IEntityBuilder<HREmployeeNotice_DetailedEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeNotice_DetailedEntityList.Count > 0) ? HREmployeeNotice_DetailedEntityList : null;
        }

        HREmployeeNotice_DetailedEntity IEntityBuilder<HREmployeeNotice_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEENOTICEID = 0;
            const Int32 FLD_SENDTOEMPLOYEEID = 1;
            const Int32 FLD_SENDTOEMPLOYEENAME = 2;
            const Int32 FLD_TEXT = 3;
            const Int32 FLD_REMARKS = 4;
            const Int32 FLD_NOTICEDATE = 5;
            const Int32 FLD_PREPAREDBYEMPLOYEEID = 6;
            const Int32 FLD_PREPAREDBYEMPLOYEENAME = 7;
            const Int32 FLD_TEMPLATEID = 8;
            const Int32 FLD_TEMPLATENAME = 9;
            const Int32 FLD_SEENNOTICE = 10;
            const Int32 FLD_VIEWCOUNT = 11;
            const Int32 FLD_ROWNUMBER = 12;

            HREmployeeNotice_DetailedEntity hREmployeeNotice_DetailedEntity = new HREmployeeNotice_DetailedEntity();

            hREmployeeNotice_DetailedEntity.EmployeeNoticeID = reader.GetInt64(FLD_EMPLOYEENOTICEID);
            hREmployeeNotice_DetailedEntity.SendToEmployeeID = reader.GetInt64(FLD_SENDTOEMPLOYEEID);
            if (reader.IsDBNull(FLD_SENDTOEMPLOYEENAME)) { hREmployeeNotice_DetailedEntity.SendToEmployeeName = null; } else { hREmployeeNotice_DetailedEntity.SendToEmployeeName = reader.GetString(FLD_SENDTOEMPLOYEENAME); }
            hREmployeeNotice_DetailedEntity.Text = reader.GetString(FLD_TEXT);
            if (reader.IsDBNull(FLD_REMARKS)) { hREmployeeNotice_DetailedEntity.Remarks = String.Empty; } else { hREmployeeNotice_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            hREmployeeNotice_DetailedEntity.NoticeDate = reader.GetDateTime(FLD_NOTICEDATE);
            hREmployeeNotice_DetailedEntity.PreparedByEmployeeID = reader.GetInt64(FLD_PREPAREDBYEMPLOYEEID);
            if (reader.IsDBNull(FLD_PREPAREDBYEMPLOYEENAME)) { hREmployeeNotice_DetailedEntity.PreparedByEmployeeName = null; } else { hREmployeeNotice_DetailedEntity.PreparedByEmployeeName = reader.GetString(FLD_PREPAREDBYEMPLOYEENAME); }
            if (reader.IsDBNull(FLD_TEMPLATEID)) { hREmployeeNotice_DetailedEntity.TemplateID = null; } else { hREmployeeNotice_DetailedEntity.TemplateID = reader.GetInt64(FLD_TEMPLATEID); }
            hREmployeeNotice_DetailedEntity.TemplateName = reader.GetString(FLD_TEMPLATENAME);
            if (reader.IsDBNull(FLD_SEENNOTICE)) { hREmployeeNotice_DetailedEntity.SeenNotice = null; } else { hREmployeeNotice_DetailedEntity.SeenNotice = reader.GetDateTime(FLD_SEENNOTICE); }
            if (reader.IsDBNull(FLD_VIEWCOUNT)) { hREmployeeNotice_DetailedEntity.ViewCount = null; } else { hREmployeeNotice_DetailedEntity.ViewCount = reader.GetInt64(FLD_VIEWCOUNT); }
            hREmployeeNotice_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER);

            return hREmployeeNotice_DetailedEntity;
        }
    }
}
