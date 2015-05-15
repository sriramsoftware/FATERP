// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Mar-2013, 04:24:50




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class KBUserTreeBuilder : IEntityBuilder<KBUserTreeEntity>
    {
        IList<KBUserTreeEntity> IEntityBuilder<KBUserTreeEntity>.BuildEntities(IDataReader reader)
        {
            List<KBUserTreeEntity> KBUserTreeEntityList = new List<KBUserTreeEntity>();

            while (reader.Read())
            {
                KBUserTreeEntityList.Add(((IEntityBuilder<KBUserTreeEntity>)this).BuildEntity(reader));
            }

            return (KBUserTreeEntityList.Count > 0) ? KBUserTreeEntityList : null;
        }

        KBUserTreeEntity IEntityBuilder<KBUserTreeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_USERTREEID = 0;
            const Int32 FLD_PARENTUSERTREEID = 1;
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
            const Int32 FLD_IP = 13;
            const Int32 FLD_USERTREESTATUSID = 14;
            const Int32 FLD_ISREMOVED = 15;
            const Int32 FLD_COUNTVIEWSTATE = 16;

            KBUserTreeEntity kBUserTreeEntity = new KBUserTreeEntity();

            kBUserTreeEntity.UserTreeID = reader.GetInt64(FLD_USERTREEID);
            if (reader.IsDBNull(FLD_PARENTUSERTREEID)) { kBUserTreeEntity.ParentUserTreeID = null; } else { kBUserTreeEntity.ParentUserTreeID = reader.GetInt64(FLD_PARENTUSERTREEID); }
            kBUserTreeEntity.IsDocumentNodeType = reader.GetBoolean(FLD_ISDOCUMENTNODETYPE);
            kBUserTreeEntity.Title = reader.GetString(FLD_TITLE);
            kBUserTreeEntity.Description = reader.GetString(FLD_DESCRIPTION);
            if (reader.IsDBNull(FLD_REFERENCEID)) { kBUserTreeEntity.ReferenceID = null; } else { kBUserTreeEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID); }
            if (reader.IsDBNull(FLD_TAGKEYWORD)) { kBUserTreeEntity.TagKeyword = String.Empty; } else { kBUserTreeEntity.TagKeyword = reader.GetString(FLD_TAGKEYWORD); }
            if (reader.IsDBNull(FLD_ISSTARRED)) { kBUserTreeEntity.IsStarred = false; } else { kBUserTreeEntity.IsStarred = reader.GetBoolean(FLD_ISSTARRED); }
            if (reader.IsDBNull(FLD_CREATEDBYEMPLOYEEID)) { kBUserTreeEntity.CreatedByEmployeeID = null; } else { kBUserTreeEntity.CreatedByEmployeeID = reader.GetInt64(FLD_CREATEDBYEMPLOYEEID); }
            if (reader.IsDBNull(FLD_CREATEDATE)) { kBUserTreeEntity.CreateDate = null; } else { kBUserTreeEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE); }
            if (reader.IsDBNull(FLD_OWNEREMPLOYEEID)) { kBUserTreeEntity.OwnerEmployeeID = null; } else { kBUserTreeEntity.OwnerEmployeeID = reader.GetInt64(FLD_OWNEREMPLOYEEID); }
            if (reader.IsDBNull(FLD_DOCUMENTSIZE)) { kBUserTreeEntity.DocumentSize = null; } else { kBUserTreeEntity.DocumentSize = reader.GetDecimal(FLD_DOCUMENTSIZE); }
            if (reader.IsDBNull(FLD_LASTMODIFIEDDATE)) { kBUserTreeEntity.LastModifiedDate = null; } else { kBUserTreeEntity.LastModifiedDate = reader.GetDateTime(FLD_LASTMODIFIEDDATE); }
            kBUserTreeEntity.IP = reader.GetString(FLD_IP);
            kBUserTreeEntity.UserTreeStatusID = reader.GetInt64(FLD_USERTREESTATUSID);
            if (reader.IsDBNull(FLD_ISREMOVED)) { kBUserTreeEntity.IsRemoved = false; } else { kBUserTreeEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED); }
            kBUserTreeEntity.CountViewState = reader.GetInt64(FLD_COUNTVIEWSTATE);

            return kBUserTreeEntity;
        }
    }
}
