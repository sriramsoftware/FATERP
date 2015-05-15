// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Mar-2013, 04:14:01




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class KBUserTreeModifiedHistoryBuilder : IEntityBuilder<KBUserTreeModifiedHistoryEntity>
    {
        IList<KBUserTreeModifiedHistoryEntity> IEntityBuilder<KBUserTreeModifiedHistoryEntity>.BuildEntities(IDataReader reader)
        {
            List<KBUserTreeModifiedHistoryEntity> KBUserTreeModifiedHistoryEntityList = new List<KBUserTreeModifiedHistoryEntity>();

            while (reader.Read())
            {
                KBUserTreeModifiedHistoryEntityList.Add(((IEntityBuilder<KBUserTreeModifiedHistoryEntity>)this).BuildEntity(reader));
            }

            return (KBUserTreeModifiedHistoryEntityList.Count > 0) ? KBUserTreeModifiedHistoryEntityList : null;
        }

        KBUserTreeModifiedHistoryEntity IEntityBuilder<KBUserTreeModifiedHistoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_USERTREEHISTORYID = 0;
            const Int32 FLD_USERTREEID = 1;
            const Int32 FLD_ISDOCUMENTNODETYPE = 2;
            const Int32 FLD_TITLE = 3;
            const Int32 FLD_DESCRIPTION = 4;
            const Int32 FLD_REFERENCEID = 5;
            const Int32 FLD_TAGKEYWORD = 6;
            const Int32 FLD_ISSTARRED = 7;
            const Int32 FLD_CREATEDBYEMPLOYEEID = 8;
            const Int32 FLD_CREATEDATE = 9;
            const Int32 FLD_OWNEREMPLOYEEID = 10;
            const Int32 FLD_DOCUMENTSIZE = 11;
            const Int32 FLD_LASTMODIFIEDDATE = 12;
            const Int32 FLD_USERTREESTATUSID = 13;
            const Int32 FLD_COUNTVIEWSTATE = 14;
            const Int32 FLD_MODIFIEDDATE = 15;
            const Int32 FLD_MODIFIEDEMPLOYEEID = 16;
            const Int32 FLD_IP = 17;

            KBUserTreeModifiedHistoryEntity kBUserTreeModifiedHistoryEntity = new KBUserTreeModifiedHistoryEntity();

            kBUserTreeModifiedHistoryEntity.UserTreeHistoryID = reader.GetInt64(FLD_USERTREEHISTORYID);
            kBUserTreeModifiedHistoryEntity.UserTreeID = reader.GetInt64(FLD_USERTREEID);
            kBUserTreeModifiedHistoryEntity.IsDocumentNodeType = reader.GetBoolean(FLD_ISDOCUMENTNODETYPE);
            kBUserTreeModifiedHistoryEntity.Title = reader.GetString(FLD_TITLE);
            kBUserTreeModifiedHistoryEntity.Description = reader.GetString(FLD_DESCRIPTION);
            if (reader.IsDBNull(FLD_REFERENCEID)) { kBUserTreeModifiedHistoryEntity.ReferenceID = null; } else { kBUserTreeModifiedHistoryEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID); }
            if (reader.IsDBNull(FLD_TAGKEYWORD)) { kBUserTreeModifiedHistoryEntity.TagKeyword = String.Empty; } else { kBUserTreeModifiedHistoryEntity.TagKeyword = reader.GetString(FLD_TAGKEYWORD); }
            if (reader.IsDBNull(FLD_ISSTARRED)) { kBUserTreeModifiedHistoryEntity.IsStarred = false; } else { kBUserTreeModifiedHistoryEntity.IsStarred = reader.GetBoolean(FLD_ISSTARRED); }
            if (reader.IsDBNull(FLD_CREATEDBYEMPLOYEEID)) { kBUserTreeModifiedHistoryEntity.CreatedByEmployeeID = null; } else { kBUserTreeModifiedHistoryEntity.CreatedByEmployeeID = reader.GetInt64(FLD_CREATEDBYEMPLOYEEID); }
            if (reader.IsDBNull(FLD_CREATEDATE)) { kBUserTreeModifiedHistoryEntity.CreateDate = null; } else { kBUserTreeModifiedHistoryEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE); }
            if (reader.IsDBNull(FLD_OWNEREMPLOYEEID)) { kBUserTreeModifiedHistoryEntity.OwnerEmployeeID = null; } else { kBUserTreeModifiedHistoryEntity.OwnerEmployeeID = reader.GetInt64(FLD_OWNEREMPLOYEEID); }
            if (reader.IsDBNull(FLD_DOCUMENTSIZE)) { kBUserTreeModifiedHistoryEntity.DocumentSize = null; } else { kBUserTreeModifiedHistoryEntity.DocumentSize = reader.GetDecimal(FLD_DOCUMENTSIZE); }
            if (reader.IsDBNull(FLD_LASTMODIFIEDDATE)) { kBUserTreeModifiedHistoryEntity.LastModifiedDate = null; } else { kBUserTreeModifiedHistoryEntity.LastModifiedDate = reader.GetDateTime(FLD_LASTMODIFIEDDATE); }
            kBUserTreeModifiedHistoryEntity.UserTreeStatusID = reader.GetInt64(FLD_USERTREESTATUSID);
            kBUserTreeModifiedHistoryEntity.CountViewState = reader.GetInt64(FLD_COUNTVIEWSTATE);
            kBUserTreeModifiedHistoryEntity.ModifiedDate = reader.GetDateTime(FLD_MODIFIEDDATE);
            kBUserTreeModifiedHistoryEntity.ModifiedEmployeeID = reader.GetInt64(FLD_MODIFIEDEMPLOYEEID);
            kBUserTreeModifiedHistoryEntity.IP = reader.GetString(FLD_IP);

            return kBUserTreeModifiedHistoryEntity;
        }
    }
}
