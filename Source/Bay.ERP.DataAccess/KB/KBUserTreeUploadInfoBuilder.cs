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
    internal sealed class KBUserTreeUploadInfoBuilder : IEntityBuilder<KBUserTreeUploadInfoEntity>
    {
        IList<KBUserTreeUploadInfoEntity> IEntityBuilder<KBUserTreeUploadInfoEntity>.BuildEntities(IDataReader reader)
        {
            List<KBUserTreeUploadInfoEntity> KBUserTreeUploadInfoEntityList = new List<KBUserTreeUploadInfoEntity>();

            while (reader.Read())
            {
                KBUserTreeUploadInfoEntityList.Add(((IEntityBuilder<KBUserTreeUploadInfoEntity>)this).BuildEntity(reader));
            }

            return (KBUserTreeUploadInfoEntityList.Count > 0) ? KBUserTreeUploadInfoEntityList : null;
        }

        KBUserTreeUploadInfoEntity IEntityBuilder<KBUserTreeUploadInfoEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_USERTREEUPLOADINFOID = 0;
            const Int32 FLD_USERTREEID = 1;
            const Int32 FLD_EXTENSION = 2;
            const Int32 FLD_REMARKS = 3;
            const Int32 FLD_PATH = 4;
            const Int32 FLD_ORIGINALFILENAME = 5;
            const Int32 FLD_CURRENTFILENAME = 6;
            const Int32 FLD_FILETYPE = 7;

            KBUserTreeUploadInfoEntity kBUserTreeUploadInfoEntity = new KBUserTreeUploadInfoEntity();

            kBUserTreeUploadInfoEntity.UserTreeUploadInfoID = reader.GetInt64(FLD_USERTREEUPLOADINFOID);
            kBUserTreeUploadInfoEntity.UserTreeID = reader.GetInt64(FLD_USERTREEID);
            kBUserTreeUploadInfoEntity.Extension = reader.GetString(FLD_EXTENSION);
            if (reader.IsDBNull(FLD_REMARKS)) { kBUserTreeUploadInfoEntity.Remarks = String.Empty; } else { kBUserTreeUploadInfoEntity.Remarks = reader.GetString(FLD_REMARKS); }
            kBUserTreeUploadInfoEntity.Path = reader.GetString(FLD_PATH);
            kBUserTreeUploadInfoEntity.OriginalFileName = reader.GetString(FLD_ORIGINALFILENAME);
            kBUserTreeUploadInfoEntity.CurrentFileName = reader.GetString(FLD_CURRENTFILENAME);
            kBUserTreeUploadInfoEntity.FileType = reader.GetString(FLD_FILETYPE);

            return kBUserTreeUploadInfoEntity;
        }
    }
}
