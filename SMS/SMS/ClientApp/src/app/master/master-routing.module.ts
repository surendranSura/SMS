import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MasterComponent } from './master.component';

const routes: Routes = [
  {
    path: '', component: MasterComponent,
    children: [
      { path: 'new-staff/:id', loadChildren: () => import('./staff/new-staff/new-staff.module').then(m => m.NewStaffModule) },
      { path: 'new-staff', loadChildren: () => import('./staff/new-staff/new-staff.module').then(m => m.NewStaffModule) },
      { path: 'staff-list', loadChildren: () => import('./staff/staff-list/staff-list.module').then(m => m.StaffListModule) },
      { path: 'new-student', loadChildren: () => import('./student/new-student/new-student.module').then(m => m.NewStudentModule)},
      { path: 'new-student/:id', loadChildren: () => import('./student/new-student/new-student.module').then(m => m.NewStudentModule)},
      { path: 'student-list', loadChildren: () =>import('./student/student-list/student-list.module').then(m=>m.StudentListModule)},
      { path: 'e-letter', loadChildren:()=>import('./staff/e-letter/e-letter.module').then(m=>m.ELetterModule)},
      { path: 'e-letter-list', loadChildren:()=>import('./staff/e-letter-list/e-letter-list.module').then(m=>m.ELetterListModule)},
      { path: 'staff-feedback', loadChildren:()=>import('./staff/staff-feedback/staff-feedback.module').then(m=>m.StaffFeedbackModule)},
      { path: 'staff-feedback-list',loadChildren:()=>import('./staff/staff-feedback-list/staff-feedback-list.module').then(m=>m.StaffFeedbackListModule)},
      { path: 'student-feedback',loadChildren:()=>import('./student/student-feedback/student-feedback.module').then(m=>m.StudentFeedbackModule)},
      { path: 'student-feedback-list',loadChildren:()=>import('./student/student-feedback-list/student-feedback-list.module').then(m=>m.StudentFeedbackListModule)},
      { path: 'class-grade', loadChildren: () => import('./general/class-grade/class-grade.module').then(m => m.ClassGradeModule)},
      { path: 'subject', loadChildren: () => import('./general/subject/subject.module').then(m => m.SubjectModule)},
      { path: 'academic-Detail', loadChildren: () => import('./academic/academic-detail/academic-detail.module').then(m => m.AcademicDetailModule) },
      { path: 'lesson-plan', loadChildren: () => import('./academic/lesson-plan/lesson-plan.module').then(m => m.LessonPlanModule) },
      { path: 'course', loadChildren: () => import('./academic/course/course.module').then(m => m.CourseModule) }
    ]
  },
  
  
  
  
  
  
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MasterRoutingModule { }
