// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jun-2013, 02:07:00




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
    internal sealed partial class BDProjectParkingDataAccess : BaseDataAccess, IBDProjectParkingDataAccess
    {
        #region Constructors

        public BDProjectParkingDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<BDProjectParkingEntity> CreateEntityBuilder<BDProjectParkingEntity>()
        {
            return (new BDProjectParkingBuilder()) as IEntityBuilder<BDProjectParkingEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IBDProjectParkingDataAccess.Add(BDProjectParkingEntity bDProjectParkingEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(bDProjectParkingEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(bDProjectParkingEntity, option);
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

        private Int64 Add(BDProjectParkingEntity bDProjectParkingEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectParking_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ProjectParkingID");

                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectParkingEntity.ProjectID);	
                Database.AddInParameter(cmd, "@Ground", DbType.Decimal, bDProjectParkingEntity.Ground);	
                Database.AddInParameter(cmd, "@LowerGround", DbType.Decimal, bDProjectParkingEntity.LowerGround);	
                Database.AddInParameter(cmd, "@Basement1", DbType.Decimal, bDProjectParkingEntity.Basement1);	
                Database.AddInParameter(cmd, "@Basement2", DbType.Decimal, bDProjectParkingEntity.Basement2);	
                Database.AddInParameter(cmd, "@Basement3", DbType.Decimal, bDProjectParkingEntity.Basement3);	
                Database.AddInParameter(cmd, "@Basement4", DbType.Decimal, bDProjectParkingEntity.Basement4);	
                Database.AddInParameter(cmd, "@Basement5", DbType.Decimal, bDProjectParkingEntity.Basement5);	
                Database.AddInParameter(cmd, "@Basement6", DbType.Decimal, bDProjectParkingEntity.Basement6);	
                Database.AddInParameter(cmd, "@Outdoor", DbType.Decimal, bDProjectParkingEntity.Outdoor);	
                Database.AddInParameter(cmd, "@Total", DbType.Decimal, bDProjectParkingEntity.Total);	
                Database.AddInParameter(cmd, "@GuestParking", DbType.Decimal, bDProjectParkingEntity.GuestParking);	
                Database.AddInParameter(cmd, "@DisableParking", DbType.Decimal, bDProjectParkingEntity.DisableParking);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDProjectParkingEntity already exists. Please specify another BDProjectParkingEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectParkingEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectParkingEntity already exists. Please specify another BDProjectParkingEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(BDProjectParkingEntity bDProjectParkingEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectParking_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ProjectParkingID", db);

                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectParkingEntity.ProjectID);
                db.AddInParameter(cmd, "@Ground", DbType.Decimal, bDProjectParkingEntity.Ground);
                db.AddInParameter(cmd, "@LowerGround", DbType.Decimal, bDProjectParkingEntity.LowerGround);
                db.AddInParameter(cmd, "@Basement1", DbType.Decimal, bDProjectParkingEntity.Basement1);
                db.AddInParameter(cmd, "@Basement2", DbType.Decimal, bDProjectParkingEntity.Basement2);
                db.AddInParameter(cmd, "@Basement3", DbType.Decimal, bDProjectParkingEntity.Basement3);
                db.AddInParameter(cmd, "@Basement4", DbType.Decimal, bDProjectParkingEntity.Basement4);
                db.AddInParameter(cmd, "@Basement5", DbType.Decimal, bDProjectParkingEntity.Basement5);
                db.AddInParameter(cmd, "@Basement6", DbType.Decimal, bDProjectParkingEntity.Basement6);
                db.AddInParameter(cmd, "@Outdoor", DbType.Decimal, bDProjectParkingEntity.Outdoor);
                db.AddInParameter(cmd, "@Total", DbType.Decimal, bDProjectParkingEntity.Total);
                db.AddInParameter(cmd, "@GuestParking", DbType.Decimal, bDProjectParkingEntity.GuestParking);
                db.AddInParameter(cmd, "@DisableParking", DbType.Decimal, bDProjectParkingEntity.DisableParking);

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

        IList<Int64> IBDProjectParkingDataAccess.Add(IList<BDProjectParkingEntity> bDProjectParkingEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (BDProjectParkingEntity bDProjectParkingEntity in bDProjectParkingEntityList)
            {
                returnCode = (this as IBDProjectParkingDataAccess).Add(bDProjectParkingEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IBDProjectParkingDataAccess.Update(BDProjectParkingEntity bDProjectParkingEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(bDProjectParkingEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(bDProjectParkingEntity, filterExpression, option);
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

        private Int64 Update(BDProjectParkingEntity bDProjectParkingEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectParking_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ProjectParkingID", DbType.Int64, bDProjectParkingEntity.ProjectParkingID);
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectParkingEntity.ProjectID);
                Database.AddInParameter(cmd, "@Ground", DbType.Decimal, bDProjectParkingEntity.Ground);
                Database.AddInParameter(cmd, "@LowerGround", DbType.Decimal, bDProjectParkingEntity.LowerGround);
                Database.AddInParameter(cmd, "@Basement1", DbType.Decimal, bDProjectParkingEntity.Basement1);
                Database.AddInParameter(cmd, "@Basement2", DbType.Decimal, bDProjectParkingEntity.Basement2);
                Database.AddInParameter(cmd, "@Basement3", DbType.Decimal, bDProjectParkingEntity.Basement3);
                Database.AddInParameter(cmd, "@Basement4", DbType.Decimal, bDProjectParkingEntity.Basement4);
                Database.AddInParameter(cmd, "@Basement5", DbType.Decimal, bDProjectParkingEntity.Basement5);
                Database.AddInParameter(cmd, "@Basement6", DbType.Decimal, bDProjectParkingEntity.Basement6);
                Database.AddInParameter(cmd, "@Outdoor", DbType.Decimal, bDProjectParkingEntity.Outdoor);
                Database.AddInParameter(cmd, "@Total", DbType.Decimal, bDProjectParkingEntity.Total);
                Database.AddInParameter(cmd, "@GuestParking", DbType.Decimal, bDProjectParkingEntity.GuestParking);
                Database.AddInParameter(cmd, "@DisableParking", DbType.Decimal, bDProjectParkingEntity.DisableParking);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDProjectParkingEntity already exists. Please specify another BDProjectParkingEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectParkingEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectParkingEntity already exists. Please specify another BDProjectParkingEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(BDProjectParkingEntity bDProjectParkingEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectParking_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ProjectParkingID", DbType.Int64, bDProjectParkingEntity.ProjectParkingID);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectParkingEntity.ProjectID);
                db.AddInParameter(cmd, "@Ground", DbType.Decimal, bDProjectParkingEntity.Ground);
                db.AddInParameter(cmd, "@LowerGround", DbType.Decimal, bDProjectParkingEntity.LowerGround);
                db.AddInParameter(cmd, "@Basement1", DbType.Decimal, bDProjectParkingEntity.Basement1);
                db.AddInParameter(cmd, "@Basement2", DbType.Decimal, bDProjectParkingEntity.Basement2);
                db.AddInParameter(cmd, "@Basement3", DbType.Decimal, bDProjectParkingEntity.Basement3);
                db.AddInParameter(cmd, "@Basement4", DbType.Decimal, bDProjectParkingEntity.Basement4);
                db.AddInParameter(cmd, "@Basement5", DbType.Decimal, bDProjectParkingEntity.Basement5);
                db.AddInParameter(cmd, "@Basement6", DbType.Decimal, bDProjectParkingEntity.Basement6);
                db.AddInParameter(cmd, "@Outdoor", DbType.Decimal, bDProjectParkingEntity.Outdoor);
                db.AddInParameter(cmd, "@Total", DbType.Decimal, bDProjectParkingEntity.Total);
                db.AddInParameter(cmd, "@GuestParking", DbType.Decimal, bDProjectParkingEntity.GuestParking);
                db.AddInParameter(cmd, "@DisableParking", DbType.Decimal, bDProjectParkingEntity.DisableParking);

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

        IList<Int64> IBDProjectParkingDataAccess.Update(IList<BDProjectParkingEntity> bDProjectParkingEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (BDProjectParkingEntity bDProjectParkingEntity in bDProjectParkingEntityList)
            {
                returnCode = (this as IBDProjectParkingDataAccess).Update(bDProjectParkingEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IBDProjectParkingDataAccess.Delete(BDProjectParkingEntity bDProjectParkingEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(bDProjectParkingEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(bDProjectParkingEntity, filterExpression, option);
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

        private Int64 Delete(BDProjectParkingEntity bDProjectParkingEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectParking_SET";

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
                                throw new ArgumentException("BDProjectParkingEntity already exists. Please specify another BDProjectParkingEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectParkingEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectParkingEntity already exists. Please specify another BDProjectParkingEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(BDProjectParkingEntity bDProjectParkingEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectParking_SET";

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

        IList<Int64> IBDProjectParkingDataAccess.Delete(IList<BDProjectParkingEntity> bDProjectParkingEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (BDProjectParkingEntity bDProjectParkingEntity in bDProjectParkingEntityList)
            {
                returnCode = (this as IBDProjectParkingDataAccess).Delete(bDProjectParkingEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<BDProjectParkingEntity> IBDProjectParkingDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDProjectParking_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<BDProjectParkingEntity> list = CreateEntityBuilder<BDProjectParkingEntity>().BuildEntities(reader);

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

        DataTable IBDProjectParkingDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDProjectParking_GET";

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
