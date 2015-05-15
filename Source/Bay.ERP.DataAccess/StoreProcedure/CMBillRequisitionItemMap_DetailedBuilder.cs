// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Jan-2013, 11:49:03




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMBillRequisitionItemMap_DetailedBuilder : IEntityBuilder<CMBillRequisitionItemMap_DetailedEntity>
    {
        IList<CMBillRequisitionItemMap_DetailedEntity> IEntityBuilder<CMBillRequisitionItemMap_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<CMBillRequisitionItemMap_DetailedEntity> CMBillRequisitionItemMap_DetailedEntityList = new List<CMBillRequisitionItemMap_DetailedEntity>();

            while (reader.Read())
            {
                CMBillRequisitionItemMap_DetailedEntityList.Add(((IEntityBuilder<CMBillRequisitionItemMap_DetailedEntity>)this).BuildEntity(reader));
            }

            return (CMBillRequisitionItemMap_DetailedEntityList.Count > 0) ? CMBillRequisitionItemMap_DetailedEntityList : null;
        }

        CMBillRequisitionItemMap_DetailedEntity IEntityBuilder<CMBillRequisitionItemMap_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BILLREQUISITIONITEMMAPID = 0;
            const Int32 FLD_BILLID = 1;
            const Int32 FLD_REQUISITIONID = 2;
            const Int32 FLD_REQUISITIONITEMID = 3;
            const Int32 FLD_REQUISITIONPRICE = 4;
            const Int32 FLD_BILLPRICE = 5;
            const Int32 FLD_BILLNO = 6;
            const Int32 FLD_REQUISITIONNO = 7;
            const Int32 FLD_ITEMNAME = 8;

            CMBillRequisitionItemMap_DetailedEntity cMBillRequisitionItemMap_DetailedEntity = new CMBillRequisitionItemMap_DetailedEntity();

            cMBillRequisitionItemMap_DetailedEntity.BillRequisitionItemMapID = reader.GetInt64(FLD_BILLREQUISITIONITEMMAPID);
            cMBillRequisitionItemMap_DetailedEntity.BillID = reader.GetInt64(FLD_BILLID);
            cMBillRequisitionItemMap_DetailedEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID);
            cMBillRequisitionItemMap_DetailedEntity.RequisitionItemID = reader.GetInt64(FLD_REQUISITIONITEMID);
            cMBillRequisitionItemMap_DetailedEntity.RequisitionPrice = reader.GetDecimal(FLD_REQUISITIONPRICE);
            if (reader.IsDBNull(FLD_BILLPRICE)) { cMBillRequisitionItemMap_DetailedEntity.BillPrice = null; } else { cMBillRequisitionItemMap_DetailedEntity.BillPrice = reader.GetDecimal(FLD_BILLPRICE); }
            cMBillRequisitionItemMap_DetailedEntity.BillNo = reader.GetString(FLD_BILLNO);
            cMBillRequisitionItemMap_DetailedEntity.RequisitionNo = reader.GetString(FLD_REQUISITIONNO);
            cMBillRequisitionItemMap_DetailedEntity.ItemName = reader.GetString(FLD_ITEMNAME);

            return cMBillRequisitionItemMap_DetailedEntity;
        }
    }
}
