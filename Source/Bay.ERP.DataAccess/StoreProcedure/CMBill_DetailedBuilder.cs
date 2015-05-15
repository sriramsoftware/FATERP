// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Nov-2012, 10:26:04




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMBill_DetailedBuilder : IEntityBuilder<CMBill_DetailedEntity>
    {
        IList<CMBill_DetailedEntity> IEntityBuilder<CMBill_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<CMBill_DetailedEntity> CMBill_DetailedEntityList = new List<CMBill_DetailedEntity>();

            while (reader.Read())
            {
                CMBill_DetailedEntityList.Add(((IEntityBuilder<CMBill_DetailedEntity>)this).BuildEntity(reader));
            }

            return (CMBill_DetailedEntityList.Count > 0) ? CMBill_DetailedEntityList : null;
        }

        CMBill_DetailedEntity IEntityBuilder<CMBill_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BILLID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_BILLNO = 2;
            const Int32 FLD_VENDORCATEGORY = 3;
            const Int32 FLD_VENDOR = 4;
            const Int32 FLD_WORKORDERID = 5;
            const Int32 FLD_AMOUNT = 6;
            const Int32 FLD_CREATEDATE = 7;
            const Int32 FLD_BILLDATE = 8;
            const Int32 FLD_REMARKS = 9;
            const Int32 FLD_BILLSTATUSID = 10;
            const Int32 FLD_BILLAPPROVALSTATUSID = 11;
            const Int32 FLD_SUPPLIERCODE = 12;
            const Int32 FLD_SUPPLIERNAME = 13;
            const Int32 FLD_BDPROJECTPROJECTNAME = 14;
            const Int32 FLD_WORKORDERNO = 15;
            const Int32 FLD_MDBILLSTATUSNAME = 16;
            const Int32 FLD_MDBILLAPPROVALSTATUSNAME = 17;
            const Int32 FLD_ROWNUMBER = 18;

            CMBill_DetailedEntity cMBill_DetailedEntity = new CMBill_DetailedEntity();

            cMBill_DetailedEntity.BillID = reader.GetInt64(FLD_BILLID);
            cMBill_DetailedEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            cMBill_DetailedEntity.BillNo = reader.GetString(FLD_BILLNO);
            cMBill_DetailedEntity.VendorCategory = reader.GetInt64(FLD_VENDORCATEGORY);
            cMBill_DetailedEntity.Vendor = reader.GetInt64(FLD_VENDOR);
            cMBill_DetailedEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID);
            cMBill_DetailedEntity.Amount = reader.GetDecimal(FLD_AMOUNT);
            cMBill_DetailedEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            cMBill_DetailedEntity.BillDate = reader.GetDateTime(FLD_BILLDATE);
            if (reader.IsDBNull(FLD_REMARKS)) { cMBill_DetailedEntity.Remarks = String.Empty; } else { cMBill_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            cMBill_DetailedEntity.BillStatusID = reader.GetInt64(FLD_BILLSTATUSID);
            cMBill_DetailedEntity.BillApprovalStatusID = reader.GetInt64(FLD_BILLAPPROVALSTATUSID);
            if (reader.IsDBNull(FLD_SUPPLIERCODE)) { cMBill_DetailedEntity.SupplierCode = String.Empty; } else { cMBill_DetailedEntity.SupplierCode = reader.GetString(FLD_SUPPLIERCODE); }
            cMBill_DetailedEntity.SupplierName = reader.GetString(FLD_SUPPLIERNAME);
            if (reader.IsDBNull(FLD_BDPROJECTPROJECTNAME)) { cMBill_DetailedEntity.BDProjectProjectName = String.Empty; } else { cMBill_DetailedEntity.BDProjectProjectName = reader.GetString(FLD_BDPROJECTPROJECTNAME); }
            if (reader.IsDBNull(FLD_WORKORDERNO)) { cMBill_DetailedEntity.WorkOrderNo = String.Empty; } else { cMBill_DetailedEntity.WorkOrderNo = reader.GetString(FLD_WORKORDERNO); }
            if (reader.IsDBNull(FLD_MDBILLSTATUSNAME)) { cMBill_DetailedEntity.MDBillStatusName = String.Empty; } else { cMBill_DetailedEntity.MDBillStatusName = reader.GetString(FLD_MDBILLSTATUSNAME); }
            if (reader.IsDBNull(FLD_MDBILLAPPROVALSTATUSNAME)) { cMBill_DetailedEntity.MDBillApprovalStatusName = String.Empty; } else { cMBill_DetailedEntity.MDBillApprovalStatusName = reader.GetString(FLD_MDBILLAPPROVALSTATUSNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { cMBill_DetailedEntity.RowNumber = null; } else { cMBill_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return cMBill_DetailedEntity;
        }
    }
}
