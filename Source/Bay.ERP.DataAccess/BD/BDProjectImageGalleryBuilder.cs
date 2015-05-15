// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jun-2013, 02:07:00




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDProjectImageGalleryBuilder : IEntityBuilder<BDProjectImageGalleryEntity>
    {
        IList<BDProjectImageGalleryEntity> IEntityBuilder<BDProjectImageGalleryEntity>.BuildEntities(IDataReader reader)
        {
            List<BDProjectImageGalleryEntity> BDProjectImageGalleryEntityList = new List<BDProjectImageGalleryEntity>();

            while (reader.Read())
            {
                BDProjectImageGalleryEntityList.Add(((IEntityBuilder<BDProjectImageGalleryEntity>)this).BuildEntity(reader));
            }

            return (BDProjectImageGalleryEntityList.Count > 0) ? BDProjectImageGalleryEntityList : null;
        }

        BDProjectImageGalleryEntity IEntityBuilder<BDProjectImageGalleryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTIMAGEGALLERYID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_EXTENSION = 2;
            const Int32 FLD_REMARKS = 3;
            const Int32 FLD_PATH = 4;
            const Int32 FLD_ORIGINALFILENAME = 5;
            const Int32 FLD_CURRENTFILENAME = 6;
            const Int32 FLD_FILETYPE = 7;

            BDProjectImageGalleryEntity bDProjectImageGalleryEntity = new BDProjectImageGalleryEntity();

            bDProjectImageGalleryEntity.ProjectImageGalleryID = reader.GetInt64(FLD_PROJECTIMAGEGALLERYID);
            bDProjectImageGalleryEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            bDProjectImageGalleryEntity.Extension = reader.GetString(FLD_EXTENSION);
            if (reader.IsDBNull(FLD_REMARKS)) { bDProjectImageGalleryEntity.Remarks = String.Empty; } else { bDProjectImageGalleryEntity.Remarks = reader.GetString(FLD_REMARKS); }
            bDProjectImageGalleryEntity.Path = reader.GetString(FLD_PATH);
            bDProjectImageGalleryEntity.OriginalFileName = reader.GetString(FLD_ORIGINALFILENAME);
            bDProjectImageGalleryEntity.CurrentFileName = reader.GetString(FLD_CURRENTFILENAME);
            bDProjectImageGalleryEntity.FileType = reader.GetString(FLD_FILETYPE);

            return bDProjectImageGalleryEntity;
        }
    }
}
