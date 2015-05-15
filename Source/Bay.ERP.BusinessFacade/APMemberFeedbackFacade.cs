// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Oct-2012, 11:32:20




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
    public sealed partial class APMemberFeedbackFacade : IAPMemberFeedbackFacade
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

        public APMemberFeedbackFacade()
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

        ~APMemberFeedbackFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IAPMemberFeedbackFacade.Add(APMemberFeedbackEntity aPMemberFeedbackEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateAPMemberFeedbackDataAccess().Add(aPMemberFeedbackEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IAPMemberFeedbackFacade.Update(APMemberFeedbackEntity aPMemberFeedbackEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateAPMemberFeedbackDataAccess().Update(aPMemberFeedbackEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IAPMemberFeedbackFacade.Delete(APMemberFeedbackEntity aPMemberFeedbackEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateAPMemberFeedbackDataAccess().Delete(aPMemberFeedbackEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IAPMemberFeedbackFacade.Add(IList<APMemberFeedbackEntity> aPMemberFeedbackEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateAPMemberFeedbackDataAccess().Add(aPMemberFeedbackEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IAPMemberFeedbackFacade.Update(IList<APMemberFeedbackEntity> aPMemberFeedbackEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateAPMemberFeedbackDataAccess().Update(aPMemberFeedbackEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IAPMemberFeedbackFacade.Delete(IList<APMemberFeedbackEntity> aPMemberFeedbackEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateAPMemberFeedbackDataAccess().Delete(aPMemberFeedbackEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<APMemberFeedbackEntity> IAPMemberFeedbackFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateAPMemberFeedbackDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IAPMemberFeedbackFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateAPMemberFeedbackDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        APMemberFeedbackEntity IAPMemberFeedbackFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateAPMemberFeedbackDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
