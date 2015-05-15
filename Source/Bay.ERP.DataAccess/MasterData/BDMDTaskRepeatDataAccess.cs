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
    internal sealed partial class BDMDTaskRepeatDataAccess : BaseDataAccess, IBDMDTaskRepeatDataAccess
    {
        #region Constructors

        public BDMDTaskRepeatDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<BDMDTaskRepeatEntity> CreateEntityBuilder<BDMDTaskRepeatEntity>()
        {
            return (new BDMDTaskRepeatBuilder()) as IEntityBuilder<BDMDTaskRepeatEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IBDMDTaskRepeatDataAccess.Add(BDMDTaskRepeatEntity bDMDTaskRepeatEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(bDMDTaskRepeatEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(bDMDTaskRepeatEntity, option);
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

        private Int64 Add(BDMDTaskRepeatEntity bDMDTaskRepeatEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDMDTaskRepeat_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "TaskRepeatID");

                Database.AddInParameter(cmd, "@TaskID", DbType.Int64, bDMDTaskRepeatEntity.TaskID);	
                Database.AddInParameter(cmd, "@RepeatCategoryID", DbType.Int64, bDMDTaskRepeatEntity.RepeatCategoryID);	
                Database.AddInParameter(cmd, "@RepeatEvery", DbType.Int32, bDMDTaskRepeatEntity.RepeatEvery);	
                Database.AddInParameter(cmd, "@StartsOn", DbType.DateTime, bDMDTaskRepeatEntity.StartsOn);	
                Database.AddInParameter(cmd, "@EndsOn", DbType.DateTime, bDMDTaskRepeatEntity.EndsOn);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDMDTaskRepeatEntity already exists. Please specify another BDMDTaskRepeatEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDMDTaskRepeatEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDMDTaskRepeatEntity already exists. Please specify another BDMDTaskRepeatEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(BDMDTaskRepeatEntity bDMDTaskRepeatEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDMDTaskRepeat_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "TaskRepeatID", db);

                db.AddInParameter(cmd, "@TaskID", DbType.Int64, bDMDTaskRepeatEntity.TaskID);
                db.AddInParameter(cmd, "@RepeatCategoryID", DbType.Int64, bDMDTaskRepeatEntity.RepeatCategoryID);
                db.AddInParameter(cmd, "@RepeatEvery", DbType.Int32, bDMDTaskRepeatEntity.RepeatEvery);
                db.AddInParameter(cmd, "@StartsOn", DbType.DateTime, bDMDTaskRepeatEntity.StartsOn);
                db.AddInParameter(cmd, "@EndsOn", DbType.DateTime, bDMDTaskRepeatEntity.EndsOn);

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

        IList<Int64> IBDMDTaskRepeatDataAccess.Add(IList<BDMDTaskRepeatEntity> bDMDTaskRepeatEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (BDMDTaskRepeatEntity bDMDTaskRepeatEntity in bDMDTaskRepeatEntityList)
            {
                returnCode = (this as IBDMDTaskRepeatDataAccess).Add(bDMDTaskRepeatEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IBDMDTaskRepeatDataAccess.Update(BDMDTaskRepeatEntity bDMDTaskRepeatEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(bDMDTaskRepeatEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(bDMDTaskRepeatEntity, filterExpression, option);
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

        private Int64 Update(BDMDTaskRepeatEntity bDMDTaskRepeatEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDMDTaskRepeat_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@TaskRepeatID", DbType.Int64, bDMDTaskRepeatEntity.TaskRepeatID);
                Database.AddInParameter(cmd, "@TaskID", DbType.Int64, bDMDTaskRepeatEntity.TaskID);
                Database.AddInParameter(cmd, "@RepeatCategoryID", DbType.Int64, bDMDTaskRepeatEntity.RepeatCategoryID);
                Database.AddInParameter(cmd, "@RepeatEvery", DbType.Int32, bDMDTaskRepeatEntity.RepeatEvery);
                Database.AddInParameter(cmd, "@StartsOn", DbType.DateTime, bDMDTaskRepeatEntity.StartsOn);
                Database.AddInParameter(cmd, "@EndsOn", DbType.DateTime, bDMDTaskRepeatEntity.EndsOn);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDMDTaskRepeatEntity already exists. Please specify another BDMDTaskRepeatEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDMDTaskRepeatEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDMDTaskRepeatEntity already exists. Please specify another BDMDTaskRepeatEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(BDMDTaskRepeatEntity bDMDTaskRepeatEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDMDTaskRepeat_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@TaskRepeatID", DbType.Int64, bDMDTaskRepeatEntity.TaskRepeatID);
                db.AddInParameter(cmd, "@TaskID", DbType.Int64, bDMDTaskRepeatEntity.TaskID);
                db.AddInParameter(cmd, "@RepeatCategoryID", DbType.Int64, bDMDTaskRepeatEntity.RepeatCategoryID);
                db.AddInParameter(cmd, "@RepeatEvery", DbType.Int32, bDMDTaskRepeatEntity.RepeatEvery);
                db.AddInParameter(cmd, "@StartsOn", DbType.DateTime, bDMDTaskRepeatEntity.StartsOn);
                db.AddInParameter(cmd, "@EndsOn", DbType.DateTime, bDMDTaskRepeatEntity.EndsOn);

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

        IList<Int64> IBDMDTaskRepeatDataAccess.Update(IList<BDMDTaskRepeatEntity> bDMDTaskRepeatEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (BDMDTaskRepeatEntity bDMDTaskRepeatEntity in bDMDTaskRepeatEntityList)
            {
                returnCode = (this as IBDMDTaskRepeatDataAccess).Update(bDMDTaskRepeatEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IBDMDTaskRepeatDataAccess.Delete(BDMDTaskRepeatEntity bDMDTaskRepeatEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(bDMDTaskRepeatEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(bDMDTaskRepeatEntity, filterExpression, option);
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

        private Int64 Delete(BDMDTaskRepeatEntity bDMDTaskRepeatEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDMDTaskRepeat_SET";

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
                                throw new ArgumentException("BDMDTaskRepeatEntity already exists. Please specify another BDMDTaskRepeatEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDMDTaskRepeatEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDMDTaskRepeatEntity already exists. Please specify another BDMDTaskRepeatEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(BDMDTaskRepeatEntity bDMDTaskRepeatEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDMDTaskRepeat_SET";

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

        IList<Int64> IBDMDTaskRepeatDataAccess.Delete(IList<BDMDTaskRepeatEntity> bDMDTaskRepeatEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (BDMDTaskRepeatEntity bDMDTaskRepeatEntity in bDMDTaskRepeatEntityList)
            {
                returnCode = (this as IBDMDTaskRepeatDataAccess).Delete(bDMDTaskRepeatEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<BDMDTaskRepeatEntity> IBDMDTaskRepeatDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDMDTaskRepeat_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<BDMDTaskRepeatEntity> list = CreateEntityBuilder<BDMDTaskRepeatEntity>().BuildEntities(reader);

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

        DataTable IBDMDTaskRepeatDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDMDTaskRepeat_GET";

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
