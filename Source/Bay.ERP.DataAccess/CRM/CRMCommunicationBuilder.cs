// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Apr-2013, 03:35:56




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMCommunicationBuilder : IEntityBuilder<CRMCommunicationEntity>
    {
        IList<CRMCommunicationEntity> IEntityBuilder<CRMCommunicationEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMCommunicationEntity> CRMCommunicationEntityList = new List<CRMCommunicationEntity>();

            while (reader.Read())
            {
                CRMCommunicationEntityList.Add(((IEntityBuilder<CRMCommunicationEntity>)this).BuildEntity(reader));
            }

            return (CRMCommunicationEntityList.Count > 0) ? CRMCommunicationEntityList : null;
        }

        CRMCommunicationEntity IEntityBuilder<CRMCommunicationEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_COMMUNICATIONID = 0;
            const Int32 FLD_PROCESSCATEGORYID = 1;
            const Int32 FLD_REFERENCEID = 2;
            const Int32 FLD_COMMUICATIONDISCUSSIONTYPEID = 3;
            const Int32 FLD_DISCUSSIONDATE = 4;
            const Int32 FLD_COMMUNICATEBYEMPLOYEEID = 5;
            const Int32 FLD_TOPICS = 6;
            const Int32 FLD_NOTE = 7;
            const Int32 FLD_ISFOLLOWUPNEEDED = 8;
            const Int32 FLD_ISIWILLCALL = 9;
            const Int32 FLD_ISFIELD1 = 10;
            const Int32 FLD_NEXTACTION = 11;
            const Int32 FLD_NEXTCOMMUNICATIONDATE = 12;
            const Int32 FLD_COMMUNICATIONSTATUSID = 13;
            const Int32 FLD_CREATEDBYEMPLOYEEID = 14;
            const Int32 FLD_IP = 15;
            const Int32 FLD_CREATEDATE = 16;

            CRMCommunicationEntity cRMCommunicationEntity = new CRMCommunicationEntity();

            cRMCommunicationEntity.CommunicationID = reader.GetInt64(FLD_COMMUNICATIONID);
            cRMCommunicationEntity.ProcessCategoryID = reader.GetInt64(FLD_PROCESSCATEGORYID);
            cRMCommunicationEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID);
            cRMCommunicationEntity.CommuicationDiscussionTypeID = reader.GetInt64(FLD_COMMUICATIONDISCUSSIONTYPEID);
            cRMCommunicationEntity.DiscussionDate = reader.GetDateTime(FLD_DISCUSSIONDATE);
            cRMCommunicationEntity.CommunicateByEmployeeID = reader.GetInt64(FLD_COMMUNICATEBYEMPLOYEEID);
            cRMCommunicationEntity.Topics = reader.GetString(FLD_TOPICS);
            if (reader.IsDBNull(FLD_NOTE)) { cRMCommunicationEntity.Note = String.Empty; } else { cRMCommunicationEntity.Note = reader.GetString(FLD_NOTE); }
            cRMCommunicationEntity.IsFollowUpNeeded = reader.GetBoolean(FLD_ISFOLLOWUPNEEDED);
            cRMCommunicationEntity.IsIWillCall = reader.GetBoolean(FLD_ISIWILLCALL);
            cRMCommunicationEntity.IsField1 = reader.GetBoolean(FLD_ISFIELD1);
            if (reader.IsDBNull(FLD_NEXTACTION)) { cRMCommunicationEntity.NextAction = String.Empty; } else { cRMCommunicationEntity.NextAction = reader.GetString(FLD_NEXTACTION); }
            if (reader.IsDBNull(FLD_NEXTCOMMUNICATIONDATE)) { cRMCommunicationEntity.NextCommunicationDate = null; } else { cRMCommunicationEntity.NextCommunicationDate = reader.GetDateTime(FLD_NEXTCOMMUNICATIONDATE); }
            cRMCommunicationEntity.CommunicationStatusID = reader.GetInt64(FLD_COMMUNICATIONSTATUSID);
            cRMCommunicationEntity.CreatedByEmployeeID = reader.GetInt64(FLD_CREATEDBYEMPLOYEEID);
            if (reader.IsDBNull(FLD_IP)) { cRMCommunicationEntity.IP = String.Empty; } else { cRMCommunicationEntity.IP = reader.GetString(FLD_IP); }
            cRMCommunicationEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);

            return cRMCommunicationEntity;
        }
    }
}
