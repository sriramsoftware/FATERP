// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Dec-2013, 06:06:24




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
    internal sealed partial class HRWorkingDay_RPTDataAccess : BaseDataAccess, IHRWorkingDay_RPTDataAccess
    {
        #region Constructors

        public HRWorkingDay_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HRWorkingDay_RPTEntity> CreateEntityBuilder<HRWorkingDay_RPTEntity>()
        {
            return (new HRWorkingDay_RPTBuilder()) as IEntityBuilder<HRWorkingDay_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<HRWorkingDay_RPTEntity> IHRWorkingDay_RPTDataAccess.GetIL(Int64 salarySessionID)
        {
            try
            {
                const string SP = "dbo.HRWorkingDay_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, salarySessionID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HRWorkingDay_RPTEntity> list = CreateEntityBuilder<HRWorkingDay_RPTEntity>().BuildEntities(reader);

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

        DataTable IHRWorkingDay_RPTDataAccess.GetDT(Int64 salarySessionID)
        {
            try
            {
                const string SP = "dbo.HRWorkingDay_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, salarySessionID);	

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
