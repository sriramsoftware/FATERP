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
    internal sealed class BDMDProcessAssignedResourceApprovalStatusBuilder : IEntityBuilder<BDMDProcessAssignedResourceApprovalStatusEntity>
    {
        IList<BDMDProcessAssignedResourceApprovalStatusEntity> IEntityBuilder<BDMDProcessAssignedResourceApprovalStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<BDMDProcessAssignedResourceApprovalStatusEntity> BDMDProcessAssignedResourceApprovalStatusEntityList = new List<BDMDProcessAssignedResourceApprovalStatusEntity>();

            while (reader.Read())
            {
                BDMDProcessAssignedResourceApprovalStatusEntityList.Add(((IEntityBuilder<BDMDProcessAssignedResourceApprovalStatusEntity>)this).BuildEntity(reader));
            }

            return (BDMDProcessAssignedResourceApprovalStatusEntityList.Count > 0) ? BDMDProcessAssignedResourceApprovalStatusEntityList : null;
        }

        BDMDProcessAssignedResourceApprovalStatusEntity IEntityBuilder<BDMDProcessAssignedResourceApprovalStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROCESSASSIGNEDRESOURCEAPPROVALSTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            BDMDProcessAssignedResourceApprovalStatusEntity bDMDProcessAssignedResourceApprovalStatusEntity = new BDMDProcessAssignedResourceApprovalStatusEntity();

            bDMDProcessAssignedResourceApprovalStatusEntity.ProcessAssignedResourceApprovalStatusID = reader.GetInt64(FLD_PROCESSASSIGNEDRESOURCEAPPROVALSTATUSID);
            bDMDProcessAssignedResourceApprovalStatusEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { bDMDProcessAssignedResourceApprovalStatusEntity.Description = String.Empty; } else { bDMDProcessAssignedResourceApprovalStatusEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            bDMDProcessAssignedResourceApprovalStatusEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return bDMDProcessAssignedResourceApprovalStatusEntity;
        }
    }
}
