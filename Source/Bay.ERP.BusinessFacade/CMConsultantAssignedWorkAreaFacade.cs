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
    public sealed partial class CMConsultantAssignedWorkAreaFacade : ICMConsultantAssignedWorkAreaFacade
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

        public CMConsultantAssignedWorkAreaFacade()
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

        ~CMConsultantAssignedWorkAreaFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICMConsultantAssignedWorkAreaFacade.Add(CMConsultantAssignedWorkAreaEntity cMConsultantAssignedWorkAreaEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMConsultantAssignedWorkAreaDataAccess().Add(cMConsultantAssignedWorkAreaEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICMConsultantAssignedWorkAreaFacade.Update(CMConsultantAssignedWorkAreaEntity cMConsultantAssignedWorkAreaEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMConsultantAssignedWorkAreaDataAccess().Update(cMConsultantAssignedWorkAreaEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICMConsultantAssignedWorkAreaFacade.Delete(CMConsultantAssignedWorkAreaEntity cMConsultantAssignedWorkAreaEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMConsultantAssignedWorkAreaDataAccess().Delete(cMConsultantAssignedWorkAreaEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICMConsultantAssignedWorkAreaFacade.Add(IList<CMConsultantAssignedWorkAreaEntity> cMConsultantAssignedWorkAreaEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMConsultantAssignedWorkAreaDataAccess().Add(cMConsultantAssignedWorkAreaEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMConsultantAssignedWorkAreaFacade.Update(IList<CMConsultantAssignedWorkAreaEntity> cMConsultantAssignedWorkAreaEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMConsultantAssignedWorkAreaDataAccess().Update(cMConsultantAssignedWorkAreaEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMConsultantAssignedWorkAreaFacade.Delete(IList<CMConsultantAssignedWorkAreaEntity> cMConsultantAssignedWorkAreaEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMConsultantAssignedWorkAreaDataAccess().Delete(cMConsultantAssignedWorkAreaEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CMConsultantAssignedWorkAreaEntity> ICMConsultantAssignedWorkAreaFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMConsultantAssignedWorkAreaDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICMConsultantAssignedWorkAreaFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMConsultantAssignedWorkAreaDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CMConsultantAssignedWorkAreaEntity ICMConsultantAssignedWorkAreaFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMConsultantAssignedWorkAreaEntity.FLD_NAME_ConsultantAssignedWorkAreaID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCMConsultantAssignedWorkAreaDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
