// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Oct-2013, 02:28:24




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
    internal sealed partial class CMNEventDataAccess : BaseDataAccess, ICMNEventDataAccess
    {
        #region Constructors

        public CMNEventDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CMNEventEntity> CreateEntityBuilder<CMNEventEntity>()
        {
            return (new CMNEventBuilder()) as IEntityBuilder<CMNEventEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICMNEventDataAccess.Add(CMNEventEntity cMNEventEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cMNEventEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cMNEventEntity, option);
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

        private Int64 Add(CMNEventEntity cMNEventEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNEvent_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "EventID");

                Database.AddInParameter(cmd, "@EventIdentityCategoryID", DbType.Int64, cMNEventEntity.EventIdentityCategoryID);	
                Database.AddInParameter(cmd, "@EventCategoryID", DbType.Int64, cMNEventEntity.EventCategoryID);	
                Database.AddInParameter(cmd, "@ParentEventID", DbType.Int64, cMNEventEntity.ParentEventID);	
                Database.AddInParameter(cmd, "@ReferenceEventID", DbType.Int64, cMNEventEntity.ReferenceEventID);	
                Database.AddInParameter(cmd, "@EventReferenceNo", DbType.String, cMNEventEntity.EventReferenceNo);	
                Database.AddInParameter(cmd, "@Title", DbType.String, cMNEventEntity.Title);	
                Database.AddInParameter(cmd, "@Details", DbType.String, cMNEventEntity.Details);	
                Database.AddInParameter(cmd, "@Location", DbType.String, cMNEventEntity.Location);	
                Database.AddInParameter(cmd, "@EventLocationCategoryID", DbType.Int64, cMNEventEntity.EventLocationCategoryID);	
                Database.AddInParameter(cmd, "@LocationReferenceID", DbType.Int64, cMNEventEntity.LocationReferenceID);	
                Database.AddInParameter(cmd, "@WebsiteURL", DbType.String, cMNEventEntity.WebsiteURL);	
                Database.AddInParameter(cmd, "@TicketSellerURL", DbType.String, cMNEventEntity.TicketSellerURL);	
                Database.AddInParameter(cmd, "@YoutubeURL", DbType.String, cMNEventEntity.YoutubeURL);	
                Database.AddInParameter(cmd, "@TransitAndParkingInformation", DbType.String, cMNEventEntity.TransitAndParkingInformation);	
                Database.AddInParameter(cmd, "@EventOptionID", DbType.Int64, cMNEventEntity.EventOptionID);	
                Database.AddInParameter(cmd, "@CompletionPercentage", DbType.Decimal, cMNEventEntity.CompletionPercentage);	
                Database.AddInParameter(cmd, "@EventStatusID", DbType.Int64, cMNEventEntity.EventStatusID);	
                Database.AddInParameter(cmd, "@RepeatCategoryID", DbType.Int64, cMNEventEntity.RepeatCategoryID);	
                Database.AddInParameter(cmd, "@CreatedByMemberID", DbType.Int64, cMNEventEntity.CreatedByMemberID);	
                Database.AddInParameter(cmd, "@OwnerMemberID", DbType.Int64, cMNEventEntity.OwnerMemberID);	
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cMNEventEntity.CreateDate);	
                Database.AddInParameter(cmd, "@Duration", DbType.Decimal, cMNEventEntity.Duration);	
                Database.AddInParameter(cmd, "@ExpectedStartDate", DbType.DateTime, cMNEventEntity.ExpectedStartDate);	
                Database.AddInParameter(cmd, "@ExpectedEndDate", DbType.DateTime, cMNEventEntity.ExpectedEndDate);	
                Database.AddInParameter(cmd, "@ActualStartDate", DbType.DateTime, cMNEventEntity.ActualStartDate);	
                Database.AddInParameter(cmd, "@ActualEndDate", DbType.DateTime, cMNEventEntity.ActualEndDate);	
                Database.AddInParameter(cmd, "@IsAllDay", DbType.Boolean, cMNEventEntity.IsAllDay);	
                Database.AddInParameter(cmd, "@NotifyBeforeMin", DbType.Int32, cMNEventEntity.NotifyBeforeMin);	
                Database.AddInParameter(cmd, "@IsNotifyCompleted", DbType.Boolean, cMNEventEntity.IsNotifyCompleted);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cMNEventEntity.Remarks);	
                Database.AddInParameter(cmd, "@SharedSettingID", DbType.Int64, cMNEventEntity.SharedSettingID);	
                Database.AddInParameter(cmd, "@ModifiedDateTime", DbType.DateTime, cMNEventEntity.ModifiedDateTime);	
                Database.AddInParameter(cmd, "@IP", DbType.String, cMNEventEntity.IP);	
                Database.AddInParameter(cmd, "@IsOwnerGoing", DbType.Boolean, cMNEventEntity.IsOwnerGoing);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, cMNEventEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMNEventEntity already exists. Please specify another CMNEventEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMNEventEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMNEventEntity already exists. Please specify another CMNEventEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CMNEventEntity cMNEventEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNEvent_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "EventID", db);

                db.AddInParameter(cmd, "@EventIdentityCategoryID", DbType.Int64, cMNEventEntity.EventIdentityCategoryID);
                db.AddInParameter(cmd, "@EventCategoryID", DbType.Int64, cMNEventEntity.EventCategoryID);
                db.AddInParameter(cmd, "@ParentEventID", DbType.Int64, cMNEventEntity.ParentEventID);
                db.AddInParameter(cmd, "@ReferenceEventID", DbType.Int64, cMNEventEntity.ReferenceEventID);
                db.AddInParameter(cmd, "@EventReferenceNo", DbType.String, cMNEventEntity.EventReferenceNo);
                db.AddInParameter(cmd, "@Title", DbType.String, cMNEventEntity.Title);
                db.AddInParameter(cmd, "@Details", DbType.String, cMNEventEntity.Details);
                db.AddInParameter(cmd, "@Location", DbType.String, cMNEventEntity.Location);
                db.AddInParameter(cmd, "@EventLocationCategoryID", DbType.Int64, cMNEventEntity.EventLocationCategoryID);
                db.AddInParameter(cmd, "@LocationReferenceID", DbType.Int64, cMNEventEntity.LocationReferenceID);
                db.AddInParameter(cmd, "@WebsiteURL", DbType.String, cMNEventEntity.WebsiteURL);
                db.AddInParameter(cmd, "@TicketSellerURL", DbType.String, cMNEventEntity.TicketSellerURL);
                db.AddInParameter(cmd, "@YoutubeURL", DbType.String, cMNEventEntity.YoutubeURL);
                db.AddInParameter(cmd, "@TransitAndParkingInformation", DbType.String, cMNEventEntity.TransitAndParkingInformation);
                db.AddInParameter(cmd, "@EventOptionID", DbType.Int64, cMNEventEntity.EventOptionID);
                db.AddInParameter(cmd, "@CompletionPercentage", DbType.Decimal, cMNEventEntity.CompletionPercentage);
                db.AddInParameter(cmd, "@EventStatusID", DbType.Int64, cMNEventEntity.EventStatusID);
                db.AddInParameter(cmd, "@RepeatCategoryID", DbType.Int64, cMNEventEntity.RepeatCategoryID);
                db.AddInParameter(cmd, "@CreatedByMemberID", DbType.Int64, cMNEventEntity.CreatedByMemberID);
                db.AddInParameter(cmd, "@OwnerMemberID", DbType.Int64, cMNEventEntity.OwnerMemberID);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cMNEventEntity.CreateDate);
                db.AddInParameter(cmd, "@Duration", DbType.Decimal, cMNEventEntity.Duration);
                db.AddInParameter(cmd, "@ExpectedStartDate", DbType.DateTime, cMNEventEntity.ExpectedStartDate);
                db.AddInParameter(cmd, "@ExpectedEndDate", DbType.DateTime, cMNEventEntity.ExpectedEndDate);
                db.AddInParameter(cmd, "@ActualStartDate", DbType.DateTime, cMNEventEntity.ActualStartDate);
                db.AddInParameter(cmd, "@ActualEndDate", DbType.DateTime, cMNEventEntity.ActualEndDate);
                db.AddInParameter(cmd, "@IsAllDay", DbType.Boolean, cMNEventEntity.IsAllDay);
                db.AddInParameter(cmd, "@NotifyBeforeMin", DbType.Int32, cMNEventEntity.NotifyBeforeMin);
                db.AddInParameter(cmd, "@IsNotifyCompleted", DbType.Boolean, cMNEventEntity.IsNotifyCompleted);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cMNEventEntity.Remarks);
                db.AddInParameter(cmd, "@SharedSettingID", DbType.Int64, cMNEventEntity.SharedSettingID);
                db.AddInParameter(cmd, "@ModifiedDateTime", DbType.DateTime, cMNEventEntity.ModifiedDateTime);
                db.AddInParameter(cmd, "@IP", DbType.String, cMNEventEntity.IP);
                db.AddInParameter(cmd, "@IsOwnerGoing", DbType.Boolean, cMNEventEntity.IsOwnerGoing);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, cMNEventEntity.IsRemoved);

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

        IList<Int64> ICMNEventDataAccess.Add(IList<CMNEventEntity> cMNEventEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CMNEventEntity cMNEventEntity in cMNEventEntityList)
            {
                returnCode = (this as ICMNEventDataAccess).Add(cMNEventEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICMNEventDataAccess.Update(CMNEventEntity cMNEventEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cMNEventEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cMNEventEntity, filterExpression, option);
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

        private Int64 Update(CMNEventEntity cMNEventEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNEvent_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@EventID", DbType.Int64, cMNEventEntity.EventID);
                Database.AddInParameter(cmd, "@EventIdentityCategoryID", DbType.Int64, cMNEventEntity.EventIdentityCategoryID);
                Database.AddInParameter(cmd, "@EventCategoryID", DbType.Int64, cMNEventEntity.EventCategoryID);
                Database.AddInParameter(cmd, "@ParentEventID", DbType.Int64, cMNEventEntity.ParentEventID);
                Database.AddInParameter(cmd, "@ReferenceEventID", DbType.Int64, cMNEventEntity.ReferenceEventID);
                Database.AddInParameter(cmd, "@EventReferenceNo", DbType.String, cMNEventEntity.EventReferenceNo);
                Database.AddInParameter(cmd, "@Title", DbType.String, cMNEventEntity.Title);
                Database.AddInParameter(cmd, "@Details", DbType.String, cMNEventEntity.Details);
                Database.AddInParameter(cmd, "@Location", DbType.String, cMNEventEntity.Location);
                Database.AddInParameter(cmd, "@EventLocationCategoryID", DbType.Int64, cMNEventEntity.EventLocationCategoryID);
                Database.AddInParameter(cmd, "@LocationReferenceID", DbType.Int64, cMNEventEntity.LocationReferenceID);
                Database.AddInParameter(cmd, "@WebsiteURL", DbType.String, cMNEventEntity.WebsiteURL);
                Database.AddInParameter(cmd, "@TicketSellerURL", DbType.String, cMNEventEntity.TicketSellerURL);
                Database.AddInParameter(cmd, "@YoutubeURL", DbType.String, cMNEventEntity.YoutubeURL);
                Database.AddInParameter(cmd, "@TransitAndParkingInformation", DbType.String, cMNEventEntity.TransitAndParkingInformation);
                Database.AddInParameter(cmd, "@EventOptionID", DbType.Int64, cMNEventEntity.EventOptionID);
                Database.AddInParameter(cmd, "@CompletionPercentage", DbType.Decimal, cMNEventEntity.CompletionPercentage);
                Database.AddInParameter(cmd, "@EventStatusID", DbType.Int64, cMNEventEntity.EventStatusID);
                Database.AddInParameter(cmd, "@RepeatCategoryID", DbType.Int64, cMNEventEntity.RepeatCategoryID);
                Database.AddInParameter(cmd, "@CreatedByMemberID", DbType.Int64, cMNEventEntity.CreatedByMemberID);
                Database.AddInParameter(cmd, "@OwnerMemberID", DbType.Int64, cMNEventEntity.OwnerMemberID);
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cMNEventEntity.CreateDate);
                Database.AddInParameter(cmd, "@Duration", DbType.Decimal, cMNEventEntity.Duration);
                Database.AddInParameter(cmd, "@ExpectedStartDate", DbType.DateTime, cMNEventEntity.ExpectedStartDate);
                Database.AddInParameter(cmd, "@ExpectedEndDate", DbType.DateTime, cMNEventEntity.ExpectedEndDate);
                Database.AddInParameter(cmd, "@ActualStartDate", DbType.DateTime, cMNEventEntity.ActualStartDate);
                Database.AddInParameter(cmd, "@ActualEndDate", DbType.DateTime, cMNEventEntity.ActualEndDate);
                Database.AddInParameter(cmd, "@IsAllDay", DbType.Boolean, cMNEventEntity.IsAllDay);
                Database.AddInParameter(cmd, "@NotifyBeforeMin", DbType.Int32, cMNEventEntity.NotifyBeforeMin);
                Database.AddInParameter(cmd, "@IsNotifyCompleted", DbType.Boolean, cMNEventEntity.IsNotifyCompleted);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cMNEventEntity.Remarks);
                Database.AddInParameter(cmd, "@SharedSettingID", DbType.Int64, cMNEventEntity.SharedSettingID);
                Database.AddInParameter(cmd, "@ModifiedDateTime", DbType.DateTime, cMNEventEntity.ModifiedDateTime);
                Database.AddInParameter(cmd, "@IP", DbType.String, cMNEventEntity.IP);
                Database.AddInParameter(cmd, "@IsOwnerGoing", DbType.Boolean, cMNEventEntity.IsOwnerGoing);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, cMNEventEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMNEventEntity already exists. Please specify another CMNEventEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMNEventEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMNEventEntity already exists. Please specify another CMNEventEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CMNEventEntity cMNEventEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNEvent_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@EventID", DbType.Int64, cMNEventEntity.EventID);
                db.AddInParameter(cmd, "@EventIdentityCategoryID", DbType.Int64, cMNEventEntity.EventIdentityCategoryID);
                db.AddInParameter(cmd, "@EventCategoryID", DbType.Int64, cMNEventEntity.EventCategoryID);
                db.AddInParameter(cmd, "@ParentEventID", DbType.Int64, cMNEventEntity.ParentEventID);
                db.AddInParameter(cmd, "@ReferenceEventID", DbType.Int64, cMNEventEntity.ReferenceEventID);
                db.AddInParameter(cmd, "@EventReferenceNo", DbType.String, cMNEventEntity.EventReferenceNo);
                db.AddInParameter(cmd, "@Title", DbType.String, cMNEventEntity.Title);
                db.AddInParameter(cmd, "@Details", DbType.String, cMNEventEntity.Details);
                db.AddInParameter(cmd, "@Location", DbType.String, cMNEventEntity.Location);
                db.AddInParameter(cmd, "@EventLocationCategoryID", DbType.Int64, cMNEventEntity.EventLocationCategoryID);
                db.AddInParameter(cmd, "@LocationReferenceID", DbType.Int64, cMNEventEntity.LocationReferenceID);
                db.AddInParameter(cmd, "@WebsiteURL", DbType.String, cMNEventEntity.WebsiteURL);
                db.AddInParameter(cmd, "@TicketSellerURL", DbType.String, cMNEventEntity.TicketSellerURL);
                db.AddInParameter(cmd, "@YoutubeURL", DbType.String, cMNEventEntity.YoutubeURL);
                db.AddInParameter(cmd, "@TransitAndParkingInformation", DbType.String, cMNEventEntity.TransitAndParkingInformation);
                db.AddInParameter(cmd, "@EventOptionID", DbType.Int64, cMNEventEntity.EventOptionID);
                db.AddInParameter(cmd, "@CompletionPercentage", DbType.Decimal, cMNEventEntity.CompletionPercentage);
                db.AddInParameter(cmd, "@EventStatusID", DbType.Int64, cMNEventEntity.EventStatusID);
                db.AddInParameter(cmd, "@RepeatCategoryID", DbType.Int64, cMNEventEntity.RepeatCategoryID);
                db.AddInParameter(cmd, "@CreatedByMemberID", DbType.Int64, cMNEventEntity.CreatedByMemberID);
                db.AddInParameter(cmd, "@OwnerMemberID", DbType.Int64, cMNEventEntity.OwnerMemberID);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cMNEventEntity.CreateDate);
                db.AddInParameter(cmd, "@Duration", DbType.Decimal, cMNEventEntity.Duration);
                db.AddInParameter(cmd, "@ExpectedStartDate", DbType.DateTime, cMNEventEntity.ExpectedStartDate);
                db.AddInParameter(cmd, "@ExpectedEndDate", DbType.DateTime, cMNEventEntity.ExpectedEndDate);
                db.AddInParameter(cmd, "@ActualStartDate", DbType.DateTime, cMNEventEntity.ActualStartDate);
                db.AddInParameter(cmd, "@ActualEndDate", DbType.DateTime, cMNEventEntity.ActualEndDate);
                db.AddInParameter(cmd, "@IsAllDay", DbType.Boolean, cMNEventEntity.IsAllDay);
                db.AddInParameter(cmd, "@NotifyBeforeMin", DbType.Int32, cMNEventEntity.NotifyBeforeMin);
                db.AddInParameter(cmd, "@IsNotifyCompleted", DbType.Boolean, cMNEventEntity.IsNotifyCompleted);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cMNEventEntity.Remarks);
                db.AddInParameter(cmd, "@SharedSettingID", DbType.Int64, cMNEventEntity.SharedSettingID);
                db.AddInParameter(cmd, "@ModifiedDateTime", DbType.DateTime, cMNEventEntity.ModifiedDateTime);
                db.AddInParameter(cmd, "@IP", DbType.String, cMNEventEntity.IP);
                db.AddInParameter(cmd, "@IsOwnerGoing", DbType.Boolean, cMNEventEntity.IsOwnerGoing);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, cMNEventEntity.IsRemoved);

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

        IList<Int64> ICMNEventDataAccess.Update(IList<CMNEventEntity> cMNEventEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CMNEventEntity cMNEventEntity in cMNEventEntityList)
            {
                returnCode = (this as ICMNEventDataAccess).Update(cMNEventEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICMNEventDataAccess.Delete(CMNEventEntity cMNEventEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cMNEventEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cMNEventEntity, filterExpression, option);
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

        private Int64 Delete(CMNEventEntity cMNEventEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNEvent_SET";

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
                                throw new ArgumentException("CMNEventEntity already exists. Please specify another CMNEventEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMNEventEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMNEventEntity already exists. Please specify another CMNEventEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CMNEventEntity cMNEventEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMNEvent_SET";

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

        IList<Int64> ICMNEventDataAccess.Delete(IList<CMNEventEntity> cMNEventEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CMNEventEntity cMNEventEntity in cMNEventEntityList)
            {
                returnCode = (this as ICMNEventDataAccess).Delete(cMNEventEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CMNEventEntity> ICMNEventDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMNEvent_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CMNEventEntity> list = CreateEntityBuilder<CMNEventEntity>().BuildEntities(reader);

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

        DataTable ICMNEventDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMNEvent_GET";

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
