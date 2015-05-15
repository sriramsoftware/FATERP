// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 14-Jul-2013, 12:43:35




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
    internal sealed partial class BDProcessAssignedResourceMapDataAccess : BaseDataAccess, IBDProcessAssignedResourceMapDataAccess
    {
        #region Constructors

        public BDProcessAssignedResourceMapDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<BDProcessAssignedResourceMapEntity> CreateEntityBuilder<BDProcessAssignedResourceMapEntity>()
        {
            return (new BDProcessAssignedResourceMapBuilder()) as IEntityBuilder<BDProcessAssignedResourceMapEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IBDProcessAssignedResourceMapDataAccess.Add(BDProcessAssignedResourceMapEntity bDProcessAssignedResourceMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(bDProcessAssignedResourceMapEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(bDProcessAssignedResourceMapEntity, option);
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

        private Int64 Add(BDProcessAssignedResourceMapEntity bDProcessAssignedResourceMapEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProcessAssignedResourceMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ProcessAssignedResourceMapID");

                Database.AddInParameter(cmd, "@ProcessAssignedResourceID", DbType.Int64, bDProcessAssignedResourceMapEntity.ProcessAssignedResourceID);	
                Database.AddInParameter(cmd, "@ResourceCategoryID", DbType.Int64, bDProcessAssignedResourceMapEntity.ResourceCategoryID);	
                Database.AddInParameter(cmd, "@ReferenceID", DbType.Int64, bDProcessAssignedResourceMapEntity.ReferenceID);	
                Database.AddInParameter(cmd, "@ResourceName", DbType.String, bDProcessAssignedResourceMapEntity.ResourceName);	
                Database.AddInParameter(cmd, "@ResourceDesignation", DbType.String, bDProcessAssignedResourceMapEntity.ResourceDesignation);	
                Database.AddInParameter(cmd, "@ResourceCompany", DbType.String, bDProcessAssignedResourceMapEntity.ResourceCompany);	
                Database.AddInParameter(cmd, "@ResourceMobileNo", DbType.String, bDProcessAssignedResourceMapEntity.ResourceMobileNo);	
                Database.AddInParameter(cmd, "@ResourceEmail", DbType.String, bDProcessAssignedResourceMapEntity.ResourceEmail);	
                Database.AddInParameter(cmd, "@AddressLine1", DbType.String, bDProcessAssignedResourceMapEntity.AddressLine1);	
                Database.AddInParameter(cmd, "@AddressLine2", DbType.String, bDProcessAssignedResourceMapEntity.AddressLine2);	
                Database.AddInParameter(cmd, "@ResourceTypeID", DbType.Int64, bDProcessAssignedResourceMapEntity.ResourceTypeID);	
                Database.AddInParameter(cmd, "@ResourceDOB", DbType.DateTime, bDProcessAssignedResourceMapEntity.ResourceDOB);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, bDProcessAssignedResourceMapEntity.Remarks);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDProcessAssignedResourceMapEntity already exists. Please specify another BDProcessAssignedResourceMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProcessAssignedResourceMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProcessAssignedResourceMapEntity already exists. Please specify another BDProcessAssignedResourceMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(BDProcessAssignedResourceMapEntity bDProcessAssignedResourceMapEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProcessAssignedResourceMap_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ProcessAssignedResourceMapID", db);

                db.AddInParameter(cmd, "@ProcessAssignedResourceID", DbType.Int64, bDProcessAssignedResourceMapEntity.ProcessAssignedResourceID);
                db.AddInParameter(cmd, "@ResourceCategoryID", DbType.Int64, bDProcessAssignedResourceMapEntity.ResourceCategoryID);
                db.AddInParameter(cmd, "@ReferenceID", DbType.Int64, bDProcessAssignedResourceMapEntity.ReferenceID);
                db.AddInParameter(cmd, "@ResourceName", DbType.String, bDProcessAssignedResourceMapEntity.ResourceName);
                db.AddInParameter(cmd, "@ResourceDesignation", DbType.String, bDProcessAssignedResourceMapEntity.ResourceDesignation);
                db.AddInParameter(cmd, "@ResourceCompany", DbType.String, bDProcessAssignedResourceMapEntity.ResourceCompany);
                db.AddInParameter(cmd, "@ResourceMobileNo", DbType.String, bDProcessAssignedResourceMapEntity.ResourceMobileNo);
                db.AddInParameter(cmd, "@ResourceEmail", DbType.String, bDProcessAssignedResourceMapEntity.ResourceEmail);
                db.AddInParameter(cmd, "@AddressLine1", DbType.String, bDProcessAssignedResourceMapEntity.AddressLine1);
                db.AddInParameter(cmd, "@AddressLine2", DbType.String, bDProcessAssignedResourceMapEntity.AddressLine2);
                db.AddInParameter(cmd, "@ResourceTypeID", DbType.Int64, bDProcessAssignedResourceMapEntity.ResourceTypeID);
                db.AddInParameter(cmd, "@ResourceDOB", DbType.DateTime, bDProcessAssignedResourceMapEntity.ResourceDOB);
                db.AddInParameter(cmd, "@Remarks", DbType.String, bDProcessAssignedResourceMapEntity.Remarks);

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

        IList<Int64> IBDProcessAssignedResourceMapDataAccess.Add(IList<BDProcessAssignedResourceMapEntity> bDProcessAssignedResourceMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (BDProcessAssignedResourceMapEntity bDProcessAssignedResourceMapEntity in bDProcessAssignedResourceMapEntityList)
            {
                returnCode = (this as IBDProcessAssignedResourceMapDataAccess).Add(bDProcessAssignedResourceMapEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IBDProcessAssignedResourceMapDataAccess.Update(BDProcessAssignedResourceMapEntity bDProcessAssignedResourceMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(bDProcessAssignedResourceMapEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(bDProcessAssignedResourceMapEntity, filterExpression, option);
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

        private Int64 Update(BDProcessAssignedResourceMapEntity bDProcessAssignedResourceMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProcessAssignedResourceMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ProcessAssignedResourceMapID", DbType.Int64, bDProcessAssignedResourceMapEntity.ProcessAssignedResourceMapID);
                Database.AddInParameter(cmd, "@ProcessAssignedResourceID", DbType.Int64, bDProcessAssignedResourceMapEntity.ProcessAssignedResourceID);
                Database.AddInParameter(cmd, "@ResourceCategoryID", DbType.Int64, bDProcessAssignedResourceMapEntity.ResourceCategoryID);
                Database.AddInParameter(cmd, "@ReferenceID", DbType.Int64, bDProcessAssignedResourceMapEntity.ReferenceID);
                Database.AddInParameter(cmd, "@ResourceName", DbType.String, bDProcessAssignedResourceMapEntity.ResourceName);
                Database.AddInParameter(cmd, "@ResourceDesignation", DbType.String, bDProcessAssignedResourceMapEntity.ResourceDesignation);
                Database.AddInParameter(cmd, "@ResourceCompany", DbType.String, bDProcessAssignedResourceMapEntity.ResourceCompany);
                Database.AddInParameter(cmd, "@ResourceMobileNo", DbType.String, bDProcessAssignedResourceMapEntity.ResourceMobileNo);
                Database.AddInParameter(cmd, "@ResourceEmail", DbType.String, bDProcessAssignedResourceMapEntity.ResourceEmail);
                Database.AddInParameter(cmd, "@AddressLine1", DbType.String, bDProcessAssignedResourceMapEntity.AddressLine1);
                Database.AddInParameter(cmd, "@AddressLine2", DbType.String, bDProcessAssignedResourceMapEntity.AddressLine2);
                Database.AddInParameter(cmd, "@ResourceTypeID", DbType.Int64, bDProcessAssignedResourceMapEntity.ResourceTypeID);
                Database.AddInParameter(cmd, "@ResourceDOB", DbType.DateTime, bDProcessAssignedResourceMapEntity.ResourceDOB);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, bDProcessAssignedResourceMapEntity.Remarks);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDProcessAssignedResourceMapEntity already exists. Please specify another BDProcessAssignedResourceMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProcessAssignedResourceMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProcessAssignedResourceMapEntity already exists. Please specify another BDProcessAssignedResourceMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(BDProcessAssignedResourceMapEntity bDProcessAssignedResourceMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProcessAssignedResourceMap_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ProcessAssignedResourceMapID", DbType.Int64, bDProcessAssignedResourceMapEntity.ProcessAssignedResourceMapID);
                db.AddInParameter(cmd, "@ProcessAssignedResourceID", DbType.Int64, bDProcessAssignedResourceMapEntity.ProcessAssignedResourceID);
                db.AddInParameter(cmd, "@ResourceCategoryID", DbType.Int64, bDProcessAssignedResourceMapEntity.ResourceCategoryID);
                db.AddInParameter(cmd, "@ReferenceID", DbType.Int64, bDProcessAssignedResourceMapEntity.ReferenceID);
                db.AddInParameter(cmd, "@ResourceName", DbType.String, bDProcessAssignedResourceMapEntity.ResourceName);
                db.AddInParameter(cmd, "@ResourceDesignation", DbType.String, bDProcessAssignedResourceMapEntity.ResourceDesignation);
                db.AddInParameter(cmd, "@ResourceCompany", DbType.String, bDProcessAssignedResourceMapEntity.ResourceCompany);
                db.AddInParameter(cmd, "@ResourceMobileNo", DbType.String, bDProcessAssignedResourceMapEntity.ResourceMobileNo);
                db.AddInParameter(cmd, "@ResourceEmail", DbType.String, bDProcessAssignedResourceMapEntity.ResourceEmail);
                db.AddInParameter(cmd, "@AddressLine1", DbType.String, bDProcessAssignedResourceMapEntity.AddressLine1);
                db.AddInParameter(cmd, "@AddressLine2", DbType.String, bDProcessAssignedResourceMapEntity.AddressLine2);
                db.AddInParameter(cmd, "@ResourceTypeID", DbType.Int64, bDProcessAssignedResourceMapEntity.ResourceTypeID);
                db.AddInParameter(cmd, "@ResourceDOB", DbType.DateTime, bDProcessAssignedResourceMapEntity.ResourceDOB);
                db.AddInParameter(cmd, "@Remarks", DbType.String, bDProcessAssignedResourceMapEntity.Remarks);

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

        IList<Int64> IBDProcessAssignedResourceMapDataAccess.Update(IList<BDProcessAssignedResourceMapEntity> bDProcessAssignedResourceMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (BDProcessAssignedResourceMapEntity bDProcessAssignedResourceMapEntity in bDProcessAssignedResourceMapEntityList)
            {
                returnCode = (this as IBDProcessAssignedResourceMapDataAccess).Update(bDProcessAssignedResourceMapEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IBDProcessAssignedResourceMapDataAccess.Delete(BDProcessAssignedResourceMapEntity bDProcessAssignedResourceMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(bDProcessAssignedResourceMapEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(bDProcessAssignedResourceMapEntity, filterExpression, option);
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

        private Int64 Delete(BDProcessAssignedResourceMapEntity bDProcessAssignedResourceMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProcessAssignedResourceMap_SET";

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
                                throw new ArgumentException("BDProcessAssignedResourceMapEntity already exists. Please specify another BDProcessAssignedResourceMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProcessAssignedResourceMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProcessAssignedResourceMapEntity already exists. Please specify another BDProcessAssignedResourceMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(BDProcessAssignedResourceMapEntity bDProcessAssignedResourceMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProcessAssignedResourceMap_SET";

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

        IList<Int64> IBDProcessAssignedResourceMapDataAccess.Delete(IList<BDProcessAssignedResourceMapEntity> bDProcessAssignedResourceMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (BDProcessAssignedResourceMapEntity bDProcessAssignedResourceMapEntity in bDProcessAssignedResourceMapEntityList)
            {
                returnCode = (this as IBDProcessAssignedResourceMapDataAccess).Delete(bDProcessAssignedResourceMapEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<BDProcessAssignedResourceMapEntity> IBDProcessAssignedResourceMapDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDProcessAssignedResourceMap_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<BDProcessAssignedResourceMapEntity> list = CreateEntityBuilder<BDProcessAssignedResourceMapEntity>().BuildEntities(reader);

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

        DataTable IBDProcessAssignedResourceMapDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDProcessAssignedResourceMap_GET";

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
