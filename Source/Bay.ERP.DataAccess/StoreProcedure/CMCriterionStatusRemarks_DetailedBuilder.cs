// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Mar-2012, 11:54:12




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMCriterionStatusRemarks_DetailedBuilder : IEntityBuilder<CMCriterionStatusRemarks_DetailedEntity>
    {
        IList<CMCriterionStatusRemarks_DetailedEntity> IEntityBuilder<CMCriterionStatusRemarks_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<CMCriterionStatusRemarks_DetailedEntity> CMCriterionStatusRemarks_DetailedEntityList = new List<CMCriterionStatusRemarks_DetailedEntity>();

            while (reader.Read())
            {
                CMCriterionStatusRemarks_DetailedEntityList.Add(((IEntityBuilder<CMCriterionStatusRemarks_DetailedEntity>)this).BuildEntity(reader));
            }

            return (CMCriterionStatusRemarks_DetailedEntityList.Count > 0) ? CMCriterionStatusRemarks_DetailedEntityList : null;
        }

        CMCriterionStatusRemarks_DetailedEntity IEntityBuilder<CMCriterionStatusRemarks_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CRITERIONSTATUSREMARKSID = 0;
            const Int32 FLD_CONTRACTORID = 1;
            const Int32 FLD_REFERENCECRITERIONCATEGORYID = 2;
            const Int32 FLD_CONTRACTORCRITERIONSTATUSID = 3;
            const Int32 FLD_MEMBERID = 4;
            const Int32 FLD_REMARKS = 5;
            const Int32 FLD_CONTRACTORNAME = 6;
            const Int32 FLD_CRITERIONCATEGORYNAME = 7;
            const Int32 FLD_CONTRACTORCRITERIONSTATUSNAME = 8;
            const Int32 FLD_MEMBERFULLNAME = 9;
            const Int32 FLD_ROWNUMBER = 10;

            CMCriterionStatusRemarks_DetailedEntity cMCriterionStatusRemarks_DetailedEntity = new CMCriterionStatusRemarks_DetailedEntity();

            cMCriterionStatusRemarks_DetailedEntity.CriterionStatusRemarksID = reader.GetInt64(FLD_CRITERIONSTATUSREMARKSID);
            cMCriterionStatusRemarks_DetailedEntity.ContractorID = reader.GetInt64(FLD_CONTRACTORID);
            cMCriterionStatusRemarks_DetailedEntity.ReferenceCriterionCategoryID = reader.GetInt64(FLD_REFERENCECRITERIONCATEGORYID);
            if (reader.IsDBNull(FLD_CONTRACTORCRITERIONSTATUSID)) { cMCriterionStatusRemarks_DetailedEntity.ContractorCriterionStatusID = null; } else { cMCriterionStatusRemarks_DetailedEntity.ContractorCriterionStatusID = reader.GetInt64(FLD_CONTRACTORCRITERIONSTATUSID); }
            cMCriterionStatusRemarks_DetailedEntity.MemberID = reader.GetInt64(FLD_MEMBERID);
            if (reader.IsDBNull(FLD_REMARKS)) { cMCriterionStatusRemarks_DetailedEntity.Remarks = String.Empty; } else { cMCriterionStatusRemarks_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_CONTRACTORNAME)) { cMCriterionStatusRemarks_DetailedEntity.ContractorName = String.Empty; } else { cMCriterionStatusRemarks_DetailedEntity.ContractorName = reader.GetString(FLD_CONTRACTORNAME); }
            if (reader.IsDBNull(FLD_CRITERIONCATEGORYNAME)) { cMCriterionStatusRemarks_DetailedEntity.CriterionCategoryName = String.Empty; } else { cMCriterionStatusRemarks_DetailedEntity.CriterionCategoryName = reader.GetString(FLD_CRITERIONCATEGORYNAME); }
            if (reader.IsDBNull(FLD_CONTRACTORCRITERIONSTATUSNAME)) { cMCriterionStatusRemarks_DetailedEntity.ContractorCriterionStatusName = String.Empty; } else { cMCriterionStatusRemarks_DetailedEntity.ContractorCriterionStatusName = reader.GetString(FLD_CONTRACTORCRITERIONSTATUSNAME); }
            if (reader.IsDBNull(FLD_MEMBERFULLNAME)) { cMCriterionStatusRemarks_DetailedEntity.MemberFullName = String.Empty; } else { cMCriterionStatusRemarks_DetailedEntity.MemberFullName = reader.GetString(FLD_MEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { cMCriterionStatusRemarks_DetailedEntity.RowNumber = null; } else { cMCriterionStatusRemarks_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return cMCriterionStatusRemarks_DetailedEntity;
        }
    }
}
