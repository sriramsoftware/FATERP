// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Nov-2013, 09:52:33




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDProcessAssignedResource_DetailedBuilder : IEntityBuilder<BDProcessAssignedResource_DetailedEntity>
    {
        IList<BDProcessAssignedResource_DetailedEntity> IEntityBuilder<BDProcessAssignedResource_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<BDProcessAssignedResource_DetailedEntity> BDProcessAssignedResource_DetailedEntityList = new List<BDProcessAssignedResource_DetailedEntity>();

            while (reader.Read())
            {
                BDProcessAssignedResource_DetailedEntityList.Add(((IEntityBuilder<BDProcessAssignedResource_DetailedEntity>)this).BuildEntity(reader));
            }

            return (BDProcessAssignedResource_DetailedEntityList.Count > 0) ? BDProcessAssignedResource_DetailedEntityList : null;
        }

        BDProcessAssignedResource_DetailedEntity IEntityBuilder<BDProcessAssignedResource_DetailedEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_PROCESSCATEGORYNAME = 9;
            const Int32 FLD_PROCESSASSIGNEDRESOURCESTATUS = 10;
            const Int32 FLD_MEMBERFULLNAME = 11;

            BDProcessAssignedResource_DetailedEntity bDProcessAssignedResource_DetailedEntity = new BDProcessAssignedResource_DetailedEntity();

            bDProcessAssignedResource_DetailedEntity.ProcessAssignedResourceID = reader.GetInt64(FLD_PROCESSASSIGNEDRESOURCEID);
            bDProcessAssignedResource_DetailedEntity.ProcessCategoryID = reader.GetInt64(FLD_PROCESSCATEGORYID);
            bDProcessAssignedResource_DetailedEntity.Title = reader.GetString(FLD_TITLE);
            if (reader.IsDBNull(FLD_PURPOSES)) { bDProcessAssignedResource_DetailedEntity.Purposes = String.Empty; } else { bDProcessAssignedResource_DetailedEntity.Purposes = reader.GetString(FLD_PURPOSES); }
            if (reader.IsDBNull(FLD_REMARKS)) { bDProcessAssignedResource_DetailedEntity.Remarks = String.Empty; } else { bDProcessAssignedResource_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_STARTDATE)) { bDProcessAssignedResource_DetailedEntity.StartDate = null; } else { bDProcessAssignedResource_DetailedEntity.StartDate = reader.GetDateTime(FLD_STARTDATE); }
            bDProcessAssignedResource_DetailedEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            bDProcessAssignedResource_DetailedEntity.CreateByEmployeeID = reader.GetInt64(FLD_CREATEBYEMPLOYEEID);
            bDProcessAssignedResource_DetailedEntity.ProcessAssignedResourceApprovalStatusID = reader.GetInt64(FLD_PROCESSASSIGNEDRESOURCEAPPROVALSTATUSID);
            bDProcessAssignedResource_DetailedEntity.ProcessCategoryName = reader.GetString(FLD_PROCESSCATEGORYNAME);
            bDProcessAssignedResource_DetailedEntity.ProcessAssignedResourceStatus = reader.GetString(FLD_PROCESSASSIGNEDRESOURCESTATUS);
            if (reader.IsDBNull(FLD_MEMBERFULLNAME)) { bDProcessAssignedResource_DetailedEntity.MemberFullName = String.Empty; } else { bDProcessAssignedResource_DetailedEntity.MemberFullName = reader.GetString(FLD_MEMBERFULLNAME); }

            return bDProcessAssignedResource_DetailedEntity;
        }
    }
}
