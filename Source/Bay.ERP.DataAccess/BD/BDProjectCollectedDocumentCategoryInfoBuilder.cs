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
    internal sealed class BDProjectCollectedDocumentCategoryInfoBuilder : IEntityBuilder<BDProjectCollectedDocumentCategoryInfoEntity>
    {
        IList<BDProjectCollectedDocumentCategoryInfoEntity> IEntityBuilder<BDProjectCollectedDocumentCategoryInfoEntity>.BuildEntities(IDataReader reader)
        {
            List<BDProjectCollectedDocumentCategoryInfoEntity> BDProjectCollectedDocumentCategoryInfoEntityList = new List<BDProjectCollectedDocumentCategoryInfoEntity>();

            while (reader.Read())
            {
                BDProjectCollectedDocumentCategoryInfoEntityList.Add(((IEntityBuilder<BDProjectCollectedDocumentCategoryInfoEntity>)this).BuildEntity(reader));
            }

            return (BDProjectCollectedDocumentCategoryInfoEntityList.Count > 0) ? BDProjectCollectedDocumentCategoryInfoEntityList : null;
        }

        BDProjectCollectedDocumentCategoryInfoEntity IEntityBuilder<BDProjectCollectedDocumentCategoryInfoEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTCOLLECTEDDOCUMENTCATEGORYINFOID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_PROJECTDOCUMENTCATEGORYID = 2;
            const Int32 FLD_STARTDATE = 3;
            const Int32 FLD_REQUIREDTIME = 4;
            const Int32 FLD_REMINDER = 5;
            const Int32 FLD_PROJECTCOLLECTEDDOCUMENTSTATUSID = 6;
            const Int32 FLD_REMARKS = 7;

            BDProjectCollectedDocumentCategoryInfoEntity bDProjectCollectedDocumentCategoryInfoEntity = new BDProjectCollectedDocumentCategoryInfoEntity();

            bDProjectCollectedDocumentCategoryInfoEntity.ProjectCollectedDocumentCategoryInfoID = reader.GetInt64(FLD_PROJECTCOLLECTEDDOCUMENTCATEGORYINFOID);
            bDProjectCollectedDocumentCategoryInfoEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            bDProjectCollectedDocumentCategoryInfoEntity.ProjectDocumentCategoryID = reader.GetInt64(FLD_PROJECTDOCUMENTCATEGORYID);
            if (reader.IsDBNull(FLD_STARTDATE)) { bDProjectCollectedDocumentCategoryInfoEntity.StartDate = null; } else { bDProjectCollectedDocumentCategoryInfoEntity.StartDate = reader.GetDateTime(FLD_STARTDATE); }
            if (reader.IsDBNull(FLD_REQUIREDTIME)) { bDProjectCollectedDocumentCategoryInfoEntity.RequiredTime = null; } else { bDProjectCollectedDocumentCategoryInfoEntity.RequiredTime = reader.GetInt32(FLD_REQUIREDTIME); }
            if (reader.IsDBNull(FLD_REMINDER)) { bDProjectCollectedDocumentCategoryInfoEntity.Reminder = null; } else { bDProjectCollectedDocumentCategoryInfoEntity.Reminder = reader.GetInt32(FLD_REMINDER); }
            if (reader.IsDBNull(FLD_PROJECTCOLLECTEDDOCUMENTSTATUSID)) { bDProjectCollectedDocumentCategoryInfoEntity.ProjectCollectedDocumentStatusID = null; } else { bDProjectCollectedDocumentCategoryInfoEntity.ProjectCollectedDocumentStatusID = reader.GetInt64(FLD_PROJECTCOLLECTEDDOCUMENTSTATUSID); }
            if (reader.IsDBNull(FLD_REMARKS)) { bDProjectCollectedDocumentCategoryInfoEntity.Remarks = String.Empty; } else { bDProjectCollectedDocumentCategoryInfoEntity.Remarks = reader.GetString(FLD_REMARKS); }

            return bDProjectCollectedDocumentCategoryInfoEntity;
        }
    }
}
