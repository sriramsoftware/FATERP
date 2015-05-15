// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Apr-2013, 01:26:57




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
    public sealed partial class CRMAgreementSpecsFacade : ICRMAgreementSpecsFacade
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

        public CRMAgreementSpecsFacade()
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

        ~CRMAgreementSpecsFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICRMAgreementSpecsFacade.Add(CRMAgreementSpecsEntity cRMAgreementSpecsEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMAgreementSpecsDataAccess().Add(cRMAgreementSpecsEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMAgreementSpecsFacade.Update(CRMAgreementSpecsEntity cRMAgreementSpecsEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMAgreementSpecsDataAccess().Update(cRMAgreementSpecsEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMAgreementSpecsFacade.Delete(CRMAgreementSpecsEntity cRMAgreementSpecsEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMAgreementSpecsDataAccess().Delete(cRMAgreementSpecsEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICRMAgreementSpecsFacade.Add(IList<CRMAgreementSpecsEntity> cRMAgreementSpecsEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMAgreementSpecsDataAccess().Add(cRMAgreementSpecsEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMAgreementSpecsFacade.Update(IList<CRMAgreementSpecsEntity> cRMAgreementSpecsEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMAgreementSpecsDataAccess().Update(cRMAgreementSpecsEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMAgreementSpecsFacade.Delete(IList<CRMAgreementSpecsEntity> cRMAgreementSpecsEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMAgreementSpecsDataAccess().Delete(cRMAgreementSpecsEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CRMAgreementSpecsEntity> ICRMAgreementSpecsFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMAgreementSpecsDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICRMAgreementSpecsFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMAgreementSpecsDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CRMAgreementSpecsEntity ICRMAgreementSpecsFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMAgreementSpecsEntity.FLD_NAME_AgreementSpecsID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCRMAgreementSpecsDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
