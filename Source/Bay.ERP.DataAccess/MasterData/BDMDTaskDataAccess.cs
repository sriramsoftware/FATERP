// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-May-2013, 02:32:38




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
    internal sealed partial class BDMDTaskDataAccess : BaseDataAccess, IBDMDTaskDataAccess
    {
        #region Constructors

        public BDMDTaskDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<BDMDTaskEntity> CreateEntityBuilder<BDMDTaskEntity>()
        {
            return (new BDMDTaskBuilder()) as IEntityBuilder<BDMDTaskEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IBDMDTaskDataAccess.Add(BDMDTaskEntity bDMDTaskEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(bDMDTaskEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(bDMDTaskEntity, option);
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

        private Int64 Add(BDMDTaskEntity bDMDTaskEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDMDTask_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "TaskID");

                Database.AddInParameter(cmd, "@TaskCategoryID", DbType.Int64, bDMDTaskEntity.TaskCategoryID);	
                Database.AddInParameter(cmd, "@Name", DbType.String, bDMDTaskEntity.Name);	
                Database.AddInParameter(cmd, "@RequiredStandardTime", DbType.Int32, bDMDTaskEntity.RequiredStandardTime);	
                Database.AddInParameter(cmd, "@ReminderTime", DbType.Int32, bDMDTaskEntity.ReminderTime);	
                Database.AddInParameter(cmd, "@IsRepeat", DbType.Boolean, bDMDTaskEntity.IsRepeat);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, bDMDTaskEntity.Remarks);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, bDMDTaskEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDMDTaskEntity already exists. Please specify another BDMDTaskEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDMDTaskEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDMDTaskEntity already exists. Please specify another BDMDTaskEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(BDMDTaskEntity bDMDTaskEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDMDTask_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "TaskID", db);

                db.AddInParameter(cmd, "@TaskCategoryID", DbType.Int64, bDMDTaskEntity.TaskCategoryID);
                db.AddInParameter(cmd, "@Name", DbType.String, bDMDTaskEntity.Name);
                db.AddInParameter(cmd, "@RequiredStandardTime", DbType.Int32, bDMDTaskEntity.RequiredStandardTime);
                db.AddInParameter(cmd, "@ReminderTime", DbType.Int32, bDMDTaskEntity.ReminderTime);
                db.AddInParameter(cmd, "@IsRepeat", DbType.Boolean, bDMDTaskEntity.IsRepeat);
                db.AddInParameter(cmd, "@Remarks", DbType.String, bDMDTaskEntity.Remarks);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, bDMDTaskEntity.IsRemoved);

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

        IList<Int64> IBDMDTaskDataAccess.Add(IList<BDMDTaskEntity> bDMDTaskEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (BDMDTaskEntity bDMDTaskEntity in bDMDTaskEntityList)
            {
                returnCode = (this as IBDMDTaskDataAccess).Add(bDMDTaskEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IBDMDTaskDataAccess.Update(BDMDTaskEntity bDMDTaskEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(bDMDTaskEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(bDMDTaskEntity, filterExpression, option);
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

        private Int64 Update(BDMDTaskEntity bDMDTaskEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDMDTask_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@TaskID", DbType.Int64, bDMDTaskEntity.TaskID);
                Database.AddInParameter(cmd, "@TaskCategoryID", DbType.Int64, bDMDTaskEntity.TaskCategoryID);
                Database.AddInParameter(cmd, "@Name", DbType.String, bDMDTaskEntity.Name);
                Database.AddInParameter(cmd, "@RequiredStandardTime", DbType.Int32, bDMDTaskEntity.RequiredStandardTime);
                Database.AddInParameter(cmd, "@ReminderTime", DbType.Int32, bDMDTaskEntity.ReminderTime);
                Database.AddInParameter(cmd, "@IsRepeat", DbType.Boolean, bDMDTaskEntity.IsRepeat);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, bDMDTaskEntity.Remarks);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, bDMDTaskEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDMDTaskEntity already exists. Please specify another BDMDTaskEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDMDTaskEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDMDTaskEntity already exists. Please specify another BDMDTaskEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(BDMDTaskEntity bDMDTaskEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDMDTask_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@TaskID", DbType.Int64, bDMDTaskEntity.TaskID);
                db.AddInParameter(cmd, "@TaskCategoryID", DbType.Int64, bDMDTaskEntity.TaskCategoryID);
                db.AddInParameter(cmd, "@Name", DbType.String, bDMDTaskEntity.Name);
                db.AddInParameter(cmd, "@RequiredStandardTime", DbType.Int32, bDMDTaskEntity.RequiredStandardTime);
                db.AddInParameter(cmd, "@ReminderTime", DbType.Int32, bDMDTaskEntity.ReminderTime);
                db.AddInParameter(cmd, "@IsRepeat", DbType.Boolean, bDMDTaskEntity.IsRepeat);
                db.AddInParameter(cmd, "@Remarks", DbType.String, bDMDTaskEntity.Remarks);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, bDMDTaskEntity.IsRemoved);

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

        IList<Int64> IBDMDTaskDataAccess.Update(IList<BDMDTaskEntity> bDMDTaskEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (BDMDTaskEntity bDMDTaskEntity in bDMDTaskEntityList)
            {
                returnCode = (this as IBDMDTaskDataAccess).Update(bDMDTaskEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IBDMDTaskDataAccess.Delete(BDMDTaskEntity bDMDTaskEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(bDMDTaskEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(bDMDTaskEntity, filterExpression, option);
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

        private Int64 Delete(BDMDTaskEntity bDMDTaskEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDMDTask_SET";

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
                                throw new ArgumentException("BDMDTaskEntity already exists. Please specify another BDMDTaskEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDMDTaskEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDMDTaskEntity already exists. Please specify another BDMDTaskEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(BDMDTaskEntity bDMDTaskEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDMDTask_SET";

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

        IList<Int64> IBDMDTaskDataAccess.Delete(IList<BDMDTaskEntity> bDMDTaskEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (BDMDTaskEntity bDMDTaskEntity in bDMDTaskEntityList)
            {
                returnCode = (this as IBDMDTaskDataAccess).Delete(bDMDTaskEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<BDMDTaskEntity> IBDMDTaskDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDMDTask_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<BDMDTaskEntity> list = CreateEntityBuilder<BDMDTaskEntity>().BuildEntities(reader);

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

        DataTable IBDMDTaskDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDMDTask_GET";

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
