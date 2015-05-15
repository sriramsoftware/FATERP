// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-Oct-2012, 11:18:25




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMAbstractMeasurementBook_CustomBuilder : IEntityBuilder<CMAbstractMeasurementBook_CustomEntity>
    {
        IList<CMAbstractMeasurementBook_CustomEntity> IEntityBuilder<CMAbstractMeasurementBook_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<CMAbstractMeasurementBook_CustomEntity> CMAbstractMeasurementBook_CustomEntityList = new List<CMAbstractMeasurementBook_CustomEntity>();

            while (reader.Read())
            {
                CMAbstractMeasurementBook_CustomEntityList.Add(((IEntityBuilder<CMAbstractMeasurementBook_CustomEntity>)this).BuildEntity(reader));
            }

            return (CMAbstractMeasurementBook_CustomEntityList.Count > 0) ? CMAbstractMeasurementBook_CustomEntityList : null;
        }

        CMAbstractMeasurementBook_CustomEntity IEntityBuilder<CMAbstractMeasurementBook_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ITEMID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_PROJECTNAME = 2;
            const Int32 FLD_ITEMNAME = 3;
            const Int32 FLD_UNITNAME = 4;
            const Int32 FLD_TOTALQTY = 5;

            CMAbstractMeasurementBook_CustomEntity cMAbstractMeasurementBook_CustomEntity = new CMAbstractMeasurementBook_CustomEntity();

            cMAbstractMeasurementBook_CustomEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            cMAbstractMeasurementBook_CustomEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            cMAbstractMeasurementBook_CustomEntity.ProjectName = reader.GetString(FLD_PROJECTNAME);
            cMAbstractMeasurementBook_CustomEntity.ItemName = reader.GetString(FLD_ITEMNAME);
            if (reader.IsDBNull(FLD_UNITNAME)) { cMAbstractMeasurementBook_CustomEntity.UnitName = String.Empty; } else { cMAbstractMeasurementBook_CustomEntity.UnitName = reader.GetString(FLD_UNITNAME); }
            if (reader.IsDBNull(FLD_TOTALQTY)) { cMAbstractMeasurementBook_CustomEntity.TotalQty = null; } else { cMAbstractMeasurementBook_CustomEntity.TotalQty = reader.GetDecimal(FLD_TOTALQTY); }

            return cMAbstractMeasurementBook_CustomEntity;
        }
    }
}
