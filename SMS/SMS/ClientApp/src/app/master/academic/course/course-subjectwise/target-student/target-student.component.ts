import { Component, EventEmitter, OnInit, Output, ViewChild, AfterViewInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { SmsConstant } from 'src/app/shared/constant-values';
import { StudentListComponent } from "../../../../student/student-list/student-list.component";
import {SelectionModel} from '@angular/cdk/collections';

import { Subscription} from 'rxjs';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { Router } from '@angular/router';

@Component({
  selector: 'app-target-student',
  templateUrl: './target-student.component.html',
  styleUrls: ['./target-student.component.css']
})

export class TargetStudentComponent implements OnInit {
  @Output() emitcourseformDetails = new EventEmitter();
  

  @ViewChild(MatPaginator)
  paginator!: MatPaginator;
  @ViewChild(MatSort) sort !: MatSort;

  currentUserSubscription !: Subscription;
  studentListData : any[];
  

  columnsToDisplay = ['StudentName','EsisNumber', 'MobileNumber','Email','Class','Section', 'Status'];




  targetstudentForm : FormGroup;
 classes=SmsConstant.classes;
 sections=SmsConstant.section;
 allstatus=SmsConstant.section
  constructor(private fb:FormBuilder) {
    this.targetstudentForm=this.fb.group({
      class:[''],
      section:[''],
      status:['']
    });
    this.targetstudentForm.valueChanges.subscribe(()=>{
      this.emitcourseformDetails.emit({value:this.targetstudentForm.value,valid:this.targetstudentForm.valid});
    })
   }

  ngOnInit(): void {
  }
  checkBoxAction(matValue:any){
    // this.pFlagEmit.emit(matValue.checked);
    // if (matValue.checked) {
    //   this.form.disable();
    // }
    // else {
    //   this.form.enable();
    // }
  }
}
