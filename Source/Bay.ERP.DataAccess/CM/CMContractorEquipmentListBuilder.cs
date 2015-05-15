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
    internal sealed class CMContractorEquipmentListBuilder : IEntityBuilder<CMContractorEquipmentListEntity>
    {
        IList<CMContractorEquipmentListEntity> IEntityBuilder<CMContractorEquipmentListEntity>.BuildEntities(IDataReader reader)
        {
            List<CMContractorEquipmentListEntity> CMContractorEquipmentListEntityList = new List<CMContractorEquipmentListEntity>();

            while (reader.Read())
            {
                CMContractorEquipmentListEntityList.Add(((IEntityBuilder<CMContractorEquipmentListEntity>)this).BuildEntity(reader));
            }

            return (CMContractorEquipmentListEntityList.Count > 0) ? CMContractorEquipmentListEntityList : null;
        }

        CMContractorEquipmentListEntity IEntityBuilder<CMContractorEquipmentListEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CONTRACTOREQUIPMENTID = 0;
            const Int32 FLD_CONTRACTORID = 1;
            const Int32 FLD_CONSTRUCTIONTOOLID = 2;

            CMContractorEquipmentListEntity cMContractorEquipmentListEntity = new CMContractorEquipmentListEntity();

            cMContractorEquipmentListEntity.ContractorEquipmentID = reader.GetInt64(FLD_CONTRACTOREQUIPMENTID);
            cMContractorEquipmentListEntity.ContractorID = reader.GetInt64(FLD_CONTRACTORID);
            cMContractorEquipmentListEntity.ConstructionToolID = reader.GetInt64(FLD_CONSTRUCTIONTOOLID);

            return cMContractorEquipmentListEntity;
        }
    }
}
