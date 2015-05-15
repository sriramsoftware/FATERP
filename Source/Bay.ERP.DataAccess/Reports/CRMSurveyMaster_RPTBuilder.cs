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
    internal sealed class CRMSurveyMaster_RPTBuilder : IEntityBuilder<CRMSurveyMaster_RPTEntity>
    {
        IList<CRMSurveyMaster_RPTEntity> IEntityBuilder<CRMSurveyMaster_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMSurveyMaster_RPTEntity> CRMSurveyMaster_RPTEntityList = new List<CRMSurveyMaster_RPTEntity>();

            while (reader.Read())
            {
                CRMSurveyMaster_RPTEntityList.Add(((IEntityBuilder<CRMSurveyMaster_RPTEntity>)this).BuildEntity(reader));
            }

            return (CRMSurveyMaster_RPTEntityList.Count > 0) ? CRMSurveyMaster_RPTEntityList : null;
        }

        CRMSurveyMaster_RPTEntity IEntityBuilder<CRMSurveyMaster_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SURVEYID = 0;
            const Int32 FLD_SURVEYOWNERID = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_PLOTADDRESS = 3;
            const Int32 FLD_APPROXIMATEPLOTSIZE = 4;
            const Int32 FLD_AREAUNITID = 5;
            const Int32 FLD_APPROXIMATEFLOORSIZESFT = 6;
            const Int32 FLD_FLOORS = 7;
            const Int32 FLD_APPROXIMATETOTALSPACESFT = 8;
            const Int32 FLD_BASEMENTS = 9;
            const Int32 FLD_NOOFCARPARKING = 10;
            const Int32 FLD_ACSYSTEM = 11;
            const Int32 FLD_GENERATORBACKUP = 12;
            const Int32 FLD_LIFTSCAPACITY = 13;
            const Int32 FLD_TOILETSPERFLOOR = 14;
            const Int32 FLD_AVAILABLEFLOORSFT = 15;
            const Int32 FLD_AVAILABLEFOROCCUPANCY = 16;
            const Int32 FLD_RENTALRATEBDTPERSFT = 17;
            const Int32 FLD_SELLINGRATEBDTPERSFT = 18;
            const Int32 FLD_HANDOVERTIME = 19;
            const Int32 FLD_SURVEYBUILDINGSTATUSID = 20;
            const Int32 FLD_SURVEYSOURCEINFORMATIONID = 21;
            const Int32 FLD_SOURCEPERSONINFORMATION = 22;
            const Int32 FLD_CONTACTINFO = 23;
            const Int32 FLD_REMARKS = 24;
            const Int32 FLD_ADDITIONALREMARKS = 25;
            const Int32 FLD_OTHERSREMARKS = 26;
            const Int32 FLD_CREATEDATE = 27;
            const Int32 FLD_SURVEYDATE = 28;
            const Int32 FLD_IP = 29;
            const Int32 FLD_SURVEYBYEMPLOYEEID = 30;
            const Int32 FLD_CREATEBYEMPLOYEEID = 31;
            const Int32 FLD_SURVEYOWNERNAME = 32;
            const Int32 FLD_SURVEYBYEMPLOYEENAME = 33;
            const Int32 FLD_CREATEDBYEMPLOYEENAME = 34;
            const Int32 FLD_SURVEYOWNERTYPENAME = 35;
            const Int32 FLD_AREAUNITNAME = 36;
            const Int32 FLD_SURVEYBUILDINGSTATUSNAME = 37;
            const Int32 FLD_SURVEYSOURCEINFORMATIONNAME = 38;
            const Int32 FLD_ADDRESSLINE1 = 39;
            const Int32 FLD_CONTACTNO1 = 40;
            const Int32 FLD_EMAIL = 41;
            const Int32 FLD_SURVEYMASTERID = 42;
            const Int32 FLD_TITLE = 43;
            const Int32 FLD_STARTDATE = 44;
            const Int32 FLD_ENDDATE = 45;
            const Int32 FLD_SURVEYMASTERCREATEDATE = 46;
            const Int32 FLD_SURVEYMASTERCREATEDBYEMPLOYEEID = 47;
            const Int32 FLD_SURVEYMASTERCREATEDBYEMPLOYEE = 48;
            const Int32 FLD_AREAID = 49;
            const Int32 FLD_AREANAME = 50;

            CRMSurveyMaster_RPTEntity cRMSurveyMaster_RPTEntity = new CRMSurveyMaster_RPTEntity();

            cRMSurveyMaster_RPTEntity.SurveyID = reader.GetInt64(FLD_SURVEYID);
            cRMSurveyMaster_RPTEntity.SurveyOwnerID = reader.GetInt64(FLD_SURVEYOWNERID);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { cRMSurveyMaster_RPTEntity.Description = String.Empty; } else { cRMSurveyMaster_RPTEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            cRMSurveyMaster_RPTEntity.PlotAddress = reader.GetString(FLD_PLOTADDRESS);
            cRMSurveyMaster_RPTEntity.ApproximatePlotSize = reader.GetDecimal(FLD_APPROXIMATEPLOTSIZE);
            cRMSurveyMaster_RPTEntity.AreaUnitID = reader.GetInt64(FLD_AREAUNITID);
            cRMSurveyMaster_RPTEntity.ApproximateFloorSizeSft = reader.GetDecimal(FLD_APPROXIMATEFLOORSIZESFT);
            cRMSurveyMaster_RPTEntity.Floors = reader.GetDecimal(FLD_FLOORS);
            cRMSurveyMaster_RPTEntity.ApproximateTotalSpaceSft = reader.GetDecimal(FLD_APPROXIMATETOTALSPACESFT);
            if (reader.IsDBNull(FLD_BASEMENTS)) { cRMSurveyMaster_RPTEntity.Basements = String.Empty; } else { cRMSurveyMaster_RPTEntity.Basements = reader.GetString(FLD_BASEMENTS); }
            if (reader.IsDBNull(FLD_NOOFCARPARKING)) { cRMSurveyMaster_RPTEntity.NoOfCarParking = String.Empty; } else { cRMSurveyMaster_RPTEntity.NoOfCarParking = reader.GetString(FLD_NOOFCARPARKING); }
            if (reader.IsDBNull(FLD_ACSYSTEM)) { cRMSurveyMaster_RPTEntity.ACSystem = String.Empty; } else { cRMSurveyMaster_RPTEntity.ACSystem = reader.GetString(FLD_ACSYSTEM); }
            if (reader.IsDBNull(FLD_GENERATORBACKUP)) { cRMSurveyMaster_RPTEntity.GeneratorBackup = String.Empty; } else { cRMSurveyMaster_RPTEntity.GeneratorBackup = reader.GetString(FLD_GENERATORBACKUP); }
            if (reader.IsDBNull(FLD_LIFTSCAPACITY)) { cRMSurveyMaster_RPTEntity.LiftsCapacity = String.Empty; } else { cRMSurveyMaster_RPTEntity.LiftsCapacity = reader.GetString(FLD_LIFTSCAPACITY); }
            if (reader.IsDBNull(FLD_TOILETSPERFLOOR)) { cRMSurveyMaster_RPTEntity.ToiletsPerFloor = String.Empty; } else { cRMSurveyMaster_RPTEntity.ToiletsPerFloor = reader.GetString(FLD_TOILETSPERFLOOR); }
            if (reader.IsDBNull(FLD_AVAILABLEFLOORSFT)) { cRMSurveyMaster_RPTEntity.AvailableFloorSft = String.Empty; } else { cRMSurveyMaster_RPTEntity.AvailableFloorSft = reader.GetString(FLD_AVAILABLEFLOORSFT); }
            if (reader.IsDBNull(FLD_AVAILABLEFOROCCUPANCY)) { cRMSurveyMaster_RPTEntity.AvailableForOccupancy = String.Empty; } else { cRMSurveyMaster_RPTEntity.AvailableForOccupancy = reader.GetString(FLD_AVAILABLEFOROCCUPANCY); }
            if (reader.IsDBNull(FLD_RENTALRATEBDTPERSFT)) { cRMSurveyMaster_RPTEntity.RentalRateBDTPerSft = String.Empty; } else { cRMSurveyMaster_RPTEntity.RentalRateBDTPerSft = reader.GetString(FLD_RENTALRATEBDTPERSFT); }
            if (reader.IsDBNull(FLD_SELLINGRATEBDTPERSFT)) { cRMSurveyMaster_RPTEntity.SellingRateBDTPerSft = String.Empty; } else { cRMSurveyMaster_RPTEntity.SellingRateBDTPerSft = reader.GetString(FLD_SELLINGRATEBDTPERSFT); }
            if (reader.IsDBNull(FLD_HANDOVERTIME)) { cRMSurveyMaster_RPTEntity.HandoverTime = String.Empty; } else { cRMSurveyMaster_RPTEntity.HandoverTime = reader.GetString(FLD_HANDOVERTIME); }
            cRMSurveyMaster_RPTEntity.SurveyBuildingStatusID = reader.GetInt64(FLD_SURVEYBUILDINGSTATUSID);
            cRMSurveyMaster_RPTEntity.SurveySourceInformationID = reader.GetInt64(FLD_SURVEYSOURCEINFORMATIONID);
            if (reader.IsDBNull(FLD_SOURCEPERSONINFORMATION)) { cRMSurveyMaster_RPTEntity.SourcePersonInformation = String.Empty; } else { cRMSurveyMaster_RPTEntity.SourcePersonInformation = reader.GetString(FLD_SOURCEPERSONINFORMATION); }
            if (reader.IsDBNull(FLD_CONTACTINFO)) { cRMSurveyMaster_RPTEntity.ContactInfo = String.Empty; } else { cRMSurveyMaster_RPTEntity.ContactInfo = reader.GetString(FLD_CONTACTINFO); }
            if (reader.IsDBNull(FLD_REMARKS)) { cRMSurveyMaster_RPTEntity.Remarks = String.Empty; } else { cRMSurveyMaster_RPTEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_ADDITIONALREMARKS)) { cRMSurveyMaster_RPTEntity.AdditionalRemarks = String.Empty; } else { cRMSurveyMaster_RPTEntity.AdditionalRemarks = reader.GetString(FLD_ADDITIONALREMARKS); }
            if (reader.IsDBNull(FLD_OTHERSREMARKS)) { cRMSurveyMaster_RPTEntity.OthersRemarks = String.Empty; } else { cRMSurveyMaster_RPTEntity.OthersRemarks = reader.GetString(FLD_OTHERSREMARKS); }
            if (reader.IsDBNull(FLD_CREATEDATE)) { cRMSurveyMaster_RPTEntity.CreateDate = null; } else { cRMSurveyMaster_RPTEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE); }
            cRMSurveyMaster_RPTEntity.SurveyDate = reader.GetDateTime(FLD_SURVEYDATE);
            if (reader.IsDBNull(FLD_IP)) { cRMSurveyMaster_RPTEntity.IP = String.Empty; } else { cRMSurveyMaster_RPTEntity.IP = reader.GetString(FLD_IP); }
            cRMSurveyMaster_RPTEntity.SurveyByEmployeeID = reader.GetInt64(FLD_SURVEYBYEMPLOYEEID);
            cRMSurveyMaster_RPTEntity.CreateByEmployeeID = reader.GetInt64(FLD_CREATEBYEMPLOYEEID);
            cRMSurveyMaster_RPTEntity.SurveyOwnerName = reader.GetString(FLD_SURVEYOWNERNAME);
            cRMSurveyMaster_RPTEntity.SurveyByEmployeeName = reader.GetString(FLD_SURVEYBYEMPLOYEENAME);
            cRMSurveyMaster_RPTEntity.CreatedByEmployeeName = reader.GetString(FLD_CREATEDBYEMPLOYEENAME);
            cRMSurveyMaster_RPTEntity.SurveyOwnerTypeName = reader.GetString(FLD_SURVEYOWNERTYPENAME);
            cRMSurveyMaster_RPTEntity.AreaUnitName = reader.GetString(FLD_AREAUNITNAME);
            cRMSurveyMaster_RPTEntity.SurveyBuildingStatusName = reader.GetString(FLD_SURVEYBUILDINGSTATUSNAME);
            cRMSurveyMaster_RPTEntity.SurveySourceInformationName = reader.GetString(FLD_SURVEYSOURCEINFORMATIONNAME);
            if (reader.IsDBNull(FLD_ADDRESSLINE1)) { cRMSurveyMaster_RPTEntity.AddressLine1 = String.Empty; } else { cRMSurveyMaster_RPTEntity.AddressLine1 = reader.GetString(FLD_ADDRESSLINE1); }
            if (reader.IsDBNull(FLD_CONTACTNO1)) { cRMSurveyMaster_RPTEntity.ContactNo1 = String.Empty; } else { cRMSurveyMaster_RPTEntity.ContactNo1 = reader.GetString(FLD_CONTACTNO1); }
            if (reader.IsDBNull(FLD_EMAIL)) { cRMSurveyMaster_RPTEntity.Email = String.Empty; } else { cRMSurveyMaster_RPTEntity.Email = reader.GetString(FLD_EMAIL); }
            cRMSurveyMaster_RPTEntity.SurveyMasterID = reader.GetInt64(FLD_SURVEYMASTERID);
            cRMSurveyMaster_RPTEntity.Title = reader.GetString(FLD_TITLE);
            cRMSurveyMaster_RPTEntity.StartDate = reader.GetDateTime(FLD_STARTDATE);
            cRMSurveyMaster_RPTEntity.EndDate = reader.GetDateTime(FLD_ENDDATE);
            if (reader.IsDBNull(FLD_SURVEYMASTERCREATEDATE)) { cRMSurveyMaster_RPTEntity.SurveyMasterCreateDate = null; } else { cRMSurveyMaster_RPTEntity.SurveyMasterCreateDate = reader.GetDateTime(FLD_SURVEYMASTERCREATEDATE); }
            cRMSurveyMaster_RPTEntity.SurveyMasterCreatedByEmployeeID = reader.GetInt64(FLD_SURVEYMASTERCREATEDBYEMPLOYEEID);
            cRMSurveyMaster_RPTEntity.SurveyMasterCreatedByEmployee = reader.GetString(FLD_SURVEYMASTERCREATEDBYEMPLOYEE);
            cRMSurveyMaster_RPTEntity.AreaID = reader.GetInt64(FLD_AREAID);
            cRMSurveyMaster_RPTEntity.AreaName = reader.GetString(FLD_AREANAME);

            return cRMSurveyMaster_RPTEntity;
        }
    }
}
