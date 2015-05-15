// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-Sep-2012, 10:20:04




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class DMSDocumentNodeBuilder : IEntityBuilder<DMSDocumentNodeEntity>
    {
        IList<DMSDocumentNodeEntity> IEntityBuilder<DMSDocumentNodeEntity>.BuildEntities(IDataReader reader)
        {
            List<DMSDocumentNodeEntity> DMSDocumentNodeEntityList = new List<DMSDocumentNodeEntity>();

            while (reader.Read())
            {
                DMSDocumentNodeEntityList.Add(((IEntityBuilder<DMSDocumentNodeEntity>)this).BuildEntity(reader));
            }

            return (DMSDocumentNodeEntityList.Count > 0) ? DMSDocumentNodeEntityList : null;
        }

        DMSDocumentNodeEntity IEntityBuilder<DMSDocumentNodeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_DOCUMENTNODEID = 0;
            const Int32 FLD_PARENTDOCUMENTNODEID = 1;
            const Int32 FLD_ISDOCUMENTNODETYPE = 2;
            const Int32 FLD_NAME = 3;
            const Int32 FLD_DOCUMENTSTORAGETYPEID = 4;
            const Int32 FLD_REFERENCEID = 5;
            const Int32 FLD_EXTENSION = 6;
            const Int32 FLD_REMARKS = 7;
            const Int32 FLD_PATH = 8;
            const Int32 FLD_ORIGINALFILENAME = 9;
            const Int32 FLD_CURRENTFILENAME = 10;
            const Int32 FLD_FILETYPE = 11;
            const Int32 FLD_TAGKEYWORD = 12;
            const Int32 FLD_ISSTARRED = 13;
            const Int32 FLD_ISARCHIVED = 14;
            const Int32 FLD_ISREMOVED = 15;
            const Int32 FLD_UPLOADEDBYMEMBERID = 16;
            const Int32 FLD_OWNERTYPEID = 17;
            const Int32 FLD_OWNERREFERENCEID = 18;
            const Int32 FLD_QUOTAUSED = 19;
            const Int32 FLD_LASTMODIFIEDDATE = 20;

            DMSDocumentNodeEntity dMSDocumentNodeEntity = new DMSDocumentNodeEntity();

            dMSDocumentNodeEntity.DocumentNodeID = reader.GetInt64(FLD_DOCUMENTNODEID);
            if (reader.IsDBNull(FLD_PARENTDOCUMENTNODEID)) { dMSDocumentNodeEntity.ParentDocumentNodeID = null; } else { dMSDocumentNodeEntity.ParentDocumentNodeID = reader.GetInt64(FLD_PARENTDOCUMENTNODEID); }
            dMSDocumentNodeEntity.IsDocumentNodeType = reader.GetBoolean(FLD_ISDOCUMENTNODETYPE);
            dMSDocumentNodeEntity.Name = reader.GetString(FLD_NAME);
            dMSDocumentNodeEntity.DocumentStorageTypeID = reader.GetInt64(FLD_DOCUMENTSTORAGETYPEID);
            dMSDocumentNodeEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID);
            if (reader.IsDBNull(FLD_EXTENSION)) { dMSDocumentNodeEntity.Extension = String.Empty; } else { dMSDocumentNodeEntity.Extension = reader.GetString(FLD_EXTENSION); }
            if (reader.IsDBNull(FLD_REMARKS)) { dMSDocumentNodeEntity.Remarks = String.Empty; } else { dMSDocumentNodeEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_PATH)) { dMSDocumentNodeEntity.Path = String.Empty; } else { dMSDocumentNodeEntity.Path = reader.GetString(FLD_PATH); }
            if (reader.IsDBNull(FLD_ORIGINALFILENAME)) { dMSDocumentNodeEntity.OriginalFileName = String.Empty; } else { dMSDocumentNodeEntity.OriginalFileName = reader.GetString(FLD_ORIGINALFILENAME); }
            if (reader.IsDBNull(FLD_CURRENTFILENAME)) { dMSDocumentNodeEntity.CurrentFileName = String.Empty; } else { dMSDocumentNodeEntity.CurrentFileName = reader.GetString(FLD_CURRENTFILENAME); }
            if (reader.IsDBNull(FLD_FILETYPE)) { dMSDocumentNodeEntity.FileType = String.Empty; } else { dMSDocumentNodeEntity.FileType = reader.GetString(FLD_FILETYPE); }
            if (reader.IsDBNull(FLD_TAGKEYWORD)) { dMSDocumentNodeEntity.TagKeyword = String.Empty; } else { dMSDocumentNodeEntity.TagKeyword = reader.GetString(FLD_TAGKEYWORD); }
            if (reader.IsDBNull(FLD_ISSTARRED)) { dMSDocumentNodeEntity.IsStarred = false; } else { dMSDocumentNodeEntity.IsStarred = reader.GetBoolean(FLD_ISSTARRED); }
            if (reader.IsDBNull(FLD_ISARCHIVED)) { dMSDocumentNodeEntity.IsArchived = false; } else { dMSDocumentNodeEntity.IsArchived = reader.GetBoolean(FLD_ISARCHIVED); }
            if (reader.IsDBNull(FLD_ISREMOVED)) { dMSDocumentNodeEntity.IsRemoved = false; } else { dMSDocumentNodeEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED); }
            if (reader.IsDBNull(FLD_UPLOADEDBYMEMBERID)) { dMSDocumentNodeEntity.UploadedByMemberID = null; } else { dMSDocumentNodeEntity.UploadedByMemberID = reader.GetInt64(FLD_UPLOADEDBYMEMBERID); }
            dMSDocumentNodeEntity.OwnerTypeID = reader.GetInt64(FLD_OWNERTYPEID);
            if (reader.IsDBNull(FLD_OWNERREFERENCEID)) { dMSDocumentNodeEntity.OwnerReferenceID = null; } else { dMSDocumentNodeEntity.OwnerReferenceID = reader.GetInt64(FLD_OWNERREFERENCEID); }
            if (reader.IsDBNull(FLD_QUOTAUSED)) { dMSDocumentNodeEntity.QuotaUsed = null; } else { dMSDocumentNodeEntity.QuotaUsed = reader.GetDecimal(FLD_QUOTAUSED); }
            if (reader.IsDBNull(FLD_LASTMODIFIEDDATE)) { dMSDocumentNodeEntity.LastModifiedDate = null; } else { dMSDocumentNodeEntity.LastModifiedDate = reader.GetDateTime(FLD_LASTMODIFIEDDATE); }

            return dMSDocumentNodeEntity;
        }
    }
}
