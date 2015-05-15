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
    internal sealed class CMContractorMajorProjectExecutedBuilder : IEntityBuilder<CMContractorMajorProjectExecutedEntity>
    {
        IList<CMContractorMajorProjectExecutedEntity> IEntityBuilder<CMContractorMajorProjectExecutedEntity>.BuildEntities(IDataReader reader)
        {
            List<CMContractorMajorProjectExecutedEntity> CMContractorMajorProjectExecutedEntityList = new List<CMContractorMajorProjectExecutedEntity>();

            while (reader.Read())
            {
                CMContractorMajorProjectExecutedEntityList.Add(((IEntityBuilder<CMContractorMajorProjectExecutedEntity>)this).BuildEntity(reader));
            }

            return (CMContractorMajorProjectExecutedEntityList.Count > 0) ? CMContractorMajorProjectExecutedEntityList : null;
        }

        CMContractorMajorProjectExecutedEntity IEntityBuilder<CMContractorMajorProjectExecutedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CONTRACTORMAJORPROJECTEXECUTEDID = 0;
            const Int32 FLD_CONTRACTORID = 1;
            const Int32 FLD_NAME = 2;

            CMContractorMajorProjectExecutedEntity cMContractorMajorProjectExecutedEntity = new CMContractorMajorProjectExecutedEntity();

            cMContractorMajorProjectExecutedEntity.ContractorMajorProjectExecutedID = reader.GetInt64(FLD_CONTRACTORMAJORPROJECTEXECUTEDID);
            cMContractorMajorProjectExecutedEntity.ContractorID = reader.GetInt64(FLD_CONTRACTORID);
            cMContractorMajorProjectExecutedEntity.Name = reader.GetString(FLD_NAME);

            return cMContractorMajorProjectExecutedEntity;
        }
    }
}
