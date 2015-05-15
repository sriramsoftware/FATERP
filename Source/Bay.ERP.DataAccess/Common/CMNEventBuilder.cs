// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Oct-2013, 02:28:24




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMNEventBuilder : IEntityBuilder<CMNEventEntity>
    {
        IList<CMNEventEntity> IEntityBuilder<CMNEventEntity>.BuildEntities(IDataReader reader)
        {
            List<CMNEventEntity> CMNEventEntityList = new List<CMNEventEntity>();

            while (reader.Read())
            {
                CMNEventEntityList.Add(((IEntityBuilder<CMNEventEntity>)this).BuildEntity(reader));
            }

            return (CMNEventEntityList.Count > 0) ? CMNEventEntityList : null;
        }

        CMNEventEntity IEntityBuilder<CMNEventEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EVENTID = 0;
            const Int32 FLD_EVENTIDENTITYCATEGORYID = 1;
            const Int32 FLD_EVENTCATEGORYID = 2;
            const Int32 FLD_PARENTEVENTID = 3;
            const Int32 FLD_REFERENCEEVENTID = 4;
            const Int32 FLD_EVENTREFERENCENO = 5;
            const Int32 FLD_TITLE = 6;
            const Int32 FLD_DETAILS = 7;
            const Int32 FLD_LOCATION = 8;
            const Int32 FLD_EVENTLOCATIONCATEGORYID = 9;
            const Int32 FLD_LOCATIONREFERENCEID = 10;
            const Int32 FLD_WEBSITEURL = 11;
            const Int32 FLD_TICKETSELLERURL = 12;
            const Int32 FLD_YOUTUBEURL = 13;
            const Int32 FLD_TRANSITANDPARKINGINFORMATION = 14;
            const Int32 FLD_EVENTOPTIONID = 15;
            const Int32 FLD_COMPLETIONPERCENTAGE = 16;
            const Int32 FLD_EVENTSTATUSID = 17;
            const Int32 FLD_REPEATCATEGORYID = 18;
            const Int32 FLD_CREATEDBYMEMBERID = 19;
            const Int32 FLD_OWNERMEMBERID = 20;
            const Int32 FLD_CREATEDATE = 21;
            const Int32 FLD_DURATION = 22;
            const Int32 FLD_EXPECTEDSTARTDATE = 23;
            const Int32 FLD_EXPECTEDENDDATE = 24;
            const Int32 FLD_ACTUALSTARTDATE = 25;
            const Int32 FLD_ACTUALENDDATE = 26;
            const Int32 FLD_ISALLDAY = 27;
            const Int32 FLD_NOTIFYBEFOREMIN = 28;
            const Int32 FLD_ISNOTIFYCOMPLETED = 29;
            const Int32 FLD_REMARKS = 30;
            const Int32 FLD_SHAREDSETTINGID = 31;
            const Int32 FLD_MODIFIEDDATETIME = 32;
            const Int32 FLD_IP = 33;
            const Int32 FLD_ISOWNERGOING = 34;
            const Int32 FLD_ISREMOVED = 35;

            CMNEventEntity cMNEventEntity = new CMNEventEntity();

            cMNEventEntity.EventID = reader.GetInt64(FLD_EVENTID);
            cMNEventEntity.EventIdentityCategoryID = reader.GetInt64(FLD_EVENTIDENTITYCATEGORYID);
            cMNEventEntity.EventCategoryID = reader.GetInt64(FLD_EVENTCATEGORYID);
            if (reader.IsDBNull(FLD_PARENTEVENTID)) { cMNEventEntity.ParentEventID = null; } else { cMNEventEntity.ParentEventID = reader.GetInt64(FLD_PARENTEVENTID); }
            if (reader.IsDBNull(FLD_REFERENCEEVENTID)) { cMNEventEntity.ReferenceEventID = null; } else { cMNEventEntity.ReferenceEventID = reader.GetInt64(FLD_REFERENCEEVENTID); }
            cMNEventEntity.EventReferenceNo = reader.GetString(FLD_EVENTREFERENCENO);
            cMNEventEntity.Title = reader.GetString(FLD_TITLE);
            if (reader.IsDBNull(FLD_DETAILS)) { cMNEventEntity.Details = String.Empty; } else { cMNEventEntity.Details = reader.GetString(FLD_DETAILS); }
            if (reader.IsDBNull(FLD_LOCATION)) { cMNEventEntity.Location = String.Empty; } else { cMNEventEntity.Location = reader.GetString(FLD_LOCATION); }
            cMNEventEntity.EventLocationCategoryID = reader.GetInt64(FLD_EVENTLOCATIONCATEGORYID);
            if (reader.IsDBNull(FLD_LOCATIONREFERENCEID)) { cMNEventEntity.LocationReferenceID = null; } else { cMNEventEntity.LocationReferenceID = reader.GetInt64(FLD_LOCATIONREFERENCEID); }
            if (reader.IsDBNull(FLD_WEBSITEURL)) { cMNEventEntity.WebsiteURL = String.Empty; } else { cMNEventEntity.WebsiteURL = reader.GetString(FLD_WEBSITEURL); }
            if (reader.IsDBNull(FLD_TICKETSELLERURL)) { cMNEventEntity.TicketSellerURL = String.Empty; } else { cMNEventEntity.TicketSellerURL = reader.GetString(FLD_TICKETSELLERURL); }
            if (reader.IsDBNull(FLD_YOUTUBEURL)) { cMNEventEntity.YoutubeURL = String.Empty; } else { cMNEventEntity.YoutubeURL = reader.GetString(FLD_YOUTUBEURL); }
            if (reader.IsDBNull(FLD_TRANSITANDPARKINGINFORMATION)) { cMNEventEntity.TransitAndParkingInformation = String.Empty; } else { cMNEventEntity.TransitAndParkingInformation = reader.GetString(FLD_TRANSITANDPARKINGINFORMATION); }
            cMNEventEntity.EventOptionID = reader.GetInt64(FLD_EVENTOPTIONID);
            if (reader.IsDBNull(FLD_COMPLETIONPERCENTAGE)) { cMNEventEntity.CompletionPercentage = null; } else { cMNEventEntity.CompletionPercentage = reader.GetDecimal(FLD_COMPLETIONPERCENTAGE); }
            cMNEventEntity.EventStatusID = reader.GetInt64(FLD_EVENTSTATUSID);
            cMNEventEntity.RepeatCategoryID = reader.GetInt64(FLD_REPEATCATEGORYID);
            cMNEventEntity.CreatedByMemberID = reader.GetInt64(FLD_CREATEDBYMEMBERID);
            cMNEventEntity.OwnerMemberID = reader.GetInt64(FLD_OWNERMEMBERID);
            cMNEventEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            if (reader.IsDBNull(FLD_DURATION)) { cMNEventEntity.Duration = null; } else { cMNEventEntity.Duration = reader.GetDecimal(FLD_DURATION); }
            cMNEventEntity.ExpectedStartDate = reader.GetDateTime(FLD_EXPECTEDSTARTDATE);
            if (reader.IsDBNull(FLD_EXPECTEDENDDATE)) { cMNEventEntity.ExpectedEndDate = null; } else { cMNEventEntity.ExpectedEndDate = reader.GetDateTime(FLD_EXPECTEDENDDATE); }
            if (reader.IsDBNull(FLD_ACTUALSTARTDATE)) { cMNEventEntity.ActualStartDate = null; } else { cMNEventEntity.ActualStartDate = reader.GetDateTime(FLD_ACTUALSTARTDATE); }
            if (reader.IsDBNull(FLD_ACTUALENDDATE)) { cMNEventEntity.ActualEndDate = null; } else { cMNEventEntity.ActualEndDate = reader.GetDateTime(FLD_ACTUALENDDATE); }
            cMNEventEntity.IsAllDay = reader.GetBoolean(FLD_ISALLDAY);
            if (reader.IsDBNull(FLD_NOTIFYBEFOREMIN)) { cMNEventEntity.NotifyBeforeMin = null; } else { cMNEventEntity.NotifyBeforeMin = reader.GetInt32(FLD_NOTIFYBEFOREMIN); }
            cMNEventEntity.IsNotifyCompleted = reader.GetBoolean(FLD_ISNOTIFYCOMPLETED);
            if (reader.IsDBNull(FLD_REMARKS)) { cMNEventEntity.Remarks = String.Empty; } else { cMNEventEntity.Remarks = reader.GetString(FLD_REMARKS); }
            cMNEventEntity.SharedSettingID = reader.GetInt64(FLD_SHAREDSETTINGID);
            cMNEventEntity.ModifiedDateTime = reader.GetDateTime(FLD_MODIFIEDDATETIME);
            if (reader.IsDBNull(FLD_IP)) { cMNEventEntity.IP = String.Empty; } else { cMNEventEntity.IP = reader.GetString(FLD_IP); }
            cMNEventEntity.IsOwnerGoing = reader.GetBoolean(FLD_ISOWNERGOING);
            cMNEventEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return cMNEventEntity;
        }
    }
}
