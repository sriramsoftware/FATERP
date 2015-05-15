// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Jan-2012, 11:52:45




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMCriterionStatusRemarksBuilder : IEntityBuilder<CMCriterionStatusRemarksEntity>
    {
        IList<CMCriterionStatusRemarksEntity> IEntityBuilder<CMCriterionStatusRemarksEntity>.BuildEntities(IDataReader reader)
        {
            List<CMCriterionStatusRemarksEntity> CMCriterionStatusRemarksEntityList = new List<CMCriterionStatusRemarksEntity>();

            while (reader.Read())
            {
                CMCriterionStatusRemarksEntityList.Add(((IEntityBuilder<CMCriterionStatusRemarksEntity>)this).BuildEntity(reader));
            }

            return (CMCriterionStatusRemarksEntityList.Count > 0) ? CMCriterionStatusRemarksEntityList : null;
        }

        CMCriterionStatusRemarksEntity IEntityBuilder<CMCriterionStatusRemarksEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CRITERIONSTATUSREMARKSID = 0;
            const Int32 FLD_CONTRACTORID = 1;
            const Int32 FLD_REFERENCECRITERIONCATEGORYID = 2;
            const Int32 FLD_CONTRACTORCRITERIONSTATUSID = 3;
            const Int32 FLD_MEMBERID = 4;
            const Int32 FLD_REMARKS = 5;

            CMCriterionStatusRemarksEntity cMCriterionStatusRemarksEntity = new CMCriterionStatusRemarksEntity();

            cMCriterionStatusRemarksEntity.CriterionStatusRemarksID = reader.GetInt64(FLD_CRITERIONSTATUSREMARKSID);
            cMCriterionStatusRemarksEntity.ContractorID = reader.GetInt64(FLD_CONTRACTORID);
            cMCriterionStatusRemarksEntity.ReferenceCriterionCategoryID = reader.GetInt64(FLD_REFERENCECRITERIONCATEGORYID);
            if (reader.IsDBNull(FLD_CONTRACTORCRITERIONSTATUSID)) { cMCriterionStatusRemarksEntity.ContractorCriterionStatusID = null; } else { cMCriterionStatusRemarksEntity.ContractorCriterionStatusID = reader.GetInt64(FLD_CONTRACTORCRITERIONSTATUSID); }
            cMCriterionStatusRemarksEntity.MemberID = reader.GetInt64(FLD_MEMBERID);
            if (reader.IsDBNull(FLD_REMARKS)) { cMCriterionStatusRemarksEntity.Remarks = String.Empty; } else { cMCriterionStatusRemarksEntity.Remarks = reader.GetString(FLD_REMARKS); }

            return cMCriterionStatusRemarksEntity;
        }
    }
}
