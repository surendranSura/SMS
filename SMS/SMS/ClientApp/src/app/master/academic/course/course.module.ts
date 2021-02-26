import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CourseRoutingModule } from './course-routing.module';
import { CourseComponent } from './course.component';
import { SharedModule } from 'src/app/shared/shared.module';
import { CourseClassesComponent } from './course-classes/course-classes.component';
import { ReactiveFormsModule } from '@angular/forms';

import { CourseSubjectwiseComponent } from './course-subjectwise/course-subjectwise.component';
import { CourseSubjectComponent } from './course-subject/course-subject.component';
import { CourseDetailsComponent } from './course-subjectwise/course-details/course-details.component';
import { ContentUploadComponent } from './course-subjectwise/content-upload/content-upload.component';
import { TargetStudentComponent } from './course-subjectwise/target-student/target-student.component';
import { PreviewPublishComponent } from './course-subjectwise/preview-publish/preview-publish.component';


@NgModule({
  declarations: [CourseComponent, CourseClassesComponent,  CourseSubjectwiseComponent, CourseSubjectComponent, CourseDetailsComponent, ContentUploadComponent, TargetStudentComponent, PreviewPublishComponent],
  imports: [
    CommonModule,
    CourseRoutingModule,
    SharedModule,
    ReactiveFormsModule
  ]
})
export class CourseModule { }
