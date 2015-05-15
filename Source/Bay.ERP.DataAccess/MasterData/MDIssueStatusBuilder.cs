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
    internal sealed class MDIssueStatusBuilder : IEntityBuilder<MDIssueStatusEntity>
    {
        IList<MDIssueStatusEntity> IEntityBuilder<MDIssueStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<MDIssueStatusEntity> MDIssueStatusEntityList = new List<MDIssueStatusEntity>();

            while (reader.Read())
            {
                MDIssueStatusEntityList.Add(((IEntityBuilder<MDIssueStatusEntity>)this).BuildEntity(reader));
            }

            return (MDIssueStatusEntityList.Count > 0) ? MDIssueStatusEntityList : null;
        }

        MDIssueStatusEntity IEntityBuilder<MDIssueStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ISSUESTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDIssueStatusEntity mDIssueStatusEntity = new MDIssueStatusEntity();

            mDIssueStatusEntity.IssueStatusID = reader.GetInt64(FLD_ISSUESTATUSID);
            mDIssueStatusEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDIssueStatusEntity.Description = String.Empty; } else { mDIssueStatusEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDIssueStatusEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDIssueStatusEntity;
        }
    }
}
