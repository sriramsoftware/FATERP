// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-Aug-2013, 11:09:08




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMMeasurementBookDetailBuilder : IEntityBuilder<CMMeasurementBookDetailEntity>
    {
        IList<CMMeasurementBookDetailEntity> IEntityBuilder<CMMeasurementBookDetailEntity>.BuildEntities(IDataReader reader)
        {
            List<CMMeasurementBookDetailEntity> CMMeasurementBookDetailEntityList = new List<CMMeasurementBookDetailEntity>();

            while (reader.Read())
            {
                CMMeasurementBookDetailEntityList.Add(((IEntityBuilder<CMMeasurementBookDetailEntity>)this).BuildEntity(reader));
            }

            return (CMMeasurementBookDetailEntityList.Count > 0) ? CMMeasurementBookDetailEntityList : null;
        }

        CMMeasurementBookDetailEntity IEntityBuilder<CMMeasurementBookDetailEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_PRICE = 12;

            CMMeasurementBookDetailEntity cMMeasurementBookDetailEntity = new CMMeasurementBookDetailEntity();

            cMMeasurementBookDetailEntity.MeasurementBookDetailID = reader.GetInt64(FLD_MEASUREMENTBOOKDETAILID);
            if (reader.IsDBNull(FLD_MEASUREMENTBOOKID)) { cMMeasurementBookDetailEntity.MeasurementBookID = null; } else { cMMeasurementBookDetailEntity.MeasurementBookID = reader.GetInt64(FLD_MEASUREMENTBOOKID); }
            cMMeasurementBookDetailEntity.Description = reader.GetString(FLD_DESCRIPTION);
            cMMeasurementBookDetailEntity.UnitID = reader.GetInt64(FLD_UNITID);
            if (reader.IsDBNull(FLD_LENGTHFT)) { cMMeasurementBookDetailEntity.Lengthft = null; } else { cMMeasurementBookDetailEntity.Lengthft = reader.GetDecimal(FLD_LENGTHFT); }
            if (reader.IsDBNull(FLD_LENGHTIN)) { cMMeasurementBookDetailEntity.Lenghtin = null; } else { cMMeasurementBookDetailEntity.Lenghtin = reader.GetDecimal(FLD_LENGHTIN); }
            if (reader.IsDBNull(FLD_WIDTHFT)) { cMMeasurementBookDetailEntity.Widthft = null; } else { cMMeasurementBookDetailEntity.Widthft = reader.GetDecimal(FLD_WIDTHFT); }
            if (reader.IsDBNull(FLD_WIDTHIN)) { cMMeasurementBookDetailEntity.Widthin = null; } else { cMMeasurementBookDetailEntity.Widthin = reader.GetDecimal(FLD_WIDTHIN); }
            if (reader.IsDBNull(FLD_HEIGHTFT)) { cMMeasurementBookDetailEntity.Heightft = null; } else { cMMeasurementBookDetailEntity.Heightft = reader.GetDecimal(FLD_HEIGHTFT); }
            if (reader.IsDBNull(FLD_HEIGHTIN)) { cMMeasurementBookDetailEntity.Heightin = null; } else { cMMeasurementBookDetailEntity.Heightin = reader.GetDecimal(FLD_HEIGHTIN); }
            cMMeasurementBookDetailEntity.Nos = reader.GetDecimal(FLD_NOS);
            cMMeasurementBookDetailEntity.Qty = reader.GetDecimal(FLD_QTY);
            cMMeasurementBookDetailEntity.Price = reader.GetDecimal(FLD_PRICE);

            return cMMeasurementBookDetailEntity;
        }
    }
}
