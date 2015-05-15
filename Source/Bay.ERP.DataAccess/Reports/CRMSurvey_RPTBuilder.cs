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
    internal sealed class CRMSurvey_RPTBuilder : IEntityBuilder<CRMSurvey_RPTEntity>
    {
        IList<CRMSurvey_RPTEntity> IEntityBuilder<CRMSurvey_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMSurvey_RPTEntity> CRMSurvey_RPTEntityList = new List<CRMSurvey_RPTEntity>();

            while (reader.Read())
            {
                CRMSurvey_RPTEntityList.Add(((IEntityBuilder<CRMSurvey_RPTEntity>)this).BuildEntity(reader));
            }

            return (CRMSurvey_RPTEntityList.Count > 0) ? CRMSurvey_RPTEntityList : null;
        }

        CRMSurvey_RPTEntity IEntityBuilder<CRMSurvey_RPTEntity>.BuildEntity(IDataReader reader)
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

            CRMSurvey_RPTEntity cRMSurvey_RPTEntity = new CRMSurvey_RPTEntity();

            cRMSurvey_RPTEntity.SurveyID = reader.GetInt64(FLD_SURVEYID);
            cRMSurvey_RPTEntity.SurveyOwnerID = reader.GetInt64(FLD_SURVEYOWNERID);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { cRMSurvey_RPTEntity.Description = String.Empty; } else { cRMSurvey_RPTEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            cRMSurvey_RPTEntity.PlotAddress = reader.GetString(FLD_PLOTADDRESS);
            cRMSurvey_RPTEntity.ApproximatePlotSize = reader.GetDecimal(FLD_APPROXIMATEPLOTSIZE);
            cRMSurvey_RPTEntity.AreaUnitID = reader.GetInt64(FLD_AREAUNITID);
            cRMSurvey_RPTEntity.ApproximateFloorSizeSft = reader.GetDecimal(FLD_APPROXIMATEFLOORSIZESFT);
            cRMSurvey_RPTEntity.Floors = reader.GetDecimal(FLD_FLOORS);
            cRMSurvey_RPTEntity.ApproximateTotalSpaceSft = reader.GetDecimal(FLD_APPROXIMATETOTALSPACESFT);
            if (reader.IsDBNull(FLD_BASEMENTS)) { cRMSurvey_RPTEntity.Basements = String.Empty; } else { cRMSurvey_RPTEntity.Basements = reader.GetString(FLD_BASEMENTS); }
            if (reader.IsDBNull(FLD_NOOFCARPARKING)) { cRMSurvey_RPTEntity.NoOfCarParking = String.Empty; } else { cRMSurvey_RPTEntity.NoOfCarParking = reader.GetString(FLD_NOOFCARPARKING); }
            if (reader.IsDBNull(FLD_ACSYSTEM)) { cRMSurvey_RPTEntity.ACSystem = String.Empty; } else { cRMSurvey_RPTEntity.ACSystem = reader.GetString(FLD_ACSYSTEM); }
            if (reader.IsDBNull(FLD_GENERATORBACKUP)) { cRMSurvey_RPTEntity.GeneratorBackup = String.Empty; } else { cRMSurvey_RPTEntity.GeneratorBackup = reader.GetString(FLD_GENERATORBACKUP); }
            if (reader.IsDBNull(FLD_LIFTSCAPACITY)) { cRMSurvey_RPTEntity.LiftsCapacity = String.Empty; } else { cRMSurvey_RPTEntity.LiftsCapacity = reader.GetString(FLD_LIFTSCAPACITY); }
            if (reader.IsDBNull(FLD_TOILETSPERFLOOR)) { cRMSurvey_RPTEntity.ToiletsPerFloor = String.Empty; } else { cRMSurvey_RPTEntity.ToiletsPerFloor = reader.GetString(FLD_TOILETSPERFLOOR); }
            if (reader.IsDBNull(FLD_AVAILABLEFLOORSFT)) { cRMSurvey_RPTEntity.AvailableFloorSft = String.Empty; } else { cRMSurvey_RPTEntity.AvailableFloorSft = reader.GetString(FLD_AVAILABLEFLOORSFT); }
            if (reader.IsDBNull(FLD_AVAILABLEFOROCCUPANCY)) { cRMSurvey_RPTEntity.AvailableForOccupancy = String.Empty; } else { cRMSurvey_RPTEntity.AvailableForOccupancy = reader.GetString(FLD_AVAILABLEFOROCCUPANCY); }
            if (reader.IsDBNull(FLD_RENTALRATEBDTPERSFT)) { cRMSurvey_RPTEntity.RentalRateBDTPerSft = String.Empty; } else { cRMSurvey_RPTEntity.RentalRateBDTPerSft = reader.GetString(FLD_RENTALRATEBDTPERSFT); }
            if (reader.IsDBNull(FLD_SELLINGRATEBDTPERSFT)) { cRMSurvey_RPTEntity.SellingRateBDTPerSft = String.Empty; } else { cRMSurvey_RPTEntity.SellingRateBDTPerSft = reader.GetString(FLD_SELLINGRATEBDTPERSFT); }
            if (reader.IsDBNull(FLD_HANDOVERTIME)) { cRMSurvey_RPTEntity.HandoverTime = String.Empty; } else { cRMSurvey_RPTEntity.HandoverTime = reader.GetString(FLD_HANDOVERTIME); }
            cRMSurvey_RPTEntity.SurveyBuildingStatusID = reader.GetInt64(FLD_SURVEYBUILDINGSTATUSID);
            cRMSurvey_RPTEntity.SurveySourceInformationID = reader.GetInt64(FLD_SURVEYSOURCEINFORMATIONID);
            if (reader.IsDBNull(FLD_SOURCEPERSONINFORMATION)) { cRMSurvey_RPTEntity.SourcePersonInformation = String.Empty; } else { cRMSurvey_RPTEntity.SourcePersonInformation = reader.GetString(FLD_SOURCEPERSONINFORMATION); }
            if (reader.IsDBNull(FLD_CONTACTINFO)) { cRMSurvey_RPTEntity.ContactInfo = String.Empty; } else { cRMSurvey_RPTEntity.ContactInfo = reader.GetString(FLD_CONTACTINFO); }
            if (reader.IsDBNull(FLD_REMARKS)) { cRMSurvey_RPTEntity.Remarks = String.Empty; } else { cRMSurvey_RPTEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_ADDITIONALREMARKS)) { cRMSurvey_RPTEntity.AdditionalRemarks = String.Empty; } else { cRMSurvey_RPTEntity.AdditionalRemarks = reader.GetString(FLD_ADDITIONALREMARKS); }
            if (reader.IsDBNull(FLD_OTHERSREMARKS)) { cRMSurvey_RPTEntity.OthersRemarks = String.Empty; } else { cRMSurvey_RPTEntity.OthersRemarks = reader.GetString(FLD_OTHERSREMARKS); }
            if (reader.IsDBNull(FLD_CREATEDATE)) { cRMSurvey_RPTEntity.CreateDate = null; } else { cRMSurvey_RPTEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE); }
            cRMSurvey_RPTEntity.SurveyDate = reader.GetDateTime(FLD_SURVEYDATE);
            if (reader.IsDBNull(FLD_IP)) { cRMSurvey_RPTEntity.IP = String.Empty; } else { cRMSurvey_RPTEntity.IP = reader.GetString(FLD_IP); }
            cRMSurvey_RPTEntity.SurveyByEmployeeID = reader.GetInt64(FLD_SURVEYBYEMPLOYEEID);
            cRMSurvey_RPTEntity.CreateByEmployeeID = reader.GetInt64(FLD_CREATEBYEMPLOYEEID);
            cRMSurvey_RPTEntity.SurveyOwnerName = reader.GetString(FLD_SURVEYOWNERNAME);
            cRMSurvey_RPTEntity.SurveyByEmployeeName = reader.GetString(FLD_SURVEYBYEMPLOYEENAME);
            cRMSurvey_RPTEntity.CreatedByEmployeeName = reader.GetString(FLD_CREATEDBYEMPLOYEENAME);
            cRMSurvey_RPTEntity.SurveyOwnerTypeName = reader.GetString(FLD_SURVEYOWNERTYPENAME);
            cRMSurvey_RPTEntity.AreaUnitName = reader.GetString(FLD_AREAUNITNAME);
            cRMSurvey_RPTEntity.SurveyBuildingStatusName = reader.GetString(FLD_SURVEYBUILDINGSTATUSNAME);
            cRMSurvey_RPTEntity.SurveySourceInformationName = reader.GetString(FLD_SURVEYSOURCEINFORMATIONNAME);
            if (reader.IsDBNull(FLD_ADDRESSLINE1)) { cRMSurvey_RPTEntity.AddressLine1 = String.Empty; } else { cRMSurvey_RPTEntity.AddressLine1 = reader.GetString(FLD_ADDRESSLINE1); }
            if (reader.IsDBNull(FLD_CONTACTNO1)) { cRMSurvey_RPTEntity.ContactNo1 = String.Empty; } else { cRMSurvey_RPTEntity.ContactNo1 = reader.GetString(FLD_CONTACTNO1); }
            if (reader.IsDBNull(FLD_EMAIL)) { cRMSurvey_RPTEntity.Email = String.Empty; } else { cRMSurvey_RPTEntity.Email = reader.GetString(FLD_EMAIL); }

            return cRMSurvey_RPTEntity;
        }
    }
}
