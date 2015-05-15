// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




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
    internal sealed partial class HREmployeeDocumentDataAccess : BaseDataAccess, IHREmployeeDocumentDataAccess
    {
        #region Constructors

        public HREmployeeDocumentDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREmployeeDocumentEntity> CreateEntityBuilder<HREmployeeDocumentEntity>()
        {
            return (new HREmployeeDocumentBuilder()) as IEntityBuilder<HREmployeeDocumentEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IHREmployeeDocumentDataAccess.Add(HREmployeeDocumentEntity hREmployeeDocumentEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(hREmployeeDocumentEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(hREmployeeDocumentEntity, option);
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

        private Int64 Add(HREmployeeDocumentEntity hREmployeeDocumentEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeDocument_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "EmployeeDocumentID");

                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeDocumentEntity.EmployeeID);	
                Database.AddInParameter(cmd, "@DocumentCategoryID", DbType.Int64, hREmployeeDocumentEntity.DocumentCategoryID);	
                Database.AddInParameter(cmd, "@Extension", DbType.String, hREmployeeDocumentEntity.Extension);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeeDocumentEntity.Remarks);	
                Database.AddInParameter(cmd, "@Path", DbType.String, hREmployeeDocumentEntity.Path);	
                Database.AddInParameter(cmd, "@OriginalFileName", DbType.String, hREmployeeDocumentEntity.OriginalFileName);	
                Database.AddInParameter(cmd, "@CurrentFileName", DbType.String, hREmployeeDocumentEntity.CurrentFileName);	
                Database.AddInParameter(cmd, "@FileType", DbType.String, hREmployeeDocumentEntity.FileType);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeDocumentEntity already exists. Please specify another HREmployeeDocumentEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeDocumentEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeDocumentEntity already exists. Please specify another HREmployeeDocumentEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(HREmployeeDocumentEntity hREmployeeDocumentEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeDocument_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "EmployeeDocumentID", db);

                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeDocumentEntity.EmployeeID);
                db.AddInParameter(cmd, "@DocumentCategoryID", DbType.Int64, hREmployeeDocumentEntity.DocumentCategoryID);
                db.AddInParameter(cmd, "@Extension", DbType.String, hREmployeeDocumentEntity.Extension);
                db.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeeDocumentEntity.Remarks);
                db.AddInParameter(cmd, "@Path", DbType.String, hREmployeeDocumentEntity.Path);
                db.AddInParameter(cmd, "@OriginalFileName", DbType.String, hREmployeeDocumentEntity.OriginalFileName);
                db.AddInParameter(cmd, "@CurrentFileName", DbType.String, hREmployeeDocumentEntity.CurrentFileName);
                db.AddInParameter(cmd, "@FileType", DbType.String, hREmployeeDocumentEntity.FileType);

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

        IList<Int64> IHREmployeeDocumentDataAccess.Add(IList<HREmployeeDocumentEntity> hREmployeeDocumentEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (HREmployeeDocumentEntity hREmployeeDocumentEntity in hREmployeeDocumentEntityList)
            {
                returnCode = (this as IHREmployeeDocumentDataAccess).Add(hREmployeeDocumentEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IHREmployeeDocumentDataAccess.Update(HREmployeeDocumentEntity hREmployeeDocumentEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(hREmployeeDocumentEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(hREmployeeDocumentEntity, filterExpression, option);
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

        private Int64 Update(HREmployeeDocumentEntity hREmployeeDocumentEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeDocument_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@EmployeeDocumentID", DbType.Int64, hREmployeeDocumentEntity.EmployeeDocumentID);
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeDocumentEntity.EmployeeID);
                Database.AddInParameter(cmd, "@DocumentCategoryID", DbType.Int64, hREmployeeDocumentEntity.DocumentCategoryID);
                Database.AddInParameter(cmd, "@Extension", DbType.String, hREmployeeDocumentEntity.Extension);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeeDocumentEntity.Remarks);
                Database.AddInParameter(cmd, "@Path", DbType.String, hREmployeeDocumentEntity.Path);
                Database.AddInParameter(cmd, "@OriginalFileName", DbType.String, hREmployeeDocumentEntity.OriginalFileName);
                Database.AddInParameter(cmd, "@CurrentFileName", DbType.String, hREmployeeDocumentEntity.CurrentFileName);
                Database.AddInParameter(cmd, "@FileType", DbType.String, hREmployeeDocumentEntity.FileType);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeDocumentEntity already exists. Please specify another HREmployeeDocumentEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeDocumentEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeDocumentEntity already exists. Please specify another HREmployeeDocumentEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(HREmployeeDocumentEntity hREmployeeDocumentEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeDocument_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@EmployeeDocumentID", DbType.Int64, hREmployeeDocumentEntity.EmployeeDocumentID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeDocumentEntity.EmployeeID);
                db.AddInParameter(cmd, "@DocumentCategoryID", DbType.Int64, hREmployeeDocumentEntity.DocumentCategoryID);
                db.AddInParameter(cmd, "@Extension", DbType.String, hREmployeeDocumentEntity.Extension);
                db.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeeDocumentEntity.Remarks);
                db.AddInParameter(cmd, "@Path", DbType.String, hREmployeeDocumentEntity.Path);
                db.AddInParameter(cmd, "@OriginalFileName", DbType.String, hREmployeeDocumentEntity.OriginalFileName);
                db.AddInParameter(cmd, "@CurrentFileName", DbType.String, hREmployeeDocumentEntity.CurrentFileName);
                db.AddInParameter(cmd, "@FileType", DbType.String, hREmployeeDocumentEntity.FileType);

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

        IList<Int64> IHREmployeeDocumentDataAccess.Update(IList<HREmployeeDocumentEntity> hREmployeeDocumentEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (HREmployeeDocumentEntity hREmployeeDocumentEntity in hREmployeeDocumentEntityList)
            {
                returnCode = (this as IHREmployeeDocumentDataAccess).Update(hREmployeeDocumentEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IHREmployeeDocumentDataAccess.Delete(HREmployeeDocumentEntity hREmployeeDocumentEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(hREmployeeDocumentEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(hREmployeeDocumentEntity, filterExpression, option);
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

        private Int64 Delete(HREmployeeDocumentEntity hREmployeeDocumentEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeDocument_SET";

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
                                throw new ArgumentException("HREmployeeDocumentEntity already exists. Please specify another HREmployeeDocumentEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeDocumentEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeDocumentEntity already exists. Please specify another HREmployeeDocumentEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(HREmployeeDocumentEntity hREmployeeDocumentEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeDocument_SET";

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

        IList<Int64> IHREmployeeDocumentDataAccess.Delete(IList<HREmployeeDocumentEntity> hREmployeeDocumentEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (HREmployeeDocumentEntity hREmployeeDocumentEntity in hREmployeeDocumentEntityList)
            {
                returnCode = (this as IHREmployeeDocumentDataAccess).Delete(hREmployeeDocumentEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<HREmployeeDocumentEntity> IHREmployeeDocumentDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeDocument_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREmployeeDocumentEntity> list = CreateEntityBuilder<HREmployeeDocumentEntity>().BuildEntities(reader);

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

        DataTable IHREmployeeDocumentDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeDocument_GET";

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
