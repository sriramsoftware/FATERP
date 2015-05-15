// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Mar-2013, 09:29:16




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACTDSBuilder : IEntityBuilder<ACTDSEntity>
    {
        IList<ACTDSEntity> IEntityBuilder<ACTDSEntity>.BuildEntities(IDataReader reader)
        {
            List<ACTDSEntity> ACTDSEntityList = new List<ACTDSEntity>();

            while (reader.Read())
            {
                ACTDSEntityList.Add(((IEntityBuilder<ACTDSEntity>)this).BuildEntity(reader));
            }

            return (ACTDSEntityList.Count > 0) ? ACTDSEntityList : null;
        }

        ACTDSEntity IEntityBuilder<ACTDSEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_TDSID = 0;
            const Int32 FLD_TDSCATEGORYID = 1;
            const Int32 FLD_STARTVALUE = 2;
            const Int32 FLD_ENDVALUE = 3;
            const Int32 FLD_TAX = 4;
            const Int32 FLD_REMARKS = 5;

            ACTDSEntity aCTDSEntity = new ACTDSEntity();

            aCTDSEntity.TDSID = reader.GetInt64(FLD_TDSID);
            aCTDSEntity.TDSCategoryID = reader.GetInt64(FLD_TDSCATEGORYID);
            aCTDSEntity.StartValue = reader.GetDecimal(FLD_STARTVALUE);
            aCTDSEntity.EndValue = reader.GetDecimal(FLD_ENDVALUE);
            aCTDSEntity.Tax = reader.GetDecimal(FLD_TAX);
            if (reader.IsDBNull(FLD_REMARKS)) { aCTDSEntity.Remarks = String.Empty; } else { aCTDSEntity.Remarks = reader.GetString(FLD_REMARKS); }

            return aCTDSEntity;
        }
    }
}
