// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Jan-2012, 02:37:15




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
    public sealed partial class BulkInsertXMLFacade : IBulkInsertXMLFacade
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

        public BulkInsertXMLFacade()
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

        ~BulkInsertXMLFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Get

        [OperationContract]
        IList<BulkInsertXMLEntity> IBulkInsertXMLFacade.GetIL(String xVar, Int32 tableInfo)
        {
            return DataAccessFactory.CreateBulkInsertXMLDataAccess().GetIL(xVar, tableInfo);
        }

        [OperationContract]
        DataTable IBulkInsertXMLFacade.GetDT(String xVar, Int32 tableInfo)
        {
            return DataAccessFactory.CreateBulkInsertXMLDataAccess().GetDT(xVar, tableInfo);
        }

        #endregion Get


        #endregion
    }
}
