// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Feb-2013, 03:00:14




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMCustomerBuilder : IEntityBuilder<CRMCustomerEntity>
    {
        IList<CRMCustomerEntity> IEntityBuilder<CRMCustomerEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMCustomerEntity> CRMCustomerEntityList = new List<CRMCustomerEntity>();

            while (reader.Read())
            {
                CRMCustomerEntityList.Add(((IEntityBuilder<CRMCustomerEntity>)this).BuildEntity(reader));
            }

            return (CRMCustomerEntityList.Count > 0) ? CRMCustomerEntityList : null;
        }

        CRMCustomerEntity IEntityBuilder<CRMCustomerEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CUSTOMERID = 0;
            const Int32 FLD_FIRSTNAME = 1;
            const Int32 FLD_MIDDLENAME = 2;
            const Int32 FLD_LASTNAME = 3;
            const Int32 FLD_PRIMARYEMAIL = 4;
            const Int32 FLD_SECONDARYEMAIL = 5;
            const Int32 FLD_PHONE = 6;
            const Int32 FLD_FAX = 7;

            CRMCustomerEntity cRMCustomerEntity = new CRMCustomerEntity();

            cRMCustomerEntity.CustomerID = reader.GetInt64(FLD_CUSTOMERID);
            cRMCustomerEntity.FirstName = reader.GetString(FLD_FIRSTNAME);
            if (reader.IsDBNull(FLD_MIDDLENAME)) { cRMCustomerEntity.MiddleName = String.Empty; } else { cRMCustomerEntity.MiddleName = reader.GetString(FLD_MIDDLENAME); }
            cRMCustomerEntity.LastName = reader.GetString(FLD_LASTNAME);
            cRMCustomerEntity.PrimaryEmail = reader.GetString(FLD_PRIMARYEMAIL);
            if (reader.IsDBNull(FLD_SECONDARYEMAIL)) { cRMCustomerEntity.SecondaryEmail = String.Empty; } else { cRMCustomerEntity.SecondaryEmail = reader.GetString(FLD_SECONDARYEMAIL); }
            if (reader.IsDBNull(FLD_PHONE)) { cRMCustomerEntity.Phone = String.Empty; } else { cRMCustomerEntity.Phone = reader.GetString(FLD_PHONE); }
            if (reader.IsDBNull(FLD_FAX)) { cRMCustomerEntity.Fax = String.Empty; } else { cRMCustomerEntity.Fax = reader.GetString(FLD_FAX); }

            return cRMCustomerEntity;
        }
    }
}
