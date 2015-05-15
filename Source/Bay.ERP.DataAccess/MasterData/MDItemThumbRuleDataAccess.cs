// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-May-2012, 05:58:01




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
    internal sealed partial class MDItemThumbRuleDataAccess : BaseDataAccess, IMDItemThumbRuleDataAccess
    {
        #region Constructors

        public MDItemThumbRuleDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<MDItemThumbRuleEntity> CreateEntityBuilder<MDItemThumbRuleEntity>()
        {
            return (new MDItemThumbRuleBuilder()) as IEntityBuilder<MDItemThumbRuleEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IMDItemThumbRuleDataAccess.Add(MDItemThumbRuleEntity mDItemThumbRuleEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(mDItemThumbRuleEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(mDItemThumbRuleEntity, option);
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

        private Int64 Add(MDItemThumbRuleEntity mDItemThumbRuleEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDItemThumbRule_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "MDItemThumbRuleID");

                Database.AddInParameter(cmd, "@ItemID", DbType.Int64, mDItemThumbRuleEntity.ItemID);	
                Database.AddInParameter(cmd, "@FloorRuleVariable", DbType.Decimal, mDItemThumbRuleEntity.FloorRuleVariable);	
                Database.AddInParameter(cmd, "@FloorQuantity", DbType.Decimal, mDItemThumbRuleEntity.FloorQuantity);	
                Database.AddInParameter(cmd, "@BasementRuleVariable", DbType.Decimal, mDItemThumbRuleEntity.BasementRuleVariable);	
                Database.AddInParameter(cmd, "@BasementQuantity", DbType.Decimal, mDItemThumbRuleEntity.BasementQuantity);	
                Database.AddInParameter(cmd, "@OverallRuleVariable", DbType.Decimal, mDItemThumbRuleEntity.OverallRuleVariable);	
                Database.AddInParameter(cmd, "@OverallQuantity", DbType.Decimal, mDItemThumbRuleEntity.OverallQuantity);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDItemThumbRuleEntity already exists. Please specify another MDItemThumbRuleEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDItemThumbRuleEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDItemThumbRuleEntity already exists. Please specify another MDItemThumbRuleEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(MDItemThumbRuleEntity mDItemThumbRuleEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDItemThumbRule_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "MDItemThumbRuleID", db);

                db.AddInParameter(cmd, "@ItemID", DbType.Int64, mDItemThumbRuleEntity.ItemID);
                db.AddInParameter(cmd, "@FloorRuleVariable", DbType.Decimal, mDItemThumbRuleEntity.FloorRuleVariable);
                db.AddInParameter(cmd, "@FloorQuantity", DbType.Decimal, mDItemThumbRuleEntity.FloorQuantity);
                db.AddInParameter(cmd, "@BasementRuleVariable", DbType.Decimal, mDItemThumbRuleEntity.BasementRuleVariable);
                db.AddInParameter(cmd, "@BasementQuantity", DbType.Decimal, mDItemThumbRuleEntity.BasementQuantity);
                db.AddInParameter(cmd, "@OverallRuleVariable", DbType.Decimal, mDItemThumbRuleEntity.OverallRuleVariable);
                db.AddInParameter(cmd, "@OverallQuantity", DbType.Decimal, mDItemThumbRuleEntity.OverallQuantity);

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

        IList<Int64> IMDItemThumbRuleDataAccess.Add(IList<MDItemThumbRuleEntity> mDItemThumbRuleEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (MDItemThumbRuleEntity mDItemThumbRuleEntity in mDItemThumbRuleEntityList)
            {
                returnCode = (this as IMDItemThumbRuleDataAccess).Add(mDItemThumbRuleEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IMDItemThumbRuleDataAccess.Update(MDItemThumbRuleEntity mDItemThumbRuleEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(mDItemThumbRuleEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(mDItemThumbRuleEntity, filterExpression, option);
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

        private Int64 Update(MDItemThumbRuleEntity mDItemThumbRuleEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDItemThumbRule_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@MDItemThumbRuleID", DbType.Int64, mDItemThumbRuleEntity.MDItemThumbRuleID);
                Database.AddInParameter(cmd, "@ItemID", DbType.Int64, mDItemThumbRuleEntity.ItemID);
                Database.AddInParameter(cmd, "@FloorRuleVariable", DbType.Decimal, mDItemThumbRuleEntity.FloorRuleVariable);
                Database.AddInParameter(cmd, "@FloorQuantity", DbType.Decimal, mDItemThumbRuleEntity.FloorQuantity);
                Database.AddInParameter(cmd, "@BasementRuleVariable", DbType.Decimal, mDItemThumbRuleEntity.BasementRuleVariable);
                Database.AddInParameter(cmd, "@BasementQuantity", DbType.Decimal, mDItemThumbRuleEntity.BasementQuantity);
                Database.AddInParameter(cmd, "@OverallRuleVariable", DbType.Decimal, mDItemThumbRuleEntity.OverallRuleVariable);
                Database.AddInParameter(cmd, "@OverallQuantity", DbType.Decimal, mDItemThumbRuleEntity.OverallQuantity);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDItemThumbRuleEntity already exists. Please specify another MDItemThumbRuleEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDItemThumbRuleEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDItemThumbRuleEntity already exists. Please specify another MDItemThumbRuleEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(MDItemThumbRuleEntity mDItemThumbRuleEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDItemThumbRule_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@MDItemThumbRuleID", DbType.Int64, mDItemThumbRuleEntity.MDItemThumbRuleID);
                db.AddInParameter(cmd, "@ItemID", DbType.Int64, mDItemThumbRuleEntity.ItemID);
                db.AddInParameter(cmd, "@FloorRuleVariable", DbType.Decimal, mDItemThumbRuleEntity.FloorRuleVariable);
                db.AddInParameter(cmd, "@FloorQuantity", DbType.Decimal, mDItemThumbRuleEntity.FloorQuantity);
                db.AddInParameter(cmd, "@BasementRuleVariable", DbType.Decimal, mDItemThumbRuleEntity.BasementRuleVariable);
                db.AddInParameter(cmd, "@BasementQuantity", DbType.Decimal, mDItemThumbRuleEntity.BasementQuantity);
                db.AddInParameter(cmd, "@OverallRuleVariable", DbType.Decimal, mDItemThumbRuleEntity.OverallRuleVariable);
                db.AddInParameter(cmd, "@OverallQuantity", DbType.Decimal, mDItemThumbRuleEntity.OverallQuantity);

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

        IList<Int64> IMDItemThumbRuleDataAccess.Update(IList<MDItemThumbRuleEntity> mDItemThumbRuleEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (MDItemThumbRuleEntity mDItemThumbRuleEntity in mDItemThumbRuleEntityList)
            {
                returnCode = (this as IMDItemThumbRuleDataAccess).Update(mDItemThumbRuleEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IMDItemThumbRuleDataAccess.Delete(MDItemThumbRuleEntity mDItemThumbRuleEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(mDItemThumbRuleEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(mDItemThumbRuleEntity, filterExpression, option);
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

        private Int64 Delete(MDItemThumbRuleEntity mDItemThumbRuleEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDItemThumbRule_SET";

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
                                throw new ArgumentException("MDItemThumbRuleEntity already exists. Please specify another MDItemThumbRuleEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDItemThumbRuleEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDItemThumbRuleEntity already exists. Please specify another MDItemThumbRuleEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(MDItemThumbRuleEntity mDItemThumbRuleEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDItemThumbRule_SET";

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

        IList<Int64> IMDItemThumbRuleDataAccess.Delete(IList<MDItemThumbRuleEntity> mDItemThumbRuleEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (MDItemThumbRuleEntity mDItemThumbRuleEntity in mDItemThumbRuleEntityList)
            {
                returnCode = (this as IMDItemThumbRuleDataAccess).Delete(mDItemThumbRuleEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<MDItemThumbRuleEntity> IMDItemThumbRuleDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDItemThumbRule_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<MDItemThumbRuleEntity> list = CreateEntityBuilder<MDItemThumbRuleEntity>().BuildEntities(reader);

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

        DataTable IMDItemThumbRuleDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDItemThumbRule_GET";

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
