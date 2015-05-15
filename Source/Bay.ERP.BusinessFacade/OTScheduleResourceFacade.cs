// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




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
    public sealed partial class OTScheduleResourceFacade : IOTScheduleResourceFacade
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

        public OTScheduleResourceFacade()
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

        ~OTScheduleResourceFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IOTScheduleResourceFacade.Add(OTScheduleResourceEntity oTScheduleResourceEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateOTScheduleResourceDataAccess().Add(oTScheduleResourceEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IOTScheduleResourceFacade.Update(OTScheduleResourceEntity oTScheduleResourceEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateOTScheduleResourceDataAccess().Update(oTScheduleResourceEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IOTScheduleResourceFacade.Delete(OTScheduleResourceEntity oTScheduleResourceEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateOTScheduleResourceDataAccess().Delete(oTScheduleResourceEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IOTScheduleResourceFacade.Add(IList<OTScheduleResourceEntity> oTScheduleResourceEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateOTScheduleResourceDataAccess().Add(oTScheduleResourceEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IOTScheduleResourceFacade.Update(IList<OTScheduleResourceEntity> oTScheduleResourceEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateOTScheduleResourceDataAccess().Update(oTScheduleResourceEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IOTScheduleResourceFacade.Delete(IList<OTScheduleResourceEntity> oTScheduleResourceEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateOTScheduleResourceDataAccess().Delete(oTScheduleResourceEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<OTScheduleResourceEntity> IOTScheduleResourceFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateOTScheduleResourceDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IOTScheduleResourceFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateOTScheduleResourceDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        OTScheduleResourceEntity IOTScheduleResourceFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(OTScheduleResourceEntity.FLD_NAME_OTScheduleResourceID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateOTScheduleResourceDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
