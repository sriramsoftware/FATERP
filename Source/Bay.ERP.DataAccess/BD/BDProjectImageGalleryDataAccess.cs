// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jun-2013, 02:07:00




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
    internal sealed partial class BDProjectImageGalleryDataAccess : BaseDataAccess, IBDProjectImageGalleryDataAccess
    {
        #region Constructors

        public BDProjectImageGalleryDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<BDProjectImageGalleryEntity> CreateEntityBuilder<BDProjectImageGalleryEntity>()
        {
            return (new BDProjectImageGalleryBuilder()) as IEntityBuilder<BDProjectImageGalleryEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IBDProjectImageGalleryDataAccess.Add(BDProjectImageGalleryEntity bDProjectImageGalleryEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(bDProjectImageGalleryEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(bDProjectImageGalleryEntity, option);
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

        private Int64 Add(BDProjectImageGalleryEntity bDProjectImageGalleryEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectImageGallery_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ProjectImageGalleryID");

                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectImageGalleryEntity.ProjectID);	
                Database.AddInParameter(cmd, "@Extension", DbType.String, bDProjectImageGalleryEntity.Extension);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, bDProjectImageGalleryEntity.Remarks);	
                Database.AddInParameter(cmd, "@Path", DbType.String, bDProjectImageGalleryEntity.Path);	
                Database.AddInParameter(cmd, "@OriginalFileName", DbType.String, bDProjectImageGalleryEntity.OriginalFileName);	
                Database.AddInParameter(cmd, "@CurrentFileName", DbType.String, bDProjectImageGalleryEntity.CurrentFileName);	
                Database.AddInParameter(cmd, "@FileType", DbType.String, bDProjectImageGalleryEntity.FileType);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDProjectImageGalleryEntity already exists. Please specify another BDProjectImageGalleryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectImageGalleryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectImageGalleryEntity already exists. Please specify another BDProjectImageGalleryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(BDProjectImageGalleryEntity bDProjectImageGalleryEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectImageGallery_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ProjectImageGalleryID", db);

                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectImageGalleryEntity.ProjectID);
                db.AddInParameter(cmd, "@Extension", DbType.String, bDProjectImageGalleryEntity.Extension);
                db.AddInParameter(cmd, "@Remarks", DbType.String, bDProjectImageGalleryEntity.Remarks);
                db.AddInParameter(cmd, "@Path", DbType.String, bDProjectImageGalleryEntity.Path);
                db.AddInParameter(cmd, "@OriginalFileName", DbType.String, bDProjectImageGalleryEntity.OriginalFileName);
                db.AddInParameter(cmd, "@CurrentFileName", DbType.String, bDProjectImageGalleryEntity.CurrentFileName);
                db.AddInParameter(cmd, "@FileType", DbType.String, bDProjectImageGalleryEntity.FileType);

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

        IList<Int64> IBDProjectImageGalleryDataAccess.Add(IList<BDProjectImageGalleryEntity> bDProjectImageGalleryEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (BDProjectImageGalleryEntity bDProjectImageGalleryEntity in bDProjectImageGalleryEntityList)
            {
                returnCode = (this as IBDProjectImageGalleryDataAccess).Add(bDProjectImageGalleryEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IBDProjectImageGalleryDataAccess.Update(BDProjectImageGalleryEntity bDProjectImageGalleryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(bDProjectImageGalleryEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(bDProjectImageGalleryEntity, filterExpression, option);
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

        private Int64 Update(BDProjectImageGalleryEntity bDProjectImageGalleryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectImageGallery_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ProjectImageGalleryID", DbType.Int64, bDProjectImageGalleryEntity.ProjectImageGalleryID);
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectImageGalleryEntity.ProjectID);
                Database.AddInParameter(cmd, "@Extension", DbType.String, bDProjectImageGalleryEntity.Extension);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, bDProjectImageGalleryEntity.Remarks);
                Database.AddInParameter(cmd, "@Path", DbType.String, bDProjectImageGalleryEntity.Path);
                Database.AddInParameter(cmd, "@OriginalFileName", DbType.String, bDProjectImageGalleryEntity.OriginalFileName);
                Database.AddInParameter(cmd, "@CurrentFileName", DbType.String, bDProjectImageGalleryEntity.CurrentFileName);
                Database.AddInParameter(cmd, "@FileType", DbType.String, bDProjectImageGalleryEntity.FileType);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDProjectImageGalleryEntity already exists. Please specify another BDProjectImageGalleryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectImageGalleryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectImageGalleryEntity already exists. Please specify another BDProjectImageGalleryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(BDProjectImageGalleryEntity bDProjectImageGalleryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectImageGallery_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ProjectImageGalleryID", DbType.Int64, bDProjectImageGalleryEntity.ProjectImageGalleryID);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectImageGalleryEntity.ProjectID);
                db.AddInParameter(cmd, "@Extension", DbType.String, bDProjectImageGalleryEntity.Extension);
                db.AddInParameter(cmd, "@Remarks", DbType.String, bDProjectImageGalleryEntity.Remarks);
                db.AddInParameter(cmd, "@Path", DbType.String, bDProjectImageGalleryEntity.Path);
                db.AddInParameter(cmd, "@OriginalFileName", DbType.String, bDProjectImageGalleryEntity.OriginalFileName);
                db.AddInParameter(cmd, "@CurrentFileName", DbType.String, bDProjectImageGalleryEntity.CurrentFileName);
                db.AddInParameter(cmd, "@FileType", DbType.String, bDProjectImageGalleryEntity.FileType);

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

        IList<Int64> IBDProjectImageGalleryDataAccess.Update(IList<BDProjectImageGalleryEntity> bDProjectImageGalleryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (BDProjectImageGalleryEntity bDProjectImageGalleryEntity in bDProjectImageGalleryEntityList)
            {
                returnCode = (this as IBDProjectImageGalleryDataAccess).Update(bDProjectImageGalleryEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IBDProjectImageGalleryDataAccess.Delete(BDProjectImageGalleryEntity bDProjectImageGalleryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(bDProjectImageGalleryEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(bDProjectImageGalleryEntity, filterExpression, option);
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

        private Int64 Delete(BDProjectImageGalleryEntity bDProjectImageGalleryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectImageGallery_SET";

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
                                throw new ArgumentException("BDProjectImageGalleryEntity already exists. Please specify another BDProjectImageGalleryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectImageGalleryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectImageGalleryEntity already exists. Please specify another BDProjectImageGalleryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(BDProjectImageGalleryEntity bDProjectImageGalleryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectImageGallery_SET";

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

        IList<Int64> IBDProjectImageGalleryDataAccess.Delete(IList<BDProjectImageGalleryEntity> bDProjectImageGalleryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (BDProjectImageGalleryEntity bDProjectImageGalleryEntity in bDProjectImageGalleryEntityList)
            {
                returnCode = (this as IBDProjectImageGalleryDataAccess).Delete(bDProjectImageGalleryEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<BDProjectImageGalleryEntity> IBDProjectImageGalleryDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDProjectImageGallery_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<BDProjectImageGalleryEntity> list = CreateEntityBuilder<BDProjectImageGalleryEntity>().BuildEntities(reader);

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

        DataTable IBDProjectImageGalleryDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDProjectImageGallery_GET";

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
