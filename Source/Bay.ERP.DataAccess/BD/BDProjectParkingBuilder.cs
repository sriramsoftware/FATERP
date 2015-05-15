// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jun-2013, 02:07:00




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDProjectParkingBuilder : IEntityBuilder<BDProjectParkingEntity>
    {
        IList<BDProjectParkingEntity> IEntityBuilder<BDProjectParkingEntity>.BuildEntities(IDataReader reader)
        {
            List<BDProjectParkingEntity> BDProjectParkingEntityList = new List<BDProjectParkingEntity>();

            while (reader.Read())
            {
                BDProjectParkingEntityList.Add(((IEntityBuilder<BDProjectParkingEntity>)this).BuildEntity(reader));
            }

            return (BDProjectParkingEntityList.Count > 0) ? BDProjectParkingEntityList : null;
        }

        BDProjectParkingEntity IEntityBuilder<BDProjectParkingEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTPARKINGID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_GROUND = 2;
            const Int32 FLD_LOWERGROUND = 3;
            const Int32 FLD_BASEMENT1 = 4;
            const Int32 FLD_BASEMENT2 = 5;
            const Int32 FLD_BASEMENT3 = 6;
            const Int32 FLD_BASEMENT4 = 7;
            const Int32 FLD_BASEMENT5 = 8;
            const Int32 FLD_BASEMENT6 = 9;
            const Int32 FLD_OUTDOOR = 10;
            const Int32 FLD_TOTAL = 11;
            const Int32 FLD_GUESTPARKING = 12;
            const Int32 FLD_DISABLEPARKING = 13;

            BDProjectParkingEntity bDProjectParkingEntity = new BDProjectParkingEntity();

            bDProjectParkingEntity.ProjectParkingID = reader.GetInt64(FLD_PROJECTPARKINGID);
            bDProjectParkingEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            bDProjectParkingEntity.Ground = reader.GetDecimal(FLD_GROUND);
            if (reader.IsDBNull(FLD_LOWERGROUND)) { bDProjectParkingEntity.LowerGround = null; } else { bDProjectParkingEntity.LowerGround = reader.GetDecimal(FLD_LOWERGROUND); }
            if (reader.IsDBNull(FLD_BASEMENT1)) { bDProjectParkingEntity.Basement1 = null; } else { bDProjectParkingEntity.Basement1 = reader.GetDecimal(FLD_BASEMENT1); }
            if (reader.IsDBNull(FLD_BASEMENT2)) { bDProjectParkingEntity.Basement2 = null; } else { bDProjectParkingEntity.Basement2 = reader.GetDecimal(FLD_BASEMENT2); }
            if (reader.IsDBNull(FLD_BASEMENT3)) { bDProjectParkingEntity.Basement3 = null; } else { bDProjectParkingEntity.Basement3 = reader.GetDecimal(FLD_BASEMENT3); }
            if (reader.IsDBNull(FLD_BASEMENT4)) { bDProjectParkingEntity.Basement4 = null; } else { bDProjectParkingEntity.Basement4 = reader.GetDecimal(FLD_BASEMENT4); }
            if (reader.IsDBNull(FLD_BASEMENT5)) { bDProjectParkingEntity.Basement5 = null; } else { bDProjectParkingEntity.Basement5 = reader.GetDecimal(FLD_BASEMENT5); }
            if (reader.IsDBNull(FLD_BASEMENT6)) { bDProjectParkingEntity.Basement6 = null; } else { bDProjectParkingEntity.Basement6 = reader.GetDecimal(FLD_BASEMENT6); }
            if (reader.IsDBNull(FLD_OUTDOOR)) { bDProjectParkingEntity.Outdoor = null; } else { bDProjectParkingEntity.Outdoor = reader.GetDecimal(FLD_OUTDOOR); }
            bDProjectParkingEntity.Total = reader.GetDecimal(FLD_TOTAL);
            bDProjectParkingEntity.GuestParking = reader.GetDecimal(FLD_GUESTPARKING);
            if (reader.IsDBNull(FLD_DISABLEPARKING)) { bDProjectParkingEntity.DisableParking = null; } else { bDProjectParkingEntity.DisableParking = reader.GetDecimal(FLD_DISABLEPARKING); }

            return bDProjectParkingEntity;
        }
    }
}
