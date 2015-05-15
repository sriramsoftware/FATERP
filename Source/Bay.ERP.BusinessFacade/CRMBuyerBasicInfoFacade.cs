// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-May-2013, 03:37:43




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
    public sealed partial class CRMBuyerBasicInfoFacade : ICRMBuyerBasicInfoFacade
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

        public CRMBuyerBasicInfoFacade()
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

        ~CRMBuyerBasicInfoFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICRMBuyerBasicInfoFacade.Add(CRMBuyerBasicInfoEntity cRMBuyerBasicInfoEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMBuyerBasicInfoDataAccess().Add(cRMBuyerBasicInfoEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMBuyerBasicInfoFacade.Update(CRMBuyerBasicInfoEntity cRMBuyerBasicInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMBuyerBasicInfoDataAccess().Update(cRMBuyerBasicInfoEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMBuyerBasicInfoFacade.Delete(CRMBuyerBasicInfoEntity cRMBuyerBasicInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMBuyerBasicInfoDataAccess().Delete(cRMBuyerBasicInfoEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICRMBuyerBasicInfoFacade.Add(IList<CRMBuyerBasicInfoEntity> cRMBuyerBasicInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMBuyerBasicInfoDataAccess().Add(cRMBuyerBasicInfoEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMBuyerBasicInfoFacade.Update(IList<CRMBuyerBasicInfoEntity> cRMBuyerBasicInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMBuyerBasicInfoDataAccess().Update(cRMBuyerBasicInfoEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMBuyerBasicInfoFacade.Delete(IList<CRMBuyerBasicInfoEntity> cRMBuyerBasicInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMBuyerBasicInfoDataAccess().Delete(cRMBuyerBasicInfoEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CRMBuyerBasicInfoEntity> ICRMBuyerBasicInfoFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMBuyerBasicInfoDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICRMBuyerBasicInfoFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMBuyerBasicInfoDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CRMBuyerBasicInfoEntity ICRMBuyerBasicInfoFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMBuyerBasicInfoEntity.FLD_NAME_BuyerBasicInfoID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCRMBuyerBasicInfoDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
