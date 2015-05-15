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
    internal sealed class CRMSurveyOwnerBuilder : IEntityBuilder<CRMSurveyOwnerEntity>
    {
        IList<CRMSurveyOwnerEntity> IEntityBuilder<CRMSurveyOwnerEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMSurveyOwnerEntity> CRMSurveyOwnerEntityList = new List<CRMSurveyOwnerEntity>();

            while (reader.Read())
            {
                CRMSurveyOwnerEntityList.Add(((IEntityBuilder<CRMSurveyOwnerEntity>)this).BuildEntity(reader));
            }

            return (CRMSurveyOwnerEntityList.Count > 0) ? CRMSurveyOwnerEntityList : null;
        }

        CRMSurveyOwnerEntity IEntityBuilder<CRMSurveyOwnerEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SURVEYOWNERID = 0;
            const Int32 FLD_SURVEYOWNERTYPEID = 1;
            const Int32 FLD_NAME = 2;
            const Int32 FLD_ADDRESSLINE1 = 3;
            const Int32 FLD_ADDRESSLINE2 = 4;
            const Int32 FLD_CONTACTNO1 = 5;
            const Int32 FLD_CONTACTNO2 = 6;
            const Int32 FLD_EMAIL = 7;
            const Int32 FLD_WEBLINK = 8;
            const Int32 FLD_REMARKS = 9;

            CRMSurveyOwnerEntity cRMSurveyOwnerEntity = new CRMSurveyOwnerEntity();

            cRMSurveyOwnerEntity.SurveyOwnerID = reader.GetInt64(FLD_SURVEYOWNERID);
            cRMSurveyOwnerEntity.SurveyOwnerTypeID = reader.GetInt64(FLD_SURVEYOWNERTYPEID);
            cRMSurveyOwnerEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_ADDRESSLINE1)) { cRMSurveyOwnerEntity.AddressLine1 = String.Empty; } else { cRMSurveyOwnerEntity.AddressLine1 = reader.GetString(FLD_ADDRESSLINE1); }
            if (reader.IsDBNull(FLD_ADDRESSLINE2)) { cRMSurveyOwnerEntity.AddressLine2 = String.Empty; } else { cRMSurveyOwnerEntity.AddressLine2 = reader.GetString(FLD_ADDRESSLINE2); }
            if (reader.IsDBNull(FLD_CONTACTNO1)) { cRMSurveyOwnerEntity.ContactNo1 = String.Empty; } else { cRMSurveyOwnerEntity.ContactNo1 = reader.GetString(FLD_CONTACTNO1); }
            if (reader.IsDBNull(FLD_CONTACTNO2)) { cRMSurveyOwnerEntity.ContactNo2 = String.Empty; } else { cRMSurveyOwnerEntity.ContactNo2 = reader.GetString(FLD_CONTACTNO2); }
            if (reader.IsDBNull(FLD_EMAIL)) { cRMSurveyOwnerEntity.Email = String.Empty; } else { cRMSurveyOwnerEntity.Email = reader.GetString(FLD_EMAIL); }
            if (reader.IsDBNull(FLD_WEBLINK)) { cRMSurveyOwnerEntity.WebLink = String.Empty; } else { cRMSurveyOwnerEntity.WebLink = reader.GetString(FLD_WEBLINK); }
            if (reader.IsDBNull(FLD_REMARKS)) { cRMSurveyOwnerEntity.Remarks = String.Empty; } else { cRMSurveyOwnerEntity.Remarks = reader.GetString(FLD_REMARKS); }

            return cRMSurveyOwnerEntity;
        }
    }
}
