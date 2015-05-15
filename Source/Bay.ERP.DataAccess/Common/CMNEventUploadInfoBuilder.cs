// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-Oct-2013, 05:27:25




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMNEventUploadInfoBuilder : IEntityBuilder<CMNEventUploadInfoEntity>
    {
        IList<CMNEventUploadInfoEntity> IEntityBuilder<CMNEventUploadInfoEntity>.BuildEntities(IDataReader reader)
        {
            List<CMNEventUploadInfoEntity> CMNEventUploadInfoEntityList = new List<CMNEventUploadInfoEntity>();

            while (reader.Read())
            {
                CMNEventUploadInfoEntityList.Add(((IEntityBuilder<CMNEventUploadInfoEntity>)this).BuildEntity(reader));
            }

            return (CMNEventUploadInfoEntityList.Count > 0) ? CMNEventUploadInfoEntityList : null;
        }

        CMNEventUploadInfoEntity IEntityBuilder<CMNEventUploadInfoEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EVENTUPLOADINFOID = 0;
            const Int32 FLD_EVENTID = 1;
            const Int32 FLD_EXTENSION = 2;
            const Int32 FLD_REMARKS = 3;
            const Int32 FLD_PATH = 4;
            const Int32 FLD_ORIGINALFILENAME = 5;
            const Int32 FLD_CURRENTFILENAME = 6;
            const Int32 FLD_FILETYPE = 7;
            const Int32 FLD_UPLOADEDBYMEMBERID = 8;
            const Int32 FLD_UPLOADEDDATETIME = 9;

            CMNEventUploadInfoEntity cMNEventUploadInfoEntity = new CMNEventUploadInfoEntity();

            cMNEventUploadInfoEntity.EventUploadInfoID = reader.GetInt64(FLD_EVENTUPLOADINFOID);
            cMNEventUploadInfoEntity.EventID = reader.GetInt64(FLD_EVENTID);
            cMNEventUploadInfoEntity.Extension = reader.GetString(FLD_EXTENSION);
            if (reader.IsDBNull(FLD_REMARKS)) { cMNEventUploadInfoEntity.Remarks = String.Empty; } else { cMNEventUploadInfoEntity.Remarks = reader.GetString(FLD_REMARKS); }
            cMNEventUploadInfoEntity.Path = reader.GetString(FLD_PATH);
            cMNEventUploadInfoEntity.OriginalFileName = reader.GetString(FLD_ORIGINALFILENAME);
            cMNEventUploadInfoEntity.CurrentFileName = reader.GetString(FLD_CURRENTFILENAME);
            cMNEventUploadInfoEntity.FileType = reader.GetString(FLD_FILETYPE);
            cMNEventUploadInfoEntity.UploadedByMemberID = reader.GetInt64(FLD_UPLOADEDBYMEMBERID);
            cMNEventUploadInfoEntity.UploadedDateTime = reader.GetDateTime(FLD_UPLOADEDDATETIME);

            return cMNEventUploadInfoEntity;
        }
    }
}
