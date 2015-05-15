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
    internal sealed class BDProjectAddressInfo_DetailedBuilder : IEntityBuilder<BDProjectAddressInfo_DetailedEntity>
    {
        IList<BDProjectAddressInfo_DetailedEntity> IEntityBuilder<BDProjectAddressInfo_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<BDProjectAddressInfo_DetailedEntity> BDProjectAddressInfo_DetailedEntityList = new List<BDProjectAddressInfo_DetailedEntity>();

            while (reader.Read())
            {
                BDProjectAddressInfo_DetailedEntityList.Add(((IEntityBuilder<BDProjectAddressInfo_DetailedEntity>)this).BuildEntity(reader));
            }

            return (BDProjectAddressInfo_DetailedEntityList.Count > 0) ? BDProjectAddressInfo_DetailedEntityList : null;
        }

        BDProjectAddressInfo_DetailedEntity IEntityBuilder<BDProjectAddressInfo_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTADDRESSINFOID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_ADDRESSLINE1 = 2;
            const Int32 FLD_ADDRESSLINE2 = 3;
            const Int32 FLD_COUNTRYID = 4;
            const Int32 FLD_CITYID = 5;
            const Int32 FLD_ZIPCODE = 6;
            const Int32 FLD_PROJECTNAME = 7;
            const Int32 FLD_COUNTRYNAME = 8;
            const Int32 FLD_CITYNAME = 9;
            const Int32 FLD_ROWNUMBER = 10;

            BDProjectAddressInfo_DetailedEntity bDProjectAddressInfo_DetailedEntity = new BDProjectAddressInfo_DetailedEntity();

            bDProjectAddressInfo_DetailedEntity.ProjectAddressInfoID = reader.GetInt64(FLD_PROJECTADDRESSINFOID);
            bDProjectAddressInfo_DetailedEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            bDProjectAddressInfo_DetailedEntity.AddressLine1 = reader.GetString(FLD_ADDRESSLINE1);
            if (reader.IsDBNull(FLD_ADDRESSLINE2)) { bDProjectAddressInfo_DetailedEntity.AddressLine2 = String.Empty; } else { bDProjectAddressInfo_DetailedEntity.AddressLine2 = reader.GetString(FLD_ADDRESSLINE2); }
            if (reader.IsDBNull(FLD_COUNTRYID)) { bDProjectAddressInfo_DetailedEntity.CountryID = null; } else { bDProjectAddressInfo_DetailedEntity.CountryID = reader.GetInt64(FLD_COUNTRYID); }
            if (reader.IsDBNull(FLD_CITYID)) { bDProjectAddressInfo_DetailedEntity.CityID = null; } else { bDProjectAddressInfo_DetailedEntity.CityID = reader.GetInt64(FLD_CITYID); }
            if (reader.IsDBNull(FLD_ZIPCODE)) { bDProjectAddressInfo_DetailedEntity.ZipCode = String.Empty; } else { bDProjectAddressInfo_DetailedEntity.ZipCode = reader.GetString(FLD_ZIPCODE); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { bDProjectAddressInfo_DetailedEntity.ProjectName = String.Empty; } else { bDProjectAddressInfo_DetailedEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_COUNTRYNAME)) { bDProjectAddressInfo_DetailedEntity.CountryName = String.Empty; } else { bDProjectAddressInfo_DetailedEntity.CountryName = reader.GetString(FLD_COUNTRYNAME); }
            if (reader.IsDBNull(FLD_CITYNAME)) { bDProjectAddressInfo_DetailedEntity.CityName = String.Empty; } else { bDProjectAddressInfo_DetailedEntity.CityName = reader.GetString(FLD_CITYNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { bDProjectAddressInfo_DetailedEntity.RowNumber = null; } else { bDProjectAddressInfo_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return bDProjectAddressInfo_DetailedEntity;
        }
    }
}
