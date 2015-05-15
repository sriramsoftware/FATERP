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
    internal sealed class MDCity_DetailedBuilder : IEntityBuilder<MDCity_DetailedEntity>
    {
        IList<MDCity_DetailedEntity> IEntityBuilder<MDCity_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<MDCity_DetailedEntity> MDCity_DetailedEntityList = new List<MDCity_DetailedEntity>();

            while (reader.Read())
            {
                MDCity_DetailedEntityList.Add(((IEntityBuilder<MDCity_DetailedEntity>)this).BuildEntity(reader));
            }

            return (MDCity_DetailedEntityList.Count > 0) ? MDCity_DetailedEntityList : null;
        }

        MDCity_DetailedEntity IEntityBuilder<MDCity_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CITYID = 0;
            const Int32 FLD_COUNTRYID = 1;
            const Int32 FLD_NAME = 2;
            const Int32 FLD_ISREMOVED = 3;
            const Int32 FLD_COUNTRYNAME = 4;
            const Int32 FLD_ROWNUMBER = 5;

            MDCity_DetailedEntity mDCity_DetailedEntity = new MDCity_DetailedEntity();

            mDCity_DetailedEntity.CityID = reader.GetInt64(FLD_CITYID);
            mDCity_DetailedEntity.CountryID = reader.GetInt64(FLD_COUNTRYID);
            mDCity_DetailedEntity.Name = reader.GetString(FLD_NAME);
            mDCity_DetailedEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            if (reader.IsDBNull(FLD_COUNTRYNAME)) { mDCity_DetailedEntity.CountryName = String.Empty; } else { mDCity_DetailedEntity.CountryName = reader.GetString(FLD_COUNTRYNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { mDCity_DetailedEntity.RowNumber = null; } else { mDCity_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return mDCity_DetailedEntity;
        }
    }
}
