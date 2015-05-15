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
    internal sealed class MDCityBuilder : IEntityBuilder<MDCityEntity>
    {
        IList<MDCityEntity> IEntityBuilder<MDCityEntity>.BuildEntities(IDataReader reader)
        {
            List<MDCityEntity> MDCityEntityList = new List<MDCityEntity>();

            while (reader.Read())
            {
                MDCityEntityList.Add(((IEntityBuilder<MDCityEntity>)this).BuildEntity(reader));
            }

            return (MDCityEntityList.Count > 0) ? MDCityEntityList : null;
        }

        MDCityEntity IEntityBuilder<MDCityEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CITYID = 0;
            const Int32 FLD_COUNTRYID = 1;
            const Int32 FLD_NAME = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDCityEntity mDCityEntity = new MDCityEntity();

            mDCityEntity.CityID = reader.GetInt64(FLD_CITYID);
            mDCityEntity.CountryID = reader.GetInt64(FLD_COUNTRYID);
            mDCityEntity.Name = reader.GetString(FLD_NAME);
            mDCityEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDCityEntity;
        }
    }
}
