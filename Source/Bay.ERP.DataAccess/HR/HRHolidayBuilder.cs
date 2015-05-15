// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HRHolidayBuilder : IEntityBuilder<HRHolidayEntity>
    {
        IList<HRHolidayEntity> IEntityBuilder<HRHolidayEntity>.BuildEntities(IDataReader reader)
        {
            List<HRHolidayEntity> HRHolidayEntityList = new List<HRHolidayEntity>();

            while (reader.Read())
            {
                HRHolidayEntityList.Add(((IEntityBuilder<HRHolidayEntity>)this).BuildEntity(reader));
            }

            return (HRHolidayEntityList.Count > 0) ? HRHolidayEntityList : null;
        }

        HRHolidayEntity IEntityBuilder<HRHolidayEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_HOLIDAYID = 0;
            const Int32 FLD_HOLIDAYCATEGORYID = 1;
            const Int32 FLD_NAME = 2;
            const Int32 FLD_HOLIDAYDATE = 3;
            const Int32 FLD_REMARKS = 4;
            const Int32 FLD_HOLIDAYAPPLIEDSTATUSID = 5;

            HRHolidayEntity hRHolidayEntity = new HRHolidayEntity();

            hRHolidayEntity.HolidayID = reader.GetInt64(FLD_HOLIDAYID);
            hRHolidayEntity.HolidayCategoryID = reader.GetInt64(FLD_HOLIDAYCATEGORYID);
            hRHolidayEntity.Name = reader.GetString(FLD_NAME);
            hRHolidayEntity.HolidayDate = reader.GetDateTime(FLD_HOLIDAYDATE);
            if (reader.IsDBNull(FLD_REMARKS)) { hRHolidayEntity.Remarks = String.Empty; } else { hRHolidayEntity.Remarks = reader.GetString(FLD_REMARKS); }
            hRHolidayEntity.HolidayAppliedStatusID = reader.GetInt64(FLD_HOLIDAYAPPLIEDSTATUSID);

            return hRHolidayEntity;
        }
    }
}
