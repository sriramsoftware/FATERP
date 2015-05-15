// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 14-Aug-2013, 02:50:29




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMMaterialReceiveItemMapBuilder : IEntityBuilder<PRMMaterialReceiveItemMapEntity>
    {
        IList<PRMMaterialReceiveItemMapEntity> IEntityBuilder<PRMMaterialReceiveItemMapEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMMaterialReceiveItemMapEntity> PRMMaterialReceiveItemMapEntityList = new List<PRMMaterialReceiveItemMapEntity>();

            while (reader.Read())
            {
                PRMMaterialReceiveItemMapEntityList.Add(((IEntityBuilder<PRMMaterialReceiveItemMapEntity>)this).BuildEntity(reader));
            }

            return (PRMMaterialReceiveItemMapEntityList.Count > 0) ? PRMMaterialReceiveItemMapEntityList : null;
        }

        PRMMaterialReceiveItemMapEntity IEntityBuilder<PRMMaterialReceiveItemMapEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_MATERIALRECEIVEITEMMAPID = 0;
            const Int32 FLD_MATERIALRECEIVEID = 1;
            const Int32 FLD_REQUISITIONITEMID = 2;
            const Int32 FLD_WOITEMTOTALRATE = 3;
            const Int32 FLD_RECEIVEDATE = 4;
            const Int32 FLD_RECEIVEQTY = 5;
            const Int32 FLD_ITEMRATE = 6;
            const Int32 FLD_CHALLANNO = 7;

            PRMMaterialReceiveItemMapEntity pRMMaterialReceiveItemMapEntity = new PRMMaterialReceiveItemMapEntity();

            pRMMaterialReceiveItemMapEntity.MaterialReceiveItemMapID = reader.GetInt64(FLD_MATERIALRECEIVEITEMMAPID);
            pRMMaterialReceiveItemMapEntity.MaterialReceiveID = reader.GetInt64(FLD_MATERIALRECEIVEID);
            pRMMaterialReceiveItemMapEntity.RequisitionItemID = reader.GetInt64(FLD_REQUISITIONITEMID);
            pRMMaterialReceiveItemMapEntity.WOItemTotalRate = reader.GetDecimal(FLD_WOITEMTOTALRATE);
            pRMMaterialReceiveItemMapEntity.ReceiveDate = reader.GetDateTime(FLD_RECEIVEDATE);
            pRMMaterialReceiveItemMapEntity.ReceiveQty = reader.GetDecimal(FLD_RECEIVEQTY);
            pRMMaterialReceiveItemMapEntity.ItemRate = reader.GetDecimal(FLD_ITEMRATE);
            pRMMaterialReceiveItemMapEntity.ChallanNo = reader.GetString(FLD_CHALLANNO);

            return pRMMaterialReceiveItemMapEntity;
        }
    }
}
