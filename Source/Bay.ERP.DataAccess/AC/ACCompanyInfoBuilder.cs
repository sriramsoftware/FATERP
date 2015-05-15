// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Jan-2013, 12:49:20




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACCompanyInfoBuilder : IEntityBuilder<ACCompanyInfoEntity>
    {
        IList<ACCompanyInfoEntity> IEntityBuilder<ACCompanyInfoEntity>.BuildEntities(IDataReader reader)
        {
            List<ACCompanyInfoEntity> ACCompanyInfoEntityList = new List<ACCompanyInfoEntity>();

            while (reader.Read())
            {
                ACCompanyInfoEntityList.Add(((IEntityBuilder<ACCompanyInfoEntity>)this).BuildEntity(reader));
            }

            return (ACCompanyInfoEntityList.Count > 0) ? ACCompanyInfoEntityList : null;
        }

        ACCompanyInfoEntity IEntityBuilder<ACCompanyInfoEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_COMPANYINFOID = 0;
            const Int32 FLD_COMPANYNAME = 1;
            const Int32 FLD_ADDRESSLINE1 = 2;
            const Int32 FLD_ADDRESSLINE2 = 3;
            const Int32 FLD_PHONENUMBER = 4;
            const Int32 FLD_EMAIL = 5;
            const Int32 FLD_OFFICIALCOMPANYNUMBER = 6;
            const Int32 FLD_HOMECURRENCYID = 7;
            const Int32 FLD_FISCALYEARID = 8;

            ACCompanyInfoEntity aCCompanyInfoEntity = new ACCompanyInfoEntity();

            aCCompanyInfoEntity.CompanyInfoID = reader.GetInt64(FLD_COMPANYINFOID);
            aCCompanyInfoEntity.CompanyName = reader.GetString(FLD_COMPANYNAME);
            aCCompanyInfoEntity.AddressLine1 = reader.GetString(FLD_ADDRESSLINE1);
            if (reader.IsDBNull(FLD_ADDRESSLINE2)) { aCCompanyInfoEntity.AddressLine2 = String.Empty; } else { aCCompanyInfoEntity.AddressLine2 = reader.GetString(FLD_ADDRESSLINE2); }
            aCCompanyInfoEntity.PhoneNumber = reader.GetString(FLD_PHONENUMBER);
            if (reader.IsDBNull(FLD_EMAIL)) { aCCompanyInfoEntity.Email = String.Empty; } else { aCCompanyInfoEntity.Email = reader.GetString(FLD_EMAIL); }
            if (reader.IsDBNull(FLD_OFFICIALCOMPANYNUMBER)) { aCCompanyInfoEntity.OfficialCompanyNumber = String.Empty; } else { aCCompanyInfoEntity.OfficialCompanyNumber = reader.GetString(FLD_OFFICIALCOMPANYNUMBER); }
            aCCompanyInfoEntity.HomeCurrencyID = reader.GetInt64(FLD_HOMECURRENCYID);
            aCCompanyInfoEntity.FiscalYearID = reader.GetInt64(FLD_FISCALYEARID);

            return aCCompanyInfoEntity;
        }
    }
}
