// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Mar-2013, 11:12:01




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDMaterialReceiveApprovalStatusBuilder : IEntityBuilder<MDMaterialReceiveApprovalStatusEntity>
    {
        IList<MDMaterialReceiveApprovalStatusEntity> IEntityBuilder<MDMaterialReceiveApprovalStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<MDMaterialReceiveApprovalStatusEntity> MDMaterialReceiveApprovalStatusEntityList = new List<MDMaterialReceiveApprovalStatusEntity>();

            while (reader.Read())
            {
                MDMaterialReceiveApprovalStatusEntityList.Add(((IEntityBuilder<MDMaterialReceiveApprovalStatusEntity>)this).BuildEntity(reader));
            }

            return (MDMaterialReceiveApprovalStatusEntityList.Count > 0) ? MDMaterialReceiveApprovalStatusEntityList : null;
        }

        MDMaterialReceiveApprovalStatusEntity IEntityBuilder<MDMaterialReceiveApprovalStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_MATERIALRECEIVEAPPROVALSTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_ISREMOVED = 2;

            MDMaterialReceiveApprovalStatusEntity mDMaterialReceiveApprovalStatusEntity = new MDMaterialReceiveApprovalStatusEntity();

            mDMaterialReceiveApprovalStatusEntity.MaterialReceiveApprovalStatusID = reader.GetInt64(FLD_MATERIALRECEIVEAPPROVALSTATUSID);
            mDMaterialReceiveApprovalStatusEntity.Name = reader.GetString(FLD_NAME);
            mDMaterialReceiveApprovalStatusEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDMaterialReceiveApprovalStatusEntity;
        }
    }
}