// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-May-2012, 04:20:17




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMNApprovalProcessBuilder : IEntityBuilder<CMNApprovalProcessEntity>
    {
        IList<CMNApprovalProcessEntity> IEntityBuilder<CMNApprovalProcessEntity>.BuildEntities(IDataReader reader)
        {
            List<CMNApprovalProcessEntity> CMNApprovalProcessEntityList = new List<CMNApprovalProcessEntity>();

            while (reader.Read())
            {
                CMNApprovalProcessEntityList.Add(((IEntityBuilder<CMNApprovalProcessEntity>)this).BuildEntity(reader));
            }

            return (CMNApprovalProcessEntityList.Count > 0) ? CMNApprovalProcessEntityList : null;
        }

        CMNApprovalProcessEntity IEntityBuilder<CMNApprovalProcessEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_APPROVALPROCESSID = 0;
            const Int32 FLD_REFERENCEID = 1;
            const Int32 FLD_APPROVALPROCESSTYPEID = 2;
            const Int32 FLD_CREATEDATE = 3;
            const Int32 FLD_APPROVALPROCESSSTATUSID = 4;
            const Int32 FLD_APPROVALPROCESSPRIORITYID = 5;

            CMNApprovalProcessEntity cMNApprovalProcessEntity = new CMNApprovalProcessEntity();

            cMNApprovalProcessEntity.ApprovalProcessID = reader.GetInt64(FLD_APPROVALPROCESSID);
            cMNApprovalProcessEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID);
            cMNApprovalProcessEntity.ApprovalProcessTypeID = reader.GetInt64(FLD_APPROVALPROCESSTYPEID);
            cMNApprovalProcessEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            cMNApprovalProcessEntity.ApprovalProcessStatusID = reader.GetInt64(FLD_APPROVALPROCESSSTATUSID);
            cMNApprovalProcessEntity.ApprovalProcessPriorityID = reader.GetInt64(FLD_APPROVALPROCESSPRIORITYID);

            return cMNApprovalProcessEntity;
        }
    }
}
