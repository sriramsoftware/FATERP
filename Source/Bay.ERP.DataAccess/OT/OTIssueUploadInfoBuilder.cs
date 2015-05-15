// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class OTIssueUploadInfoBuilder : IEntityBuilder<OTIssueUploadInfoEntity>
    {
        IList<OTIssueUploadInfoEntity> IEntityBuilder<OTIssueUploadInfoEntity>.BuildEntities(IDataReader reader)
        {
            List<OTIssueUploadInfoEntity> OTIssueUploadInfoEntityList = new List<OTIssueUploadInfoEntity>();

            while (reader.Read())
            {
                OTIssueUploadInfoEntityList.Add(((IEntityBuilder<OTIssueUploadInfoEntity>)this).BuildEntity(reader));
            }

            return (OTIssueUploadInfoEntityList.Count > 0) ? OTIssueUploadInfoEntityList : null;
        }

        OTIssueUploadInfoEntity IEntityBuilder<OTIssueUploadInfoEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ISSUEUPLOADINFOID = 0;
            const Int32 FLD_ISSUEID = 1;
            const Int32 FLD_REMARKS = 2;
            const Int32 FLD_PATH = 3;
            const Int32 FLD_ORIGINALFILENAME = 4;
            const Int32 FLD_CURRENTFILENAME = 5;
            const Int32 FLD_FILETYPE = 6;
            const Int32 FLD_EXTENSION = 7;

            OTIssueUploadInfoEntity oTIssueUploadInfoEntity = new OTIssueUploadInfoEntity();

            oTIssueUploadInfoEntity.IssueUploadInfoID = reader.GetInt64(FLD_ISSUEUPLOADINFOID);
            oTIssueUploadInfoEntity.IssueID = reader.GetInt64(FLD_ISSUEID);
            if (reader.IsDBNull(FLD_REMARKS)) { oTIssueUploadInfoEntity.Remarks = String.Empty; } else { oTIssueUploadInfoEntity.Remarks = reader.GetString(FLD_REMARKS); }
            oTIssueUploadInfoEntity.Path = reader.GetString(FLD_PATH);
            oTIssueUploadInfoEntity.OriginalFileName = reader.GetString(FLD_ORIGINALFILENAME);
            oTIssueUploadInfoEntity.CurrentFileName = reader.GetString(FLD_CURRENTFILENAME);
            oTIssueUploadInfoEntity.FileType = reader.GetString(FLD_FILETYPE);
            oTIssueUploadInfoEntity.Extension = reader.GetString(FLD_EXTENSION);

            return oTIssueUploadInfoEntity;
        }
    }
}
