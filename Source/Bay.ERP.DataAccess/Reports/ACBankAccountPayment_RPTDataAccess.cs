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
    internal sealed partial class ACBankAccountPayment_RPTDataAccess : BaseDataAccess, IACBankAccountPayment_RPTDataAccess
    {
        #region Constructors

        public ACBankAccountPayment_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ACBankAccountPayment_RPTEntity> CreateEntityBuilder<ACBankAccountPayment_RPTEntity>()
        {
            return (new ACBankAccountPayment_RPTBuilder()) as IEntityBuilder<ACBankAccountPayment_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<ACBankAccountPayment_RPTEntity> IACBankAccountPayment_RPTDataAccess.GetIL(Int64 bankAccountPaymentID)
        {
            try
            {
                const string SP = "dbo.ACBankAccountPayment_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@BankAccountPaymentID", DbType.Int64, bankAccountPaymentID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ACBankAccountPayment_RPTEntity> list = CreateEntityBuilder<ACBankAccountPayment_RPTEntity>().BuildEntities(reader);

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

        DataTable IACBankAccountPayment_RPTDataAccess.GetDT(Int64 bankAccountPaymentID)
        {
            try
            {
                const string SP = "dbo.ACBankAccountPayment_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@BankAccountPaymentID", DbType.Int64, bankAccountPaymentID);	

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
