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
    internal sealed class MDIssueIdentityCategoryBuilder : IEntityBuilder<MDIssueIdentityCategoryEntity>
    {
        IList<MDIssueIdentityCategoryEntity> IEntityBuilder<MDIssueIdentityCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<MDIssueIdentityCategoryEntity> MDIssueIdentityCategoryEntityList = new List<MDIssueIdentityCategoryEntity>();

            while (reader.Read())
            {
                MDIssueIdentityCategoryEntityList.Add(((IEntityBuilder<MDIssueIdentityCategoryEntity>)this).BuildEntity(reader));
            }

            return (MDIssueIdentityCategoryEntityList.Count > 0) ? MDIssueIdentityCategoryEntityList : null;
        }

        MDIssueIdentityCategoryEntity IEntityBuilder<MDIssueIdentityCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ISSUEIDENTITYCATEGORYID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDIssueIdentityCategoryEntity mDIssueIdentityCategoryEntity = new MDIssueIdentityCategoryEntity();

            mDIssueIdentityCategoryEntity.IssueIdentityCategoryID = reader.GetInt64(FLD_ISSUEIDENTITYCATEGORYID);
            mDIssueIdentityCategoryEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDIssueIdentityCategoryEntity.Description = String.Empty; } else { mDIssueIdentityCategoryEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDIssueIdentityCategoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDIssueIdentityCategoryEntity;
        }
    }
}
