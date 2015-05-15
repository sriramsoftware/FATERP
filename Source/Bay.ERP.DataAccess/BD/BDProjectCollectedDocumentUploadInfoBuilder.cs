// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 01:41:28




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDProjectCollectedDocumentUploadInfoBuilder : IEntityBuilder<BDProjectCollectedDocumentUploadInfoEntity>
    {
        IList<BDProjectCollectedDocumentUploadInfoEntity> IEntityBuilder<BDProjectCollectedDocumentUploadInfoEntity>.BuildEntities(IDataReader reader)
        {
            List<BDProjectCollectedDocumentUploadInfoEntity> BDProjectCollectedDocumentUploadInfoEntityList = new List<BDProjectCollectedDocumentUploadInfoEntity>();

            while (reader.Read())
            {
                BDProjectCollectedDocumentUploadInfoEntityList.Add(((IEntityBuilder<BDProjectCollectedDocumentUploadInfoEntity>)this).BuildEntity(reader));
            }

            return (BDProjectCollectedDocumentUploadInfoEntityList.Count > 0) ? BDProjectCollectedDocumentUploadInfoEntityList : null;
        }

        BDProjectCollectedDocumentUploadInfoEntity IEntityBuilder<BDProjectCollectedDocumentUploadInfoEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTCOLLECTEDDOCUMENTUPLOADINFOID = 0;
            const Int32 FLD_PROJECTCOLLECTEDDOCUMENTINFOID = 1;
            const Int32 FLD_REMARKS = 2;
            const Int32 FLD_PATH = 3;
            const Int32 FLD_ORIGINALFILENAME = 4;
            const Int32 FLD_CURRENTFILENAME = 5;
            const Int32 FLD_FILETYPE = 6;
            const Int32 FLD_EXTENSION = 7;

            BDProjectCollectedDocumentUploadInfoEntity bDProjectCollectedDocumentUploadInfoEntity = new BDProjectCollectedDocumentUploadInfoEntity();

            bDProjectCollectedDocumentUploadInfoEntity.ProjectCollectedDocumentUploadInfoID = reader.GetInt64(FLD_PROJECTCOLLECTEDDOCUMENTUPLOADINFOID);
            bDProjectCollectedDocumentUploadInfoEntity.ProjectCollectedDocumentInfoID = reader.GetInt64(FLD_PROJECTCOLLECTEDDOCUMENTINFOID);
            if (reader.IsDBNull(FLD_REMARKS)) { bDProjectCollectedDocumentUploadInfoEntity.Remarks = String.Empty; } else { bDProjectCollectedDocumentUploadInfoEntity.Remarks = reader.GetString(FLD_REMARKS); }
            bDProjectCollectedDocumentUploadInfoEntity.Path = reader.GetString(FLD_PATH);
            bDProjectCollectedDocumentUploadInfoEntity.OriginalFileName = reader.GetString(FLD_ORIGINALFILENAME);
            bDProjectCollectedDocumentUploadInfoEntity.CurrentFileName = reader.GetString(FLD_CURRENTFILENAME);
            bDProjectCollectedDocumentUploadInfoEntity.FileType = reader.GetString(FLD_FILETYPE);
            bDProjectCollectedDocumentUploadInfoEntity.Extension = reader.GetString(FLD_EXTENSION);

            return bDProjectCollectedDocumentUploadInfoEntity;
        }
    }
}
