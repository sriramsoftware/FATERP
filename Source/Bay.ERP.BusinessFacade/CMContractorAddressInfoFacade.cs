// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Jan-2012, 02:49:42




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
    public sealed partial class CMContractorAddressInfoFacade : ICMContractorAddressInfoFacade
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

        public CMContractorAddressInfoFacade()
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

        ~CMContractorAddressInfoFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICMContractorAddressInfoFacade.Add(CMContractorAddressInfoEntity cMContractorAddressInfoEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMContractorAddressInfoDataAccess().Add(cMContractorAddressInfoEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICMContractorAddressInfoFacade.Update(CMContractorAddressInfoEntity cMContractorAddressInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMContractorAddressInfoDataAccess().Update(cMContractorAddressInfoEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICMContractorAddressInfoFacade.Delete(CMContractorAddressInfoEntity cMContractorAddressInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMContractorAddressInfoDataAccess().Delete(cMContractorAddressInfoEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICMContractorAddressInfoFacade.Add(IList<CMContractorAddressInfoEntity> cMContractorAddressInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMContractorAddressInfoDataAccess().Add(cMContractorAddressInfoEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMContractorAddressInfoFacade.Update(IList<CMContractorAddressInfoEntity> cMContractorAddressInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMContractorAddressInfoDataAccess().Update(cMContractorAddressInfoEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMContractorAddressInfoFacade.Delete(IList<CMContractorAddressInfoEntity> cMContractorAddressInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMContractorAddressInfoDataAccess().Delete(cMContractorAddressInfoEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CMContractorAddressInfoEntity> ICMContractorAddressInfoFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMContractorAddressInfoDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICMContractorAddressInfoFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMContractorAddressInfoDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CMContractorAddressInfoEntity ICMContractorAddressInfoFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMContractorAddressInfoEntity.FLD_NAME_ContractorAddressInfoID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCMContractorAddressInfoDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
