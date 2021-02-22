import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { LessonPlanRoutingModule } from './lesson-plan-routing.module';
import { LessonPlanComponent } from './lesson-plan.component';
import { SharedModule } from 'src/app/shared/shared.module';
import { ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [LessonPlanComponent],
  imports: [
    CommonModule,
    LessonPlanRoutingModule,
    SharedModule,
    ReactiveFormsModule
  ]
  
})
export class LessonPlanModule { }
