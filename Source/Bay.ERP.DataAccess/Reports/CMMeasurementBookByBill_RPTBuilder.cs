// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Oct-2012, 01:00:56




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMMeasurementBookByBill_RPTBuilder : IEntityBuilder<CMMeasurementBookByBill_RPTEntity>
    {
        IList<CMMeasurementBookByBill_RPTEntity> IEntityBuilder<CMMeasurementBookByBill_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<CMMeasurementBookByBill_RPTEntity> CMMeasurementBookByBill_RPTEntityList = new List<CMMeasurementBookByBill_RPTEntity>();

            while (reader.Read())
            {
                CMMeasurementBookByBill_RPTEntityList.Add(((IEntityBuilder<CMMeasurementBookByBill_RPTEntity>)this).BuildEntity(reader));
            }

            return (CMMeasurementBookByBill_RPTEntityList.Count > 0) ? CMMeasurementBookByBill_RPTEntityList : null;
        }

        CMMeasurementBookByBill_RPTEntity IEntityBuilder<CMMeasurementBookByBill_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_MEASUREMENTBOOKID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_PROJECTCODE = 2;
            const Int32 FLD_SUPPLIERID = 3;
            const Int32 FLD_BILLID = 4;
            const Int32 FLD_WORKORDERID = 5;
            const Int32 FLD_ITEMID = 6;
            const Int32 FLD_CREATEDATE = 7;
            const Int32 FLD_DESCRIPTION = 8;
            const Int32 FLD_UNITID = 9;
            const Int32 FLD_LENGTHFT = 10;
            const Int32 FLD_LENGHTIN = 11;
            const Int32 FLD_WIDTHFT = 12;
            const Int32 FLD_WIDTHIN = 13;
            const Int32 FLD_HEIGHTFT = 14;
            const Int32 FLD_HEIGHTIN = 15;
            const Int32 FLD_NOS = 16;
            const Int32 FLD_QTY = 17;
            const Int32 FLD_BILLNO = 18;
            const Int32 FLD_UNITNAME = 19;
            const Int32 FLD_ITEMNAME = 20;

            CMMeasurementBookByBill_RPTEntity cMMeasurementBookByBill_RPTEntity = new CMMeasurementBookByBill_RPTEntity();

            cMMeasurementBookByBill_RPTEntity.MeasurementBookID = reader.GetInt64(FLD_MEASUREMENTBOOKID);
            cMMeasurementBookByBill_RPTEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            cMMeasurementBookByBill_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE);
            cMMeasurementBookByBill_RPTEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);
            if (reader.IsDBNull(FLD_BILLID)) { cMMeasurementBookByBill_RPTEntity.BillID = null; } else { cMMeasurementBookByBill_RPTEntity.BillID = reader.GetInt64(FLD_BILLID); }
            if (reader.IsDBNull(FLD_WORKORDERID)) { cMMeasurementBookByBill_RPTEntity.WorkOrderID = null; } else { cMMeasurementBookByBill_RPTEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID); }
            cMMeasurementBookByBill_RPTEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            cMMeasurementBookByBill_RPTEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { cMMeasurementBookByBill_RPTEntity.Description = String.Empty; } else { cMMeasurementBookByBill_RPTEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            if (reader.IsDBNull(FLD_UNITID)) { cMMeasurementBookByBill_RPTEntity.UnitID = null; } else { cMMeasurementBookByBill_RPTEntity.UnitID = reader.GetInt64(FLD_UNITID); }
            if (reader.IsDBNull(FLD_LENGTHFT)) { cMMeasurementBookByBill_RPTEntity.Lengthft = null; } else { cMMeasurementBookByBill_RPTEntity.Lengthft = reader.GetDecimal(FLD_LENGTHFT); }
            if (reader.IsDBNull(FLD_LENGHTIN)) { cMMeasurementBookByBill_RPTEntity.Lenghtin = null; } else { cMMeasurementBookByBill_RPTEntity.Lenghtin = reader.GetDecimal(FLD_LENGHTIN); }
            if (reader.IsDBNull(FLD_WIDTHFT)) { cMMeasurementBookByBill_RPTEntity.Widthft = null; } else { cMMeasurementBookByBill_RPTEntity.Widthft = reader.GetDecimal(FLD_WIDTHFT); }
            if (reader.IsDBNull(FLD_WIDTHIN)) { cMMeasurementBookByBill_RPTEntity.Widthin = null; } else { cMMeasurementBookByBill_RPTEntity.Widthin = reader.GetDecimal(FLD_WIDTHIN); }
            if (reader.IsDBNull(FLD_HEIGHTFT)) { cMMeasurementBookByBill_RPTEntity.Heightft = null; } else { cMMeasurementBookByBill_RPTEntity.Heightft = reader.GetDecimal(FLD_HEIGHTFT); }
            if (reader.IsDBNull(FLD_HEIGHTIN)) { cMMeasurementBookByBill_RPTEntity.Heightin = null; } else { cMMeasurementBookByBill_RPTEntity.Heightin = reader.GetDecimal(FLD_HEIGHTIN); }
            if (reader.IsDBNull(FLD_NOS)) { cMMeasurementBookByBill_RPTEntity.Nos = null; } else { cMMeasurementBookByBill_RPTEntity.Nos = reader.GetDecimal(FLD_NOS); }
            if (reader.IsDBNull(FLD_QTY)) { cMMeasurementBookByBill_RPTEntity.Qty = null; } else { cMMeasurementBookByBill_RPTEntity.Qty = reader.GetDecimal(FLD_QTY); }
            if (reader.IsDBNull(FLD_BILLNO)) { cMMeasurementBookByBill_RPTEntity.BillNo = String.Empty; } else { cMMeasurementBookByBill_RPTEntity.BillNo = reader.GetString(FLD_BILLNO); }
            cMMeasurementBookByBill_RPTEntity.UnitName = reader.GetString(FLD_UNITNAME);
            if (reader.IsDBNull(FLD_ITEMNAME)) { cMMeasurementBookByBill_RPTEntity.ItemName = String.Empty; } else { cMMeasurementBookByBill_RPTEntity.ItemName = reader.GetString(FLD_ITEMNAME); }

            return cMMeasurementBookByBill_RPTEntity;
        }
    }
}
