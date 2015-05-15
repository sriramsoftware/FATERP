// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Sep-2012, 10:06:41




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
    internal sealed partial class DMSReferenceLibraryDataAccess : BaseDataAccess, IDMSReferenceLibraryDataAccess
    {
        #region Constructors

        public DMSReferenceLibraryDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<DMSReferenceLibraryEntity> CreateEntityBuilder<DMSReferenceLibraryEntity>()
        {
            return (new DMSReferenceLibraryBuilder()) as IEntityBuilder<DMSReferenceLibraryEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IDMSReferenceLibraryDataAccess.Add(DMSReferenceLibraryEntity dMSReferenceLibraryEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(dMSReferenceLibraryEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(dMSReferenceLibraryEntity, option);
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

        private Int64 Add(DMSReferenceLibraryEntity dMSReferenceLibraryEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.DMSReferenceLibrary_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ReferenceLibraryID");

                Database.AddInParameter(cmd, "@ReferenceLibraryCategoryID", DbType.Int64, dMSReferenceLibraryEntity.ReferenceLibraryCategoryID);	
                Database.AddInParameter(cmd, "@Url", DbType.String, dMSReferenceLibraryEntity.Url);	
                Database.AddInParameter(cmd, "@Description", DbType.String, dMSReferenceLibraryEntity.Description);	
                Database.AddInParameter(cmd, "@FileName", DbType.String, dMSReferenceLibraryEntity.FileName);	
                Database.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, dMSReferenceLibraryEntity.CreatedByEmployeeID);	
                Database.AddInParameter(cmd, "@ReferencedByEmployeeID", DbType.Int64, dMSReferenceLibraryEntity.ReferencedByEmployeeID);	
                Database.AddInParameter(cmd, "@Extension", DbType.String, dMSReferenceLibraryEntity.Extension);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, dMSReferenceLibraryEntity.Remarks);	
                Database.AddInParameter(cmd, "@Path", DbType.String, dMSReferenceLibraryEntity.Path);	
                Database.AddInParameter(cmd, "@OriginalFileName", DbType.String, dMSReferenceLibraryEntity.OriginalFileName);	
                Database.AddInParameter(cmd, "@CurrentFileName", DbType.String, dMSReferenceLibraryEntity.CurrentFileName);	
                Database.AddInParameter(cmd, "@FileType", DbType.String, dMSReferenceLibraryEntity.FileType);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("DMSReferenceLibraryEntity already exists. Please specify another DMSReferenceLibraryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("DMSReferenceLibraryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("DMSReferenceLibraryEntity already exists. Please specify another DMSReferenceLibraryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(DMSReferenceLibraryEntity dMSReferenceLibraryEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.DMSReferenceLibrary_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ReferenceLibraryID", db);

                db.AddInParameter(cmd, "@ReferenceLibraryCategoryID", DbType.Int64, dMSReferenceLibraryEntity.ReferenceLibraryCategoryID);
                db.AddInParameter(cmd, "@Url", DbType.String, dMSReferenceLibraryEntity.Url);
                db.AddInParameter(cmd, "@Description", DbType.String, dMSReferenceLibraryEntity.Description);
                db.AddInParameter(cmd, "@FileName", DbType.String, dMSReferenceLibraryEntity.FileName);
                db.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, dMSReferenceLibraryEntity.CreatedByEmployeeID);
                db.AddInParameter(cmd, "@ReferencedByEmployeeID", DbType.Int64, dMSReferenceLibraryEntity.ReferencedByEmployeeID);
                db.AddInParameter(cmd, "@Extension", DbType.String, dMSReferenceLibraryEntity.Extension);
                db.AddInParameter(cmd, "@Remarks", DbType.String, dMSReferenceLibraryEntity.Remarks);
                db.AddInParameter(cmd, "@Path", DbType.String, dMSReferenceLibraryEntity.Path);
                db.AddInParameter(cmd, "@OriginalFileName", DbType.String, dMSReferenceLibraryEntity.OriginalFileName);
                db.AddInParameter(cmd, "@CurrentFileName", DbType.String, dMSReferenceLibraryEntity.CurrentFileName);
                db.AddInParameter(cmd, "@FileType", DbType.String, dMSReferenceLibraryEntity.FileType);

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

        IList<Int64> IDMSReferenceLibraryDataAccess.Add(IList<DMSReferenceLibraryEntity> dMSReferenceLibraryEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (DMSReferenceLibraryEntity dMSReferenceLibraryEntity in dMSReferenceLibraryEntityList)
            {
                returnCode = (this as IDMSReferenceLibraryDataAccess).Add(dMSReferenceLibraryEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IDMSReferenceLibraryDataAccess.Update(DMSReferenceLibraryEntity dMSReferenceLibraryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(dMSReferenceLibraryEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(dMSReferenceLibraryEntity, filterExpression, option);
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

        private Int64 Update(DMSReferenceLibraryEntity dMSReferenceLibraryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.DMSReferenceLibrary_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ReferenceLibraryID", DbType.Int64, dMSReferenceLibraryEntity.ReferenceLibraryID);
                Database.AddInParameter(cmd, "@ReferenceLibraryCategoryID", DbType.Int64, dMSReferenceLibraryEntity.ReferenceLibraryCategoryID);
                Database.AddInParameter(cmd, "@Url", DbType.String, dMSReferenceLibraryEntity.Url);
                Database.AddInParameter(cmd, "@Description", DbType.String, dMSReferenceLibraryEntity.Description);
                Database.AddInParameter(cmd, "@FileName", DbType.String, dMSReferenceLibraryEntity.FileName);
                Database.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, dMSReferenceLibraryEntity.CreatedByEmployeeID);
                Database.AddInParameter(cmd, "@ReferencedByEmployeeID", DbType.Int64, dMSReferenceLibraryEntity.ReferencedByEmployeeID);
                Database.AddInParameter(cmd, "@Extension", DbType.String, dMSReferenceLibraryEntity.Extension);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, dMSReferenceLibraryEntity.Remarks);
                Database.AddInParameter(cmd, "@Path", DbType.String, dMSReferenceLibraryEntity.Path);
                Database.AddInParameter(cmd, "@OriginalFileName", DbType.String, dMSReferenceLibraryEntity.OriginalFileName);
                Database.AddInParameter(cmd, "@CurrentFileName", DbType.String, dMSReferenceLibraryEntity.CurrentFileName);
                Database.AddInParameter(cmd, "@FileType", DbType.String, dMSReferenceLibraryEntity.FileType);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("DMSReferenceLibraryEntity already exists. Please specify another DMSReferenceLibraryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("DMSReferenceLibraryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("DMSReferenceLibraryEntity already exists. Please specify another DMSReferenceLibraryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(DMSReferenceLibraryEntity dMSReferenceLibraryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.DMSReferenceLibrary_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ReferenceLibraryID", DbType.Int64, dMSReferenceLibraryEntity.ReferenceLibraryID);
                db.AddInParameter(cmd, "@ReferenceLibraryCategoryID", DbType.Int64, dMSReferenceLibraryEntity.ReferenceLibraryCategoryID);
                db.AddInParameter(cmd, "@Url", DbType.String, dMSReferenceLibraryEntity.Url);
                db.AddInParameter(cmd, "@Description", DbType.String, dMSReferenceLibraryEntity.Description);
                db.AddInParameter(cmd, "@FileName", DbType.String, dMSReferenceLibraryEntity.FileName);
                db.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, dMSReferenceLibraryEntity.CreatedByEmployeeID);
                db.AddInParameter(cmd, "@ReferencedByEmployeeID", DbType.Int64, dMSReferenceLibraryEntity.ReferencedByEmployeeID);
                db.AddInParameter(cmd, "@Extension", DbType.String, dMSReferenceLibraryEntity.Extension);
                db.AddInParameter(cmd, "@Remarks", DbType.String, dMSReferenceLibraryEntity.Remarks);
                db.AddInParameter(cmd, "@Path", DbType.String, dMSReferenceLibraryEntity.Path);
                db.AddInParameter(cmd, "@OriginalFileName", DbType.String, dMSReferenceLibraryEntity.OriginalFileName);
                db.AddInParameter(cmd, "@CurrentFileName", DbType.String, dMSReferenceLibraryEntity.CurrentFileName);
                db.AddInParameter(cmd, "@FileType", DbType.String, dMSReferenceLibraryEntity.FileType);

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

        IList<Int64> IDMSReferenceLibraryDataAccess.Update(IList<DMSReferenceLibraryEntity> dMSReferenceLibraryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (DMSReferenceLibraryEntity dMSReferenceLibraryEntity in dMSReferenceLibraryEntityList)
            {
                returnCode = (this as IDMSReferenceLibraryDataAccess).Update(dMSReferenceLibraryEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IDMSReferenceLibraryDataAccess.Delete(DMSReferenceLibraryEntity dMSReferenceLibraryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(dMSReferenceLibraryEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(dMSReferenceLibraryEntity, filterExpression, option);
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

        private Int64 Delete(DMSReferenceLibraryEntity dMSReferenceLibraryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.DMSReferenceLibrary_SET";

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
                                throw new ArgumentException("DMSReferenceLibraryEntity already exists. Please specify another DMSReferenceLibraryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("DMSReferenceLibraryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("DMSReferenceLibraryEntity already exists. Please specify another DMSReferenceLibraryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(DMSReferenceLibraryEntity dMSReferenceLibraryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.DMSReferenceLibrary_SET";

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

        IList<Int64> IDMSReferenceLibraryDataAccess.Delete(IList<DMSReferenceLibraryEntity> dMSReferenceLibraryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (DMSReferenceLibraryEntity dMSReferenceLibraryEntity in dMSReferenceLibraryEntityList)
            {
                returnCode = (this as IDMSReferenceLibraryDataAccess).Delete(dMSReferenceLibraryEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<DMSReferenceLibraryEntity> IDMSReferenceLibraryDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.DMSReferenceLibrary_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<DMSReferenceLibraryEntity> list = CreateEntityBuilder<DMSReferenceLibraryEntity>().BuildEntities(reader);

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

        DataTable IDMSReferenceLibraryDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.DMSReferenceLibrary_GET";

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
