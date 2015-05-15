// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREmployeeNoticeBuilder : IEntityBuilder<HREmployeeNoticeEntity>
    {
        IList<HREmployeeNoticeEntity> IEntityBuilder<HREmployeeNoticeEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeNoticeEntity> HREmployeeNoticeEntityList = new List<HREmployeeNoticeEntity>();

            while (reader.Read())
            {
                HREmployeeNoticeEntityList.Add(((IEntityBuilder<HREmployeeNoticeEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeNoticeEntityList.Count > 0) ? HREmployeeNoticeEntityList : null;
        }

        HREmployeeNoticeEntity IEntityBuilder<HREmployeeNoticeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEENOTICEID = 0;
            const Int32 FLD_SENDTOEMPLOYEEID = 1;
            const Int32 FLD_MEMO = 2;
            const Int32 FLD_TEXT = 3;
            const Int32 FLD_REMARKS = 4;
            const Int32 FLD_NOTICEDATE = 5;
            const Int32 FLD_PREPAREDBYEMPLOYEEID = 6;
            const Int32 FLD_PREPAREDBYEMPLOYEESALARYLEVEL = 7;
            const Int32 FLD_TEMPLATEID = 8;
            const Int32 FLD_SEENNOTICE = 9;
            const Int32 FLD_VIEWCOUNT = 10;

            HREmployeeNoticeEntity hREmployeeNoticeEntity = new HREmployeeNoticeEntity();

            hREmployeeNoticeEntity.EmployeeNoticeID = reader.GetInt64(FLD_EMPLOYEENOTICEID);
            hREmployeeNoticeEntity.SendToEmployeeID = reader.GetInt64(FLD_SENDTOEMPLOYEEID);
            if (reader.IsDBNull(FLD_MEMO)) { hREmployeeNoticeEntity.Memo = null; } else { hREmployeeNoticeEntity.Memo = reader.GetString(FLD_MEMO); }
            hREmployeeNoticeEntity.Text = reader.GetString(FLD_TEXT);
            if (reader.IsDBNull(FLD_REMARKS)) { hREmployeeNoticeEntity.Remarks = String.Empty; } else { hREmployeeNoticeEntity.Remarks = reader.GetString(FLD_REMARKS); }
            hREmployeeNoticeEntity.NoticeDate = reader.GetDateTime(FLD_NOTICEDATE);
            hREmployeeNoticeEntity.PreparedByEmployeeID = reader.GetInt64(FLD_PREPAREDBYEMPLOYEEID);
            if (reader.IsDBNull(FLD_PREPAREDBYEMPLOYEESALARYLEVEL)) { hREmployeeNoticeEntity.PreparedByEmployeeSalaryLevel = null; } else { hREmployeeNoticeEntity.PreparedByEmployeeSalaryLevel = reader.GetInt32(FLD_PREPAREDBYEMPLOYEESALARYLEVEL); }
            if (reader.IsDBNull(FLD_TEMPLATEID)) { hREmployeeNoticeEntity.TemplateID = null; } else { hREmployeeNoticeEntity.TemplateID = reader.GetInt64(FLD_TEMPLATEID); }
            if (reader.IsDBNull(FLD_SEENNOTICE)) { hREmployeeNoticeEntity.SeenNotice = null; } else { hREmployeeNoticeEntity.SeenNotice = reader.GetDateTime(FLD_SEENNOTICE); }
            if (reader.IsDBNull(FLD_VIEWCOUNT)) { hREmployeeNoticeEntity.ViewCount= null; } else { hREmployeeNoticeEntity.ViewCount = reader.GetInt64(FLD_VIEWCOUNT); }

            return hREmployeeNoticeEntity;
        }
    }
}
