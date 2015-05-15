// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 01-Apr-2013, 02:41:21




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
    public sealed partial class CRMBuyerAllotteeFacade : ICRMBuyerAllotteeFacade
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

        public CRMBuyerAllotteeFacade()
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

        ~CRMBuyerAllotteeFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICRMBuyerAllotteeFacade.Add(CRMBuyerAllotteeEntity cRMBuyerAllotteeEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMBuyerAllotteeDataAccess().Add(cRMBuyerAllotteeEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMBuyerAllotteeFacade.Update(CRMBuyerAllotteeEntity cRMBuyerAllotteeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMBuyerAllotteeDataAccess().Update(cRMBuyerAllotteeEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMBuyerAllotteeFacade.Delete(CRMBuyerAllotteeEntity cRMBuyerAllotteeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMBuyerAllotteeDataAccess().Delete(cRMBuyerAllotteeEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICRMBuyerAllotteeFacade.Add(IList<CRMBuyerAllotteeEntity> cRMBuyerAllotteeEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMBuyerAllotteeDataAccess().Add(cRMBuyerAllotteeEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMBuyerAllotteeFacade.Update(IList<CRMBuyerAllotteeEntity> cRMBuyerAllotteeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMBuyerAllotteeDataAccess().Update(cRMBuyerAllotteeEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMBuyerAllotteeFacade.Delete(IList<CRMBuyerAllotteeEntity> cRMBuyerAllotteeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMBuyerAllotteeDataAccess().Delete(cRMBuyerAllotteeEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CRMBuyerAllotteeEntity> ICRMBuyerAllotteeFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMBuyerAllotteeDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICRMBuyerAllotteeFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMBuyerAllotteeDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CRMBuyerAllotteeEntity ICRMBuyerAllotteeFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMBuyerAllotteeEntity.FLD_NAME_BuyerAllotteeID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCRMBuyerAllotteeDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
