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
    internal sealed class CRMSurveyOwnerContactPersonBuilder : IEntityBuilder<CRMSurveyOwnerContactPersonEntity>
    {
        IList<CRMSurveyOwnerContactPersonEntity> IEntityBuilder<CRMSurveyOwnerContactPersonEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMSurveyOwnerContactPersonEntity> CRMSurveyOwnerContactPersonEntityList = new List<CRMSurveyOwnerContactPersonEntity>();

            while (reader.Read())
            {
                CRMSurveyOwnerContactPersonEntityList.Add(((IEntityBuilder<CRMSurveyOwnerContactPersonEntity>)this).BuildEntity(reader));
            }

            return (CRMSurveyOwnerContactPersonEntityList.Count > 0) ? CRMSurveyOwnerContactPersonEntityList : null;
        }

        CRMSurveyOwnerContactPersonEntity IEntityBuilder<CRMSurveyOwnerContactPersonEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SURVEYOWNERCONTACTPERSONID = 0;
            const Int32 FLD_SURVEYOWNERID = 1;
            const Int32 FLD_NAME = 2;
            const Int32 FLD_DESIGNATION = 3;
            const Int32 FLD_PHONE = 4;
            const Int32 FLD_MOBILENO = 5;
            const Int32 FLD_FAX = 6;
            const Int32 FLD_EMAIL = 7;
            const Int32 FLD_WEBLINK = 8;
            const Int32 FLD_REMARKS = 9;

            CRMSurveyOwnerContactPersonEntity cRMSurveyOwnerContactPersonEntity = new CRMSurveyOwnerContactPersonEntity();

            cRMSurveyOwnerContactPersonEntity.SurveyOwnerContactPersonID = reader.GetInt64(FLD_SURVEYOWNERCONTACTPERSONID);
            cRMSurveyOwnerContactPersonEntity.SurveyOwnerID = reader.GetInt64(FLD_SURVEYOWNERID);
            cRMSurveyOwnerContactPersonEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESIGNATION)) { cRMSurveyOwnerContactPersonEntity.Designation = String.Empty; } else { cRMSurveyOwnerContactPersonEntity.Designation = reader.GetString(FLD_DESIGNATION); }
            if (reader.IsDBNull(FLD_PHONE)) { cRMSurveyOwnerContactPersonEntity.Phone = String.Empty; } else { cRMSurveyOwnerContactPersonEntity.Phone = reader.GetString(FLD_PHONE); }
            if (reader.IsDBNull(FLD_MOBILENO)) { cRMSurveyOwnerContactPersonEntity.MobileNo = String.Empty; } else { cRMSurveyOwnerContactPersonEntity.MobileNo = reader.GetString(FLD_MOBILENO); }
            if (reader.IsDBNull(FLD_FAX)) { cRMSurveyOwnerContactPersonEntity.Fax = String.Empty; } else { cRMSurveyOwnerContactPersonEntity.Fax = reader.GetString(FLD_FAX); }
            if (reader.IsDBNull(FLD_EMAIL)) { cRMSurveyOwnerContactPersonEntity.Email = String.Empty; } else { cRMSurveyOwnerContactPersonEntity.Email = reader.GetString(FLD_EMAIL); }
            if (reader.IsDBNull(FLD_WEBLINK)) { cRMSurveyOwnerContactPersonEntity.WebLink = String.Empty; } else { cRMSurveyOwnerContactPersonEntity.WebLink = reader.GetString(FLD_WEBLINK); }
            if (reader.IsDBNull(FLD_REMARKS)) { cRMSurveyOwnerContactPersonEntity.Remarks = String.Empty; } else { cRMSurveyOwnerContactPersonEntity.Remarks = reader.GetString(FLD_REMARKS); }

            return cRMSurveyOwnerContactPersonEntity;
        }
    }
}
