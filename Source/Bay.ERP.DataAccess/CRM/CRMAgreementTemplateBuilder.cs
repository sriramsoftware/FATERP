// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 11-Apr-2013, 01:28:07




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMAgreementTemplateBuilder : IEntityBuilder<CRMAgreementTemplateEntity>
    {
        IList<CRMAgreementTemplateEntity> IEntityBuilder<CRMAgreementTemplateEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMAgreementTemplateEntity> CRMAgreementTemplateEntityList = new List<CRMAgreementTemplateEntity>();

            while (reader.Read())
            {
                CRMAgreementTemplateEntityList.Add(((IEntityBuilder<CRMAgreementTemplateEntity>)this).BuildEntity(reader));
            }

            return (CRMAgreementTemplateEntityList.Count > 0) ? CRMAgreementTemplateEntityList : null;
        }

        CRMAgreementTemplateEntity IEntityBuilder<CRMAgreementTemplateEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_AGREEMENTTEMPLATEID = 0;
            const Int32 FLD_TEMPLATENAME = 1;
            const Int32 FLD_TEXT = 2;
            const Int32 FLD_REMARKS = 3;
            const Int32 FLD_CREATEDATE = 4;
            const Int32 FLD_IP = 5;
            const Int32 FLD_CREATEDBYEMPLOYEEID = 6;

            CRMAgreementTemplateEntity cRMAgreementTemplateEntity = new CRMAgreementTemplateEntity();

            cRMAgreementTemplateEntity.AgreementTemplateID = reader.GetInt64(FLD_AGREEMENTTEMPLATEID);
            cRMAgreementTemplateEntity.TemplateName = reader.GetString(FLD_TEMPLATENAME);
            cRMAgreementTemplateEntity.Text = reader.GetString(FLD_TEXT);
            if (reader.IsDBNull(FLD_REMARKS)) { cRMAgreementTemplateEntity.Remarks = String.Empty; } else { cRMAgreementTemplateEntity.Remarks = reader.GetString(FLD_REMARKS); }
            cRMAgreementTemplateEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            cRMAgreementTemplateEntity.IP = reader.GetString(FLD_IP);
            cRMAgreementTemplateEntity.CreatedByEmployeeID = reader.GetInt64(FLD_CREATEDBYEMPLOYEEID);

            return cRMAgreementTemplateEntity;
        }
    }
}
