import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TimetableGridComponent } from './timetable-grid/timetable-grid.component';
import { RouterModule } from '@angular/router';
import { ReactiveFormsModule } from '@angular/forms';
import { SharedModule } from 'src/app/shared/shared.module';
import {CdkTableModule} from '@angular/cdk/table';



@NgModule({
  declarations: [TimetableGridComponent],
  imports: [
    CommonModule,
    RouterModule.forChild([{path : '',component:TimetableGridComponent}
  ]),
  SharedModule,
  ReactiveFormsModule,
  CdkTableModule
]
})
export class TimetableGridModule { }
