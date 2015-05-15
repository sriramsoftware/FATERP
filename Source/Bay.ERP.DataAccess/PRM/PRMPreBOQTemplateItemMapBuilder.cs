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
    internal sealed class PRMPreBOQTemplateItemMapBuilder : IEntityBuilder<PRMPreBOQTemplateItemMapEntity>
    {
        IList<PRMPreBOQTemplateItemMapEntity> IEntityBuilder<PRMPreBOQTemplateItemMapEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMPreBOQTemplateItemMapEntity> PRMPreBOQTemplateItemMapEntityList = new List<PRMPreBOQTemplateItemMapEntity>();

            while (reader.Read())
            {
                PRMPreBOQTemplateItemMapEntityList.Add(((IEntityBuilder<PRMPreBOQTemplateItemMapEntity>)this).BuildEntity(reader));
            }

            return (PRMPreBOQTemplateItemMapEntityList.Count > 0) ? PRMPreBOQTemplateItemMapEntityList : null;
        }

        PRMPreBOQTemplateItemMapEntity IEntityBuilder<PRMPreBOQTemplateItemMapEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PREBOQTEMPLATEITEMMAPID = 0;
            const Int32 FLD_PREBOQTEMPLATEID = 1;
            const Int32 FLD_ITEMID = 2;
            const Int32 FLD_SEQUENCENO = 3;

            PRMPreBOQTemplateItemMapEntity pRMPreBOQTemplateItemMapEntity = new PRMPreBOQTemplateItemMapEntity();

            pRMPreBOQTemplateItemMapEntity.PreBOQTemplateItemMapID = reader.GetInt64(FLD_PREBOQTEMPLATEITEMMAPID);
            pRMPreBOQTemplateItemMapEntity.PreBOQTemplateID = reader.GetInt64(FLD_PREBOQTEMPLATEID);
            pRMPreBOQTemplateItemMapEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            pRMPreBOQTemplateItemMapEntity.SequenceNo = reader.GetInt32(FLD_SEQUENCENO);

            return pRMPreBOQTemplateItemMapEntity;
        }
    }
}
