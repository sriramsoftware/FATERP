// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Jan-2012, 02:49:42




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMContractorAddressInfoBuilder : IEntityBuilder<CMContractorAddressInfoEntity>
    {
        IList<CMContractorAddressInfoEntity> IEntityBuilder<CMContractorAddressInfoEntity>.BuildEntities(IDataReader reader)
        {
            List<CMContractorAddressInfoEntity> CMContractorAddressInfoEntityList = new List<CMContractorAddressInfoEntity>();

            while (reader.Read())
            {
                CMContractorAddressInfoEntityList.Add(((IEntityBuilder<CMContractorAddressInfoEntity>)this).BuildEntity(reader));
            }

            return (CMContractorAddressInfoEntityList.Count > 0) ? CMContractorAddressInfoEntityList : null;
        }

        CMContractorAddressInfoEntity IEntityBuilder<CMContractorAddressInfoEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CONTRACTORADDRESSINFOID = 0;
            const Int32 FLD_CONTRACTORID = 1;
            const Int32 FLD_ADDRESSTYPEID = 2;
            const Int32 FLD_COUNTRYID = 3;
            const Int32 FLD_CITYID = 4;
            const Int32 FLD_ADDRESSLINE1 = 5;
            const Int32 FLD_ADDRESSLINE2 = 6;
            const Int32 FLD_FAX = 7;
            const Int32 FLD_ZIPCODE = 8;
            const Int32 FLD_PHONE = 9;

            CMContractorAddressInfoEntity cMContractorAddressInfoEntity = new CMContractorAddressInfoEntity();

            cMContractorAddressInfoEntity.ContractorAddressInfoID = reader.GetInt64(FLD_CONTRACTORADDRESSINFOID);
            cMContractorAddressInfoEntity.ContractorID = reader.GetInt64(FLD_CONTRACTORID);
            cMContractorAddressInfoEntity.AddressTypeID = reader.GetInt64(FLD_ADDRESSTYPEID);
            if (reader.IsDBNull(FLD_COUNTRYID)) { cMContractorAddressInfoEntity.CountryID = null; } else { cMContractorAddressInfoEntity.CountryID = reader.GetInt64(FLD_COUNTRYID); }
            if (reader.IsDBNull(FLD_CITYID)) { cMContractorAddressInfoEntity.CityID = null; } else { cMContractorAddressInfoEntity.CityID = reader.GetInt64(FLD_CITYID); }
            cMContractorAddressInfoEntity.AddressLine1 = reader.GetString(FLD_ADDRESSLINE1);
            if (reader.IsDBNull(FLD_ADDRESSLINE2)) { cMContractorAddressInfoEntity.AddressLine2 = String.Empty; } else { cMContractorAddressInfoEntity.AddressLine2 = reader.GetString(FLD_ADDRESSLINE2); }
            if (reader.IsDBNull(FLD_FAX)) { cMContractorAddressInfoEntity.Fax = String.Empty; } else { cMContractorAddressInfoEntity.Fax = reader.GetString(FLD_FAX); }
            if (reader.IsDBNull(FLD_ZIPCODE)) { cMContractorAddressInfoEntity.ZipCode = String.Empty; } else { cMContractorAddressInfoEntity.ZipCode = reader.GetString(FLD_ZIPCODE); }
            if (reader.IsDBNull(FLD_PHONE)) { cMContractorAddressInfoEntity.Phone = String.Empty; } else { cMContractorAddressInfoEntity.Phone = reader.GetString(FLD_PHONE); }

            return cMContractorAddressInfoEntity;
        }
    }
}
