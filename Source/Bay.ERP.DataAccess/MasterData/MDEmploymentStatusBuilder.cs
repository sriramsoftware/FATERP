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
    internal sealed class MDEmploymentStatusBuilder : IEntityBuilder<MDEmploymentStatusEntity>
    {
        IList<MDEmploymentStatusEntity> IEntityBuilder<MDEmploymentStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<MDEmploymentStatusEntity> MDEmploymentStatusEntityList = new List<MDEmploymentStatusEntity>();

            while (reader.Read())
            {
                MDEmploymentStatusEntityList.Add(((IEntityBuilder<MDEmploymentStatusEntity>)this).BuildEntity(reader));
            }

            return (MDEmploymentStatusEntityList.Count > 0) ? MDEmploymentStatusEntityList : null;
        }

        MDEmploymentStatusEntity IEntityBuilder<MDEmploymentStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYMENTSTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_ISREMOVED = 2;

            MDEmploymentStatusEntity mDEmploymentStatusEntity = new MDEmploymentStatusEntity();

            mDEmploymentStatusEntity.EmploymentStatusID = reader.GetInt64(FLD_EMPLOYMENTSTATUSID);
            mDEmploymentStatusEntity.Name = reader.GetString(FLD_NAME);
            mDEmploymentStatusEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDEmploymentStatusEntity;
        }
    }
}
