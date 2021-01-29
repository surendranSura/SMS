import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MasterComponent } from './master.component';

const routes: Routes = [
  {
    path: '', component: MasterComponent,
    children: [
      { path: 'new-staff', loadChildren: () => import('./staff/new-staff/new-staff.module').then(m => m.NewStaffModule) },
      { path: 'staff-list', loadChildren: () => import('./staff/staff-list/staff-list.module').then(m => m.StaffListModule) },
      { path: 'new-student', loadChildren: () => import('./student/new-student/new-student.module').then(m => m.NewStudentModule) }


    ]
  },
  
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MasterRoutingModule { }
