// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Apr-2013, 11:16:54




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
    internal sealed partial class ACTrialBalance_CustomDataAccess : BaseDataAccess, IACTrialBalance_CustomDataAccess
    {
        #region Constructors

        public ACTrialBalance_CustomDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ACTrialBalance_CustomEntity> CreateEntityBuilder<ACTrialBalance_CustomEntity>()
        {
            return (new ACTrialBalance_CustomBuilder()) as IEntityBuilder<ACTrialBalance_CustomEntity>;
        }

        #endregion


        #region GetAll

        IList<ACTrialBalance_CustomEntity> IACTrialBalance_CustomDataAccess.GetIL(DateTime fromDate, DateTime toDate, Int64 fiscalYearID)
        {
            try
            {
                const string SP = "dbo.ACTrialBalance_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@FromDate", DbType.DateTime, fromDate);	
				    Database.AddInParameter(cmd, "@ToDate", DbType.DateTime, toDate);	
				    Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, fiscalYearID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ACTrialBalance_CustomEntity> list = CreateEntityBuilder<ACTrialBalance_CustomEntity>().BuildEntities(reader);

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

        DataTable IACTrialBalance_CustomDataAccess.GetDT(DateTime fromDate, DateTime toDate, Int64 fiscalYearID)
        {
            try
            {
                const string SP = "dbo.ACTrialBalance_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@FromDate", DbType.DateTime, fromDate);	
				    Database.AddInParameter(cmd, "@ToDate", DbType.DateTime, toDate);	
				    Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, fiscalYearID);	

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
