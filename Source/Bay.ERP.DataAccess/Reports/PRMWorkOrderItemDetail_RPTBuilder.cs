// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Feb-2013, 03:02:44




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMWorkOrderItemDetail_RPTBuilder : IEntityBuilder<PRMWorkOrderItemDetail_RPTEntity>
    {
        IList<PRMWorkOrderItemDetail_RPTEntity> IEntityBuilder<PRMWorkOrderItemDetail_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMWorkOrderItemDetail_RPTEntity> PRMWorkOrderItemDetail_RPTEntityList = new List<PRMWorkOrderItemDetail_RPTEntity>();

            while (reader.Read())
            {
                PRMWorkOrderItemDetail_RPTEntityList.Add(((IEntityBuilder<PRMWorkOrderItemDetail_RPTEntity>)this).BuildEntity(reader));
            }

            return (PRMWorkOrderItemDetail_RPTEntityList.Count > 0) ? PRMWorkOrderItemDetail_RPTEntityList : null;
        }

        PRMWorkOrderItemDetail_RPTEntity IEntityBuilder<PRMWorkOrderItemDetail_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_WORKORDERITEMDETAILID = 0;
            const Int32 FLD_DESCRIPTION = 1;
            const Int32 FLD_RATE = 2;
            const Int32 FLD_UNITNAME = 3;
            const Int32 FLD_QTY = 4;
            const Int32 FLD_WORKORDERID = 5;
            const Int32 FLD_ITEMNAME = 6;

            PRMWorkOrderItemDetail_RPTEntity pRMWorkOrderItemDetail_RPTEntity = new PRMWorkOrderItemDetail_RPTEntity();

            pRMWorkOrderItemDetail_RPTEntity.WorkOrderItemDetailID = reader.GetInt64(FLD_WORKORDERITEMDETAILID);
            pRMWorkOrderItemDetail_RPTEntity.Description = reader.GetString(FLD_DESCRIPTION);
            pRMWorkOrderItemDetail_RPTEntity.Rate = reader.GetDecimal(FLD_RATE);
            if (reader.IsDBNull(FLD_UNITNAME)) { pRMWorkOrderItemDetail_RPTEntity.UnitName = String.Empty; } else { pRMWorkOrderItemDetail_RPTEntity.UnitName = reader.GetString(FLD_UNITNAME); }
            pRMWorkOrderItemDetail_RPTEntity.Qty = reader.GetDecimal(FLD_QTY);
            pRMWorkOrderItemDetail_RPTEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID);
            pRMWorkOrderItemDetail_RPTEntity.ItemName = reader.GetString(FLD_ITEMNAME);

            return pRMWorkOrderItemDetail_RPTEntity;
        }
    }
}
