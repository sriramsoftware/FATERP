// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREmployeePassportInformationBuilder : IEntityBuilder<HREmployeePassportInformationEntity>
    {
        IList<HREmployeePassportInformationEntity> IEntityBuilder<HREmployeePassportInformationEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeePassportInformationEntity> HREmployeePassportInformationEntityList = new List<HREmployeePassportInformationEntity>();

            while (reader.Read())
            {
                HREmployeePassportInformationEntityList.Add(((IEntityBuilder<HREmployeePassportInformationEntity>)this).BuildEntity(reader));
            }

            return (HREmployeePassportInformationEntityList.Count > 0) ? HREmployeePassportInformationEntityList : null;
        }

        HREmployeePassportInformationEntity IEntityBuilder<HREmployeePassportInformationEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEEPASSPORTINFORMATIONID = 0;
            const Int32 FLD_EMPLOYEEID = 1;
            const Int32 FLD_PASSPORTCOUNTRY = 2;
            const Int32 FLD_CITYNAME = 3;
            const Int32 FLD_PASSPORTNUMBER = 4;
            const Int32 FLD_ISSUEDDATE = 5;
            const Int32 FLD_EXPIREDATE = 6;
            const Int32 FLD_PASSPORTPROFESSION = 7;
            const Int32 FLD_NOTE = 8;

            HREmployeePassportInformationEntity hREmployeePassportInformationEntity = new HREmployeePassportInformationEntity();

            hREmployeePassportInformationEntity.EmployeePassportInformationID = reader.GetInt64(FLD_EMPLOYEEPASSPORTINFORMATIONID);
            hREmployeePassportInformationEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeePassportInformationEntity.PassportCountry = reader.GetInt64(FLD_PASSPORTCOUNTRY);
            if (reader.IsDBNull(FLD_CITYNAME)) { hREmployeePassportInformationEntity.CityName = String.Empty; } else { hREmployeePassportInformationEntity.CityName = reader.GetString(FLD_CITYNAME); }
            hREmployeePassportInformationEntity.PassportNumber = reader.GetString(FLD_PASSPORTNUMBER);
            hREmployeePassportInformationEntity.IssuedDate = reader.GetDateTime(FLD_ISSUEDDATE);
            hREmployeePassportInformationEntity.ExpireDate = reader.GetDateTime(FLD_EXPIREDATE);
            if (reader.IsDBNull(FLD_PASSPORTPROFESSION)) { hREmployeePassportInformationEntity.PassportProfession = String.Empty; } else { hREmployeePassportInformationEntity.PassportProfession = reader.GetString(FLD_PASSPORTPROFESSION); }
            if (reader.IsDBNull(FLD_NOTE)) { hREmployeePassportInformationEntity.Note = String.Empty; } else { hREmployeePassportInformationEntity.Note = reader.GetString(FLD_NOTE); }

            return hREmployeePassportInformationEntity;
        }
    }
}
