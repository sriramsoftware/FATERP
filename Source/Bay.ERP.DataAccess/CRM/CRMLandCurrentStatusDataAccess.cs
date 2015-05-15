// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 01-Apr-2013, 02:41:21




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
    internal sealed partial class CRMLandCurrentStatusDataAccess : BaseDataAccess, ICRMLandCurrentStatusDataAccess
    {
        #region Constructors

        public CRMLandCurrentStatusDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CRMLandCurrentStatusEntity> CreateEntityBuilder<CRMLandCurrentStatusEntity>()
        {
            return (new CRMLandCurrentStatusBuilder()) as IEntityBuilder<CRMLandCurrentStatusEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICRMLandCurrentStatusDataAccess.Add(CRMLandCurrentStatusEntity cRMLandCurrentStatusEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cRMLandCurrentStatusEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cRMLandCurrentStatusEntity, option);
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

        private Int64 Add(CRMLandCurrentStatusEntity cRMLandCurrentStatusEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMLandCurrentStatus_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "LandCurrentStatusID");

                Database.AddInParameter(cmd, "@LandBasicInfoID", DbType.Int64, cRMLandCurrentStatusEntity.LandBasicInfoID);	
                Database.AddInParameter(cmd, "@Ownership", DbType.String, cRMLandCurrentStatusEntity.Ownership);	
                Database.AddInParameter(cmd, "@Mutation", DbType.String, cRMLandCurrentStatusEntity.Mutation);	
                Database.AddInParameter(cmd, "@CurrentUsage", DbType.String, cRMLandCurrentStatusEntity.CurrentUsage);	
                Database.AddInParameter(cmd, "@CommercialPermit", DbType.String, cRMLandCurrentStatusEntity.CommercialPermit);	
                Database.AddInParameter(cmd, "@Tenant", DbType.String, cRMLandCurrentStatusEntity.Tenant);	
                Database.AddInParameter(cmd, "@LoanLiability", DbType.String, cRMLandCurrentStatusEntity.LoanLiability);	
                Database.AddInParameter(cmd, "@NOC", DbType.String, cRMLandCurrentStatusEntity.NOC);	
                Database.AddInParameter(cmd, "@Agreements", DbType.String, cRMLandCurrentStatusEntity.Agreements);	
                Database.AddInParameter(cmd, "@Litigation", DbType.String, cRMLandCurrentStatusEntity.Litigation);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CRMLandCurrentStatusEntity already exists. Please specify another CRMLandCurrentStatusEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMLandCurrentStatusEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMLandCurrentStatusEntity already exists. Please specify another CRMLandCurrentStatusEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CRMLandCurrentStatusEntity cRMLandCurrentStatusEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMLandCurrentStatus_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "LandCurrentStatusID", db);

                db.AddInParameter(cmd, "@LandBasicInfoID", DbType.Int64, cRMLandCurrentStatusEntity.LandBasicInfoID);
                db.AddInParameter(cmd, "@Ownership", DbType.String, cRMLandCurrentStatusEntity.Ownership);
                db.AddInParameter(cmd, "@Mutation", DbType.String, cRMLandCurrentStatusEntity.Mutation);
                db.AddInParameter(cmd, "@CurrentUsage", DbType.String, cRMLandCurrentStatusEntity.CurrentUsage);
                db.AddInParameter(cmd, "@CommercialPermit", DbType.String, cRMLandCurrentStatusEntity.CommercialPermit);
                db.AddInParameter(cmd, "@Tenant", DbType.String, cRMLandCurrentStatusEntity.Tenant);
                db.AddInParameter(cmd, "@LoanLiability", DbType.String, cRMLandCurrentStatusEntity.LoanLiability);
                db.AddInParameter(cmd, "@NOC", DbType.String, cRMLandCurrentStatusEntity.NOC);
                db.AddInParameter(cmd, "@Agreements", DbType.String, cRMLandCurrentStatusEntity.Agreements);
                db.AddInParameter(cmd, "@Litigation", DbType.String, cRMLandCurrentStatusEntity.Litigation);

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

        IList<Int64> ICRMLandCurrentStatusDataAccess.Add(IList<CRMLandCurrentStatusEntity> cRMLandCurrentStatusEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CRMLandCurrentStatusEntity cRMLandCurrentStatusEntity in cRMLandCurrentStatusEntityList)
            {
                returnCode = (this as ICRMLandCurrentStatusDataAccess).Add(cRMLandCurrentStatusEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICRMLandCurrentStatusDataAccess.Update(CRMLandCurrentStatusEntity cRMLandCurrentStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cRMLandCurrentStatusEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cRMLandCurrentStatusEntity, filterExpression, option);
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

        private Int64 Update(CRMLandCurrentStatusEntity cRMLandCurrentStatusEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMLandCurrentStatus_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@LandCurrentStatusID", DbType.Int64, cRMLandCurrentStatusEntity.LandCurrentStatusID);
                Database.AddInParameter(cmd, "@LandBasicInfoID", DbType.Int64, cRMLandCurrentStatusEntity.LandBasicInfoID);
                Database.AddInParameter(cmd, "@Ownership", DbType.String, cRMLandCurrentStatusEntity.Ownership);
                Database.AddInParameter(cmd, "@Mutation", DbType.String, cRMLandCurrentStatusEntity.Mutation);
                Database.AddInParameter(cmd, "@CurrentUsage", DbType.String, cRMLandCurrentStatusEntity.CurrentUsage);
                Database.AddInParameter(cmd, "@CommercialPermit", DbType.String, cRMLandCurrentStatusEntity.CommercialPermit);
                Database.AddInParameter(cmd, "@Tenant", DbType.String, cRMLandCurrentStatusEntity.Tenant);
                Database.AddInParameter(cmd, "@LoanLiability", DbType.String, cRMLandCurrentStatusEntity.LoanLiability);
                Database.AddInParameter(cmd, "@NOC", DbType.String, cRMLandCurrentStatusEntity.NOC);
                Database.AddInParameter(cmd, "@Agreements", DbType.String, cRMLandCurrentStatusEntity.Agreements);
                Database.AddInParameter(cmd, "@Litigation", DbType.String, cRMLandCurrentStatusEntity.Litigation);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CRMLandCurrentStatusEntity already exists. Please specify another CRMLandCurrentStatusEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMLandCurrentStatusEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMLandCurrentStatusEntity already exists. Please specify another CRMLandCurrentStatusEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CRMLandCurrentStatusEntity cRMLandCurrentStatusEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMLandCurrentStatus_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@LandCurrentStatusID", DbType.Int64, cRMLandCurrentStatusEntity.LandCurrentStatusID);
                db.AddInParameter(cmd, "@LandBasicInfoID", DbType.Int64, cRMLandCurrentStatusEntity.LandBasicInfoID);
                db.AddInParameter(cmd, "@Ownership", DbType.String, cRMLandCurrentStatusEntity.Ownership);
                db.AddInParameter(cmd, "@Mutation", DbType.String, cRMLandCurrentStatusEntity.Mutation);
                db.AddInParameter(cmd, "@CurrentUsage", DbType.String, cRMLandCurrentStatusEntity.CurrentUsage);
                db.AddInParameter(cmd, "@CommercialPermit", DbType.String, cRMLandCurrentStatusEntity.CommercialPermit);
                db.AddInParameter(cmd, "@Tenant", DbType.String, cRMLandCurrentStatusEntity.Tenant);
                db.AddInParameter(cmd, "@LoanLiability", DbType.String, cRMLandCurrentStatusEntity.LoanLiability);
                db.AddInParameter(cmd, "@NOC", DbType.String, cRMLandCurrentStatusEntity.NOC);
                db.AddInParameter(cmd, "@Agreements", DbType.String, cRMLandCurrentStatusEntity.Agreements);
                db.AddInParameter(cmd, "@Litigation", DbType.String, cRMLandCurrentStatusEntity.Litigation);

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

        IList<Int64> ICRMLandCurrentStatusDataAccess.Update(IList<CRMLandCurrentStatusEntity> cRMLandCurrentStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CRMLandCurrentStatusEntity cRMLandCurrentStatusEntity in cRMLandCurrentStatusEntityList)
            {
                returnCode = (this as ICRMLandCurrentStatusDataAccess).Update(cRMLandCurrentStatusEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICRMLandCurrentStatusDataAccess.Delete(CRMLandCurrentStatusEntity cRMLandCurrentStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cRMLandCurrentStatusEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cRMLandCurrentStatusEntity, filterExpression, option);
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

        private Int64 Delete(CRMLandCurrentStatusEntity cRMLandCurrentStatusEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMLandCurrentStatus_SET";

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
                                throw new ArgumentException("CRMLandCurrentStatusEntity already exists. Please specify another CRMLandCurrentStatusEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMLandCurrentStatusEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMLandCurrentStatusEntity already exists. Please specify another CRMLandCurrentStatusEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CRMLandCurrentStatusEntity cRMLandCurrentStatusEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMLandCurrentStatus_SET";

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

        IList<Int64> ICRMLandCurrentStatusDataAccess.Delete(IList<CRMLandCurrentStatusEntity> cRMLandCurrentStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CRMLandCurrentStatusEntity cRMLandCurrentStatusEntity in cRMLandCurrentStatusEntityList)
            {
                returnCode = (this as ICRMLandCurrentStatusDataAccess).Delete(cRMLandCurrentStatusEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CRMLandCurrentStatusEntity> ICRMLandCurrentStatusDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CRMLandCurrentStatus_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CRMLandCurrentStatusEntity> list = CreateEntityBuilder<CRMLandCurrentStatusEntity>().BuildEntities(reader);

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

        DataTable ICRMLandCurrentStatusDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CRMLandCurrentStatus_GET";

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
