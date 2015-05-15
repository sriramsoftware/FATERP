// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 03:34:29




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
    public sealed partial class ASSiteMapNode_DetailedFacade : IASSiteMapNode_DetailedFacade
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

        public ASSiteMapNode_DetailedFacade()
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

        ~ASSiteMapNode_DetailedFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Get

        [OperationContract]
        IList<ASSiteMapNode_DetailedEntity> IASSiteMapNode_DetailedFacade.GetIL(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            return DataAccessFactory.CreateASSiteMapNode_DetailedDataAccess().GetIL(startRowIndex, pageSize, sortExpression, filterExpression);
        }

        [OperationContract]
        DataTable IASSiteMapNode_DetailedFacade.GetDT(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            return DataAccessFactory.CreateASSiteMapNode_DetailedDataAccess().GetDT(startRowIndex, pageSize, sortExpression, filterExpression);
        }

        #endregion Get


        #endregion
    }
}
