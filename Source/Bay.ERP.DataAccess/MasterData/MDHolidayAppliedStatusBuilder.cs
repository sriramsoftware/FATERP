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
    internal sealed class MDHolidayAppliedStatusBuilder : IEntityBuilder<MDHolidayAppliedStatusEntity>
    {
        IList<MDHolidayAppliedStatusEntity> IEntityBuilder<MDHolidayAppliedStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<MDHolidayAppliedStatusEntity> MDHolidayAppliedStatusEntityList = new List<MDHolidayAppliedStatusEntity>();

            while (reader.Read())
            {
                MDHolidayAppliedStatusEntityList.Add(((IEntityBuilder<MDHolidayAppliedStatusEntity>)this).BuildEntity(reader));
            }

            return (MDHolidayAppliedStatusEntityList.Count > 0) ? MDHolidayAppliedStatusEntityList : null;
        }

        MDHolidayAppliedStatusEntity IEntityBuilder<MDHolidayAppliedStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_HOLIDAYAPPLIEDSTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_ISREMOVED = 2;

            MDHolidayAppliedStatusEntity mDHolidayAppliedStatusEntity = new MDHolidayAppliedStatusEntity();

            mDHolidayAppliedStatusEntity.HolidayAppliedStatusID = reader.GetInt64(FLD_HOLIDAYAPPLIEDSTATUSID);
            mDHolidayAppliedStatusEntity.Name = reader.GetString(FLD_NAME);
            mDHolidayAppliedStatusEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDHolidayAppliedStatusEntity;
        }
    }
}
