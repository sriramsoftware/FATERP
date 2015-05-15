// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Dec-2012, 11:43:49




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
    internal sealed partial class MDPayableClassificationDataAccess : BaseDataAccess, IMDPayableClassificationDataAccess
    {
        #region Constructors

        public MDPayableClassificationDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<MDPayableClassificationEntity> CreateEntityBuilder<MDPayableClassificationEntity>()
        {
            return (new MDPayableClassificationBuilder()) as IEntityBuilder<MDPayableClassificationEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IMDPayableClassificationDataAccess.Add(MDPayableClassificationEntity mDPayableClassificationEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(mDPayableClassificationEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(mDPayableClassificationEntity, option);
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

        private Int64 Add(MDPayableClassificationEntity mDPayableClassificationEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDPayableClassification_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "PayableClassificationID");

                Database.AddInParameter(cmd, "@Name", DbType.String, mDPayableClassificationEntity.Name);	
                Database.AddInParameter(cmd, "@Narration", DbType.String, mDPayableClassificationEntity.Narration);	
                Database.AddInParameter(cmd, "@PaymentMode", DbType.String, mDPayableClassificationEntity.PaymentMode);	
                Database.AddInParameter(cmd, "@PaymentChennal", DbType.String, mDPayableClassificationEntity.PaymentChennal);	
                Database.AddInParameter(cmd, "@SecurityMoney", DbType.String, mDPayableClassificationEntity.SecurityMoney);	
                Database.AddInParameter(cmd, "@TaxDeduction", DbType.String, mDPayableClassificationEntity.TaxDeduction);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, mDPayableClassificationEntity.Remarks);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDPayableClassificationEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDPayableClassificationEntity already exists. Please specify another MDPayableClassificationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDPayableClassificationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDPayableClassificationEntity already exists. Please specify another MDPayableClassificationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(MDPayableClassificationEntity mDPayableClassificationEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDPayableClassification_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "PayableClassificationID", db);

                db.AddInParameter(cmd, "@Name", DbType.String, mDPayableClassificationEntity.Name);
                db.AddInParameter(cmd, "@Narration", DbType.String, mDPayableClassificationEntity.Narration);
                db.AddInParameter(cmd, "@PaymentMode", DbType.String, mDPayableClassificationEntity.PaymentMode);
                db.AddInParameter(cmd, "@PaymentChennal", DbType.String, mDPayableClassificationEntity.PaymentChennal);
                db.AddInParameter(cmd, "@SecurityMoney", DbType.String, mDPayableClassificationEntity.SecurityMoney);
                db.AddInParameter(cmd, "@TaxDeduction", DbType.String, mDPayableClassificationEntity.TaxDeduction);
                db.AddInParameter(cmd, "@Remarks", DbType.String, mDPayableClassificationEntity.Remarks);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDPayableClassificationEntity.IsRemoved);

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

        IList<Int64> IMDPayableClassificationDataAccess.Add(IList<MDPayableClassificationEntity> mDPayableClassificationEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (MDPayableClassificationEntity mDPayableClassificationEntity in mDPayableClassificationEntityList)
            {
                returnCode = (this as IMDPayableClassificationDataAccess).Add(mDPayableClassificationEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IMDPayableClassificationDataAccess.Update(MDPayableClassificationEntity mDPayableClassificationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(mDPayableClassificationEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(mDPayableClassificationEntity, filterExpression, option);
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

        private Int64 Update(MDPayableClassificationEntity mDPayableClassificationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDPayableClassification_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@PayableClassificationID", DbType.Int64, mDPayableClassificationEntity.PayableClassificationID);
                Database.AddInParameter(cmd, "@Name", DbType.String, mDPayableClassificationEntity.Name);
                Database.AddInParameter(cmd, "@Narration", DbType.String, mDPayableClassificationEntity.Narration);
                Database.AddInParameter(cmd, "@PaymentMode", DbType.String, mDPayableClassificationEntity.PaymentMode);
                Database.AddInParameter(cmd, "@PaymentChennal", DbType.String, mDPayableClassificationEntity.PaymentChennal);
                Database.AddInParameter(cmd, "@SecurityMoney", DbType.String, mDPayableClassificationEntity.SecurityMoney);
                Database.AddInParameter(cmd, "@TaxDeduction", DbType.String, mDPayableClassificationEntity.TaxDeduction);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, mDPayableClassificationEntity.Remarks);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDPayableClassificationEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDPayableClassificationEntity already exists. Please specify another MDPayableClassificationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDPayableClassificationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDPayableClassificationEntity already exists. Please specify another MDPayableClassificationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(MDPayableClassificationEntity mDPayableClassificationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDPayableClassification_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@PayableClassificationID", DbType.Int64, mDPayableClassificationEntity.PayableClassificationID);
                db.AddInParameter(cmd, "@Name", DbType.String, mDPayableClassificationEntity.Name);
                db.AddInParameter(cmd, "@Narration", DbType.String, mDPayableClassificationEntity.Narration);
                db.AddInParameter(cmd, "@PaymentMode", DbType.String, mDPayableClassificationEntity.PaymentMode);
                db.AddInParameter(cmd, "@PaymentChennal", DbType.String, mDPayableClassificationEntity.PaymentChennal);
                db.AddInParameter(cmd, "@SecurityMoney", DbType.String, mDPayableClassificationEntity.SecurityMoney);
                db.AddInParameter(cmd, "@TaxDeduction", DbType.String, mDPayableClassificationEntity.TaxDeduction);
                db.AddInParameter(cmd, "@Remarks", DbType.String, mDPayableClassificationEntity.Remarks);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDPayableClassificationEntity.IsRemoved);

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

        IList<Int64> IMDPayableClassificationDataAccess.Update(IList<MDPayableClassificationEntity> mDPayableClassificationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (MDPayableClassificationEntity mDPayableClassificationEntity in mDPayableClassificationEntityList)
            {
                returnCode = (this as IMDPayableClassificationDataAccess).Update(mDPayableClassificationEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IMDPayableClassificationDataAccess.Delete(MDPayableClassificationEntity mDPayableClassificationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(mDPayableClassificationEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(mDPayableClassificationEntity, filterExpression, option);
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

        private Int64 Delete(MDPayableClassificationEntity mDPayableClassificationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDPayableClassification_SET";

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
                                throw new ArgumentException("MDPayableClassificationEntity already exists. Please specify another MDPayableClassificationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDPayableClassificationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDPayableClassificationEntity already exists. Please specify another MDPayableClassificationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(MDPayableClassificationEntity mDPayableClassificationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDPayableClassification_SET";

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

        IList<Int64> IMDPayableClassificationDataAccess.Delete(IList<MDPayableClassificationEntity> mDPayableClassificationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (MDPayableClassificationEntity mDPayableClassificationEntity in mDPayableClassificationEntityList)
            {
                returnCode = (this as IMDPayableClassificationDataAccess).Delete(mDPayableClassificationEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<MDPayableClassificationEntity> IMDPayableClassificationDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDPayableClassification_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<MDPayableClassificationEntity> list = CreateEntityBuilder<MDPayableClassificationEntity>().BuildEntities(reader);

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

        DataTable IMDPayableClassificationDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDPayableClassification_GET";

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
