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
    internal sealed class CMContractorLicenceBuilder : IEntityBuilder<CMContractorLicenceEntity>
    {
        IList<CMContractorLicenceEntity> IEntityBuilder<CMContractorLicenceEntity>.BuildEntities(IDataReader reader)
        {
            List<CMContractorLicenceEntity> CMContractorLicenceEntityList = new List<CMContractorLicenceEntity>();

            while (reader.Read())
            {
                CMContractorLicenceEntityList.Add(((IEntityBuilder<CMContractorLicenceEntity>)this).BuildEntity(reader));
            }

            return (CMContractorLicenceEntityList.Count > 0) ? CMContractorLicenceEntityList : null;
        }

        CMContractorLicenceEntity IEntityBuilder<CMContractorLicenceEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CONTRACTORLICENCEID = 0;
            const Int32 FLD_CONTRACTORID = 1;
            const Int32 FLD_LICENCENO = 2;

            CMContractorLicenceEntity cMContractorLicenceEntity = new CMContractorLicenceEntity();

            cMContractorLicenceEntity.ContractorLicenceID = reader.GetInt64(FLD_CONTRACTORLICENCEID);
            cMContractorLicenceEntity.ContractorID = reader.GetInt64(FLD_CONTRACTORID);
            cMContractorLicenceEntity.LicenceNo = reader.GetString(FLD_LICENCENO);

            return cMContractorLicenceEntity;
        }
    }
}
