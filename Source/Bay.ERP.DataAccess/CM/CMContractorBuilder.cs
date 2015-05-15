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
    internal sealed class CMContractorBuilder : IEntityBuilder<CMContractorEntity>
    {
        IList<CMContractorEntity> IEntityBuilder<CMContractorEntity>.BuildEntities(IDataReader reader)
        {
            List<CMContractorEntity> CMContractorEntityList = new List<CMContractorEntity>();

            while (reader.Read())
            {
                CMContractorEntityList.Add(((IEntityBuilder<CMContractorEntity>)this).BuildEntity(reader));
            }

            return (CMContractorEntityList.Count > 0) ? CMContractorEntityList : null;
        }

        CMContractorEntity IEntityBuilder<CMContractorEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CONTRACTORID = 0;
            const Int32 FLD_MEMBERID = 1;
            const Int32 FLD_NAMEOFWORK = 2;
            const Int32 FLD_DATE = 3;
            const Int32 FLD_NAME = 4;
            const Int32 FLD_PREPAREDBY = 5;
            const Int32 FLD_ISREMOVED = 6;

            CMContractorEntity cMContractorEntity = new CMContractorEntity();

            cMContractorEntity.ContractorID = reader.GetInt64(FLD_CONTRACTORID);
            cMContractorEntity.MemberID = reader.GetInt64(FLD_MEMBERID);
            cMContractorEntity.NameOfWork = reader.GetString(FLD_NAMEOFWORK);
            cMContractorEntity.Date = reader.GetDateTime(FLD_DATE);
            cMContractorEntity.Name = reader.GetString(FLD_NAME);
            cMContractorEntity.PreparedBy = reader.GetInt64(FLD_PREPAREDBY);
            cMContractorEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return cMContractorEntity;
        }
    }
}
