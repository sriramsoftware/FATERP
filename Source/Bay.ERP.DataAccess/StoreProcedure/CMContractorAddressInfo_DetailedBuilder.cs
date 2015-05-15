// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Jan-2012, 06:01:25




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMContractorAddressInfo_DetailedBuilder : IEntityBuilder<CMContractorAddressInfo_DetailedEntity>
    {
        IList<CMContractorAddressInfo_DetailedEntity> IEntityBuilder<CMContractorAddressInfo_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<CMContractorAddressInfo_DetailedEntity> CMContractorAddressInfo_DetailedEntityList = new List<CMContractorAddressInfo_DetailedEntity>();

            while (reader.Read())
            {
                CMContractorAddressInfo_DetailedEntityList.Add(((IEntityBuilder<CMContractorAddressInfo_DetailedEntity>)this).BuildEntity(reader));
            }

            return (CMContractorAddressInfo_DetailedEntityList.Count > 0) ? CMContractorAddressInfo_DetailedEntityList : null;
        }

        CMContractorAddressInfo_DetailedEntity IEntityBuilder<CMContractorAddressInfo_DetailedEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_CONTRACTORNAME = 10;
            const Int32 FLD_ADDRESSTYPENAME = 11;
            const Int32 FLD_COUNTRYNAME = 12;
            const Int32 FLD_CITYNAME = 13;
            const Int32 FLD_ROWNUMBER = 14;

            CMContractorAddressInfo_DetailedEntity cMContractorAddressInfo_DetailedEntity = new CMContractorAddressInfo_DetailedEntity();

            cMContractorAddressInfo_DetailedEntity.ContractorAddressInfoID = reader.GetInt64(FLD_CONTRACTORADDRESSINFOID);
            cMContractorAddressInfo_DetailedEntity.ContractorID = reader.GetInt64(FLD_CONTRACTORID);
            cMContractorAddressInfo_DetailedEntity.AddressTypeID = reader.GetInt64(FLD_ADDRESSTYPEID);
            if (reader.IsDBNull(FLD_COUNTRYID)) { cMContractorAddressInfo_DetailedEntity.CountryID = null; } else { cMContractorAddressInfo_DetailedEntity.CountryID = reader.GetInt64(FLD_COUNTRYID); }
            if (reader.IsDBNull(FLD_CITYID)) { cMContractorAddressInfo_DetailedEntity.CityID = null; } else { cMContractorAddressInfo_DetailedEntity.CityID = reader.GetInt64(FLD_CITYID); }
            cMContractorAddressInfo_DetailedEntity.AddressLine1 = reader.GetString(FLD_ADDRESSLINE1);
            if (reader.IsDBNull(FLD_ADDRESSLINE2)) { cMContractorAddressInfo_DetailedEntity.AddressLine2 = String.Empty; } else { cMContractorAddressInfo_DetailedEntity.AddressLine2 = reader.GetString(FLD_ADDRESSLINE2); }
            if (reader.IsDBNull(FLD_FAX)) { cMContractorAddressInfo_DetailedEntity.Fax = String.Empty; } else { cMContractorAddressInfo_DetailedEntity.Fax = reader.GetString(FLD_FAX); }
            if (reader.IsDBNull(FLD_ZIPCODE)) { cMContractorAddressInfo_DetailedEntity.ZipCode = String.Empty; } else { cMContractorAddressInfo_DetailedEntity.ZipCode = reader.GetString(FLD_ZIPCODE); }
            if (reader.IsDBNull(FLD_PHONE)) { cMContractorAddressInfo_DetailedEntity.Phone = String.Empty; } else { cMContractorAddressInfo_DetailedEntity.Phone = reader.GetString(FLD_PHONE); }
            if (reader.IsDBNull(FLD_CONTRACTORNAME)) { cMContractorAddressInfo_DetailedEntity.ContractorName = String.Empty; } else { cMContractorAddressInfo_DetailedEntity.ContractorName = reader.GetString(FLD_CONTRACTORNAME); }
            if (reader.IsDBNull(FLD_ADDRESSTYPENAME)) { cMContractorAddressInfo_DetailedEntity.AddressTypeName = String.Empty; } else { cMContractorAddressInfo_DetailedEntity.AddressTypeName = reader.GetString(FLD_ADDRESSTYPENAME); }
            if (reader.IsDBNull(FLD_COUNTRYNAME)) { cMContractorAddressInfo_DetailedEntity.CountryName = String.Empty; } else { cMContractorAddressInfo_DetailedEntity.CountryName = reader.GetString(FLD_COUNTRYNAME); }
            if (reader.IsDBNull(FLD_CITYNAME)) { cMContractorAddressInfo_DetailedEntity.CityName = String.Empty; } else { cMContractorAddressInfo_DetailedEntity.CityName = reader.GetString(FLD_CITYNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { cMContractorAddressInfo_DetailedEntity.RowNumber = null; } else { cMContractorAddressInfo_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return cMContractorAddressInfo_DetailedEntity;
        }
    }
}
