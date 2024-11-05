using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace StudentWindowsFormsApp.Views.assignmentView{
    public partial class assignmentView : XtraUserControl {
        public assignmentView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<StudentWindowsFormsApp.ViewModels.assignmentViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                assignmentViewBindingSource, x => x.Entity, x => x.Update());
									// Binding for department LookUp editor
			fluentAPI.SetBinding(departmentLookUpEdit.Properties, p => p.DataSource, x => x.LookUpdepartments.Entities);
						// Binding for employee LookUp editor
			fluentAPI.SetBinding(employeeLookUpEdit.Properties, p => p.DataSource, x => x.LookUpemployees.Entities);
			 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
    }
}
