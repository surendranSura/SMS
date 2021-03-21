import {  Component, OnInit, Output,EventEmitter, ViewChild, AfterViewInit } from '@angular/core';
import { Router } from '@angular/router'
import { FormControl } from '@angular/forms';
import { StaffrestApiService } from '../staffrest-api.service';
import { Staff } from '../Staff';
import { Subscription} from 'rxjs';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { BlockUI, NgBlockUI } from 'ng-block-ui';
import { SmsConstant } from 'src/app/shared/constant-values';
import { Console } from 'console';

@Component({
  selector: 'app-staff-list',
  templateUrl: './staff-list.component.html',
  styleUrls: ['./staff-list.component.css']
})
export class StaffListComponent implements OnInit {

  department = SmsConstant.department;
  designationList = SmsConstant.designation;
  status = SmsConstant.employmentStatus;

  @ViewChild(MatPaginator)
  paginator!: MatPaginator;
  @ViewChild(MatSort) sort !: MatSort;

  currentUserSubscription !: Subscription;
  currentStaff? : Staff;
  staffs: Staff[] = [];
  staffListData!: MatTableDataSource<any>;

  columnsToDisplay = ['staffName','staffType', 'employeeID','department','designation','status','joiningDate','mobileNumber','eMail','actions'];
  
   @BlockUI() blockUI: NgBlockUI;
  
  constructor(private router:Router, private staffApiService: StaffrestApiService) {

    this.LoadStaff();
  }

  departmentchange(value)
  {
    
    this.staffListData.filter.search(value);
      console.log(this.staffListData.filter.search(value));
  }
  LoadStaff()
  {
    this.blockUI.start();

    this.currentUserSubscription = this.staffApiService.getStaffs().subscribe((staff:any) => {
      this.currentStaff = staff;
      this.staffListData = new MatTableDataSource(staff);
       this.staffListData.paginator = this.paginator;
      this.staffListData.sort = this.sort;
      console.log(this.staffListData);
       this.blockUI.stop();

    });

  }

  

  ngOnInit(): void {
   
    // this.staffListData = new MatTableDataSource(this.staffs);
    // this.staffListData.paginator = this.paginator;
    // this.staffListData.sort = this.sort;
    
  }

  callNewStudent()
  {  
    this.router.navigate(['/main/new-staff']);
  }
  
  removeStaff(staff : Staff)
  {
    this.staffApiService.deleteStaff(staff.mobile).subscribe(_=>{
      this.LoadStaff();
    });
  }

  editStaff(staff : Staff)
  {
    this.router.navigate(['/main/new-staff',staff.mobile]);
    // this.staffApiService.deleteStaff(staff.mobile).subscribe(_=>{
    // });
  }

}
