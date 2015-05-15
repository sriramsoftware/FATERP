// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Jul-2013, 09:56:00




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDProjectFloorUnit_RPTBuilder : IEntityBuilder<BDProjectFloorUnit_RPTEntity>
    {
        IList<BDProjectFloorUnit_RPTEntity> IEntityBuilder<BDProjectFloorUnit_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<BDProjectFloorUnit_RPTEntity> BDProjectFloorUnit_RPTEntityList = new List<BDProjectFloorUnit_RPTEntity>();

            while (reader.Read())
            {
                BDProjectFloorUnit_RPTEntityList.Add(((IEntityBuilder<BDProjectFloorUnit_RPTEntity>)this).BuildEntity(reader));
            }

            return (BDProjectFloorUnit_RPTEntityList.Count > 0) ? BDProjectFloorUnit_RPTEntityList : null;
        }

        BDProjectFloorUnit_RPTEntity IEntityBuilder<BDProjectFloorUnit_RPTEntity>.BuildEntity(IDataReader reader)
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

            BDProjectFloorUnit_RPTEntity bDProjectFloorUnit_RPTEntity = new BDProjectFloorUnit_RPTEntity();

            bDProjectFloorUnit_RPTEntity.ProjectFloorUnitID = reader.GetInt64(FLD_PROJECTFLOORUNITID);
            bDProjectFloorUnit_RPTEntity.ProjectFloorID = reader.GetInt64(FLD_PROJECTFLOORID);
            bDProjectFloorUnit_RPTEntity.ProjectFloorName = reader.GetString(FLD_PROJECTFLOORNAME);
            bDProjectFloorUnit_RPTEntity.ProjectFloorUnitTypeID = reader.GetInt64(FLD_PROJECTFLOORUNITTYPEID);
            bDProjectFloorUnit_RPTEntity.ProjectFloorUnitTypeName = reader.GetString(FLD_ProjectFloorUnitTypeName);
            bDProjectFloorUnit_RPTEntity.ProjectFloorUnitName = reader.GetString(FLD_PROJECTFLOORUNITNAME);
            bDProjectFloorUnit_RPTEntity.ProjectFloorUnitStatusID = reader.GetInt64(FLD_PROJECTFLOORUNITSTATUSID);
            bDProjectFloorUnit_RPTEntity.ProjectFloorUnitStatusName = reader.GetString(FLD_PROJECTFLOORUNITSTATUSNAME);
            bDProjectFloorUnit_RPTEntity.UnitArea = reader.GetDecimal(FLD_UNITAREA);
            bDProjectFloorUnit_RPTEntity.TotalArea = reader.GetDecimal(FLD_TOTALAREA);
            if (reader.IsDBNull(FLD_REGISTEREDAREA)) { bDProjectFloorUnit_RPTEntity.RegisteredArea = null; } else { bDProjectFloorUnit_RPTEntity.RegisteredArea = reader.GetDecimal(FLD_REGISTEREDAREA); }
            bDProjectFloorUnit_RPTEntity.Facing = reader.GetString(FLD_FACING);
            bDProjectFloorUnit_RPTEntity.Toilet = reader.GetDecimal(FLD_TOILET);
            bDProjectFloorUnit_RPTEntity.Kitchen = reader.GetDecimal(FLD_KITCHEN);
            bDProjectFloorUnit_RPTEntity.Parking = reader.GetDecimal(FLD_PARKING);
            bDProjectFloorUnit_RPTEntity.BathRoom = reader.GetDecimal(FLD_BATHROOM);
            bDProjectFloorUnit_RPTEntity.BedRoom = reader.GetDecimal(FLD_BEDROOM);
            bDProjectFloorUnit_RPTEntity.ServantBed = reader.GetDecimal(FLD_SERVANTBED);
            bDProjectFloorUnit_RPTEntity.ServantToilet = reader.GetDecimal(FLD_SERVANTTOILET);
            bDProjectFloorUnit_RPTEntity.Corridor = reader.GetDecimal(FLD_CORRIDOR);
            bDProjectFloorUnit_RPTEntity.TapasGarden = reader.GetDecimal(FLD_TAPASGARDEN);
            bDProjectFloorUnit_RPTEntity.SwimmingPool = reader.GetDecimal(FLD_SWIMMINGPOOL);
            bDProjectFloorUnit_RPTEntity.IsIDServiceAvailable = reader.GetBoolean(FLD_ISIDSERVICEAVAILABLE);
            bDProjectFloorUnit_RPTEntity.ElectricityService = reader.GetBoolean(FLD_ELECTRICITYSERVICE);
            bDProjectFloorUnit_RPTEntity.CommonGenerator = reader.GetBoolean(FLD_COMMONGENERATOR);
            if (reader.IsDBNull(FLD_PRICEPERSFT)) { bDProjectFloorUnit_RPTEntity.PricePerSft = null; } else { bDProjectFloorUnit_RPTEntity.PricePerSft = reader.GetDecimal(FLD_PRICEPERSFT); }
            if (reader.IsDBNull(FLD_AREAPRICE)) { bDProjectFloorUnit_RPTEntity.AreaPrice = null; } else { bDProjectFloorUnit_RPTEntity.AreaPrice = reader.GetDecimal(FLD_AREAPRICE); }
            if (reader.IsDBNull(FLD_IDPRICE)) { bDProjectFloorUnit_RPTEntity.IDPrice = null; } else { bDProjectFloorUnit_RPTEntity.IDPrice = reader.GetDecimal(FLD_IDPRICE); }
            if (reader.IsDBNull(FLD_ADDITIONALCHARGES)) { bDProjectFloorUnit_RPTEntity.AdditionalCharges = null; } else { bDProjectFloorUnit_RPTEntity.AdditionalCharges = reader.GetDecimal(FLD_ADDITIONALCHARGES); }
            if (reader.IsDBNull(FLD_FEATURES)) { bDProjectFloorUnit_RPTEntity.Features = String.Empty; } else { bDProjectFloorUnit_RPTEntity.Features = reader.GetString(FLD_FEATURES); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { bDProjectFloorUnit_RPTEntity.RowNumber = null; } else { bDProjectFloorUnit_RPTEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }
            if (reader.IsDBNull(FLD_CIVILDRAWINGIMAGEURL)) { bDProjectFloorUnit_RPTEntity.CivilDrawingImageUrl = String.Empty; } else { bDProjectFloorUnit_RPTEntity.CivilDrawingImageUrl = reader.GetString(FLD_CIVILDRAWINGIMAGEURL); }
            if (reader.IsDBNull(FLD_ELECTRICALDRAWINGIMAGEURL)) { bDProjectFloorUnit_RPTEntity.ElectricalDrawingImageUrl = String.Empty; } else { bDProjectFloorUnit_RPTEntity.ElectricalDrawingImageUrl = reader.GetString(FLD_ELECTRICALDRAWINGIMAGEURL); }
            if (reader.IsDBNull(FLD_INTERIORDRAWINGIMAGEURL)) { bDProjectFloorUnit_RPTEntity.InteriorDrawingImageUrl = String.Empty; } else { bDProjectFloorUnit_RPTEntity.InteriorDrawingImageUrl = reader.GetString(FLD_INTERIORDRAWINGIMAGEURL); }
            if (reader.IsDBNull(FLD_MECHANICALDRAWINGIMAGEURL)) { bDProjectFloorUnit_RPTEntity.MechanicalDrawingImageUrl = String.Empty; } else { bDProjectFloorUnit_RPTEntity.MechanicalDrawingImageUrl = reader.GetString(FLD_MECHANICALDRAWINGIMAGEURL); }
            if (reader.IsDBNull(FLD_PLUMBINGDRAWINGIMAGEURL)) { bDProjectFloorUnit_RPTEntity.PlumbingDrawingImageUrl = String.Empty; } else { bDProjectFloorUnit_RPTEntity.PlumbingDrawingImageUrl = reader.GetString(FLD_PLUMBINGDRAWINGIMAGEURL); }
            if (reader.IsDBNull(FLD_OTHERSDRAWINGIMAGEURL)) { bDProjectFloorUnit_RPTEntity.OthersDrawingImageUrl = String.Empty; } else { bDProjectFloorUnit_RPTEntity.OthersDrawingImageUrl = reader.GetString(FLD_OTHERSDRAWINGIMAGEURL); }
            bDProjectFloorUnit_RPTEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            bDProjectFloorUnit_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE);
            bDProjectFloorUnit_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME);
            if (reader.IsDBNull(FLD_FOYER)) { bDProjectFloorUnit_RPTEntity.Foyer = null; } else { bDProjectFloorUnit_RPTEntity.Foyer = reader.GetDecimal(FLD_FOYER); }
            if (reader.IsDBNull(FLD_SITTINGROOM)) { bDProjectFloorUnit_RPTEntity.SittingRoom = null; } else { bDProjectFloorUnit_RPTEntity.SittingRoom = reader.GetDecimal(FLD_SITTINGROOM); }
            if (reader.IsDBNull(FLD_DININGROOM)) { bDProjectFloorUnit_RPTEntity.DiningRoom = null; } else { bDProjectFloorUnit_RPTEntity.DiningRoom = reader.GetDecimal(FLD_DININGROOM); }
            if (reader.IsDBNull(FLD_PANTRY)) { bDProjectFloorUnit_RPTEntity.Pantry = null; } else { bDProjectFloorUnit_RPTEntity.Pantry = reader.GetDecimal(FLD_PANTRY); }
            if (reader.IsDBNull(FLD_BREAKFASTCORNER)) { bDProjectFloorUnit_RPTEntity.BreakfastCorner = null; } else { bDProjectFloorUnit_RPTEntity.BreakfastCorner = reader.GetDecimal(FLD_BREAKFASTCORNER); }
            if (reader.IsDBNull(FLD_STUDYROOM)) { bDProjectFloorUnit_RPTEntity.StudyRoom = null; } else { bDProjectFloorUnit_RPTEntity.StudyRoom = reader.GetDecimal(FLD_STUDYROOM); }
            if (reader.IsDBNull(FLD_STUDY)) { bDProjectFloorUnit_RPTEntity.Study = null; } else { bDProjectFloorUnit_RPTEntity.Study = reader.GetDecimal(FLD_STUDY); }
            if (reader.IsDBNull(FLD_VERANDAH)) { bDProjectFloorUnit_RPTEntity.Verandah = null; } else { bDProjectFloorUnit_RPTEntity.Verandah = reader.GetDecimal(FLD_VERANDAH); }
            if (reader.IsDBNull(FLD_WATERSUPPLYAVAILABLE)) { bDProjectFloorUnit_RPTEntity.WaterSupplyAvailable = null; } else { bDProjectFloorUnit_RPTEntity.WaterSupplyAvailable = reader.GetBoolean(FLD_WATERSUPPLYAVAILABLE); }

            return bDProjectFloorUnit_RPTEntity;
        }
    }
}
