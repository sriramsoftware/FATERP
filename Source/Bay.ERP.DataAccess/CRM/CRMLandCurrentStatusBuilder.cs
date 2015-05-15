// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 01-Apr-2013, 02:41:21




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMLandCurrentStatusBuilder : IEntityBuilder<CRMLandCurrentStatusEntity>
    {
        IList<CRMLandCurrentStatusEntity> IEntityBuilder<CRMLandCurrentStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMLandCurrentStatusEntity> CRMLandCurrentStatusEntityList = new List<CRMLandCurrentStatusEntity>();

            while (reader.Read())
            {
                CRMLandCurrentStatusEntityList.Add(((IEntityBuilder<CRMLandCurrentStatusEntity>)this).BuildEntity(reader));
            }

            return (CRMLandCurrentStatusEntityList.Count > 0) ? CRMLandCurrentStatusEntityList : null;
        }

        CRMLandCurrentStatusEntity IEntityBuilder<CRMLandCurrentStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_LANDCURRENTSTATUSID = 0;
            const Int32 FLD_LANDBASICINFOID = 1;
            const Int32 FLD_OWNERSHIP = 2;
            const Int32 FLD_MUTATION = 3;
            const Int32 FLD_CURRENTUSAGE = 4;
            const Int32 FLD_COMMERCIALPERMIT = 5;
            const Int32 FLD_TENANT = 6;
            const Int32 FLD_LOANLIABILITY = 7;
            const Int32 FLD_NOC = 8;
            const Int32 FLD_AGREEMENTS = 9;
            const Int32 FLD_LITIGATION = 10;

            CRMLandCurrentStatusEntity cRMLandCurrentStatusEntity = new CRMLandCurrentStatusEntity();

            cRMLandCurrentStatusEntity.LandCurrentStatusID = reader.GetInt64(FLD_LANDCURRENTSTATUSID);
            cRMLandCurrentStatusEntity.LandBasicInfoID = reader.GetInt64(FLD_LANDBASICINFOID);
            cRMLandCurrentStatusEntity.Ownership = reader.GetString(FLD_OWNERSHIP);
            if (reader.IsDBNull(FLD_MUTATION)) { cRMLandCurrentStatusEntity.Mutation = String.Empty; } else { cRMLandCurrentStatusEntity.Mutation = reader.GetString(FLD_MUTATION); }
            if (reader.IsDBNull(FLD_CURRENTUSAGE)) { cRMLandCurrentStatusEntity.CurrentUsage = String.Empty; } else { cRMLandCurrentStatusEntity.CurrentUsage = reader.GetString(FLD_CURRENTUSAGE); }
            if (reader.IsDBNull(FLD_COMMERCIALPERMIT)) { cRMLandCurrentStatusEntity.CommercialPermit = String.Empty; } else { cRMLandCurrentStatusEntity.CommercialPermit = reader.GetString(FLD_COMMERCIALPERMIT); }
            if (reader.IsDBNull(FLD_TENANT)) { cRMLandCurrentStatusEntity.Tenant = String.Empty; } else { cRMLandCurrentStatusEntity.Tenant = reader.GetString(FLD_TENANT); }
            if (reader.IsDBNull(FLD_LOANLIABILITY)) { cRMLandCurrentStatusEntity.LoanLiability = String.Empty; } else { cRMLandCurrentStatusEntity.LoanLiability = reader.GetString(FLD_LOANLIABILITY); }
            if (reader.IsDBNull(FLD_NOC)) { cRMLandCurrentStatusEntity.NOC = String.Empty; } else { cRMLandCurrentStatusEntity.NOC = reader.GetString(FLD_NOC); }
            if (reader.IsDBNull(FLD_AGREEMENTS)) { cRMLandCurrentStatusEntity.Agreements = String.Empty; } else { cRMLandCurrentStatusEntity.Agreements = reader.GetString(FLD_AGREEMENTS); }
            if (reader.IsDBNull(FLD_LITIGATION)) { cRMLandCurrentStatusEntity.Litigation = String.Empty; } else { cRMLandCurrentStatusEntity.Litigation = reader.GetString(FLD_LITIGATION); }

            return cRMLandCurrentStatusEntity;
        }
    }
}
