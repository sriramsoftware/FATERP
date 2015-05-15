// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Mar-2013, 12:53:07




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class KBUserTree_DetailedBuilder : IEntityBuilder<KBUserTree_DetailedEntity>
    {
        IList<KBUserTree_DetailedEntity> IEntityBuilder<KBUserTree_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<KBUserTree_DetailedEntity> KBUserTree_DetailedEntityList = new List<KBUserTree_DetailedEntity>();

            while (reader.Read())
            {
                KBUserTree_DetailedEntityList.Add(((IEntityBuilder<KBUserTree_DetailedEntity>)this).BuildEntity(reader));
            }

            return (KBUserTree_DetailedEntityList.Count > 0) ? KBUserTree_DetailedEntityList : null;
        }

        KBUserTree_DetailedEntity IEntityBuilder<KBUserTree_DetailedEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_KBUSERTREEPARENTUSERTREE = 17;
            const Int32 FLD_CREATEDBYMEMBERFULLNAME = 18;
            const Int32 FLD_OWNERMEMBERFULLNAME = 19;
            const Int32 FLD_KBMDUSERTREESTATUSNAME = 20;
            const Int32 FLD_ROWNUMBER = 21;

            KBUserTree_DetailedEntity kBUserTree_DetailedEntity = new KBUserTree_DetailedEntity();

            kBUserTree_DetailedEntity.UserTreeID = reader.GetInt64(FLD_USERTREEID);
            if (reader.IsDBNull(FLD_PARENTUSERTREEID)) { kBUserTree_DetailedEntity.ParentUserTreeID = null; } else { kBUserTree_DetailedEntity.ParentUserTreeID = reader.GetInt64(FLD_PARENTUSERTREEID); }
            kBUserTree_DetailedEntity.IsDocumentNodeType = reader.GetBoolean(FLD_ISDOCUMENTNODETYPE);
            kBUserTree_DetailedEntity.Title = reader.GetString(FLD_TITLE);
            kBUserTree_DetailedEntity.Description = reader.GetString(FLD_DESCRIPTION);
            if (reader.IsDBNull(FLD_REFERENCEID)) { kBUserTree_DetailedEntity.ReferenceID = null; } else { kBUserTree_DetailedEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID); }
            if (reader.IsDBNull(FLD_TAGKEYWORD)) { kBUserTree_DetailedEntity.TagKeyword = String.Empty; } else { kBUserTree_DetailedEntity.TagKeyword = reader.GetString(FLD_TAGKEYWORD); }
            if (reader.IsDBNull(FLD_ISSTARRED)) { kBUserTree_DetailedEntity.IsStarred = false; } else { kBUserTree_DetailedEntity.IsStarred = reader.GetBoolean(FLD_ISSTARRED); }
            if (reader.IsDBNull(FLD_CREATEDBYEMPLOYEEID)) { kBUserTree_DetailedEntity.CreatedByEmployeeID = null; } else { kBUserTree_DetailedEntity.CreatedByEmployeeID = reader.GetInt64(FLD_CREATEDBYEMPLOYEEID); }
            if (reader.IsDBNull(FLD_CREATEDATE)) { kBUserTree_DetailedEntity.CreateDate = null; } else { kBUserTree_DetailedEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE); }
            if (reader.IsDBNull(FLD_OWNEREMPLOYEEID)) { kBUserTree_DetailedEntity.OwnerEmployeeID = null; } else { kBUserTree_DetailedEntity.OwnerEmployeeID = reader.GetInt64(FLD_OWNEREMPLOYEEID); }
            if (reader.IsDBNull(FLD_DOCUMENTSIZE)) { kBUserTree_DetailedEntity.DocumentSize = null; } else { kBUserTree_DetailedEntity.DocumentSize = reader.GetDecimal(FLD_DOCUMENTSIZE); }
            if (reader.IsDBNull(FLD_LASTMODIFIEDDATE)) { kBUserTree_DetailedEntity.LastModifiedDate = null; } else { kBUserTree_DetailedEntity.LastModifiedDate = reader.GetDateTime(FLD_LASTMODIFIEDDATE); }
            kBUserTree_DetailedEntity.IP = reader.GetString(FLD_IP);
            kBUserTree_DetailedEntity.UserTreeStatusID = reader.GetInt64(FLD_USERTREESTATUSID);
            if (reader.IsDBNull(FLD_ISREMOVED)) { kBUserTree_DetailedEntity.IsRemoved = false; } else { kBUserTree_DetailedEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED); }
            kBUserTree_DetailedEntity.CountViewState = reader.GetInt64(FLD_COUNTVIEWSTATE);
            if (reader.IsDBNull(FLD_KBUSERTREEPARENTUSERTREE)) { kBUserTree_DetailedEntity.KBUserTreeParentUserTree = String.Empty; } else { kBUserTree_DetailedEntity.KBUserTreeParentUserTree = reader.GetString(FLD_KBUSERTREEPARENTUSERTREE); }
            if (reader.IsDBNull(FLD_CREATEDBYMEMBERFULLNAME)) { kBUserTree_DetailedEntity.CreatedByMemberFullName = String.Empty; } else { kBUserTree_DetailedEntity.CreatedByMemberFullName = reader.GetString(FLD_CREATEDBYMEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_OWNERMEMBERFULLNAME)) { kBUserTree_DetailedEntity.OwnerMemberFullName = String.Empty; } else { kBUserTree_DetailedEntity.OwnerMemberFullName = reader.GetString(FLD_OWNERMEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_KBMDUSERTREESTATUSNAME)) { kBUserTree_DetailedEntity.KBMDUserTreeStatusName = String.Empty; } else { kBUserTree_DetailedEntity.KBMDUserTreeStatusName = reader.GetString(FLD_KBMDUSERTREESTATUSNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { kBUserTree_DetailedEntity.RowNumber = null; } else { kBUserTree_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return kBUserTree_DetailedEntity;
        }
    }
}
