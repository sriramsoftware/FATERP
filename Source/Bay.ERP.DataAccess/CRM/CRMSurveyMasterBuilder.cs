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
    internal sealed class CRMSurveyMasterBuilder : IEntityBuilder<CRMSurveyMasterEntity>
    {
        IList<CRMSurveyMasterEntity> IEntityBuilder<CRMSurveyMasterEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMSurveyMasterEntity> CRMSurveyMasterEntityList = new List<CRMSurveyMasterEntity>();

            while (reader.Read())
            {
                CRMSurveyMasterEntityList.Add(((IEntityBuilder<CRMSurveyMasterEntity>)this).BuildEntity(reader));
            }

            return (CRMSurveyMasterEntityList.Count > 0) ? CRMSurveyMasterEntityList : null;
        }

        CRMSurveyMasterEntity IEntityBuilder<CRMSurveyMasterEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SURVEYMASTERID = 0;
            const Int32 FLD_TITLE = 1;
            const Int32 FLD_STARTDATE = 2;
            const Int32 FLD_ENDDATE= 3;
            const Int32 FLD_CREATEDATE = 4;
            const Int32 FLD_CREATEBYEMPLOYEEID = 5;

            CRMSurveyMasterEntity cRMSurveyMasterEntity = new CRMSurveyMasterEntity();

            cRMSurveyMasterEntity.SurveyMasterID = reader.GetInt64(FLD_SURVEYMASTERID);
            cRMSurveyMasterEntity.Title = reader.GetString(FLD_TITLE);
            cRMSurveyMasterEntity.StartDate = reader.GetDateTime(FLD_STARTDATE);
            cRMSurveyMasterEntity.EndDate = reader.GetDateTime(FLD_ENDDATE);
            if (reader.IsDBNull(FLD_CREATEDATE)) { cRMSurveyMasterEntity.CreateDate = null; } else { cRMSurveyMasterEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE); }
            cRMSurveyMasterEntity.CreateByEmployeeID = reader.GetInt64(FLD_CREATEBYEMPLOYEEID);

            return cRMSurveyMasterEntity;
        }
    }
}
