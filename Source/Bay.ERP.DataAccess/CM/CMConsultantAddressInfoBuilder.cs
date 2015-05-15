// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 04:47:08




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMConsultantAddressInfoBuilder : IEntityBuilder<CMConsultantAddressInfoEntity>
    {
        IList<CMConsultantAddressInfoEntity> IEntityBuilder<CMConsultantAddressInfoEntity>.BuildEntities(IDataReader reader)
        {
            List<CMConsultantAddressInfoEntity> CMConsultantAddressInfoEntityList = new List<CMConsultantAddressInfoEntity>();

            while (reader.Read())
            {
                CMConsultantAddressInfoEntityList.Add(((IEntityBuilder<CMConsultantAddressInfoEntity>)this).BuildEntity(reader));
            }

            return (CMConsultantAddressInfoEntityList.Count > 0) ? CMConsultantAddressInfoEntityList : null;
        }

        CMConsultantAddressInfoEntity IEntityBuilder<CMConsultantAddressInfoEntity>.BuildEntity(IDataReader reader)
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

            CMConsultantAddressInfoEntity cMConsultantAddressInfoEntity = new CMConsultantAddressInfoEntity();

            cMConsultantAddressInfoEntity.ConsultantAddressInfoID = reader.GetInt64(FLD_CONSULTANTADDRESSINFOID);
            cMConsultantAddressInfoEntity.ConsultantID = reader.GetInt64(FLD_CONSULTANTID);
            cMConsultantAddressInfoEntity.AddressTypeID = reader.GetInt64(FLD_ADDRESSTYPEID);
            if (reader.IsDBNull(FLD_PHONE)) { cMConsultantAddressInfoEntity.Phone = String.Empty; } else { cMConsultantAddressInfoEntity.Phone = reader.GetString(FLD_PHONE); }
            if (reader.IsDBNull(FLD_COUNTRYID)) { cMConsultantAddressInfoEntity.CountryID = null; } else { cMConsultantAddressInfoEntity.CountryID = reader.GetInt64(FLD_COUNTRYID); }
            if (reader.IsDBNull(FLD_CITYID)) { cMConsultantAddressInfoEntity.CityID = null; } else { cMConsultantAddressInfoEntity.CityID = reader.GetInt64(FLD_CITYID); }
            cMConsultantAddressInfoEntity.AddressLine1 = reader.GetString(FLD_ADDRESSLINE1);
            if (reader.IsDBNull(FLD_ADDRESSLINE2)) { cMConsultantAddressInfoEntity.AddressLine2 = String.Empty; } else { cMConsultantAddressInfoEntity.AddressLine2 = reader.GetString(FLD_ADDRESSLINE2); }
            if (reader.IsDBNull(FLD_FAX)) { cMConsultantAddressInfoEntity.Fax = String.Empty; } else { cMConsultantAddressInfoEntity.Fax = reader.GetString(FLD_FAX); }
            if (reader.IsDBNull(FLD_ZIPCODE)) { cMConsultantAddressInfoEntity.ZipCode = String.Empty; } else { cMConsultantAddressInfoEntity.ZipCode = reader.GetString(FLD_ZIPCODE); }

            return cMConsultantAddressInfoEntity;
        }
    }
}
