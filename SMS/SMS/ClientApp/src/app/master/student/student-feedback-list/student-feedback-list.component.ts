import { Component, OnInit,  ViewChild, AfterViewInit } from '@angular/core';
import { Router } from '@angular/router';
import { StudentrestApiService } from '../studentrest-api.service';
import { Subscription} from 'rxjs';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { BlockUI, NgBlockUI } from 'ng-block-ui';

@Component({
  selector: 'app-student-feedback-list',
  templateUrl: './student-feedback-list.component.html',
  styleUrls: ['./student-feedback-list.component.css']
})
export class StudentFeedbackListComponent implements OnInit {
  studentFeedbackList=[{
    'studentName':'Ramesh',
    'feedBackType': 'Achievement',
    'feedbackTitle':'Best Student of the Year',
    'description':'2020 Best Student BVPS',
    'date':'01-01-2020',
    'attachment':'A1'}];

    @ViewChild(MatPaginator)
    paginator!: MatPaginator;
    @ViewChild(MatSort) sort !: MatSort;
  
    currentUserSubscription !: Subscription;
    staffListData!: MatTableDataSource<any>;


    // "studentFeedbackId": 1,
    // "staffName": "asdasdasd",
    // "feedbackType": "1",
    // "date": "2021-02-28T18:30:00",
    // "class": "asdasd",
    // "feedbacktitle": "asdasd",
    // "section": "asdasd",
    // "teacherId": "",
    // "description": "asdasdasd",
    // "attachment": ""
  
    
     @BlockUI() blockUI: NgBlockUI;
    columnsToDisplay=['studentName','feedBackType','feedbackTitle','description','date', 'actions'];
  
  constructor(private roter:Router, private studentrestApiService :StudentrestApiService) { }

  ngOnInit(): void {
    this.LoadFeedBack();
  }
  callNewStudentFeedback(){
    this.roter.navigate(['/main/student-feedback'])
  }

  removeStaffFeedBack(staff : any){

    this.studentrestApiService.deleteStudentFeedBack(staff.studentFeedbackId).subscribe(_=>{
      this.LoadFeedBack();
    });
  }

  editStaffFeedBack(staff : any)
  {
    console.log(staff);
    this.roter.navigate(['/main/student-feedback',staff.studentFeedbackId]);
    // this.staffApiService.deleteStaff(staff.mobile).subscribe(_=>{
    // });
  }

  LoadFeedBack()
  {
    this.blockUI.start();

    this.currentUserSubscription = this.studentrestApiService.getStudentsFeedBack().subscribe((staffFeedback:any) => {
      this.studentFeedbackList = staffFeedback;
      console.log(this.studentFeedbackList);
       this.blockUI.stop();

    });
  }

}
