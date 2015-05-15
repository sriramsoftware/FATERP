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
    internal sealed partial class CRMBuyerInterestedRoomMapDataAccess : BaseDataAccess, ICRMBuyerInterestedRoomMapDataAccess
    {
        #region Constructors

        public CRMBuyerInterestedRoomMapDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CRMBuyerInterestedRoomMapEntity> CreateEntityBuilder<CRMBuyerInterestedRoomMapEntity>()
        {
            return (new CRMBuyerInterestedRoomMapBuilder()) as IEntityBuilder<CRMBuyerInterestedRoomMapEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICRMBuyerInterestedRoomMapDataAccess.Add(CRMBuyerInterestedRoomMapEntity cRMBuyerInterestedRoomMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cRMBuyerInterestedRoomMapEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cRMBuyerInterestedRoomMapEntity, option);
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

        private Int64 Add(CRMBuyerInterestedRoomMapEntity cRMBuyerInterestedRoomMapEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMBuyerInterestedRoomMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "BuyerInterestedRoomMapID");

                Database.AddInParameter(cmd, "@BuyerBasicInfoID", DbType.Int64, cRMBuyerInterestedRoomMapEntity.BuyerBasicInfoID);	
                Database.AddInParameter(cmd, "@BuyerInterestedRoomCategoryID", DbType.Int64, cRMBuyerInterestedRoomMapEntity.BuyerInterestedRoomCategoryID);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CRMBuyerInterestedRoomMapEntity already exists. Please specify another CRMBuyerInterestedRoomMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMBuyerInterestedRoomMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMBuyerInterestedRoomMapEntity already exists. Please specify another CRMBuyerInterestedRoomMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CRMBuyerInterestedRoomMapEntity cRMBuyerInterestedRoomMapEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMBuyerInterestedRoomMap_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "BuyerInterestedRoomMapID", db);

                db.AddInParameter(cmd, "@BuyerBasicInfoID", DbType.Int64, cRMBuyerInterestedRoomMapEntity.BuyerBasicInfoID);
                db.AddInParameter(cmd, "@BuyerInterestedRoomCategoryID", DbType.Int64, cRMBuyerInterestedRoomMapEntity.BuyerInterestedRoomCategoryID);

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

        IList<Int64> ICRMBuyerInterestedRoomMapDataAccess.Add(IList<CRMBuyerInterestedRoomMapEntity> cRMBuyerInterestedRoomMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CRMBuyerInterestedRoomMapEntity cRMBuyerInterestedRoomMapEntity in cRMBuyerInterestedRoomMapEntityList)
            {
                returnCode = (this as ICRMBuyerInterestedRoomMapDataAccess).Add(cRMBuyerInterestedRoomMapEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICRMBuyerInterestedRoomMapDataAccess.Update(CRMBuyerInterestedRoomMapEntity cRMBuyerInterestedRoomMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cRMBuyerInterestedRoomMapEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cRMBuyerInterestedRoomMapEntity, filterExpression, option);
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

        private Int64 Update(CRMBuyerInterestedRoomMapEntity cRMBuyerInterestedRoomMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMBuyerInterestedRoomMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@BuyerInterestedRoomMapID", DbType.Int64, cRMBuyerInterestedRoomMapEntity.BuyerInterestedRoomMapID);
                Database.AddInParameter(cmd, "@BuyerBasicInfoID", DbType.Int64, cRMBuyerInterestedRoomMapEntity.BuyerBasicInfoID);
                Database.AddInParameter(cmd, "@BuyerInterestedRoomCategoryID", DbType.Int64, cRMBuyerInterestedRoomMapEntity.BuyerInterestedRoomCategoryID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CRMBuyerInterestedRoomMapEntity already exists. Please specify another CRMBuyerInterestedRoomMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMBuyerInterestedRoomMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMBuyerInterestedRoomMapEntity already exists. Please specify another CRMBuyerInterestedRoomMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CRMBuyerInterestedRoomMapEntity cRMBuyerInterestedRoomMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMBuyerInterestedRoomMap_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@BuyerInterestedRoomMapID", DbType.Int64, cRMBuyerInterestedRoomMapEntity.BuyerInterestedRoomMapID);
                db.AddInParameter(cmd, "@BuyerBasicInfoID", DbType.Int64, cRMBuyerInterestedRoomMapEntity.BuyerBasicInfoID);
                db.AddInParameter(cmd, "@BuyerInterestedRoomCategoryID", DbType.Int64, cRMBuyerInterestedRoomMapEntity.BuyerInterestedRoomCategoryID);

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

        IList<Int64> ICRMBuyerInterestedRoomMapDataAccess.Update(IList<CRMBuyerInterestedRoomMapEntity> cRMBuyerInterestedRoomMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CRMBuyerInterestedRoomMapEntity cRMBuyerInterestedRoomMapEntity in cRMBuyerInterestedRoomMapEntityList)
            {
                returnCode = (this as ICRMBuyerInterestedRoomMapDataAccess).Update(cRMBuyerInterestedRoomMapEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICRMBuyerInterestedRoomMapDataAccess.Delete(CRMBuyerInterestedRoomMapEntity cRMBuyerInterestedRoomMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cRMBuyerInterestedRoomMapEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cRMBuyerInterestedRoomMapEntity, filterExpression, option);
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

        private Int64 Delete(CRMBuyerInterestedRoomMapEntity cRMBuyerInterestedRoomMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMBuyerInterestedRoomMap_SET";

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
                                throw new ArgumentException("CRMBuyerInterestedRoomMapEntity already exists. Please specify another CRMBuyerInterestedRoomMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMBuyerInterestedRoomMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMBuyerInterestedRoomMapEntity already exists. Please specify another CRMBuyerInterestedRoomMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CRMBuyerInterestedRoomMapEntity cRMBuyerInterestedRoomMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMBuyerInterestedRoomMap_SET";

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

        IList<Int64> ICRMBuyerInterestedRoomMapDataAccess.Delete(IList<CRMBuyerInterestedRoomMapEntity> cRMBuyerInterestedRoomMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CRMBuyerInterestedRoomMapEntity cRMBuyerInterestedRoomMapEntity in cRMBuyerInterestedRoomMapEntityList)
            {
                returnCode = (this as ICRMBuyerInterestedRoomMapDataAccess).Delete(cRMBuyerInterestedRoomMapEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CRMBuyerInterestedRoomMapEntity> ICRMBuyerInterestedRoomMapDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CRMBuyerInterestedRoomMap_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CRMBuyerInterestedRoomMapEntity> list = CreateEntityBuilder<CRMBuyerInterestedRoomMapEntity>().BuildEntities(reader);

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

        DataTable ICRMBuyerInterestedRoomMapDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CRMBuyerInterestedRoomMap_GET";

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
