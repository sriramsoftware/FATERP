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
    public sealed partial class APMemberFeedbackRemarksFacade : IAPMemberFeedbackRemarksFacade
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

        public APMemberFeedbackRemarksFacade()
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

        ~APMemberFeedbackRemarksFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IAPMemberFeedbackRemarksFacade.Add(APMemberFeedbackRemarksEntity aPMemberFeedbackRemarksEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateAPMemberFeedbackRemarksDataAccess().Add(aPMemberFeedbackRemarksEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IAPMemberFeedbackRemarksFacade.Update(APMemberFeedbackRemarksEntity aPMemberFeedbackRemarksEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateAPMemberFeedbackRemarksDataAccess().Update(aPMemberFeedbackRemarksEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IAPMemberFeedbackRemarksFacade.Delete(APMemberFeedbackRemarksEntity aPMemberFeedbackRemarksEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateAPMemberFeedbackRemarksDataAccess().Delete(aPMemberFeedbackRemarksEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IAPMemberFeedbackRemarksFacade.Add(IList<APMemberFeedbackRemarksEntity> aPMemberFeedbackRemarksEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateAPMemberFeedbackRemarksDataAccess().Add(aPMemberFeedbackRemarksEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IAPMemberFeedbackRemarksFacade.Update(IList<APMemberFeedbackRemarksEntity> aPMemberFeedbackRemarksEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateAPMemberFeedbackRemarksDataAccess().Update(aPMemberFeedbackRemarksEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IAPMemberFeedbackRemarksFacade.Delete(IList<APMemberFeedbackRemarksEntity> aPMemberFeedbackRemarksEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateAPMemberFeedbackRemarksDataAccess().Delete(aPMemberFeedbackRemarksEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<APMemberFeedbackRemarksEntity> IAPMemberFeedbackRemarksFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateAPMemberFeedbackRemarksDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IAPMemberFeedbackRemarksFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateAPMemberFeedbackRemarksDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        APMemberFeedbackRemarksEntity IAPMemberFeedbackRemarksFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(APMemberFeedbackRemarksEntity.FLD_NAME_APMemberFeedbackRemarksID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateAPMemberFeedbackRemarksDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
