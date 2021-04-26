import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl,FormGroup } from '@angular/forms';
import { SmsConstant } from 'src/app/shared/constant-values';

export interface PeriodicElement {
  staffName: number;
  employeeId: number;
  present: number;
  absent: number;
  halfday: number;
  leave: number;
}

const ELEMENT_DATA: PeriodicElement[] = [
  {staffName: 1, employeeId: 54, present:1, absent: 1,halfday:1,leave:1}
 
];

@Component({
  selector: 'app-staff-attendance',
  templateUrl: './staff-attendance.component.html',
  styleUrls: ['./staff-attendance.component.css']
})
export class StaffAttendanceComponent implements OnInit {

  departmentIdFilter = new FormControl('');
  designationFilter = new FormControl('');
  statusvalueFilter = new FormControl('');
  joiningDateFrom = new FormControl('');

  displayedColumns: string[] = ['staffName','employeeId','present','absent','halfday','leave'];
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
  
  class = SmsConstant.Subjectsdropdown;
  section = SmsConstant.staffType;
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
