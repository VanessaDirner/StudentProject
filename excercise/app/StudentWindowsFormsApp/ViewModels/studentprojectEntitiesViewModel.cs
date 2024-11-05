using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.ViewModel;
using StudentWindowsFormsApp.studentprojectEntitiesDataModel;

namespace StudentWindowsFormsApp.ViewModels {
    /// <summary>
    /// Represents the root POCO view model for the studentprojectEntities data model.
    /// </summary>
    public partial class studentprojectEntitiesViewModel : DocumentsViewModel<studentprojectEntitiesModuleDescription, IstudentprojectEntitiesUnitOfWork> {

		const string TablesGroup = "Tables";

		const string ViewsGroup = "Views";
		INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }
	
        /// <summary>
        /// Creates a new instance of studentprojectEntitiesViewModel as a POCO view model.
        /// </summary>
        public static studentprojectEntitiesViewModel Create() {
            return ViewModelSource.Create(() => new studentprojectEntitiesViewModel());
        }

		
        /// <summary>
        /// Initializes a new instance of the studentprojectEntitiesViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the studentprojectEntitiesViewModel type without the POCO proxy factory.
        /// </summary>
        protected studentprojectEntitiesViewModel()
		    : base(UnitOfWorkSource.GetUnitOfWorkFactory()) {
        }

        protected override studentprojectEntitiesModuleDescription[] CreateModules() {
			return new studentprojectEntitiesModuleDescription[] {
                new studentprojectEntitiesModuleDescription( "assignments", "assignmentCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.assignments)),
                new studentprojectEntitiesModuleDescription( "departments", "departmentCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.departments)),
                new studentprojectEntitiesModuleDescription( "employees", "employeeCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.employees)),
			};
        }
                		protected override void OnActiveModuleChanged(studentprojectEntitiesModuleDescription oldModule) {
            if(ActiveModule != null && NavigationService != null) {
                NavigationService.ClearNavigationHistory();
            }
            base.OnActiveModuleChanged(oldModule);
        }
	}

    public partial class studentprojectEntitiesModuleDescription : ModuleDescription<studentprojectEntitiesModuleDescription> {
        public studentprojectEntitiesModuleDescription(string title, string documentType, string group, Func<studentprojectEntitiesModuleDescription, object> peekCollectionViewModelFactory = null)
            : base(title, documentType, group, peekCollectionViewModelFactory) {
        }
    }
}