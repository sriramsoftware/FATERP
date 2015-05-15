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
    public sealed partial class CRMMDCommuicationDiscussionTypeFacade : ICRMMDCommuicationDiscussionTypeFacade
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

        public CRMMDCommuicationDiscussionTypeFacade()
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

        ~CRMMDCommuicationDiscussionTypeFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICRMMDCommuicationDiscussionTypeFacade.Add(CRMMDCommuicationDiscussionTypeEntity cRMMDCommuicationDiscussionTypeEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDCommuicationDiscussionTypeDataAccess().Add(cRMMDCommuicationDiscussionTypeEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMMDCommuicationDiscussionTypeFacade.Update(CRMMDCommuicationDiscussionTypeEntity cRMMDCommuicationDiscussionTypeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDCommuicationDiscussionTypeDataAccess().Update(cRMMDCommuicationDiscussionTypeEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICRMMDCommuicationDiscussionTypeFacade.Delete(CRMMDCommuicationDiscussionTypeEntity cRMMDCommuicationDiscussionTypeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDCommuicationDiscussionTypeDataAccess().Delete(cRMMDCommuicationDiscussionTypeEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICRMMDCommuicationDiscussionTypeFacade.Add(IList<CRMMDCommuicationDiscussionTypeEntity> cRMMDCommuicationDiscussionTypeEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDCommuicationDiscussionTypeDataAccess().Add(cRMMDCommuicationDiscussionTypeEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMMDCommuicationDiscussionTypeFacade.Update(IList<CRMMDCommuicationDiscussionTypeEntity> cRMMDCommuicationDiscussionTypeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDCommuicationDiscussionTypeDataAccess().Update(cRMMDCommuicationDiscussionTypeEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICRMMDCommuicationDiscussionTypeFacade.Delete(IList<CRMMDCommuicationDiscussionTypeEntity> cRMMDCommuicationDiscussionTypeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCRMMDCommuicationDiscussionTypeDataAccess().Delete(cRMMDCommuicationDiscussionTypeEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CRMMDCommuicationDiscussionTypeEntity> ICRMMDCommuicationDiscussionTypeFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMMDCommuicationDiscussionTypeDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICRMMDCommuicationDiscussionTypeFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCRMMDCommuicationDiscussionTypeDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CRMMDCommuicationDiscussionTypeEntity ICRMMDCommuicationDiscussionTypeFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMMDCommuicationDiscussionTypeEntity.FLD_NAME_CommuicationDiscussionTypeID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCRMMDCommuicationDiscussionTypeDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
