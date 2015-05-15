// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 11-Apr-2013, 01:28:07




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
    public sealed partial class CRMMDAgreementApprovalStatusFacade : ICRMMDAgreementApprovalStatusFacade
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

        public CRMMDAgreementApprovalStatusFacade()
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

        ~CRMMDAgreementApprovalStatusFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICRMMDAgreementApprovalStatusFacade.Add(CRMMDAgreementApprovalStatusEntity cRMMDAgreementApprovalStatusEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDAgreementApprovalStatusDataAccess().Add(cRMMDAgreementApprovalStatusEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMMDAgreementApprovalStatusFacade.Update(CRMMDAgreementApprovalStatusEntity cRMMDAgreementApprovalStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDAgreementApprovalStatusDataAccess().Update(cRMMDAgreementApprovalStatusEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMMDAgreementApprovalStatusFacade.Delete(CRMMDAgreementApprovalStatusEntity cRMMDAgreementApprovalStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDAgreementApprovalStatusDataAccess().Delete(cRMMDAgreementApprovalStatusEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICRMMDAgreementApprovalStatusFacade.Add(IList<CRMMDAgreementApprovalStatusEntity> cRMMDAgreementApprovalStatusEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDAgreementApprovalStatusDataAccess().Add(cRMMDAgreementApprovalStatusEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMMDAgreementApprovalStatusFacade.Update(IList<CRMMDAgreementApprovalStatusEntity> cRMMDAgreementApprovalStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDAgreementApprovalStatusDataAccess().Update(cRMMDAgreementApprovalStatusEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMMDAgreementApprovalStatusFacade.Delete(IList<CRMMDAgreementApprovalStatusEntity> cRMMDAgreementApprovalStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDAgreementApprovalStatusDataAccess().Delete(cRMMDAgreementApprovalStatusEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CRMMDAgreementApprovalStatusEntity> ICRMMDAgreementApprovalStatusFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMMDAgreementApprovalStatusDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICRMMDAgreementApprovalStatusFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMMDAgreementApprovalStatusDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CRMMDAgreementApprovalStatusEntity ICRMMDAgreementApprovalStatusFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMMDAgreementApprovalStatusEntity.FLD_NAME_AgreementApprovalStatusID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCRMMDAgreementApprovalStatusDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
