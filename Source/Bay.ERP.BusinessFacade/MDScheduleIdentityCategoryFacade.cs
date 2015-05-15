// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;
using System.Diagnostics;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.DataAccess;
using Bay.ERP.BusinessFacade;
using Bay.ERP.Common.Shared;
using Bay.ERP.Common.Helper;

namespace Bay.ERP.BusinessFacade
{
    public sealed partial class MDScheduleIdentityCategoryFacade : IMDScheduleIdentityCategoryFacade
    {

        #region Instance Variables

        private bool _isDisposed;
        private Context _currentContext;

        private BaseDataAccessFactory _dataAccessFactory;

        #endregion

        #region Private Properties

        private Context CurrentContext
        {
            [DebuggerStepThrough()]
            get
            {
                if (_currentContext == null)
                {
                    _currentContext = new Context();
                }

                return _currentContext;
            }
        }

        private BaseDataAccessFactory DataAccessFactory
        {
            [DebuggerStepThrough()]
            get
            {
                if (_dataAccessFactory == null)
                {
                    _dataAccessFactory = BaseDataAccessFactory.Create(CurrentContext);
                }

                return _dataAccessFactory;
            }
        }

        #endregion

        #region Constructer & Destructor

        public MDScheduleIdentityCategoryFacade()
            : base()
        {
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    if (_currentContext != null)
                    {
                        _currentContext.Dispose();
                    }
                }
            }

            _isDisposed = true;
        }

        ~MDScheduleIdentityCategoryFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDScheduleIdentityCategoryFacade.Add(MDScheduleIdentityCategoryEntity mDScheduleIdentityCategoryEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDScheduleIdentityCategoryDataAccess().Add(mDScheduleIdentityCategoryEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDScheduleIdentityCategoryFacade.Update(MDScheduleIdentityCategoryEntity mDScheduleIdentityCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDScheduleIdentityCategoryDataAccess().Update(mDScheduleIdentityCategoryEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDScheduleIdentityCategoryFacade.Delete(MDScheduleIdentityCategoryEntity mDScheduleIdentityCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDScheduleIdentityCategoryDataAccess().Delete(mDScheduleIdentityCategoryEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDScheduleIdentityCategoryFacade.Add(IList<MDScheduleIdentityCategoryEntity> mDScheduleIdentityCategoryEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDScheduleIdentityCategoryDataAccess().Add(mDScheduleIdentityCategoryEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDScheduleIdentityCategoryFacade.Update(IList<MDScheduleIdentityCategoryEntity> mDScheduleIdentityCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDScheduleIdentityCategoryDataAccess().Update(mDScheduleIdentityCategoryEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDScheduleIdentityCategoryFacade.Delete(IList<MDScheduleIdentityCategoryEntity> mDScheduleIdentityCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDScheduleIdentityCategoryDataAccess().Delete(mDScheduleIdentityCategoryEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDScheduleIdentityCategoryEntity> IMDScheduleIdentityCategoryFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDScheduleIdentityCategoryDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDScheduleIdentityCategoryFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDScheduleIdentityCategoryDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDScheduleIdentityCategoryEntity IMDScheduleIdentityCategoryFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDScheduleIdentityCategoryEntity.FLD_NAME_ScheduleIdentityCategoryID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDScheduleIdentityCategoryDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
