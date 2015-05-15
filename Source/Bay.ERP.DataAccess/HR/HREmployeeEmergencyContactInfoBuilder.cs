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
    internal sealed class HREmployeeEmergencyContactInfoBuilder : IEntityBuilder<HREmployeeEmergencyContactInfoEntity>
    {
        IList<HREmployeeEmergencyContactInfoEntity> IEntityBuilder<HREmployeeEmergencyContactInfoEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeEmergencyContactInfoEntity> HREmployeeEmergencyContactInfoEntityList = new List<HREmployeeEmergencyContactInfoEntity>();

            while (reader.Read())
            {
                HREmployeeEmergencyContactInfoEntityList.Add(((IEntityBuilder<HREmployeeEmergencyContactInfoEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeEmergencyContactInfoEntityList.Count > 0) ? HREmployeeEmergencyContactInfoEntityList : null;
        }

        HREmployeeEmergencyContactInfoEntity IEntityBuilder<HREmployeeEmergencyContactInfoEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEEEMERGENCYCONTACTINFOID = 0;
            const Int32 FLD_EMPLOYEEID = 1;
            const Int32 FLD_FIRSTNAME = 2;
            const Int32 FLD_MIDDLENAME = 3;
            const Int32 FLD_LASTNAME = 4;
            const Int32 FLD_HOMEPHONENUMBER = 5;
            const Int32 FLD_MOBILEPHONENUMBER = 6;
            const Int32 FLD_RELATIONSHIP = 7;

            HREmployeeEmergencyContactInfoEntity hREmployeeEmergencyContactInfoEntity = new HREmployeeEmergencyContactInfoEntity();

            hREmployeeEmergencyContactInfoEntity.EmployeeEmergencyContactInfoID = reader.GetInt64(FLD_EMPLOYEEEMERGENCYCONTACTINFOID);
            hREmployeeEmergencyContactInfoEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeEmergencyContactInfoEntity.FirstName = reader.GetString(FLD_FIRSTNAME);
            if (reader.IsDBNull(FLD_MIDDLENAME)) { hREmployeeEmergencyContactInfoEntity.MiddleName = String.Empty; } else { hREmployeeEmergencyContactInfoEntity.MiddleName = reader.GetString(FLD_MIDDLENAME); }
            hREmployeeEmergencyContactInfoEntity.LastName = reader.GetString(FLD_LASTNAME);
            if (reader.IsDBNull(FLD_HOMEPHONENUMBER)) { hREmployeeEmergencyContactInfoEntity.HomePhoneNumber = String.Empty; } else { hREmployeeEmergencyContactInfoEntity.HomePhoneNumber = reader.GetString(FLD_HOMEPHONENUMBER); }
            if (reader.IsDBNull(FLD_MOBILEPHONENUMBER)) { hREmployeeEmergencyContactInfoEntity.MobilePhoneNumber = String.Empty; } else { hREmployeeEmergencyContactInfoEntity.MobilePhoneNumber = reader.GetString(FLD_MOBILEPHONENUMBER); }
            if (reader.IsDBNull(FLD_RELATIONSHIP)) { hREmployeeEmergencyContactInfoEntity.RelationShip = String.Empty; } else { hREmployeeEmergencyContactInfoEntity.RelationShip = reader.GetString(FLD_RELATIONSHIP); }

            return hREmployeeEmergencyContactInfoEntity;
        }
    }
}
