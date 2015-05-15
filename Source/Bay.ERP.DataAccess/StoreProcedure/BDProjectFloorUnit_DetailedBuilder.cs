// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Apr-2013, 03:03:13




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDProjectFloorUnit_DetailedBuilder : IEntityBuilder<BDProjectFloorUnit_DetailedEntity>
    {
        IList<BDProjectFloorUnit_DetailedEntity> IEntityBuilder<BDProjectFloorUnit_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<BDProjectFloorUnit_DetailedEntity> BDProjectFloorUnit_DetailedEntityList = new List<BDProjectFloorUnit_DetailedEntity>();

            while (reader.Read())
            {
                BDProjectFloorUnit_DetailedEntityList.Add(((IEntityBuilder<BDProjectFloorUnit_DetailedEntity>)this).BuildEntity(reader));
            }

            return (BDProjectFloorUnit_DetailedEntityList.Count > 0) ? BDProjectFloorUnit_DetailedEntityList : null;
        }

        BDProjectFloorUnit_DetailedEntity IEntityBuilder<BDProjectFloorUnit_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTFLOORUNITID = 0;
            const Int32 FLD_PROJECTFLOORID = 1;
            const Int32 FLD_PROJECTFLOORNAME = 2;
            const Int32 FLD_PROJECTFLOORUNITTYPEID = 3;
            const Int32 FLD_ProjectFloorUnitTypeName = 4;
            const Int32 FLD_PROJECTFLOORUNITNAME = 5;
            const Int32 FLD_PROJECTFLOORUNITSTATUSID = 6;
            const Int32 FLD_PROJECTFLOORUNITSTATUSNAME = 7;
            const Int32 FLD_UNITAREA = 8;
            const Int32 FLD_TOTALAREA = 9;
            const Int32 FLD_REGISTEREDAREA = 10;
            const Int32 FLD_FACING = 11;
            const Int32 FLD_TOILET = 12;
            const Int32 FLD_KITCHEN = 13;
            const Int32 FLD_PARKING = 14;
            const Int32 FLD_BATHROOM = 15;
            const Int32 FLD_BEDROOM = 16;
            const Int32 FLD_SERVANTBED = 17;
            const Int32 FLD_SERVANTTOILET = 18;
            const Int32 FLD_CORRIDOR = 19;
            const Int32 FLD_TAPASGARDEN = 20;
            const Int32 FLD_SWIMMINGPOOL = 21;
            const Int32 FLD_ISIDSERVICEAVAILABLE = 22;
            const Int32 FLD_ELECTRICITYSERVICE = 23;
            const Int32 FLD_COMMONGENERATOR = 24;
            const Int32 FLD_PRICEPERSFT = 25;
            const Int32 FLD_AREAPRICE = 26;
            const Int32 FLD_IDPRICE = 27;
            const Int32 FLD_ADDITIONALCHARGES = 28;
            const Int32 FLD_FEATURES = 29;
            const Int32 FLD_CIVILDRAWINGIMAGEURL = 30;
            const Int32 FLD_ELECTRICALDRAWINGIMAGEURL = 31;
            const Int32 FLD_INTERIORDRAWINGIMAGEURL = 32;
            const Int32 FLD_MECHANICALDRAWINGIMAGEURL = 33;
            const Int32 FLD_PLUMBINGDRAWINGIMAGEURL = 34;
            const Int32 FLD_OTHERSDRAWINGIMAGEURL = 35;
            const Int32 FLD_PROJECTID = 36;
            const Int32 FLD_PROJECTCODE = 37;
            const Int32 FLD_PROJECTNAME = 38;
            const Int32 FLD_FOYER = 39;
            const Int32 FLD_SITTINGROOM = 40;
            const Int32 FLD_DININGROOM = 41;
            const Int32 FLD_PANTRY = 42;
            const Int32 FLD_BREAKFASTCORNER = 43;
            const Int32 FLD_STUDYROOM = 44;
            const Int32 FLD_STUDY = 45;
            const Int32 FLD_VERANDAH = 46;
            const Int32 FLD_WATERSUPPLYAVAILABLE = 47;
            const Int32 FLD_ROWNUMBER = 48;
                        
            

            BDProjectFloorUnit_DetailedEntity bDProjectFloorUnit_DetailedEntity = new BDProjectFloorUnit_DetailedEntity();

            bDProjectFloorUnit_DetailedEntity.ProjectFloorUnitID = reader.GetInt64(FLD_PROJECTFLOORUNITID);
            bDProjectFloorUnit_DetailedEntity.ProjectFloorID = reader.GetInt64(FLD_PROJECTFLOORID);
            bDProjectFloorUnit_DetailedEntity.ProjectFloorName = reader.GetString(FLD_PROJECTFLOORNAME);
            bDProjectFloorUnit_DetailedEntity.ProjectFloorUnitTypeID = reader.GetInt64(FLD_PROJECTFLOORUNITTYPEID);
            bDProjectFloorUnit_DetailedEntity.ProjectFloorUnitTypeName = reader.GetString(FLD_ProjectFloorUnitTypeName);
            bDProjectFloorUnit_DetailedEntity.ProjectFloorUnitName = reader.GetString(FLD_PROJECTFLOORUNITNAME);
            bDProjectFloorUnit_DetailedEntity.ProjectFloorUnitStatusID = reader.GetInt64(FLD_PROJECTFLOORUNITSTATUSID);
            bDProjectFloorUnit_DetailedEntity.ProjectFloorUnitStatusName = reader.GetString(FLD_PROJECTFLOORUNITSTATUSNAME);
            bDProjectFloorUnit_DetailedEntity.UnitArea = reader.GetDecimal(FLD_UNITAREA);
            bDProjectFloorUnit_DetailedEntity.TotalArea = reader.GetDecimal(FLD_TOTALAREA);
            if (reader.IsDBNull(FLD_REGISTEREDAREA)) { bDProjectFloorUnit_DetailedEntity.RegisteredArea = null; } else { bDProjectFloorUnit_DetailedEntity.RegisteredArea = reader.GetDecimal(FLD_REGISTEREDAREA); }
            bDProjectFloorUnit_DetailedEntity.Facing = reader.GetString(FLD_FACING);
            bDProjectFloorUnit_DetailedEntity.Toilet = reader.GetDecimal(FLD_TOILET);
            bDProjectFloorUnit_DetailedEntity.Kitchen = reader.GetDecimal(FLD_KITCHEN);
            bDProjectFloorUnit_DetailedEntity.Parking = reader.GetDecimal(FLD_PARKING);
            bDProjectFloorUnit_DetailedEntity.BathRoom = reader.GetDecimal(FLD_BATHROOM);
            bDProjectFloorUnit_DetailedEntity.BedRoom = reader.GetDecimal(FLD_BEDROOM);
            bDProjectFloorUnit_DetailedEntity.ServantBed = reader.GetDecimal(FLD_SERVANTBED);
            bDProjectFloorUnit_DetailedEntity.ServantToilet = reader.GetDecimal(FLD_SERVANTTOILET);
            bDProjectFloorUnit_DetailedEntity.Corridor = reader.GetDecimal(FLD_CORRIDOR);
            bDProjectFloorUnit_DetailedEntity.TapasGarden = reader.GetDecimal(FLD_TAPASGARDEN);
            bDProjectFloorUnit_DetailedEntity.SwimmingPool = reader.GetDecimal(FLD_SWIMMINGPOOL);
            bDProjectFloorUnit_DetailedEntity.IsIDServiceAvailable = reader.GetBoolean(FLD_ISIDSERVICEAVAILABLE);
            bDProjectFloorUnit_DetailedEntity.ElectricityService = reader.GetBoolean(FLD_ELECTRICITYSERVICE);
            bDProjectFloorUnit_DetailedEntity.CommonGenerator = reader.GetBoolean(FLD_COMMONGENERATOR);
            if (reader.IsDBNull(FLD_PRICEPERSFT)) { bDProjectFloorUnit_DetailedEntity.PricePerSft = null; } else { bDProjectFloorUnit_DetailedEntity.PricePerSft = reader.GetDecimal(FLD_PRICEPERSFT); }
            if (reader.IsDBNull(FLD_AREAPRICE)) { bDProjectFloorUnit_DetailedEntity.AreaPrice = null; } else { bDProjectFloorUnit_DetailedEntity.AreaPrice = reader.GetDecimal(FLD_AREAPRICE); }
            if (reader.IsDBNull(FLD_IDPRICE)) { bDProjectFloorUnit_DetailedEntity.IDPrice = null; } else { bDProjectFloorUnit_DetailedEntity.IDPrice = reader.GetDecimal(FLD_IDPRICE); }
            if (reader.IsDBNull(FLD_ADDITIONALCHARGES)) { bDProjectFloorUnit_DetailedEntity.AdditionalCharges = null; } else { bDProjectFloorUnit_DetailedEntity.AdditionalCharges = reader.GetDecimal(FLD_ADDITIONALCHARGES); }
            if (reader.IsDBNull(FLD_FEATURES)) { bDProjectFloorUnit_DetailedEntity.Features = String.Empty; } else { bDProjectFloorUnit_DetailedEntity.Features = reader.GetString(FLD_FEATURES); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { bDProjectFloorUnit_DetailedEntity.RowNumber = null; } else { bDProjectFloorUnit_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }
            if (reader.IsDBNull(FLD_CIVILDRAWINGIMAGEURL)) { bDProjectFloorUnit_DetailedEntity.CivilDrawingImageUrl = String.Empty; } else { bDProjectFloorUnit_DetailedEntity.CivilDrawingImageUrl = reader.GetString(FLD_CIVILDRAWINGIMAGEURL); }
            if (reader.IsDBNull(FLD_ELECTRICALDRAWINGIMAGEURL)) { bDProjectFloorUnit_DetailedEntity.ElectricalDrawingImageUrl = String.Empty; } else { bDProjectFloorUnit_DetailedEntity.ElectricalDrawingImageUrl = reader.GetString(FLD_ELECTRICALDRAWINGIMAGEURL); }
            if (reader.IsDBNull(FLD_INTERIORDRAWINGIMAGEURL)) { bDProjectFloorUnit_DetailedEntity.InteriorDrawingImageUrl = String.Empty; } else { bDProjectFloorUnit_DetailedEntity.InteriorDrawingImageUrl = reader.GetString(FLD_INTERIORDRAWINGIMAGEURL); }
            if (reader.IsDBNull(FLD_MECHANICALDRAWINGIMAGEURL)) { bDProjectFloorUnit_DetailedEntity.MechanicalDrawingImageUrl = String.Empty; } else { bDProjectFloorUnit_DetailedEntity.MechanicalDrawingImageUrl = reader.GetString(FLD_MECHANICALDRAWINGIMAGEURL); }
            if (reader.IsDBNull(FLD_PLUMBINGDRAWINGIMAGEURL)) { bDProjectFloorUnit_DetailedEntity.PlumbingDrawingImageUrl = String.Empty; } else { bDProjectFloorUnit_DetailedEntity.PlumbingDrawingImageUrl = reader.GetString(FLD_PLUMBINGDRAWINGIMAGEURL); }
            if (reader.IsDBNull(FLD_OTHERSDRAWINGIMAGEURL)) { bDProjectFloorUnit_DetailedEntity.OthersDrawingImageUrl = String.Empty; } else { bDProjectFloorUnit_DetailedEntity.OthersDrawingImageUrl = reader.GetString(FLD_OTHERSDRAWINGIMAGEURL); }
            bDProjectFloorUnit_DetailedEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            bDProjectFloorUnit_DetailedEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE);
            bDProjectFloorUnit_DetailedEntity.ProjectName = reader.GetString(FLD_PROJECTNAME);
            if (reader.IsDBNull(FLD_FOYER)) { bDProjectFloorUnit_DetailedEntity.Foyer = null; } else { bDProjectFloorUnit_DetailedEntity.Foyer = reader.GetDecimal(FLD_FOYER); }
            if (reader.IsDBNull(FLD_SITTINGROOM)) { bDProjectFloorUnit_DetailedEntity.SittingRoom = null; } else { bDProjectFloorUnit_DetailedEntity.SittingRoom = reader.GetDecimal(FLD_SITTINGROOM); }
            if (reader.IsDBNull(FLD_DININGROOM)) { bDProjectFloorUnit_DetailedEntity.DiningRoom = null; } else { bDProjectFloorUnit_DetailedEntity.DiningRoom = reader.GetDecimal(FLD_DININGROOM); }
            if (reader.IsDBNull(FLD_PANTRY)) { bDProjectFloorUnit_DetailedEntity.Pantry = null; } else { bDProjectFloorUnit_DetailedEntity.Pantry = reader.GetDecimal(FLD_PANTRY); }
            if (reader.IsDBNull(FLD_BREAKFASTCORNER)) { bDProjectFloorUnit_DetailedEntity.BreakfastCorner = null; } else { bDProjectFloorUnit_DetailedEntity.BreakfastCorner = reader.GetDecimal(FLD_BREAKFASTCORNER); }
            if (reader.IsDBNull(FLD_STUDYROOM)) { bDProjectFloorUnit_DetailedEntity.StudyRoom = null; } else { bDProjectFloorUnit_DetailedEntity.StudyRoom = reader.GetDecimal(FLD_STUDYROOM); }
            if (reader.IsDBNull(FLD_STUDY)) { bDProjectFloorUnit_DetailedEntity.Study = null; } else { bDProjectFloorUnit_DetailedEntity.Study = reader.GetDecimal(FLD_STUDY); }
            if (reader.IsDBNull(FLD_VERANDAH)) { bDProjectFloorUnit_DetailedEntity.Verandah = null; } else { bDProjectFloorUnit_DetailedEntity.Verandah = reader.GetDecimal(FLD_VERANDAH); }
            if (reader.IsDBNull(FLD_WATERSUPPLYAVAILABLE)) { bDProjectFloorUnit_DetailedEntity.WaterSupplyAvailable = null; } else { bDProjectFloorUnit_DetailedEntity.WaterSupplyAvailable = reader.GetBoolean(FLD_WATERSUPPLYAVAILABLE); }
            return bDProjectFloorUnit_DetailedEntity;
        }
    }
}
