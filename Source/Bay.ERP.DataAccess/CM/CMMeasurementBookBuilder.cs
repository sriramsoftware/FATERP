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
    internal sealed class CMMeasurementBookBuilder : IEntityBuilder<CMMeasurementBookEntity>
    {
        IList<CMMeasurementBookEntity> IEntityBuilder<CMMeasurementBookEntity>.BuildEntities(IDataReader reader)
        {
            List<CMMeasurementBookEntity> CMMeasurementBookEntityList = new List<CMMeasurementBookEntity>();

            while (reader.Read())
            {
                CMMeasurementBookEntityList.Add(((IEntityBuilder<CMMeasurementBookEntity>)this).BuildEntity(reader));
            }

            return (CMMeasurementBookEntityList.Count > 0) ? CMMeasurementBookEntityList : null;
        }

        CMMeasurementBookEntity IEntityBuilder<CMMeasurementBookEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_MEASUREMENTBOOKID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_PROJECTCODE = 2;
            const Int32 FLD_VENDORCATEGORYID = 3;
            const Int32 FLD_REFERENCEID = 4;
            const Int32 FLD_BILLID = 5;
            const Int32 FLD_WORKORDERID = 6;
            const Int32 FLD_ITEMID = 7;
            const Int32 FLD_CREATEDATE = 8;
            const Int32 FLD_PROJECTFLOORID = 9;
            const Int32 FLD_PROJECTFLOORUNITID = 10;

            CMMeasurementBookEntity cMMeasurementBookEntity = new CMMeasurementBookEntity();

            cMMeasurementBookEntity.MeasurementBookID = reader.GetInt64(FLD_MEASUREMENTBOOKID);
            cMMeasurementBookEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            cMMeasurementBookEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE);
            cMMeasurementBookEntity.VendorCategoryID = reader.GetInt64(FLD_VENDORCATEGORYID);
            cMMeasurementBookEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID);
            if (reader.IsDBNull(FLD_BILLID)) { cMMeasurementBookEntity.BillID = null; } else { cMMeasurementBookEntity.BillID = reader.GetInt64(FLD_BILLID); }
            if (reader.IsDBNull(FLD_WORKORDERID)) { cMMeasurementBookEntity.WorkOrderID = null; } else { cMMeasurementBookEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID); }
            cMMeasurementBookEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            cMMeasurementBookEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            if (reader.IsDBNull(FLD_PROJECTFLOORID)) { cMMeasurementBookEntity.ProjectFloorID = null; } else { cMMeasurementBookEntity.ProjectFloorID = reader.GetInt64(FLD_PROJECTFLOORID); }
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITID)) { cMMeasurementBookEntity.ProjectFloorUnitID = null; } else { cMMeasurementBookEntity.ProjectFloorUnitID = reader.GetInt64(FLD_PROJECTFLOORUNITID); }

            return cMMeasurementBookEntity;
        }
    }
}
