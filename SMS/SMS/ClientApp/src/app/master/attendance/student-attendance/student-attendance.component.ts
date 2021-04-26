import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl,FormGroup } from '@angular/forms';
import { SmsConstant } from 'src/app/shared/constant-values';

export interface PeriodicElement {
  month: number;
  admissionnumber: number;
  present: number;
  absent: number;
  halfday: number;
  leave: number;
}

const ELEMENT_DATA: PeriodicElement[] = [
  {month: 1, admissionnumber: 54, present:1, absent: 1,halfday:1,leave:1}
 
];
 



@Component({
  selector: 'app-student-attendance',
  templateUrl: './student-attendance.component.html',
  styleUrls: ['./student-attendance.component.css']
})
export class StudentAttendanceComponent implements OnInit {

  departmentIdFilter = new FormControl('');
  designationFilter = new FormControl('');
  statusvalueFilter = new FormControl('');
  joiningDateFrom = new FormControl('');

  displayedColumns: string[] = ['month','admissionnumber','present','absent','halfday','leave'];
  filterValues = {
    //department: 
    departmentId :'',
   // designation: '',
    designationId: '',
    //status: '',
    employeementstatusId: '',
    //joiningDateFrom: '',
    joiningDate: ''
    //joiningDateTo: '',
  };

  stafffilters: FormGroup;
  
  dataSource1 = ELEMENT_DATA;
  
  class = SmsConstant.classes;
  section = SmsConstant.section;
  constructor(private fb: FormBuilder) {
    this.stafffilters = this.fb.group({
      departmentIdFilter: [''],
      designationFilter: [''],
      statusvalueFilter: [''],
      joiningDateFrom: ['']
    });
   }

  ngOnInit(): void {
  }

}
