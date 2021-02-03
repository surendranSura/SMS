import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
@Component({
  selector: 'app-student-list',
  templateUrl: './student-list.component.html',
  styleUrls: ['./student-list.component.css']
})
export class StudentListComponent implements OnInit {
  studentListData=[{
    "studentName":"one",
    'esisNumber':'one',
     'mobileNumber':'one',
     'email':'aiswarya@gmail.com',
     'class':'5',
     'section':'B',
     'status':'good'
  }];
  columnsToDisplay = ['studentName','esisNumber', 'mobileNumber','email','class','section','status','actions'];
  constructor() { }

  ngOnInit(): void {
  }

}
