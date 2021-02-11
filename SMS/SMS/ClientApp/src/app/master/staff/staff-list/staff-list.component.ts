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
       'employeeID':1,
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
       'employeeID':2,
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
    
    this.router.navigate(['/main/new-staff']);
  }
  // removeStaff(emp : any)
  // {
  //   console.log(emp);
    
  // }
  removeStaff(emp : any)
  {
    console.log('hai');
  }

}
