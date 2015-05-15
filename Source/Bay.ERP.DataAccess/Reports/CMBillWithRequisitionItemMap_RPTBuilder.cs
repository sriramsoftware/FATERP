// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jan-2013, 12:10:49




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMBillWithRequisitionItemMap_RPTBuilder : IEntityBuilder<CMBillWithRequisitionItemMap_RPTEntity>
    {
        IList<CMBillWithRequisitionItemMap_RPTEntity> IEntityBuilder<CMBillWithRequisitionItemMap_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<CMBillWithRequisitionItemMap_RPTEntity> CMBillWithRequisitionItemMap_RPTEntityList = new List<CMBillWithRequisitionItemMap_RPTEntity>();

            while (reader.Read())
            {
                CMBillWithRequisitionItemMap_RPTEntityList.Add(((IEntityBuilder<CMBillWithRequisitionItemMap_RPTEntity>)this).BuildEntity(reader));
            }

            return (CMBillWithRequisitionItemMap_RPTEntityList.Count > 0) ? CMBillWithRequisitionItemMap_RPTEntityList : null;
        }

        CMBillWithRequisitionItemMap_RPTEntity IEntityBuilder<CMBillWithRequisitionItemMap_RPTEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_PROJECTCODE = 12;
            const Int32 FLD_PROJECTNAME = 13;
            const Int32 FLD_REQUISITIONNO = 14;
            const Int32 FLD_ITEMNAME = 15;
            const Int32 FLD_REQUISITIONPRICE = 16;
            const Int32 FLD_BILLPRICE = 17;
            const Int32 FLD_PRESENTREQUIREDQTY = 18;
            const Int32 FLD_UNITNAME = 19;
            const Int32 FLD_VENDORCATEGORYNAME = 20;
            const Int32 FLD_RESOURCENAME = 21;
            const Int32 FLD_ROWNUMBER = 22;

            CMBillWithRequisitionItemMap_RPTEntity cMBillWithRequisitionItemMap_RPTEntity = new CMBillWithRequisitionItemMap_RPTEntity();

            cMBillWithRequisitionItemMap_RPTEntity.BillID = reader.GetInt64(FLD_BILLID);
            cMBillWithRequisitionItemMap_RPTEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            cMBillWithRequisitionItemMap_RPTEntity.BillNo = reader.GetString(FLD_BILLNO);
            cMBillWithRequisitionItemMap_RPTEntity.VendorCategory = reader.GetInt64(FLD_VENDORCATEGORY);
            cMBillWithRequisitionItemMap_RPTEntity.Vendor = reader.GetInt64(FLD_VENDOR);
            cMBillWithRequisitionItemMap_RPTEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID);
            cMBillWithRequisitionItemMap_RPTEntity.Amount = reader.GetDecimal(FLD_AMOUNT);
            cMBillWithRequisitionItemMap_RPTEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            cMBillWithRequisitionItemMap_RPTEntity.BillDate = reader.GetDateTime(FLD_BILLDATE);
            if (reader.IsDBNull(FLD_REMARKS)) { cMBillWithRequisitionItemMap_RPTEntity.Remarks = String.Empty; } else { cMBillWithRequisitionItemMap_RPTEntity.Remarks = reader.GetString(FLD_REMARKS); }
            cMBillWithRequisitionItemMap_RPTEntity.BillStatusID = reader.GetInt64(FLD_BILLSTATUSID);
            cMBillWithRequisitionItemMap_RPTEntity.BillApprovalStatusID = reader.GetInt64(FLD_BILLAPPROVALSTATUSID);
            cMBillWithRequisitionItemMap_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE);
            cMBillWithRequisitionItemMap_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME);
            if (reader.IsDBNull(FLD_REQUISITIONNO)) { cMBillWithRequisitionItemMap_RPTEntity.RequisitionNo = String.Empty; } else { cMBillWithRequisitionItemMap_RPTEntity.RequisitionNo = reader.GetString(FLD_REQUISITIONNO); }
            if (reader.IsDBNull(FLD_ITEMNAME)) { cMBillWithRequisitionItemMap_RPTEntity.ItemName = String.Empty; } else { cMBillWithRequisitionItemMap_RPTEntity.ItemName = reader.GetString(FLD_ITEMNAME); }
            if (reader.IsDBNull(FLD_REQUISITIONPRICE)) { cMBillWithRequisitionItemMap_RPTEntity.RequisitionPrice = null; } else { cMBillWithRequisitionItemMap_RPTEntity.RequisitionPrice = reader.GetDecimal(FLD_REQUISITIONPRICE); }
            if (reader.IsDBNull(FLD_BILLPRICE)) { cMBillWithRequisitionItemMap_RPTEntity.BillPrice = null; } else { cMBillWithRequisitionItemMap_RPTEntity.BillPrice = reader.GetDecimal(FLD_BILLPRICE); }
            if (reader.IsDBNull(FLD_PRESENTREQUIREDQTY)) { cMBillWithRequisitionItemMap_RPTEntity.PresentRequiredQty = null; } else { cMBillWithRequisitionItemMap_RPTEntity.PresentRequiredQty = reader.GetDecimal(FLD_PRESENTREQUIREDQTY); }
            if (reader.IsDBNull(FLD_UNITNAME)) { cMBillWithRequisitionItemMap_RPTEntity.UnitName = String.Empty; } else { cMBillWithRequisitionItemMap_RPTEntity.UnitName = reader.GetString(FLD_UNITNAME); }
            cMBillWithRequisitionItemMap_RPTEntity.VendorCategoryName = reader.GetString(FLD_VENDORCATEGORYNAME);
            cMBillWithRequisitionItemMap_RPTEntity.ResourceName = reader.GetString(FLD_RESOURCENAME);
            if (reader.IsDBNull(FLD_ROWNUMBER)) { cMBillWithRequisitionItemMap_RPTEntity.RowNumber = null; } else { cMBillWithRequisitionItemMap_RPTEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return cMBillWithRequisitionItemMap_RPTEntity;
        }
    }
}
