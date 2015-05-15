// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Jan-2012, 11:52:45




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMContractorContactPersonBuilder : IEntityBuilder<CMContractorContactPersonEntity>
    {
        IList<CMContractorContactPersonEntity> IEntityBuilder<CMContractorContactPersonEntity>.BuildEntities(IDataReader reader)
        {
            List<CMContractorContactPersonEntity> CMContractorContactPersonEntityList = new List<CMContractorContactPersonEntity>();

            while (reader.Read())
            {
                CMContractorContactPersonEntityList.Add(((IEntityBuilder<CMContractorContactPersonEntity>)this).BuildEntity(reader));
            }

            return (CMContractorContactPersonEntityList.Count > 0) ? CMContractorContactPersonEntityList : null;
        }

        CMContractorContactPersonEntity IEntityBuilder<CMContractorContactPersonEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CONTRACTORCONTACTPERSONID = 0;
            const Int32 FLD_CONTRACTORID = 1;
            const Int32 FLD_NAME = 2;
            const Int32 FLD_DESIGNATION = 3;
            const Int32 FLD_PHONE = 4;
            const Int32 FLD_EMAIL = 5;
            const Int32 FLD_ADDRESSLINE1 = 6;
            const Int32 FLD_ADDRESSLINE2 = 7;

            CMContractorContactPersonEntity cMContractorContactPersonEntity = new CMContractorContactPersonEntity();

            cMContractorContactPersonEntity.ContractorContactPersonID = reader.GetInt64(FLD_CONTRACTORCONTACTPERSONID);
            cMContractorContactPersonEntity.ContractorID = reader.GetInt64(FLD_CONTRACTORID);
            cMContractorContactPersonEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESIGNATION)) { cMContractorContactPersonEntity.Designation = String.Empty; } else { cMContractorContactPersonEntity.Designation = reader.GetString(FLD_DESIGNATION); }
            if (reader.IsDBNull(FLD_PHONE)) { cMContractorContactPersonEntity.Phone = String.Empty; } else { cMContractorContactPersonEntity.Phone = reader.GetString(FLD_PHONE); }
            if (reader.IsDBNull(FLD_EMAIL)) { cMContractorContactPersonEntity.Email = String.Empty; } else { cMContractorContactPersonEntity.Email = reader.GetString(FLD_EMAIL); }
            if (reader.IsDBNull(FLD_ADDRESSLINE1)) { cMContractorContactPersonEntity.AddressLine1 = String.Empty; } else { cMContractorContactPersonEntity.AddressLine1 = reader.GetString(FLD_ADDRESSLINE1); }
            if (reader.IsDBNull(FLD_ADDRESSLINE2)) { cMContractorContactPersonEntity.AddressLine2 = String.Empty; } else { cMContractorContactPersonEntity.AddressLine2 = reader.GetString(FLD_ADDRESSLINE2); }

            return cMContractorContactPersonEntity;
        }
    }
}
