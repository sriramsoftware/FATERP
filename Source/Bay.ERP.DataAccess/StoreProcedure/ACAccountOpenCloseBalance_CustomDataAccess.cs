// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Feb-2013, 12:02:49




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
    internal sealed partial class ACAccountOpenCloseBalance_CustomDataAccess : BaseDataAccess, IACAccountOpenCloseBalance_CustomDataAccess
    {
        #region Constructors

        public ACAccountOpenCloseBalance_CustomDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ACAccountOpenCloseBalance_CustomEntity> CreateEntityBuilder<ACAccountOpenCloseBalance_CustomEntity>()
        {
            return (new ACAccountOpenCloseBalance_CustomBuilder()) as IEntityBuilder<ACAccountOpenCloseBalance_CustomEntity>;
        }

        #endregion


        #region GetAll

        IList<ACAccountOpenCloseBalance_CustomEntity> IACAccountOpenCloseBalance_CustomDataAccess.GetIL(Int64 accountID, Int64 fiscalYearID, DateTime fromDate, DateTime toDate)
        {
            try
            {
                const string SP = "dbo.ACAccountOpenCloseBalance_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@AccountID", DbType.Int64, accountID);	
				    Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, fiscalYearID);	
				    Database.AddInParameter(cmd, "@FromDate", DbType.DateTime, fromDate);	
				    Database.AddInParameter(cmd, "@ToDate", DbType.DateTime, toDate);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ACAccountOpenCloseBalance_CustomEntity> list = CreateEntityBuilder<ACAccountOpenCloseBalance_CustomEntity>().BuildEntities(reader);

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

        DataTable IACAccountOpenCloseBalance_CustomDataAccess.GetDT(Int64 accountID, Int64 fiscalYearID, DateTime fromDate, DateTime toDate)
        {
            try
            {
                const string SP = "dbo.ACAccountOpenCloseBalance_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@AccountID", DbType.Int64, accountID);	
				    Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, fiscalYearID);	
				    Database.AddInParameter(cmd, "@FromDate", DbType.DateTime, fromDate);	
				    Database.AddInParameter(cmd, "@ToDate", DbType.DateTime, toDate);	

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
