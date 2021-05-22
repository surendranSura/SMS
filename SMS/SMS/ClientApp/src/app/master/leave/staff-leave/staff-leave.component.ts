import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl,FormGroup } from '@angular/forms';
import { matMenuAnimations } from '@angular/material/menu';
import { SmsConstant } from 'src/app/shared/constant-values';



export interface PeriodicElement {
  staffName: number;
  admissionnumber: number;
  leaveType: string;
  noofdays: number;
  datefrom: Date;
  reason: number;
  status: string;
}

const ELEMENT_DATA: PeriodicElement[] = [
  {staffName: 1, admissionnumber: 54, leaveType:'seek leave', noofdays: 1,datefrom:new Date(),reason:1,status:"approved"}
 
];
@Component({
  selector: 'app-staff-leave',
  templateUrl: './staff-leave.component.html',
  styleUrls: ['./staff-leave.component.css']
})
export class StaffLeaveComponent implements OnInit {

  departmentIdFilter = new FormControl('');
  designationFilter = new FormControl('');
  statusvalueFilter = new FormControl('');
  joiningDateFrom = new FormControl('');

  displayedColumns: string[] = ['studentName','admissionnumber','leaveType','noofdays','datefrom','reason','status'];
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
