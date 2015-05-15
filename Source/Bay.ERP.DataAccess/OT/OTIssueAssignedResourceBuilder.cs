// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Mar-2013, 10:57:47




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class OTIssueAssignedResourceBuilder : IEntityBuilder<OTIssueAssignedResourceEntity>
    {
        IList<OTIssueAssignedResourceEntity> IEntityBuilder<OTIssueAssignedResourceEntity>.BuildEntities(IDataReader reader)
        {
            List<OTIssueAssignedResourceEntity> OTIssueAssignedResourceEntityList = new List<OTIssueAssignedResourceEntity>();

            while (reader.Read())
            {
                OTIssueAssignedResourceEntityList.Add(((IEntityBuilder<OTIssueAssignedResourceEntity>)this).BuildEntity(reader));
            }

            return (OTIssueAssignedResourceEntityList.Count > 0) ? OTIssueAssignedResourceEntityList : null;
        }

        OTIssueAssignedResourceEntity IEntityBuilder<OTIssueAssignedResourceEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ISSUEASSIGNEDRESOURCEID = 0;
            const Int32 FLD_ISSUEID = 1;
            const Int32 FLD_RESOURCEID = 2;
            const Int32 FLD_STARTDATE = 3;
            const Int32 FLD_ENDDATE = 4;
            const Int32 FLD_ISSUEASSIGNTYPEID = 5;
            const Int32 FLD_REMARKS = 6;

            OTIssueAssignedResourceEntity oTIssueAssignedResourceEntity = new OTIssueAssignedResourceEntity();

            oTIssueAssignedResourceEntity.IssueAssignedResourceID = reader.GetInt64(FLD_ISSUEASSIGNEDRESOURCEID);
            oTIssueAssignedResourceEntity.IssueID = reader.GetInt64(FLD_ISSUEID);
            oTIssueAssignedResourceEntity.ResourceID = reader.GetInt64(FLD_RESOURCEID);
            oTIssueAssignedResourceEntity.StartDate = reader.GetDateTime(FLD_STARTDATE);
            oTIssueAssignedResourceEntity.EndDate = reader.GetDateTime(FLD_ENDDATE);
            oTIssueAssignedResourceEntity.IssueAssignTypeID = reader.GetInt64(FLD_ISSUEASSIGNTYPEID);
            if (reader.IsDBNull(FLD_REMARKS)) { oTIssueAssignedResourceEntity.Remarks = String.Empty; } else { oTIssueAssignedResourceEntity.Remarks = reader.GetString(FLD_REMARKS); }

            return oTIssueAssignedResourceEntity;
        }
    }
}
