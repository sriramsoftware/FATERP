// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Jan-2012, 01:42:10




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

namespace Bay.ERP.BusinessFacade
{
    public sealed partial class CMConsultantEnlistedWorkArea_DetailedFacade : ICMConsultantEnlistedWorkArea_DetailedFacade
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

        public CMConsultantEnlistedWorkArea_DetailedFacade()
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

        ~CMConsultantEnlistedWorkArea_DetailedFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Get

        [OperationContract]
        IList<CMConsultantEnlistedWorkArea_DetailedEntity> ICMConsultantEnlistedWorkArea_DetailedFacade.GetIL(Int32 pageSize, Int32 currentPage, String sortExpression, String filterExpression)
        {
            return DataAccessFactory.CreateCMConsultantEnlistedWorkArea_DetailedDataAccess().GetIL(pageSize, currentPage, sortExpression, filterExpression);
        }

        [OperationContract]
        DataTable ICMConsultantEnlistedWorkArea_DetailedFacade.GetDT(Int32 pageSize, Int32 currentPage, String sortExpression, String filterExpression)
        {
            return DataAccessFactory.CreateCMConsultantEnlistedWorkArea_DetailedDataAccess().GetDT(pageSize, currentPage, sortExpression, filterExpression);
        }

        #endregion Get


        #endregion
    }
}
