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
    public sealed partial class MDSchedulePriorityFacade : IMDSchedulePriorityFacade
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

        public MDSchedulePriorityFacade()
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

        ~MDSchedulePriorityFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDSchedulePriorityFacade.Add(MDSchedulePriorityEntity mDSchedulePriorityEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDSchedulePriorityDataAccess().Add(mDSchedulePriorityEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDSchedulePriorityFacade.Update(MDSchedulePriorityEntity mDSchedulePriorityEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDSchedulePriorityDataAccess().Update(mDSchedulePriorityEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDSchedulePriorityFacade.Delete(MDSchedulePriorityEntity mDSchedulePriorityEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDSchedulePriorityDataAccess().Delete(mDSchedulePriorityEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDSchedulePriorityFacade.Add(IList<MDSchedulePriorityEntity> mDSchedulePriorityEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDSchedulePriorityDataAccess().Add(mDSchedulePriorityEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDSchedulePriorityFacade.Update(IList<MDSchedulePriorityEntity> mDSchedulePriorityEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDSchedulePriorityDataAccess().Update(mDSchedulePriorityEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDSchedulePriorityFacade.Delete(IList<MDSchedulePriorityEntity> mDSchedulePriorityEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDSchedulePriorityDataAccess().Delete(mDSchedulePriorityEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDSchedulePriorityEntity> IMDSchedulePriorityFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDSchedulePriorityDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDSchedulePriorityFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDSchedulePriorityDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDSchedulePriorityEntity IMDSchedulePriorityFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDSchedulePriorityEntity.FLD_NAME_SchedulePriorityID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDSchedulePriorityDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
