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
    internal sealed class CMNEvent_DetailedBuilder : IEntityBuilder<CMNEvent_DetailedEntity>
    {
        IList<CMNEvent_DetailedEntity> IEntityBuilder<CMNEvent_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<CMNEvent_DetailedEntity> CMNEvent_DetailedEntityList = new List<CMNEvent_DetailedEntity>();

            while (reader.Read())
            {
                CMNEvent_DetailedEntityList.Add(((IEntityBuilder<CMNEvent_DetailedEntity>)this).BuildEntity(reader));
            }

            return (CMNEvent_DetailedEntityList.Count > 0) ? CMNEvent_DetailedEntityList : null;
        }

        CMNEvent_DetailedEntity IEntityBuilder<CMNEvent_DetailedEntity>.BuildEntity(IDataReader reader)
        {

            const Int32 FLD_EVENTID = 0;
            const Int32 FLD_EVENTIDENTITYCATEGORYID = 1;
            const Int32 FLD_EVENTCATEGORYID = 2;
            const Int32 FLD_PARENTEVENTID = 3;
            const Int32 FLD_REFERENCEEVENTID = 4;
            const Int32 FLD_EVENTREFERENCENO = 5;
            const Int32 FLD_TITLE = 6;
            const Int32 FLD_LOCATION = 7;
            const Int32 FLD_DETAILS = 8;
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
            const Int32 FLD_NAME = 36;
            const Int32 FLD_DESCRIPTION = 37; 
            const Int32 FLD_EVENTLOCATIONCATEGORYNAME = 38;
            const Int32 FLD_EVENTOPTIONNAME = 39;
            const Int32 FLD_EVENTSTATUSNAME = 40; 
            const Int32 FLD_REPEATCATEGORYNAME = 41;
            const Int32 FLD_SHAREDSETTINGNAME = 42;
            const Int32 FLD_LOCATIONNAME = 43;
            const Int32 FLD_EVENTIDENTITYCATEGORYNAME = 44;
            const Int32 FLD_CREATEDBYMEMBERFULLNAME = 45;
            const Int32 FLD_OWNERMEMBERFULLNAME = 46;
            const Int32 FLD_ROWNUMBER = 47;
            
            CMNEvent_DetailedEntity cMNEvent_DetailedEntity = new CMNEvent_DetailedEntity();

            cMNEvent_DetailedEntity.EventID = reader.GetInt64(FLD_EVENTID);
            cMNEvent_DetailedEntity.EventIdentityCategoryID = reader.GetInt64(FLD_EVENTIDENTITYCATEGORYID);
            cMNEvent_DetailedEntity.EventCategoryID = reader.GetInt64(FLD_EVENTCATEGORYID);
            if (reader.IsDBNull(FLD_PARENTEVENTID)) { cMNEvent_DetailedEntity.ParentEventID = null; } else { cMNEvent_DetailedEntity.ParentEventID = reader.GetInt64(FLD_PARENTEVENTID); }
            if (reader.IsDBNull(FLD_REFERENCEEVENTID)) { cMNEvent_DetailedEntity.ReferenceEventID = null; } else { cMNEvent_DetailedEntity.ReferenceEventID = reader.GetInt64(FLD_REFERENCEEVENTID); }
            cMNEvent_DetailedEntity.EventReferenceNo = reader.GetString(FLD_EVENTREFERENCENO);
            cMNEvent_DetailedEntity.Title = reader.GetString(FLD_TITLE);
            //cMNEvent_DetailedEntity.Details = reader.GetString(FLD_DETAILS);
            if (reader.IsDBNull(FLD_DETAILS)) { cMNEvent_DetailedEntity.Details = String.Empty; } else { cMNEvent_DetailedEntity.Details = reader.GetString(FLD_DETAILS); }
            if (reader.IsDBNull(FLD_LOCATION)) { cMNEvent_DetailedEntity.Location = String.Empty; } else { cMNEvent_DetailedEntity.Location = reader.GetString(FLD_LOCATION); }
            cMNEvent_DetailedEntity.EventLocationCategoryID = reader.GetInt64(FLD_EVENTLOCATIONCATEGORYID);
            if (reader.IsDBNull(FLD_LOCATIONREFERENCEID)) { cMNEvent_DetailedEntity.LocationReferenceID = null; } else { cMNEvent_DetailedEntity.LocationReferenceID = reader.GetInt64(FLD_LOCATIONREFERENCEID); }
            if (reader.IsDBNull(FLD_WEBSITEURL)) { cMNEvent_DetailedEntity.WebsiteURL = String.Empty; } else { cMNEvent_DetailedEntity.WebsiteURL = reader.GetString(FLD_WEBSITEURL); }
            if (reader.IsDBNull(FLD_TICKETSELLERURL)) { cMNEvent_DetailedEntity.TicketSellerURL = String.Empty; } else { cMNEvent_DetailedEntity.TicketSellerURL = reader.GetString(FLD_TICKETSELLERURL); }
            if (reader.IsDBNull(FLD_YOUTUBEURL)) { cMNEvent_DetailedEntity.YoutubeURL = String.Empty; } else { cMNEvent_DetailedEntity.YoutubeURL = reader.GetString(FLD_YOUTUBEURL); }
            if (reader.IsDBNull(FLD_TRANSITANDPARKINGINFORMATION)) { cMNEvent_DetailedEntity.TransitAndParkingInformation = String.Empty; } else { cMNEvent_DetailedEntity.TransitAndParkingInformation = reader.GetString(FLD_TRANSITANDPARKINGINFORMATION); }
            cMNEvent_DetailedEntity.EventOptionID = reader.GetInt64(FLD_EVENTOPTIONID);
            if (reader.IsDBNull(FLD_COMPLETIONPERCENTAGE)) { cMNEvent_DetailedEntity.CompletionPercentage = null; } else { cMNEvent_DetailedEntity.CompletionPercentage = reader.GetDecimal(FLD_COMPLETIONPERCENTAGE); }
            cMNEvent_DetailedEntity.EventStatusID = reader.GetInt64(FLD_EVENTSTATUSID);
            cMNEvent_DetailedEntity.RepeatCategoryID = reader.GetInt64(FLD_REPEATCATEGORYID);
            cMNEvent_DetailedEntity.CreatedByMemberID = reader.GetInt64(FLD_CREATEDBYMEMBERID);
            cMNEvent_DetailedEntity.OwnerMemberID = reader.GetInt64(FLD_OWNERMEMBERID);
            cMNEvent_DetailedEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            if (reader.IsDBNull(FLD_DURATION)) { cMNEvent_DetailedEntity.Duration = null; } else { cMNEvent_DetailedEntity.Duration = reader.GetDecimal(FLD_DURATION); }
            cMNEvent_DetailedEntity.ExpectedStartDate = reader.GetDateTime(FLD_EXPECTEDSTARTDATE);
            if (reader.IsDBNull(FLD_EXPECTEDENDDATE)) { cMNEvent_DetailedEntity.ExpectedEndDate = null; } else { cMNEvent_DetailedEntity.ExpectedEndDate = reader.GetDateTime(FLD_EXPECTEDENDDATE); }
            if (reader.IsDBNull(FLD_ACTUALSTARTDATE)) { cMNEvent_DetailedEntity.ActualStartDate = null; } else { cMNEvent_DetailedEntity.ActualStartDate = reader.GetDateTime(FLD_ACTUALSTARTDATE); }
            if (reader.IsDBNull(FLD_ACTUALENDDATE)) { cMNEvent_DetailedEntity.ActualEndDate = null; } else { cMNEvent_DetailedEntity.ActualEndDate = reader.GetDateTime(FLD_ACTUALENDDATE); }
            cMNEvent_DetailedEntity.IsAllDay = reader.GetBoolean(FLD_ISALLDAY);
            if (reader.IsDBNull(FLD_NOTIFYBEFOREMIN)) { cMNEvent_DetailedEntity.NotifyBeforeMin = null; } else { cMNEvent_DetailedEntity.NotifyBeforeMin = reader.GetInt32(FLD_NOTIFYBEFOREMIN); }
            cMNEvent_DetailedEntity.IsNotifyCompleted = reader.GetBoolean(FLD_ISNOTIFYCOMPLETED);
            if (reader.IsDBNull(FLD_REMARKS)) { cMNEvent_DetailedEntity.Remarks = String.Empty; } else { cMNEvent_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            cMNEvent_DetailedEntity.SharedSettingID = reader.GetInt64(FLD_SHAREDSETTINGID);
            cMNEvent_DetailedEntity.ModifiedDateTime = reader.GetDateTime(FLD_MODIFIEDDATETIME);
            if (reader.IsDBNull(FLD_IP)) { cMNEvent_DetailedEntity.IP = String.Empty; } else { cMNEvent_DetailedEntity.IP = reader.GetString(FLD_IP); }
            cMNEvent_DetailedEntity.IsOwnerGoing = reader.GetBoolean(FLD_ISOWNERGOING);
            cMNEvent_DetailedEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            cMNEvent_DetailedEntity.Name = reader.GetString(FLD_NAME);
            cMNEvent_DetailedEntity.Description = reader.GetString(FLD_DESCRIPTION);
            cMNEvent_DetailedEntity.EventLocationCategoryName = reader.GetString(FLD_EVENTLOCATIONCATEGORYNAME);
            cMNEvent_DetailedEntity.EventOptionName = reader.GetString(FLD_EVENTOPTIONNAME);
            cMNEvent_DetailedEntity.EventStatusName = reader.GetString(FLD_EVENTSTATUSNAME);
            cMNEvent_DetailedEntity.RepeatCategoryName = reader.GetString(FLD_REPEATCATEGORYNAME);
            cMNEvent_DetailedEntity.SharedSettingName = reader.GetString(FLD_SHAREDSETTINGNAME);
            cMNEvent_DetailedEntity.LocationName = reader.GetString(FLD_LOCATIONNAME);
            if (reader.IsDBNull(FLD_ROWNUMBER)) { cMNEvent_DetailedEntity.RowNumber = null; } else { cMNEvent_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }
            cMNEvent_DetailedEntity.EventIdentityCategoryName = reader.GetString(FLD_EVENTIDENTITYCATEGORYNAME);
            cMNEvent_DetailedEntity.CreatedByMemberFullName = reader.GetString(FLD_CREATEDBYMEMBERFULLNAME);
            cMNEvent_DetailedEntity.OwnerMemberFullName = reader.GetString(FLD_OWNERMEMBERFULLNAME);

            return cMNEvent_DetailedEntity;
        }
    }
}
