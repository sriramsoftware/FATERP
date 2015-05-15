// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Dec-2011, 11:00:45




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDProjectDocumentCategoryBuilder : IEntityBuilder<MDProjectDocumentCategoryEntity>
    {
        IList<MDProjectDocumentCategoryEntity> IEntityBuilder<MDProjectDocumentCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<MDProjectDocumentCategoryEntity> MDProjectDocumentCategoryEntityList = new List<MDProjectDocumentCategoryEntity>();

            while (reader.Read())
            {
                MDProjectDocumentCategoryEntityList.Add(((IEntityBuilder<MDProjectDocumentCategoryEntity>)this).BuildEntity(reader));
            }

            return (MDProjectDocumentCategoryEntityList.Count > 0) ? MDProjectDocumentCategoryEntityList : null;
        }

        MDProjectDocumentCategoryEntity IEntityBuilder<MDProjectDocumentCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTDOCUMENTCATEGORYID = 0;
            const Int32 FLD_PARENTPROJECTDOCUMENTCATEGORYID = 1;
            const Int32 FLD_NAME = 2;
            const Int32 FLD_REQUIREDSTANDARDTIME = 3;
            const Int32 FLD_REMINDERTIME = 4;
            const Int32 FLD_ISREMOVED = 5;

            MDProjectDocumentCategoryEntity mDProjectDocumentCategoryEntity = new MDProjectDocumentCategoryEntity();

            mDProjectDocumentCategoryEntity.ProjectDocumentCategoryID = reader.GetInt64(FLD_PROJECTDOCUMENTCATEGORYID);
            if (reader.IsDBNull(FLD_PARENTPROJECTDOCUMENTCATEGORYID)) { mDProjectDocumentCategoryEntity.ParentProjectDocumentCategoryID = null; } else { mDProjectDocumentCategoryEntity.ParentProjectDocumentCategoryID = reader.GetInt64(FLD_PARENTPROJECTDOCUMENTCATEGORYID); }
            mDProjectDocumentCategoryEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_REQUIREDSTANDARDTIME)) { mDProjectDocumentCategoryEntity.RequiredStandardTime = null; } else { mDProjectDocumentCategoryEntity.RequiredStandardTime = reader.GetInt32(FLD_REQUIREDSTANDARDTIME); }
            if (reader.IsDBNull(FLD_REMINDERTIME)) { mDProjectDocumentCategoryEntity.ReminderTime = null; } else { mDProjectDocumentCategoryEntity.ReminderTime = reader.GetInt32(FLD_REMINDERTIME); }
            mDProjectDocumentCategoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDProjectDocumentCategoryEntity;
        }
    }
}
