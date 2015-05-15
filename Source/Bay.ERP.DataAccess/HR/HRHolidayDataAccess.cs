// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




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
    internal sealed partial class HRHolidayDataAccess : BaseDataAccess, IHRHolidayDataAccess
    {
        #region Constructors

        public HRHolidayDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HRHolidayEntity> CreateEntityBuilder<HRHolidayEntity>()
        {
            return (new HRHolidayBuilder()) as IEntityBuilder<HRHolidayEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IHRHolidayDataAccess.Add(HRHolidayEntity hRHolidayEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(hRHolidayEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(hRHolidayEntity, option);
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

        private Int64 Add(HRHolidayEntity hRHolidayEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRHoliday_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "HolidayID");

                Database.AddInParameter(cmd, "@HolidayCategoryID", DbType.Int64, hRHolidayEntity.HolidayCategoryID);	
                Database.AddInParameter(cmd, "@Name", DbType.String, hRHolidayEntity.Name);	
                Database.AddInParameter(cmd, "@HolidayDate", DbType.DateTime, hRHolidayEntity.HolidayDate);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, hRHolidayEntity.Remarks);	
                Database.AddInParameter(cmd, "@HolidayAppliedStatusID", DbType.Int64, hRHolidayEntity.HolidayAppliedStatusID);
                Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, hRHolidayEntity.FiscalYearID);

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HRHolidayEntity already exists. Please specify another HRHolidayEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HRHolidayEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HRHolidayEntity already exists. Please specify another HRHolidayEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(HRHolidayEntity hRHolidayEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRHoliday_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "HolidayID", db);

                db.AddInParameter(cmd, "@HolidayCategoryID", DbType.Int64, hRHolidayEntity.HolidayCategoryID);
                db.AddInParameter(cmd, "@Name", DbType.String, hRHolidayEntity.Name);
                db.AddInParameter(cmd, "@HolidayDate", DbType.DateTime, hRHolidayEntity.HolidayDate);
                db.AddInParameter(cmd, "@Remarks", DbType.String, hRHolidayEntity.Remarks);
                db.AddInParameter(cmd, "@HolidayAppliedStatusID", DbType.Int64, hRHolidayEntity.HolidayAppliedStatusID);
                db.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, hRHolidayEntity.FiscalYearID);

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

        IList<Int64> IHRHolidayDataAccess.Add(IList<HRHolidayEntity> hRHolidayEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (HRHolidayEntity hRHolidayEntity in hRHolidayEntityList)
            {
                returnCode = (this as IHRHolidayDataAccess).Add(hRHolidayEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IHRHolidayDataAccess.Update(HRHolidayEntity hRHolidayEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(hRHolidayEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(hRHolidayEntity, filterExpression, option);
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

        private Int64 Update(HRHolidayEntity hRHolidayEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRHoliday_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@HolidayID", DbType.Int64, hRHolidayEntity.HolidayID);
                Database.AddInParameter(cmd, "@HolidayCategoryID", DbType.Int64, hRHolidayEntity.HolidayCategoryID);
                Database.AddInParameter(cmd, "@Name", DbType.String, hRHolidayEntity.Name);
                Database.AddInParameter(cmd, "@HolidayDate", DbType.DateTime, hRHolidayEntity.HolidayDate);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, hRHolidayEntity.Remarks);
                Database.AddInParameter(cmd, "@HolidayAppliedStatusID", DbType.Int64, hRHolidayEntity.HolidayAppliedStatusID);
                Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, hRHolidayEntity.FiscalYearID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HRHolidayEntity already exists. Please specify another HRHolidayEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HRHolidayEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HRHolidayEntity already exists. Please specify another HRHolidayEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(HRHolidayEntity hRHolidayEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRHoliday_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@HolidayID", DbType.Int64, hRHolidayEntity.HolidayID);
                db.AddInParameter(cmd, "@HolidayCategoryID", DbType.Int64, hRHolidayEntity.HolidayCategoryID);
                db.AddInParameter(cmd, "@Name", DbType.String, hRHolidayEntity.Name);
                db.AddInParameter(cmd, "@HolidayDate", DbType.DateTime, hRHolidayEntity.HolidayDate);
                db.AddInParameter(cmd, "@Remarks", DbType.String, hRHolidayEntity.Remarks);
                db.AddInParameter(cmd, "@HolidayAppliedStatusID", DbType.Int64, hRHolidayEntity.HolidayAppliedStatusID);
                db.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, hRHolidayEntity.FiscalYearID);

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

        IList<Int64> IHRHolidayDataAccess.Update(IList<HRHolidayEntity> hRHolidayEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (HRHolidayEntity hRHolidayEntity in hRHolidayEntityList)
            {
                returnCode = (this as IHRHolidayDataAccess).Update(hRHolidayEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IHRHolidayDataAccess.Delete(HRHolidayEntity hRHolidayEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(hRHolidayEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(hRHolidayEntity, filterExpression, option);
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

        private Int64 Delete(HRHolidayEntity hRHolidayEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRHoliday_SET";

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
                                throw new ArgumentException("HRHolidayEntity already exists. Please specify another HRHolidayEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HRHolidayEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HRHolidayEntity already exists. Please specify another HRHolidayEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(HRHolidayEntity hRHolidayEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRHoliday_SET";

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

        IList<Int64> IHRHolidayDataAccess.Delete(IList<HRHolidayEntity> hRHolidayEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (HRHolidayEntity hRHolidayEntity in hRHolidayEntityList)
            {
                returnCode = (this as IHRHolidayDataAccess).Delete(hRHolidayEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<HRHolidayEntity> IHRHolidayDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HRHoliday_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HRHolidayEntity> list = CreateEntityBuilder<HRHolidayEntity>().BuildEntities(reader);

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

        DataTable IHRHolidayDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HRHoliday_GET";

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
