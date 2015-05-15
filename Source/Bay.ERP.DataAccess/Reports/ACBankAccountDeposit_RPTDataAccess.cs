// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Jul-2013, 10:23:15




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
    internal sealed partial class ACBankAccountDeposit_RPTDataAccess : BaseDataAccess, IACBankAccountDeposit_RPTDataAccess
    {
        #region Constructors

        public ACBankAccountDeposit_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ACBankAccountDeposit_RPTEntity> CreateEntityBuilder<ACBankAccountDeposit_RPTEntity>()
        {
            return (new ACBankAccountDeposit_RPTBuilder()) as IEntityBuilder<ACBankAccountDeposit_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<ACBankAccountDeposit_RPTEntity> IACBankAccountDeposit_RPTDataAccess.GetIL(Int64 bankAccountDepositID)
        {
            try
            {
                const string SP = "dbo.ACBankAccountDeposit_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@BankAccountDepositID", DbType.Int64, bankAccountDepositID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ACBankAccountDeposit_RPTEntity> list = CreateEntityBuilder<ACBankAccountDeposit_RPTEntity>().BuildEntities(reader);

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

        DataTable IACBankAccountDeposit_RPTDataAccess.GetDT(Int64 bankAccountDepositID)
        {
            try
            {
                const string SP = "dbo.ACBankAccountDeposit_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@BankAccountDepositID", DbType.Int64, bankAccountDepositID);	

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
