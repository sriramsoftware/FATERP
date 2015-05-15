// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDPayscaleBuilder : IEntityBuilder<MDPayscaleEntity>
    {
        IList<MDPayscaleEntity> IEntityBuilder<MDPayscaleEntity>.BuildEntities(IDataReader reader)
        {
            List<MDPayscaleEntity> MDPayscaleEntityList = new List<MDPayscaleEntity>();

            while (reader.Read())
            {
                MDPayscaleEntityList.Add(((IEntityBuilder<MDPayscaleEntity>)this).BuildEntity(reader));
            }

            return (MDPayscaleEntityList.Count > 0) ? MDPayscaleEntityList : null;
        }

        MDPayscaleEntity IEntityBuilder<MDPayscaleEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PAYSCALEID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_MINIMUMSALARY = 3;
            const Int32 FLD_MAXIMUMSALARY = 4;
            const Int32 FLD_AVERAGESALARY = 5;
            const Int32 FLD_SALARYRATEDURATIONID = 6;
            const Int32 FLD_ISREMOVED = 7;

            MDPayscaleEntity mDPayscaleEntity = new MDPayscaleEntity();

            mDPayscaleEntity.PayscaleID = reader.GetInt64(FLD_PAYSCALEID);
            mDPayscaleEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDPayscaleEntity.Description = String.Empty; } else { mDPayscaleEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDPayscaleEntity.MinimumSalary = reader.GetDecimal(FLD_MINIMUMSALARY);
            mDPayscaleEntity.MaximumSalary = reader.GetDecimal(FLD_MAXIMUMSALARY);
            mDPayscaleEntity.AverageSalary = reader.GetDecimal(FLD_AVERAGESALARY);
            mDPayscaleEntity.SalaryRateDurationID = reader.GetInt64(FLD_SALARYRATEDURATIONID);
            mDPayscaleEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDPayscaleEntity;
        }
    }
}
