// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Jan-2013, 09:34:03




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACTaxTypeBuilder : IEntityBuilder<ACTaxTypeEntity>
    {
        IList<ACTaxTypeEntity> IEntityBuilder<ACTaxTypeEntity>.BuildEntities(IDataReader reader)
        {
            List<ACTaxTypeEntity> ACTaxTypeEntityList = new List<ACTaxTypeEntity>();

            while (reader.Read())
            {
                ACTaxTypeEntityList.Add(((IEntityBuilder<ACTaxTypeEntity>)this).BuildEntity(reader));
            }

            return (ACTaxTypeEntityList.Count > 0) ? ACTaxTypeEntityList : null;
        }

        ACTaxTypeEntity IEntityBuilder<ACTaxTypeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_TAXTYPEID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_RATE = 2;
            const Int32 FLD_DESCRIPTION = 3;
            const Int32 FLD_ISREMOVED = 4;

            ACTaxTypeEntity aCTaxTypeEntity = new ACTaxTypeEntity();

            aCTaxTypeEntity.TaxTypeID = reader.GetInt64(FLD_TAXTYPEID);
            aCTaxTypeEntity.Name = reader.GetString(FLD_NAME);
            aCTaxTypeEntity.Rate = reader.GetDecimal(FLD_RATE);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { aCTaxTypeEntity.Description = String.Empty; } else { aCTaxTypeEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            aCTaxTypeEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return aCTaxTypeEntity;
        }
    }
}
