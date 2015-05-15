// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 01-Apr-2013, 02:41:21




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMBuyerInterestedRoomMapBuilder : IEntityBuilder<CRMBuyerInterestedRoomMapEntity>
    {
        IList<CRMBuyerInterestedRoomMapEntity> IEntityBuilder<CRMBuyerInterestedRoomMapEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMBuyerInterestedRoomMapEntity> CRMBuyerInterestedRoomMapEntityList = new List<CRMBuyerInterestedRoomMapEntity>();

            while (reader.Read())
            {
                CRMBuyerInterestedRoomMapEntityList.Add(((IEntityBuilder<CRMBuyerInterestedRoomMapEntity>)this).BuildEntity(reader));
            }

            return (CRMBuyerInterestedRoomMapEntityList.Count > 0) ? CRMBuyerInterestedRoomMapEntityList : null;
        }

        CRMBuyerInterestedRoomMapEntity IEntityBuilder<CRMBuyerInterestedRoomMapEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BUYERINTERESTEDROOMMAPID = 0;
            const Int32 FLD_BUYERBASICINFOID = 1;
            const Int32 FLD_BUYERINTERESTEDROOMCATEGORYID = 2;

            CRMBuyerInterestedRoomMapEntity cRMBuyerInterestedRoomMapEntity = new CRMBuyerInterestedRoomMapEntity();

            cRMBuyerInterestedRoomMapEntity.BuyerInterestedRoomMapID = reader.GetInt64(FLD_BUYERINTERESTEDROOMMAPID);
            cRMBuyerInterestedRoomMapEntity.BuyerBasicInfoID = reader.GetInt64(FLD_BUYERBASICINFOID);
            cRMBuyerInterestedRoomMapEntity.BuyerInterestedRoomCategoryID = reader.GetInt64(FLD_BUYERINTERESTEDROOMCATEGORYID);

            return cRMBuyerInterestedRoomMapEntity;
        }
    }
}
