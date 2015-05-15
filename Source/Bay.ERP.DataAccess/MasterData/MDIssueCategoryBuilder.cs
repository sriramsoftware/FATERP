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
    internal sealed class MDIssueCategoryBuilder : IEntityBuilder<MDIssueCategoryEntity>
    {
        IList<MDIssueCategoryEntity> IEntityBuilder<MDIssueCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<MDIssueCategoryEntity> MDIssueCategoryEntityList = new List<MDIssueCategoryEntity>();

            while (reader.Read())
            {
                MDIssueCategoryEntityList.Add(((IEntityBuilder<MDIssueCategoryEntity>)this).BuildEntity(reader));
            }

            return (MDIssueCategoryEntityList.Count > 0) ? MDIssueCategoryEntityList : null;
        }

        MDIssueCategoryEntity IEntityBuilder<MDIssueCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ISSUECATEGORYID = 0;
            const Int32 FLD_ISSUEIDENTITYCATEGORYID = 1;
            const Int32 FLD_NAME = 2;
            const Int32 FLD_DESCRIPTION = 3;
            const Int32 FLD_ISREMOVED = 4;

            MDIssueCategoryEntity mDIssueCategoryEntity = new MDIssueCategoryEntity();

            mDIssueCategoryEntity.IssueCategoryID = reader.GetInt64(FLD_ISSUECATEGORYID);
            mDIssueCategoryEntity.IssueIdentityCategoryID = reader.GetInt64(FLD_ISSUEIDENTITYCATEGORYID);
            mDIssueCategoryEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDIssueCategoryEntity.Description = String.Empty; } else { mDIssueCategoryEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDIssueCategoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDIssueCategoryEntity;
        }
    }
}
