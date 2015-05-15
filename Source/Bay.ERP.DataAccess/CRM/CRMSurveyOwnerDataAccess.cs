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
    internal sealed partial class CRMSurveyOwnerDataAccess : BaseDataAccess, ICRMSurveyOwnerDataAccess
    {
        #region Constructors

        public CRMSurveyOwnerDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CRMSurveyOwnerEntity> CreateEntityBuilder<CRMSurveyOwnerEntity>()
        {
            return (new CRMSurveyOwnerBuilder()) as IEntityBuilder<CRMSurveyOwnerEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICRMSurveyOwnerDataAccess.Add(CRMSurveyOwnerEntity cRMSurveyOwnerEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cRMSurveyOwnerEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cRMSurveyOwnerEntity, option);
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

        private Int64 Add(CRMSurveyOwnerEntity cRMSurveyOwnerEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMSurveyOwner_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "SurveyOwnerID");

                Database.AddInParameter(cmd, "@SurveyOwnerTypeID", DbType.Int64, cRMSurveyOwnerEntity.SurveyOwnerTypeID);	
                Database.AddInParameter(cmd, "@Name", DbType.String, cRMSurveyOwnerEntity.Name);	
                Database.AddInParameter(cmd, "@AddressLine1", DbType.String, cRMSurveyOwnerEntity.AddressLine1);	
                Database.AddInParameter(cmd, "@AddressLine2", DbType.String, cRMSurveyOwnerEntity.AddressLine2);	
                Database.AddInParameter(cmd, "@ContactNo1", DbType.String, cRMSurveyOwnerEntity.ContactNo1);	
                Database.AddInParameter(cmd, "@ContactNo2", DbType.String, cRMSurveyOwnerEntity.ContactNo2);	
                Database.AddInParameter(cmd, "@Email", DbType.String, cRMSurveyOwnerEntity.Email);	
                Database.AddInParameter(cmd, "@WebLink", DbType.String, cRMSurveyOwnerEntity.WebLink);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cRMSurveyOwnerEntity.Remarks);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CRMSurveyOwnerEntity already exists. Please specify another CRMSurveyOwnerEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMSurveyOwnerEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMSurveyOwnerEntity already exists. Please specify another CRMSurveyOwnerEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CRMSurveyOwnerEntity cRMSurveyOwnerEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMSurveyOwner_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "SurveyOwnerID", db);

                db.AddInParameter(cmd, "@SurveyOwnerTypeID", DbType.Int64, cRMSurveyOwnerEntity.SurveyOwnerTypeID);
                db.AddInParameter(cmd, "@Name", DbType.String, cRMSurveyOwnerEntity.Name);
                db.AddInParameter(cmd, "@AddressLine1", DbType.String, cRMSurveyOwnerEntity.AddressLine1);
                db.AddInParameter(cmd, "@AddressLine2", DbType.String, cRMSurveyOwnerEntity.AddressLine2);
                db.AddInParameter(cmd, "@ContactNo1", DbType.String, cRMSurveyOwnerEntity.ContactNo1);
                db.AddInParameter(cmd, "@ContactNo2", DbType.String, cRMSurveyOwnerEntity.ContactNo2);
                db.AddInParameter(cmd, "@Email", DbType.String, cRMSurveyOwnerEntity.Email);
                db.AddInParameter(cmd, "@WebLink", DbType.String, cRMSurveyOwnerEntity.WebLink);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cRMSurveyOwnerEntity.Remarks);

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

        IList<Int64> ICRMSurveyOwnerDataAccess.Add(IList<CRMSurveyOwnerEntity> cRMSurveyOwnerEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CRMSurveyOwnerEntity cRMSurveyOwnerEntity in cRMSurveyOwnerEntityList)
            {
                returnCode = (this as ICRMSurveyOwnerDataAccess).Add(cRMSurveyOwnerEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICRMSurveyOwnerDataAccess.Update(CRMSurveyOwnerEntity cRMSurveyOwnerEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cRMSurveyOwnerEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cRMSurveyOwnerEntity, filterExpression, option);
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

        private Int64 Update(CRMSurveyOwnerEntity cRMSurveyOwnerEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMSurveyOwner_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@SurveyOwnerID", DbType.Int64, cRMSurveyOwnerEntity.SurveyOwnerID);
                Database.AddInParameter(cmd, "@SurveyOwnerTypeID", DbType.Int64, cRMSurveyOwnerEntity.SurveyOwnerTypeID);
                Database.AddInParameter(cmd, "@Name", DbType.String, cRMSurveyOwnerEntity.Name);
                Database.AddInParameter(cmd, "@AddressLine1", DbType.String, cRMSurveyOwnerEntity.AddressLine1);
                Database.AddInParameter(cmd, "@AddressLine2", DbType.String, cRMSurveyOwnerEntity.AddressLine2);
                Database.AddInParameter(cmd, "@ContactNo1", DbType.String, cRMSurveyOwnerEntity.ContactNo1);
                Database.AddInParameter(cmd, "@ContactNo2", DbType.String, cRMSurveyOwnerEntity.ContactNo2);
                Database.AddInParameter(cmd, "@Email", DbType.String, cRMSurveyOwnerEntity.Email);
                Database.AddInParameter(cmd, "@WebLink", DbType.String, cRMSurveyOwnerEntity.WebLink);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cRMSurveyOwnerEntity.Remarks);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CRMSurveyOwnerEntity already exists. Please specify another CRMSurveyOwnerEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMSurveyOwnerEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMSurveyOwnerEntity already exists. Please specify another CRMSurveyOwnerEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CRMSurveyOwnerEntity cRMSurveyOwnerEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMSurveyOwner_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@SurveyOwnerID", DbType.Int64, cRMSurveyOwnerEntity.SurveyOwnerID);
                db.AddInParameter(cmd, "@SurveyOwnerTypeID", DbType.Int64, cRMSurveyOwnerEntity.SurveyOwnerTypeID);
                db.AddInParameter(cmd, "@Name", DbType.String, cRMSurveyOwnerEntity.Name);
                db.AddInParameter(cmd, "@AddressLine1", DbType.String, cRMSurveyOwnerEntity.AddressLine1);
                db.AddInParameter(cmd, "@AddressLine2", DbType.String, cRMSurveyOwnerEntity.AddressLine2);
                db.AddInParameter(cmd, "@ContactNo1", DbType.String, cRMSurveyOwnerEntity.ContactNo1);
                db.AddInParameter(cmd, "@ContactNo2", DbType.String, cRMSurveyOwnerEntity.ContactNo2);
                db.AddInParameter(cmd, "@Email", DbType.String, cRMSurveyOwnerEntity.Email);
                db.AddInParameter(cmd, "@WebLink", DbType.String, cRMSurveyOwnerEntity.WebLink);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cRMSurveyOwnerEntity.Remarks);

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

        IList<Int64> ICRMSurveyOwnerDataAccess.Update(IList<CRMSurveyOwnerEntity> cRMSurveyOwnerEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CRMSurveyOwnerEntity cRMSurveyOwnerEntity in cRMSurveyOwnerEntityList)
            {
                returnCode = (this as ICRMSurveyOwnerDataAccess).Update(cRMSurveyOwnerEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICRMSurveyOwnerDataAccess.Delete(CRMSurveyOwnerEntity cRMSurveyOwnerEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cRMSurveyOwnerEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cRMSurveyOwnerEntity, filterExpression, option);
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

        private Int64 Delete(CRMSurveyOwnerEntity cRMSurveyOwnerEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMSurveyOwner_SET";

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
                                throw new ArgumentException("CRMSurveyOwnerEntity already exists. Please specify another CRMSurveyOwnerEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMSurveyOwnerEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMSurveyOwnerEntity already exists. Please specify another CRMSurveyOwnerEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CRMSurveyOwnerEntity cRMSurveyOwnerEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMSurveyOwner_SET";

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

        IList<Int64> ICRMSurveyOwnerDataAccess.Delete(IList<CRMSurveyOwnerEntity> cRMSurveyOwnerEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CRMSurveyOwnerEntity cRMSurveyOwnerEntity in cRMSurveyOwnerEntityList)
            {
                returnCode = (this as ICRMSurveyOwnerDataAccess).Delete(cRMSurveyOwnerEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CRMSurveyOwnerEntity> ICRMSurveyOwnerDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CRMSurveyOwner_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CRMSurveyOwnerEntity> list = CreateEntityBuilder<CRMSurveyOwnerEntity>().BuildEntities(reader);

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

        DataTable ICRMSurveyOwnerDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CRMSurveyOwner_GET";

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
