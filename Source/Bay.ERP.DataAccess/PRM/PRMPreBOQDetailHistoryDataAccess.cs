// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Sep-2012, 11:06:52




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
    internal sealed partial class PRMPreBOQDetailHistoryDataAccess : BaseDataAccess, IPRMPreBOQDetailHistoryDataAccess
    {
        #region Constructors

        public PRMPreBOQDetailHistoryDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<PRMPreBOQDetailHistoryEntity> CreateEntityBuilder<PRMPreBOQDetailHistoryEntity>()
        {
            return (new PRMPreBOQDetailHistoryBuilder()) as IEntityBuilder<PRMPreBOQDetailHistoryEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IPRMPreBOQDetailHistoryDataAccess.Add(PRMPreBOQDetailHistoryEntity pRMPreBOQDetailHistoryEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(pRMPreBOQDetailHistoryEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(pRMPreBOQDetailHistoryEntity, option);
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

        private Int64 Add(PRMPreBOQDetailHistoryEntity pRMPreBOQDetailHistoryEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMPreBOQDetailHistory_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "PRMPreBOQDetailHistoryID");

                Database.AddInParameter(cmd, "@PreBOQDetailID", DbType.Int64, pRMPreBOQDetailHistoryEntity.PreBOQDetailID);	
                Database.AddInParameter(cmd, "@Rate", DbType.Decimal, pRMPreBOQDetailHistoryEntity.Rate);	
                Database.AddInParameter(cmd, "@TotalQty", DbType.Decimal, pRMPreBOQDetailHistoryEntity.TotalQty);	
                Database.AddInParameter(cmd, "@EntryDate", DbType.DateTime, pRMPreBOQDetailHistoryEntity.EntryDate);	
                Database.AddInParameter(cmd, "@BrandID", DbType.Int64, pRMPreBOQDetailHistoryEntity.BrandID);	
                Database.AddInParameter(cmd, "@SupplierID", DbType.Int64, pRMPreBOQDetailHistoryEntity.SupplierID);	
                Database.AddInParameter(cmd, "@RegionID", DbType.Int64, pRMPreBOQDetailHistoryEntity.RegionID);	
                Database.AddInParameter(cmd, "@CountryID", DbType.Int64, pRMPreBOQDetailHistoryEntity.CountryID);	
                Database.AddInParameter(cmd, "@MemberID", DbType.Int64, pRMPreBOQDetailHistoryEntity.MemberID);	
                Database.AddInParameter(cmd, "@UserPCIP", DbType.String, pRMPreBOQDetailHistoryEntity.UserPCIP);	
                Database.AddInParameter(cmd, "@UpdatedDate", DbType.DateTime, pRMPreBOQDetailHistoryEntity.UpdatedDate);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMPreBOQDetailHistoryEntity already exists. Please specify another PRMPreBOQDetailHistoryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMPreBOQDetailHistoryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMPreBOQDetailHistoryEntity already exists. Please specify another PRMPreBOQDetailHistoryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(PRMPreBOQDetailHistoryEntity pRMPreBOQDetailHistoryEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMPreBOQDetailHistory_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "PRMPreBOQDetailHistoryID", db);

                db.AddInParameter(cmd, "@PreBOQDetailID", DbType.Int64, pRMPreBOQDetailHistoryEntity.PreBOQDetailID);
                db.AddInParameter(cmd, "@Rate", DbType.Decimal, pRMPreBOQDetailHistoryEntity.Rate);
                db.AddInParameter(cmd, "@TotalQty", DbType.Decimal, pRMPreBOQDetailHistoryEntity.TotalQty);
                db.AddInParameter(cmd, "@EntryDate", DbType.DateTime, pRMPreBOQDetailHistoryEntity.EntryDate);
                db.AddInParameter(cmd, "@BrandID", DbType.Int64, pRMPreBOQDetailHistoryEntity.BrandID);
                db.AddInParameter(cmd, "@SupplierID", DbType.Int64, pRMPreBOQDetailHistoryEntity.SupplierID);
                db.AddInParameter(cmd, "@RegionID", DbType.Int64, pRMPreBOQDetailHistoryEntity.RegionID);
                db.AddInParameter(cmd, "@CountryID", DbType.Int64, pRMPreBOQDetailHistoryEntity.CountryID);
                db.AddInParameter(cmd, "@MemberID", DbType.Int64, pRMPreBOQDetailHistoryEntity.MemberID);
                db.AddInParameter(cmd, "@UserPCIP", DbType.String, pRMPreBOQDetailHistoryEntity.UserPCIP);
                db.AddInParameter(cmd, "@UpdatedDate", DbType.DateTime, pRMPreBOQDetailHistoryEntity.UpdatedDate);

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

        IList<Int64> IPRMPreBOQDetailHistoryDataAccess.Add(IList<PRMPreBOQDetailHistoryEntity> pRMPreBOQDetailHistoryEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (PRMPreBOQDetailHistoryEntity pRMPreBOQDetailHistoryEntity in pRMPreBOQDetailHistoryEntityList)
            {
                returnCode = (this as IPRMPreBOQDetailHistoryDataAccess).Add(pRMPreBOQDetailHistoryEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IPRMPreBOQDetailHistoryDataAccess.Update(PRMPreBOQDetailHistoryEntity pRMPreBOQDetailHistoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(pRMPreBOQDetailHistoryEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(pRMPreBOQDetailHistoryEntity, filterExpression, option);
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

        private Int64 Update(PRMPreBOQDetailHistoryEntity pRMPreBOQDetailHistoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMPreBOQDetailHistory_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@PRMPreBOQDetailHistoryID", DbType.Int64, pRMPreBOQDetailHistoryEntity.PRMPreBOQDetailHistoryID);
                Database.AddInParameter(cmd, "@PreBOQDetailID", DbType.Int64, pRMPreBOQDetailHistoryEntity.PreBOQDetailID);
                Database.AddInParameter(cmd, "@Rate", DbType.Decimal, pRMPreBOQDetailHistoryEntity.Rate);
                Database.AddInParameter(cmd, "@TotalQty", DbType.Decimal, pRMPreBOQDetailHistoryEntity.TotalQty);
                Database.AddInParameter(cmd, "@EntryDate", DbType.DateTime, pRMPreBOQDetailHistoryEntity.EntryDate);
                Database.AddInParameter(cmd, "@BrandID", DbType.Int64, pRMPreBOQDetailHistoryEntity.BrandID);
                Database.AddInParameter(cmd, "@SupplierID", DbType.Int64, pRMPreBOQDetailHistoryEntity.SupplierID);
                Database.AddInParameter(cmd, "@RegionID", DbType.Int64, pRMPreBOQDetailHistoryEntity.RegionID);
                Database.AddInParameter(cmd, "@CountryID", DbType.Int64, pRMPreBOQDetailHistoryEntity.CountryID);
                Database.AddInParameter(cmd, "@MemberID", DbType.Int64, pRMPreBOQDetailHistoryEntity.MemberID);
                Database.AddInParameter(cmd, "@UserPCIP", DbType.String, pRMPreBOQDetailHistoryEntity.UserPCIP);
                Database.AddInParameter(cmd, "@UpdatedDate", DbType.DateTime, pRMPreBOQDetailHistoryEntity.UpdatedDate);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMPreBOQDetailHistoryEntity already exists. Please specify another PRMPreBOQDetailHistoryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMPreBOQDetailHistoryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMPreBOQDetailHistoryEntity already exists. Please specify another PRMPreBOQDetailHistoryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(PRMPreBOQDetailHistoryEntity pRMPreBOQDetailHistoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMPreBOQDetailHistory_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@PRMPreBOQDetailHistoryID", DbType.Int64, pRMPreBOQDetailHistoryEntity.PRMPreBOQDetailHistoryID);
                db.AddInParameter(cmd, "@PreBOQDetailID", DbType.Int64, pRMPreBOQDetailHistoryEntity.PreBOQDetailID);
                db.AddInParameter(cmd, "@Rate", DbType.Decimal, pRMPreBOQDetailHistoryEntity.Rate);
                db.AddInParameter(cmd, "@TotalQty", DbType.Decimal, pRMPreBOQDetailHistoryEntity.TotalQty);
                db.AddInParameter(cmd, "@EntryDate", DbType.DateTime, pRMPreBOQDetailHistoryEntity.EntryDate);
                db.AddInParameter(cmd, "@BrandID", DbType.Int64, pRMPreBOQDetailHistoryEntity.BrandID);
                db.AddInParameter(cmd, "@SupplierID", DbType.Int64, pRMPreBOQDetailHistoryEntity.SupplierID);
                db.AddInParameter(cmd, "@RegionID", DbType.Int64, pRMPreBOQDetailHistoryEntity.RegionID);
                db.AddInParameter(cmd, "@CountryID", DbType.Int64, pRMPreBOQDetailHistoryEntity.CountryID);
                db.AddInParameter(cmd, "@MemberID", DbType.Int64, pRMPreBOQDetailHistoryEntity.MemberID);
                db.AddInParameter(cmd, "@UserPCIP", DbType.String, pRMPreBOQDetailHistoryEntity.UserPCIP);
                db.AddInParameter(cmd, "@UpdatedDate", DbType.DateTime, pRMPreBOQDetailHistoryEntity.UpdatedDate);

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

        IList<Int64> IPRMPreBOQDetailHistoryDataAccess.Update(IList<PRMPreBOQDetailHistoryEntity> pRMPreBOQDetailHistoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (PRMPreBOQDetailHistoryEntity pRMPreBOQDetailHistoryEntity in pRMPreBOQDetailHistoryEntityList)
            {
                returnCode = (this as IPRMPreBOQDetailHistoryDataAccess).Update(pRMPreBOQDetailHistoryEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IPRMPreBOQDetailHistoryDataAccess.Delete(PRMPreBOQDetailHistoryEntity pRMPreBOQDetailHistoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(pRMPreBOQDetailHistoryEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(pRMPreBOQDetailHistoryEntity, filterExpression, option);
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

        private Int64 Delete(PRMPreBOQDetailHistoryEntity pRMPreBOQDetailHistoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMPreBOQDetailHistory_SET";

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
                                throw new ArgumentException("PRMPreBOQDetailHistoryEntity already exists. Please specify another PRMPreBOQDetailHistoryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMPreBOQDetailHistoryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMPreBOQDetailHistoryEntity already exists. Please specify another PRMPreBOQDetailHistoryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(PRMPreBOQDetailHistoryEntity pRMPreBOQDetailHistoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMPreBOQDetailHistory_SET";

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

        IList<Int64> IPRMPreBOQDetailHistoryDataAccess.Delete(IList<PRMPreBOQDetailHistoryEntity> pRMPreBOQDetailHistoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (PRMPreBOQDetailHistoryEntity pRMPreBOQDetailHistoryEntity in pRMPreBOQDetailHistoryEntityList)
            {
                returnCode = (this as IPRMPreBOQDetailHistoryDataAccess).Delete(pRMPreBOQDetailHistoryEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<PRMPreBOQDetailHistoryEntity> IPRMPreBOQDetailHistoryDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMPreBOQDetailHistory_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<PRMPreBOQDetailHistoryEntity> list = CreateEntityBuilder<PRMPreBOQDetailHistoryEntity>().BuildEntities(reader);

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

        DataTable IPRMPreBOQDetailHistoryDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMPreBOQDetailHistory_GET";

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
