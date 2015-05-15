// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-May-2013, 05:23:07




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
    internal sealed partial class CRMBuyerChildrenInfoDataAccess : BaseDataAccess, ICRMBuyerChildrenInfoDataAccess
    {
        #region Constructors

        public CRMBuyerChildrenInfoDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CRMBuyerChildrenInfoEntity> CreateEntityBuilder<CRMBuyerChildrenInfoEntity>()
        {
            return (new CRMBuyerChildrenInfoBuilder()) as IEntityBuilder<CRMBuyerChildrenInfoEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICRMBuyerChildrenInfoDataAccess.Add(CRMBuyerChildrenInfoEntity cRMBuyerChildrenInfoEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cRMBuyerChildrenInfoEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cRMBuyerChildrenInfoEntity, option);
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

        private Int64 Add(CRMBuyerChildrenInfoEntity cRMBuyerChildrenInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMBuyerChildrenInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "BuyerChildrenInfoID");

                Database.AddInParameter(cmd, "@BuyerBasicInfoID", DbType.Int64, cRMBuyerChildrenInfoEntity.BuyerBasicInfoID);	
                Database.AddInParameter(cmd, "@Name", DbType.String, cRMBuyerChildrenInfoEntity.Name);	
                Database.AddInParameter(cmd, "@DOB", DbType.DateTime, cRMBuyerChildrenInfoEntity.DOB);	
                Database.AddInParameter(cmd, "@GenderID", DbType.Int64, cRMBuyerChildrenInfoEntity.GenderID);	
                Database.AddInParameter(cmd, "@EditionalInstituteName", DbType.String, cRMBuyerChildrenInfoEntity.EditionalInstituteName);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CRMBuyerChildrenInfoEntity already exists. Please specify another CRMBuyerChildrenInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMBuyerChildrenInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMBuyerChildrenInfoEntity already exists. Please specify another CRMBuyerChildrenInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CRMBuyerChildrenInfoEntity cRMBuyerChildrenInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMBuyerChildrenInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "BuyerChildrenInfoID", db);

                db.AddInParameter(cmd, "@BuyerBasicInfoID", DbType.Int64, cRMBuyerChildrenInfoEntity.BuyerBasicInfoID);
                db.AddInParameter(cmd, "@Name", DbType.String, cRMBuyerChildrenInfoEntity.Name);
                db.AddInParameter(cmd, "@DOB", DbType.DateTime, cRMBuyerChildrenInfoEntity.DOB);
                db.AddInParameter(cmd, "@GenderID", DbType.Int64, cRMBuyerChildrenInfoEntity.GenderID);
                db.AddInParameter(cmd, "@EditionalInstituteName", DbType.String, cRMBuyerChildrenInfoEntity.EditionalInstituteName);

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

        IList<Int64> ICRMBuyerChildrenInfoDataAccess.Add(IList<CRMBuyerChildrenInfoEntity> cRMBuyerChildrenInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CRMBuyerChildrenInfoEntity cRMBuyerChildrenInfoEntity in cRMBuyerChildrenInfoEntityList)
            {
                returnCode = (this as ICRMBuyerChildrenInfoDataAccess).Add(cRMBuyerChildrenInfoEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICRMBuyerChildrenInfoDataAccess.Update(CRMBuyerChildrenInfoEntity cRMBuyerChildrenInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cRMBuyerChildrenInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cRMBuyerChildrenInfoEntity, filterExpression, option);
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

        private Int64 Update(CRMBuyerChildrenInfoEntity cRMBuyerChildrenInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMBuyerChildrenInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@BuyerChildrenInfoID", DbType.Int64, cRMBuyerChildrenInfoEntity.BuyerChildrenInfoID);
                Database.AddInParameter(cmd, "@BuyerBasicInfoID", DbType.Int64, cRMBuyerChildrenInfoEntity.BuyerBasicInfoID);
                Database.AddInParameter(cmd, "@Name", DbType.String, cRMBuyerChildrenInfoEntity.Name);
                Database.AddInParameter(cmd, "@DOB", DbType.DateTime, cRMBuyerChildrenInfoEntity.DOB);
                Database.AddInParameter(cmd, "@GenderID", DbType.Int64, cRMBuyerChildrenInfoEntity.GenderID);
                Database.AddInParameter(cmd, "@EditionalInstituteName", DbType.String, cRMBuyerChildrenInfoEntity.EditionalInstituteName);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CRMBuyerChildrenInfoEntity already exists. Please specify another CRMBuyerChildrenInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMBuyerChildrenInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMBuyerChildrenInfoEntity already exists. Please specify another CRMBuyerChildrenInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CRMBuyerChildrenInfoEntity cRMBuyerChildrenInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMBuyerChildrenInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@BuyerChildrenInfoID", DbType.Int64, cRMBuyerChildrenInfoEntity.BuyerChildrenInfoID);
                db.AddInParameter(cmd, "@BuyerBasicInfoID", DbType.Int64, cRMBuyerChildrenInfoEntity.BuyerBasicInfoID);
                db.AddInParameter(cmd, "@Name", DbType.String, cRMBuyerChildrenInfoEntity.Name);
                db.AddInParameter(cmd, "@DOB", DbType.DateTime, cRMBuyerChildrenInfoEntity.DOB);
                db.AddInParameter(cmd, "@GenderID", DbType.Int64, cRMBuyerChildrenInfoEntity.GenderID);
                db.AddInParameter(cmd, "@EditionalInstituteName", DbType.String, cRMBuyerChildrenInfoEntity.EditionalInstituteName);

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

        IList<Int64> ICRMBuyerChildrenInfoDataAccess.Update(IList<CRMBuyerChildrenInfoEntity> cRMBuyerChildrenInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CRMBuyerChildrenInfoEntity cRMBuyerChildrenInfoEntity in cRMBuyerChildrenInfoEntityList)
            {
                returnCode = (this as ICRMBuyerChildrenInfoDataAccess).Update(cRMBuyerChildrenInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICRMBuyerChildrenInfoDataAccess.Delete(CRMBuyerChildrenInfoEntity cRMBuyerChildrenInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cRMBuyerChildrenInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cRMBuyerChildrenInfoEntity, filterExpression, option);
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

        private Int64 Delete(CRMBuyerChildrenInfoEntity cRMBuyerChildrenInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMBuyerChildrenInfo_SET";

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
                                throw new ArgumentException("CRMBuyerChildrenInfoEntity already exists. Please specify another CRMBuyerChildrenInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMBuyerChildrenInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMBuyerChildrenInfoEntity already exists. Please specify another CRMBuyerChildrenInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CRMBuyerChildrenInfoEntity cRMBuyerChildrenInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMBuyerChildrenInfo_SET";

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

        IList<Int64> ICRMBuyerChildrenInfoDataAccess.Delete(IList<CRMBuyerChildrenInfoEntity> cRMBuyerChildrenInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CRMBuyerChildrenInfoEntity cRMBuyerChildrenInfoEntity in cRMBuyerChildrenInfoEntityList)
            {
                returnCode = (this as ICRMBuyerChildrenInfoDataAccess).Delete(cRMBuyerChildrenInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CRMBuyerChildrenInfoEntity> ICRMBuyerChildrenInfoDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CRMBuyerChildrenInfo_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CRMBuyerChildrenInfoEntity> list = CreateEntityBuilder<CRMBuyerChildrenInfoEntity>().BuildEntities(reader);

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

        DataTable ICRMBuyerChildrenInfoDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CRMBuyerChildrenInfo_GET";

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
