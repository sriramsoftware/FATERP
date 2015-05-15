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
    internal sealed partial class ACBankAccountPaymentDataAccess : BaseDataAccess, IACBankAccountPaymentDataAccess
    {
        #region Constructors

        public ACBankAccountPaymentDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ACBankAccountPaymentEntity> CreateEntityBuilder<ACBankAccountPaymentEntity>()
        {
            return (new ACBankAccountPaymentBuilder()) as IEntityBuilder<ACBankAccountPaymentEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IACBankAccountPaymentDataAccess.Add(ACBankAccountPaymentEntity aCBankAccountPaymentEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(aCBankAccountPaymentEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(aCBankAccountPaymentEntity, option);
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

        private Int64 Add(ACBankAccountPaymentEntity aCBankAccountPaymentEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACBankAccountPayment_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "BankAccountPaymentID");

                Database.AddInParameter(cmd, "@PaymentDate", DbType.DateTime, aCBankAccountPaymentEntity.PaymentDate);	
                Database.AddInParameter(cmd, "@PayToID", DbType.Int64, aCBankAccountPaymentEntity.PayToID);	
                Database.AddInParameter(cmd, "@ReferenceID", DbType.Int64, aCBankAccountPaymentEntity.ReferenceID);	
                Database.AddInParameter(cmd, "@BankAccountID", DbType.Int64, aCBankAccountPaymentEntity.BankAccountID);	
                Database.AddInParameter(cmd, "@Reference", DbType.String, aCBankAccountPaymentEntity.Reference);	
                Database.AddInParameter(cmd, "@Name", DbType.String, aCBankAccountPaymentEntity.Name);	
                Database.AddInParameter(cmd, "@Memo", DbType.String, aCBankAccountPaymentEntity.Memo);	
                Database.AddInParameter(cmd, "@BankAccountPaymentApprovalStatusID", DbType.Int64, aCBankAccountPaymentEntity.BankAccountPaymentApprovalStatusID);	
                Database.AddInParameter(cmd, "@PreparedByEmployeeID", DbType.Int64, aCBankAccountPaymentEntity.PreparedByEmployeeID);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACBankAccountPaymentEntity already exists. Please specify another ACBankAccountPaymentEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACBankAccountPaymentEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACBankAccountPaymentEntity already exists. Please specify another ACBankAccountPaymentEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(ACBankAccountPaymentEntity aCBankAccountPaymentEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACBankAccountPayment_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "BankAccountPaymentID", db);

                db.AddInParameter(cmd, "@PaymentDate", DbType.DateTime, aCBankAccountPaymentEntity.PaymentDate);
                db.AddInParameter(cmd, "@PayToID", DbType.Int64, aCBankAccountPaymentEntity.PayToID);
                db.AddInParameter(cmd, "@ReferenceID", DbType.Int64, aCBankAccountPaymentEntity.ReferenceID);
                db.AddInParameter(cmd, "@BankAccountID", DbType.Int64, aCBankAccountPaymentEntity.BankAccountID);
                db.AddInParameter(cmd, "@Reference", DbType.String, aCBankAccountPaymentEntity.Reference);
                db.AddInParameter(cmd, "@Name", DbType.String, aCBankAccountPaymentEntity.Name);
                db.AddInParameter(cmd, "@Memo", DbType.String, aCBankAccountPaymentEntity.Memo);
                db.AddInParameter(cmd, "@BankAccountPaymentApprovalStatusID", DbType.Int64, aCBankAccountPaymentEntity.BankAccountPaymentApprovalStatusID);
                db.AddInParameter(cmd, "@PreparedByEmployeeID", DbType.Int64, aCBankAccountPaymentEntity.PreparedByEmployeeID);

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

        IList<Int64> IACBankAccountPaymentDataAccess.Add(IList<ACBankAccountPaymentEntity> aCBankAccountPaymentEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (ACBankAccountPaymentEntity aCBankAccountPaymentEntity in aCBankAccountPaymentEntityList)
            {
                returnCode = (this as IACBankAccountPaymentDataAccess).Add(aCBankAccountPaymentEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IACBankAccountPaymentDataAccess.Update(ACBankAccountPaymentEntity aCBankAccountPaymentEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(aCBankAccountPaymentEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(aCBankAccountPaymentEntity, filterExpression, option);
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

        private Int64 Update(ACBankAccountPaymentEntity aCBankAccountPaymentEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACBankAccountPayment_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@BankAccountPaymentID", DbType.Int64, aCBankAccountPaymentEntity.BankAccountPaymentID);
                Database.AddInParameter(cmd, "@PaymentDate", DbType.DateTime, aCBankAccountPaymentEntity.PaymentDate);
                Database.AddInParameter(cmd, "@PayToID", DbType.Int64, aCBankAccountPaymentEntity.PayToID);
                Database.AddInParameter(cmd, "@ReferenceID", DbType.Int64, aCBankAccountPaymentEntity.ReferenceID);
                Database.AddInParameter(cmd, "@BankAccountID", DbType.Int64, aCBankAccountPaymentEntity.BankAccountID);
                Database.AddInParameter(cmd, "@Reference", DbType.String, aCBankAccountPaymentEntity.Reference);
                Database.AddInParameter(cmd, "@Name", DbType.String, aCBankAccountPaymentEntity.Name);
                Database.AddInParameter(cmd, "@Memo", DbType.String, aCBankAccountPaymentEntity.Memo);
                Database.AddInParameter(cmd, "@BankAccountPaymentApprovalStatusID", DbType.Int64, aCBankAccountPaymentEntity.BankAccountPaymentApprovalStatusID);
                Database.AddInParameter(cmd, "@PreparedByEmployeeID", DbType.Int64, aCBankAccountPaymentEntity.PreparedByEmployeeID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACBankAccountPaymentEntity already exists. Please specify another ACBankAccountPaymentEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACBankAccountPaymentEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACBankAccountPaymentEntity already exists. Please specify another ACBankAccountPaymentEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(ACBankAccountPaymentEntity aCBankAccountPaymentEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACBankAccountPayment_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@BankAccountPaymentID", DbType.Int64, aCBankAccountPaymentEntity.BankAccountPaymentID);
                db.AddInParameter(cmd, "@PaymentDate", DbType.DateTime, aCBankAccountPaymentEntity.PaymentDate);
                db.AddInParameter(cmd, "@PayToID", DbType.Int64, aCBankAccountPaymentEntity.PayToID);
                db.AddInParameter(cmd, "@ReferenceID", DbType.Int64, aCBankAccountPaymentEntity.ReferenceID);
                db.AddInParameter(cmd, "@BankAccountID", DbType.Int64, aCBankAccountPaymentEntity.BankAccountID);
                db.AddInParameter(cmd, "@Reference", DbType.String, aCBankAccountPaymentEntity.Reference);
                db.AddInParameter(cmd, "@Name", DbType.String, aCBankAccountPaymentEntity.Name);
                db.AddInParameter(cmd, "@Memo", DbType.String, aCBankAccountPaymentEntity.Memo);
                db.AddInParameter(cmd, "@BankAccountPaymentApprovalStatusID", DbType.Int64, aCBankAccountPaymentEntity.BankAccountPaymentApprovalStatusID);
                db.AddInParameter(cmd, "@PreparedByEmployeeID", DbType.Int64, aCBankAccountPaymentEntity.PreparedByEmployeeID);

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

        IList<Int64> IACBankAccountPaymentDataAccess.Update(IList<ACBankAccountPaymentEntity> aCBankAccountPaymentEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (ACBankAccountPaymentEntity aCBankAccountPaymentEntity in aCBankAccountPaymentEntityList)
            {
                returnCode = (this as IACBankAccountPaymentDataAccess).Update(aCBankAccountPaymentEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IACBankAccountPaymentDataAccess.Delete(ACBankAccountPaymentEntity aCBankAccountPaymentEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(aCBankAccountPaymentEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(aCBankAccountPaymentEntity, filterExpression, option);
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

        private Int64 Delete(ACBankAccountPaymentEntity aCBankAccountPaymentEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACBankAccountPayment_SET";

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
                                throw new ArgumentException("ACBankAccountPaymentEntity already exists. Please specify another ACBankAccountPaymentEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACBankAccountPaymentEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACBankAccountPaymentEntity already exists. Please specify another ACBankAccountPaymentEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(ACBankAccountPaymentEntity aCBankAccountPaymentEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACBankAccountPayment_SET";

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

        IList<Int64> IACBankAccountPaymentDataAccess.Delete(IList<ACBankAccountPaymentEntity> aCBankAccountPaymentEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (ACBankAccountPaymentEntity aCBankAccountPaymentEntity in aCBankAccountPaymentEntityList)
            {
                returnCode = (this as IACBankAccountPaymentDataAccess).Delete(aCBankAccountPaymentEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<ACBankAccountPaymentEntity> IACBankAccountPaymentDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACBankAccountPayment_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ACBankAccountPaymentEntity> list = CreateEntityBuilder<ACBankAccountPaymentEntity>().BuildEntities(reader);

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

        DataTable IACBankAccountPaymentDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACBankAccountPayment_GET";

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
