// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 01:41:28




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDCountryBuilder : IEntityBuilder<MDCountryEntity>
    {
        IList<MDCountryEntity> IEntityBuilder<MDCountryEntity>.BuildEntities(IDataReader reader)
        {
            List<MDCountryEntity> MDCountryEntityList = new List<MDCountryEntity>();

            while (reader.Read())
            {
                MDCountryEntityList.Add(((IEntityBuilder<MDCountryEntity>)this).BuildEntity(reader));
            }

            return (MDCountryEntityList.Count > 0) ? MDCountryEntityList : null;
        }

        MDCountryEntity IEntityBuilder<MDCountryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_COUNTRYID = 0;
            const Int32 FLD_REGIONID = 1;
            const Int32 FLD_NAME = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDCountryEntity mDCountryEntity = new MDCountryEntity();

            mDCountryEntity.CountryID = reader.GetInt64(FLD_COUNTRYID);
            mDCountryEntity.RegionID = reader.GetInt64(FLD_REGIONID);
            mDCountryEntity.Name = reader.GetString(FLD_NAME);
            mDCountryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDCountryEntity;
        }
    }
}
