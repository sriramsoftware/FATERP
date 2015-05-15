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
    internal sealed class MDReligionBuilder : IEntityBuilder<MDReligionEntity>
    {
        IList<MDReligionEntity> IEntityBuilder<MDReligionEntity>.BuildEntities(IDataReader reader)
        {
            List<MDReligionEntity> MDReligionEntityList = new List<MDReligionEntity>();

            while (reader.Read())
            {
                MDReligionEntityList.Add(((IEntityBuilder<MDReligionEntity>)this).BuildEntity(reader));
            }

            return (MDReligionEntityList.Count > 0) ? MDReligionEntityList : null;
        }

        MDReligionEntity IEntityBuilder<MDReligionEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_RELIGIONID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_REMARKS = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDReligionEntity mDReligionEntity = new MDReligionEntity();

            mDReligionEntity.ReligionID = reader.GetInt64(FLD_RELIGIONID);
            mDReligionEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_REMARKS)) { mDReligionEntity.Remarks = String.Empty; } else { mDReligionEntity.Remarks = reader.GetString(FLD_REMARKS); }
            mDReligionEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDReligionEntity;
        }
    }
}
