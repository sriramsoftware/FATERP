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
    internal sealed class CRMMDBuyerInterestedRoomCategoryBuilder : IEntityBuilder<CRMMDBuyerInterestedRoomCategoryEntity>
    {
        IList<CRMMDBuyerInterestedRoomCategoryEntity> IEntityBuilder<CRMMDBuyerInterestedRoomCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMMDBuyerInterestedRoomCategoryEntity> CRMMDBuyerInterestedRoomCategoryEntityList = new List<CRMMDBuyerInterestedRoomCategoryEntity>();

            while (reader.Read())
            {
                CRMMDBuyerInterestedRoomCategoryEntityList.Add(((IEntityBuilder<CRMMDBuyerInterestedRoomCategoryEntity>)this).BuildEntity(reader));
            }

            return (CRMMDBuyerInterestedRoomCategoryEntityList.Count > 0) ? CRMMDBuyerInterestedRoomCategoryEntityList : null;
        }

        CRMMDBuyerInterestedRoomCategoryEntity IEntityBuilder<CRMMDBuyerInterestedRoomCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BUYERINTERESTEDROOMCATEGORYID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            CRMMDBuyerInterestedRoomCategoryEntity cRMMDBuyerInterestedRoomCategoryEntity = new CRMMDBuyerInterestedRoomCategoryEntity();

            cRMMDBuyerInterestedRoomCategoryEntity.BuyerInterestedRoomCategoryID = reader.GetInt64(FLD_BUYERINTERESTEDROOMCATEGORYID);
            cRMMDBuyerInterestedRoomCategoryEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { cRMMDBuyerInterestedRoomCategoryEntity.Description = String.Empty; } else { cRMMDBuyerInterestedRoomCategoryEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            cRMMDBuyerInterestedRoomCategoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return cRMMDBuyerInterestedRoomCategoryEntity;
        }
    }
}
