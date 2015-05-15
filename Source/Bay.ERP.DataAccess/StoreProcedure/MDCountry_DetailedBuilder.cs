// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Dec-2011, 02:17:33




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDCountry_DetailedBuilder : IEntityBuilder<MDCountry_DetailedEntity>
    {
        IList<MDCountry_DetailedEntity> IEntityBuilder<MDCountry_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<MDCountry_DetailedEntity> MDCountry_DetailedEntityList = new List<MDCountry_DetailedEntity>();

            while (reader.Read())
            {
                MDCountry_DetailedEntityList.Add(((IEntityBuilder<MDCountry_DetailedEntity>)this).BuildEntity(reader));
            }

            return (MDCountry_DetailedEntityList.Count > 0) ? MDCountry_DetailedEntityList : null;
        }

        MDCountry_DetailedEntity IEntityBuilder<MDCountry_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_COUNTRYID = 0;
            const Int32 FLD_REGIONID = 1;
            const Int32 FLD_NAME = 2;
            const Int32 FLD_ISREMOVED = 3;
            const Int32 FLD_REGIONNAME = 4;
            const Int32 FLD_ROWNUMBER = 5;

            MDCountry_DetailedEntity mDCountry_DetailedEntity = new MDCountry_DetailedEntity();

            mDCountry_DetailedEntity.CountryID = reader.GetInt64(FLD_COUNTRYID);
            mDCountry_DetailedEntity.RegionID = reader.GetInt64(FLD_REGIONID);
            mDCountry_DetailedEntity.Name = reader.GetString(FLD_NAME);
            mDCountry_DetailedEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            if (reader.IsDBNull(FLD_REGIONNAME)) { mDCountry_DetailedEntity.RegionName = String.Empty; } else { mDCountry_DetailedEntity.RegionName = reader.GetString(FLD_REGIONNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { mDCountry_DetailedEntity.RowNumber = null; } else { mDCountry_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return mDCountry_DetailedEntity;
        }
    }
}
