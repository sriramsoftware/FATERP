// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Jan-2012, 02:49:42




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMFinancialStrengthMajorWorkBuilder : IEntityBuilder<CMFinancialStrengthMajorWorkEntity>
    {
        IList<CMFinancialStrengthMajorWorkEntity> IEntityBuilder<CMFinancialStrengthMajorWorkEntity>.BuildEntities(IDataReader reader)
        {
            List<CMFinancialStrengthMajorWorkEntity> CMFinancialStrengthMajorWorkEntityList = new List<CMFinancialStrengthMajorWorkEntity>();

            while (reader.Read())
            {
                CMFinancialStrengthMajorWorkEntityList.Add(((IEntityBuilder<CMFinancialStrengthMajorWorkEntity>)this).BuildEntity(reader));
            }

            return (CMFinancialStrengthMajorWorkEntityList.Count > 0) ? CMFinancialStrengthMajorWorkEntityList : null;
        }

        CMFinancialStrengthMajorWorkEntity IEntityBuilder<CMFinancialStrengthMajorWorkEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_FINANCIALSTRENGTHMAJORWORKID = 0;
            const Int32 FLD_CONTRACTORID = 1;
            const Int32 FLD_NAME = 2;

            CMFinancialStrengthMajorWorkEntity cMFinancialStrengthMajorWorkEntity = new CMFinancialStrengthMajorWorkEntity();

            cMFinancialStrengthMajorWorkEntity.FinancialStrengthMajorWorkID = reader.GetInt64(FLD_FINANCIALSTRENGTHMAJORWORKID);
            cMFinancialStrengthMajorWorkEntity.ContractorID = reader.GetInt64(FLD_CONTRACTORID);
            cMFinancialStrengthMajorWorkEntity.Name = reader.GetString(FLD_NAME);

            return cMFinancialStrengthMajorWorkEntity;
        }
    }
}
