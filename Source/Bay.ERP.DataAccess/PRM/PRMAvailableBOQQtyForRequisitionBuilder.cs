// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 01-Jul-2013, 05:44:25




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMAvailableBOQQtyForRequisitionBuilder : IEntityBuilder<PRMAvailableBOQQtyForRequisitionEntity>
    {
        IList<PRMAvailableBOQQtyForRequisitionEntity> IEntityBuilder<PRMAvailableBOQQtyForRequisitionEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMAvailableBOQQtyForRequisitionEntity> PRMAvailableBOQQtyForRequisitionEntityList = new List<PRMAvailableBOQQtyForRequisitionEntity>();

            while (reader.Read())
            {
                PRMAvailableBOQQtyForRequisitionEntityList.Add(((IEntityBuilder<PRMAvailableBOQQtyForRequisitionEntity>)this).BuildEntity(reader));
            }

            return (PRMAvailableBOQQtyForRequisitionEntityList.Count > 0) ? PRMAvailableBOQQtyForRequisitionEntityList : null;
        }

        PRMAvailableBOQQtyForRequisitionEntity IEntityBuilder<PRMAvailableBOQQtyForRequisitionEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_AVAILABLEBOQQTYFORREQUISITIONID = 0;
            const Int32 FLD_ISBOQ = 1;
            const Int32 FLD_PROJECTID = 2;
            const Int32 FLD_PREBOQORBOQDETAILID = 3;
            const Int32 FLD_ITEMID = 4;
            const Int32 FLD_QTY = 5;
            const Int32 FLD_CREATEDATE = 6;
            const Int32 FLD_CREATEDBYEMPLOYEEID = 7;

            PRMAvailableBOQQtyForRequisitionEntity pRMAvailableBOQQtyForRequisitionEntity = new PRMAvailableBOQQtyForRequisitionEntity();

            pRMAvailableBOQQtyForRequisitionEntity.AvailableBOQQtyForRequisitionID = reader.GetInt64(FLD_AVAILABLEBOQQTYFORREQUISITIONID);
            if (reader.IsDBNull(FLD_ISBOQ)) { pRMAvailableBOQQtyForRequisitionEntity.IsBOQ = false; } else { pRMAvailableBOQQtyForRequisitionEntity.IsBOQ = reader.GetBoolean(FLD_ISBOQ); }
            if (reader.IsDBNull(FLD_PROJECTID)) { pRMAvailableBOQQtyForRequisitionEntity.ProjectID = null; } else { pRMAvailableBOQQtyForRequisitionEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            pRMAvailableBOQQtyForRequisitionEntity.PreBOQOrBOQDetailID = reader.GetInt64(FLD_PREBOQORBOQDETAILID);
            pRMAvailableBOQQtyForRequisitionEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            pRMAvailableBOQQtyForRequisitionEntity.Qty = reader.GetDecimal(FLD_QTY);
            pRMAvailableBOQQtyForRequisitionEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            pRMAvailableBOQQtyForRequisitionEntity.CreatedByEmployeeID = reader.GetInt64(FLD_CREATEDBYEMPLOYEEID);

            return pRMAvailableBOQQtyForRequisitionEntity;
        }
    }
}
