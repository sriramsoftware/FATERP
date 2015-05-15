// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Oct-2013, 12:51:37




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
    internal sealed partial class CRMSurveyOwnerContactPersonDataAccess : BaseDataAccess, ICRMSurveyOwnerContactPersonDataAccess
    {
        #region Constructors

        public CRMSurveyOwnerContactPersonDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CRMSurveyOwnerContactPersonEntity> CreateEntityBuilder<CRMSurveyOwnerContactPersonEntity>()
        {
            return (new CRMSurveyOwnerContactPersonBuilder()) as IEntityBuilder<CRMSurveyOwnerContactPersonEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICRMSurveyOwnerContactPersonDataAccess.Add(CRMSurveyOwnerContactPersonEntity cRMSurveyOwnerContactPersonEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cRMSurveyOwnerContactPersonEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cRMSurveyOwnerContactPersonEntity, option);
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

        private Int64 Add(CRMSurveyOwnerContactPersonEntity cRMSurveyOwnerContactPersonEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMSurveyOwnerContactPerson_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "SurveyOwnerContactPersonID");

                Database.AddInParameter(cmd, "@SurveyOwnerID", DbType.Int64, cRMSurveyOwnerContactPersonEntity.SurveyOwnerID);	
                Database.AddInParameter(cmd, "@Name", DbType.String, cRMSurveyOwnerContactPersonEntity.Name);	
                Database.AddInParameter(cmd, "@Designation", DbType.String, cRMSurveyOwnerContactPersonEntity.Designation);	
                Database.AddInParameter(cmd, "@Phone", DbType.String, cRMSurveyOwnerContactPersonEntity.Phone);	
                Database.AddInParameter(cmd, "@MobileNo", DbType.String, cRMSurveyOwnerContactPersonEntity.MobileNo);	
                Database.AddInParameter(cmd, "@Fax", DbType.String, cRMSurveyOwnerContactPersonEntity.Fax);	
                Database.AddInParameter(cmd, "@Email", DbType.String, cRMSurveyOwnerContactPersonEntity.Email);	
                Database.AddInParameter(cmd, "@WebLink", DbType.String, cRMSurveyOwnerContactPersonEntity.WebLink);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cRMSurveyOwnerContactPersonEntity.Remarks);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CRMSurveyOwnerContactPersonEntity already exists. Please specify another CRMSurveyOwnerContactPersonEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMSurveyOwnerContactPersonEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMSurveyOwnerContactPersonEntity already exists. Please specify another CRMSurveyOwnerContactPersonEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CRMSurveyOwnerContactPersonEntity cRMSurveyOwnerContactPersonEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMSurveyOwnerContactPerson_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "SurveyOwnerContactPersonID", db);

                db.AddInParameter(cmd, "@SurveyOwnerID", DbType.Int64, cRMSurveyOwnerContactPersonEntity.SurveyOwnerID);
                db.AddInParameter(cmd, "@Name", DbType.String, cRMSurveyOwnerContactPersonEntity.Name);
                db.AddInParameter(cmd, "@Designation", DbType.String, cRMSurveyOwnerContactPersonEntity.Designation);
                db.AddInParameter(cmd, "@Phone", DbType.String, cRMSurveyOwnerContactPersonEntity.Phone);
                db.AddInParameter(cmd, "@MobileNo", DbType.String, cRMSurveyOwnerContactPersonEntity.MobileNo);
                db.AddInParameter(cmd, "@Fax", DbType.String, cRMSurveyOwnerContactPersonEntity.Fax);
                db.AddInParameter(cmd, "@Email", DbType.String, cRMSurveyOwnerContactPersonEntity.Email);
                db.AddInParameter(cmd, "@WebLink", DbType.String, cRMSurveyOwnerContactPersonEntity.WebLink);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cRMSurveyOwnerContactPersonEntity.Remarks);

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

        IList<Int64> ICRMSurveyOwnerContactPersonDataAccess.Add(IList<CRMSurveyOwnerContactPersonEntity> cRMSurveyOwnerContactPersonEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CRMSurveyOwnerContactPersonEntity cRMSurveyOwnerContactPersonEntity in cRMSurveyOwnerContactPersonEntityList)
            {
                returnCode = (this as ICRMSurveyOwnerContactPersonDataAccess).Add(cRMSurveyOwnerContactPersonEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICRMSurveyOwnerContactPersonDataAccess.Update(CRMSurveyOwnerContactPersonEntity cRMSurveyOwnerContactPersonEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cRMSurveyOwnerContactPersonEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cRMSurveyOwnerContactPersonEntity, filterExpression, option);
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

        private Int64 Update(CRMSurveyOwnerContactPersonEntity cRMSurveyOwnerContactPersonEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMSurveyOwnerContactPerson_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@SurveyOwnerContactPersonID", DbType.Int64, cRMSurveyOwnerContactPersonEntity.SurveyOwnerContactPersonID);
                Database.AddInParameter(cmd, "@SurveyOwnerID", DbType.Int64, cRMSurveyOwnerContactPersonEntity.SurveyOwnerID);
                Database.AddInParameter(cmd, "@Name", DbType.String, cRMSurveyOwnerContactPersonEntity.Name);
                Database.AddInParameter(cmd, "@Designation", DbType.String, cRMSurveyOwnerContactPersonEntity.Designation);
                Database.AddInParameter(cmd, "@Phone", DbType.String, cRMSurveyOwnerContactPersonEntity.Phone);
                Database.AddInParameter(cmd, "@MobileNo", DbType.String, cRMSurveyOwnerContactPersonEntity.MobileNo);
                Database.AddInParameter(cmd, "@Fax", DbType.String, cRMSurveyOwnerContactPersonEntity.Fax);
                Database.AddInParameter(cmd, "@Email", DbType.String, cRMSurveyOwnerContactPersonEntity.Email);
                Database.AddInParameter(cmd, "@WebLink", DbType.String, cRMSurveyOwnerContactPersonEntity.WebLink);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cRMSurveyOwnerContactPersonEntity.Remarks);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CRMSurveyOwnerContactPersonEntity already exists. Please specify another CRMSurveyOwnerContactPersonEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMSurveyOwnerContactPersonEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMSurveyOwnerContactPersonEntity already exists. Please specify another CRMSurveyOwnerContactPersonEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CRMSurveyOwnerContactPersonEntity cRMSurveyOwnerContactPersonEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMSurveyOwnerContactPerson_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@SurveyOwnerContactPersonID", DbType.Int64, cRMSurveyOwnerContactPersonEntity.SurveyOwnerContactPersonID);
                db.AddInParameter(cmd, "@SurveyOwnerID", DbType.Int64, cRMSurveyOwnerContactPersonEntity.SurveyOwnerID);
                db.AddInParameter(cmd, "@Name", DbType.String, cRMSurveyOwnerContactPersonEntity.Name);
                db.AddInParameter(cmd, "@Designation", DbType.String, cRMSurveyOwnerContactPersonEntity.Designation);
                db.AddInParameter(cmd, "@Phone", DbType.String, cRMSurveyOwnerContactPersonEntity.Phone);
                db.AddInParameter(cmd, "@MobileNo", DbType.String, cRMSurveyOwnerContactPersonEntity.MobileNo);
                db.AddInParameter(cmd, "@Fax", DbType.String, cRMSurveyOwnerContactPersonEntity.Fax);
                db.AddInParameter(cmd, "@Email", DbType.String, cRMSurveyOwnerContactPersonEntity.Email);
                db.AddInParameter(cmd, "@WebLink", DbType.String, cRMSurveyOwnerContactPersonEntity.WebLink);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cRMSurveyOwnerContactPersonEntity.Remarks);

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

        IList<Int64> ICRMSurveyOwnerContactPersonDataAccess.Update(IList<CRMSurveyOwnerContactPersonEntity> cRMSurveyOwnerContactPersonEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CRMSurveyOwnerContactPersonEntity cRMSurveyOwnerContactPersonEntity in cRMSurveyOwnerContactPersonEntityList)
            {
                returnCode = (this as ICRMSurveyOwnerContactPersonDataAccess).Update(cRMSurveyOwnerContactPersonEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICRMSurveyOwnerContactPersonDataAccess.Delete(CRMSurveyOwnerContactPersonEntity cRMSurveyOwnerContactPersonEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cRMSurveyOwnerContactPersonEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cRMSurveyOwnerContactPersonEntity, filterExpression, option);
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

        private Int64 Delete(CRMSurveyOwnerContactPersonEntity cRMSurveyOwnerContactPersonEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMSurveyOwnerContactPerson_SET";

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
                                throw new ArgumentException("CRMSurveyOwnerContactPersonEntity already exists. Please specify another CRMSurveyOwnerContactPersonEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMSurveyOwnerContactPersonEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMSurveyOwnerContactPersonEntity already exists. Please specify another CRMSurveyOwnerContactPersonEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CRMSurveyOwnerContactPersonEntity cRMSurveyOwnerContactPersonEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMSurveyOwnerContactPerson_SET";

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

        IList<Int64> ICRMSurveyOwnerContactPersonDataAccess.Delete(IList<CRMSurveyOwnerContactPersonEntity> cRMSurveyOwnerContactPersonEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CRMSurveyOwnerContactPersonEntity cRMSurveyOwnerContactPersonEntity in cRMSurveyOwnerContactPersonEntityList)
            {
                returnCode = (this as ICRMSurveyOwnerContactPersonDataAccess).Delete(cRMSurveyOwnerContactPersonEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CRMSurveyOwnerContactPersonEntity> ICRMSurveyOwnerContactPersonDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CRMSurveyOwnerContactPerson_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CRMSurveyOwnerContactPersonEntity> list = CreateEntityBuilder<CRMSurveyOwnerContactPersonEntity>().BuildEntities(reader);

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

        DataTable ICRMSurveyOwnerContactPersonDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CRMSurveyOwnerContactPerson_GET";

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
