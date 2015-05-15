// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-May-2013, 02:32:38




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDProcessAssignedResourceBuilder : IEntityBuilder<BDProcessAssignedResourceEntity>
    {
        IList<BDProcessAssignedResourceEntity> IEntityBuilder<BDProcessAssignedResourceEntity>.BuildEntities(IDataReader reader)
        {
            List<BDProcessAssignedResourceEntity> BDProcessAssignedResourceEntityList = new List<BDProcessAssignedResourceEntity>();

            while (reader.Read())
            {
                BDProcessAssignedResourceEntityList.Add(((IEntityBuilder<BDProcessAssignedResourceEntity>)this).BuildEntity(reader));
            }

            return (BDProcessAssignedResourceEntityList.Count > 0) ? BDProcessAssignedResourceEntityList : null;
        }

        BDProcessAssignedResourceEntity IEntityBuilder<BDProcessAssignedResourceEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROCESSASSIGNEDRESOURCEID = 0;
            const Int32 FLD_PROCESSCATEGORYID = 1;
            const Int32 FLD_TITLE = 2;
            const Int32 FLD_PURPOSES = 3;
            const Int32 FLD_REMARKS = 4;
            const Int32 FLD_STARTDATE = 5;
            const Int32 FLD_CREATEDATE = 6;
            const Int32 FLD_CREATEBYEMPLOYEEID = 7;
            const Int32 FLD_PROCESSASSIGNEDRESOURCEAPPROVALSTATUSID = 8;

            BDProcessAssignedResourceEntity bDProcessAssignedResourceEntity = new BDProcessAssignedResourceEntity();

            bDProcessAssignedResourceEntity.ProcessAssignedResourceID = reader.GetInt64(FLD_PROCESSASSIGNEDRESOURCEID);
            bDProcessAssignedResourceEntity.ProcessCategoryID = reader.GetInt64(FLD_PROCESSCATEGORYID);
            bDProcessAssignedResourceEntity.Title = reader.GetString(FLD_TITLE);
            if (reader.IsDBNull(FLD_PURPOSES)) { bDProcessAssignedResourceEntity.Purposes = String.Empty; } else { bDProcessAssignedResourceEntity.Purposes = reader.GetString(FLD_PURPOSES); }
            if (reader.IsDBNull(FLD_REMARKS)) { bDProcessAssignedResourceEntity.Remarks = String.Empty; } else { bDProcessAssignedResourceEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_STARTDATE)) { bDProcessAssignedResourceEntity.StartDate = null; } else { bDProcessAssignedResourceEntity.StartDate = reader.GetDateTime(FLD_STARTDATE); }
            bDProcessAssignedResourceEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            bDProcessAssignedResourceEntity.CreateByEmployeeID = reader.GetInt64(FLD_CREATEBYEMPLOYEEID);
            bDProcessAssignedResourceEntity.ProcessAssignedResourceApprovalStatusID = reader.GetInt64(FLD_PROCESSASSIGNEDRESOURCEAPPROVALSTATUSID);

            return bDProcessAssignedResourceEntity;
        }
    }
}
