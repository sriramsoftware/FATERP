// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-May-2013, 11:39:55




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMSurveyOwner_DetailedBuilder : IEntityBuilder<CRMSurveyOwner_DetailedEntity>
    {
        IList<CRMSurveyOwner_DetailedEntity> IEntityBuilder<CRMSurveyOwner_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMSurveyOwner_DetailedEntity> CRMSurveyOwner_DetailedEntityList = new List<CRMSurveyOwner_DetailedEntity>();

            while (reader.Read())
            {
                CRMSurveyOwner_DetailedEntityList.Add(((IEntityBuilder<CRMSurveyOwner_DetailedEntity>)this).BuildEntity(reader));
            }

            return (CRMSurveyOwner_DetailedEntityList.Count > 0) ? CRMSurveyOwner_DetailedEntityList : null;
        }

        CRMSurveyOwner_DetailedEntity IEntityBuilder<CRMSurveyOwner_DetailedEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_SURVEYOWNERTYPENAME = 10;
            const Int32 FLD_ROWNUMBER = 11;

            CRMSurveyOwner_DetailedEntity cRMSurveyOwner_DetailedEntity = new CRMSurveyOwner_DetailedEntity();

            cRMSurveyOwner_DetailedEntity.SurveyOwnerID = reader.GetInt64(FLD_SURVEYOWNERID);
            cRMSurveyOwner_DetailedEntity.SurveyOwnerTypeID = reader.GetInt64(FLD_SURVEYOWNERTYPEID);
            cRMSurveyOwner_DetailedEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_ADDRESSLINE1)) { cRMSurveyOwner_DetailedEntity.AddressLine1 = String.Empty; } else { cRMSurveyOwner_DetailedEntity.AddressLine1 = reader.GetString(FLD_ADDRESSLINE1); }
            if (reader.IsDBNull(FLD_ADDRESSLINE2)) { cRMSurveyOwner_DetailedEntity.AddressLine2 = String.Empty; } else { cRMSurveyOwner_DetailedEntity.AddressLine2 = reader.GetString(FLD_ADDRESSLINE2); }
            if (reader.IsDBNull(FLD_CONTACTNO1)) { cRMSurveyOwner_DetailedEntity.ContactNo1 = String.Empty; } else { cRMSurveyOwner_DetailedEntity.ContactNo1 = reader.GetString(FLD_CONTACTNO1); }
            if (reader.IsDBNull(FLD_CONTACTNO2)) { cRMSurveyOwner_DetailedEntity.ContactNo2 = String.Empty; } else { cRMSurveyOwner_DetailedEntity.ContactNo2 = reader.GetString(FLD_CONTACTNO2); }
            if (reader.IsDBNull(FLD_EMAIL)) { cRMSurveyOwner_DetailedEntity.Email = String.Empty; } else { cRMSurveyOwner_DetailedEntity.Email = reader.GetString(FLD_EMAIL); }
            if (reader.IsDBNull(FLD_WEBLINK)) { cRMSurveyOwner_DetailedEntity.WebLink = String.Empty; } else { cRMSurveyOwner_DetailedEntity.WebLink = reader.GetString(FLD_WEBLINK); }
            if (reader.IsDBNull(FLD_REMARKS)) { cRMSurveyOwner_DetailedEntity.Remarks = String.Empty; } else { cRMSurveyOwner_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            cRMSurveyOwner_DetailedEntity.SurveyOwnerTypeName = reader.GetString(FLD_SURVEYOWNERTYPENAME);
            if (reader.IsDBNull(FLD_ROWNUMBER)) { cRMSurveyOwner_DetailedEntity.RowNumber = null; } else { cRMSurveyOwner_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return cRMSurveyOwner_DetailedEntity;
        }
    }
}
