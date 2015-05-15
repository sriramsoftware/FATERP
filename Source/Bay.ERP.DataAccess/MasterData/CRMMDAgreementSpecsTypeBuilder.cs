// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 11-Apr-2013, 01:28:07




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMMDAgreementSpecsTypeBuilder : IEntityBuilder<CRMMDAgreementSpecsTypeEntity>
    {
        IList<CRMMDAgreementSpecsTypeEntity> IEntityBuilder<CRMMDAgreementSpecsTypeEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMMDAgreementSpecsTypeEntity> CRMMDAgreementSpecsTypeEntityList = new List<CRMMDAgreementSpecsTypeEntity>();

            while (reader.Read())
            {
                CRMMDAgreementSpecsTypeEntityList.Add(((IEntityBuilder<CRMMDAgreementSpecsTypeEntity>)this).BuildEntity(reader));
            }

            return (CRMMDAgreementSpecsTypeEntityList.Count > 0) ? CRMMDAgreementSpecsTypeEntityList : null;
        }

        CRMMDAgreementSpecsTypeEntity IEntityBuilder<CRMMDAgreementSpecsTypeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_AGREEMENTSPECSTYPEID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            CRMMDAgreementSpecsTypeEntity cRMMDAgreementSpecsTypeEntity = new CRMMDAgreementSpecsTypeEntity();

            cRMMDAgreementSpecsTypeEntity.AgreementSpecsTypeID = reader.GetInt64(FLD_AGREEMENTSPECSTYPEID);
            cRMMDAgreementSpecsTypeEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { cRMMDAgreementSpecsTypeEntity.Description = String.Empty; } else { cRMMDAgreementSpecsTypeEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            cRMMDAgreementSpecsTypeEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return cRMMDAgreementSpecsTypeEntity;
        }
    }
}
