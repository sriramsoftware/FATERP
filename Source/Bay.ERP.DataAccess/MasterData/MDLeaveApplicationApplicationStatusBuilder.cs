// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDLeaveApplicationApplicationStatusBuilder : IEntityBuilder<MDLeaveApplicationApplicationStatusEntity>
    {
        IList<MDLeaveApplicationApplicationStatusEntity> IEntityBuilder<MDLeaveApplicationApplicationStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<MDLeaveApplicationApplicationStatusEntity> MDLeaveApplicationApplicationStatusEntityList = new List<MDLeaveApplicationApplicationStatusEntity>();

            while (reader.Read())
            {
                MDLeaveApplicationApplicationStatusEntityList.Add(((IEntityBuilder<MDLeaveApplicationApplicationStatusEntity>)this).BuildEntity(reader));
            }

            return (MDLeaveApplicationApplicationStatusEntityList.Count > 0) ? MDLeaveApplicationApplicationStatusEntityList : null;
        }

        MDLeaveApplicationApplicationStatusEntity IEntityBuilder<MDLeaveApplicationApplicationStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_LEAVEAPPLICATIONAPPLICATIONSTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDLeaveApplicationApplicationStatusEntity mDLeaveApplicationApplicationStatusEntity = new MDLeaveApplicationApplicationStatusEntity();

            mDLeaveApplicationApplicationStatusEntity.LeaveApplicationApplicationStatusID = reader.GetInt64(FLD_LEAVEAPPLICATIONAPPLICATIONSTATUSID);
            mDLeaveApplicationApplicationStatusEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDLeaveApplicationApplicationStatusEntity.Description = String.Empty; } else { mDLeaveApplicationApplicationStatusEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDLeaveApplicationApplicationStatusEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDLeaveApplicationApplicationStatusEntity;
        }
    }
}
