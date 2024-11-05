using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using StudentWindowsFormsApp.studentprojectEntitiesDataModel;
using StudentWindowsFormsApp.Common;
using StudentWindowsFormsApp;

namespace StudentWindowsFormsApp.ViewModels {

    /// <summary>
    /// Represents the single employee object view model.
    /// </summary>
    public partial class employeeViewModel : SingleObjectViewModel<employee, Guid, IstudentprojectEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of employeeViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static employeeViewModel Create(IUnitOfWorkFactory<IstudentprojectEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new employeeViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the employeeViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the employeeViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected employeeViewModel(IUnitOfWorkFactory<IstudentprojectEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.employees, x => x.lastname) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of assignments for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<assignment> LookUpassignments {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (employeeViewModel x) => x.LookUpassignments,
                    getRepositoryFunc: x => x.assignments);
            }
        }


        /// <summary>
        /// The view model for the employeeassignments detail collection.
        /// </summary>
        public CollectionViewModelBase<assignment, assignment, Guid, IstudentprojectEntitiesUnitOfWork> employeeassignmentsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (employeeViewModel x) => x.employeeassignmentsDetails,
                    getRepositoryFunc: x => x.assignments,
                    foreignKeyExpression: x => x.personID,
                    navigationExpression: x => x.employee);
            }
        }
    }
}
