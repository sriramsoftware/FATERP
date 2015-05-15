// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class OTScheduleBuilder : IEntityBuilder<OTScheduleEntity>
    {
        IList<OTScheduleEntity> IEntityBuilder<OTScheduleEntity>.BuildEntities(IDataReader reader)
        {
            List<OTScheduleEntity> OTScheduleEntityList = new List<OTScheduleEntity>();

            while (reader.Read())
            {
                OTScheduleEntityList.Add(((IEntityBuilder<OTScheduleEntity>)this).BuildEntity(reader));
            }

            return (OTScheduleEntityList.Count > 0) ? OTScheduleEntityList : null;
        }

        OTScheduleEntity IEntityBuilder<OTScheduleEntity>.BuildEntity(IDataReader reader)
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

            OTScheduleEntity oTScheduleEntity = new OTScheduleEntity();

            oTScheduleEntity.ScheduleID = reader.GetInt64(FLD_SCHEDULEID);
            oTScheduleEntity.ScheduleIdentityCategoryID = reader.GetInt64(FLD_SCHEDULEIDENTITYCATEGORYID);
            oTScheduleEntity.ScheduleCategoryID = reader.GetInt64(FLD_SCHEDULECATEGORYID);
            if (reader.IsDBNull(FLD_REFERENCEID)) { oTScheduleEntity.ReferenceID = null; } else { oTScheduleEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID); }
            oTScheduleEntity.Title = reader.GetString(FLD_TITLE);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { oTScheduleEntity.Description = String.Empty; } else { oTScheduleEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            oTScheduleEntity.SchedulePriorityID = reader.GetInt64(FLD_SCHEDULEPRIORITYID);
            oTScheduleEntity.CreatedByMemberID = reader.GetInt64(FLD_CREATEDBYMEMBERID);
            if (reader.IsDBNull(FLD_CREATEDATE)) { oTScheduleEntity.CreateDate = null; } else { oTScheduleEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE); }
            if (reader.IsDBNull(FLD_DURATION)) { oTScheduleEntity.Duration = null; } else { oTScheduleEntity.Duration = reader.GetDecimal(FLD_DURATION); }
            if (reader.IsDBNull(FLD_STARTDATETIME)) { oTScheduleEntity.StartDateTime = null; } else { oTScheduleEntity.StartDateTime = reader.GetDateTime(FLD_STARTDATETIME); }
            if (reader.IsDBNull(FLD_ENDDATETIME)) { oTScheduleEntity.EndDateTime = null; } else { oTScheduleEntity.EndDateTime = reader.GetDateTime(FLD_ENDDATETIME); }
            if (reader.IsDBNull(FLD_NOTIFYBEFOREMIN)) { oTScheduleEntity.NotifyBeforeMin = null; } else { oTScheduleEntity.NotifyBeforeMin = reader.GetInt32(FLD_NOTIFYBEFOREMIN); }
            oTScheduleEntity.IsNotifyCompleted = reader.GetBoolean(FLD_ISNOTIFYCOMPLETED);
            if (reader.IsDBNull(FLD_REMARKS)) { oTScheduleEntity.Remarks = String.Empty; } else { oTScheduleEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_REFERENCESCHEDULEID)) { oTScheduleEntity.ReferenceScheduleID = null; } else { oTScheduleEntity.ReferenceScheduleID = reader.GetInt64(FLD_REFERENCESCHEDULEID); }
            oTScheduleEntity.IsRescheduled = reader.GetBoolean(FLD_ISRESCHEDULED);
            oTScheduleEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return oTScheduleEntity;
        }
    }
}
