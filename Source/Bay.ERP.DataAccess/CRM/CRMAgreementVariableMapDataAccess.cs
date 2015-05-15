// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Apr-2013, 05:21:43




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
    internal sealed partial class CRMAgreementVariableMapDataAccess : BaseDataAccess, ICRMAgreementVariableMapDataAccess
    {
        #region Constructors

        public CRMAgreementVariableMapDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CRMAgreementVariableMapEntity> CreateEntityBuilder<CRMAgreementVariableMapEntity>()
        {
            return (new CRMAgreementVariableMapBuilder()) as IEntityBuilder<CRMAgreementVariableMapEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICRMAgreementVariableMapDataAccess.Add(CRMAgreementVariableMapEntity cRMAgreementVariableMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cRMAgreementVariableMapEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cRMAgreementVariableMapEntity, option);
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

        private Int64 Add(CRMAgreementVariableMapEntity cRMAgreementVariableMapEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMAgreementVariableMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "AgreementVariableMapID");

                Database.AddInParameter(cmd, "@AgreementID", DbType.Int64, cRMAgreementVariableMapEntity.AgreementID);	
                Database.AddInParameter(cmd, "@Name", DbType.String, cRMAgreementVariableMapEntity.Name);	
                Database.AddInParameter(cmd, "@Value", DbType.String, cRMAgreementVariableMapEntity.Value);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cRMAgreementVariableMapEntity.Remarks);	
                Database.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, cRMAgreementVariableMapEntity.CreatedByEmployeeID);	
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMAgreementVariableMapEntity.CreateDate);	
                Database.AddInParameter(cmd, "@IP", DbType.String, cRMAgreementVariableMapEntity.IP);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CRMAgreementVariableMapEntity already exists. Please specify another CRMAgreementVariableMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMAgreementVariableMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMAgreementVariableMapEntity already exists. Please specify another CRMAgreementVariableMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CRMAgreementVariableMapEntity cRMAgreementVariableMapEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMAgreementVariableMap_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "AgreementVariableMapID", db);

                db.AddInParameter(cmd, "@AgreementID", DbType.Int64, cRMAgreementVariableMapEntity.AgreementID);
                db.AddInParameter(cmd, "@Name", DbType.String, cRMAgreementVariableMapEntity.Name);
                db.AddInParameter(cmd, "@Value", DbType.String, cRMAgreementVariableMapEntity.Value);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cRMAgreementVariableMapEntity.Remarks);
                db.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, cRMAgreementVariableMapEntity.CreatedByEmployeeID);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMAgreementVariableMapEntity.CreateDate);
                db.AddInParameter(cmd, "@IP", DbType.String, cRMAgreementVariableMapEntity.IP);

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

        IList<Int64> ICRMAgreementVariableMapDataAccess.Add(IList<CRMAgreementVariableMapEntity> cRMAgreementVariableMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CRMAgreementVariableMapEntity cRMAgreementVariableMapEntity in cRMAgreementVariableMapEntityList)
            {
                returnCode = (this as ICRMAgreementVariableMapDataAccess).Add(cRMAgreementVariableMapEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICRMAgreementVariableMapDataAccess.Update(CRMAgreementVariableMapEntity cRMAgreementVariableMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cRMAgreementVariableMapEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cRMAgreementVariableMapEntity, filterExpression, option);
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

        private Int64 Update(CRMAgreementVariableMapEntity cRMAgreementVariableMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMAgreementVariableMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@AgreementVariableMapID", DbType.Int64, cRMAgreementVariableMapEntity.AgreementVariableMapID);
                Database.AddInParameter(cmd, "@AgreementID", DbType.Int64, cRMAgreementVariableMapEntity.AgreementID);
                Database.AddInParameter(cmd, "@Name", DbType.String, cRMAgreementVariableMapEntity.Name);
                Database.AddInParameter(cmd, "@Value", DbType.String, cRMAgreementVariableMapEntity.Value);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cRMAgreementVariableMapEntity.Remarks);
                Database.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, cRMAgreementVariableMapEntity.CreatedByEmployeeID);
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMAgreementVariableMapEntity.CreateDate);
                Database.AddInParameter(cmd, "@IP", DbType.String, cRMAgreementVariableMapEntity.IP);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CRMAgreementVariableMapEntity already exists. Please specify another CRMAgreementVariableMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMAgreementVariableMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMAgreementVariableMapEntity already exists. Please specify another CRMAgreementVariableMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CRMAgreementVariableMapEntity cRMAgreementVariableMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMAgreementVariableMap_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@AgreementVariableMapID", DbType.Int64, cRMAgreementVariableMapEntity.AgreementVariableMapID);
                db.AddInParameter(cmd, "@AgreementID", DbType.Int64, cRMAgreementVariableMapEntity.AgreementID);
                db.AddInParameter(cmd, "@Name", DbType.String, cRMAgreementVariableMapEntity.Name);
                db.AddInParameter(cmd, "@Value", DbType.String, cRMAgreementVariableMapEntity.Value);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cRMAgreementVariableMapEntity.Remarks);
                db.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, cRMAgreementVariableMapEntity.CreatedByEmployeeID);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMAgreementVariableMapEntity.CreateDate);
                db.AddInParameter(cmd, "@IP", DbType.String, cRMAgreementVariableMapEntity.IP);

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

        IList<Int64> ICRMAgreementVariableMapDataAccess.Update(IList<CRMAgreementVariableMapEntity> cRMAgreementVariableMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CRMAgreementVariableMapEntity cRMAgreementVariableMapEntity in cRMAgreementVariableMapEntityList)
            {
                returnCode = (this as ICRMAgreementVariableMapDataAccess).Update(cRMAgreementVariableMapEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICRMAgreementVariableMapDataAccess.Delete(CRMAgreementVariableMapEntity cRMAgreementVariableMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cRMAgreementVariableMapEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cRMAgreementVariableMapEntity, filterExpression, option);
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

        private Int64 Delete(CRMAgreementVariableMapEntity cRMAgreementVariableMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMAgreementVariableMap_SET";

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
                                throw new ArgumentException("CRMAgreementVariableMapEntity already exists. Please specify another CRMAgreementVariableMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMAgreementVariableMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMAgreementVariableMapEntity already exists. Please specify another CRMAgreementVariableMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CRMAgreementVariableMapEntity cRMAgreementVariableMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMAgreementVariableMap_SET";

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

        IList<Int64> ICRMAgreementVariableMapDataAccess.Delete(IList<CRMAgreementVariableMapEntity> cRMAgreementVariableMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CRMAgreementVariableMapEntity cRMAgreementVariableMapEntity in cRMAgreementVariableMapEntityList)
            {
                returnCode = (this as ICRMAgreementVariableMapDataAccess).Delete(cRMAgreementVariableMapEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CRMAgreementVariableMapEntity> ICRMAgreementVariableMapDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CRMAgreementVariableMap_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CRMAgreementVariableMapEntity> list = CreateEntityBuilder<CRMAgreementVariableMapEntity>().BuildEntities(reader);

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

        DataTable ICRMAgreementVariableMapDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CRMAgreementVariableMap_GET";

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
