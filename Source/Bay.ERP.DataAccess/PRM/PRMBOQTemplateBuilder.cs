// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-May-2012, 05:58:01




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMBOQTemplateBuilder : IEntityBuilder<PRMBOQTemplateEntity>
    {
        IList<PRMBOQTemplateEntity> IEntityBuilder<PRMBOQTemplateEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMBOQTemplateEntity> PRMBOQTemplateEntityList = new List<PRMBOQTemplateEntity>();

            while (reader.Read())
            {
                PRMBOQTemplateEntityList.Add(((IEntityBuilder<PRMBOQTemplateEntity>)this).BuildEntity(reader));
            }

            return (PRMBOQTemplateEntityList.Count > 0) ? PRMBOQTemplateEntityList : null;
        }

        PRMBOQTemplateEntity IEntityBuilder<PRMBOQTemplateEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BOQTEMPLATEID = 0;
            const Int32 FLD_TEMPLATENAME = 1;
            const Int32 FLD_ISREMOVED = 2;

            PRMBOQTemplateEntity pRMBOQTemplateEntity = new PRMBOQTemplateEntity();

            pRMBOQTemplateEntity.BOQTemplateID = reader.GetInt64(FLD_BOQTEMPLATEID);
            pRMBOQTemplateEntity.TemplateName = reader.GetString(FLD_TEMPLATENAME);
            pRMBOQTemplateEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return pRMBOQTemplateEntity;
        }
    }
}
