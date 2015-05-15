// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Jan-2013, 11:55:33




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMBillRequisitionItemMapBuilder : IEntityBuilder<CMBillRequisitionItemMapEntity>
    {
        IList<CMBillRequisitionItemMapEntity> IEntityBuilder<CMBillRequisitionItemMapEntity>.BuildEntities(IDataReader reader)
        {
            List<CMBillRequisitionItemMapEntity> CMBillRequisitionItemMapEntityList = new List<CMBillRequisitionItemMapEntity>();

            while (reader.Read())
            {
                CMBillRequisitionItemMapEntityList.Add(((IEntityBuilder<CMBillRequisitionItemMapEntity>)this).BuildEntity(reader));
            }

            return (CMBillRequisitionItemMapEntityList.Count > 0) ? CMBillRequisitionItemMapEntityList : null;
        }

        CMBillRequisitionItemMapEntity IEntityBuilder<CMBillRequisitionItemMapEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BILLREQUISITIONITEMMAPID = 0;
            const Int32 FLD_BILLID = 1;
            const Int32 FLD_REQUISITIONID = 2;
            const Int32 FLD_REQUISITIONITEMID = 3;
            const Int32 FLD_REQUISITIONPRICE = 4;
            const Int32 FLD_BILLPRICE = 5;

            CMBillRequisitionItemMapEntity cMBillRequisitionItemMapEntity = new CMBillRequisitionItemMapEntity();

            cMBillRequisitionItemMapEntity.BillRequisitionItemMapID = reader.GetInt64(FLD_BILLREQUISITIONITEMMAPID);
            cMBillRequisitionItemMapEntity.BillID = reader.GetInt64(FLD_BILLID);
            cMBillRequisitionItemMapEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID);
            cMBillRequisitionItemMapEntity.RequisitionItemID = reader.GetInt64(FLD_REQUISITIONITEMID);
            cMBillRequisitionItemMapEntity.RequisitionPrice = reader.GetDecimal(FLD_REQUISITIONPRICE);
            if (reader.IsDBNull(FLD_BILLPRICE)) { cMBillRequisitionItemMapEntity.BillPrice = null; } else { cMBillRequisitionItemMapEntity.BillPrice = reader.GetDecimal(FLD_BILLPRICE); }

            return cMBillRequisitionItemMapEntity;
        }
    }
}
