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
    public sealed partial class CRMMDAreaUnitFacade : ICRMMDAreaUnitFacade
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

        public CRMMDAreaUnitFacade()
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

        ~CRMMDAreaUnitFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICRMMDAreaUnitFacade.Add(CRMMDAreaUnitEntity cRMMDAreaUnitEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDAreaUnitDataAccess().Add(cRMMDAreaUnitEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMMDAreaUnitFacade.Update(CRMMDAreaUnitEntity cRMMDAreaUnitEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDAreaUnitDataAccess().Update(cRMMDAreaUnitEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMMDAreaUnitFacade.Delete(CRMMDAreaUnitEntity cRMMDAreaUnitEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDAreaUnitDataAccess().Delete(cRMMDAreaUnitEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICRMMDAreaUnitFacade.Add(IList<CRMMDAreaUnitEntity> cRMMDAreaUnitEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDAreaUnitDataAccess().Add(cRMMDAreaUnitEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMMDAreaUnitFacade.Update(IList<CRMMDAreaUnitEntity> cRMMDAreaUnitEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDAreaUnitDataAccess().Update(cRMMDAreaUnitEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMMDAreaUnitFacade.Delete(IList<CRMMDAreaUnitEntity> cRMMDAreaUnitEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDAreaUnitDataAccess().Delete(cRMMDAreaUnitEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CRMMDAreaUnitEntity> ICRMMDAreaUnitFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMMDAreaUnitDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICRMMDAreaUnitFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMMDAreaUnitDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CRMMDAreaUnitEntity ICRMMDAreaUnitFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMMDAreaUnitEntity.FLD_NAME_AreaUnitID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCRMMDAreaUnitDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
