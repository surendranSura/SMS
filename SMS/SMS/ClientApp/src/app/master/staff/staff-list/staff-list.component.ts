import {  Component, OnInit, Output,EventEmitter } from '@angular/core';
import { Router } from '@angular/router'
import { FormControl } from '@angular/forms';

@Component({
  selector: 'app-staff-list',
  templateUrl: './staff-list.component.html',
  styleUrls: ['./staff-list.component.css']
})
export class StaffListComponent implements OnInit {
  staffListData = [
    {
      'staffName':'hai',
      'staffType':'hai',
       'employeeID':'hai',
       'department':'hai',
       'designation':'hai',
       'status':'hai',
       'joiningDate':'hai',
       'mobileNumber':'hai',
       'eMail':'hai'
    },
    {
      'staffName':'bye',
      'staffType':'bye',
       'employeeID':'bye',
       'department':'bye',
       'designation':'bye',
       'status':'bye',
       'joiningDate':'bye',
       'mobileNumber':'bye',
       'eMail':'Surendranvenkat@gmail.com'
    }
  ];
//  Staff Type Employee ID Teacher ID Department Designation Status Joining Date Mobile Number e-mail
  columnsToDisplay = ['staffName','staffType', 'employeeID','department','designation','status','joiningDate','mobileNumber','eMail','actions'];

  constructor(private router:Router) { }
  // name = new FormControl('');

  ngOnInit(): void {
    
  }
  callNewStudent()
  {
    console.log('hai');
    this.router.navigate(['/main/new-staff']);
  }

}
