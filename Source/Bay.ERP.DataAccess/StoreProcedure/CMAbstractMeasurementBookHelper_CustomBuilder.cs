// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Oct-2012, 04:30:09




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMAbstractMeasurementBookHelper_CustomBuilder : IEntityBuilder<CMAbstractMeasurementBookHelper_CustomEntity>
    {
        IList<CMAbstractMeasurementBookHelper_CustomEntity> IEntityBuilder<CMAbstractMeasurementBookHelper_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<CMAbstractMeasurementBookHelper_CustomEntity> CMAbstractMeasurementBookHelper_CustomEntityList = new List<CMAbstractMeasurementBookHelper_CustomEntity>();

            while (reader.Read())
            {
                CMAbstractMeasurementBookHelper_CustomEntityList.Add(((IEntityBuilder<CMAbstractMeasurementBookHelper_CustomEntity>)this).BuildEntity(reader));
            }

            return (CMAbstractMeasurementBookHelper_CustomEntityList.Count > 0) ? CMAbstractMeasurementBookHelper_CustomEntityList : null;
        }

        CMAbstractMeasurementBookHelper_CustomEntity IEntityBuilder<CMAbstractMeasurementBookHelper_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTID = 0;
            const Int32 FLD_PRESENTQTY = 1;
            const Int32 FLD_ITEMID = 2;
            const Int32 FLD_MEASUREMENTBOOKID = 3;

            CMAbstractMeasurementBookHelper_CustomEntity cMAbstractMeasurementBookHelper_CustomEntity = new CMAbstractMeasurementBookHelper_CustomEntity();

            cMAbstractMeasurementBookHelper_CustomEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            if (reader.IsDBNull(FLD_PRESENTQTY)) { cMAbstractMeasurementBookHelper_CustomEntity.PresentQty = null; } else { cMAbstractMeasurementBookHelper_CustomEntity.PresentQty = reader.GetDecimal(FLD_PRESENTQTY); }
            cMAbstractMeasurementBookHelper_CustomEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            cMAbstractMeasurementBookHelper_CustomEntity.MeasurementBookID = reader.GetInt64(FLD_MEASUREMENTBOOKID);

            return cMAbstractMeasurementBookHelper_CustomEntity;
        }
    }
}
