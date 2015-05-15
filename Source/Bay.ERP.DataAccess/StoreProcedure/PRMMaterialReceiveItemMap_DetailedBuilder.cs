// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-Aug-2013, 05:41:48




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMMaterialReceiveItemMap_DetailedBuilder : IEntityBuilder<PRMMaterialReceiveItemMap_DetailedEntity>
    {
        IList<PRMMaterialReceiveItemMap_DetailedEntity> IEntityBuilder<PRMMaterialReceiveItemMap_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMMaterialReceiveItemMap_DetailedEntity> PRMMaterialReceiveItemMap_DetailedEntityList = new List<PRMMaterialReceiveItemMap_DetailedEntity>();

            while (reader.Read())
            {
                PRMMaterialReceiveItemMap_DetailedEntityList.Add(((IEntityBuilder<PRMMaterialReceiveItemMap_DetailedEntity>)this).BuildEntity(reader));
            }

            return (PRMMaterialReceiveItemMap_DetailedEntityList.Count > 0) ? PRMMaterialReceiveItemMap_DetailedEntityList : null;
        }

        PRMMaterialReceiveItemMap_DetailedEntity IEntityBuilder<PRMMaterialReceiveItemMap_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_MATERIALRECEIVEITEMMAPID = 0;
            const Int32 FLD_MATERIALRECEIVEID = 1;
            const Int32 FLD_REQUISITIONITEMID = 2;
            const Int32 FLD_RECEIVEDATE = 3;
            const Int32 FLD_RECEIVEQTY = 4;
            const Int32 FLD_ITEMRATE = 5;
            const Int32 FLD_CHALLANNO = 6;
            const Int32 FLD_WOITEMTOTALRATE = 7;
            const Int32 FLD_MRRNO = 8;
            const Int32 FLD_PROJECTID = 9;
            const Int32 FLD_ITEMNAME = 10;
            const Int32 FLD_BRANDNAME = 11;
            const Int32 FLD_SUPPLIERNAME = 12;
            const Int32 FLD_ORIGINCOUNTRY = 13;
            const Int32 FLD_ORIGINREGION = 14;
            const Int32 FLD_UNITNAME = 15;
            const Int32 FLD_WORKORDERID = 16;
            const Int32 FLD_ITEMID = 17;
            const Int32 FLD_REQUISITIONID = 18;
            const Int32 FLD_WORKORDERITEMMAPID = 19;

            PRMMaterialReceiveItemMap_DetailedEntity pRMMaterialReceiveItemMap_DetailedEntity = new PRMMaterialReceiveItemMap_DetailedEntity();

            pRMMaterialReceiveItemMap_DetailedEntity.MaterialReceiveItemMapID = reader.GetInt64(FLD_MATERIALRECEIVEITEMMAPID);
            pRMMaterialReceiveItemMap_DetailedEntity.MaterialReceiveID = reader.GetInt64(FLD_MATERIALRECEIVEID);
            pRMMaterialReceiveItemMap_DetailedEntity.RequisitionItemID = reader.GetInt64(FLD_REQUISITIONITEMID);
            pRMMaterialReceiveItemMap_DetailedEntity.ReceiveDate = reader.GetDateTime(FLD_RECEIVEDATE);
            pRMMaterialReceiveItemMap_DetailedEntity.ReceiveQty = reader.GetDecimal(FLD_RECEIVEQTY);
            pRMMaterialReceiveItemMap_DetailedEntity.ItemRate = reader.GetDecimal(FLD_ITEMRATE);
            pRMMaterialReceiveItemMap_DetailedEntity.ChallanNo = reader.GetString(FLD_CHALLANNO);
            pRMMaterialReceiveItemMap_DetailedEntity.WOItemTotalRate = reader.GetDecimal(FLD_WOITEMTOTALRATE);
            if (reader.IsDBNull(FLD_MRRNO)) { pRMMaterialReceiveItemMap_DetailedEntity.MRRNo = String.Empty; } else { pRMMaterialReceiveItemMap_DetailedEntity.MRRNo = reader.GetString(FLD_MRRNO); }
            if (reader.IsDBNull(FLD_PROJECTID)) { pRMMaterialReceiveItemMap_DetailedEntity.ProjectID = null; } else { pRMMaterialReceiveItemMap_DetailedEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            if (reader.IsDBNull(FLD_ITEMNAME)) { pRMMaterialReceiveItemMap_DetailedEntity.ItemName = String.Empty; } else { pRMMaterialReceiveItemMap_DetailedEntity.ItemName = reader.GetString(FLD_ITEMNAME); }
            if (reader.IsDBNull(FLD_BRANDNAME)) { pRMMaterialReceiveItemMap_DetailedEntity.BrandName = String.Empty; } else { pRMMaterialReceiveItemMap_DetailedEntity.BrandName = reader.GetString(FLD_BRANDNAME); }
            if (reader.IsDBNull(FLD_SUPPLIERNAME)) { pRMMaterialReceiveItemMap_DetailedEntity.SupplierName = String.Empty; } else { pRMMaterialReceiveItemMap_DetailedEntity.SupplierName = reader.GetString(FLD_SUPPLIERNAME); }
            if (reader.IsDBNull(FLD_ORIGINCOUNTRY)) { pRMMaterialReceiveItemMap_DetailedEntity.OriginCountry = String.Empty; } else { pRMMaterialReceiveItemMap_DetailedEntity.OriginCountry = reader.GetString(FLD_ORIGINCOUNTRY); }
            if (reader.IsDBNull(FLD_ORIGINREGION)) { pRMMaterialReceiveItemMap_DetailedEntity.OriginRegion = String.Empty; } else { pRMMaterialReceiveItemMap_DetailedEntity.OriginRegion = reader.GetString(FLD_ORIGINREGION); }
            if (reader.IsDBNull(FLD_UNITNAME)) { pRMMaterialReceiveItemMap_DetailedEntity.UnitName = String.Empty; } else { pRMMaterialReceiveItemMap_DetailedEntity.UnitName = reader.GetString(FLD_UNITNAME); }
            if (reader.IsDBNull(FLD_WORKORDERID)) { pRMMaterialReceiveItemMap_DetailedEntity.WorkOrderID = null; } else { pRMMaterialReceiveItemMap_DetailedEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID); }
            if (reader.IsDBNull(FLD_ITEMID)) { pRMMaterialReceiveItemMap_DetailedEntity.ItemID = null; } else { pRMMaterialReceiveItemMap_DetailedEntity.ItemID = reader.GetInt64(FLD_ITEMID); }
            if (reader.IsDBNull(FLD_REQUISITIONID)) { pRMMaterialReceiveItemMap_DetailedEntity.RequisitionID = null; } else { pRMMaterialReceiveItemMap_DetailedEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID); }
            pRMMaterialReceiveItemMap_DetailedEntity.WorkOrderItemMapID = reader.GetInt64(FLD_WORKORDERITEMMAPID);

            return pRMMaterialReceiveItemMap_DetailedEntity;
        }
    }
}
