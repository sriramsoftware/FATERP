// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Dec-2011, 11:00:45




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDProjectAddressInfoBuilder : IEntityBuilder<BDProjectAddressInfoEntity>
    {
        IList<BDProjectAddressInfoEntity> IEntityBuilder<BDProjectAddressInfoEntity>.BuildEntities(IDataReader reader)
        {
            List<BDProjectAddressInfoEntity> BDProjectAddressInfoEntityList = new List<BDProjectAddressInfoEntity>();

            while (reader.Read())
            {
                BDProjectAddressInfoEntityList.Add(((IEntityBuilder<BDProjectAddressInfoEntity>)this).BuildEntity(reader));
            }

            return (BDProjectAddressInfoEntityList.Count > 0) ? BDProjectAddressInfoEntityList : null;
        }

        BDProjectAddressInfoEntity IEntityBuilder<BDProjectAddressInfoEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTADDRESSINFOID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_ADDRESSLINE1 = 2;
            const Int32 FLD_ADDRESSLINE2 = 3;
            const Int32 FLD_COUNTRYID = 4;
            const Int32 FLD_CITYID = 5;
            const Int32 FLD_ZIPCODE = 6;

            BDProjectAddressInfoEntity bDProjectAddressInfoEntity = new BDProjectAddressInfoEntity();

            bDProjectAddressInfoEntity.ProjectAddressInfoID = reader.GetInt64(FLD_PROJECTADDRESSINFOID);
            bDProjectAddressInfoEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            bDProjectAddressInfoEntity.AddressLine1 = reader.GetString(FLD_ADDRESSLINE1);
            if (reader.IsDBNull(FLD_ADDRESSLINE2)) { bDProjectAddressInfoEntity.AddressLine2 = String.Empty; } else { bDProjectAddressInfoEntity.AddressLine2 = reader.GetString(FLD_ADDRESSLINE2); }
            if (reader.IsDBNull(FLD_COUNTRYID)) { bDProjectAddressInfoEntity.CountryID = null; } else { bDProjectAddressInfoEntity.CountryID = reader.GetInt64(FLD_COUNTRYID); }
            if (reader.IsDBNull(FLD_CITYID)) { bDProjectAddressInfoEntity.CityID = null; } else { bDProjectAddressInfoEntity.CityID = reader.GetInt64(FLD_CITYID); }
            if (reader.IsDBNull(FLD_ZIPCODE)) { bDProjectAddressInfoEntity.ZipCode = String.Empty; } else { bDProjectAddressInfoEntity.ZipCode = reader.GetString(FLD_ZIPCODE); }

            return bDProjectAddressInfoEntity;
        }
    }
}
