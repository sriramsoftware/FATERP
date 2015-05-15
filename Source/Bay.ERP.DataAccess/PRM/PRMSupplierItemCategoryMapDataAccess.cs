// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-May-2012, 11:02:33




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
    internal sealed partial class PRMSupplierItemCategoryMapDataAccess : BaseDataAccess, IPRMSupplierItemCategoryMapDataAccess
    {
        #region Constructors

        public PRMSupplierItemCategoryMapDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<PRMSupplierItemCategoryMapEntity> CreateEntityBuilder<PRMSupplierItemCategoryMapEntity>()
        {
            return (new PRMSupplierItemCategoryMapBuilder()) as IEntityBuilder<PRMSupplierItemCategoryMapEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IPRMSupplierItemCategoryMapDataAccess.Add(PRMSupplierItemCategoryMapEntity pRMSupplierItemCategoryMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(pRMSupplierItemCategoryMapEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(pRMSupplierItemCategoryMapEntity, option);
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

        private Int64 Add(PRMSupplierItemCategoryMapEntity pRMSupplierItemCategoryMapEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMSupplierItemCategoryMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "SupplierItemCategoryMapID");

                Database.AddInParameter(cmd, "@SupplierItemCategoryID", DbType.Int64, pRMSupplierItemCategoryMapEntity.SupplierItemCategoryID);	
                Database.AddInParameter(cmd, "@SupplierID", DbType.Int64, pRMSupplierItemCategoryMapEntity.SupplierID);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMSupplierItemCategoryMapEntity already exists. Please specify another PRMSupplierItemCategoryMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMSupplierItemCategoryMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMSupplierItemCategoryMapEntity already exists. Please specify another PRMSupplierItemCategoryMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(PRMSupplierItemCategoryMapEntity pRMSupplierItemCategoryMapEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMSupplierItemCategoryMap_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "SupplierItemCategoryMapID", db);

                db.AddInParameter(cmd, "@SupplierItemCategoryID", DbType.Int64, pRMSupplierItemCategoryMapEntity.SupplierItemCategoryID);
                db.AddInParameter(cmd, "@SupplierID", DbType.Int64, pRMSupplierItemCategoryMapEntity.SupplierID);

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

        IList<Int64> IPRMSupplierItemCategoryMapDataAccess.Add(IList<PRMSupplierItemCategoryMapEntity> pRMSupplierItemCategoryMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (PRMSupplierItemCategoryMapEntity pRMSupplierItemCategoryMapEntity in pRMSupplierItemCategoryMapEntityList)
            {
                returnCode = (this as IPRMSupplierItemCategoryMapDataAccess).Add(pRMSupplierItemCategoryMapEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IPRMSupplierItemCategoryMapDataAccess.Update(PRMSupplierItemCategoryMapEntity pRMSupplierItemCategoryMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(pRMSupplierItemCategoryMapEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(pRMSupplierItemCategoryMapEntity, filterExpression, option);
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

        private Int64 Update(PRMSupplierItemCategoryMapEntity pRMSupplierItemCategoryMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMSupplierItemCategoryMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@SupplierItemCategoryMapID", DbType.Int64, pRMSupplierItemCategoryMapEntity.SupplierItemCategoryMapID);
                Database.AddInParameter(cmd, "@SupplierItemCategoryID", DbType.Int64, pRMSupplierItemCategoryMapEntity.SupplierItemCategoryID);
                Database.AddInParameter(cmd, "@SupplierID", DbType.Int64, pRMSupplierItemCategoryMapEntity.SupplierID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMSupplierItemCategoryMapEntity already exists. Please specify another PRMSupplierItemCategoryMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMSupplierItemCategoryMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMSupplierItemCategoryMapEntity already exists. Please specify another PRMSupplierItemCategoryMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(PRMSupplierItemCategoryMapEntity pRMSupplierItemCategoryMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMSupplierItemCategoryMap_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@SupplierItemCategoryMapID", DbType.Int64, pRMSupplierItemCategoryMapEntity.SupplierItemCategoryMapID);
                db.AddInParameter(cmd, "@SupplierItemCategoryID", DbType.Int64, pRMSupplierItemCategoryMapEntity.SupplierItemCategoryID);
                db.AddInParameter(cmd, "@SupplierID", DbType.Int64, pRMSupplierItemCategoryMapEntity.SupplierID);

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

        IList<Int64> IPRMSupplierItemCategoryMapDataAccess.Update(IList<PRMSupplierItemCategoryMapEntity> pRMSupplierItemCategoryMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (PRMSupplierItemCategoryMapEntity pRMSupplierItemCategoryMapEntity in pRMSupplierItemCategoryMapEntityList)
            {
                returnCode = (this as IPRMSupplierItemCategoryMapDataAccess).Update(pRMSupplierItemCategoryMapEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IPRMSupplierItemCategoryMapDataAccess.Delete(PRMSupplierItemCategoryMapEntity pRMSupplierItemCategoryMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(pRMSupplierItemCategoryMapEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(pRMSupplierItemCategoryMapEntity, filterExpression, option);
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

        private Int64 Delete(PRMSupplierItemCategoryMapEntity pRMSupplierItemCategoryMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMSupplierItemCategoryMap_SET";

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
                                throw new ArgumentException("PRMSupplierItemCategoryMapEntity already exists. Please specify another PRMSupplierItemCategoryMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMSupplierItemCategoryMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMSupplierItemCategoryMapEntity already exists. Please specify another PRMSupplierItemCategoryMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(PRMSupplierItemCategoryMapEntity pRMSupplierItemCategoryMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMSupplierItemCategoryMap_SET";

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

        IList<Int64> IPRMSupplierItemCategoryMapDataAccess.Delete(IList<PRMSupplierItemCategoryMapEntity> pRMSupplierItemCategoryMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (PRMSupplierItemCategoryMapEntity pRMSupplierItemCategoryMapEntity in pRMSupplierItemCategoryMapEntityList)
            {
                returnCode = (this as IPRMSupplierItemCategoryMapDataAccess).Delete(pRMSupplierItemCategoryMapEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<PRMSupplierItemCategoryMapEntity> IPRMSupplierItemCategoryMapDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMSupplierItemCategoryMap_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<PRMSupplierItemCategoryMapEntity> list = CreateEntityBuilder<PRMSupplierItemCategoryMapEntity>().BuildEntities(reader);

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

        DataTable IPRMSupplierItemCategoryMapDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMSupplierItemCategoryMap_GET";

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
