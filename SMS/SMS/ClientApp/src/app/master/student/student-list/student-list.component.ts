import { Component, OnInit, Output,EventEmitter, ViewChild, AfterViewInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { StudentrestApiService } from '../studentrest-api.service';
import { BlockUI, NgBlockUI } from 'ng-block-ui';
import { Subscription} from 'rxjs';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { SmsConstant } from 'src/app/shared/constant-values';
import { Student } from '../student';
import { Router } from '@angular/router';

@Component({
  selector: 'app-student-list',
  templateUrl: './student-list.component.html',
  styleUrls: ['./student-list.component.css']
})
export class StudentListComponent implements OnInit {
  // studentListData=[{
  //   "studentName":"one",
  //   'esisNumber':'one',
  //    'mobileNumber':'one',
  //    'email':'aiswarya@gmail.com',
  //    'class':'5',
  //    'section':'B',
  //    'status':'good'
  // }];
  @BlockUI() blockUI: NgBlockUI;
  @ViewChild(MatPaginator)
  paginator!: MatPaginator;
  @ViewChild(MatSort) sort !: MatSort;

  currentUserSubscription !: Subscription;
  studentListData : any;
  currentStudent : Student;
  columnsToDisplay = ['StudentName','EsisNumber', 'MobileNumber','Email','Class','Section', 'Actions'];
  constructor(private studentrestApiService : StudentrestApiService, private router:Router) { }

  ngOnInit(): void {
    this.LoadStudent();
  }

  LoadStudent()
  {
    this.blockUI.start();

    this.currentUserSubscription = this.studentrestApiService.getStudents().subscribe((student:any) => {
      this.currentStudent = student;
      this.studentListData = new MatTableDataSource(student);
       this.studentListData.paginator = this.paginator;
      this.studentListData.sort = this.sort;
      console.log(this.studentListData);
       this.blockUI.stop();

    });
  }

  removeStudent(student : Student)
  {
    this.blockUI.start();

    this.studentrestApiService.deleteStudent(student.admissionNumber).subscribe(_=>{
      this.LoadStudent();
    });
    this.blockUI.stop();
  }

  editStudent(student : Student)
  {
    this.router.navigate(['/main/new-student',student.admissionNumber]);
    // this.staffApiService.deleteStaff(staff.mobile).subscribe(_=>{
    // });
  }

}
