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
    internal sealed partial class HREmployeeEducationDataAccess : BaseDataAccess, IHREmployeeEducationDataAccess
    {
        #region Constructors

        public HREmployeeEducationDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREmployeeEducationEntity> CreateEntityBuilder<HREmployeeEducationEntity>()
        {
            return (new HREmployeeEducationBuilder()) as IEntityBuilder<HREmployeeEducationEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IHREmployeeEducationDataAccess.Add(HREmployeeEducationEntity hREmployeeEducationEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(hREmployeeEducationEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(hREmployeeEducationEntity, option);
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

        private Int64 Add(HREmployeeEducationEntity hREmployeeEducationEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeEducation_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "EmployeeEducationID");

                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeEducationEntity.EmployeeID);	
                Database.AddInParameter(cmd, "@EducationalDegreeID", DbType.Int64, hREmployeeEducationEntity.EducationalDegreeID);	
                Database.AddInParameter(cmd, "@PassedYear", DbType.Int32, hREmployeeEducationEntity.PassedYear);	
                Database.AddInParameter(cmd, "@Session", DbType.String, hREmployeeEducationEntity.Session);	
                Database.AddInParameter(cmd, "@Result", DbType.String, hREmployeeEducationEntity.Result);	
                Database.AddInParameter(cmd, "@ResultOutOf", DbType.String, hREmployeeEducationEntity.ResultOutOf);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeeEducationEntity.Remarks);	
                Database.AddInParameter(cmd, "@IsCompleted", DbType.Boolean, hREmployeeEducationEntity.IsCompleted);	
                Database.AddInParameter(cmd, "@IsLastAcquired", DbType.Boolean, hREmployeeEducationEntity.IsLastAcquired);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeEducationEntity already exists. Please specify another HREmployeeEducationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeEducationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeEducationEntity already exists. Please specify another HREmployeeEducationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(HREmployeeEducationEntity hREmployeeEducationEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeEducation_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "EmployeeEducationID", db);

                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeEducationEntity.EmployeeID);
                db.AddInParameter(cmd, "@EducationalDegreeID", DbType.Int64, hREmployeeEducationEntity.EducationalDegreeID);
                db.AddInParameter(cmd, "@PassedYear", DbType.Int32, hREmployeeEducationEntity.PassedYear);
                db.AddInParameter(cmd, "@Session", DbType.String, hREmployeeEducationEntity.Session);
                db.AddInParameter(cmd, "@Result", DbType.String, hREmployeeEducationEntity.Result);
                db.AddInParameter(cmd, "@ResultOutOf", DbType.String, hREmployeeEducationEntity.ResultOutOf);
                db.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeeEducationEntity.Remarks);
                db.AddInParameter(cmd, "@IsCompleted", DbType.Boolean, hREmployeeEducationEntity.IsCompleted);
                db.AddInParameter(cmd, "@IsLastAcquired", DbType.Boolean, hREmployeeEducationEntity.IsLastAcquired);

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

        IList<Int64> IHREmployeeEducationDataAccess.Add(IList<HREmployeeEducationEntity> hREmployeeEducationEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (HREmployeeEducationEntity hREmployeeEducationEntity in hREmployeeEducationEntityList)
            {
                returnCode = (this as IHREmployeeEducationDataAccess).Add(hREmployeeEducationEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IHREmployeeEducationDataAccess.Update(HREmployeeEducationEntity hREmployeeEducationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(hREmployeeEducationEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(hREmployeeEducationEntity, filterExpression, option);
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

        private Int64 Update(HREmployeeEducationEntity hREmployeeEducationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeEducation_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@EmployeeEducationID", DbType.Int64, hREmployeeEducationEntity.EmployeeEducationID);
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeEducationEntity.EmployeeID);
                Database.AddInParameter(cmd, "@EducationalDegreeID", DbType.Int64, hREmployeeEducationEntity.EducationalDegreeID);
                Database.AddInParameter(cmd, "@PassedYear", DbType.Int32, hREmployeeEducationEntity.PassedYear);
                Database.AddInParameter(cmd, "@Session", DbType.String, hREmployeeEducationEntity.Session);
                Database.AddInParameter(cmd, "@Result", DbType.String, hREmployeeEducationEntity.Result);
                Database.AddInParameter(cmd, "@ResultOutOf", DbType.String, hREmployeeEducationEntity.ResultOutOf);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeeEducationEntity.Remarks);
                Database.AddInParameter(cmd, "@IsCompleted", DbType.Boolean, hREmployeeEducationEntity.IsCompleted);
                Database.AddInParameter(cmd, "@IsLastAcquired", DbType.Boolean, hREmployeeEducationEntity.IsLastAcquired);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeEducationEntity already exists. Please specify another HREmployeeEducationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeEducationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeEducationEntity already exists. Please specify another HREmployeeEducationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(HREmployeeEducationEntity hREmployeeEducationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeEducation_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@EmployeeEducationID", DbType.Int64, hREmployeeEducationEntity.EmployeeEducationID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeEducationEntity.EmployeeID);
                db.AddInParameter(cmd, "@EducationalDegreeID", DbType.Int64, hREmployeeEducationEntity.EducationalDegreeID);
                db.AddInParameter(cmd, "@PassedYear", DbType.Int32, hREmployeeEducationEntity.PassedYear);
                db.AddInParameter(cmd, "@Session", DbType.String, hREmployeeEducationEntity.Session);
                db.AddInParameter(cmd, "@Result", DbType.String, hREmployeeEducationEntity.Result);
                db.AddInParameter(cmd, "@ResultOutOf", DbType.String, hREmployeeEducationEntity.ResultOutOf);
                db.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeeEducationEntity.Remarks);
                db.AddInParameter(cmd, "@IsCompleted", DbType.Boolean, hREmployeeEducationEntity.IsCompleted);
                db.AddInParameter(cmd, "@IsLastAcquired", DbType.Boolean, hREmployeeEducationEntity.IsLastAcquired);

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

        IList<Int64> IHREmployeeEducationDataAccess.Update(IList<HREmployeeEducationEntity> hREmployeeEducationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (HREmployeeEducationEntity hREmployeeEducationEntity in hREmployeeEducationEntityList)
            {
                returnCode = (this as IHREmployeeEducationDataAccess).Update(hREmployeeEducationEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IHREmployeeEducationDataAccess.Delete(HREmployeeEducationEntity hREmployeeEducationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(hREmployeeEducationEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(hREmployeeEducationEntity, filterExpression, option);
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

        private Int64 Delete(HREmployeeEducationEntity hREmployeeEducationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeEducation_SET";

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
                                throw new ArgumentException("HREmployeeEducationEntity already exists. Please specify another HREmployeeEducationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeEducationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeEducationEntity already exists. Please specify another HREmployeeEducationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(HREmployeeEducationEntity hREmployeeEducationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeEducation_SET";

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

        IList<Int64> IHREmployeeEducationDataAccess.Delete(IList<HREmployeeEducationEntity> hREmployeeEducationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (HREmployeeEducationEntity hREmployeeEducationEntity in hREmployeeEducationEntityList)
            {
                returnCode = (this as IHREmployeeEducationDataAccess).Delete(hREmployeeEducationEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<HREmployeeEducationEntity> IHREmployeeEducationDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeEducation_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREmployeeEducationEntity> list = CreateEntityBuilder<HREmployeeEducationEntity>().BuildEntities(reader);

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

        DataTable IHREmployeeEducationDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeEducation_GET";

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
