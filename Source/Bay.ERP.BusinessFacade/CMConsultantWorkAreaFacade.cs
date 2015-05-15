// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 04:47:08




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
    public sealed partial class CMConsultantWorkAreaFacade : ICMConsultantWorkAreaFacade
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

        public CMConsultantWorkAreaFacade()
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

        ~CMConsultantWorkAreaFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICMConsultantWorkAreaFacade.Add(CMConsultantWorkAreaEntity cMConsultantWorkAreaEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMConsultantWorkAreaDataAccess().Add(cMConsultantWorkAreaEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICMConsultantWorkAreaFacade.Update(CMConsultantWorkAreaEntity cMConsultantWorkAreaEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMConsultantWorkAreaDataAccess().Update(cMConsultantWorkAreaEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICMConsultantWorkAreaFacade.Delete(CMConsultantWorkAreaEntity cMConsultantWorkAreaEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMConsultantWorkAreaDataAccess().Delete(cMConsultantWorkAreaEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICMConsultantWorkAreaFacade.Add(IList<CMConsultantWorkAreaEntity> cMConsultantWorkAreaEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMConsultantWorkAreaDataAccess().Add(cMConsultantWorkAreaEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMConsultantWorkAreaFacade.Update(IList<CMConsultantWorkAreaEntity> cMConsultantWorkAreaEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMConsultantWorkAreaDataAccess().Update(cMConsultantWorkAreaEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMConsultantWorkAreaFacade.Delete(IList<CMConsultantWorkAreaEntity> cMConsultantWorkAreaEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMConsultantWorkAreaDataAccess().Delete(cMConsultantWorkAreaEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CMConsultantWorkAreaEntity> ICMConsultantWorkAreaFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMConsultantWorkAreaDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICMConsultantWorkAreaFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMConsultantWorkAreaDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CMConsultantWorkAreaEntity ICMConsultantWorkAreaFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMConsultantWorkAreaEntity.FLD_NAME_ConsultantWorkAreaID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCMConsultantWorkAreaDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
