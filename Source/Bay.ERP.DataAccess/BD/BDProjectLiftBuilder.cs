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
    internal sealed class BDProjectLiftBuilder : IEntityBuilder<BDProjectLiftEntity>
    {
        IList<BDProjectLiftEntity> IEntityBuilder<BDProjectLiftEntity>.BuildEntities(IDataReader reader)
        {
            List<BDProjectLiftEntity> BDProjectLiftEntityList = new List<BDProjectLiftEntity>();

            while (reader.Read())
            {
                BDProjectLiftEntityList.Add(((IEntityBuilder<BDProjectLiftEntity>)this).BuildEntity(reader));
            }

            return (BDProjectLiftEntityList.Count > 0) ? BDProjectLiftEntityList : null;
        }

        BDProjectLiftEntity IEntityBuilder<BDProjectLiftEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTLIFTID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_NUMBEROFLIFT = 2;
            const Int32 FLD_LIFTBRANDID =3;
            const Int32 FLD_LIFTBRANDSUPPLIERID = 4;
            const Int32 FLD_NUMBEROFPASSENGERLIFT = 5;
            const Int32 FLD_PASSENGERLIFTBRANDID = 6;
            const Int32 FLD_PASSENGERLIFTBRANDSUPPLIERID = 7;
            const Int32 FLD_CAPACITYOFPASSENGERLIFT = 8;
            const Int32 FLD_NUMBEROFSERVICELIFT = 9;
            const Int32 FLD_SERVICELIFTBRANDID = 10;
            const Int32 FLD_SERVICELIFTBRANDSUPPLIERID = 11;
            const Int32 FLD_CAPACITYOFSERVICELIFT = 12;
            const Int32 FLD_NUMBEROFFIREFIGHTERLIFT = 13;
            const Int32 FLD_BRANDID = 14;
            const Int32 FLD_BRANDSUPPLIERID = 15;

            BDProjectLiftEntity bDProjectLiftEntity = new BDProjectLiftEntity();

            bDProjectLiftEntity.ProjectLiftID = reader.GetInt64(FLD_PROJECTLIFTID);
            bDProjectLiftEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            bDProjectLiftEntity.NumberOfLift = reader.GetDecimal(FLD_NUMBEROFLIFT);
            if (reader.IsDBNull(FLD_LIFTBRANDID)) { bDProjectLiftEntity.LiftBrandID = null; } else { bDProjectLiftEntity.LiftBrandID = reader.GetInt64(FLD_LIFTBRANDID); }
            if (reader.IsDBNull(FLD_LIFTBRANDSUPPLIERID)) { bDProjectLiftEntity.LiftBrandSupplierID = null; } else { bDProjectLiftEntity.LiftBrandSupplierID = reader.GetInt64(FLD_LIFTBRANDSUPPLIERID); }
            bDProjectLiftEntity.NumberOfPassengerLift = reader.GetDecimal(FLD_NUMBEROFPASSENGERLIFT);
            if (reader.IsDBNull(FLD_PASSENGERLIFTBRANDID)) { bDProjectLiftEntity.PassengerLiftBrandID = null; } else { bDProjectLiftEntity.PassengerLiftBrandID = reader.GetInt64(FLD_PASSENGERLIFTBRANDID); }
            if (reader.IsDBNull(FLD_PASSENGERLIFTBRANDSUPPLIERID)) { bDProjectLiftEntity.PassengerLiftBrandSupplierID = null; } else { bDProjectLiftEntity.PassengerLiftBrandSupplierID = reader.GetInt64(FLD_PASSENGERLIFTBRANDSUPPLIERID); }
            if (reader.IsDBNull(FLD_CAPACITYOFPASSENGERLIFT)) { bDProjectLiftEntity.CapacityOfPassengerLift = null; } else { bDProjectLiftEntity.CapacityOfPassengerLift = reader.GetDecimal(FLD_CAPACITYOFPASSENGERLIFT); }
            if (reader.IsDBNull(FLD_NUMBEROFSERVICELIFT)) { bDProjectLiftEntity.NumberOfServiceLift = null; } else { bDProjectLiftEntity.NumberOfServiceLift = reader.GetDecimal(FLD_NUMBEROFSERVICELIFT); }
            if (reader.IsDBNull(FLD_SERVICELIFTBRANDID)) { bDProjectLiftEntity.ServiceLiftBrandID = null; } else { bDProjectLiftEntity.ServiceLiftBrandID = reader.GetInt64(FLD_SERVICELIFTBRANDID); }
            if (reader.IsDBNull(FLD_SERVICELIFTBRANDSUPPLIERID)) { bDProjectLiftEntity.ServiceLiftBrandSupplierID = null; } else { bDProjectLiftEntity.ServiceLiftBrandSupplierID = reader.GetInt64(FLD_SERVICELIFTBRANDSUPPLIERID); }
            if (reader.IsDBNull(FLD_CAPACITYOFSERVICELIFT)) { bDProjectLiftEntity.CapacityOfServiceLift = null; } else { bDProjectLiftEntity.CapacityOfServiceLift = reader.GetDecimal(FLD_CAPACITYOFSERVICELIFT); }
            if (reader.IsDBNull(FLD_NUMBEROFFIREFIGHTERLIFT)) { bDProjectLiftEntity.NumberOfFireFighterLift = null; } else { bDProjectLiftEntity.NumberOfFireFighterLift = reader.GetDecimal(FLD_NUMBEROFFIREFIGHTERLIFT); }
            bDProjectLiftEntity.BrandID = reader.GetInt64(FLD_BRANDID);
            if (reader.IsDBNull(FLD_BRANDSUPPLIERID)) { bDProjectLiftEntity.BrandSupplierID = null; } else { bDProjectLiftEntity.BrandSupplierID = reader.GetInt64(FLD_BRANDSUPPLIERID); }

            return bDProjectLiftEntity;
        }
    }
}
