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
    internal sealed partial class DMSFileTrackingDataAccess : BaseDataAccess, IDMSFileTrackingDataAccess
    {
        #region Constructors

        public DMSFileTrackingDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<DMSFileTrackingEntity> CreateEntityBuilder<DMSFileTrackingEntity>()
        {
            return (new DMSFileTrackingBuilder()) as IEntityBuilder<DMSFileTrackingEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IDMSFileTrackingDataAccess.Add(DMSFileTrackingEntity dMSFileTrackingEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(dMSFileTrackingEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(dMSFileTrackingEntity, option);
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

        private Int64 Add(DMSFileTrackingEntity dMSFileTrackingEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.DMSFileTracking_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "FileTrackingID");

                Database.AddInParameter(cmd, "@FileNo", DbType.String, dMSFileTrackingEntity.FileNo);	
                Database.AddInParameter(cmd, "@FileName", DbType.String, dMSFileTrackingEntity.FileName);	
                Database.AddInParameter(cmd, "@DepartmentID", DbType.Int64, dMSFileTrackingEntity.DepartmentID);	
                Database.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, dMSFileTrackingEntity.CreatedByEmployeeID);	
                Database.AddInParameter(cmd, "@CreatedDateTime", DbType.DateTime, dMSFileTrackingEntity.CreatedDateTime);	
                Database.AddInParameter(cmd, "@FileParmanentPlace", DbType.String, dMSFileTrackingEntity.FileParmanentPlace);	
                Database.AddInParameter(cmd, "@FileCurrentPlace", DbType.String, dMSFileTrackingEntity.FileCurrentPlace);	
                Database.AddInParameter(cmd, "@FileType", DbType.String, dMSFileTrackingEntity.FileType);	
                Database.AddInParameter(cmd, "@SoftFileName", DbType.String, dMSFileTrackingEntity.SoftFileName);	
                Database.AddInParameter(cmd, "@Extension", DbType.String, dMSFileTrackingEntity.Extension);	
                Database.AddInParameter(cmd, "@Path", DbType.String, dMSFileTrackingEntity.Path);	
                Database.AddInParameter(cmd, "@OriginalFileName", DbType.String, dMSFileTrackingEntity.OriginalFileName);	
                Database.AddInParameter(cmd, "@CurrentFileName", DbType.String, dMSFileTrackingEntity.CurrentFileName);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("DMSFileTrackingEntity already exists. Please specify another DMSFileTrackingEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("DMSFileTrackingEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("DMSFileTrackingEntity already exists. Please specify another DMSFileTrackingEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(DMSFileTrackingEntity dMSFileTrackingEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.DMSFileTracking_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "FileTrackingID", db);

                db.AddInParameter(cmd, "@FileNo", DbType.String, dMSFileTrackingEntity.FileNo);
                db.AddInParameter(cmd, "@FileName", DbType.String, dMSFileTrackingEntity.FileName);
                db.AddInParameter(cmd, "@DepartmentID", DbType.Int64, dMSFileTrackingEntity.DepartmentID);
                db.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, dMSFileTrackingEntity.CreatedByEmployeeID);
                db.AddInParameter(cmd, "@CreatedDateTime", DbType.DateTime, dMSFileTrackingEntity.CreatedDateTime);
                db.AddInParameter(cmd, "@FileParmanentPlace", DbType.String, dMSFileTrackingEntity.FileParmanentPlace);
                db.AddInParameter(cmd, "@FileCurrentPlace", DbType.String, dMSFileTrackingEntity.FileCurrentPlace);
                db.AddInParameter(cmd, "@FileType", DbType.String, dMSFileTrackingEntity.FileType);
                db.AddInParameter(cmd, "@SoftFileName", DbType.String, dMSFileTrackingEntity.SoftFileName);
                db.AddInParameter(cmd, "@Extension", DbType.String, dMSFileTrackingEntity.Extension);
                db.AddInParameter(cmd, "@Path", DbType.String, dMSFileTrackingEntity.Path);
                db.AddInParameter(cmd, "@OriginalFileName", DbType.String, dMSFileTrackingEntity.OriginalFileName);
                db.AddInParameter(cmd, "@CurrentFileName", DbType.String, dMSFileTrackingEntity.CurrentFileName);

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

        IList<Int64> IDMSFileTrackingDataAccess.Add(IList<DMSFileTrackingEntity> dMSFileTrackingEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (DMSFileTrackingEntity dMSFileTrackingEntity in dMSFileTrackingEntityList)
            {
                returnCode = (this as IDMSFileTrackingDataAccess).Add(dMSFileTrackingEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IDMSFileTrackingDataAccess.Update(DMSFileTrackingEntity dMSFileTrackingEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(dMSFileTrackingEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(dMSFileTrackingEntity, filterExpression, option);
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

        private Int64 Update(DMSFileTrackingEntity dMSFileTrackingEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.DMSFileTracking_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@FileTrackingID", DbType.Int64, dMSFileTrackingEntity.FileTrackingID);
                Database.AddInParameter(cmd, "@FileNo", DbType.String, dMSFileTrackingEntity.FileNo);
                Database.AddInParameter(cmd, "@FileName", DbType.String, dMSFileTrackingEntity.FileName);
                Database.AddInParameter(cmd, "@DepartmentID", DbType.Int64, dMSFileTrackingEntity.DepartmentID);
                Database.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, dMSFileTrackingEntity.CreatedByEmployeeID);
                Database.AddInParameter(cmd, "@CreatedDateTime", DbType.DateTime, dMSFileTrackingEntity.CreatedDateTime);
                Database.AddInParameter(cmd, "@FileParmanentPlace", DbType.String, dMSFileTrackingEntity.FileParmanentPlace);
                Database.AddInParameter(cmd, "@FileCurrentPlace", DbType.String, dMSFileTrackingEntity.FileCurrentPlace);
                Database.AddInParameter(cmd, "@FileType", DbType.String, dMSFileTrackingEntity.FileType);
                Database.AddInParameter(cmd, "@SoftFileName", DbType.String, dMSFileTrackingEntity.SoftFileName);
                Database.AddInParameter(cmd, "@Extension", DbType.String, dMSFileTrackingEntity.Extension);
                Database.AddInParameter(cmd, "@Path", DbType.String, dMSFileTrackingEntity.Path);
                Database.AddInParameter(cmd, "@OriginalFileName", DbType.String, dMSFileTrackingEntity.OriginalFileName);
                Database.AddInParameter(cmd, "@CurrentFileName", DbType.String, dMSFileTrackingEntity.CurrentFileName);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("DMSFileTrackingEntity already exists. Please specify another DMSFileTrackingEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("DMSFileTrackingEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("DMSFileTrackingEntity already exists. Please specify another DMSFileTrackingEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(DMSFileTrackingEntity dMSFileTrackingEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.DMSFileTracking_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@FileTrackingID", DbType.Int64, dMSFileTrackingEntity.FileTrackingID);
                db.AddInParameter(cmd, "@FileNo", DbType.String, dMSFileTrackingEntity.FileNo);
                db.AddInParameter(cmd, "@FileName", DbType.String, dMSFileTrackingEntity.FileName);
                db.AddInParameter(cmd, "@DepartmentID", DbType.Int64, dMSFileTrackingEntity.DepartmentID);
                db.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, dMSFileTrackingEntity.CreatedByEmployeeID);
                db.AddInParameter(cmd, "@CreatedDateTime", DbType.DateTime, dMSFileTrackingEntity.CreatedDateTime);
                db.AddInParameter(cmd, "@FileParmanentPlace", DbType.String, dMSFileTrackingEntity.FileParmanentPlace);
                db.AddInParameter(cmd, "@FileCurrentPlace", DbType.String, dMSFileTrackingEntity.FileCurrentPlace);
                db.AddInParameter(cmd, "@FileType", DbType.String, dMSFileTrackingEntity.FileType);
                db.AddInParameter(cmd, "@SoftFileName", DbType.String, dMSFileTrackingEntity.SoftFileName);
                db.AddInParameter(cmd, "@Extension", DbType.String, dMSFileTrackingEntity.Extension);
                db.AddInParameter(cmd, "@Path", DbType.String, dMSFileTrackingEntity.Path);
                db.AddInParameter(cmd, "@OriginalFileName", DbType.String, dMSFileTrackingEntity.OriginalFileName);
                db.AddInParameter(cmd, "@CurrentFileName", DbType.String, dMSFileTrackingEntity.CurrentFileName);

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

        IList<Int64> IDMSFileTrackingDataAccess.Update(IList<DMSFileTrackingEntity> dMSFileTrackingEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (DMSFileTrackingEntity dMSFileTrackingEntity in dMSFileTrackingEntityList)
            {
                returnCode = (this as IDMSFileTrackingDataAccess).Update(dMSFileTrackingEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IDMSFileTrackingDataAccess.Delete(DMSFileTrackingEntity dMSFileTrackingEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(dMSFileTrackingEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(dMSFileTrackingEntity, filterExpression, option);
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

        private Int64 Delete(DMSFileTrackingEntity dMSFileTrackingEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.DMSFileTracking_SET";

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
                                throw new ArgumentException("DMSFileTrackingEntity already exists. Please specify another DMSFileTrackingEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("DMSFileTrackingEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("DMSFileTrackingEntity already exists. Please specify another DMSFileTrackingEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(DMSFileTrackingEntity dMSFileTrackingEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.DMSFileTracking_SET";

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

        IList<Int64> IDMSFileTrackingDataAccess.Delete(IList<DMSFileTrackingEntity> dMSFileTrackingEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (DMSFileTrackingEntity dMSFileTrackingEntity in dMSFileTrackingEntityList)
            {
                returnCode = (this as IDMSFileTrackingDataAccess).Delete(dMSFileTrackingEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<DMSFileTrackingEntity> IDMSFileTrackingDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.DMSFileTracking_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<DMSFileTrackingEntity> list = CreateEntityBuilder<DMSFileTrackingEntity>().BuildEntities(reader);

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

        DataTable IDMSFileTrackingDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.DMSFileTracking_GET";

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
