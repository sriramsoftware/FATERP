// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Mar-2012, 03:28:59




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
    internal sealed partial class BDProjectCollectedDocumentInfoDataAccess : BaseDataAccess, IBDProjectCollectedDocumentInfoDataAccess
    {
        #region Constructors

        public BDProjectCollectedDocumentInfoDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<BDProjectCollectedDocumentInfoEntity> CreateEntityBuilder<BDProjectCollectedDocumentInfoEntity>()
        {
            return (new BDProjectCollectedDocumentInfoBuilder()) as IEntityBuilder<BDProjectCollectedDocumentInfoEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IBDProjectCollectedDocumentInfoDataAccess.Add(BDProjectCollectedDocumentInfoEntity bDProjectCollectedDocumentInfoEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(bDProjectCollectedDocumentInfoEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(bDProjectCollectedDocumentInfoEntity, option);
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

        private Int64 Add(BDProjectCollectedDocumentInfoEntity bDProjectCollectedDocumentInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectCollectedDocumentInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ProjectCollectedDocumentInfoID");

                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectCollectedDocumentInfoEntity.ProjectID);	
                Database.AddInParameter(cmd, "@ProjectDocumentID", DbType.Int64, bDProjectCollectedDocumentInfoEntity.ProjectDocumentID);	
                Database.AddInParameter(cmd, "@StartDate", DbType.DateTime, bDProjectCollectedDocumentInfoEntity.StartDate);	
                Database.AddInParameter(cmd, "@RequiredTime", DbType.Int32, bDProjectCollectedDocumentInfoEntity.RequiredTime);	
                Database.AddInParameter(cmd, "@RequiredTimeStandardTimeUnitID", DbType.Int64, bDProjectCollectedDocumentInfoEntity.RequiredTimeStandardTimeUnitID);	
                Database.AddInParameter(cmd, "@ReminderBefore", DbType.Int32, bDProjectCollectedDocumentInfoEntity.ReminderBefore);	
                Database.AddInParameter(cmd, "@ReminderBeforeStandardTimeUnitID", DbType.Int64, bDProjectCollectedDocumentInfoEntity.ReminderBeforeStandardTimeUnitID);	
                Database.AddInParameter(cmd, "@ProjectCollectedDocumentStatusID", DbType.Int64, bDProjectCollectedDocumentInfoEntity.ProjectCollectedDocumentStatusID);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, bDProjectCollectedDocumentInfoEntity.Remarks);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDProjectCollectedDocumentInfoEntity already exists. Please specify another BDProjectCollectedDocumentInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectCollectedDocumentInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectCollectedDocumentInfoEntity already exists. Please specify another BDProjectCollectedDocumentInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(BDProjectCollectedDocumentInfoEntity bDProjectCollectedDocumentInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectCollectedDocumentInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ProjectCollectedDocumentInfoID", db);

                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectCollectedDocumentInfoEntity.ProjectID);
                db.AddInParameter(cmd, "@ProjectDocumentID", DbType.Int64, bDProjectCollectedDocumentInfoEntity.ProjectDocumentID);
                db.AddInParameter(cmd, "@StartDate", DbType.DateTime, bDProjectCollectedDocumentInfoEntity.StartDate);
                db.AddInParameter(cmd, "@RequiredTime", DbType.Int32, bDProjectCollectedDocumentInfoEntity.RequiredTime);
                db.AddInParameter(cmd, "@RequiredTimeStandardTimeUnitID", DbType.Int64, bDProjectCollectedDocumentInfoEntity.RequiredTimeStandardTimeUnitID);
                db.AddInParameter(cmd, "@ReminderBefore", DbType.Int32, bDProjectCollectedDocumentInfoEntity.ReminderBefore);
                db.AddInParameter(cmd, "@ReminderBeforeStandardTimeUnitID", DbType.Int64, bDProjectCollectedDocumentInfoEntity.ReminderBeforeStandardTimeUnitID);
                db.AddInParameter(cmd, "@ProjectCollectedDocumentStatusID", DbType.Int64, bDProjectCollectedDocumentInfoEntity.ProjectCollectedDocumentStatusID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, bDProjectCollectedDocumentInfoEntity.Remarks);

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

        IList<Int64> IBDProjectCollectedDocumentInfoDataAccess.Add(IList<BDProjectCollectedDocumentInfoEntity> bDProjectCollectedDocumentInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (BDProjectCollectedDocumentInfoEntity bDProjectCollectedDocumentInfoEntity in bDProjectCollectedDocumentInfoEntityList)
            {
                returnCode = (this as IBDProjectCollectedDocumentInfoDataAccess).Add(bDProjectCollectedDocumentInfoEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IBDProjectCollectedDocumentInfoDataAccess.Update(BDProjectCollectedDocumentInfoEntity bDProjectCollectedDocumentInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(bDProjectCollectedDocumentInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(bDProjectCollectedDocumentInfoEntity, filterExpression, option);
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

        private Int64 Update(BDProjectCollectedDocumentInfoEntity bDProjectCollectedDocumentInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectCollectedDocumentInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ProjectCollectedDocumentInfoID", DbType.Int64, bDProjectCollectedDocumentInfoEntity.ProjectCollectedDocumentInfoID);
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectCollectedDocumentInfoEntity.ProjectID);
                Database.AddInParameter(cmd, "@ProjectDocumentID", DbType.Int64, bDProjectCollectedDocumentInfoEntity.ProjectDocumentID);
                Database.AddInParameter(cmd, "@StartDate", DbType.DateTime, bDProjectCollectedDocumentInfoEntity.StartDate);
                Database.AddInParameter(cmd, "@RequiredTime", DbType.Int32, bDProjectCollectedDocumentInfoEntity.RequiredTime);
                Database.AddInParameter(cmd, "@RequiredTimeStandardTimeUnitID", DbType.Int64, bDProjectCollectedDocumentInfoEntity.RequiredTimeStandardTimeUnitID);
                Database.AddInParameter(cmd, "@ReminderBefore", DbType.Int32, bDProjectCollectedDocumentInfoEntity.ReminderBefore);
                Database.AddInParameter(cmd, "@ReminderBeforeStandardTimeUnitID", DbType.Int64, bDProjectCollectedDocumentInfoEntity.ReminderBeforeStandardTimeUnitID);
                Database.AddInParameter(cmd, "@ProjectCollectedDocumentStatusID", DbType.Int64, bDProjectCollectedDocumentInfoEntity.ProjectCollectedDocumentStatusID);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, bDProjectCollectedDocumentInfoEntity.Remarks);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDProjectCollectedDocumentInfoEntity already exists. Please specify another BDProjectCollectedDocumentInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectCollectedDocumentInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectCollectedDocumentInfoEntity already exists. Please specify another BDProjectCollectedDocumentInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(BDProjectCollectedDocumentInfoEntity bDProjectCollectedDocumentInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectCollectedDocumentInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ProjectCollectedDocumentInfoID", DbType.Int64, bDProjectCollectedDocumentInfoEntity.ProjectCollectedDocumentInfoID);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectCollectedDocumentInfoEntity.ProjectID);
                db.AddInParameter(cmd, "@ProjectDocumentID", DbType.Int64, bDProjectCollectedDocumentInfoEntity.ProjectDocumentID);
                db.AddInParameter(cmd, "@StartDate", DbType.DateTime, bDProjectCollectedDocumentInfoEntity.StartDate);
                db.AddInParameter(cmd, "@RequiredTime", DbType.Int32, bDProjectCollectedDocumentInfoEntity.RequiredTime);
                db.AddInParameter(cmd, "@RequiredTimeStandardTimeUnitID", DbType.Int64, bDProjectCollectedDocumentInfoEntity.RequiredTimeStandardTimeUnitID);
                db.AddInParameter(cmd, "@ReminderBefore", DbType.Int32, bDProjectCollectedDocumentInfoEntity.ReminderBefore);
                db.AddInParameter(cmd, "@ReminderBeforeStandardTimeUnitID", DbType.Int64, bDProjectCollectedDocumentInfoEntity.ReminderBeforeStandardTimeUnitID);
                db.AddInParameter(cmd, "@ProjectCollectedDocumentStatusID", DbType.Int64, bDProjectCollectedDocumentInfoEntity.ProjectCollectedDocumentStatusID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, bDProjectCollectedDocumentInfoEntity.Remarks);

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

        IList<Int64> IBDProjectCollectedDocumentInfoDataAccess.Update(IList<BDProjectCollectedDocumentInfoEntity> bDProjectCollectedDocumentInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (BDProjectCollectedDocumentInfoEntity bDProjectCollectedDocumentInfoEntity in bDProjectCollectedDocumentInfoEntityList)
            {
                returnCode = (this as IBDProjectCollectedDocumentInfoDataAccess).Update(bDProjectCollectedDocumentInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IBDProjectCollectedDocumentInfoDataAccess.Delete(BDProjectCollectedDocumentInfoEntity bDProjectCollectedDocumentInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(bDProjectCollectedDocumentInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(bDProjectCollectedDocumentInfoEntity, filterExpression, option);
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

        private Int64 Delete(BDProjectCollectedDocumentInfoEntity bDProjectCollectedDocumentInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectCollectedDocumentInfo_SET";

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
                                throw new ArgumentException("BDProjectCollectedDocumentInfoEntity already exists. Please specify another BDProjectCollectedDocumentInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectCollectedDocumentInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectCollectedDocumentInfoEntity already exists. Please specify another BDProjectCollectedDocumentInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(BDProjectCollectedDocumentInfoEntity bDProjectCollectedDocumentInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectCollectedDocumentInfo_SET";

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

        IList<Int64> IBDProjectCollectedDocumentInfoDataAccess.Delete(IList<BDProjectCollectedDocumentInfoEntity> bDProjectCollectedDocumentInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (BDProjectCollectedDocumentInfoEntity bDProjectCollectedDocumentInfoEntity in bDProjectCollectedDocumentInfoEntityList)
            {
                returnCode = (this as IBDProjectCollectedDocumentInfoDataAccess).Delete(bDProjectCollectedDocumentInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<BDProjectCollectedDocumentInfoEntity> IBDProjectCollectedDocumentInfoDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDProjectCollectedDocumentInfo_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<BDProjectCollectedDocumentInfoEntity> list = CreateEntityBuilder<BDProjectCollectedDocumentInfoEntity>().BuildEntities(reader);

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

        DataTable IBDProjectCollectedDocumentInfoDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDProjectCollectedDocumentInfo_GET";

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
