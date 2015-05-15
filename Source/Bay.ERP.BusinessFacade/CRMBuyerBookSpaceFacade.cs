// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Apr-2013, 03:35:56




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
    public sealed partial class CRMBuyerBookSpaceFacade : ICRMBuyerBookSpaceFacade
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

        public CRMBuyerBookSpaceFacade()
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

        ~CRMBuyerBookSpaceFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICRMBuyerBookSpaceFacade.Add(CRMBuyerBookSpaceEntity cRMBuyerBookSpaceEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMBuyerBookSpaceDataAccess().Add(cRMBuyerBookSpaceEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMBuyerBookSpaceFacade.Update(CRMBuyerBookSpaceEntity cRMBuyerBookSpaceEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMBuyerBookSpaceDataAccess().Update(cRMBuyerBookSpaceEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMBuyerBookSpaceFacade.Delete(CRMBuyerBookSpaceEntity cRMBuyerBookSpaceEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMBuyerBookSpaceDataAccess().Delete(cRMBuyerBookSpaceEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICRMBuyerBookSpaceFacade.Add(IList<CRMBuyerBookSpaceEntity> cRMBuyerBookSpaceEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMBuyerBookSpaceDataAccess().Add(cRMBuyerBookSpaceEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMBuyerBookSpaceFacade.Update(IList<CRMBuyerBookSpaceEntity> cRMBuyerBookSpaceEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMBuyerBookSpaceDataAccess().Update(cRMBuyerBookSpaceEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMBuyerBookSpaceFacade.Delete(IList<CRMBuyerBookSpaceEntity> cRMBuyerBookSpaceEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMBuyerBookSpaceDataAccess().Delete(cRMBuyerBookSpaceEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CRMBuyerBookSpaceEntity> ICRMBuyerBookSpaceFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMBuyerBookSpaceDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICRMBuyerBookSpaceFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMBuyerBookSpaceDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CRMBuyerBookSpaceEntity ICRMBuyerBookSpaceFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMBuyerBookSpaceEntity.FLD_NAME_BuyerBookSpaceID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCRMBuyerBookSpaceDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
