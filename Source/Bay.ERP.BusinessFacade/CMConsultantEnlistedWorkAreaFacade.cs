// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Jan-2012, 01:23:18




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
    public sealed partial class CMConsultantEnlistedWorkAreaFacade : ICMConsultantEnlistedWorkAreaFacade
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

        public CMConsultantEnlistedWorkAreaFacade()
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

        ~CMConsultantEnlistedWorkAreaFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICMConsultantEnlistedWorkAreaFacade.Add(CMConsultantEnlistedWorkAreaEntity cMConsultantEnlistedWorkAreaEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMConsultantEnlistedWorkAreaDataAccess().Add(cMConsultantEnlistedWorkAreaEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICMConsultantEnlistedWorkAreaFacade.Update(CMConsultantEnlistedWorkAreaEntity cMConsultantEnlistedWorkAreaEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMConsultantEnlistedWorkAreaDataAccess().Update(cMConsultantEnlistedWorkAreaEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICMConsultantEnlistedWorkAreaFacade.Delete(CMConsultantEnlistedWorkAreaEntity cMConsultantEnlistedWorkAreaEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMConsultantEnlistedWorkAreaDataAccess().Delete(cMConsultantEnlistedWorkAreaEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICMConsultantEnlistedWorkAreaFacade.Add(IList<CMConsultantEnlistedWorkAreaEntity> cMConsultantEnlistedWorkAreaEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMConsultantEnlistedWorkAreaDataAccess().Add(cMConsultantEnlistedWorkAreaEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMConsultantEnlistedWorkAreaFacade.Update(IList<CMConsultantEnlistedWorkAreaEntity> cMConsultantEnlistedWorkAreaEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMConsultantEnlistedWorkAreaDataAccess().Update(cMConsultantEnlistedWorkAreaEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMConsultantEnlistedWorkAreaFacade.Delete(IList<CMConsultantEnlistedWorkAreaEntity> cMConsultantEnlistedWorkAreaEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMConsultantEnlistedWorkAreaDataAccess().Delete(cMConsultantEnlistedWorkAreaEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CMConsultantEnlistedWorkAreaEntity> ICMConsultantEnlistedWorkAreaFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMConsultantEnlistedWorkAreaDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICMConsultantEnlistedWorkAreaFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMConsultantEnlistedWorkAreaDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CMConsultantEnlistedWorkAreaEntity ICMConsultantEnlistedWorkAreaFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMConsultantEnlistedWorkAreaEntity.FLD_NAME_ConsultantEnlistedWorkAreaID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCMConsultantEnlistedWorkAreaDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
