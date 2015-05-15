// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Jan-2012, 06:06:50




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
    internal sealed partial class CMConstructionToolDetailDataAccess : BaseDataAccess, ICMConstructionToolDetailDataAccess
    {
        #region Constructors

        public CMConstructionToolDetailDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CMConstructionToolDetailEntity> CreateEntityBuilder<CMConstructionToolDetailEntity>()
        {
            return (new CMConstructionToolDetailBuilder()) as IEntityBuilder<CMConstructionToolDetailEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICMConstructionToolDetailDataAccess.Add(CMConstructionToolDetailEntity cMConstructionToolDetailEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cMConstructionToolDetailEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cMConstructionToolDetailEntity, option);
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

        private Int64 Add(CMConstructionToolDetailEntity cMConstructionToolDetailEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMConstructionToolDetail_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ConstructionToolDetailID");

                Database.AddInParameter(cmd, "@ConstructionToolID", DbType.Int64, cMConstructionToolDetailEntity.ConstructionToolID);	
                Database.AddInParameter(cmd, "@Specification", DbType.String, cMConstructionToolDetailEntity.Specification);	
                Database.AddInParameter(cmd, "@ConstructionToolWorkingConditionID", DbType.Int64, cMConstructionToolDetailEntity.ConstructionToolWorkingConditionID);	
                Database.AddInParameter(cmd, "@BrandID", DbType.Int64, cMConstructionToolDetailEntity.BrandID);	
                Database.AddInParameter(cmd, "@SupplierID", DbType.Int64, cMConstructionToolDetailEntity.SupplierID);	
                Database.AddInParameter(cmd, "@NextMaintananceDate", DbType.DateTime, cMConstructionToolDetailEntity.NextMaintananceDate);	
                Database.AddInParameter(cmd, "@UsedOrHandeledBy", DbType.String, cMConstructionToolDetailEntity.UsedOrHandeledBy);	
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, cMConstructionToolDetailEntity.ProjectID);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cMConstructionToolDetailEntity.Remarks);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, cMConstructionToolDetailEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMConstructionToolDetailEntity already exists. Please specify another CMConstructionToolDetailEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMConstructionToolDetailEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMConstructionToolDetailEntity already exists. Please specify another CMConstructionToolDetailEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CMConstructionToolDetailEntity cMConstructionToolDetailEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMConstructionToolDetail_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ConstructionToolDetailID", db);

                db.AddInParameter(cmd, "@ConstructionToolID", DbType.Int64, cMConstructionToolDetailEntity.ConstructionToolID);
                db.AddInParameter(cmd, "@Specification", DbType.String, cMConstructionToolDetailEntity.Specification);
                db.AddInParameter(cmd, "@ConstructionToolWorkingConditionID", DbType.Int64, cMConstructionToolDetailEntity.ConstructionToolWorkingConditionID);
                db.AddInParameter(cmd, "@BrandID", DbType.Int64, cMConstructionToolDetailEntity.BrandID);
                db.AddInParameter(cmd, "@SupplierID", DbType.Int64, cMConstructionToolDetailEntity.SupplierID);
                db.AddInParameter(cmd, "@NextMaintananceDate", DbType.DateTime, cMConstructionToolDetailEntity.NextMaintananceDate);
                db.AddInParameter(cmd, "@UsedOrHandeledBy", DbType.String, cMConstructionToolDetailEntity.UsedOrHandeledBy);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, cMConstructionToolDetailEntity.ProjectID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cMConstructionToolDetailEntity.Remarks);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, cMConstructionToolDetailEntity.IsRemoved);

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

        IList<Int64> ICMConstructionToolDetailDataAccess.Add(IList<CMConstructionToolDetailEntity> cMConstructionToolDetailEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CMConstructionToolDetailEntity cMConstructionToolDetailEntity in cMConstructionToolDetailEntityList)
            {
                returnCode = (this as ICMConstructionToolDetailDataAccess).Add(cMConstructionToolDetailEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICMConstructionToolDetailDataAccess.Update(CMConstructionToolDetailEntity cMConstructionToolDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cMConstructionToolDetailEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cMConstructionToolDetailEntity, filterExpression, option);
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

        private Int64 Update(CMConstructionToolDetailEntity cMConstructionToolDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMConstructionToolDetail_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ConstructionToolDetailID", DbType.Int64, cMConstructionToolDetailEntity.ConstructionToolDetailID);
                Database.AddInParameter(cmd, "@ConstructionToolID", DbType.Int64, cMConstructionToolDetailEntity.ConstructionToolID);
                Database.AddInParameter(cmd, "@Specification", DbType.String, cMConstructionToolDetailEntity.Specification);
                Database.AddInParameter(cmd, "@ConstructionToolWorkingConditionID", DbType.Int64, cMConstructionToolDetailEntity.ConstructionToolWorkingConditionID);
                Database.AddInParameter(cmd, "@BrandID", DbType.Int64, cMConstructionToolDetailEntity.BrandID);
                Database.AddInParameter(cmd, "@SupplierID", DbType.Int64, cMConstructionToolDetailEntity.SupplierID);
                Database.AddInParameter(cmd, "@NextMaintananceDate", DbType.DateTime, cMConstructionToolDetailEntity.NextMaintananceDate);
                Database.AddInParameter(cmd, "@UsedOrHandeledBy", DbType.String, cMConstructionToolDetailEntity.UsedOrHandeledBy);
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, cMConstructionToolDetailEntity.ProjectID);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cMConstructionToolDetailEntity.Remarks);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, cMConstructionToolDetailEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMConstructionToolDetailEntity already exists. Please specify another CMConstructionToolDetailEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMConstructionToolDetailEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMConstructionToolDetailEntity already exists. Please specify another CMConstructionToolDetailEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CMConstructionToolDetailEntity cMConstructionToolDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMConstructionToolDetail_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ConstructionToolDetailID", DbType.Int64, cMConstructionToolDetailEntity.ConstructionToolDetailID);
                db.AddInParameter(cmd, "@ConstructionToolID", DbType.Int64, cMConstructionToolDetailEntity.ConstructionToolID);
                db.AddInParameter(cmd, "@Specification", DbType.String, cMConstructionToolDetailEntity.Specification);
                db.AddInParameter(cmd, "@ConstructionToolWorkingConditionID", DbType.Int64, cMConstructionToolDetailEntity.ConstructionToolWorkingConditionID);
                db.AddInParameter(cmd, "@BrandID", DbType.Int64, cMConstructionToolDetailEntity.BrandID);
                db.AddInParameter(cmd, "@SupplierID", DbType.Int64, cMConstructionToolDetailEntity.SupplierID);
                db.AddInParameter(cmd, "@NextMaintananceDate", DbType.DateTime, cMConstructionToolDetailEntity.NextMaintananceDate);
                db.AddInParameter(cmd, "@UsedOrHandeledBy", DbType.String, cMConstructionToolDetailEntity.UsedOrHandeledBy);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, cMConstructionToolDetailEntity.ProjectID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cMConstructionToolDetailEntity.Remarks);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, cMConstructionToolDetailEntity.IsRemoved);

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

        IList<Int64> ICMConstructionToolDetailDataAccess.Update(IList<CMConstructionToolDetailEntity> cMConstructionToolDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CMConstructionToolDetailEntity cMConstructionToolDetailEntity in cMConstructionToolDetailEntityList)
            {
                returnCode = (this as ICMConstructionToolDetailDataAccess).Update(cMConstructionToolDetailEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICMConstructionToolDetailDataAccess.Delete(CMConstructionToolDetailEntity cMConstructionToolDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cMConstructionToolDetailEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cMConstructionToolDetailEntity, filterExpression, option);
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

        private Int64 Delete(CMConstructionToolDetailEntity cMConstructionToolDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMConstructionToolDetail_SET";

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
                                throw new ArgumentException("CMConstructionToolDetailEntity already exists. Please specify another CMConstructionToolDetailEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMConstructionToolDetailEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMConstructionToolDetailEntity already exists. Please specify another CMConstructionToolDetailEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CMConstructionToolDetailEntity cMConstructionToolDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMConstructionToolDetail_SET";

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

        IList<Int64> ICMConstructionToolDetailDataAccess.Delete(IList<CMConstructionToolDetailEntity> cMConstructionToolDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CMConstructionToolDetailEntity cMConstructionToolDetailEntity in cMConstructionToolDetailEntityList)
            {
                returnCode = (this as ICMConstructionToolDetailDataAccess).Delete(cMConstructionToolDetailEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CMConstructionToolDetailEntity> ICMConstructionToolDetailDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMConstructionToolDetail_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CMConstructionToolDetailEntity> list = CreateEntityBuilder<CMConstructionToolDetailEntity>().BuildEntities(reader);

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

        DataTable ICMConstructionToolDetailDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMConstructionToolDetail_GET";

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
