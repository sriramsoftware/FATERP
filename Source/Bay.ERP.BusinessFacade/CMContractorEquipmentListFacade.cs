// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Jan-2012, 11:52:45




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
    public sealed partial class CMContractorEquipmentListFacade : ICMContractorEquipmentListFacade
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

        public CMContractorEquipmentListFacade()
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

        ~CMContractorEquipmentListFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICMContractorEquipmentListFacade.Add(CMContractorEquipmentListEntity cMContractorEquipmentListEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMContractorEquipmentListDataAccess().Add(cMContractorEquipmentListEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICMContractorEquipmentListFacade.Update(CMContractorEquipmentListEntity cMContractorEquipmentListEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMContractorEquipmentListDataAccess().Update(cMContractorEquipmentListEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICMContractorEquipmentListFacade.Delete(CMContractorEquipmentListEntity cMContractorEquipmentListEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMContractorEquipmentListDataAccess().Delete(cMContractorEquipmentListEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICMContractorEquipmentListFacade.Add(IList<CMContractorEquipmentListEntity> cMContractorEquipmentListEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMContractorEquipmentListDataAccess().Add(cMContractorEquipmentListEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMContractorEquipmentListFacade.Update(IList<CMContractorEquipmentListEntity> cMContractorEquipmentListEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMContractorEquipmentListDataAccess().Update(cMContractorEquipmentListEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMContractorEquipmentListFacade.Delete(IList<CMContractorEquipmentListEntity> cMContractorEquipmentListEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMContractorEquipmentListDataAccess().Delete(cMContractorEquipmentListEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CMContractorEquipmentListEntity> ICMContractorEquipmentListFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMContractorEquipmentListDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICMContractorEquipmentListFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMContractorEquipmentListDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CMContractorEquipmentListEntity ICMContractorEquipmentListFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMContractorEquipmentListEntity.FLD_NAME_ContractorEquipmentID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCMContractorEquipmentListDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
