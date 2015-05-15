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
    internal sealed class CRMMDAgreementTypeBuilder : IEntityBuilder<CRMMDAgreementTypeEntity>
    {
        IList<CRMMDAgreementTypeEntity> IEntityBuilder<CRMMDAgreementTypeEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMMDAgreementTypeEntity> CRMMDAgreementTypeEntityList = new List<CRMMDAgreementTypeEntity>();

            while (reader.Read())
            {
                CRMMDAgreementTypeEntityList.Add(((IEntityBuilder<CRMMDAgreementTypeEntity>)this).BuildEntity(reader));
            }

            return (CRMMDAgreementTypeEntityList.Count > 0) ? CRMMDAgreementTypeEntityList : null;
        }

        CRMMDAgreementTypeEntity IEntityBuilder<CRMMDAgreementTypeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_AGREEMENTTYPEID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            CRMMDAgreementTypeEntity cRMMDAgreementTypeEntity = new CRMMDAgreementTypeEntity();

            cRMMDAgreementTypeEntity.AgreementTypeID = reader.GetInt64(FLD_AGREEMENTTYPEID);
            cRMMDAgreementTypeEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { cRMMDAgreementTypeEntity.Description = String.Empty; } else { cRMMDAgreementTypeEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            cRMMDAgreementTypeEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return cRMMDAgreementTypeEntity;
        }
    }
}
