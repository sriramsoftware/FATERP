// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Jan-2014, 01:58:57




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
    internal sealed partial class HREmployeeSalaryPayment_RPTDataAccess : BaseDataAccess, IHREmployeeSalaryPayment_RPTDataAccess
    {
        #region Constructors

        public HREmployeeSalaryPayment_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREmployeeSalaryPayment_RPTEntity> CreateEntityBuilder<HREmployeeSalaryPayment_RPTEntity>()
        {
            return (new HREmployeeSalaryPayment_RPTBuilder()) as IEntityBuilder<HREmployeeSalaryPayment_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<HREmployeeSalaryPayment_RPTEntity> IHREmployeeSalaryPayment_RPTDataAccess.GetIL(Int64 salarySessionID, Int64 from, Int64 to, Int64 other)
        {
            try
            {
                const string SP = "dbo.HREmployeeSalaryPayment_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, salarySessionID);
                    Database.AddInParameter(cmd, "@From", DbType.Int64, from);
                    Database.AddInParameter(cmd, "@To", DbType.Int64, to);
                    Database.AddInParameter(cmd, "@Other", DbType.Int64, other);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREmployeeSalaryPayment_RPTEntity> list = CreateEntityBuilder<HREmployeeSalaryPayment_RPTEntity>().BuildEntities(reader);

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

        DataTable IHREmployeeSalaryPayment_RPTDataAccess.GetDT(Int64 salarySessionID, Int64 from, Int64 to, Int64 other)
        {
            try
            {
                const string SP = "dbo.HREmployeeSalaryPayment_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, salarySessionID);
                    Database.AddInParameter(cmd, "@From", DbType.Int64, from);
                    Database.AddInParameter(cmd, "@To", DbType.Int64, to);
                    Database.AddInParameter(cmd, "@Other", DbType.Int64, other);

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
