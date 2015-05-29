// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-May-2015, 11:33:13




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
    internal sealed partial class BDOperatorDataAccess : BaseDataAccess, IBDOperatorDataAccess
    {
        #region Constructors

        public BDOperatorDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<BDOperatorEntity> CreateEntityBuilder<BDOperatorEntity>()
        {
            return (new BDOperatorBuilder()) as IEntityBuilder<BDOperatorEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IBDOperatorDataAccess.Add(BDOperatorEntity bDOperatorEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(bDOperatorEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(bDOperatorEntity, option);
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

        private Int64 Add(BDOperatorEntity bDOperatorEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDOperator_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "OperatorID");

                Database.AddInParameter(cmd, "@OperatorCode", DbType.String, bDOperatorEntity.OperatorCode);	
                Database.AddInParameter(cmd, "@OperatorName", DbType.String, bDOperatorEntity.OperatorName);	
                Database.AddInParameter(cmd, "@Relationship", DbType.String, bDOperatorEntity.Relationship);	
                Database.AddInParameter(cmd, "@Phone", DbType.String, bDOperatorEntity.Phone);	
                Database.AddInParameter(cmd, "@MobileNo", DbType.String, bDOperatorEntity.MobileNo);	
                Database.AddInParameter(cmd, "@Fax", DbType.String, bDOperatorEntity.Fax);	
                Database.AddInParameter(cmd, "@Email", DbType.String, bDOperatorEntity.Email);	
                Database.AddInParameter(cmd, "@WebLink", DbType.String, bDOperatorEntity.WebLink);	
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, bDOperatorEntity.CreateDate);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, bDOperatorEntity.Remarks);	
                Database.AddInParameter(cmd, "@Reason", DbType.String, bDOperatorEntity.Reason);	
                Database.AddInParameter(cmd, "@OperatorStatusID", DbType.Int64, bDOperatorEntity.OperatorStatusID);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, bDOperatorEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDOperatorEntity already exists. Please specify another BDOperatorEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDOperatorEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDOperatorEntity already exists. Please specify another BDOperatorEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(BDOperatorEntity bDOperatorEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDOperator_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "OperatorID", db);

                db.AddInParameter(cmd, "@OperatorCode", DbType.String, bDOperatorEntity.OperatorCode);
                db.AddInParameter(cmd, "@OperatorName", DbType.String, bDOperatorEntity.OperatorName);
                db.AddInParameter(cmd, "@Relationship", DbType.String, bDOperatorEntity.Relationship);
                db.AddInParameter(cmd, "@Phone", DbType.String, bDOperatorEntity.Phone);
                db.AddInParameter(cmd, "@MobileNo", DbType.String, bDOperatorEntity.MobileNo);
                db.AddInParameter(cmd, "@Fax", DbType.String, bDOperatorEntity.Fax);
                db.AddInParameter(cmd, "@Email", DbType.String, bDOperatorEntity.Email);
                db.AddInParameter(cmd, "@WebLink", DbType.String, bDOperatorEntity.WebLink);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, bDOperatorEntity.CreateDate);
                db.AddInParameter(cmd, "@Remarks", DbType.String, bDOperatorEntity.Remarks);
                db.AddInParameter(cmd, "@Reason", DbType.String, bDOperatorEntity.Reason);
                db.AddInParameter(cmd, "@OperatorStatusID", DbType.Int64, bDOperatorEntity.OperatorStatusID);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, bDOperatorEntity.IsRemoved);

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

        IList<Int64> IBDOperatorDataAccess.Add(IList<BDOperatorEntity> bDOperatorEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (BDOperatorEntity bDOperatorEntity in bDOperatorEntityList)
            {
                returnCode = (this as IBDOperatorDataAccess).Add(bDOperatorEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IBDOperatorDataAccess.Update(BDOperatorEntity bDOperatorEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(bDOperatorEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(bDOperatorEntity, filterExpression, option);
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

        private Int64 Update(BDOperatorEntity bDOperatorEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDOperator_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@OperatorID", DbType.Int64, bDOperatorEntity.OperatorID);
                Database.AddInParameter(cmd, "@OperatorCode", DbType.String, bDOperatorEntity.OperatorCode);
                Database.AddInParameter(cmd, "@OperatorName", DbType.String, bDOperatorEntity.OperatorName);
                Database.AddInParameter(cmd, "@Relationship", DbType.String, bDOperatorEntity.Relationship);
                Database.AddInParameter(cmd, "@Phone", DbType.String, bDOperatorEntity.Phone);
                Database.AddInParameter(cmd, "@MobileNo", DbType.String, bDOperatorEntity.MobileNo);
                Database.AddInParameter(cmd, "@Fax", DbType.String, bDOperatorEntity.Fax);
                Database.AddInParameter(cmd, "@Email", DbType.String, bDOperatorEntity.Email);
                Database.AddInParameter(cmd, "@WebLink", DbType.String, bDOperatorEntity.WebLink);
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, bDOperatorEntity.CreateDate);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, bDOperatorEntity.Remarks);
                Database.AddInParameter(cmd, "@Reason", DbType.String, bDOperatorEntity.Reason);
                Database.AddInParameter(cmd, "@OperatorStatusID", DbType.Int64, bDOperatorEntity.OperatorStatusID);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, bDOperatorEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDOperatorEntity already exists. Please specify another BDOperatorEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDOperatorEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDOperatorEntity already exists. Please specify another BDOperatorEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(BDOperatorEntity bDOperatorEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDOperator_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@OperatorID", DbType.Int64, bDOperatorEntity.OperatorID);
                db.AddInParameter(cmd, "@OperatorCode", DbType.String, bDOperatorEntity.OperatorCode);
                db.AddInParameter(cmd, "@OperatorName", DbType.String, bDOperatorEntity.OperatorName);
                db.AddInParameter(cmd, "@Relationship", DbType.String, bDOperatorEntity.Relationship);
                db.AddInParameter(cmd, "@Phone", DbType.String, bDOperatorEntity.Phone);
                db.AddInParameter(cmd, "@MobileNo", DbType.String, bDOperatorEntity.MobileNo);
                db.AddInParameter(cmd, "@Fax", DbType.String, bDOperatorEntity.Fax);
                db.AddInParameter(cmd, "@Email", DbType.String, bDOperatorEntity.Email);
                db.AddInParameter(cmd, "@WebLink", DbType.String, bDOperatorEntity.WebLink);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, bDOperatorEntity.CreateDate);
                db.AddInParameter(cmd, "@Remarks", DbType.String, bDOperatorEntity.Remarks);
                db.AddInParameter(cmd, "@Reason", DbType.String, bDOperatorEntity.Reason);
                db.AddInParameter(cmd, "@OperatorStatusID", DbType.Int64, bDOperatorEntity.OperatorStatusID);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, bDOperatorEntity.IsRemoved);

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

        IList<Int64> IBDOperatorDataAccess.Update(IList<BDOperatorEntity> bDOperatorEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (BDOperatorEntity bDOperatorEntity in bDOperatorEntityList)
            {
                returnCode = (this as IBDOperatorDataAccess).Update(bDOperatorEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IBDOperatorDataAccess.Delete(BDOperatorEntity bDOperatorEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(bDOperatorEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(bDOperatorEntity, filterExpression, option);
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

        private Int64 Delete(BDOperatorEntity bDOperatorEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDOperator_SET";

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
                                throw new ArgumentException("BDOperatorEntity already exists. Please specify another BDOperatorEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDOperatorEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDOperatorEntity already exists. Please specify another BDOperatorEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(BDOperatorEntity bDOperatorEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDOperator_SET";

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

        IList<Int64> IBDOperatorDataAccess.Delete(IList<BDOperatorEntity> bDOperatorEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (BDOperatorEntity bDOperatorEntity in bDOperatorEntityList)
            {
                returnCode = (this as IBDOperatorDataAccess).Delete(bDOperatorEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<BDOperatorEntity> IBDOperatorDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDOperator_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<BDOperatorEntity> list = CreateEntityBuilder<BDOperatorEntity>().BuildEntities(reader);

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

        DataTable IBDOperatorDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDOperator_GET";

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
