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
    internal sealed class CMNEventInvitationInformation_DetailedBuilder : IEntityBuilder<CMNEventInvitationInformation_DetailedEntity>
    {
        IList<CMNEventInvitationInformation_DetailedEntity> IEntityBuilder<CMNEventInvitationInformation_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<CMNEventInvitationInformation_DetailedEntity> cMNEventInvitationInformation_DetailedEntityList = new List<CMNEventInvitationInformation_DetailedEntity>();

            while (reader.Read())
            {
                cMNEventInvitationInformation_DetailedEntityList.Add(((IEntityBuilder<CMNEventInvitationInformation_DetailedEntity>)this).BuildEntity(reader));
            }

            return (cMNEventInvitationInformation_DetailedEntityList.Count > 0) ? cMNEventInvitationInformation_DetailedEntityList : null;
        }

        CMNEventInvitationInformation_DetailedEntity IEntityBuilder<CMNEventInvitationInformation_DetailedEntity>.BuildEntity(IDataReader reader)
        {

            const Int32 FLD_EVENTINVITATIONINFORMATIONID = 0;
            const Int32 FLD_EVENTID = 1;
            const Int32 FLD_INITATIONGIVENBYMEMBERID = 2;
            const Int32 FLD_SHAREDDATETIME = 3;
            const Int32 FLD_MESSAGE = 4;
            const Int32 FLD_INITATIONGIVENTOMEMBERID = 5;
            const Int32 FLD_ISGUESTGOING = 6;
            const Int32 FLD_IP = 7;
            const Int32 FLD_ROWNUMBER = 8;
            const Int32 FLD_INITATIONGIVENBYMEMBER = 9;
            const Int32 FLD_INITATIONGIVENTOMEMBER = 10;
            const Int32 FLD_TITLE = 11;

            CMNEventInvitationInformation_DetailedEntity cMNEventInvitationInformation_DetailedEntity = new CMNEventInvitationInformation_DetailedEntity();

            cMNEventInvitationInformation_DetailedEntity.EventInvitationInformationID = reader.GetInt64(FLD_EVENTINVITATIONINFORMATIONID);
            cMNEventInvitationInformation_DetailedEntity.EventID = reader.GetInt64(FLD_EVENTID);
            cMNEventInvitationInformation_DetailedEntity.InitationGivenByMemberID = reader.GetInt64(FLD_INITATIONGIVENBYMEMBERID);
            cMNEventInvitationInformation_DetailedEntity.SharedDateTime = reader.GetDateTime(FLD_SHAREDDATETIME);
            if (reader.IsDBNull(FLD_MESSAGE)) { cMNEventInvitationInformation_DetailedEntity.Message = String.Empty; } else { cMNEventInvitationInformation_DetailedEntity.Message = reader.GetString(FLD_MESSAGE); }
            cMNEventInvitationInformation_DetailedEntity.InitationGivenToMemberID = reader.GetInt64(FLD_INITATIONGIVENTOMEMBERID);
            cMNEventInvitationInformation_DetailedEntity.IsGuestGoing = reader.GetBoolean(FLD_ISGUESTGOING);
            if (reader.IsDBNull(FLD_IP)) { cMNEventInvitationInformation_DetailedEntity.IP = String.Empty; } else { cMNEventInvitationInformation_DetailedEntity.IP = reader.GetString(FLD_IP); }
            cMNEventInvitationInformation_DetailedEntity.Rownumber = reader.GetInt64(FLD_ROWNUMBER);
            cMNEventInvitationInformation_DetailedEntity.InitationGivenByMember = reader.GetString(FLD_INITATIONGIVENBYMEMBER);
            cMNEventInvitationInformation_DetailedEntity.InitationGivenToMember = reader.GetString(FLD_INITATIONGIVENTOMEMBER);
            cMNEventInvitationInformation_DetailedEntity.Title = reader.GetString(FLD_TITLE);

            return cMNEventInvitationInformation_DetailedEntity;
        }
    }
}
