// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 31-Dec-2011, 05:48:38




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class OTSchedule_DetailedBuilder : IEntityBuilder<OTSchedule_DetailedEntity>
    {
        IList<OTSchedule_DetailedEntity> IEntityBuilder<OTSchedule_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<OTSchedule_DetailedEntity> OTSchedule_DetailedEntityList = new List<OTSchedule_DetailedEntity>();

            while (reader.Read())
            {
                OTSchedule_DetailedEntityList.Add(((IEntityBuilder<OTSchedule_DetailedEntity>)this).BuildEntity(reader));
            }

            return (OTSchedule_DetailedEntityList.Count > 0) ? OTSchedule_DetailedEntityList : null;
        }

        OTSchedule_DetailedEntity IEntityBuilder<OTSchedule_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SCHEDULEID = 0;
            const Int32 FLD_SCHEDULEIDENTITYCATEGORYID = 1;
            const Int32 FLD_SCHEDULECATEGORYID = 2;
            const Int32 FLD_REFERENCEID = 3;
            const Int32 FLD_TITLE = 4;
            const Int32 FLD_DESCRIPTION = 5;
            const Int32 FLD_SCHEDULEPRIORITYID = 6;
            const Int32 FLD_CREATEDBYMEMBERID = 7;
            const Int32 FLD_CREATEDATE = 8;
            const Int32 FLD_DURATION = 9;
            const Int32 FLD_STARTDATETIME = 10;
            const Int32 FLD_ENDDATETIME = 11;
            const Int32 FLD_NOTIFYBEFOREMIN = 12;
            const Int32 FLD_ISNOTIFYCOMPLETED = 13;
            const Int32 FLD_REMARKS = 14;
            const Int32 FLD_REFERENCESCHEDULEID = 15;
            const Int32 FLD_ISRESCHEDULED = 16;
            const Int32 FLD_ISREMOVED = 17;
            const Int32 FLD_SCHEDULEIDENTITYCATEGORYNAME = 18;
            const Int32 FLD_SCHEDULECATEGORYNAME = 19;
            const Int32 FLD_SCHEDULEPRIORITYNAME = 20;
            const Int32 FLD_MEMBERFULLNAME = 21;
            const Int32 FLD_SCHEDULESCHEDULEIDENTITYCATEGORYID = 22;
            const Int32 FLD_ROWNUMBER = 23;

            OTSchedule_DetailedEntity oTSchedule_DetailedEntity = new OTSchedule_DetailedEntity();

            oTSchedule_DetailedEntity.ScheduleID = reader.GetInt64(FLD_SCHEDULEID);
            oTSchedule_DetailedEntity.ScheduleIdentityCategoryID = reader.GetInt64(FLD_SCHEDULEIDENTITYCATEGORYID);
            oTSchedule_DetailedEntity.ScheduleCategoryID = reader.GetInt64(FLD_SCHEDULECATEGORYID);
            if (reader.IsDBNull(FLD_REFERENCEID)) { oTSchedule_DetailedEntity.ReferenceID = null; } else { oTSchedule_DetailedEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID); }
            oTSchedule_DetailedEntity.Title = reader.GetString(FLD_TITLE);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { oTSchedule_DetailedEntity.Description = String.Empty; } else { oTSchedule_DetailedEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            oTSchedule_DetailedEntity.SchedulePriorityID = reader.GetInt64(FLD_SCHEDULEPRIORITYID);
            oTSchedule_DetailedEntity.CreatedByMemberID = reader.GetInt64(FLD_CREATEDBYMEMBERID);
            if (reader.IsDBNull(FLD_CREATEDATE)) { oTSchedule_DetailedEntity.CreateDate = null; } else { oTSchedule_DetailedEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE); }
            if (reader.IsDBNull(FLD_DURATION)) { oTSchedule_DetailedEntity.Duration = null; } else { oTSchedule_DetailedEntity.Duration = reader.GetDecimal(FLD_DURATION); }
            if (reader.IsDBNull(FLD_STARTDATETIME)) { oTSchedule_DetailedEntity.StartDateTime = null; } else { oTSchedule_DetailedEntity.StartDateTime = reader.GetDateTime(FLD_STARTDATETIME); }
            if (reader.IsDBNull(FLD_ENDDATETIME)) { oTSchedule_DetailedEntity.EndDateTime = null; } else { oTSchedule_DetailedEntity.EndDateTime = reader.GetDateTime(FLD_ENDDATETIME); }
            if (reader.IsDBNull(FLD_NOTIFYBEFOREMIN)) { oTSchedule_DetailedEntity.NotifyBeforeMin = null; } else { oTSchedule_DetailedEntity.NotifyBeforeMin = reader.GetInt32(FLD_NOTIFYBEFOREMIN); }
            oTSchedule_DetailedEntity.IsNotifyCompleted = reader.GetBoolean(FLD_ISNOTIFYCOMPLETED);
            if (reader.IsDBNull(FLD_REMARKS)) { oTSchedule_DetailedEntity.Remarks = String.Empty; } else { oTSchedule_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_REFERENCESCHEDULEID)) { oTSchedule_DetailedEntity.ReferenceScheduleID = null; } else { oTSchedule_DetailedEntity.ReferenceScheduleID = reader.GetInt64(FLD_REFERENCESCHEDULEID); }
            oTSchedule_DetailedEntity.IsRescheduled = reader.GetBoolean(FLD_ISRESCHEDULED);
            oTSchedule_DetailedEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            if (reader.IsDBNull(FLD_SCHEDULEIDENTITYCATEGORYNAME)) { oTSchedule_DetailedEntity.ScheduleIdentityCategoryName = String.Empty; } else { oTSchedule_DetailedEntity.ScheduleIdentityCategoryName = reader.GetString(FLD_SCHEDULEIDENTITYCATEGORYNAME); }
            if (reader.IsDBNull(FLD_SCHEDULECATEGORYNAME)) { oTSchedule_DetailedEntity.ScheduleCategoryName = String.Empty; } else { oTSchedule_DetailedEntity.ScheduleCategoryName = reader.GetString(FLD_SCHEDULECATEGORYNAME); }
            if (reader.IsDBNull(FLD_SCHEDULEPRIORITYNAME)) { oTSchedule_DetailedEntity.SchedulePriorityName = String.Empty; } else { oTSchedule_DetailedEntity.SchedulePriorityName = reader.GetString(FLD_SCHEDULEPRIORITYNAME); }
            if (reader.IsDBNull(FLD_MEMBERFULLNAME)) { oTSchedule_DetailedEntity.MemberFullName = String.Empty; } else { oTSchedule_DetailedEntity.MemberFullName = reader.GetString(FLD_MEMBERFULLNAME); }
            oTSchedule_DetailedEntity.ScheduleScheduleIdentityCategoryID = reader.GetInt64(FLD_SCHEDULESCHEDULEIDENTITYCATEGORYID);
            if (reader.IsDBNull(FLD_ROWNUMBER)) { oTSchedule_DetailedEntity.RowNumber = null; } else { oTSchedule_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return oTSchedule_DetailedEntity;
        }
    }
}
