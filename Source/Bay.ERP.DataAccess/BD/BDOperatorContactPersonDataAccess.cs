// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-May-2015, 12:50:36




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
    internal sealed partial class BDOperatorContactPersonDataAccess : BaseDataAccess, IBDOperatorContactPersonDataAccess
    {
        #region Constructors

        public BDOperatorContactPersonDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<BDOperatorContactPersonEntity> CreateEntityBuilder<BDOperatorContactPersonEntity>()
        {
            return (new BDOperatorContactPersonBuilder()) as IEntityBuilder<BDOperatorContactPersonEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IBDOperatorContactPersonDataAccess.Add(BDOperatorContactPersonEntity bDOperatorContactPersonEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(bDOperatorContactPersonEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(bDOperatorContactPersonEntity, option);
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

        private Int64 Add(BDOperatorContactPersonEntity bDOperatorContactPersonEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDOperatorContactPerson_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "OperatorContactPersonID");

                Database.AddInParameter(cmd, "@OperatorID", DbType.Int64, bDOperatorContactPersonEntity.OperatorID);	
                Database.AddInParameter(cmd, "@ZoneID", DbType.Int64, bDOperatorContactPersonEntity.ZoneID);	
                Database.AddInParameter(cmd, "@Name", DbType.String, bDOperatorContactPersonEntity.Name);	
                Database.AddInParameter(cmd, "@ZoneDesignationID", DbType.Int64, bDOperatorContactPersonEntity.ZoneDesignationID);	
                Database.AddInParameter(cmd, "@ID", DbType.String, bDOperatorContactPersonEntity.ID);	
                Database.AddInParameter(cmd, "@Phone", DbType.String, bDOperatorContactPersonEntity.Phone);	
                Database.AddInParameter(cmd, "@MobileNo", DbType.String, bDOperatorContactPersonEntity.MobileNo);	
                Database.AddInParameter(cmd, "@Fax", DbType.String, bDOperatorContactPersonEntity.Fax);	
                Database.AddInParameter(cmd, "@Email", DbType.String, bDOperatorContactPersonEntity.Email);	
                Database.AddInParameter(cmd, "@WebLink", DbType.String, bDOperatorContactPersonEntity.WebLink);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDOperatorContactPersonEntity already exists. Please specify another BDOperatorContactPersonEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDOperatorContactPersonEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDOperatorContactPersonEntity already exists. Please specify another BDOperatorContactPersonEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(BDOperatorContactPersonEntity bDOperatorContactPersonEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDOperatorContactPerson_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "OperatorContactPersonID", db);

                db.AddInParameter(cmd, "@OperatorID", DbType.Int64, bDOperatorContactPersonEntity.OperatorID);
                db.AddInParameter(cmd, "@ZoneID", DbType.Int64, bDOperatorContactPersonEntity.ZoneID);
                db.AddInParameter(cmd, "@Name", DbType.String, bDOperatorContactPersonEntity.Name);
                db.AddInParameter(cmd, "@ZoneDesignationID", DbType.Int64, bDOperatorContactPersonEntity.ZoneDesignationID);
                db.AddInParameter(cmd, "@ID", DbType.String, bDOperatorContactPersonEntity.ID);
                db.AddInParameter(cmd, "@Phone", DbType.String, bDOperatorContactPersonEntity.Phone);
                db.AddInParameter(cmd, "@MobileNo", DbType.String, bDOperatorContactPersonEntity.MobileNo);
                db.AddInParameter(cmd, "@Fax", DbType.String, bDOperatorContactPersonEntity.Fax);
                db.AddInParameter(cmd, "@Email", DbType.String, bDOperatorContactPersonEntity.Email);
                db.AddInParameter(cmd, "@WebLink", DbType.String, bDOperatorContactPersonEntity.WebLink);

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

        IList<Int64> IBDOperatorContactPersonDataAccess.Add(IList<BDOperatorContactPersonEntity> bDOperatorContactPersonEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (BDOperatorContactPersonEntity bDOperatorContactPersonEntity in bDOperatorContactPersonEntityList)
            {
                returnCode = (this as IBDOperatorContactPersonDataAccess).Add(bDOperatorContactPersonEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IBDOperatorContactPersonDataAccess.Update(BDOperatorContactPersonEntity bDOperatorContactPersonEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(bDOperatorContactPersonEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(bDOperatorContactPersonEntity, filterExpression, option);
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

        private Int64 Update(BDOperatorContactPersonEntity bDOperatorContactPersonEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDOperatorContactPerson_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@OperatorContactPersonID", DbType.Int64, bDOperatorContactPersonEntity.OperatorContactPersonID);
                Database.AddInParameter(cmd, "@OperatorID", DbType.Int64, bDOperatorContactPersonEntity.OperatorID);
                Database.AddInParameter(cmd, "@ZoneID", DbType.Int64, bDOperatorContactPersonEntity.ZoneID);
                Database.AddInParameter(cmd, "@Name", DbType.String, bDOperatorContactPersonEntity.Name);
                Database.AddInParameter(cmd, "@ZoneDesignationID", DbType.Int64, bDOperatorContactPersonEntity.ZoneDesignationID);
                Database.AddInParameter(cmd, "@ID", DbType.String, bDOperatorContactPersonEntity.ID);
                Database.AddInParameter(cmd, "@Phone", DbType.String, bDOperatorContactPersonEntity.Phone);
                Database.AddInParameter(cmd, "@MobileNo", DbType.String, bDOperatorContactPersonEntity.MobileNo);
                Database.AddInParameter(cmd, "@Fax", DbType.String, bDOperatorContactPersonEntity.Fax);
                Database.AddInParameter(cmd, "@Email", DbType.String, bDOperatorContactPersonEntity.Email);
                Database.AddInParameter(cmd, "@WebLink", DbType.String, bDOperatorContactPersonEntity.WebLink);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDOperatorContactPersonEntity already exists. Please specify another BDOperatorContactPersonEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDOperatorContactPersonEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDOperatorContactPersonEntity already exists. Please specify another BDOperatorContactPersonEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(BDOperatorContactPersonEntity bDOperatorContactPersonEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDOperatorContactPerson_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@OperatorContactPersonID", DbType.Int64, bDOperatorContactPersonEntity.OperatorContactPersonID);
                db.AddInParameter(cmd, "@OperatorID", DbType.Int64, bDOperatorContactPersonEntity.OperatorID);
                db.AddInParameter(cmd, "@ZoneID", DbType.Int64, bDOperatorContactPersonEntity.ZoneID);
                db.AddInParameter(cmd, "@Name", DbType.String, bDOperatorContactPersonEntity.Name);
                db.AddInParameter(cmd, "@ZoneDesignationID", DbType.Int64, bDOperatorContactPersonEntity.ZoneDesignationID);
                db.AddInParameter(cmd, "@ID", DbType.String, bDOperatorContactPersonEntity.ID);
                db.AddInParameter(cmd, "@Phone", DbType.String, bDOperatorContactPersonEntity.Phone);
                db.AddInParameter(cmd, "@MobileNo", DbType.String, bDOperatorContactPersonEntity.MobileNo);
                db.AddInParameter(cmd, "@Fax", DbType.String, bDOperatorContactPersonEntity.Fax);
                db.AddInParameter(cmd, "@Email", DbType.String, bDOperatorContactPersonEntity.Email);
                db.AddInParameter(cmd, "@WebLink", DbType.String, bDOperatorContactPersonEntity.WebLink);

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

        IList<Int64> IBDOperatorContactPersonDataAccess.Update(IList<BDOperatorContactPersonEntity> bDOperatorContactPersonEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (BDOperatorContactPersonEntity bDOperatorContactPersonEntity in bDOperatorContactPersonEntityList)
            {
                returnCode = (this as IBDOperatorContactPersonDataAccess).Update(bDOperatorContactPersonEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IBDOperatorContactPersonDataAccess.Delete(BDOperatorContactPersonEntity bDOperatorContactPersonEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(bDOperatorContactPersonEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(bDOperatorContactPersonEntity, filterExpression, option);
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

        private Int64 Delete(BDOperatorContactPersonEntity bDOperatorContactPersonEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDOperatorContactPerson_SET";

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
                                throw new ArgumentException("BDOperatorContactPersonEntity already exists. Please specify another BDOperatorContactPersonEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDOperatorContactPersonEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDOperatorContactPersonEntity already exists. Please specify another BDOperatorContactPersonEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(BDOperatorContactPersonEntity bDOperatorContactPersonEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDOperatorContactPerson_SET";

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

        IList<Int64> IBDOperatorContactPersonDataAccess.Delete(IList<BDOperatorContactPersonEntity> bDOperatorContactPersonEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (BDOperatorContactPersonEntity bDOperatorContactPersonEntity in bDOperatorContactPersonEntityList)
            {
                returnCode = (this as IBDOperatorContactPersonDataAccess).Delete(bDOperatorContactPersonEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<BDOperatorContactPersonEntity> IBDOperatorContactPersonDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDOperatorContactPerson_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<BDOperatorContactPersonEntity> list = CreateEntityBuilder<BDOperatorContactPersonEntity>().BuildEntities(reader);

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

        DataTable IBDOperatorContactPersonDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDOperatorContactPerson_GET";

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
