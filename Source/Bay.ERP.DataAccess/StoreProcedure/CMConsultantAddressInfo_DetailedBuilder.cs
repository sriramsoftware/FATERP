// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Jan-2012, 11:59:55




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMConsultantAddressInfo_DetailedBuilder : IEntityBuilder<CMConsultantAddressInfo_DetailedEntity>
    {
        IList<CMConsultantAddressInfo_DetailedEntity> IEntityBuilder<CMConsultantAddressInfo_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<CMConsultantAddressInfo_DetailedEntity> CMConsultantAddressInfo_DetailedEntityList = new List<CMConsultantAddressInfo_DetailedEntity>();

            while (reader.Read())
            {
                CMConsultantAddressInfo_DetailedEntityList.Add(((IEntityBuilder<CMConsultantAddressInfo_DetailedEntity>)this).BuildEntity(reader));
            }

            return (CMConsultantAddressInfo_DetailedEntityList.Count > 0) ? CMConsultantAddressInfo_DetailedEntityList : null;
        }

        CMConsultantAddressInfo_DetailedEntity IEntityBuilder<CMConsultantAddressInfo_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CONSULTANTADDRESSINFOID = 0;
            const Int32 FLD_CONSULTANTID = 1;
            const Int32 FLD_ADDRESSTYPEID = 2;
            const Int32 FLD_PHONE = 3;
            const Int32 FLD_COUNTRYID = 4;
            const Int32 FLD_CITYID = 5;
            const Int32 FLD_ADDRESSLINE1 = 6;
            const Int32 FLD_ADDRESSLINE2 = 7;
            const Int32 FLD_FAX = 8;
            const Int32 FLD_ZIPCODE = 9;
            const Int32 FLD_CONSULTANTNAME = 10;
            const Int32 FLD_ADDRESSTYPENAME = 11;
            const Int32 FLD_COUNTRYNAME = 12;
            const Int32 FLD_CITYNAME = 13;
            const Int32 FLD_ROWNUMBER = 14;

            CMConsultantAddressInfo_DetailedEntity cMConsultantAddressInfo_DetailedEntity = new CMConsultantAddressInfo_DetailedEntity();

            cMConsultantAddressInfo_DetailedEntity.ConsultantAddressInfoID = reader.GetInt64(FLD_CONSULTANTADDRESSINFOID);
            cMConsultantAddressInfo_DetailedEntity.ConsultantID = reader.GetInt64(FLD_CONSULTANTID);
            cMConsultantAddressInfo_DetailedEntity.AddressTypeID = reader.GetInt64(FLD_ADDRESSTYPEID);
            if (reader.IsDBNull(FLD_PHONE)) { cMConsultantAddressInfo_DetailedEntity.Phone = String.Empty; } else { cMConsultantAddressInfo_DetailedEntity.Phone = reader.GetString(FLD_PHONE); }
            if (reader.IsDBNull(FLD_COUNTRYID)) { cMConsultantAddressInfo_DetailedEntity.CountryID = null; } else { cMConsultantAddressInfo_DetailedEntity.CountryID = reader.GetInt64(FLD_COUNTRYID); }
            if (reader.IsDBNull(FLD_CITYID)) { cMConsultantAddressInfo_DetailedEntity.CityID = null; } else { cMConsultantAddressInfo_DetailedEntity.CityID = reader.GetInt64(FLD_CITYID); }
            cMConsultantAddressInfo_DetailedEntity.AddressLine1 = reader.GetString(FLD_ADDRESSLINE1);
            if (reader.IsDBNull(FLD_ADDRESSLINE2)) { cMConsultantAddressInfo_DetailedEntity.AddressLine2 = String.Empty; } else { cMConsultantAddressInfo_DetailedEntity.AddressLine2 = reader.GetString(FLD_ADDRESSLINE2); }
            if (reader.IsDBNull(FLD_FAX)) { cMConsultantAddressInfo_DetailedEntity.Fax = String.Empty; } else { cMConsultantAddressInfo_DetailedEntity.Fax = reader.GetString(FLD_FAX); }
            if (reader.IsDBNull(FLD_ZIPCODE)) { cMConsultantAddressInfo_DetailedEntity.ZipCode = String.Empty; } else { cMConsultantAddressInfo_DetailedEntity.ZipCode = reader.GetString(FLD_ZIPCODE); }
            if (reader.IsDBNull(FLD_CONSULTANTNAME)) { cMConsultantAddressInfo_DetailedEntity.ConsultantName = String.Empty; } else { cMConsultantAddressInfo_DetailedEntity.ConsultantName = reader.GetString(FLD_CONSULTANTNAME); }
            if (reader.IsDBNull(FLD_ADDRESSTYPENAME)) { cMConsultantAddressInfo_DetailedEntity.AddressTypeName = String.Empty; } else { cMConsultantAddressInfo_DetailedEntity.AddressTypeName = reader.GetString(FLD_ADDRESSTYPENAME); }
            if (reader.IsDBNull(FLD_COUNTRYNAME)) { cMConsultantAddressInfo_DetailedEntity.CountryName = String.Empty; } else { cMConsultantAddressInfo_DetailedEntity.CountryName = reader.GetString(FLD_COUNTRYNAME); }
            if (reader.IsDBNull(FLD_CITYNAME)) { cMConsultantAddressInfo_DetailedEntity.CityName = String.Empty; } else { cMConsultantAddressInfo_DetailedEntity.CityName = reader.GetString(FLD_CITYNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { cMConsultantAddressInfo_DetailedEntity.RowNumber = null; } else { cMConsultantAddressInfo_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return cMConsultantAddressInfo_DetailedEntity;
        }
    }
}
