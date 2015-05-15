// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Jul-2013, 11:29:54




using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;
using Bay.ERP.DataAccess;

namespace Bay.ERP.DataAccess
{
    internal sealed partial class HREmployeeSalaryDisbursementBank_RPTDataAccess : BaseDataAccess, IHREmployeeSalaryDisbursementBank_RPTDataAccess
    {
        #region Constructors

        public HREmployeeSalaryDisbursementBank_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREmployeeSalaryDisbursementBank_RPTEntity> CreateEntityBuilder<HREmployeeSalaryDisbursementBank_RPTEntity>()
        {
            return (new HREmployeeSalaryDisbursementBank_RPTBuilder()) as IEntityBuilder<HREmployeeSalaryDisbursementBank_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<HREmployeeSalaryDisbursementBank_RPTEntity> IHREmployeeSalaryDisbursementBank_RPTDataAccess.GetIL(Int64 salarySessionID, Int64 fromLevel, Int64 toLevel)
        {
            try
            {
                const string SP = "dbo.HREmployeeSalaryDisbursementBank_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, salarySessionID);
                    Database.AddInParameter(cmd, "@FromLevel", DbType.Int64, fromLevel);
                    Database.AddInParameter(cmd, "@ToLevel", DbType.Int64, toLevel);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREmployeeSalaryDisbursementBank_RPTEntity> list = CreateEntityBuilder<HREmployeeSalaryDisbursementBank_RPTEntity>().BuildEntities(reader);

                        if (list != null && list.Count > 0)
                        {
                            if ((reader.NextResult()) && (reader.Read()))
                            {
                                list[0].TotalRowCount = reader.GetInt32(0);
                            }
                        }

                        return list;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        DataTable IHREmployeeSalaryDisbursementBank_RPTDataAccess.GetDT(Int64 salarySessionID, Int64 fromLevel, Int64 toLevel)
        {
            try
            {
                const string SP = "dbo.HREmployeeSalaryDisbursementBank_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, salarySessionID); 
                    Database.AddInParameter(cmd, "@FromLevel", DbType.Int64, fromLevel);
                    Database.AddInParameter(cmd, "@ToLevel", DbType.Int64, toLevel);

                    DataSet ds = new DataSet();
                    ds = Database.ExecuteDataSet(cmd);

                    if (ds.Tables.Count > 0)
                    {
                        return (ds.Tables[0]);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
