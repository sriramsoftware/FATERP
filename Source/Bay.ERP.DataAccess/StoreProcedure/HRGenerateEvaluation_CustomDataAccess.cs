// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Sep-2013, 06:31:16




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
    internal sealed partial class HRGenerateEvaluation_CustomDataAccess : BaseDataAccess, IHRGenerateEvaluation_CustomDataAccess
    {
        #region Constructors

        public HRGenerateEvaluation_CustomDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HRGenerateEvaluation_CustomEntity> CreateEntityBuilder<HRGenerateEvaluation_CustomEntity>()
        {
            return (new HRGenerateEvaluation_CustomBuilder()) as IEntityBuilder<HRGenerateEvaluation_CustomEntity>;
        }

        #endregion


        #region GetAll

        IList<HRGenerateEvaluation_CustomEntity> IHRGenerateEvaluation_CustomDataAccess.GetIL(Int64 sessionID, Int64 evaluatedBy, Int64 salaryLevelFrom, Int64 salaryLevelTo)
        {
            try
            {
                const string SP = "dbo.HRGenerateEvaluation_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@SessionID", DbType.Int64, sessionID);	
				    Database.AddInParameter(cmd, "@EvaluatedBy", DbType.Int64, evaluatedBy);	
				    Database.AddInParameter(cmd, "@SalaryLevelFrom", DbType.Int64, salaryLevelFrom);	
				    Database.AddInParameter(cmd, "@SalaryLevelTo", DbType.Int64, salaryLevelTo);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HRGenerateEvaluation_CustomEntity> list = CreateEntityBuilder<HRGenerateEvaluation_CustomEntity>().BuildEntities(reader);

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

        DataTable IHRGenerateEvaluation_CustomDataAccess.GetDT(Int64 sessionID, Int64 evaluatedBy, Int64 salaryLevelFrom, Int64 salaryLevelTo)
        {
            try
            {
                const string SP = "dbo.HRGenerateEvaluation_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@SessionID", DbType.Int64, sessionID);	
				    Database.AddInParameter(cmd, "@EvaluatedBy", DbType.Int64, evaluatedBy);	
				    Database.AddInParameter(cmd, "@SalaryLevelFrom", DbType.Int64, salaryLevelFrom);	
				    Database.AddInParameter(cmd, "@SalaryLevelTo", DbType.Int64, salaryLevelTo);	

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
