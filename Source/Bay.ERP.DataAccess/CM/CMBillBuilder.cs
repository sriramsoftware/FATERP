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
    internal sealed class CMBillBuilder : IEntityBuilder<CMBillEntity>
    {
        IList<CMBillEntity> IEntityBuilder<CMBillEntity>.BuildEntities(IDataReader reader)
        {
            List<CMBillEntity> CMBillEntityList = new List<CMBillEntity>();

            while (reader.Read())
            {
                CMBillEntityList.Add(((IEntityBuilder<CMBillEntity>)this).BuildEntity(reader));
            }

            return (CMBillEntityList.Count > 0) ? CMBillEntityList : null;
        }

        CMBillEntity IEntityBuilder<CMBillEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BILLID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_BILLNO = 2;
            const Int32 FLD_VENDORCATEGORY = 3;
            const Int32 FLD_VENDOR = 4;
            const Int32 FLD_WORKORDERID = 5;
            const Int32 FLD_DISCOUNTADDITION = 6;
            const Int32 FLD_VAT = 7;
            const Int32 FLD_TAX = 8;
            const Int32 FLD_CARRYINGCHARGE = 9;
            const Int32 FLD_AMOUNT = 10;
            const Int32 FLD_ADDITIONREMARKS = 11;
            const Int32 FLD_CREATEDATE = 12;
            const Int32 FLD_BILLDATE = 13;
            const Int32 FLD_REMARKS = 14;
            const Int32 FLD_BILLSTATUSID = 15;
            const Int32 FLD_BILLAPPROVALSTATUSID = 16;

            CMBillEntity cMBillEntity = new CMBillEntity();

            cMBillEntity.BillID = reader.GetInt64(FLD_BILLID);
            cMBillEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            cMBillEntity.BillNo = reader.GetString(FLD_BILLNO);
            cMBillEntity.VendorCategory = reader.GetInt64(FLD_VENDORCATEGORY);
            cMBillEntity.Vendor = reader.GetInt64(FLD_VENDOR);
            cMBillEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID);
            if (reader.IsDBNull(FLD_DISCOUNTADDITION)) { cMBillEntity.DiscountAddition = null; } else { cMBillEntity.DiscountAddition = reader.GetDecimal(FLD_DISCOUNTADDITION); }
            if (reader.IsDBNull(FLD_VAT)) { cMBillEntity.Vat = null; } else { cMBillEntity.Vat = reader.GetDecimal(FLD_VAT); }
            if (reader.IsDBNull(FLD_TAX)) { cMBillEntity.Tax = null; } else { cMBillEntity.Tax = reader.GetDecimal(FLD_TAX); }
            if (reader.IsDBNull(FLD_CARRYINGCHARGE)) { cMBillEntity.CarryingCharge = null; } else { cMBillEntity.CarryingCharge = reader.GetDecimal(FLD_CARRYINGCHARGE); }
            cMBillEntity.Amount = reader.GetDecimal(FLD_AMOUNT);
            if (reader.IsDBNull(FLD_ADDITIONREMARKS)) { cMBillEntity.AdditionRemarks = String.Empty; } else { cMBillEntity.AdditionRemarks = reader.GetString(FLD_ADDITIONREMARKS); }
            cMBillEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            cMBillEntity.BillDate = reader.GetDateTime(FLD_BILLDATE);
            if (reader.IsDBNull(FLD_REMARKS)) { cMBillEntity.Remarks = String.Empty; } else { cMBillEntity.Remarks = reader.GetString(FLD_REMARKS); }
            cMBillEntity.BillStatusID = reader.GetInt64(FLD_BILLSTATUSID);
            cMBillEntity.BillApprovalStatusID = reader.GetInt64(FLD_BILLAPPROVALSTATUSID);

            return cMBillEntity;
        }
    }
}
