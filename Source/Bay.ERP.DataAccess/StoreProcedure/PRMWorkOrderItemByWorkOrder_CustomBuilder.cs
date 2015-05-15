// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Oct-2012, 11:18:20




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMWorkOrderItemByWorkOrder_CustomBuilder : IEntityBuilder<PRMWorkOrderItemByWorkOrder_CustomEntity>
    {
        IList<PRMWorkOrderItemByWorkOrder_CustomEntity> IEntityBuilder<PRMWorkOrderItemByWorkOrder_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMWorkOrderItemByWorkOrder_CustomEntity> PRMWorkOrderItemByWorkOrder_CustomEntityList = new List<PRMWorkOrderItemByWorkOrder_CustomEntity>();

            while (reader.Read())
            {
                PRMWorkOrderItemByWorkOrder_CustomEntityList.Add(((IEntityBuilder<PRMWorkOrderItemByWorkOrder_CustomEntity>)this).BuildEntity(reader));
            }

            return (PRMWorkOrderItemByWorkOrder_CustomEntityList.Count > 0) ? PRMWorkOrderItemByWorkOrder_CustomEntityList : null;
        }

        PRMWorkOrderItemByWorkOrder_CustomEntity IEntityBuilder<PRMWorkOrderItemByWorkOrder_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_WORKORDERID = 0;
            const Int32 FLD_ITEMNAME = 1;
            const Int32 FLD_ITEMID = 2;

            PRMWorkOrderItemByWorkOrder_CustomEntity pRMWorkOrderItemByWorkOrder_CustomEntity = new PRMWorkOrderItemByWorkOrder_CustomEntity();

            pRMWorkOrderItemByWorkOrder_CustomEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID);
            pRMWorkOrderItemByWorkOrder_CustomEntity.ItemName = reader.GetString(FLD_ITEMNAME);
            pRMWorkOrderItemByWorkOrder_CustomEntity.ItemID = reader.GetInt64(FLD_ITEMID);

            return pRMWorkOrderItemByWorkOrder_CustomEntity;
        }
    }
}
