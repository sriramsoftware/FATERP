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
    public sealed partial class CRMAgreementVariableMapFacade : ICRMAgreementVariableMapFacade
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

        public CRMAgreementVariableMapFacade()
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

        ~CRMAgreementVariableMapFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICRMAgreementVariableMapFacade.Add(CRMAgreementVariableMapEntity cRMAgreementVariableMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMAgreementVariableMapDataAccess().Add(cRMAgreementVariableMapEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMAgreementVariableMapFacade.Update(CRMAgreementVariableMapEntity cRMAgreementVariableMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMAgreementVariableMapDataAccess().Update(cRMAgreementVariableMapEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMAgreementVariableMapFacade.Delete(CRMAgreementVariableMapEntity cRMAgreementVariableMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMAgreementVariableMapDataAccess().Delete(cRMAgreementVariableMapEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICRMAgreementVariableMapFacade.Add(IList<CRMAgreementVariableMapEntity> cRMAgreementVariableMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMAgreementVariableMapDataAccess().Add(cRMAgreementVariableMapEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMAgreementVariableMapFacade.Update(IList<CRMAgreementVariableMapEntity> cRMAgreementVariableMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMAgreementVariableMapDataAccess().Update(cRMAgreementVariableMapEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMAgreementVariableMapFacade.Delete(IList<CRMAgreementVariableMapEntity> cRMAgreementVariableMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMAgreementVariableMapDataAccess().Delete(cRMAgreementVariableMapEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CRMAgreementVariableMapEntity> ICRMAgreementVariableMapFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMAgreementVariableMapDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICRMAgreementVariableMapFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMAgreementVariableMapDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CRMAgreementVariableMapEntity ICRMAgreementVariableMapFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMAgreementVariableMapEntity.FLD_NAME_AgreementVariableMapID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCRMAgreementVariableMapDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
