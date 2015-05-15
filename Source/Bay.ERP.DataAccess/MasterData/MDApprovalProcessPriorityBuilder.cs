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
    internal sealed class MDApprovalProcessPriorityBuilder : IEntityBuilder<MDApprovalProcessPriorityEntity>
    {
        IList<MDApprovalProcessPriorityEntity> IEntityBuilder<MDApprovalProcessPriorityEntity>.BuildEntities(IDataReader reader)
        {
            List<MDApprovalProcessPriorityEntity> MDApprovalProcessPriorityEntityList = new List<MDApprovalProcessPriorityEntity>();

            while (reader.Read())
            {
                MDApprovalProcessPriorityEntityList.Add(((IEntityBuilder<MDApprovalProcessPriorityEntity>)this).BuildEntity(reader));
            }

            return (MDApprovalProcessPriorityEntityList.Count > 0) ? MDApprovalProcessPriorityEntityList : null;
        }

        MDApprovalProcessPriorityEntity IEntityBuilder<MDApprovalProcessPriorityEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_APPROVALPROCESSPRIORITYID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_RESPONSETIME = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDApprovalProcessPriorityEntity mDApprovalProcessPriorityEntity = new MDApprovalProcessPriorityEntity();

            mDApprovalProcessPriorityEntity.ApprovalProcessPriorityID = reader.GetInt64(FLD_APPROVALPROCESSPRIORITYID);
            mDApprovalProcessPriorityEntity.Name = reader.GetString(FLD_NAME);
            mDApprovalProcessPriorityEntity.ResponseTime = reader.GetInt32(FLD_RESPONSETIME);
            mDApprovalProcessPriorityEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDApprovalProcessPriorityEntity;
        }
    }
}
