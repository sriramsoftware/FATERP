// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-May-2015, 08:31:04




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDOperatorAddressInfoBuilder : IEntityBuilder<BDOperatorAddressInfoEntity>
    {
        IList<BDOperatorAddressInfoEntity> IEntityBuilder<BDOperatorAddressInfoEntity>.BuildEntities(IDataReader reader)
        {
            List<BDOperatorAddressInfoEntity> BDOperatorAddressInfoEntityList = new List<BDOperatorAddressInfoEntity>();

            while (reader.Read())
            {
                BDOperatorAddressInfoEntityList.Add(((IEntityBuilder<BDOperatorAddressInfoEntity>)this).BuildEntity(reader));
            }

            return (BDOperatorAddressInfoEntityList.Count > 0) ? BDOperatorAddressInfoEntityList : null;
        }

        BDOperatorAddressInfoEntity IEntityBuilder<BDOperatorAddressInfoEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_OPERATORADDRESSINFOID = 0;
            const Int32 FLD_OPERATORID = 1;
            const Int32 FLD_WEBLINK = 2;
            const Int32 FLD_OPERATORADDRESSTYPEID = 3;
            const Int32 FLD_ADDRESSLINE1 = 4;
            const Int32 FLD_ADDRESSLINE2 = 5;
            const Int32 FLD_COUNTRYID = 6;
            const Int32 FLD_CITYID = 7;
            const Int32 FLD_ZIPCODE = 8;
            const Int32 FLD_PHONE = 9;
            const Int32 FLD_EMAIL = 10;

            BDOperatorAddressInfoEntity bDOperatorAddressInfoEntity = new BDOperatorAddressInfoEntity();

            bDOperatorAddressInfoEntity.OperatorAddressInfoID = reader.GetInt64(FLD_OPERATORADDRESSINFOID);
            bDOperatorAddressInfoEntity.OperatorID = reader.GetInt64(FLD_OPERATORID);
            if (reader.IsDBNull(FLD_WEBLINK)) { bDOperatorAddressInfoEntity.WebLink = String.Empty; } else { bDOperatorAddressInfoEntity.WebLink = reader.GetString(FLD_WEBLINK); }
            bDOperatorAddressInfoEntity.OperatorAddressTypeID = reader.GetInt64(FLD_OPERATORADDRESSTYPEID);
            bDOperatorAddressInfoEntity.AddressLine1 = reader.GetString(FLD_ADDRESSLINE1);
            if (reader.IsDBNull(FLD_ADDRESSLINE2)) { bDOperatorAddressInfoEntity.AddressLine2 = String.Empty; } else { bDOperatorAddressInfoEntity.AddressLine2 = reader.GetString(FLD_ADDRESSLINE2); }
            if (reader.IsDBNull(FLD_COUNTRYID)) { bDOperatorAddressInfoEntity.CountryID = null; } else { bDOperatorAddressInfoEntity.CountryID = reader.GetInt64(FLD_COUNTRYID); }
            if (reader.IsDBNull(FLD_CITYID)) { bDOperatorAddressInfoEntity.CityID = null; } else { bDOperatorAddressInfoEntity.CityID = reader.GetInt64(FLD_CITYID); }
            if (reader.IsDBNull(FLD_ZIPCODE)) { bDOperatorAddressInfoEntity.ZipCode = String.Empty; } else { bDOperatorAddressInfoEntity.ZipCode = reader.GetString(FLD_ZIPCODE); }
            if (reader.IsDBNull(FLD_PHONE)) { bDOperatorAddressInfoEntity.Phone = String.Empty; } else { bDOperatorAddressInfoEntity.Phone = reader.GetString(FLD_PHONE); }
            if (reader.IsDBNull(FLD_EMAIL)) { bDOperatorAddressInfoEntity.Email = String.Empty; } else { bDOperatorAddressInfoEntity.Email = reader.GetString(FLD_EMAIL); }

            return bDOperatorAddressInfoEntity;
        }
    }
}
