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
    public sealed partial class CRMBuyerInterestedRoomMapFacade : ICRMBuyerInterestedRoomMapFacade
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

        public CRMBuyerInterestedRoomMapFacade()
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

        ~CRMBuyerInterestedRoomMapFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICRMBuyerInterestedRoomMapFacade.Add(CRMBuyerInterestedRoomMapEntity cRMBuyerInterestedRoomMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMBuyerInterestedRoomMapDataAccess().Add(cRMBuyerInterestedRoomMapEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMBuyerInterestedRoomMapFacade.Update(CRMBuyerInterestedRoomMapEntity cRMBuyerInterestedRoomMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMBuyerInterestedRoomMapDataAccess().Update(cRMBuyerInterestedRoomMapEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMBuyerInterestedRoomMapFacade.Delete(CRMBuyerInterestedRoomMapEntity cRMBuyerInterestedRoomMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMBuyerInterestedRoomMapDataAccess().Delete(cRMBuyerInterestedRoomMapEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICRMBuyerInterestedRoomMapFacade.Add(IList<CRMBuyerInterestedRoomMapEntity> cRMBuyerInterestedRoomMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMBuyerInterestedRoomMapDataAccess().Add(cRMBuyerInterestedRoomMapEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMBuyerInterestedRoomMapFacade.Update(IList<CRMBuyerInterestedRoomMapEntity> cRMBuyerInterestedRoomMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMBuyerInterestedRoomMapDataAccess().Update(cRMBuyerInterestedRoomMapEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMBuyerInterestedRoomMapFacade.Delete(IList<CRMBuyerInterestedRoomMapEntity> cRMBuyerInterestedRoomMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMBuyerInterestedRoomMapDataAccess().Delete(cRMBuyerInterestedRoomMapEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CRMBuyerInterestedRoomMapEntity> ICRMBuyerInterestedRoomMapFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMBuyerInterestedRoomMapDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICRMBuyerInterestedRoomMapFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMBuyerInterestedRoomMapDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CRMBuyerInterestedRoomMapEntity ICRMBuyerInterestedRoomMapFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMBuyerInterestedRoomMapEntity.FLD_NAME_BuyerInterestedRoomMapID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCRMBuyerInterestedRoomMapDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
