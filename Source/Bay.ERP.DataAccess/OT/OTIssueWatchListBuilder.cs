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
    internal sealed class OTIssueWatchListBuilder : IEntityBuilder<OTIssueWatchListEntity>
    {
        IList<OTIssueWatchListEntity> IEntityBuilder<OTIssueWatchListEntity>.BuildEntities(IDataReader reader)
        {
            List<OTIssueWatchListEntity> OTIssueWatchListEntityList = new List<OTIssueWatchListEntity>();

            while (reader.Read())
            {
                OTIssueWatchListEntityList.Add(((IEntityBuilder<OTIssueWatchListEntity>)this).BuildEntity(reader));
            }

            return (OTIssueWatchListEntityList.Count > 0) ? OTIssueWatchListEntityList : null;
        }

        OTIssueWatchListEntity IEntityBuilder<OTIssueWatchListEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ISSUEWATCHLISTID = 0;
            const Int32 FLD_ISSUEID = 1;
            const Int32 FLD_RESOURCEID = 2;

            OTIssueWatchListEntity oTIssueWatchListEntity = new OTIssueWatchListEntity();

            oTIssueWatchListEntity.IssueWatchListID = reader.GetInt64(FLD_ISSUEWATCHLISTID);
            oTIssueWatchListEntity.IssueID = reader.GetInt64(FLD_ISSUEID);
            oTIssueWatchListEntity.ResourceID = reader.GetInt64(FLD_RESOURCEID);

            return oTIssueWatchListEntity;
        }
    }
}
