import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AcademicDetailRoutingModule } from './academic-detail-routing.module';
import { AcademicDetailComponent } from './academic-detail.component';
import { ReactiveFormsModule } from '@angular/forms';
import { SharedModule } from 'src/app/shared/shared.module';
import { RouterModule } from '@angular/router';


@NgModule({
  declarations: [AcademicDetailComponent],
  imports: [
    CommonModule,
    AcademicDetailRoutingModule,
    RouterModule.forChild([{path : '',component:AcademicDetailComponent}
  ]),
    SharedModule,
    ReactiveFormsModule
  ]})
export class AcademicDetailModule { }
