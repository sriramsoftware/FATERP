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
    public sealed partial class CRMMDBuyerInterestedRoomCategoryFacade : ICRMMDBuyerInterestedRoomCategoryFacade
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

        public CRMMDBuyerInterestedRoomCategoryFacade()
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

        ~CRMMDBuyerInterestedRoomCategoryFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICRMMDBuyerInterestedRoomCategoryFacade.Add(CRMMDBuyerInterestedRoomCategoryEntity cRMMDBuyerInterestedRoomCategoryEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDBuyerInterestedRoomCategoryDataAccess().Add(cRMMDBuyerInterestedRoomCategoryEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMMDBuyerInterestedRoomCategoryFacade.Update(CRMMDBuyerInterestedRoomCategoryEntity cRMMDBuyerInterestedRoomCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDBuyerInterestedRoomCategoryDataAccess().Update(cRMMDBuyerInterestedRoomCategoryEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMMDBuyerInterestedRoomCategoryFacade.Delete(CRMMDBuyerInterestedRoomCategoryEntity cRMMDBuyerInterestedRoomCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDBuyerInterestedRoomCategoryDataAccess().Delete(cRMMDBuyerInterestedRoomCategoryEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICRMMDBuyerInterestedRoomCategoryFacade.Add(IList<CRMMDBuyerInterestedRoomCategoryEntity> cRMMDBuyerInterestedRoomCategoryEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDBuyerInterestedRoomCategoryDataAccess().Add(cRMMDBuyerInterestedRoomCategoryEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMMDBuyerInterestedRoomCategoryFacade.Update(IList<CRMMDBuyerInterestedRoomCategoryEntity> cRMMDBuyerInterestedRoomCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDBuyerInterestedRoomCategoryDataAccess().Update(cRMMDBuyerInterestedRoomCategoryEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMMDBuyerInterestedRoomCategoryFacade.Delete(IList<CRMMDBuyerInterestedRoomCategoryEntity> cRMMDBuyerInterestedRoomCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDBuyerInterestedRoomCategoryDataAccess().Delete(cRMMDBuyerInterestedRoomCategoryEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CRMMDBuyerInterestedRoomCategoryEntity> ICRMMDBuyerInterestedRoomCategoryFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMMDBuyerInterestedRoomCategoryDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICRMMDBuyerInterestedRoomCategoryFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMMDBuyerInterestedRoomCategoryDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CRMMDBuyerInterestedRoomCategoryEntity ICRMMDBuyerInterestedRoomCategoryFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMMDBuyerInterestedRoomCategoryEntity.FLD_NAME_BuyerInterestedRoomCategoryID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCRMMDBuyerInterestedRoomCategoryDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
