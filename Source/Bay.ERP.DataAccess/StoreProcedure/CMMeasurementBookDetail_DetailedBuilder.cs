// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Oct-2012, 03:40:52




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMMeasurementBookDetail_DetailedBuilder : IEntityBuilder<CMMeasurementBookDetail_DetailedEntity>
    {
        IList<CMMeasurementBookDetail_DetailedEntity> IEntityBuilder<CMMeasurementBookDetail_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<CMMeasurementBookDetail_DetailedEntity> CMMeasurementBookDetail_DetailedEntityList = new List<CMMeasurementBookDetail_DetailedEntity>();

            while (reader.Read())
            {
                CMMeasurementBookDetail_DetailedEntityList.Add(((IEntityBuilder<CMMeasurementBookDetail_DetailedEntity>)this).BuildEntity(reader));
            }

            return (CMMeasurementBookDetail_DetailedEntityList.Count > 0) ? CMMeasurementBookDetail_DetailedEntityList : null;
        }

        CMMeasurementBookDetail_DetailedEntity IEntityBuilder<CMMeasurementBookDetail_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_MEASUREMENTBOOKDETAILID = 0;
            const Int32 FLD_MEASUREMENTBOOKID = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_UNITID = 3;
            const Int32 FLD_LENGTHFT = 4;
            const Int32 FLD_LENGHTIN = 5;
            const Int32 FLD_WIDTHFT = 6;
            const Int32 FLD_WIDTHIN = 7;
            const Int32 FLD_HEIGHTFT = 8;
            const Int32 FLD_HEIGHTIN = 9;
            const Int32 FLD_NOS = 10;
            const Int32 FLD_QTY = 11;
            const Int32 FLD_CMMEASUREMENTBOOKPROJECTID = 12;
            const Int32 FLD_UNITNAME = 13;
            const Int32 FLD_ROWNUMBER = 14;

            CMMeasurementBookDetail_DetailedEntity cMMeasurementBookDetail_DetailedEntity = new CMMeasurementBookDetail_DetailedEntity();

            cMMeasurementBookDetail_DetailedEntity.MeasurementBookDetailID = reader.GetInt64(FLD_MEASUREMENTBOOKDETAILID);
            if (reader.IsDBNull(FLD_MEASUREMENTBOOKID)) { cMMeasurementBookDetail_DetailedEntity.MeasurementBookID = null; } else { cMMeasurementBookDetail_DetailedEntity.MeasurementBookID = reader.GetInt64(FLD_MEASUREMENTBOOKID); }
            cMMeasurementBookDetail_DetailedEntity.Description = reader.GetString(FLD_DESCRIPTION);
            cMMeasurementBookDetail_DetailedEntity.UnitID = reader.GetInt64(FLD_UNITID);
            if (reader.IsDBNull(FLD_LENGTHFT)) { cMMeasurementBookDetail_DetailedEntity.Lengthft = null; } else { cMMeasurementBookDetail_DetailedEntity.Lengthft = reader.GetDecimal(FLD_LENGTHFT); }
            if (reader.IsDBNull(FLD_LENGHTIN)) { cMMeasurementBookDetail_DetailedEntity.Lenghtin = null; } else { cMMeasurementBookDetail_DetailedEntity.Lenghtin = reader.GetDecimal(FLD_LENGHTIN); }
            if (reader.IsDBNull(FLD_WIDTHFT)) { cMMeasurementBookDetail_DetailedEntity.Widthft = null; } else { cMMeasurementBookDetail_DetailedEntity.Widthft = reader.GetDecimal(FLD_WIDTHFT); }
            if (reader.IsDBNull(FLD_WIDTHIN)) { cMMeasurementBookDetail_DetailedEntity.Widthin = null; } else { cMMeasurementBookDetail_DetailedEntity.Widthin = reader.GetDecimal(FLD_WIDTHIN); }
            if (reader.IsDBNull(FLD_HEIGHTFT)) { cMMeasurementBookDetail_DetailedEntity.Heightft = null; } else { cMMeasurementBookDetail_DetailedEntity.Heightft = reader.GetDecimal(FLD_HEIGHTFT); }
            if (reader.IsDBNull(FLD_HEIGHTIN)) { cMMeasurementBookDetail_DetailedEntity.Heightin = null; } else { cMMeasurementBookDetail_DetailedEntity.Heightin = reader.GetDecimal(FLD_HEIGHTIN); }
            cMMeasurementBookDetail_DetailedEntity.Nos = reader.GetDecimal(FLD_NOS);
            cMMeasurementBookDetail_DetailedEntity.Qty = reader.GetDecimal(FLD_QTY);
            if (reader.IsDBNull(FLD_CMMEASUREMENTBOOKPROJECTID)) { cMMeasurementBookDetail_DetailedEntity.CMMeasurementBookProjectID = null; } else { cMMeasurementBookDetail_DetailedEntity.CMMeasurementBookProjectID = reader.GetInt64(FLD_CMMEASUREMENTBOOKPROJECTID); }
            if (reader.IsDBNull(FLD_UNITNAME)) { cMMeasurementBookDetail_DetailedEntity.UnitName = String.Empty; } else { cMMeasurementBookDetail_DetailedEntity.UnitName = reader.GetString(FLD_UNITNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { cMMeasurementBookDetail_DetailedEntity.RowNumber = null; } else { cMMeasurementBookDetail_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return cMMeasurementBookDetail_DetailedEntity;
        }
    }
}
