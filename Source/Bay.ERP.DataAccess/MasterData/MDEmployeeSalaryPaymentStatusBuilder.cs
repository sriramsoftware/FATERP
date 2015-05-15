// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Jan-2014, 03:42:17




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDEmployeeSalaryPaymentStatusBuilder : IEntityBuilder<MDEmployeeSalaryPaymentStatusEntity>
    {
        IList<MDEmployeeSalaryPaymentStatusEntity> IEntityBuilder<MDEmployeeSalaryPaymentStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<MDEmployeeSalaryPaymentStatusEntity> MDEmployeeSalaryPaymentStatusEntityList = new List<MDEmployeeSalaryPaymentStatusEntity>();

            while (reader.Read())
            {
                MDEmployeeSalaryPaymentStatusEntityList.Add(((IEntityBuilder<MDEmployeeSalaryPaymentStatusEntity>)this).BuildEntity(reader));
            }

            return (MDEmployeeSalaryPaymentStatusEntityList.Count > 0) ? MDEmployeeSalaryPaymentStatusEntityList : null;
        }

        MDEmployeeSalaryPaymentStatusEntity IEntityBuilder<MDEmployeeSalaryPaymentStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEESALARYPAYMENTSTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_ISREMOVED = 2;

            MDEmployeeSalaryPaymentStatusEntity mDEmployeeSalaryPaymentStatusEntity = new MDEmployeeSalaryPaymentStatusEntity();

            mDEmployeeSalaryPaymentStatusEntity.EmployeeSalaryPaymentStatusID = reader.GetInt64(FLD_EMPLOYEESALARYPAYMENTSTATUSID);
            mDEmployeeSalaryPaymentStatusEntity.Name = reader.GetString(FLD_NAME);
            mDEmployeeSalaryPaymentStatusEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDEmployeeSalaryPaymentStatusEntity;
        }
    }
}
