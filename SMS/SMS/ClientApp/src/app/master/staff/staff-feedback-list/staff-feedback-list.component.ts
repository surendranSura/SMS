import { Component, OnInit, ViewChild, AfterViewInit } from '@angular/core';
import { Router } from '@angular/router'
import { FormControl } from '@angular/forms';
import { Subscription} from 'rxjs';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { BlockUI, NgBlockUI } from 'ng-block-ui';
import { StaffrestApiService } from '../staffrest-api.service';

@Component({
  selector: 'app-staff-feedback-list',
  templateUrl: './staff-feedback-list.component.html',
  styleUrls: ['./staff-feedback-list.component.css']
})
export class StaffFeedbackListComponent implements OnInit {
  // staffFeedbackList = [
  //   {
  //     'staffName': 'arya',
  //     'feedBackType': 'Achievement',
  //     'feedbackTitle':'Best Teacher of the Year',
  //     'description':'2020 Best Techer BVPS',
  //     'date':'06-02-2021',
  //     'attachment':'A1'
  //   }
  // ];

  staffFeedbackList: any[];

  @ViewChild(MatPaginator)
  paginator!: MatPaginator;
  @ViewChild(MatSort) sort !: MatSort;

  currentUserSubscription !: Subscription;
  staffListData!: MatTableDataSource<any>;

  
   @BlockUI() blockUI: NgBlockUI;

  columnsToDisplay = ['staffName', 'feedBackType', 'feedbackTitle', 'description', 'date', 'attachment', 'actions'];
  constructor(private router: Router,  private staffrestApiService :StaffrestApiService) { }

  ngOnInit(): void {
  }
  callNewStaffFeedback()
  {
    this.router.navigate(['./main/staff-feedback'])
  }

  removeStaffFeedBack(staff : any){

    this.staffrestApiService.deleteStaffFeedBack(staff.staffFeedbackID).subscribe(_=>{
      this.LoadFeedBack();
    });
  }

  editStaffFeedBack(staff : any)
  {
    this.router.navigate(['/main/e-letter',staff.staffFeedbackID]);
    // this.staffApiService.deleteStaff(staff.mobile).subscribe(_=>{
    // });
  }

  LoadFeedBack()
  {
    this.blockUI.start();

    this.currentUserSubscription = this.staffrestApiService.getStaffseLetters().subscribe((staffFeedback:any) => {
      this.staffFeedbackList = staffFeedback;
      console.log(this.staffFeedbackList);
       this.blockUI.stop();

    });
  }

}
