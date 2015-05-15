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
    internal sealed partial class ACTrialBalanceForActiveFiscalYear_RPTDataAccess : BaseDataAccess, IACTrialBalanceForActiveFiscalYear_RPTDataAccess
    {
        #region Constructors

        public ACTrialBalanceForActiveFiscalYear_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ACTrialBalanceForActiveFiscalYear_RPTEntity> CreateEntityBuilder<ACTrialBalanceForActiveFiscalYear_RPTEntity>()
        {
            return (new ACTrialBalanceForActiveFiscalYear_RPTBuilder()) as IEntityBuilder<ACTrialBalanceForActiveFiscalYear_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<ACTrialBalanceForActiveFiscalYear_RPTEntity> IACTrialBalanceForActiveFiscalYear_RPTDataAccess.GetIL(Int64 fiscalYearID)
        {
            try
            {
                const string SP = "dbo.ACTrialBalanceForActiveFiscalYear_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, fiscalYearID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ACTrialBalanceForActiveFiscalYear_RPTEntity> list = CreateEntityBuilder<ACTrialBalanceForActiveFiscalYear_RPTEntity>().BuildEntities(reader);

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

        DataTable IACTrialBalanceForActiveFiscalYear_RPTDataAccess.GetDT(Int64 fiscalYearID)
        {
            try
            {
                const string SP = "dbo.ACTrialBalanceForActiveFiscalYear_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
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
