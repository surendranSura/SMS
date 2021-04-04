import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TimetableClassesComponent } from './timetable-classes.component';
import { RouterModule } from '@angular/router';
import { SharedModule } from 'src/app/shared/shared.module';
import { ReactiveFormsModule } from '@angular/forms';



@NgModule({
  declarations: [TimetableClassesComponent],
  imports: [
    CommonModule,
    RouterModule.forChild([{path : '',component:TimetableClassesComponent}
  ]),
    SharedModule,
    ReactiveFormsModule
]})
export class TimetableClassesModule { }
