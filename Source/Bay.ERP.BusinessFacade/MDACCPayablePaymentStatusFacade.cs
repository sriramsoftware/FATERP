// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Dec-2012, 08:03:28




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
    public sealed partial class MDACCPayablePaymentStatusFacade : IMDACCPayablePaymentStatusFacade
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

        public MDACCPayablePaymentStatusFacade()
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

        ~MDACCPayablePaymentStatusFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDACCPayablePaymentStatusFacade.Add(MDACCPayablePaymentStatusEntity mDACCPayablePaymentStatusEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDACCPayablePaymentStatusDataAccess().Add(mDACCPayablePaymentStatusEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDACCPayablePaymentStatusFacade.Update(MDACCPayablePaymentStatusEntity mDACCPayablePaymentStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDACCPayablePaymentStatusDataAccess().Update(mDACCPayablePaymentStatusEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDACCPayablePaymentStatusFacade.Delete(MDACCPayablePaymentStatusEntity mDACCPayablePaymentStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDACCPayablePaymentStatusDataAccess().Delete(mDACCPayablePaymentStatusEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDACCPayablePaymentStatusFacade.Add(IList<MDACCPayablePaymentStatusEntity> mDACCPayablePaymentStatusEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDACCPayablePaymentStatusDataAccess().Add(mDACCPayablePaymentStatusEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDACCPayablePaymentStatusFacade.Update(IList<MDACCPayablePaymentStatusEntity> mDACCPayablePaymentStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDACCPayablePaymentStatusDataAccess().Update(mDACCPayablePaymentStatusEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDACCPayablePaymentStatusFacade.Delete(IList<MDACCPayablePaymentStatusEntity> mDACCPayablePaymentStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDACCPayablePaymentStatusDataAccess().Delete(mDACCPayablePaymentStatusEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDACCPayablePaymentStatusEntity> IMDACCPayablePaymentStatusFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDACCPayablePaymentStatusDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDACCPayablePaymentStatusFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDACCPayablePaymentStatusDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDACCPayablePaymentStatusEntity IMDACCPayablePaymentStatusFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDACCPayablePaymentStatusEntity.FLD_NAME_ACCPayablePaymentStatusID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDACCPayablePaymentStatusDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
