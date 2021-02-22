import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { SubjectRoutingModule } from './subject-routing.module';
import { SubjectComponent } from './subject.component';
import { SharedModule } from 'src/app/shared/shared.module';
import { ReactiveFormsModule } from '@angular/forms';
import { SubjectsComponent } from './subjects/subjects.component';
import { RouterModule } from '@angular/router';


@NgModule({
  declarations: [SubjectComponent, SubjectsComponent],
  imports: [
    CommonModule,
    SubjectRoutingModule,
    SharedModule,
  ReactiveFormsModule,
  RouterModule.forChild([{path : '',component:SubjectComponent}
]),
  ]})
export class SubjectModule { }
