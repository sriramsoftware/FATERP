// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Oct-2013, 12:51:37




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMSurveyBuilder : IEntityBuilder<CRMSurveyEntity>
    {
        IList<CRMSurveyEntity> IEntityBuilder<CRMSurveyEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMSurveyEntity> CRMSurveyEntityList = new List<CRMSurveyEntity>();

            while (reader.Read())
            {
                CRMSurveyEntityList.Add(((IEntityBuilder<CRMSurveyEntity>)this).BuildEntity(reader));
            }

            return (CRMSurveyEntityList.Count > 0) ? CRMSurveyEntityList : null;
        }

        CRMSurveyEntity IEntityBuilder<CRMSurveyEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SURVEYID = 0;
            const Int32 FLD_SURVEYMASTERID = 1;
            const Int32 FLD_SURVEYOWNERID = 2;
            const Int32 FLD_AREAID = 3;
            const Int32 FLD_DESCRIPTION = 4;
            const Int32 FLD_PLOTADDRESS = 5;
            const Int32 FLD_APPROXIMATEPLOTSIZE = 6;
            const Int32 FLD_AREAUNITID = 7;
            const Int32 FLD_APPROXIMATEFLOORSIZESFT = 8;
            const Int32 FLD_FLOORS = 9;
            const Int32 FLD_APPROXIMATETOTALSPACESFT = 10;
            const Int32 FLD_BASEMENTS = 11;
            const Int32 FLD_NOOFCARPARKING = 12;
            const Int32 FLD_ACSYSTEM = 13;
            const Int32 FLD_GENERATORBACKUP = 14;
            const Int32 FLD_LIFTSCAPACITY = 15;
            const Int32 FLD_TOILETSPERFLOOR = 16;
            const Int32 FLD_AVAILABLEFLOORSFT = 17;
            const Int32 FLD_AVAILABLEFOROCCUPANCY = 18;
            const Int32 FLD_RENTALRATEBDTPERSFT = 19;
            const Int32 FLD_SELLINGRATEBDTPERSFT = 20;
            const Int32 FLD_HANDOVERTIME = 21;
            const Int32 FLD_SURVEYBUILDINGSTATUSID = 22;
            const Int32 FLD_SURVEYSOURCEINFORMATIONID = 23;
            const Int32 FLD_SOURCEPERSONINFORMATION = 24;
            const Int32 FLD_CONTACTINFO = 25;
            const Int32 FLD_REMARKS = 26;
            const Int32 FLD_ADDITIONALREMARKS = 27;
            const Int32 FLD_OTHERSREMARKS = 28;
            const Int32 FLD_CREATEDATE = 29;
            const Int32 FLD_SURVEYDATE = 30;
            const Int32 FLD_IP = 31;
            const Int32 FLD_SURVEYBYEMPLOYEEID = 32;
            const Int32 FLD_CREATEBYEMPLOYEEID = 33;

            CRMSurveyEntity cRMSurveyEntity = new CRMSurveyEntity();

            cRMSurveyEntity.SurveyID = reader.GetInt64(FLD_SURVEYID);
            cRMSurveyEntity.SurveyMasterID = reader.GetInt64(FLD_SURVEYMASTERID);
            cRMSurveyEntity.SurveyOwnerID = reader.GetInt64(FLD_SURVEYOWNERID);
            cRMSurveyEntity.AreaID = reader.GetInt64(FLD_AREAID);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { cRMSurveyEntity.Description = String.Empty; } else { cRMSurveyEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            cRMSurveyEntity.PlotAddress = reader.GetString(FLD_PLOTADDRESS);
            cRMSurveyEntity.ApproximatePlotSize = reader.GetDecimal(FLD_APPROXIMATEPLOTSIZE);
            cRMSurveyEntity.AreaUnitID = reader.GetInt64(FLD_AREAUNITID);
            cRMSurveyEntity.ApproximateFloorSizeSft = reader.GetDecimal(FLD_APPROXIMATEFLOORSIZESFT);
            cRMSurveyEntity.Floors = reader.GetDecimal(FLD_FLOORS);
            cRMSurveyEntity.ApproximateTotalSpaceSft = reader.GetDecimal(FLD_APPROXIMATETOTALSPACESFT);
            if (reader.IsDBNull(FLD_BASEMENTS)) { cRMSurveyEntity.Basements = String.Empty; } else { cRMSurveyEntity.Basements = reader.GetString(FLD_BASEMENTS); }
            if (reader.IsDBNull(FLD_NOOFCARPARKING)) { cRMSurveyEntity.NoOfCarParking = String.Empty; } else { cRMSurveyEntity.NoOfCarParking = reader.GetString(FLD_NOOFCARPARKING); }
            if (reader.IsDBNull(FLD_ACSYSTEM)) { cRMSurveyEntity.ACSystem = String.Empty; } else { cRMSurveyEntity.ACSystem = reader.GetString(FLD_ACSYSTEM); }
            if (reader.IsDBNull(FLD_GENERATORBACKUP)) { cRMSurveyEntity.GeneratorBackup = String.Empty; } else { cRMSurveyEntity.GeneratorBackup = reader.GetString(FLD_GENERATORBACKUP); }
            if (reader.IsDBNull(FLD_LIFTSCAPACITY)) { cRMSurveyEntity.LiftsCapacity = String.Empty; } else { cRMSurveyEntity.LiftsCapacity = reader.GetString(FLD_LIFTSCAPACITY); }
            if (reader.IsDBNull(FLD_TOILETSPERFLOOR)) { cRMSurveyEntity.ToiletsPerFloor = String.Empty; } else { cRMSurveyEntity.ToiletsPerFloor = reader.GetString(FLD_TOILETSPERFLOOR); }
            if (reader.IsDBNull(FLD_AVAILABLEFLOORSFT)) { cRMSurveyEntity.AvailableFloorSft = String.Empty; } else { cRMSurveyEntity.AvailableFloorSft = reader.GetString(FLD_AVAILABLEFLOORSFT); }
            if (reader.IsDBNull(FLD_AVAILABLEFOROCCUPANCY)) { cRMSurveyEntity.AvailableForOccupancy = String.Empty; } else { cRMSurveyEntity.AvailableForOccupancy = reader.GetString(FLD_AVAILABLEFOROCCUPANCY); }
            if (reader.IsDBNull(FLD_RENTALRATEBDTPERSFT)) { cRMSurveyEntity.RentalRateBDTPerSft = String.Empty; } else { cRMSurveyEntity.RentalRateBDTPerSft = reader.GetString(FLD_RENTALRATEBDTPERSFT); }
            if (reader.IsDBNull(FLD_SELLINGRATEBDTPERSFT)) { cRMSurveyEntity.SellingRateBDTPerSft = String.Empty; } else { cRMSurveyEntity.SellingRateBDTPerSft = reader.GetString(FLD_SELLINGRATEBDTPERSFT); }
            if (reader.IsDBNull(FLD_HANDOVERTIME)) { cRMSurveyEntity.HandoverTime = String.Empty; } else { cRMSurveyEntity.HandoverTime = reader.GetString(FLD_HANDOVERTIME); }
            cRMSurveyEntity.SurveyBuildingStatusID = reader.GetInt64(FLD_SURVEYBUILDINGSTATUSID);
            cRMSurveyEntity.SurveySourceInformationID = reader.GetInt64(FLD_SURVEYSOURCEINFORMATIONID);
            if (reader.IsDBNull(FLD_SOURCEPERSONINFORMATION)) { cRMSurveyEntity.SourcePersonInformation = String.Empty; } else { cRMSurveyEntity.SourcePersonInformation = reader.GetString(FLD_SOURCEPERSONINFORMATION); }
            if (reader.IsDBNull(FLD_CONTACTINFO)) { cRMSurveyEntity.ContactInfo = String.Empty; } else { cRMSurveyEntity.ContactInfo = reader.GetString(FLD_CONTACTINFO); }
            if (reader.IsDBNull(FLD_REMARKS)) { cRMSurveyEntity.Remarks = String.Empty; } else { cRMSurveyEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_ADDITIONALREMARKS)) { cRMSurveyEntity.AdditionalRemarks = String.Empty; } else { cRMSurveyEntity.AdditionalRemarks = reader.GetString(FLD_ADDITIONALREMARKS); }
            if (reader.IsDBNull(FLD_OTHERSREMARKS)) { cRMSurveyEntity.OthersRemarks = String.Empty; } else { cRMSurveyEntity.OthersRemarks = reader.GetString(FLD_OTHERSREMARKS); }
            if (reader.IsDBNull(FLD_CREATEDATE)) { cRMSurveyEntity.CreateDate = null; } else { cRMSurveyEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE); }
            cRMSurveyEntity.SurveyDate = reader.GetDateTime(FLD_SURVEYDATE);
            if (reader.IsDBNull(FLD_IP)) { cRMSurveyEntity.IP = String.Empty; } else { cRMSurveyEntity.IP = reader.GetString(FLD_IP); }
            cRMSurveyEntity.SurveyByEmployeeID = reader.GetInt64(FLD_SURVEYBYEMPLOYEEID);
            cRMSurveyEntity.CreateByEmployeeID = reader.GetInt64(FLD_CREATEBYEMPLOYEEID);

            return cRMSurveyEntity;
        }
    }
}
