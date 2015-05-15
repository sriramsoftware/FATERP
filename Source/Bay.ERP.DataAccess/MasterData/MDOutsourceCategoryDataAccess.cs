// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-Oct-2013, 01:41:30




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
    internal sealed partial class MDOutsourceCategoryDataAccess : BaseDataAccess, IMDOutsourceCategoryDataAccess
    {
        #region Constructors

        public MDOutsourceCategoryDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<MDOutsourceCategoryEntity> CreateEntityBuilder<MDOutsourceCategoryEntity>()
        {
            return (new MDOutsourceCategoryBuilder()) as IEntityBuilder<MDOutsourceCategoryEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IMDOutsourceCategoryDataAccess.Add(MDOutsourceCategoryEntity mDOutsourceCategoryEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(mDOutsourceCategoryEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(mDOutsourceCategoryEntity, option);
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

        private Int64 Add(MDOutsourceCategoryEntity mDOutsourceCategoryEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDOutsourceCategory_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "OutsourceCategoryID");

                Database.AddInParameter(cmd, "@Name", DbType.String, mDOutsourceCategoryEntity.Name);	
                Database.AddInParameter(cmd, "@Description", DbType.String, mDOutsourceCategoryEntity.Description);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDOutsourceCategoryEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDOutsourceCategoryEntity already exists. Please specify another MDOutsourceCategoryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDOutsourceCategoryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDOutsourceCategoryEntity already exists. Please specify another MDOutsourceCategoryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(MDOutsourceCategoryEntity mDOutsourceCategoryEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDOutsourceCategory_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "OutsourceCategoryID", db);

                db.AddInParameter(cmd, "@Name", DbType.String, mDOutsourceCategoryEntity.Name);
                db.AddInParameter(cmd, "@Description", DbType.String, mDOutsourceCategoryEntity.Description);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDOutsourceCategoryEntity.IsRemoved);

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

        IList<Int64> IMDOutsourceCategoryDataAccess.Add(IList<MDOutsourceCategoryEntity> mDOutsourceCategoryEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (MDOutsourceCategoryEntity mDOutsourceCategoryEntity in mDOutsourceCategoryEntityList)
            {
                returnCode = (this as IMDOutsourceCategoryDataAccess).Add(mDOutsourceCategoryEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IMDOutsourceCategoryDataAccess.Update(MDOutsourceCategoryEntity mDOutsourceCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(mDOutsourceCategoryEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(mDOutsourceCategoryEntity, filterExpression, option);
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

        private Int64 Update(MDOutsourceCategoryEntity mDOutsourceCategoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDOutsourceCategory_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@OutsourceCategoryID", DbType.Int64, mDOutsourceCategoryEntity.OutsourceCategoryID);
                Database.AddInParameter(cmd, "@Name", DbType.String, mDOutsourceCategoryEntity.Name);
                Database.AddInParameter(cmd, "@Description", DbType.String, mDOutsourceCategoryEntity.Description);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDOutsourceCategoryEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDOutsourceCategoryEntity already exists. Please specify another MDOutsourceCategoryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDOutsourceCategoryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDOutsourceCategoryEntity already exists. Please specify another MDOutsourceCategoryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(MDOutsourceCategoryEntity mDOutsourceCategoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDOutsourceCategory_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@OutsourceCategoryID", DbType.Int64, mDOutsourceCategoryEntity.OutsourceCategoryID);
                db.AddInParameter(cmd, "@Name", DbType.String, mDOutsourceCategoryEntity.Name);
                db.AddInParameter(cmd, "@Description", DbType.String, mDOutsourceCategoryEntity.Description);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDOutsourceCategoryEntity.IsRemoved);

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

        IList<Int64> IMDOutsourceCategoryDataAccess.Update(IList<MDOutsourceCategoryEntity> mDOutsourceCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (MDOutsourceCategoryEntity mDOutsourceCategoryEntity in mDOutsourceCategoryEntityList)
            {
                returnCode = (this as IMDOutsourceCategoryDataAccess).Update(mDOutsourceCategoryEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IMDOutsourceCategoryDataAccess.Delete(MDOutsourceCategoryEntity mDOutsourceCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(mDOutsourceCategoryEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(mDOutsourceCategoryEntity, filterExpression, option);
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

        private Int64 Delete(MDOutsourceCategoryEntity mDOutsourceCategoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDOutsourceCategory_SET";

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
                                throw new ArgumentException("MDOutsourceCategoryEntity already exists. Please specify another MDOutsourceCategoryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDOutsourceCategoryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDOutsourceCategoryEntity already exists. Please specify another MDOutsourceCategoryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(MDOutsourceCategoryEntity mDOutsourceCategoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDOutsourceCategory_SET";

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

        IList<Int64> IMDOutsourceCategoryDataAccess.Delete(IList<MDOutsourceCategoryEntity> mDOutsourceCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (MDOutsourceCategoryEntity mDOutsourceCategoryEntity in mDOutsourceCategoryEntityList)
            {
                returnCode = (this as IMDOutsourceCategoryDataAccess).Delete(mDOutsourceCategoryEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<MDOutsourceCategoryEntity> IMDOutsourceCategoryDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDOutsourceCategory_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<MDOutsourceCategoryEntity> list = CreateEntityBuilder<MDOutsourceCategoryEntity>().BuildEntities(reader);

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

        DataTable IMDOutsourceCategoryDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDOutsourceCategory_GET";

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
