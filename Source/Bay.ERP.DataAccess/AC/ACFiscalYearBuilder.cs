// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Jan-2013, 03:35:13




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACFiscalYearBuilder : IEntityBuilder<ACFiscalYearEntity>
    {
        IList<ACFiscalYearEntity> IEntityBuilder<ACFiscalYearEntity>.BuildEntities(IDataReader reader)
        {
            List<ACFiscalYearEntity> ACFiscalYearEntityList = new List<ACFiscalYearEntity>();

            while (reader.Read())
            {
                ACFiscalYearEntityList.Add(((IEntityBuilder<ACFiscalYearEntity>)this).BuildEntity(reader));
            }

            return (ACFiscalYearEntityList.Count > 0) ? ACFiscalYearEntityList : null;
        }

        ACFiscalYearEntity IEntityBuilder<ACFiscalYearEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_FISCALYEARID = 0;
            const Int32 FLD_BEGINDATE = 1;
            const Int32 FLD_ENDDATE = 2;
            const Int32 FLD_ISCLOSED = 3;
            const Int32 FLD_ISLOCKED = 4;
            const Int32 FLD_ISREMOVED = 5;

            ACFiscalYearEntity aCFiscalYearEntity = new ACFiscalYearEntity();

            aCFiscalYearEntity.FiscalYearID = reader.GetInt64(FLD_FISCALYEARID);
            aCFiscalYearEntity.BeginDate = reader.GetDateTime(FLD_BEGINDATE);
            aCFiscalYearEntity.EndDate = reader.GetDateTime(FLD_ENDDATE);
            aCFiscalYearEntity.IsClosed = reader.GetBoolean(FLD_ISCLOSED);
            aCFiscalYearEntity.IsLocked = reader.GetBoolean(FLD_ISLOCKED);
            aCFiscalYearEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return aCFiscalYearEntity;
        }
    }
}
