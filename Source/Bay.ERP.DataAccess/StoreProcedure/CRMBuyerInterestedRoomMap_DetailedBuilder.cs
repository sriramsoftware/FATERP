// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Apr-2013, 04:34:01




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMBuyerInterestedRoomMap_DetailedBuilder : IEntityBuilder<CRMBuyerInterestedRoomMap_DetailedEntity>
    {
        IList<CRMBuyerInterestedRoomMap_DetailedEntity> IEntityBuilder<CRMBuyerInterestedRoomMap_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMBuyerInterestedRoomMap_DetailedEntity> CRMBuyerInterestedRoomMap_DetailedEntityList = new List<CRMBuyerInterestedRoomMap_DetailedEntity>();

            while (reader.Read())
            {
                CRMBuyerInterestedRoomMap_DetailedEntityList.Add(((IEntityBuilder<CRMBuyerInterestedRoomMap_DetailedEntity>)this).BuildEntity(reader));
            }

            return (CRMBuyerInterestedRoomMap_DetailedEntityList.Count > 0) ? CRMBuyerInterestedRoomMap_DetailedEntityList : null;
        }

        CRMBuyerInterestedRoomMap_DetailedEntity IEntityBuilder<CRMBuyerInterestedRoomMap_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BUYERINTERESTEDROOMMAPID = 0;
            const Int32 FLD_BUYERBASICINFOID = 1;
            const Int32 FLD_BUYERINTERESTEDROOMCATEGORYID = 2;
            const Int32 FLD_BUYERBASICINFOCONTACTFULLNAME = 3;
            const Int32 FLD_BUYERINTERESTEDROOMCATEGORYNAME = 4;
            const Int32 FLD_ROWNUMBER = 5;

            CRMBuyerInterestedRoomMap_DetailedEntity cRMBuyerInterestedRoomMap_DetailedEntity = new CRMBuyerInterestedRoomMap_DetailedEntity();

            cRMBuyerInterestedRoomMap_DetailedEntity.BuyerInterestedRoomMapID = reader.GetInt64(FLD_BUYERINTERESTEDROOMMAPID);
            cRMBuyerInterestedRoomMap_DetailedEntity.BuyerBasicInfoID = reader.GetInt64(FLD_BUYERBASICINFOID);
            cRMBuyerInterestedRoomMap_DetailedEntity.BuyerInterestedRoomCategoryID = reader.GetInt64(FLD_BUYERINTERESTEDROOMCATEGORYID);
            if (reader.IsDBNull(FLD_BUYERBASICINFOCONTACTFULLNAME)) { cRMBuyerInterestedRoomMap_DetailedEntity.BuyerBasicInfoContactFullName = String.Empty; } else { cRMBuyerInterestedRoomMap_DetailedEntity.BuyerBasicInfoContactFullName = reader.GetString(FLD_BUYERBASICINFOCONTACTFULLNAME); }
            if (reader.IsDBNull(FLD_BUYERINTERESTEDROOMCATEGORYNAME)) { cRMBuyerInterestedRoomMap_DetailedEntity.BuyerInterestedRoomCategoryName = String.Empty; } else { cRMBuyerInterestedRoomMap_DetailedEntity.BuyerInterestedRoomCategoryName = reader.GetString(FLD_BUYERINTERESTEDROOMCATEGORYNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { cRMBuyerInterestedRoomMap_DetailedEntity.RowNumber = null; } else { cRMBuyerInterestedRoomMap_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return cRMBuyerInterestedRoomMap_DetailedEntity;
        }
    }
}
