// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Jul-2013, 11:20:53




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
    internal sealed partial class ACBankAccountDepositDataAccess : BaseDataAccess, IACBankAccountDepositDataAccess
    {
        #region Constructors

        public ACBankAccountDepositDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ACBankAccountDepositEntity> CreateEntityBuilder<ACBankAccountDepositEntity>()
        {
            return (new ACBankAccountDepositBuilder()) as IEntityBuilder<ACBankAccountDepositEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IACBankAccountDepositDataAccess.Add(ACBankAccountDepositEntity aCBankAccountDepositEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(aCBankAccountDepositEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(aCBankAccountDepositEntity, option);
                            break;
                        }
                    default:
                        {
                            retValues = -99;
                            break;
                        }
                }

                return retValues;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Int64 Add(ACBankAccountDepositEntity aCBankAccountDepositEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACBankAccountDeposit_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "BankAccountDepositID");

                Database.AddInParameter(cmd, "@DepositDate", DbType.DateTime, aCBankAccountDepositEntity.DepositDate);	
                Database.AddInParameter(cmd, "@PaidFromID", DbType.Int64, aCBankAccountDepositEntity.PaidFromID);	
                Database.AddInParameter(cmd, "@ReferenceID", DbType.Int64, aCBankAccountDepositEntity.ReferenceID);	
                Database.AddInParameter(cmd, "@BankAccountID", DbType.Int64, aCBankAccountDepositEntity.BankAccountID);	
                Database.AddInParameter(cmd, "@Reference", DbType.String, aCBankAccountDepositEntity.Reference);	
                Database.AddInParameter(cmd, "@Name", DbType.String, aCBankAccountDepositEntity.Name);	
                Database.AddInParameter(cmd, "@Memo", DbType.String, aCBankAccountDepositEntity.Memo);	
                Database.AddInParameter(cmd, "@BankAccountDepositApprovalStatusID", DbType.Int64, aCBankAccountDepositEntity.BankAccountDepositApprovalStatusID);	
                Database.AddInParameter(cmd, "@PreparedByEmployeeID", DbType.Int64, aCBankAccountDepositEntity.PreparedByEmployeeID);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACBankAccountDepositEntity already exists. Please specify another ACBankAccountDepositEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACBankAccountDepositEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACBankAccountDepositEntity already exists. Please specify another ACBankAccountDepositEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(ACBankAccountDepositEntity aCBankAccountDepositEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACBankAccountDeposit_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "BankAccountDepositID", db);

                db.AddInParameter(cmd, "@DepositDate", DbType.DateTime, aCBankAccountDepositEntity.DepositDate);
                db.AddInParameter(cmd, "@PaidFromID", DbType.Int64, aCBankAccountDepositEntity.PaidFromID);
                db.AddInParameter(cmd, "@ReferenceID", DbType.Int64, aCBankAccountDepositEntity.ReferenceID);
                db.AddInParameter(cmd, "@BankAccountID", DbType.Int64, aCBankAccountDepositEntity.BankAccountID);
                db.AddInParameter(cmd, "@Reference", DbType.String, aCBankAccountDepositEntity.Reference);
                db.AddInParameter(cmd, "@Name", DbType.String, aCBankAccountDepositEntity.Name);
                db.AddInParameter(cmd, "@Memo", DbType.String, aCBankAccountDepositEntity.Memo);
                db.AddInParameter(cmd, "@BankAccountDepositApprovalStatusID", DbType.Int64, aCBankAccountDepositEntity.BankAccountDepositApprovalStatusID);
                db.AddInParameter(cmd, "@PreparedByEmployeeID", DbType.Int64, aCBankAccountDepositEntity.PreparedByEmployeeID);

                DbConnection connection = db.CreateConnection();
                connection.Open();
                DbTransaction transaction = connection.BeginTransaction();

                try
                {
                    returnCode = db.ExecuteNonQuery(cmd, transaction);

                    returnCode = GetReturnCodeFromParameter(cmd, db);

                    if (returnCode > 0)
                    {
                        transaction.Commit();
                    }
                    else
                    {
                        throw new ArgumentException("Error Code." + returnCode.ToString());
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
                finally
                {
                    transaction.Dispose();
                    connection.Close();
                    connection = null;
                }
            }

            return returnCode;
        }

        #endregion Add Operation

        #region Add List Operation

        IList<Int64> IACBankAccountDepositDataAccess.Add(IList<ACBankAccountDepositEntity> aCBankAccountDepositEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (ACBankAccountDepositEntity aCBankAccountDepositEntity in aCBankAccountDepositEntityList)
            {
                returnCode = (this as IACBankAccountDepositDataAccess).Add(aCBankAccountDepositEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IACBankAccountDepositDataAccess.Update(ACBankAccountDepositEntity aCBankAccountDepositEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(aCBankAccountDepositEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(aCBankAccountDepositEntity, filterExpression, option);
                            break;
                        }
                    default:
                        {
                            retValues = -99;
                            break;
                        }
                }

                return retValues;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Int64 Update(ACBankAccountDepositEntity aCBankAccountDepositEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACBankAccountDeposit_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@BankAccountDepositID", DbType.Int64, aCBankAccountDepositEntity.BankAccountDepositID);
                Database.AddInParameter(cmd, "@DepositDate", DbType.DateTime, aCBankAccountDepositEntity.DepositDate);
                Database.AddInParameter(cmd, "@PaidFromID", DbType.Int64, aCBankAccountDepositEntity.PaidFromID);
                Database.AddInParameter(cmd, "@ReferenceID", DbType.Int64, aCBankAccountDepositEntity.ReferenceID);
                Database.AddInParameter(cmd, "@BankAccountID", DbType.Int64, aCBankAccountDepositEntity.BankAccountID);
                Database.AddInParameter(cmd, "@Reference", DbType.String, aCBankAccountDepositEntity.Reference);
                Database.AddInParameter(cmd, "@Name", DbType.String, aCBankAccountDepositEntity.Name);
                Database.AddInParameter(cmd, "@Memo", DbType.String, aCBankAccountDepositEntity.Memo);
                Database.AddInParameter(cmd, "@BankAccountDepositApprovalStatusID", DbType.Int64, aCBankAccountDepositEntity.BankAccountDepositApprovalStatusID);
                Database.AddInParameter(cmd, "@PreparedByEmployeeID", DbType.Int64, aCBankAccountDepositEntity.PreparedByEmployeeID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACBankAccountDepositEntity already exists. Please specify another ACBankAccountDepositEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACBankAccountDepositEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACBankAccountDepositEntity already exists. Please specify another ACBankAccountDepositEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(ACBankAccountDepositEntity aCBankAccountDepositEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACBankAccountDeposit_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@BankAccountDepositID", DbType.Int64, aCBankAccountDepositEntity.BankAccountDepositID);
                db.AddInParameter(cmd, "@DepositDate", DbType.DateTime, aCBankAccountDepositEntity.DepositDate);
                db.AddInParameter(cmd, "@PaidFromID", DbType.Int64, aCBankAccountDepositEntity.PaidFromID);
                db.AddInParameter(cmd, "@ReferenceID", DbType.Int64, aCBankAccountDepositEntity.ReferenceID);
                db.AddInParameter(cmd, "@BankAccountID", DbType.Int64, aCBankAccountDepositEntity.BankAccountID);
                db.AddInParameter(cmd, "@Reference", DbType.String, aCBankAccountDepositEntity.Reference);
                db.AddInParameter(cmd, "@Name", DbType.String, aCBankAccountDepositEntity.Name);
                db.AddInParameter(cmd, "@Memo", DbType.String, aCBankAccountDepositEntity.Memo);
                db.AddInParameter(cmd, "@BankAccountDepositApprovalStatusID", DbType.Int64, aCBankAccountDepositEntity.BankAccountDepositApprovalStatusID);
                db.AddInParameter(cmd, "@PreparedByEmployeeID", DbType.Int64, aCBankAccountDepositEntity.PreparedByEmployeeID);

                DbConnection connection = db.CreateConnection();
                connection.Open();
                DbTransaction transaction = connection.BeginTransaction();

                try
                {
                    using (IDataReader reader = db.ExecuteReader(cmd, transaction))
                    {
                        returnCode = GetReturnCodeFromParameter(cmd);
                    }                    

                    if (returnCode > 0)
                    {
                        transaction.Commit();
                    }
                    else
                    {
                        throw new ArgumentException("Error Code." + returnCode.ToString());
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
                finally
                {
                    transaction.Dispose();
                    connection.Close();
                    connection = null;
                }
            }

            return returnCode;
        }

        #endregion Update Operation

        #region Update List Operation

        IList<Int64> IACBankAccountDepositDataAccess.Update(IList<ACBankAccountDepositEntity> aCBankAccountDepositEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (ACBankAccountDepositEntity aCBankAccountDepositEntity in aCBankAccountDepositEntityList)
            {
                returnCode = (this as IACBankAccountDepositDataAccess).Update(aCBankAccountDepositEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IACBankAccountDepositDataAccess.Delete(ACBankAccountDepositEntity aCBankAccountDepositEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(aCBankAccountDepositEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(aCBankAccountDepositEntity, filterExpression, option);
                            break;
                        }
                    default:
                        {
                            retValues = -99;
                            break;
                        }
                }

                return retValues;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Int64 Delete(ACBankAccountDepositEntity aCBankAccountDepositEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACBankAccountDeposit_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);


                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACBankAccountDepositEntity already exists. Please specify another ACBankAccountDepositEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACBankAccountDepositEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACBankAccountDepositEntity already exists. Please specify another ACBankAccountDepositEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(ACBankAccountDepositEntity aCBankAccountDepositEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACBankAccountDeposit_SET";

            Database db = DatabaseFactory.CreateDatabase();


            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd, db);
                AddFilterExpressionParameter(cmd, filterExpression, db);


                DbConnection connection = db.CreateConnection();
                connection.Open();
                DbTransaction transaction = connection.BeginTransaction();

                try
                {
                    using (IDataReader reader = db.ExecuteReader(cmd, transaction))
                    {
                        returnCode = GetReturnCodeFromParameter(cmd);
                    }

                    if (returnCode >= 0)
                    {
                        transaction.Commit();
                    }
                    else
                    {
                        throw new ArgumentException("Error Code." + returnCode.ToString());
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
                finally
                {
                    transaction.Dispose();
                    connection.Close();
                    connection = null;
                }
            }

            return returnCode;
        }

        #endregion Delete Operation

        #region Delete List Operation

        IList<Int64> IACBankAccountDepositDataAccess.Delete(IList<ACBankAccountDepositEntity> aCBankAccountDepositEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (ACBankAccountDepositEntity aCBankAccountDepositEntity in aCBankAccountDepositEntityList)
            {
                returnCode = (this as IACBankAccountDepositDataAccess).Delete(aCBankAccountDepositEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<ACBankAccountDepositEntity> IACBankAccountDepositDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACBankAccountDeposit_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ACBankAccountDepositEntity> list = CreateEntityBuilder<ACBankAccountDepositEntity>().BuildEntities(reader);

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

        DataTable IACBankAccountDepositDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACBankAccountDeposit_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddCurrentPageParameter(cmd, currentPage);
                    AddPageSizeParameter(cmd, pageSize);
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

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
