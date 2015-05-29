// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-May-2015, 12:41:19




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDOperatorStatusBuilder : IEntityBuilder<MDOperatorStatusEntity>
    {
        IList<MDOperatorStatusEntity> IEntityBuilder<MDOperatorStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<MDOperatorStatusEntity> MDOperatorStatusEntityList = new List<MDOperatorStatusEntity>();

            while (reader.Read())
            {
                MDOperatorStatusEntityList.Add(((IEntityBuilder<MDOperatorStatusEntity>)this).BuildEntity(reader));
            }

            return (MDOperatorStatusEntityList.Count > 0) ? MDOperatorStatusEntityList : null;
        }

        MDOperatorStatusEntity IEntityBuilder<MDOperatorStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_OPERATORSTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTON = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDOperatorStatusEntity mDOperatorStatusEntity = new MDOperatorStatusEntity();

            mDOperatorStatusEntity.OperatorStatusID = reader.GetInt64(FLD_OPERATORSTATUSID);
            mDOperatorStatusEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTON)) { mDOperatorStatusEntity.Descripton = String.Empty; } else { mDOperatorStatusEntity.Descripton = reader.GetString(FLD_DESCRIPTON); }
            mDOperatorStatusEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDOperatorStatusEntity;
        }
    }
}
