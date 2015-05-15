// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Jan-2012, 06:01:25




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMContractorEquipmentList_DetailedBuilder : IEntityBuilder<CMContractorEquipmentList_DetailedEntity>
    {
        IList<CMContractorEquipmentList_DetailedEntity> IEntityBuilder<CMContractorEquipmentList_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<CMContractorEquipmentList_DetailedEntity> CMContractorEquipmentList_DetailedEntityList = new List<CMContractorEquipmentList_DetailedEntity>();

            while (reader.Read())
            {
                CMContractorEquipmentList_DetailedEntityList.Add(((IEntityBuilder<CMContractorEquipmentList_DetailedEntity>)this).BuildEntity(reader));
            }

            return (CMContractorEquipmentList_DetailedEntityList.Count > 0) ? CMContractorEquipmentList_DetailedEntityList : null;
        }

        CMContractorEquipmentList_DetailedEntity IEntityBuilder<CMContractorEquipmentList_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CONTRACTOREQUIPMENTID = 0;
            const Int32 FLD_CONTRACTORID = 1;
            const Int32 FLD_CONSTRUCTIONTOOLID = 2;
            const Int32 FLD_CONTRACTORNAME = 3;
            const Int32 FLD_CONSTRUCTIONTOOLNAME = 4;
            const Int32 FLD_ROWNUMBER = 5;

            CMContractorEquipmentList_DetailedEntity cMContractorEquipmentList_DetailedEntity = new CMContractorEquipmentList_DetailedEntity();

            cMContractorEquipmentList_DetailedEntity.ContractorEquipmentID = reader.GetInt64(FLD_CONTRACTOREQUIPMENTID);
            cMContractorEquipmentList_DetailedEntity.ContractorID = reader.GetInt64(FLD_CONTRACTORID);
            cMContractorEquipmentList_DetailedEntity.ConstructionToolID = reader.GetInt64(FLD_CONSTRUCTIONTOOLID);
            if (reader.IsDBNull(FLD_CONTRACTORNAME)) { cMContractorEquipmentList_DetailedEntity.ContractorName = String.Empty; } else { cMContractorEquipmentList_DetailedEntity.ContractorName = reader.GetString(FLD_CONTRACTORNAME); }
            if (reader.IsDBNull(FLD_CONSTRUCTIONTOOLNAME)) { cMContractorEquipmentList_DetailedEntity.ConstructionToolName = String.Empty; } else { cMContractorEquipmentList_DetailedEntity.ConstructionToolName = reader.GetString(FLD_CONSTRUCTIONTOOLNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { cMContractorEquipmentList_DetailedEntity.RowNumber = null; } else { cMContractorEquipmentList_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return cMContractorEquipmentList_DetailedEntity;
        }
    }
}
