// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Jan-2012, 10:20:36




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDRequisitionStatusBuilder : IEntityBuilder<MDRequisitionStatusEntity>
    {
        IList<MDRequisitionStatusEntity> IEntityBuilder<MDRequisitionStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<MDRequisitionStatusEntity> MDRequisitionStatusEntityList = new List<MDRequisitionStatusEntity>();

            while (reader.Read())
            {
                MDRequisitionStatusEntityList.Add(((IEntityBuilder<MDRequisitionStatusEntity>)this).BuildEntity(reader));
            }

            return (MDRequisitionStatusEntityList.Count > 0) ? MDRequisitionStatusEntityList : null;
        }

        MDRequisitionStatusEntity IEntityBuilder<MDRequisitionStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_REQUISITIONSTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_ISREMOVED = 2;

            MDRequisitionStatusEntity mDRequisitionStatusEntity = new MDRequisitionStatusEntity();

            mDRequisitionStatusEntity.RequisitionStatusID = reader.GetInt64(FLD_REQUISITIONSTATUSID);
            mDRequisitionStatusEntity.Name = reader.GetString(FLD_NAME);
            mDRequisitionStatusEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDRequisitionStatusEntity;
        }
    }
}
