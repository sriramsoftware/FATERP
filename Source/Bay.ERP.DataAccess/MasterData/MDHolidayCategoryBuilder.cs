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
    internal sealed class MDHolidayCategoryBuilder : IEntityBuilder<MDHolidayCategoryEntity>
    {
        IList<MDHolidayCategoryEntity> IEntityBuilder<MDHolidayCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<MDHolidayCategoryEntity> MDHolidayCategoryEntityList = new List<MDHolidayCategoryEntity>();

            while (reader.Read())
            {
                MDHolidayCategoryEntityList.Add(((IEntityBuilder<MDHolidayCategoryEntity>)this).BuildEntity(reader));
            }

            return (MDHolidayCategoryEntityList.Count > 0) ? MDHolidayCategoryEntityList : null;
        }

        MDHolidayCategoryEntity IEntityBuilder<MDHolidayCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_HOLIDAYCATEGORYID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_COLORNAME = 3;
            const Int32 FLD_COLORCODE = 4;
            const Int32 FLD_REMARKS = 5;
            const Int32 FLD_ISREMOVED = 6;

            MDHolidayCategoryEntity mDHolidayCategoryEntity = new MDHolidayCategoryEntity();

            mDHolidayCategoryEntity.HolidayCategoryID = reader.GetInt64(FLD_HOLIDAYCATEGORYID);
            mDHolidayCategoryEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDHolidayCategoryEntity.Description = String.Empty; } else { mDHolidayCategoryEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            if (reader.IsDBNull(FLD_COLORNAME)) { mDHolidayCategoryEntity.ColorName = String.Empty; } else { mDHolidayCategoryEntity.ColorName = reader.GetString(FLD_COLORNAME); }
            if (reader.IsDBNull(FLD_COLORCODE)) { mDHolidayCategoryEntity.ColorCode = String.Empty; } else { mDHolidayCategoryEntity.ColorCode = reader.GetString(FLD_COLORCODE); }
            if (reader.IsDBNull(FLD_REMARKS)) { mDHolidayCategoryEntity.Remarks = String.Empty; } else { mDHolidayCategoryEntity.Remarks = reader.GetString(FLD_REMARKS); }
            mDHolidayCategoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDHolidayCategoryEntity;
        }
    }
}
