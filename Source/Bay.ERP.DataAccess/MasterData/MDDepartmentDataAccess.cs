// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




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
    internal sealed partial class MDDepartmentDataAccess : BaseDataAccess, IMDDepartmentDataAccess
    {
        #region Constructors

        public MDDepartmentDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<MDDepartmentEntity> CreateEntityBuilder<MDDepartmentEntity>()
        {
            return (new MDDepartmentBuilder()) as IEntityBuilder<MDDepartmentEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IMDDepartmentDataAccess.Add(MDDepartmentEntity mDDepartmentEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(mDDepartmentEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(mDDepartmentEntity, option);
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

        private Int64 Add(MDDepartmentEntity mDDepartmentEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDDepartment_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "DepartmentID");

                Database.AddInParameter(cmd, "@ParentDepartmentID", DbType.Int64, mDDepartmentEntity.ParentDepartmentID);	
                Database.AddInParameter(cmd, "@DepartmentCode", DbType.String, mDDepartmentEntity.DepartmentCode);	
                Database.AddInParameter(cmd, "@Name", DbType.String, mDDepartmentEntity.Name);	
                Database.AddInParameter(cmd, "@Location", DbType.String, mDDepartmentEntity.Location);	
                Database.AddInParameter(cmd, "@HODEmployeeID", DbType.Int64, mDDepartmentEntity.HODEmployeeID);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDDepartmentEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDDepartmentEntity already exists. Please specify another MDDepartmentEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDDepartmentEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDDepartmentEntity already exists. Please specify another MDDepartmentEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(MDDepartmentEntity mDDepartmentEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDDepartment_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "DepartmentID", db);

                db.AddInParameter(cmd, "@ParentDepartmentID", DbType.Int64, mDDepartmentEntity.ParentDepartmentID);
                db.AddInParameter(cmd, "@DepartmentCode", DbType.String, mDDepartmentEntity.DepartmentCode);
                db.AddInParameter(cmd, "@Name", DbType.String, mDDepartmentEntity.Name);
                db.AddInParameter(cmd, "@Location", DbType.String, mDDepartmentEntity.Location);
                db.AddInParameter(cmd, "@HODEmployeeID", DbType.Int64, mDDepartmentEntity.HODEmployeeID);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDDepartmentEntity.IsRemoved);

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

        IList<Int64> IMDDepartmentDataAccess.Add(IList<MDDepartmentEntity> mDDepartmentEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (MDDepartmentEntity mDDepartmentEntity in mDDepartmentEntityList)
            {
                returnCode = (this as IMDDepartmentDataAccess).Add(mDDepartmentEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IMDDepartmentDataAccess.Update(MDDepartmentEntity mDDepartmentEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(mDDepartmentEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(mDDepartmentEntity, filterExpression, option);
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

        private Int64 Update(MDDepartmentEntity mDDepartmentEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDDepartment_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@DepartmentID", DbType.Int64, mDDepartmentEntity.DepartmentID);
                Database.AddInParameter(cmd, "@ParentDepartmentID", DbType.Int64, mDDepartmentEntity.ParentDepartmentID);
                Database.AddInParameter(cmd, "@DepartmentCode", DbType.String, mDDepartmentEntity.DepartmentCode);
                Database.AddInParameter(cmd, "@Name", DbType.String, mDDepartmentEntity.Name);
                Database.AddInParameter(cmd, "@Location", DbType.String, mDDepartmentEntity.Location);
                Database.AddInParameter(cmd, "@HODEmployeeID", DbType.Int64, mDDepartmentEntity.HODEmployeeID);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDDepartmentEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDDepartmentEntity already exists. Please specify another MDDepartmentEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDDepartmentEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDDepartmentEntity already exists. Please specify another MDDepartmentEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(MDDepartmentEntity mDDepartmentEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDDepartment_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@DepartmentID", DbType.Int64, mDDepartmentEntity.DepartmentID);
                db.AddInParameter(cmd, "@ParentDepartmentID", DbType.Int64, mDDepartmentEntity.ParentDepartmentID);
                db.AddInParameter(cmd, "@DepartmentCode", DbType.String, mDDepartmentEntity.DepartmentCode);
                db.AddInParameter(cmd, "@Name", DbType.String, mDDepartmentEntity.Name);
                db.AddInParameter(cmd, "@Location", DbType.String, mDDepartmentEntity.Location);
                db.AddInParameter(cmd, "@HODEmployeeID", DbType.Int64, mDDepartmentEntity.HODEmployeeID);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDDepartmentEntity.IsRemoved);

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

        IList<Int64> IMDDepartmentDataAccess.Update(IList<MDDepartmentEntity> mDDepartmentEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (MDDepartmentEntity mDDepartmentEntity in mDDepartmentEntityList)
            {
                returnCode = (this as IMDDepartmentDataAccess).Update(mDDepartmentEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IMDDepartmentDataAccess.Delete(MDDepartmentEntity mDDepartmentEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(mDDepartmentEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(mDDepartmentEntity, filterExpression, option);
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

        private Int64 Delete(MDDepartmentEntity mDDepartmentEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDDepartment_SET";

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
                                throw new ArgumentException("MDDepartmentEntity already exists. Please specify another MDDepartmentEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDDepartmentEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDDepartmentEntity already exists. Please specify another MDDepartmentEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(MDDepartmentEntity mDDepartmentEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDDepartment_SET";

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

        IList<Int64> IMDDepartmentDataAccess.Delete(IList<MDDepartmentEntity> mDDepartmentEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (MDDepartmentEntity mDDepartmentEntity in mDDepartmentEntityList)
            {
                returnCode = (this as IMDDepartmentDataAccess).Delete(mDDepartmentEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<MDDepartmentEntity> IMDDepartmentDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDDepartment_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<MDDepartmentEntity> list = CreateEntityBuilder<MDDepartmentEntity>().BuildEntities(reader);

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

        DataTable IMDDepartmentDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDDepartment_GET";

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
