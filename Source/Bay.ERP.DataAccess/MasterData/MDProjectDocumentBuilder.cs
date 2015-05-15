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
    internal sealed class MDProjectDocumentBuilder : IEntityBuilder<MDProjectDocumentEntity>
    {
        IList<MDProjectDocumentEntity> IEntityBuilder<MDProjectDocumentEntity>.BuildEntities(IDataReader reader)
        {
            List<MDProjectDocumentEntity> MDProjectDocumentEntityList = new List<MDProjectDocumentEntity>();

            while (reader.Read())
            {
                MDProjectDocumentEntityList.Add(((IEntityBuilder<MDProjectDocumentEntity>)this).BuildEntity(reader));
            }

            return (MDProjectDocumentEntityList.Count > 0) ? MDProjectDocumentEntityList : null;
        }

        MDProjectDocumentEntity IEntityBuilder<MDProjectDocumentEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTDOCUMENTID = 0;
            const Int32 FLD_PROJECTDOCUMENTCATEGORYID = 1;
            const Int32 FLD_NAME = 2;
            const Int32 FLD_REQUIREDSTANDARDTIME = 3;
            const Int32 FLD_REMINDERTIME = 4;
            const Int32 FLD_REMARKS = 5;
            const Int32 FLD_ISREMOVED = 6;

            MDProjectDocumentEntity mDProjectDocumentEntity = new MDProjectDocumentEntity();

            mDProjectDocumentEntity.ProjectDocumentID = reader.GetInt64(FLD_PROJECTDOCUMENTID);
            mDProjectDocumentEntity.ProjectDocumentCategoryID = reader.GetInt64(FLD_PROJECTDOCUMENTCATEGORYID);
            mDProjectDocumentEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_REQUIREDSTANDARDTIME)) { mDProjectDocumentEntity.RequiredStandardTime = null; } else { mDProjectDocumentEntity.RequiredStandardTime = reader.GetInt32(FLD_REQUIREDSTANDARDTIME); }
            if (reader.IsDBNull(FLD_REMINDERTIME)) { mDProjectDocumentEntity.ReminderTime = null; } else { mDProjectDocumentEntity.ReminderTime = reader.GetInt32(FLD_REMINDERTIME); }
            if (reader.IsDBNull(FLD_REMARKS)) { mDProjectDocumentEntity.Remarks = String.Empty; } else { mDProjectDocumentEntity.Remarks = reader.GetString(FLD_REMARKS); }
            mDProjectDocumentEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDProjectDocumentEntity;
        }
    }
}
