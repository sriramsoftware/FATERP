// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDDocumentCategoryBuilder : IEntityBuilder<MDDocumentCategoryEntity>
    {
        IList<MDDocumentCategoryEntity> IEntityBuilder<MDDocumentCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<MDDocumentCategoryEntity> MDDocumentCategoryEntityList = new List<MDDocumentCategoryEntity>();

            while (reader.Read())
            {
                MDDocumentCategoryEntityList.Add(((IEntityBuilder<MDDocumentCategoryEntity>)this).BuildEntity(reader));
            }

            return (MDDocumentCategoryEntityList.Count > 0) ? MDDocumentCategoryEntityList : null;
        }

        MDDocumentCategoryEntity IEntityBuilder<MDDocumentCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_DOCUMENTCATEGORYID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_REMARKS = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDDocumentCategoryEntity mDDocumentCategoryEntity = new MDDocumentCategoryEntity();

            mDDocumentCategoryEntity.DocumentCategoryID = reader.GetInt64(FLD_DOCUMENTCATEGORYID);
            mDDocumentCategoryEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_REMARKS)) { mDDocumentCategoryEntity.Remarks = String.Empty; } else { mDDocumentCategoryEntity.Remarks = reader.GetString(FLD_REMARKS); }
            mDDocumentCategoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDDocumentCategoryEntity;
        }
    }
}
