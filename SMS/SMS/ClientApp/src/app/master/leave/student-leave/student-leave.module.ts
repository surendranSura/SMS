import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { StudentLeaveRoutingModule } from './student-leave-routing.module';
import { StudentLeaveComponent } from './student-leave.component';
import { AngularMaterialModule } from 'src/angular-material.module';
import { ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [StudentLeaveComponent],
  imports: [
    CommonModule,
    StudentLeaveRoutingModule,
    AngularMaterialModule,
    ReactiveFormsModule
  ]
})
export class StudentLeaveModule { }
