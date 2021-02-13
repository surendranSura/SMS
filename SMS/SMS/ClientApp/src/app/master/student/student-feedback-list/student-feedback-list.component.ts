import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

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
    columnsToDisplay=['studentName','feedBackType','feedbackTitle','description','date','attachment'];
  constructor(private roter:Router) { }

  ngOnInit(): void {
  }
  callNewStudentFeedback(){
    this.roter.navigate(['/main/student-feedback'])
  }

}
