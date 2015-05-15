// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 11-Apr-2013, 01:28:07




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
    internal sealed partial class CRMAgreementTemplateDataAccess : BaseDataAccess, ICRMAgreementTemplateDataAccess
    {
        #region Constructors

        public CRMAgreementTemplateDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CRMAgreementTemplateEntity> CreateEntityBuilder<CRMAgreementTemplateEntity>()
        {
            return (new CRMAgreementTemplateBuilder()) as IEntityBuilder<CRMAgreementTemplateEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICRMAgreementTemplateDataAccess.Add(CRMAgreementTemplateEntity cRMAgreementTemplateEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cRMAgreementTemplateEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cRMAgreementTemplateEntity, option);
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

        private Int64 Add(CRMAgreementTemplateEntity cRMAgreementTemplateEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMAgreementTemplate_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "AgreementTemplateID");

                Database.AddInParameter(cmd, "@TemplateName", DbType.String, cRMAgreementTemplateEntity.TemplateName);	
                Database.AddInParameter(cmd, "@Text", DbType.String, cRMAgreementTemplateEntity.Text);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cRMAgreementTemplateEntity.Remarks);	
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMAgreementTemplateEntity.CreateDate);	
                Database.AddInParameter(cmd, "@IP", DbType.String, cRMAgreementTemplateEntity.IP);	
                Database.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, cRMAgreementTemplateEntity.CreatedByEmployeeID);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CRMAgreementTemplateEntity already exists. Please specify another CRMAgreementTemplateEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMAgreementTemplateEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMAgreementTemplateEntity already exists. Please specify another CRMAgreementTemplateEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CRMAgreementTemplateEntity cRMAgreementTemplateEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMAgreementTemplate_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "AgreementTemplateID", db);

                db.AddInParameter(cmd, "@TemplateName", DbType.String, cRMAgreementTemplateEntity.TemplateName);
                db.AddInParameter(cmd, "@Text", DbType.String, cRMAgreementTemplateEntity.Text);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cRMAgreementTemplateEntity.Remarks);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMAgreementTemplateEntity.CreateDate);
                db.AddInParameter(cmd, "@IP", DbType.String, cRMAgreementTemplateEntity.IP);
                db.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, cRMAgreementTemplateEntity.CreatedByEmployeeID);

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

        IList<Int64> ICRMAgreementTemplateDataAccess.Add(IList<CRMAgreementTemplateEntity> cRMAgreementTemplateEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CRMAgreementTemplateEntity cRMAgreementTemplateEntity in cRMAgreementTemplateEntityList)
            {
                returnCode = (this as ICRMAgreementTemplateDataAccess).Add(cRMAgreementTemplateEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICRMAgreementTemplateDataAccess.Update(CRMAgreementTemplateEntity cRMAgreementTemplateEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cRMAgreementTemplateEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cRMAgreementTemplateEntity, filterExpression, option);
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

        private Int64 Update(CRMAgreementTemplateEntity cRMAgreementTemplateEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMAgreementTemplate_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@AgreementTemplateID", DbType.Int64, cRMAgreementTemplateEntity.AgreementTemplateID);
                Database.AddInParameter(cmd, "@TemplateName", DbType.String, cRMAgreementTemplateEntity.TemplateName);
                Database.AddInParameter(cmd, "@Text", DbType.String, cRMAgreementTemplateEntity.Text);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cRMAgreementTemplateEntity.Remarks);
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMAgreementTemplateEntity.CreateDate);
                Database.AddInParameter(cmd, "@IP", DbType.String, cRMAgreementTemplateEntity.IP);
                Database.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, cRMAgreementTemplateEntity.CreatedByEmployeeID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CRMAgreementTemplateEntity already exists. Please specify another CRMAgreementTemplateEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMAgreementTemplateEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMAgreementTemplateEntity already exists. Please specify another CRMAgreementTemplateEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CRMAgreementTemplateEntity cRMAgreementTemplateEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMAgreementTemplate_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@AgreementTemplateID", DbType.Int64, cRMAgreementTemplateEntity.AgreementTemplateID);
                db.AddInParameter(cmd, "@TemplateName", DbType.String, cRMAgreementTemplateEntity.TemplateName);
                db.AddInParameter(cmd, "@Text", DbType.String, cRMAgreementTemplateEntity.Text);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cRMAgreementTemplateEntity.Remarks);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMAgreementTemplateEntity.CreateDate);
                db.AddInParameter(cmd, "@IP", DbType.String, cRMAgreementTemplateEntity.IP);
                db.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, cRMAgreementTemplateEntity.CreatedByEmployeeID);

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

        IList<Int64> ICRMAgreementTemplateDataAccess.Update(IList<CRMAgreementTemplateEntity> cRMAgreementTemplateEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CRMAgreementTemplateEntity cRMAgreementTemplateEntity in cRMAgreementTemplateEntityList)
            {
                returnCode = (this as ICRMAgreementTemplateDataAccess).Update(cRMAgreementTemplateEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICRMAgreementTemplateDataAccess.Delete(CRMAgreementTemplateEntity cRMAgreementTemplateEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cRMAgreementTemplateEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cRMAgreementTemplateEntity, filterExpression, option);
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

        private Int64 Delete(CRMAgreementTemplateEntity cRMAgreementTemplateEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMAgreementTemplate_SET";

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
                                throw new ArgumentException("CRMAgreementTemplateEntity already exists. Please specify another CRMAgreementTemplateEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMAgreementTemplateEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMAgreementTemplateEntity already exists. Please specify another CRMAgreementTemplateEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CRMAgreementTemplateEntity cRMAgreementTemplateEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMAgreementTemplate_SET";

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

        IList<Int64> ICRMAgreementTemplateDataAccess.Delete(IList<CRMAgreementTemplateEntity> cRMAgreementTemplateEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CRMAgreementTemplateEntity cRMAgreementTemplateEntity in cRMAgreementTemplateEntityList)
            {
                returnCode = (this as ICRMAgreementTemplateDataAccess).Delete(cRMAgreementTemplateEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CRMAgreementTemplateEntity> ICRMAgreementTemplateDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CRMAgreementTemplate_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CRMAgreementTemplateEntity> list = CreateEntityBuilder<CRMAgreementTemplateEntity>().BuildEntities(reader);

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

        DataTable ICRMAgreementTemplateDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CRMAgreementTemplate_GET";

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
