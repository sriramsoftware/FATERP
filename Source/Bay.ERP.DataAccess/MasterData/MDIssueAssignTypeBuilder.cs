// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Mar-2013, 11:29:57




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDIssueAssignTypeBuilder : IEntityBuilder<MDIssueAssignTypeEntity>
    {
        IList<MDIssueAssignTypeEntity> IEntityBuilder<MDIssueAssignTypeEntity>.BuildEntities(IDataReader reader)
        {
            List<MDIssueAssignTypeEntity> MDIssueAssignTypeEntityList = new List<MDIssueAssignTypeEntity>();

            while (reader.Read())
            {
                MDIssueAssignTypeEntityList.Add(((IEntityBuilder<MDIssueAssignTypeEntity>)this).BuildEntity(reader));
            }

            return (MDIssueAssignTypeEntityList.Count > 0) ? MDIssueAssignTypeEntityList : null;
        }

        MDIssueAssignTypeEntity IEntityBuilder<MDIssueAssignTypeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ISSUEASSIGNTYPEID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDIssueAssignTypeEntity mDIssueAssignTypeEntity = new MDIssueAssignTypeEntity();

            mDIssueAssignTypeEntity.IssueAssignTypeID = reader.GetInt64(FLD_ISSUEASSIGNTYPEID);
            mDIssueAssignTypeEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDIssueAssignTypeEntity.Description = String.Empty; } else { mDIssueAssignTypeEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDIssueAssignTypeEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDIssueAssignTypeEntity;
        }
    }
}
