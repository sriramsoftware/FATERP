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
    public sealed partial class CRMMDAgreementSpecsTypeFacade : ICRMMDAgreementSpecsTypeFacade
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

        public CRMMDAgreementSpecsTypeFacade()
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

        ~CRMMDAgreementSpecsTypeFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICRMMDAgreementSpecsTypeFacade.Add(CRMMDAgreementSpecsTypeEntity cRMMDAgreementSpecsTypeEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDAgreementSpecsTypeDataAccess().Add(cRMMDAgreementSpecsTypeEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMMDAgreementSpecsTypeFacade.Update(CRMMDAgreementSpecsTypeEntity cRMMDAgreementSpecsTypeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDAgreementSpecsTypeDataAccess().Update(cRMMDAgreementSpecsTypeEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMMDAgreementSpecsTypeFacade.Delete(CRMMDAgreementSpecsTypeEntity cRMMDAgreementSpecsTypeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDAgreementSpecsTypeDataAccess().Delete(cRMMDAgreementSpecsTypeEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICRMMDAgreementSpecsTypeFacade.Add(IList<CRMMDAgreementSpecsTypeEntity> cRMMDAgreementSpecsTypeEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDAgreementSpecsTypeDataAccess().Add(cRMMDAgreementSpecsTypeEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMMDAgreementSpecsTypeFacade.Update(IList<CRMMDAgreementSpecsTypeEntity> cRMMDAgreementSpecsTypeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDAgreementSpecsTypeDataAccess().Update(cRMMDAgreementSpecsTypeEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMMDAgreementSpecsTypeFacade.Delete(IList<CRMMDAgreementSpecsTypeEntity> cRMMDAgreementSpecsTypeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDAgreementSpecsTypeDataAccess().Delete(cRMMDAgreementSpecsTypeEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CRMMDAgreementSpecsTypeEntity> ICRMMDAgreementSpecsTypeFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMMDAgreementSpecsTypeDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICRMMDAgreementSpecsTypeFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMMDAgreementSpecsTypeDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CRMMDAgreementSpecsTypeEntity ICRMMDAgreementSpecsTypeFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMMDAgreementSpecsTypeEntity.FLD_NAME_AgreementSpecsTypeID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCRMMDAgreementSpecsTypeDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
