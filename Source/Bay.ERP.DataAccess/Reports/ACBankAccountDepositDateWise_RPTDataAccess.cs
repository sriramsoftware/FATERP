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
    internal sealed partial class ACBankAccountDepositDateWise_RPTDataAccess : BaseDataAccess, IACBankAccountDepositDateWise_RPTDataAccess
    {
        #region Constructors

        public ACBankAccountDepositDateWise_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ACBankAccountDepositDateWise_RPTEntity> CreateEntityBuilder<ACBankAccountDepositDateWise_RPTEntity>()
        {
            return (new ACBankAccountDepositDateWise_RPTBuilder()) as IEntityBuilder<ACBankAccountDepositDateWise_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<ACBankAccountDepositDateWise_RPTEntity> IACBankAccountDepositDateWise_RPTDataAccess.GetIL(DateTime fromDate, DateTime toDate)
        {
            try
            {
                const string SP = "dbo.ACBankAccountDepositDateWise_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@FromDate", DbType.DateTime, fromDate);	
				    Database.AddInParameter(cmd, "@ToDate", DbType.DateTime, toDate);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ACBankAccountDepositDateWise_RPTEntity> list = CreateEntityBuilder<ACBankAccountDepositDateWise_RPTEntity>().BuildEntities(reader);

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

        DataTable IACBankAccountDepositDateWise_RPTDataAccess.GetDT(DateTime fromDate, DateTime toDate)
        {
            try
            {
                const string SP = "dbo.ACBankAccountDepositDateWise_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
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