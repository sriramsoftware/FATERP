// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Jul-2013, 11:20:53




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
    internal sealed partial class ACBankAccountPaymentItemDataAccess : BaseDataAccess, IACBankAccountPaymentItemDataAccess
    {
        #region Constructors

        public ACBankAccountPaymentItemDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ACBankAccountPaymentItemEntity> CreateEntityBuilder<ACBankAccountPaymentItemEntity>()
        {
            return (new ACBankAccountPaymentItemBuilder()) as IEntityBuilder<ACBankAccountPaymentItemEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IACBankAccountPaymentItemDataAccess.Add(ACBankAccountPaymentItemEntity aCBankAccountPaymentItemEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(aCBankAccountPaymentItemEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(aCBankAccountPaymentItemEntity, option);
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

        private Int64 Add(ACBankAccountPaymentItemEntity aCBankAccountPaymentItemEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACBankAccountPaymentItem_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "BankAccountPaymentItemID");

                Database.AddInParameter(cmd, "@BankAccountPaymentID", DbType.Int64, aCBankAccountPaymentItemEntity.BankAccountPaymentID);	
                Database.AddInParameter(cmd, "@AccountID", DbType.Int64, aCBankAccountPaymentItemEntity.AccountID);	
                Database.AddInParameter(cmd, "@DimensionID", DbType.Int64, aCBankAccountPaymentItemEntity.DimensionID);	
                Database.AddInParameter(cmd, "@ItemID", DbType.Int64, aCBankAccountPaymentItemEntity.ItemID);	
                Database.AddInParameter(cmd, "@Amount", DbType.Decimal, aCBankAccountPaymentItemEntity.Amount);	
                Database.AddInParameter(cmd, "@Memo", DbType.String, aCBankAccountPaymentItemEntity.Memo);	
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, aCBankAccountPaymentItemEntity.ProjectID);	
                Database.AddInParameter(cmd, "@RequisitionID", DbType.Int64, aCBankAccountPaymentItemEntity.RequisitionID);	
                Database.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, aCBankAccountPaymentItemEntity.WorkOrderID);	
                Database.AddInParameter(cmd, "@BillID", DbType.Int64, aCBankAccountPaymentItemEntity.BillID);	
                Database.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, aCBankAccountPaymentItemEntity.ProjectFloorID);	
                Database.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, aCBankAccountPaymentItemEntity.ProjectFloorUnitID);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACBankAccountPaymentItemEntity already exists. Please specify another ACBankAccountPaymentItemEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACBankAccountPaymentItemEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACBankAccountPaymentItemEntity already exists. Please specify another ACBankAccountPaymentItemEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(ACBankAccountPaymentItemEntity aCBankAccountPaymentItemEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACBankAccountPaymentItem_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "BankAccountPaymentItemID", db);

                db.AddInParameter(cmd, "@BankAccountPaymentID", DbType.Int64, aCBankAccountPaymentItemEntity.BankAccountPaymentID);
                db.AddInParameter(cmd, "@AccountID", DbType.Int64, aCBankAccountPaymentItemEntity.AccountID);
                db.AddInParameter(cmd, "@DimensionID", DbType.Int64, aCBankAccountPaymentItemEntity.DimensionID);
                db.AddInParameter(cmd, "@ItemID", DbType.Int64, aCBankAccountPaymentItemEntity.ItemID);
                db.AddInParameter(cmd, "@Amount", DbType.Decimal, aCBankAccountPaymentItemEntity.Amount);
                db.AddInParameter(cmd, "@Memo", DbType.String, aCBankAccountPaymentItemEntity.Memo);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, aCBankAccountPaymentItemEntity.ProjectID);
                db.AddInParameter(cmd, "@RequisitionID", DbType.Int64, aCBankAccountPaymentItemEntity.RequisitionID);
                db.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, aCBankAccountPaymentItemEntity.WorkOrderID);
                db.AddInParameter(cmd, "@BillID", DbType.Int64, aCBankAccountPaymentItemEntity.BillID);
                db.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, aCBankAccountPaymentItemEntity.ProjectFloorID);
                db.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, aCBankAccountPaymentItemEntity.ProjectFloorUnitID);

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

        IList<Int64> IACBankAccountPaymentItemDataAccess.Add(IList<ACBankAccountPaymentItemEntity> aCBankAccountPaymentItemEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (ACBankAccountPaymentItemEntity aCBankAccountPaymentItemEntity in aCBankAccountPaymentItemEntityList)
            {
                returnCode = (this as IACBankAccountPaymentItemDataAccess).Add(aCBankAccountPaymentItemEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IACBankAccountPaymentItemDataAccess.Update(ACBankAccountPaymentItemEntity aCBankAccountPaymentItemEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(aCBankAccountPaymentItemEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(aCBankAccountPaymentItemEntity, filterExpression, option);
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

        private Int64 Update(ACBankAccountPaymentItemEntity aCBankAccountPaymentItemEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACBankAccountPaymentItem_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@BankAccountPaymentItemID", DbType.Int64, aCBankAccountPaymentItemEntity.BankAccountPaymentItemID);
                Database.AddInParameter(cmd, "@BankAccountPaymentID", DbType.Int64, aCBankAccountPaymentItemEntity.BankAccountPaymentID);
                Database.AddInParameter(cmd, "@AccountID", DbType.Int64, aCBankAccountPaymentItemEntity.AccountID);
                Database.AddInParameter(cmd, "@DimensionID", DbType.Int64, aCBankAccountPaymentItemEntity.DimensionID);
                Database.AddInParameter(cmd, "@ItemID", DbType.Int64, aCBankAccountPaymentItemEntity.ItemID);
                Database.AddInParameter(cmd, "@Amount", DbType.Decimal, aCBankAccountPaymentItemEntity.Amount);
                Database.AddInParameter(cmd, "@Memo", DbType.String, aCBankAccountPaymentItemEntity.Memo);
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, aCBankAccountPaymentItemEntity.ProjectID);
                Database.AddInParameter(cmd, "@RequisitionID", DbType.Int64, aCBankAccountPaymentItemEntity.RequisitionID);
                Database.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, aCBankAccountPaymentItemEntity.WorkOrderID);
                Database.AddInParameter(cmd, "@BillID", DbType.Int64, aCBankAccountPaymentItemEntity.BillID);
                Database.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, aCBankAccountPaymentItemEntity.ProjectFloorID);
                Database.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, aCBankAccountPaymentItemEntity.ProjectFloorUnitID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACBankAccountPaymentItemEntity already exists. Please specify another ACBankAccountPaymentItemEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACBankAccountPaymentItemEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACBankAccountPaymentItemEntity already exists. Please specify another ACBankAccountPaymentItemEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(ACBankAccountPaymentItemEntity aCBankAccountPaymentItemEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACBankAccountPaymentItem_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@BankAccountPaymentItemID", DbType.Int64, aCBankAccountPaymentItemEntity.BankAccountPaymentItemID);
                db.AddInParameter(cmd, "@BankAccountPaymentID", DbType.Int64, aCBankAccountPaymentItemEntity.BankAccountPaymentID);
                db.AddInParameter(cmd, "@AccountID", DbType.Int64, aCBankAccountPaymentItemEntity.AccountID);
                db.AddInParameter(cmd, "@DimensionID", DbType.Int64, aCBankAccountPaymentItemEntity.DimensionID);
                db.AddInParameter(cmd, "@ItemID", DbType.Int64, aCBankAccountPaymentItemEntity.ItemID);
                db.AddInParameter(cmd, "@Amount", DbType.Decimal, aCBankAccountPaymentItemEntity.Amount);
                db.AddInParameter(cmd, "@Memo", DbType.String, aCBankAccountPaymentItemEntity.Memo);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, aCBankAccountPaymentItemEntity.ProjectID);
                db.AddInParameter(cmd, "@RequisitionID", DbType.Int64, aCBankAccountPaymentItemEntity.RequisitionID);
                db.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, aCBankAccountPaymentItemEntity.WorkOrderID);
                db.AddInParameter(cmd, "@BillID", DbType.Int64, aCBankAccountPaymentItemEntity.BillID);
                db.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, aCBankAccountPaymentItemEntity.ProjectFloorID);
                db.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, aCBankAccountPaymentItemEntity.ProjectFloorUnitID);

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

        IList<Int64> IACBankAccountPaymentItemDataAccess.Update(IList<ACBankAccountPaymentItemEntity> aCBankAccountPaymentItemEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (ACBankAccountPaymentItemEntity aCBankAccountPaymentItemEntity in aCBankAccountPaymentItemEntityList)
            {
                returnCode = (this as IACBankAccountPaymentItemDataAccess).Update(aCBankAccountPaymentItemEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IACBankAccountPaymentItemDataAccess.Delete(ACBankAccountPaymentItemEntity aCBankAccountPaymentItemEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(aCBankAccountPaymentItemEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(aCBankAccountPaymentItemEntity, filterExpression, option);
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

        private Int64 Delete(ACBankAccountPaymentItemEntity aCBankAccountPaymentItemEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACBankAccountPaymentItem_SET";

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
                                throw new ArgumentException("ACBankAccountPaymentItemEntity already exists. Please specify another ACBankAccountPaymentItemEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACBankAccountPaymentItemEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACBankAccountPaymentItemEntity already exists. Please specify another ACBankAccountPaymentItemEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(ACBankAccountPaymentItemEntity aCBankAccountPaymentItemEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACBankAccountPaymentItem_SET";

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

        IList<Int64> IACBankAccountPaymentItemDataAccess.Delete(IList<ACBankAccountPaymentItemEntity> aCBankAccountPaymentItemEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (ACBankAccountPaymentItemEntity aCBankAccountPaymentItemEntity in aCBankAccountPaymentItemEntityList)
            {
                returnCode = (this as IACBankAccountPaymentItemDataAccess).Delete(aCBankAccountPaymentItemEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<ACBankAccountPaymentItemEntity> IACBankAccountPaymentItemDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACBankAccountPaymentItem_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ACBankAccountPaymentItemEntity> list = CreateEntityBuilder<ACBankAccountPaymentItemEntity>().BuildEntities(reader);

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

        DataTable IACBankAccountPaymentItemDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACBankAccountPaymentItem_GET";

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
