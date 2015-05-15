// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 01:41:28




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
    internal sealed partial class BDProjectDocumentTemplateMapDataAccess : BaseDataAccess, IBDProjectDocumentTemplateMapDataAccess
    {
        #region Constructors

        public BDProjectDocumentTemplateMapDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<BDProjectDocumentTemplateMapEntity> CreateEntityBuilder<BDProjectDocumentTemplateMapEntity>()
        {
            return (new BDProjectDocumentTemplateMapBuilder()) as IEntityBuilder<BDProjectDocumentTemplateMapEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IBDProjectDocumentTemplateMapDataAccess.Add(BDProjectDocumentTemplateMapEntity bDProjectDocumentTemplateMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(bDProjectDocumentTemplateMapEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(bDProjectDocumentTemplateMapEntity, option);
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

        private Int64 Add(BDProjectDocumentTemplateMapEntity bDProjectDocumentTemplateMapEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectDocumentTemplateMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ProjectDocumentTemplateMapID");

                Database.AddInParameter(cmd, "@ProjectDocumentTemplateID", DbType.Int64, bDProjectDocumentTemplateMapEntity.ProjectDocumentTemplateID);	
                Database.AddInParameter(cmd, "@ProjectDocumentID", DbType.Int64, bDProjectDocumentTemplateMapEntity.ProjectDocumentID);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDProjectDocumentTemplateMapEntity already exists. Please specify another BDProjectDocumentTemplateMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectDocumentTemplateMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectDocumentTemplateMapEntity already exists. Please specify another BDProjectDocumentTemplateMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(BDProjectDocumentTemplateMapEntity bDProjectDocumentTemplateMapEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectDocumentTemplateMap_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ProjectDocumentTemplateMapID", db);

                db.AddInParameter(cmd, "@ProjectDocumentTemplateID", DbType.Int64, bDProjectDocumentTemplateMapEntity.ProjectDocumentTemplateID);
                db.AddInParameter(cmd, "@ProjectDocumentID", DbType.Int64, bDProjectDocumentTemplateMapEntity.ProjectDocumentID);

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

        IList<Int64> IBDProjectDocumentTemplateMapDataAccess.Add(IList<BDProjectDocumentTemplateMapEntity> bDProjectDocumentTemplateMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (BDProjectDocumentTemplateMapEntity bDProjectDocumentTemplateMapEntity in bDProjectDocumentTemplateMapEntityList)
            {
                returnCode = (this as IBDProjectDocumentTemplateMapDataAccess).Add(bDProjectDocumentTemplateMapEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IBDProjectDocumentTemplateMapDataAccess.Update(BDProjectDocumentTemplateMapEntity bDProjectDocumentTemplateMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(bDProjectDocumentTemplateMapEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(bDProjectDocumentTemplateMapEntity, filterExpression, option);
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

        private Int64 Update(BDProjectDocumentTemplateMapEntity bDProjectDocumentTemplateMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectDocumentTemplateMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ProjectDocumentTemplateMapID", DbType.Int64, bDProjectDocumentTemplateMapEntity.ProjectDocumentTemplateMapID);
                Database.AddInParameter(cmd, "@ProjectDocumentTemplateID", DbType.Int64, bDProjectDocumentTemplateMapEntity.ProjectDocumentTemplateID);
                Database.AddInParameter(cmd, "@ProjectDocumentID", DbType.Int64, bDProjectDocumentTemplateMapEntity.ProjectDocumentID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDProjectDocumentTemplateMapEntity already exists. Please specify another BDProjectDocumentTemplateMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectDocumentTemplateMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectDocumentTemplateMapEntity already exists. Please specify another BDProjectDocumentTemplateMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(BDProjectDocumentTemplateMapEntity bDProjectDocumentTemplateMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectDocumentTemplateMap_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ProjectDocumentTemplateMapID", DbType.Int64, bDProjectDocumentTemplateMapEntity.ProjectDocumentTemplateMapID);
                db.AddInParameter(cmd, "@ProjectDocumentTemplateID", DbType.Int64, bDProjectDocumentTemplateMapEntity.ProjectDocumentTemplateID);
                db.AddInParameter(cmd, "@ProjectDocumentID", DbType.Int64, bDProjectDocumentTemplateMapEntity.ProjectDocumentID);

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

        IList<Int64> IBDProjectDocumentTemplateMapDataAccess.Update(IList<BDProjectDocumentTemplateMapEntity> bDProjectDocumentTemplateMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (BDProjectDocumentTemplateMapEntity bDProjectDocumentTemplateMapEntity in bDProjectDocumentTemplateMapEntityList)
            {
                returnCode = (this as IBDProjectDocumentTemplateMapDataAccess).Update(bDProjectDocumentTemplateMapEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IBDProjectDocumentTemplateMapDataAccess.Delete(BDProjectDocumentTemplateMapEntity bDProjectDocumentTemplateMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(bDProjectDocumentTemplateMapEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(bDProjectDocumentTemplateMapEntity, filterExpression, option);
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

        private Int64 Delete(BDProjectDocumentTemplateMapEntity bDProjectDocumentTemplateMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectDocumentTemplateMap_SET";

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
                                throw new ArgumentException("BDProjectDocumentTemplateMapEntity already exists. Please specify another BDProjectDocumentTemplateMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectDocumentTemplateMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectDocumentTemplateMapEntity already exists. Please specify another BDProjectDocumentTemplateMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(BDProjectDocumentTemplateMapEntity bDProjectDocumentTemplateMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectDocumentTemplateMap_SET";

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

        IList<Int64> IBDProjectDocumentTemplateMapDataAccess.Delete(IList<BDProjectDocumentTemplateMapEntity> bDProjectDocumentTemplateMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (BDProjectDocumentTemplateMapEntity bDProjectDocumentTemplateMapEntity in bDProjectDocumentTemplateMapEntityList)
            {
                returnCode = (this as IBDProjectDocumentTemplateMapDataAccess).Delete(bDProjectDocumentTemplateMapEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<BDProjectDocumentTemplateMapEntity> IBDProjectDocumentTemplateMapDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDProjectDocumentTemplateMap_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<BDProjectDocumentTemplateMapEntity> list = CreateEntityBuilder<BDProjectDocumentTemplateMapEntity>().BuildEntities(reader);

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

        DataTable IBDProjectDocumentTemplateMapDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDProjectDocumentTemplateMap_GET";

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
