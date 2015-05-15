// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Jan-2013, 03:48:49




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMMeasurementBook_DetailedBuilder : IEntityBuilder<CMMeasurementBook_DetailedEntity>
    {
        IList<CMMeasurementBook_DetailedEntity> IEntityBuilder<CMMeasurementBook_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<CMMeasurementBook_DetailedEntity> CMMeasurementBook_DetailedEntityList = new List<CMMeasurementBook_DetailedEntity>();

            while (reader.Read())
            {
                CMMeasurementBook_DetailedEntityList.Add(((IEntityBuilder<CMMeasurementBook_DetailedEntity>)this).BuildEntity(reader));
            }

            return (CMMeasurementBook_DetailedEntityList.Count > 0) ? CMMeasurementBook_DetailedEntityList : null;
        }

        CMMeasurementBook_DetailedEntity IEntityBuilder<CMMeasurementBook_DetailedEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_PROJECTNAME = 9;
            const Int32 FLD_VENDORCATEGORYNAME = 10;
            const Int32 FLD_BILLNO = 11;
            const Int32 FLD_WORKORDERNO = 12;
            const Int32 FLD_ITEMNAME = 13;
            const Int32 FLD_RESOURCENAME = 14;
            const Int32 FLD_ROWNUMBER = 15;

            CMMeasurementBook_DetailedEntity cMMeasurementBook_DetailedEntity = new CMMeasurementBook_DetailedEntity();

            cMMeasurementBook_DetailedEntity.MeasurementBookID = reader.GetInt64(FLD_MEASUREMENTBOOKID);
            cMMeasurementBook_DetailedEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            cMMeasurementBook_DetailedEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE);
            cMMeasurementBook_DetailedEntity.VendorCategoryID = reader.GetInt64(FLD_VENDORCATEGORYID);
            cMMeasurementBook_DetailedEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID);
            if (reader.IsDBNull(FLD_BILLID)) { cMMeasurementBook_DetailedEntity.BillID = null; } else { cMMeasurementBook_DetailedEntity.BillID = reader.GetInt64(FLD_BILLID); }
            if (reader.IsDBNull(FLD_WORKORDERID)) { cMMeasurementBook_DetailedEntity.WorkOrderID = null; } else { cMMeasurementBook_DetailedEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID); }
            cMMeasurementBook_DetailedEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            cMMeasurementBook_DetailedEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            if (reader.IsDBNull(FLD_PROJECTNAME)) { cMMeasurementBook_DetailedEntity.ProjectName = String.Empty; } else { cMMeasurementBook_DetailedEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            cMMeasurementBook_DetailedEntity.VendorCategoryName = reader.GetString(FLD_VENDORCATEGORYNAME);
            if (reader.IsDBNull(FLD_BILLNO)) { cMMeasurementBook_DetailedEntity.BillNo = String.Empty; } else { cMMeasurementBook_DetailedEntity.BillNo = reader.GetString(FLD_BILLNO); }
            if (reader.IsDBNull(FLD_WORKORDERNO)) { cMMeasurementBook_DetailedEntity.WorkOrderNo = String.Empty; } else { cMMeasurementBook_DetailedEntity.WorkOrderNo = reader.GetString(FLD_WORKORDERNO); }
            if (reader.IsDBNull(FLD_ITEMNAME)) { cMMeasurementBook_DetailedEntity.ItemName = String.Empty; } else { cMMeasurementBook_DetailedEntity.ItemName = reader.GetString(FLD_ITEMNAME); }
            cMMeasurementBook_DetailedEntity.ResourceName = reader.GetString(FLD_RESOURCENAME);
            if (reader.IsDBNull(FLD_ROWNUMBER)) { cMMeasurementBook_DetailedEntity.RowNumber = null; } else { cMMeasurementBook_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return cMMeasurementBook_DetailedEntity;
        }
    }
}
