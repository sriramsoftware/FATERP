// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Nov-2013, 12:21:52




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMNEventInvitationInformationBuilder : IEntityBuilder<CMNEventInvitationInformationEntity>
    {
        IList<CMNEventInvitationInformationEntity> IEntityBuilder<CMNEventInvitationInformationEntity>.BuildEntities(IDataReader reader)
        {
            List<CMNEventInvitationInformationEntity> CMNEventInvitationInformationEntityList = new List<CMNEventInvitationInformationEntity>();

            while (reader.Read())
            {
                CMNEventInvitationInformationEntityList.Add(((IEntityBuilder<CMNEventInvitationInformationEntity>)this).BuildEntity(reader));
            }

            return (CMNEventInvitationInformationEntityList.Count > 0) ? CMNEventInvitationInformationEntityList : null;
        }

        CMNEventInvitationInformationEntity IEntityBuilder<CMNEventInvitationInformationEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EVENTINVITATIONINFORMATIONID = 0;
            const Int32 FLD_EVENTID = 1;
            const Int32 FLD_INITATIONGIVENBYMEMBERID = 2;
            const Int32 FLD_SHAREDDATETIME = 3;
            const Int32 FLD_MESSAGE = 4;
            const Int32 FLD_INITATIONGIVENTOMEMBERID = 5;
            const Int32 FLD_EVENTINVITATEDPERSONTYPEID = 6;
            const Int32 FLD_ISGUESTGOING = 7;
            const Int32 FLD_IP = 8;

            CMNEventInvitationInformationEntity cMNEventInvitationInformationEntity = new CMNEventInvitationInformationEntity();

            cMNEventInvitationInformationEntity.EventInvitationInformationID = reader.GetInt64(FLD_EVENTINVITATIONINFORMATIONID);
            cMNEventInvitationInformationEntity.EventID = reader.GetInt64(FLD_EVENTID);
            cMNEventInvitationInformationEntity.InitationGivenByMemberID = reader.GetInt64(FLD_INITATIONGIVENBYMEMBERID);
            cMNEventInvitationInformationEntity.SharedDateTime = reader.GetDateTime(FLD_SHAREDDATETIME);
            if (reader.IsDBNull(FLD_MESSAGE)) { cMNEventInvitationInformationEntity.Message = String.Empty; } else { cMNEventInvitationInformationEntity.Message = reader.GetString(FLD_MESSAGE); }
            cMNEventInvitationInformationEntity.InitationGivenToMemberID = reader.GetInt64(FLD_INITATIONGIVENTOMEMBERID);
            cMNEventInvitationInformationEntity.EventInvitatedPersonTypeID = reader.GetInt64(FLD_EVENTINVITATEDPERSONTYPEID);
            cMNEventInvitationInformationEntity.IsGuestGoing = reader.GetBoolean(FLD_ISGUESTGOING);
            if (reader.IsDBNull(FLD_IP)) { cMNEventInvitationInformationEntity.IP = String.Empty; } else { cMNEventInvitationInformationEntity.IP = reader.GetString(FLD_IP); }

            return cMNEventInvitationInformationEntity;
        }
    }
}
