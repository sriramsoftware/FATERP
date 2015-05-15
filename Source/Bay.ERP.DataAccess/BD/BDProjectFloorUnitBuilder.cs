// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Oct-2013, 03:32:47




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDProjectFloorUnitBuilder : IEntityBuilder<BDProjectFloorUnitEntity>
    {
        IList<BDProjectFloorUnitEntity> IEntityBuilder<BDProjectFloorUnitEntity>.BuildEntities(IDataReader reader)
        {
            List<BDProjectFloorUnitEntity> BDProjectFloorUnitEntityList = new List<BDProjectFloorUnitEntity>();

            while (reader.Read())
            {
                BDProjectFloorUnitEntityList.Add(((IEntityBuilder<BDProjectFloorUnitEntity>)this).BuildEntity(reader));
            }

            return (BDProjectFloorUnitEntityList.Count > 0) ? BDProjectFloorUnitEntityList : null;
        }

        BDProjectFloorUnitEntity IEntityBuilder<BDProjectFloorUnitEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTFLOORUNITID = 0;
            const Int32 FLD_PROJECTFLOORID = 1;
            const Int32 FLD_PROJECTFLOORUNITTYPEID = 2;
            const Int32 FLD_PROJECTFLOORUNITNAME = 3;
            const Int32 FLD_PROJECTFLOORUNITSTATUSID = 4;
            const Int32 FLD_UNITAREA = 5;
            const Int32 FLD_TOTALAREA = 6;
            const Int32 FLD_REGISTEREDAREA = 7;
            const Int32 FLD_FACING = 8;
            const Int32 FLD_TOILET = 9;
            const Int32 FLD_KITCHEN = 10;
            const Int32 FLD_PARKING = 11;
            const Int32 FLD_BATHROOM = 12;
            const Int32 FLD_BEDROOM = 13;
            const Int32 FLD_SERVANTBED = 14;
            const Int32 FLD_SERVANTTOILET = 15;
            const Int32 FLD_CORRIDOR = 16;
            const Int32 FLD_TAPASGARDEN = 17;
            const Int32 FLD_SWIMMINGPOOL = 18;
            const Int32 FLD_ISIDSERVICEAVAILABLE = 19;
            const Int32 FLD_ELECTRICITYSERVICE = 20;
            const Int32 FLD_COMMONGENERATOR = 21;
            const Int32 FLD_PRICEPERSFT = 22;
            const Int32 FLD_AREAPRICE = 23;
            const Int32 FLD_IDPRICE = 24;
            const Int32 FLD_ADDITIONALCHARGES = 25;
            const Int32 FLD_FEATURES = 26;
            const Int32 FLD_CIVILDRAWINGIMAGEURL = 27;
            const Int32 FLD_ELECTRICALDRAWINGIMAGEURL = 28;
            const Int32 FLD_INTERIORDRAWINGIMAGEURL = 29;
            const Int32 FLD_MECHANICALDRAWINGIMAGEURL = 30;
            const Int32 FLD_PLUMBINGDRAWINGIMAGEURL = 31;
            const Int32 FLD_OTHERSDRAWINGIMAGEURL = 32;
            const Int32 FLD_FOYER = 33; 
            const Int32 FLD_SITTINGROOM = 34;
            const Int32 FLD_DININGROOM = 35;
            const Int32 FLD_PANTRY = 36; 
            const Int32 FLD_BREAKFASTCORNER = 37; 
            const Int32 FLD_STUDYROOM = 38;
            const Int32 FLD_STUDY = 39;
            const Int32 FLD_VERANDAH = 40;
            const Int32 FLD_WATERSUPPLYAVAILABLE = 41;
            const Int32 FLD_ISREMOVED = 42;

            BDProjectFloorUnitEntity bDProjectFloorUnitEntity = new BDProjectFloorUnitEntity();

            bDProjectFloorUnitEntity.ProjectFloorUnitID = reader.GetInt64(FLD_PROJECTFLOORUNITID);
            bDProjectFloorUnitEntity.ProjectFloorID = reader.GetInt64(FLD_PROJECTFLOORID);
            bDProjectFloorUnitEntity.ProjectFloorUnitTypeID = reader.GetInt64(FLD_PROJECTFLOORUNITTYPEID);
            bDProjectFloorUnitEntity.ProjectFloorUnitName = reader.GetString(FLD_PROJECTFLOORUNITNAME);
            bDProjectFloorUnitEntity.ProjectFloorUnitStatusID = reader.GetInt64(FLD_PROJECTFLOORUNITSTATUSID);
            bDProjectFloorUnitEntity.UnitArea = reader.GetDecimal(FLD_UNITAREA);
            bDProjectFloorUnitEntity.TotalArea = reader.GetDecimal(FLD_TOTALAREA);
            if (reader.IsDBNull(FLD_REGISTEREDAREA)) { bDProjectFloorUnitEntity.RegisteredArea = null; } else { bDProjectFloorUnitEntity.RegisteredArea = reader.GetDecimal(FLD_REGISTEREDAREA); }
            bDProjectFloorUnitEntity.Facing = reader.GetString(FLD_FACING);
            bDProjectFloorUnitEntity.Toilet = reader.GetDecimal(FLD_TOILET);
            bDProjectFloorUnitEntity.Kitchen = reader.GetDecimal(FLD_KITCHEN);
            bDProjectFloorUnitEntity.Parking = reader.GetDecimal(FLD_PARKING);
            bDProjectFloorUnitEntity.BathRoom = reader.GetDecimal(FLD_BATHROOM);
            bDProjectFloorUnitEntity.BedRoom = reader.GetDecimal(FLD_BEDROOM);
            bDProjectFloorUnitEntity.ServantBed = reader.GetDecimal(FLD_SERVANTBED);
            bDProjectFloorUnitEntity.ServantToilet = reader.GetDecimal(FLD_SERVANTTOILET);
            bDProjectFloorUnitEntity.Corridor = reader.GetDecimal(FLD_CORRIDOR);
            bDProjectFloorUnitEntity.TapasGarden = reader.GetDecimal(FLD_TAPASGARDEN);
            bDProjectFloorUnitEntity.SwimmingPool = reader.GetDecimal(FLD_SWIMMINGPOOL);
            if (reader.IsDBNull(FLD_FOYER)) { bDProjectFloorUnitEntity.Foyer = null; } else { bDProjectFloorUnitEntity.Foyer = reader.GetDecimal(FLD_FOYER); }
            if (reader.IsDBNull(FLD_SITTINGROOM)) { bDProjectFloorUnitEntity.SittingRoom = null; } else { bDProjectFloorUnitEntity.SittingRoom = reader.GetDecimal(FLD_SITTINGROOM); }
            if (reader.IsDBNull(FLD_DININGROOM)) { bDProjectFloorUnitEntity.DiningRoom = null; } else { bDProjectFloorUnitEntity.DiningRoom = reader.GetDecimal(FLD_DININGROOM); }
            if (reader.IsDBNull(FLD_PANTRY)) { bDProjectFloorUnitEntity.Pantry = null; } else { bDProjectFloorUnitEntity.Pantry = reader.GetDecimal(FLD_PANTRY); }
            if (reader.IsDBNull(FLD_BREAKFASTCORNER)) { bDProjectFloorUnitEntity.BreakfastCorner = null; } else { bDProjectFloorUnitEntity.BreakfastCorner = reader.GetDecimal(FLD_BREAKFASTCORNER); }
            if (reader.IsDBNull(FLD_STUDYROOM)) { bDProjectFloorUnitEntity.StudyRoom = null; } else { bDProjectFloorUnitEntity.StudyRoom = reader.GetDecimal(FLD_STUDYROOM); }
            if (reader.IsDBNull(FLD_STUDY)) { bDProjectFloorUnitEntity.Study = null; } else { bDProjectFloorUnitEntity.Study = reader.GetDecimal(FLD_STUDY); }
            if (reader.IsDBNull(FLD_VERANDAH)) { bDProjectFloorUnitEntity.Verandah = null; } else { bDProjectFloorUnitEntity.Verandah = reader.GetDecimal(FLD_VERANDAH); }
            bDProjectFloorUnitEntity.IsIDServiceAvailable = reader.GetBoolean(FLD_ISIDSERVICEAVAILABLE);
            bDProjectFloorUnitEntity.ElectricityService = reader.GetBoolean(FLD_ELECTRICITYSERVICE);
            bDProjectFloorUnitEntity.CommonGenerator = reader.GetBoolean(FLD_COMMONGENERATOR);
            if (reader.IsDBNull(FLD_WATERSUPPLYAVAILABLE)) { bDProjectFloorUnitEntity.WaterSupplyAvailable = null; } else { bDProjectFloorUnitEntity.WaterSupplyAvailable = reader.GetBoolean(FLD_WATERSUPPLYAVAILABLE); }
            if (reader.IsDBNull(FLD_PRICEPERSFT)) { bDProjectFloorUnitEntity.PricePerSft = null; } else { bDProjectFloorUnitEntity.PricePerSft = reader.GetDecimal(FLD_PRICEPERSFT); }
            if (reader.IsDBNull(FLD_AREAPRICE)) { bDProjectFloorUnitEntity.AreaPrice = null; } else { bDProjectFloorUnitEntity.AreaPrice = reader.GetDecimal(FLD_AREAPRICE); }
            if (reader.IsDBNull(FLD_IDPRICE)) { bDProjectFloorUnitEntity.IDPrice = null; } else { bDProjectFloorUnitEntity.IDPrice = reader.GetDecimal(FLD_IDPRICE); }
            if (reader.IsDBNull(FLD_ADDITIONALCHARGES)) { bDProjectFloorUnitEntity.AdditionalCharges = null; } else { bDProjectFloorUnitEntity.AdditionalCharges = reader.GetDecimal(FLD_ADDITIONALCHARGES); }
            if (reader.IsDBNull(FLD_FEATURES)) { bDProjectFloorUnitEntity.Features = String.Empty; } else { bDProjectFloorUnitEntity.Features = reader.GetString(FLD_FEATURES); }
            if (reader.IsDBNull(FLD_CIVILDRAWINGIMAGEURL)) { bDProjectFloorUnitEntity.CivilDrawingImageUrl = String.Empty; } else { bDProjectFloorUnitEntity.CivilDrawingImageUrl = reader.GetString(FLD_CIVILDRAWINGIMAGEURL); }
            if (reader.IsDBNull(FLD_ELECTRICALDRAWINGIMAGEURL)) { bDProjectFloorUnitEntity.ElectricalDrawingImageUrl = String.Empty; } else { bDProjectFloorUnitEntity.ElectricalDrawingImageUrl = reader.GetString(FLD_ELECTRICALDRAWINGIMAGEURL); }
            if (reader.IsDBNull(FLD_INTERIORDRAWINGIMAGEURL)) { bDProjectFloorUnitEntity.InteriorDrawingImageUrl = String.Empty; } else { bDProjectFloorUnitEntity.InteriorDrawingImageUrl = reader.GetString(FLD_INTERIORDRAWINGIMAGEURL); }
            if (reader.IsDBNull(FLD_MECHANICALDRAWINGIMAGEURL)) { bDProjectFloorUnitEntity.MechanicalDrawingImageUrl = String.Empty; } else { bDProjectFloorUnitEntity.MechanicalDrawingImageUrl = reader.GetString(FLD_MECHANICALDRAWINGIMAGEURL); }
            if (reader.IsDBNull(FLD_PLUMBINGDRAWINGIMAGEURL)) { bDProjectFloorUnitEntity.PlumbingDrawingImageUrl = String.Empty; } else { bDProjectFloorUnitEntity.PlumbingDrawingImageUrl = reader.GetString(FLD_PLUMBINGDRAWINGIMAGEURL); }
            if (reader.IsDBNull(FLD_OTHERSDRAWINGIMAGEURL)) { bDProjectFloorUnitEntity.OthersDrawingImageUrl = String.Empty; } else { bDProjectFloorUnitEntity.OthersDrawingImageUrl = reader.GetString(FLD_OTHERSDRAWINGIMAGEURL); }
            bDProjectFloorUnitEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            

            return bDProjectFloorUnitEntity;
        }
    }
}
