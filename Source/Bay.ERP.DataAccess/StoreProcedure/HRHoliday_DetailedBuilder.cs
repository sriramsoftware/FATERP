// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Mar-2012, 11:22:12




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HRHoliday_DetailedBuilder : IEntityBuilder<HRHoliday_DetailedEntity>
    {
        IList<HRHoliday_DetailedEntity> IEntityBuilder<HRHoliday_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<HRHoliday_DetailedEntity> HRHoliday_DetailedEntityList = new List<HRHoliday_DetailedEntity>();

            while (reader.Read())
            {
                HRHoliday_DetailedEntityList.Add(((IEntityBuilder<HRHoliday_DetailedEntity>)this).BuildEntity(reader));
            }

            return (HRHoliday_DetailedEntityList.Count > 0) ? HRHoliday_DetailedEntityList : null;
        }

        HRHoliday_DetailedEntity IEntityBuilder<HRHoliday_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_HOLIDAYID = 0;
            const Int32 FLD_HOLIDAYCATEGORYID = 1;
            const Int32 FLD_NAME = 2;
            const Int32 FLD_HOLIDAYDATE = 3;
            const Int32 FLD_HOLIDAYCATEGORYNAME = 4;
            const Int32 FLD_ROWNUMBER = 5;

            HRHoliday_DetailedEntity hRHoliday_DetailedEntity = new HRHoliday_DetailedEntity();

            hRHoliday_DetailedEntity.HolidayID = reader.GetInt64(FLD_HOLIDAYID);
            hRHoliday_DetailedEntity.HolidayCategoryID = reader.GetInt64(FLD_HOLIDAYCATEGORYID);
            hRHoliday_DetailedEntity.Name = reader.GetString(FLD_NAME);
            hRHoliday_DetailedEntity.HolidayDate = reader.GetDateTime(FLD_HOLIDAYDATE);
            if (reader.IsDBNull(FLD_HOLIDAYCATEGORYNAME)) { hRHoliday_DetailedEntity.HolidayCategoryName = String.Empty; } else { hRHoliday_DetailedEntity.HolidayCategoryName = reader.GetString(FLD_HOLIDAYCATEGORYNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { hRHoliday_DetailedEntity.RowNumber = null; } else { hRHoliday_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return hRHoliday_DetailedEntity;
        }
    }
}
