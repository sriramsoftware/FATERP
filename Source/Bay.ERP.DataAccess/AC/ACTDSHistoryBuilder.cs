// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Mar-2013, 10:30:04




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACTDSHistoryBuilder : IEntityBuilder<ACTDSHistoryEntity>
    {
        IList<ACTDSHistoryEntity> IEntityBuilder<ACTDSHistoryEntity>.BuildEntities(IDataReader reader)
        {
            List<ACTDSHistoryEntity> ACTDSHistoryEntityList = new List<ACTDSHistoryEntity>();

            while (reader.Read())
            {
                ACTDSHistoryEntityList.Add(((IEntityBuilder<ACTDSHistoryEntity>)this).BuildEntity(reader));
            }

            return (ACTDSHistoryEntityList.Count > 0) ? ACTDSHistoryEntityList : null;
        }

        ACTDSHistoryEntity IEntityBuilder<ACTDSHistoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_TDSHISTORYID = 0;
            const Int32 FLD_TDSCATEGORYID = 1;
            const Int32 FLD_STARTVALUE = 2;
            const Int32 FLD_ENDVALUE = 3;
            const Int32 FLD_TAX = 4;
            const Int32 FLD_REMARKS = 5;
            const Int32 FLD_UPDATEDDATE = 6;

            ACTDSHistoryEntity aCTDSHistoryEntity = new ACTDSHistoryEntity();

            aCTDSHistoryEntity.TDSHistoryID = reader.GetInt64(FLD_TDSHISTORYID);
            aCTDSHistoryEntity.TDSCategoryID = reader.GetInt64(FLD_TDSCATEGORYID);
            aCTDSHistoryEntity.StartValue = reader.GetDecimal(FLD_STARTVALUE);
            aCTDSHistoryEntity.EndValue = reader.GetDecimal(FLD_ENDVALUE);
            aCTDSHistoryEntity.Tax = reader.GetDecimal(FLD_TAX);
            if (reader.IsDBNull(FLD_REMARKS)) { aCTDSHistoryEntity.Remarks = String.Empty; } else { aCTDSHistoryEntity.Remarks = reader.GetString(FLD_REMARKS); }
            aCTDSHistoryEntity.UpdatedDate = reader.GetDateTime(FLD_UPDATEDDATE);

            return aCTDSHistoryEntity;
        }
    }
}
