// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Dec-2013, 11:03:59




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMCommunication_DetailedBuilder : IEntityBuilder<CRMCommunication_DetailedEntity>
    {
        IList<CRMCommunication_DetailedEntity> IEntityBuilder<CRMCommunication_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMCommunication_DetailedEntity> CRMCommunication_DetailedEntityList = new List<CRMCommunication_DetailedEntity>();

            while (reader.Read())
            {
                CRMCommunication_DetailedEntityList.Add(((IEntityBuilder<CRMCommunication_DetailedEntity>)this).BuildEntity(reader));
            }

            return (CRMCommunication_DetailedEntityList.Count > 0) ? CRMCommunication_DetailedEntityList : null;
        }

        CRMCommunication_DetailedEntity IEntityBuilder<CRMCommunication_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_COMMUNICATIONID = 0;
            const Int32 FLD_PROCESSCATEGORYID = 1;
            const Int32 FLD_COMMUICATIONDISCUSSIONTYPEID = 2;
            const Int32 FLD_DISCUSSIONDATE = 3;
            const Int32 FLD_COMMUNICATEBYEMPLOYEEID = 4;
            const Int32 FLD_TOPICS = 5;
            const Int32 FLD_NOTE = 6;
            const Int32 FLD_ISFOLLOWUPNEEDED = 7;
            const Int32 FLD_ISIWILLCALL = 8;
            const Int32 FLD_ISFIELD1 = 9;
            const Int32 FLD_NEXTACTION = 10;
            const Int32 FLD_NEXTCOMMUNICATIONDATE = 11;
            const Int32 FLD_COMMUNICATIONSTATUSID = 12;
            const Int32 FLD_CREATEDBYEMPLOYEEID = 13;
            const Int32 FLD_IP = 14;
            const Int32 FLD_CREATEDATE = 15;
            const Int32 FLD_REFERENCEID = 16;
            const Int32 FLD_COMMUICATIONDISCUSSIONTYPENAME = 17;
            const Int32 FLD_COMMUNICATEBYMEMBERFULLNAME = 18;
            const Int32 FLD_COMMUNICATIONSTATUSNAME = 19;
            const Int32 FLD_CREATEDBYMEMBERFULLNAME = 20;
            const Int32 FLD_COMMUNICATETOCONTACTFULLNAME = 21;
            const Int32 FLD_ROWNUMBER = 22;

            CRMCommunication_DetailedEntity cRMCommunication_DetailedEntity = new CRMCommunication_DetailedEntity();

            cRMCommunication_DetailedEntity.CommunicationID = reader.GetInt64(FLD_COMMUNICATIONID);
            cRMCommunication_DetailedEntity.ProcessCategoryID = reader.GetInt64(FLD_PROCESSCATEGORYID);
            cRMCommunication_DetailedEntity.CommuicationDiscussionTypeID = reader.GetInt64(FLD_COMMUICATIONDISCUSSIONTYPEID);
            cRMCommunication_DetailedEntity.DiscussionDate = reader.GetDateTime(FLD_DISCUSSIONDATE);
            cRMCommunication_DetailedEntity.CommunicateByEmployeeID = reader.GetInt64(FLD_COMMUNICATEBYEMPLOYEEID);
            cRMCommunication_DetailedEntity.Topics = reader.GetString(FLD_TOPICS);
            if (reader.IsDBNull(FLD_NOTE)) { cRMCommunication_DetailedEntity.Note = String.Empty; } else { cRMCommunication_DetailedEntity.Note = reader.GetString(FLD_NOTE); }
            cRMCommunication_DetailedEntity.IsFollowUpNeeded = reader.GetBoolean(FLD_ISFOLLOWUPNEEDED);
            cRMCommunication_DetailedEntity.IsIWillCall = reader.GetBoolean(FLD_ISIWILLCALL);
            cRMCommunication_DetailedEntity.IsField1 = reader.GetBoolean(FLD_ISFIELD1);
            if (reader.IsDBNull(FLD_NEXTACTION)) { cRMCommunication_DetailedEntity.NextAction = String.Empty; } else { cRMCommunication_DetailedEntity.NextAction = reader.GetString(FLD_NEXTACTION); }
            if (reader.IsDBNull(FLD_NEXTCOMMUNICATIONDATE)) { cRMCommunication_DetailedEntity.NextCommunicationDate = null; } else { cRMCommunication_DetailedEntity.NextCommunicationDate = reader.GetDateTime(FLD_NEXTCOMMUNICATIONDATE); }
            cRMCommunication_DetailedEntity.CommunicationStatusID = reader.GetInt64(FLD_COMMUNICATIONSTATUSID);
            cRMCommunication_DetailedEntity.CreatedByEmployeeID = reader.GetInt64(FLD_CREATEDBYEMPLOYEEID);
            if (reader.IsDBNull(FLD_IP)) { cRMCommunication_DetailedEntity.IP = String.Empty; } else { cRMCommunication_DetailedEntity.IP = reader.GetString(FLD_IP); }
            cRMCommunication_DetailedEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            cRMCommunication_DetailedEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID);
            if (reader.IsDBNull(FLD_COMMUICATIONDISCUSSIONTYPENAME)) { cRMCommunication_DetailedEntity.CommuicationDiscussionTypeName = String.Empty; } else { cRMCommunication_DetailedEntity.CommuicationDiscussionTypeName = reader.GetString(FLD_COMMUICATIONDISCUSSIONTYPENAME); }
            if (reader.IsDBNull(FLD_COMMUNICATEBYMEMBERFULLNAME)) { cRMCommunication_DetailedEntity.CommunicateByMemberFullName = String.Empty; } else { cRMCommunication_DetailedEntity.CommunicateByMemberFullName = reader.GetString(FLD_COMMUNICATEBYMEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_COMMUNICATIONSTATUSNAME)) { cRMCommunication_DetailedEntity.CommunicationStatusName = String.Empty; } else { cRMCommunication_DetailedEntity.CommunicationStatusName = reader.GetString(FLD_COMMUNICATIONSTATUSNAME); }
            if (reader.IsDBNull(FLD_CREATEDBYMEMBERFULLNAME)) { cRMCommunication_DetailedEntity.CreatedByMemberFullName = String.Empty; } else { cRMCommunication_DetailedEntity.CreatedByMemberFullName = reader.GetString(FLD_CREATEDBYMEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_COMMUNICATETOCONTACTFULLNAME)) { cRMCommunication_DetailedEntity.CommunicateToContactFullName = String.Empty; } else { cRMCommunication_DetailedEntity.CommunicateToContactFullName = reader.GetString(FLD_COMMUNICATETOCONTACTFULLNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { cRMCommunication_DetailedEntity.RowNumber = null; } else { cRMCommunication_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return cRMCommunication_DetailedEntity;
        }
    }
}
