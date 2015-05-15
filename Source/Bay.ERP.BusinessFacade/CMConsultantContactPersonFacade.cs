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
    public sealed partial class CMConsultantContactPersonFacade : ICMConsultantContactPersonFacade
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

        public CMConsultantContactPersonFacade()
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

        ~CMConsultantContactPersonFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICMConsultantContactPersonFacade.Add(CMConsultantContactPersonEntity cMConsultantContactPersonEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMConsultantContactPersonDataAccess().Add(cMConsultantContactPersonEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICMConsultantContactPersonFacade.Update(CMConsultantContactPersonEntity cMConsultantContactPersonEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMConsultantContactPersonDataAccess().Update(cMConsultantContactPersonEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICMConsultantContactPersonFacade.Delete(CMConsultantContactPersonEntity cMConsultantContactPersonEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMConsultantContactPersonDataAccess().Delete(cMConsultantContactPersonEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICMConsultantContactPersonFacade.Add(IList<CMConsultantContactPersonEntity> cMConsultantContactPersonEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMConsultantContactPersonDataAccess().Add(cMConsultantContactPersonEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMConsultantContactPersonFacade.Update(IList<CMConsultantContactPersonEntity> cMConsultantContactPersonEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMConsultantContactPersonDataAccess().Update(cMConsultantContactPersonEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMConsultantContactPersonFacade.Delete(IList<CMConsultantContactPersonEntity> cMConsultantContactPersonEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMConsultantContactPersonDataAccess().Delete(cMConsultantContactPersonEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CMConsultantContactPersonEntity> ICMConsultantContactPersonFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMConsultantContactPersonDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICMConsultantContactPersonFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMConsultantContactPersonDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CMConsultantContactPersonEntity ICMConsultantContactPersonFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMConsultantContactPersonEntity.FLD_NAME_ConsultantContactPersonID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCMConsultantContactPersonDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
