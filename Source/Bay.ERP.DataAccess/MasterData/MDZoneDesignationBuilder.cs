// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-May-2015, 10:30:28




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDZoneDesignationBuilder : IEntityBuilder<MDZoneDesignationEntity>
    {
        IList<MDZoneDesignationEntity> IEntityBuilder<MDZoneDesignationEntity>.BuildEntities(IDataReader reader)
        {
            List<MDZoneDesignationEntity> MDZoneDesignationEntityList = new List<MDZoneDesignationEntity>();

            while (reader.Read())
            {
                MDZoneDesignationEntityList.Add(((IEntityBuilder<MDZoneDesignationEntity>)this).BuildEntity(reader));
            }

            return (MDZoneDesignationEntityList.Count > 0) ? MDZoneDesignationEntityList : null;
        }

        MDZoneDesignationEntity IEntityBuilder<MDZoneDesignationEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ZONEDESIGNATIONID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESIGNATION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDZoneDesignationEntity mDZoneDesignationEntity = new MDZoneDesignationEntity();

            mDZoneDesignationEntity.ZoneDesignationID = reader.GetInt64(FLD_ZONEDESIGNATIONID);
            mDZoneDesignationEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESIGNATION)) { mDZoneDesignationEntity.Designation = String.Empty; } else { mDZoneDesignationEntity.Designation = reader.GetString(FLD_DESIGNATION); }
            mDZoneDesignationEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDZoneDesignationEntity;
        }
    }
}
