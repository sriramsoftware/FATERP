// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Dec-2013, 01:17:51




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
    internal sealed partial class HREmployeeEvaluationReportDataAccess : BaseDataAccess, IHREmployeeEvaluationReportDataAccess
    {
        #region Constructors

        public HREmployeeEvaluationReportDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREmployeeEvaluationReportEntity> CreateEntityBuilder<HREmployeeEvaluationReportEntity>()
        {
            return (new HREmployeeEvaluationReportBuilder()) as IEntityBuilder<HREmployeeEvaluationReportEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IHREmployeeEvaluationReportDataAccess.Add(HREmployeeEvaluationReportEntity hREmployeeEvaluationReportEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(hREmployeeEvaluationReportEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(hREmployeeEvaluationReportEntity, option);
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

        private Int64 Add(HREmployeeEvaluationReportEntity hREmployeeEvaluationReportEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeEvaluationReport_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "EmployeeEvaluationReportID");

                Database.AddInParameter(cmd, "@SessionID", DbType.Int64, hREmployeeEvaluationReportEntity.SessionID);	
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeEvaluationReportEntity.EmployeeID);	
                Database.AddInParameter(cmd, "@Title1", DbType.String, hREmployeeEvaluationReportEntity.Title1);	
                Database.AddInParameter(cmd, "@Title1Column1", DbType.String, hREmployeeEvaluationReportEntity.Title1Column1);	
                Database.AddInParameter(cmd, "@Title1Column2", DbType.String, hREmployeeEvaluationReportEntity.Title1Column2);	
                Database.AddInParameter(cmd, "@Title1Category1", DbType.String, hREmployeeEvaluationReportEntity.Title1Category1);	
                Database.AddInParameter(cmd, "@Title1Category1Column1Value", DbType.String, hREmployeeEvaluationReportEntity.Title1Category1Column1Value);	
                Database.AddInParameter(cmd, "@Title1Category1Column2Value", DbType.String, hREmployeeEvaluationReportEntity.Title1Category1Column2Value);	
                Database.AddInParameter(cmd, "@Title1Category2", DbType.String, hREmployeeEvaluationReportEntity.Title1Category2);	
                Database.AddInParameter(cmd, "@Title1Category2Column1Value", DbType.String, hREmployeeEvaluationReportEntity.Title1Category2Column1Value);	
                Database.AddInParameter(cmd, "@Title1Category2Column2Value", DbType.String, hREmployeeEvaluationReportEntity.Title1Category2Column2Value);	
                Database.AddInParameter(cmd, "@Title2", DbType.String, hREmployeeEvaluationReportEntity.Title2);	
                Database.AddInParameter(cmd, "@Title2Column1", DbType.String, hREmployeeEvaluationReportEntity.Title2Column1);	
                Database.AddInParameter(cmd, "@Title2Category1", DbType.String, hREmployeeEvaluationReportEntity.Title2Category1);	
                Database.AddInParameter(cmd, "@Title2Category1Column1Value", DbType.String, hREmployeeEvaluationReportEntity.Title2Category1Column1Value);	
                Database.AddInParameter(cmd, "@Title2Category1Column2Value", DbType.String, hREmployeeEvaluationReportEntity.Title2Category1Column2Value);	
                Database.AddInParameter(cmd, "@Title2Category2", DbType.String, hREmployeeEvaluationReportEntity.Title2Category2);	
                Database.AddInParameter(cmd, "@Title2Category2Column1Value", DbType.String, hREmployeeEvaluationReportEntity.Title2Category2Column1Value);	
                Database.AddInParameter(cmd, "@Title2Category2Column2Value", DbType.String, hREmployeeEvaluationReportEntity.Title2Category2Column2Value);	
                Database.AddInParameter(cmd, "@Title3", DbType.String, hREmployeeEvaluationReportEntity.Title3);	
                Database.AddInParameter(cmd, "@Title3Column1", DbType.String, hREmployeeEvaluationReportEntity.Title3Column1);	
                Database.AddInParameter(cmd, "@Title3Category1", DbType.String, hREmployeeEvaluationReportEntity.Title3Category1);	
                Database.AddInParameter(cmd, "@Title3Category1Column1Value", DbType.String, hREmployeeEvaluationReportEntity.Title3Category1Column1Value);	
                Database.AddInParameter(cmd, "@Title3Category1Column2Value", DbType.String, hREmployeeEvaluationReportEntity.Title3Category1Column2Value);	
                Database.AddInParameter(cmd, "@Title3Category2", DbType.String, hREmployeeEvaluationReportEntity.Title3Category2);	
                Database.AddInParameter(cmd, "@Title3Category2Column1Value", DbType.String, hREmployeeEvaluationReportEntity.Title3Category2Column1Value);	
                Database.AddInParameter(cmd, "@Title3Category2Column2Value", DbType.String, hREmployeeEvaluationReportEntity.Title3Category2Column2Value);	
                Database.AddInParameter(cmd, "@HRReportQuestion1Title", DbType.String, hREmployeeEvaluationReportEntity.HRReportQuestion1Title);	
                Database.AddInParameter(cmd, "@HRReportQuestion1TitleValue", DbType.String, hREmployeeEvaluationReportEntity.HRReportQuestion1TitleValue);	
                Database.AddInParameter(cmd, "@SupervisorNumberValue", DbType.Decimal, hREmployeeEvaluationReportEntity.SupervisorNumberValue);	
                Database.AddInParameter(cmd, "@ScoreValue", DbType.Decimal, hREmployeeEvaluationReportEntity.ScoreValue);	
                Database.AddInParameter(cmd, "@DeducationValue", DbType.Decimal, hREmployeeEvaluationReportEntity.DeducationValue);	
                Database.AddInParameter(cmd, "@ActualScoreValue", DbType.Decimal, hREmployeeEvaluationReportEntity.ActualScoreValue);	
                Database.AddInParameter(cmd, "@Title4", DbType.String, hREmployeeEvaluationReportEntity.Title4);	
                Database.AddInParameter(cmd, "@Title4Column1Value", DbType.Decimal, hREmployeeEvaluationReportEntity.Title4Column1Value);	
                Database.AddInParameter(cmd, "@HRReportQuestion2Title", DbType.String, hREmployeeEvaluationReportEntity.HRReportQuestion2Title);	
                Database.AddInParameter(cmd, "@HRReportQuestion2TitleValue", DbType.String, hREmployeeEvaluationReportEntity.HRReportQuestion2TitleValue);	
                Database.AddInParameter(cmd, "@Extra1", DbType.String, hREmployeeEvaluationReportEntity.Extra1);	
                Database.AddInParameter(cmd, "@Extra2", DbType.Decimal, hREmployeeEvaluationReportEntity.Extra2);	
                Database.AddInParameter(cmd, "@Extra3", DbType.String, hREmployeeEvaluationReportEntity.Extra3);	
                Database.AddInParameter(cmd, "@Extra4", DbType.Decimal, hREmployeeEvaluationReportEntity.Extra4);
                Database.AddInParameter(cmd, "@Extra5", DbType.String, hREmployeeEvaluationReportEntity.Extra5);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeEvaluationReportEntity already exists. Please specify another HREmployeeEvaluationReportEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeEvaluationReportEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeEvaluationReportEntity already exists. Please specify another HREmployeeEvaluationReportEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(HREmployeeEvaluationReportEntity hREmployeeEvaluationReportEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeEvaluationReport_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "EmployeeEvaluationReportID", db);

                db.AddInParameter(cmd, "@SessionID", DbType.Int64, hREmployeeEvaluationReportEntity.SessionID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeEvaluationReportEntity.EmployeeID);
                db.AddInParameter(cmd, "@Title1", DbType.String, hREmployeeEvaluationReportEntity.Title1);
                db.AddInParameter(cmd, "@Title1Column1", DbType.String, hREmployeeEvaluationReportEntity.Title1Column1);
                db.AddInParameter(cmd, "@Title1Column2", DbType.String, hREmployeeEvaluationReportEntity.Title1Column2);
                db.AddInParameter(cmd, "@Title1Category1", DbType.String, hREmployeeEvaluationReportEntity.Title1Category1);
                db.AddInParameter(cmd, "@Title1Category1Column1Value", DbType.String, hREmployeeEvaluationReportEntity.Title1Category1Column1Value);
                db.AddInParameter(cmd, "@Title1Category1Column2Value", DbType.String, hREmployeeEvaluationReportEntity.Title1Category1Column2Value);
                db.AddInParameter(cmd, "@Title1Category2", DbType.String, hREmployeeEvaluationReportEntity.Title1Category2);
                db.AddInParameter(cmd, "@Title1Category2Column1Value", DbType.String, hREmployeeEvaluationReportEntity.Title1Category2Column1Value);
                db.AddInParameter(cmd, "@Title1Category2Column2Value", DbType.String, hREmployeeEvaluationReportEntity.Title1Category2Column2Value);
                db.AddInParameter(cmd, "@Title2", DbType.String, hREmployeeEvaluationReportEntity.Title2);
                db.AddInParameter(cmd, "@Title2Column1", DbType.String, hREmployeeEvaluationReportEntity.Title2Column1);
                db.AddInParameter(cmd, "@Title2Category1", DbType.String, hREmployeeEvaluationReportEntity.Title2Category1);
                db.AddInParameter(cmd, "@Title2Category1Column1Value", DbType.String, hREmployeeEvaluationReportEntity.Title2Category1Column1Value);
                db.AddInParameter(cmd, "@Title2Category1Column2Value", DbType.String, hREmployeeEvaluationReportEntity.Title2Category1Column2Value);
                db.AddInParameter(cmd, "@Title2Category2", DbType.String, hREmployeeEvaluationReportEntity.Title2Category2);
                db.AddInParameter(cmd, "@Title2Category2Column1Value", DbType.String, hREmployeeEvaluationReportEntity.Title2Category2Column1Value);
                db.AddInParameter(cmd, "@Title2Category2Column2Value", DbType.String, hREmployeeEvaluationReportEntity.Title2Category2Column2Value);
                db.AddInParameter(cmd, "@Title3", DbType.String, hREmployeeEvaluationReportEntity.Title3);
                db.AddInParameter(cmd, "@Title3Column1", DbType.String, hREmployeeEvaluationReportEntity.Title3Column1);
                db.AddInParameter(cmd, "@Title3Category1", DbType.String, hREmployeeEvaluationReportEntity.Title3Category1);
                db.AddInParameter(cmd, "@Title3Category1Column1Value", DbType.String, hREmployeeEvaluationReportEntity.Title3Category1Column1Value);
                db.AddInParameter(cmd, "@Title3Category1Column2Value", DbType.String, hREmployeeEvaluationReportEntity.Title3Category1Column2Value);
                db.AddInParameter(cmd, "@Title3Category2", DbType.String, hREmployeeEvaluationReportEntity.Title3Category2);
                db.AddInParameter(cmd, "@Title3Category2Column1Value", DbType.String, hREmployeeEvaluationReportEntity.Title3Category2Column1Value);
                db.AddInParameter(cmd, "@Title3Category2Column2Value", DbType.String, hREmployeeEvaluationReportEntity.Title3Category2Column2Value);
                db.AddInParameter(cmd, "@HRReportQuestion1Title", DbType.String, hREmployeeEvaluationReportEntity.HRReportQuestion1Title);
                db.AddInParameter(cmd, "@HRReportQuestion1TitleValue", DbType.String, hREmployeeEvaluationReportEntity.HRReportQuestion1TitleValue);
                db.AddInParameter(cmd, "@SupervisorNumberValue", DbType.Decimal, hREmployeeEvaluationReportEntity.SupervisorNumberValue);
                db.AddInParameter(cmd, "@ScoreValue", DbType.Decimal, hREmployeeEvaluationReportEntity.ScoreValue);
                db.AddInParameter(cmd, "@DeducationValue", DbType.Decimal, hREmployeeEvaluationReportEntity.DeducationValue);
                db.AddInParameter(cmd, "@ActualScoreValue", DbType.Decimal, hREmployeeEvaluationReportEntity.ActualScoreValue);
                db.AddInParameter(cmd, "@Title4", DbType.String, hREmployeeEvaluationReportEntity.Title4);
                db.AddInParameter(cmd, "@Title4Column1Value", DbType.Decimal, hREmployeeEvaluationReportEntity.Title4Column1Value);
                db.AddInParameter(cmd, "@HRReportQuestion2Title", DbType.String, hREmployeeEvaluationReportEntity.HRReportQuestion2Title);
                db.AddInParameter(cmd, "@HRReportQuestion2TitleValue", DbType.String, hREmployeeEvaluationReportEntity.HRReportQuestion2TitleValue);
                db.AddInParameter(cmd, "@Extra1", DbType.String, hREmployeeEvaluationReportEntity.Extra1);
                db.AddInParameter(cmd, "@Extra2", DbType.Decimal, hREmployeeEvaluationReportEntity.Extra2);
                db.AddInParameter(cmd, "@Extra3", DbType.String, hREmployeeEvaluationReportEntity.Extra3);
                db.AddInParameter(cmd, "@Extra4", DbType.Decimal, hREmployeeEvaluationReportEntity.Extra4);
                db.AddInParameter(cmd, "@Extra5", DbType.String, hREmployeeEvaluationReportEntity.Extra5);

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

        IList<Int64> IHREmployeeEvaluationReportDataAccess.Add(IList<HREmployeeEvaluationReportEntity> hREmployeeEvaluationReportEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (HREmployeeEvaluationReportEntity hREmployeeEvaluationReportEntity in hREmployeeEvaluationReportEntityList)
            {
                returnCode = (this as IHREmployeeEvaluationReportDataAccess).Add(hREmployeeEvaluationReportEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IHREmployeeEvaluationReportDataAccess.Update(HREmployeeEvaluationReportEntity hREmployeeEvaluationReportEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(hREmployeeEvaluationReportEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(hREmployeeEvaluationReportEntity, filterExpression, option);
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

        private Int64 Update(HREmployeeEvaluationReportEntity hREmployeeEvaluationReportEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeEvaluationReport_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@EmployeeEvaluationReportID", DbType.Int64, hREmployeeEvaluationReportEntity.EmployeeEvaluationReportID);
                Database.AddInParameter(cmd, "@SessionID", DbType.Int64, hREmployeeEvaluationReportEntity.SessionID);
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeEvaluationReportEntity.EmployeeID);
                Database.AddInParameter(cmd, "@Title1", DbType.String, hREmployeeEvaluationReportEntity.Title1);
                Database.AddInParameter(cmd, "@Title1Column1", DbType.String, hREmployeeEvaluationReportEntity.Title1Column1);
                Database.AddInParameter(cmd, "@Title1Column2", DbType.String, hREmployeeEvaluationReportEntity.Title1Column2);
                Database.AddInParameter(cmd, "@Title1Category1", DbType.String, hREmployeeEvaluationReportEntity.Title1Category1);
                Database.AddInParameter(cmd, "@Title1Category1Column1Value", DbType.String, hREmployeeEvaluationReportEntity.Title1Category1Column1Value);
                Database.AddInParameter(cmd, "@Title1Category1Column2Value", DbType.String, hREmployeeEvaluationReportEntity.Title1Category1Column2Value);
                Database.AddInParameter(cmd, "@Title1Category2", DbType.String, hREmployeeEvaluationReportEntity.Title1Category2);
                Database.AddInParameter(cmd, "@Title1Category2Column1Value", DbType.String, hREmployeeEvaluationReportEntity.Title1Category2Column1Value);
                Database.AddInParameter(cmd, "@Title1Category2Column2Value", DbType.String, hREmployeeEvaluationReportEntity.Title1Category2Column2Value);
                Database.AddInParameter(cmd, "@Title2", DbType.String, hREmployeeEvaluationReportEntity.Title2);
                Database.AddInParameter(cmd, "@Title2Column1", DbType.String, hREmployeeEvaluationReportEntity.Title2Column1);
                Database.AddInParameter(cmd, "@Title2Category1", DbType.String, hREmployeeEvaluationReportEntity.Title2Category1);
                Database.AddInParameter(cmd, "@Title2Category1Column1Value", DbType.String, hREmployeeEvaluationReportEntity.Title2Category1Column1Value);
                Database.AddInParameter(cmd, "@Title2Category1Column2Value", DbType.String, hREmployeeEvaluationReportEntity.Title2Category1Column2Value);
                Database.AddInParameter(cmd, "@Title2Category2", DbType.String, hREmployeeEvaluationReportEntity.Title2Category2);
                Database.AddInParameter(cmd, "@Title2Category2Column1Value", DbType.String, hREmployeeEvaluationReportEntity.Title2Category2Column1Value);
                Database.AddInParameter(cmd, "@Title2Category2Column2Value", DbType.String, hREmployeeEvaluationReportEntity.Title2Category2Column2Value);
                Database.AddInParameter(cmd, "@Title3", DbType.String, hREmployeeEvaluationReportEntity.Title3);
                Database.AddInParameter(cmd, "@Title3Column1", DbType.String, hREmployeeEvaluationReportEntity.Title3Column1);
                Database.AddInParameter(cmd, "@Title3Category1", DbType.String, hREmployeeEvaluationReportEntity.Title3Category1);
                Database.AddInParameter(cmd, "@Title3Category1Column1Value", DbType.String, hREmployeeEvaluationReportEntity.Title3Category1Column1Value);
                Database.AddInParameter(cmd, "@Title3Category1Column2Value", DbType.String, hREmployeeEvaluationReportEntity.Title3Category1Column2Value);
                Database.AddInParameter(cmd, "@Title3Category2", DbType.String, hREmployeeEvaluationReportEntity.Title3Category2);
                Database.AddInParameter(cmd, "@Title3Category2Column1Value", DbType.String, hREmployeeEvaluationReportEntity.Title3Category2Column1Value);
                Database.AddInParameter(cmd, "@Title3Category2Column2Value", DbType.String, hREmployeeEvaluationReportEntity.Title3Category2Column2Value);
                Database.AddInParameter(cmd, "@HRReportQuestion1Title", DbType.String, hREmployeeEvaluationReportEntity.HRReportQuestion1Title);
                Database.AddInParameter(cmd, "@HRReportQuestion1TitleValue", DbType.String, hREmployeeEvaluationReportEntity.HRReportQuestion1TitleValue);
                Database.AddInParameter(cmd, "@SupervisorNumberValue", DbType.Decimal, hREmployeeEvaluationReportEntity.SupervisorNumberValue);
                Database.AddInParameter(cmd, "@ScoreValue", DbType.Decimal, hREmployeeEvaluationReportEntity.ScoreValue);
                Database.AddInParameter(cmd, "@DeducationValue", DbType.Decimal, hREmployeeEvaluationReportEntity.DeducationValue);
                Database.AddInParameter(cmd, "@ActualScoreValue", DbType.Decimal, hREmployeeEvaluationReportEntity.ActualScoreValue);
                Database.AddInParameter(cmd, "@Title4", DbType.String, hREmployeeEvaluationReportEntity.Title4);
                Database.AddInParameter(cmd, "@Title4Column1Value", DbType.Decimal, hREmployeeEvaluationReportEntity.Title4Column1Value);
                Database.AddInParameter(cmd, "@HRReportQuestion2Title", DbType.String, hREmployeeEvaluationReportEntity.HRReportQuestion2Title);
                Database.AddInParameter(cmd, "@HRReportQuestion2TitleValue", DbType.String, hREmployeeEvaluationReportEntity.HRReportQuestion2TitleValue);
                Database.AddInParameter(cmd, "@Extra1", DbType.String, hREmployeeEvaluationReportEntity.Extra1);
                Database.AddInParameter(cmd, "@Extra2", DbType.Decimal, hREmployeeEvaluationReportEntity.Extra2);
                Database.AddInParameter(cmd, "@Extra3", DbType.String, hREmployeeEvaluationReportEntity.Extra3);
                Database.AddInParameter(cmd, "@Extra4", DbType.Decimal, hREmployeeEvaluationReportEntity.Extra4);
                Database.AddInParameter(cmd, "@Extra5", DbType.String, hREmployeeEvaluationReportEntity.Extra5);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeEvaluationReportEntity already exists. Please specify another HREmployeeEvaluationReportEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeEvaluationReportEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeEvaluationReportEntity already exists. Please specify another HREmployeeEvaluationReportEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(HREmployeeEvaluationReportEntity hREmployeeEvaluationReportEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeEvaluationReport_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@EmployeeEvaluationReportID", DbType.Int64, hREmployeeEvaluationReportEntity.EmployeeEvaluationReportID);
                db.AddInParameter(cmd, "@SessionID", DbType.Int64, hREmployeeEvaluationReportEntity.SessionID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeEvaluationReportEntity.EmployeeID);
                db.AddInParameter(cmd, "@Title1", DbType.String, hREmployeeEvaluationReportEntity.Title1);
                db.AddInParameter(cmd, "@Title1Column1", DbType.String, hREmployeeEvaluationReportEntity.Title1Column1);
                db.AddInParameter(cmd, "@Title1Column2", DbType.String, hREmployeeEvaluationReportEntity.Title1Column2);
                db.AddInParameter(cmd, "@Title1Category1", DbType.String, hREmployeeEvaluationReportEntity.Title1Category1);
                db.AddInParameter(cmd, "@Title1Category1Column1Value", DbType.String, hREmployeeEvaluationReportEntity.Title1Category1Column1Value);
                db.AddInParameter(cmd, "@Title1Category1Column2Value", DbType.String, hREmployeeEvaluationReportEntity.Title1Category1Column2Value);
                db.AddInParameter(cmd, "@Title1Category2", DbType.String, hREmployeeEvaluationReportEntity.Title1Category2);
                db.AddInParameter(cmd, "@Title1Category2Column1Value", DbType.String, hREmployeeEvaluationReportEntity.Title1Category2Column1Value);
                db.AddInParameter(cmd, "@Title1Category2Column2Value", DbType.String, hREmployeeEvaluationReportEntity.Title1Category2Column2Value);
                db.AddInParameter(cmd, "@Title2", DbType.String, hREmployeeEvaluationReportEntity.Title2);
                db.AddInParameter(cmd, "@Title2Column1", DbType.String, hREmployeeEvaluationReportEntity.Title2Column1);
                db.AddInParameter(cmd, "@Title2Category1", DbType.String, hREmployeeEvaluationReportEntity.Title2Category1);
                db.AddInParameter(cmd, "@Title2Category1Column1Value", DbType.String, hREmployeeEvaluationReportEntity.Title2Category1Column1Value);
                db.AddInParameter(cmd, "@Title2Category1Column2Value", DbType.String, hREmployeeEvaluationReportEntity.Title2Category1Column2Value);
                db.AddInParameter(cmd, "@Title2Category2", DbType.String, hREmployeeEvaluationReportEntity.Title2Category2);
                db.AddInParameter(cmd, "@Title2Category2Column1Value", DbType.String, hREmployeeEvaluationReportEntity.Title2Category2Column1Value);
                db.AddInParameter(cmd, "@Title2Category2Column2Value", DbType.String, hREmployeeEvaluationReportEntity.Title2Category2Column2Value);
                db.AddInParameter(cmd, "@Title3", DbType.String, hREmployeeEvaluationReportEntity.Title3);
                db.AddInParameter(cmd, "@Title3Column1", DbType.String, hREmployeeEvaluationReportEntity.Title3Column1);
                db.AddInParameter(cmd, "@Title3Category1", DbType.String, hREmployeeEvaluationReportEntity.Title3Category1);
                db.AddInParameter(cmd, "@Title3Category1Column1Value", DbType.String, hREmployeeEvaluationReportEntity.Title3Category1Column1Value);
                db.AddInParameter(cmd, "@Title3Category1Column2Value", DbType.String, hREmployeeEvaluationReportEntity.Title3Category1Column2Value);
                db.AddInParameter(cmd, "@Title3Category2", DbType.String, hREmployeeEvaluationReportEntity.Title3Category2);
                db.AddInParameter(cmd, "@Title3Category2Column1Value", DbType.String, hREmployeeEvaluationReportEntity.Title3Category2Column1Value);
                db.AddInParameter(cmd, "@Title3Category2Column2Value", DbType.String, hREmployeeEvaluationReportEntity.Title3Category2Column2Value);
                db.AddInParameter(cmd, "@HRReportQuestion1Title", DbType.String, hREmployeeEvaluationReportEntity.HRReportQuestion1Title);
                db.AddInParameter(cmd, "@HRReportQuestion1TitleValue", DbType.String, hREmployeeEvaluationReportEntity.HRReportQuestion1TitleValue);
                db.AddInParameter(cmd, "@SupervisorNumberValue", DbType.Decimal, hREmployeeEvaluationReportEntity.SupervisorNumberValue);
                db.AddInParameter(cmd, "@ScoreValue", DbType.Decimal, hREmployeeEvaluationReportEntity.ScoreValue);
                db.AddInParameter(cmd, "@DeducationValue", DbType.Decimal, hREmployeeEvaluationReportEntity.DeducationValue);
                db.AddInParameter(cmd, "@ActualScoreValue", DbType.Decimal, hREmployeeEvaluationReportEntity.ActualScoreValue);
                db.AddInParameter(cmd, "@Title4", DbType.String, hREmployeeEvaluationReportEntity.Title4);
                db.AddInParameter(cmd, "@Title4Column1Value", DbType.Decimal, hREmployeeEvaluationReportEntity.Title4Column1Value);
                db.AddInParameter(cmd, "@HRReportQuestion2Title", DbType.String, hREmployeeEvaluationReportEntity.HRReportQuestion2Title);
                db.AddInParameter(cmd, "@HRReportQuestion2TitleValue", DbType.String, hREmployeeEvaluationReportEntity.HRReportQuestion2TitleValue);
                db.AddInParameter(cmd, "@Extra1", DbType.String, hREmployeeEvaluationReportEntity.Extra1);
                db.AddInParameter(cmd, "@Extra2", DbType.Decimal, hREmployeeEvaluationReportEntity.Extra2);
                db.AddInParameter(cmd, "@Extra3", DbType.String, hREmployeeEvaluationReportEntity.Extra3);
                db.AddInParameter(cmd, "@Extra4", DbType.Decimal, hREmployeeEvaluationReportEntity.Extra4);
                db.AddInParameter(cmd, "@Extra5", DbType.String, hREmployeeEvaluationReportEntity.Extra5);

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

        IList<Int64> IHREmployeeEvaluationReportDataAccess.Update(IList<HREmployeeEvaluationReportEntity> hREmployeeEvaluationReportEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (HREmployeeEvaluationReportEntity hREmployeeEvaluationReportEntity in hREmployeeEvaluationReportEntityList)
            {
                returnCode = (this as IHREmployeeEvaluationReportDataAccess).Update(hREmployeeEvaluationReportEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IHREmployeeEvaluationReportDataAccess.Delete(HREmployeeEvaluationReportEntity hREmployeeEvaluationReportEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(hREmployeeEvaluationReportEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(hREmployeeEvaluationReportEntity, filterExpression, option);
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

        private Int64 Delete(HREmployeeEvaluationReportEntity hREmployeeEvaluationReportEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeEvaluationReport_SET";

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
                                throw new ArgumentException("HREmployeeEvaluationReportEntity already exists. Please specify another HREmployeeEvaluationReportEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeEvaluationReportEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeEvaluationReportEntity already exists. Please specify another HREmployeeEvaluationReportEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(HREmployeeEvaluationReportEntity hREmployeeEvaluationReportEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeEvaluationReport_SET";

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

        IList<Int64> IHREmployeeEvaluationReportDataAccess.Delete(IList<HREmployeeEvaluationReportEntity> hREmployeeEvaluationReportEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (HREmployeeEvaluationReportEntity hREmployeeEvaluationReportEntity in hREmployeeEvaluationReportEntityList)
            {
                returnCode = (this as IHREmployeeEvaluationReportDataAccess).Delete(hREmployeeEvaluationReportEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<HREmployeeEvaluationReportEntity> IHREmployeeEvaluationReportDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeEvaluationReport_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREmployeeEvaluationReportEntity> list = CreateEntityBuilder<HREmployeeEvaluationReportEntity>().BuildEntities(reader);

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

        DataTable IHREmployeeEvaluationReportDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeEvaluationReport_GET";

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
