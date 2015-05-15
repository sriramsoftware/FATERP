// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 01:41:28




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMPreBOQTemplateBuilder : IEntityBuilder<PRMPreBOQTemplateEntity>
    {
        IList<PRMPreBOQTemplateEntity> IEntityBuilder<PRMPreBOQTemplateEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMPreBOQTemplateEntity> PRMPreBOQTemplateEntityList = new List<PRMPreBOQTemplateEntity>();

            while (reader.Read())
            {
                PRMPreBOQTemplateEntityList.Add(((IEntityBuilder<PRMPreBOQTemplateEntity>)this).BuildEntity(reader));
            }

            return (PRMPreBOQTemplateEntityList.Count > 0) ? PRMPreBOQTemplateEntityList : null;
        }

        PRMPreBOQTemplateEntity IEntityBuilder<PRMPreBOQTemplateEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PREBOQTEMPLATEID = 0;
            const Int32 FLD_TEMPLATENAME = 1;
            const Int32 FLD_ISREMOVED = 2;

            PRMPreBOQTemplateEntity pRMPreBOQTemplateEntity = new PRMPreBOQTemplateEntity();

            pRMPreBOQTemplateEntity.PreBOQTemplateID = reader.GetInt64(FLD_PREBOQTEMPLATEID);
            pRMPreBOQTemplateEntity.TemplateName = reader.GetString(FLD_TEMPLATENAME);
            pRMPreBOQTemplateEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return pRMPreBOQTemplateEntity;
        }
    }
}
