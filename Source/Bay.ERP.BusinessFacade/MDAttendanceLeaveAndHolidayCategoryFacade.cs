// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




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
    public sealed partial class MDAttendanceLeaveAndHolidayCategoryFacade : IMDAttendanceLeaveAndHolidayCategoryFacade
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

        public MDAttendanceLeaveAndHolidayCategoryFacade()
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

        ~MDAttendanceLeaveAndHolidayCategoryFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDAttendanceLeaveAndHolidayCategoryFacade.Add(MDAttendanceLeaveAndHolidayCategoryEntity mDAttendanceLeaveAndHolidayCategoryEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDAttendanceLeaveAndHolidayCategoryDataAccess().Add(mDAttendanceLeaveAndHolidayCategoryEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDAttendanceLeaveAndHolidayCategoryFacade.Update(MDAttendanceLeaveAndHolidayCategoryEntity mDAttendanceLeaveAndHolidayCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDAttendanceLeaveAndHolidayCategoryDataAccess().Update(mDAttendanceLeaveAndHolidayCategoryEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDAttendanceLeaveAndHolidayCategoryFacade.Delete(MDAttendanceLeaveAndHolidayCategoryEntity mDAttendanceLeaveAndHolidayCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDAttendanceLeaveAndHolidayCategoryDataAccess().Delete(mDAttendanceLeaveAndHolidayCategoryEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDAttendanceLeaveAndHolidayCategoryFacade.Add(IList<MDAttendanceLeaveAndHolidayCategoryEntity> mDAttendanceLeaveAndHolidayCategoryEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDAttendanceLeaveAndHolidayCategoryDataAccess().Add(mDAttendanceLeaveAndHolidayCategoryEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDAttendanceLeaveAndHolidayCategoryFacade.Update(IList<MDAttendanceLeaveAndHolidayCategoryEntity> mDAttendanceLeaveAndHolidayCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDAttendanceLeaveAndHolidayCategoryDataAccess().Update(mDAttendanceLeaveAndHolidayCategoryEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDAttendanceLeaveAndHolidayCategoryFacade.Delete(IList<MDAttendanceLeaveAndHolidayCategoryEntity> mDAttendanceLeaveAndHolidayCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDAttendanceLeaveAndHolidayCategoryDataAccess().Delete(mDAttendanceLeaveAndHolidayCategoryEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDAttendanceLeaveAndHolidayCategoryEntity> IMDAttendanceLeaveAndHolidayCategoryFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDAttendanceLeaveAndHolidayCategoryDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDAttendanceLeaveAndHolidayCategoryFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDAttendanceLeaveAndHolidayCategoryDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDAttendanceLeaveAndHolidayCategoryEntity IMDAttendanceLeaveAndHolidayCategoryFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDAttendanceLeaveAndHolidayCategoryEntity.FLD_NAME_AttendanceLeaveAndHolidayCategoryID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDAttendanceLeaveAndHolidayCategoryDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
