// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Feb-2013, 04:16:42




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMBillMaterialReceiveMeasurementBookMapBuilder : IEntityBuilder<CMBillMaterialReceiveMeasurementBookMapEntity>
    {
        IList<CMBillMaterialReceiveMeasurementBookMapEntity> IEntityBuilder<CMBillMaterialReceiveMeasurementBookMapEntity>.BuildEntities(IDataReader reader)
        {
            List<CMBillMaterialReceiveMeasurementBookMapEntity> CMBillMaterialReceiveMeasurementBookMapEntityList = new List<CMBillMaterialReceiveMeasurementBookMapEntity>();

            while (reader.Read())
            {
                CMBillMaterialReceiveMeasurementBookMapEntityList.Add(((IEntityBuilder<CMBillMaterialReceiveMeasurementBookMapEntity>)this).BuildEntity(reader));
            }

            return (CMBillMaterialReceiveMeasurementBookMapEntityList.Count > 0) ? CMBillMaterialReceiveMeasurementBookMapEntityList : null;
        }

        CMBillMaterialReceiveMeasurementBookMapEntity IEntityBuilder<CMBillMaterialReceiveMeasurementBookMapEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BILLMATERIALRECEIVEMEASUREMENTBOOKMAPID = 0;
            const Int32 FLD_BILLID = 1;
            const Int32 FLD_MATERIALRECEIVEID = 2;
            const Int32 FLD_MATERIALRECEIVEITEMMAPID = 3;
            const Int32 FLD_MEASUREMENTBOOKID = 4;
            const Int32 FLD_MEASUREMENTBOOKDETAILID = 5;
            const Int32 FLD_BILLPRICE = 6;

            CMBillMaterialReceiveMeasurementBookMapEntity cMBillMaterialReceiveMeasurementBookMapEntity = new CMBillMaterialReceiveMeasurementBookMapEntity();

            cMBillMaterialReceiveMeasurementBookMapEntity.BillMaterialReceiveMeasurementBookMapID = reader.GetInt64(FLD_BILLMATERIALRECEIVEMEASUREMENTBOOKMAPID);
            cMBillMaterialReceiveMeasurementBookMapEntity.BillID = reader.GetInt64(FLD_BILLID);
            if (reader.IsDBNull(FLD_MATERIALRECEIVEID)) { cMBillMaterialReceiveMeasurementBookMapEntity.MaterialReceiveID = null; } else { cMBillMaterialReceiveMeasurementBookMapEntity.MaterialReceiveID = reader.GetInt64(FLD_MATERIALRECEIVEID); }
            if (reader.IsDBNull(FLD_MATERIALRECEIVEITEMMAPID)) { cMBillMaterialReceiveMeasurementBookMapEntity.MaterialReceiveItemMapID = null; } else { cMBillMaterialReceiveMeasurementBookMapEntity.MaterialReceiveItemMapID = reader.GetInt64(FLD_MATERIALRECEIVEITEMMAPID); }
            if (reader.IsDBNull(FLD_MEASUREMENTBOOKID)) { cMBillMaterialReceiveMeasurementBookMapEntity.MeasurementBookID = null; } else { cMBillMaterialReceiveMeasurementBookMapEntity.MeasurementBookID = reader.GetInt64(FLD_MEASUREMENTBOOKID); }
            if (reader.IsDBNull(FLD_MEASUREMENTBOOKDETAILID)) { cMBillMaterialReceiveMeasurementBookMapEntity.MeasurementBookDetailID = null; } else { cMBillMaterialReceiveMeasurementBookMapEntity.MeasurementBookDetailID = reader.GetInt64(FLD_MEASUREMENTBOOKDETAILID); }
            cMBillMaterialReceiveMeasurementBookMapEntity.BillPrice = reader.GetDecimal(FLD_BILLPRICE);

            return cMBillMaterialReceiveMeasurementBookMapEntity;
        }
    }
}
