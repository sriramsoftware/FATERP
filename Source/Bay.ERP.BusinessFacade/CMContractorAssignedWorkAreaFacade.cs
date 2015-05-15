// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 14-Nov-2012, 03:31:55




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
    public sealed partial class CMContractorAssignedWorkAreaFacade : ICMContractorAssignedWorkAreaFacade
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

        public CMContractorAssignedWorkAreaFacade()
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

        ~CMContractorAssignedWorkAreaFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICMContractorAssignedWorkAreaFacade.Add(CMContractorAssignedWorkAreaEntity cMContractorAssignedWorkAreaEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMContractorAssignedWorkAreaDataAccess().Add(cMContractorAssignedWorkAreaEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICMContractorAssignedWorkAreaFacade.Update(CMContractorAssignedWorkAreaEntity cMContractorAssignedWorkAreaEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMContractorAssignedWorkAreaDataAccess().Update(cMContractorAssignedWorkAreaEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICMContractorAssignedWorkAreaFacade.Delete(CMContractorAssignedWorkAreaEntity cMContractorAssignedWorkAreaEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMContractorAssignedWorkAreaDataAccess().Delete(cMContractorAssignedWorkAreaEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICMContractorAssignedWorkAreaFacade.Add(IList<CMContractorAssignedWorkAreaEntity> cMContractorAssignedWorkAreaEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMContractorAssignedWorkAreaDataAccess().Add(cMContractorAssignedWorkAreaEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMContractorAssignedWorkAreaFacade.Update(IList<CMContractorAssignedWorkAreaEntity> cMContractorAssignedWorkAreaEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMContractorAssignedWorkAreaDataAccess().Update(cMContractorAssignedWorkAreaEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMContractorAssignedWorkAreaFacade.Delete(IList<CMContractorAssignedWorkAreaEntity> cMContractorAssignedWorkAreaEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMContractorAssignedWorkAreaDataAccess().Delete(cMContractorAssignedWorkAreaEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CMContractorAssignedWorkAreaEntity> ICMContractorAssignedWorkAreaFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMContractorAssignedWorkAreaDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICMContractorAssignedWorkAreaFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMContractorAssignedWorkAreaDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CMContractorAssignedWorkAreaEntity ICMContractorAssignedWorkAreaFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMContractorAssignedWorkAreaEntity.FLD_NAME_ContractorAssignedWorkAreaID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCMContractorAssignedWorkAreaDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}