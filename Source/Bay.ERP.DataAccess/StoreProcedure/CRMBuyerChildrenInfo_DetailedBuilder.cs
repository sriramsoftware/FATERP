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
    internal sealed class CRMBuyerChildrenInfo_DetailedBuilder : IEntityBuilder<CRMBuyerChildrenInfo_DetailedEntity>
    {
        IList<CRMBuyerChildrenInfo_DetailedEntity> IEntityBuilder<CRMBuyerChildrenInfo_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMBuyerChildrenInfo_DetailedEntity> CRMBuyerChildrenInfo_DetailedEntityList = new List<CRMBuyerChildrenInfo_DetailedEntity>();

            while (reader.Read())
            {
                CRMBuyerChildrenInfo_DetailedEntityList.Add(((IEntityBuilder<CRMBuyerChildrenInfo_DetailedEntity>)this).BuildEntity(reader));
            }

            return (CRMBuyerChildrenInfo_DetailedEntityList.Count > 0) ? CRMBuyerChildrenInfo_DetailedEntityList : null;
        }

        CRMBuyerChildrenInfo_DetailedEntity IEntityBuilder<CRMBuyerChildrenInfo_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BUYERCHILDRENINFOID = 0;
            const Int32 FLD_BUYERBASICINFOID = 1;
            const Int32 FLD_NAME = 2;
            const Int32 FLD_DOB = 3;
            const Int32 FLD_GENDERID = 4;
            const Int32 FLD_EDITIONALINSTITUTENAME = 5;
            const Int32 FLD_GENDERNAME = 6;
            const Int32 FLD_ROWNUMBER = 7;

            CRMBuyerChildrenInfo_DetailedEntity cRMBuyerChildrenInfo_DetailedEntity = new CRMBuyerChildrenInfo_DetailedEntity();

            cRMBuyerChildrenInfo_DetailedEntity.BuyerChildrenInfoID = reader.GetInt64(FLD_BUYERCHILDRENINFOID);
            cRMBuyerChildrenInfo_DetailedEntity.BuyerBasicInfoID = reader.GetInt64(FLD_BUYERBASICINFOID);
            cRMBuyerChildrenInfo_DetailedEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DOB)) { cRMBuyerChildrenInfo_DetailedEntity.DOB = null; } else { cRMBuyerChildrenInfo_DetailedEntity.DOB = reader.GetDateTime(FLD_DOB); }
            cRMBuyerChildrenInfo_DetailedEntity.GenderID = reader.GetInt64(FLD_GENDERID);
            if (reader.IsDBNull(FLD_EDITIONALINSTITUTENAME)) { cRMBuyerChildrenInfo_DetailedEntity.EditionalInstituteName = String.Empty; } else { cRMBuyerChildrenInfo_DetailedEntity.EditionalInstituteName = reader.GetString(FLD_EDITIONALINSTITUTENAME); }
            cRMBuyerChildrenInfo_DetailedEntity.GenderName = reader.GetString(FLD_GENDERNAME);
            if (reader.IsDBNull(FLD_ROWNUMBER)) { cRMBuyerChildrenInfo_DetailedEntity.RowNumber = null; } else { cRMBuyerChildrenInfo_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return cRMBuyerChildrenInfo_DetailedEntity;
        }
    }
}
