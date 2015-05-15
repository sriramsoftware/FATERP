// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 31-Dec-2011, 05:48:38




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDIssueCategory_DetailedBuilder : IEntityBuilder<MDIssueCategory_DetailedEntity>
    {
        IList<MDIssueCategory_DetailedEntity> IEntityBuilder<MDIssueCategory_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<MDIssueCategory_DetailedEntity> MDIssueCategory_DetailedEntityList = new List<MDIssueCategory_DetailedEntity>();

            while (reader.Read())
            {
                MDIssueCategory_DetailedEntityList.Add(((IEntityBuilder<MDIssueCategory_DetailedEntity>)this).BuildEntity(reader));
            }

            return (MDIssueCategory_DetailedEntityList.Count > 0) ? MDIssueCategory_DetailedEntityList : null;
        }

        MDIssueCategory_DetailedEntity IEntityBuilder<MDIssueCategory_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ISSUECATEGORYID = 0;
            const Int32 FLD_ISSUEIDENTITYCATEGORYID = 1;
            const Int32 FLD_NAME = 2;
            const Int32 FLD_DESCRIPTION = 3;
            const Int32 FLD_ISREMOVED = 4;
            const Int32 FLD_ISSUEIDENTITYCATEGORYNAME = 5;
            const Int32 FLD_ROWNUMBER = 6;

            MDIssueCategory_DetailedEntity mDIssueCategory_DetailedEntity = new MDIssueCategory_DetailedEntity();

            mDIssueCategory_DetailedEntity.IssueCategoryID = reader.GetInt64(FLD_ISSUECATEGORYID);
            mDIssueCategory_DetailedEntity.IssueIdentityCategoryID = reader.GetInt64(FLD_ISSUEIDENTITYCATEGORYID);
            mDIssueCategory_DetailedEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDIssueCategory_DetailedEntity.Description = String.Empty; } else { mDIssueCategory_DetailedEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDIssueCategory_DetailedEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            if (reader.IsDBNull(FLD_ISSUEIDENTITYCATEGORYNAME)) { mDIssueCategory_DetailedEntity.IssueIdentityCategoryName = String.Empty; } else { mDIssueCategory_DetailedEntity.IssueIdentityCategoryName = reader.GetString(FLD_ISSUEIDENTITYCATEGORYNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { mDIssueCategory_DetailedEntity.RowNumber = null; } else { mDIssueCategory_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return mDIssueCategory_DetailedEntity;
        }
    }
}
