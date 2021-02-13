import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router'
import { FormControl } from '@angular/forms';

@Component({
  selector: 'app-e-letter-list',
  templateUrl: './e-letter-list.component.html',
  styleUrls: ['./e-letter-list.component.css']
})
export class ELetterListComponent implements OnInit {

  eLetterList = [
    {
      'staffName': 'hai',
      'employeeID': 'hai',
      'letterType': 1,
      'month': 'hai',
      'year': 'hai',
      'attachment': 'hai'
    },
    {
      'staffName': 'hai',
      'employeeID': 'hai',
      'letterType': 1,
      'month': 'hai',
      'year': 'hai',
      'attachment': 'hai'
    }
  ];
  //  Staff Type Employee ID Teacher ID Department Designation Status Joining Date Mobile Number e-mail
  columnsToDisplay = ['staffName', 'employeeID', 'letterType', 'month', 'year', 'attachment', 'actions'];

  constructor(private router: Router) { }
  // name = new FormControl('');

  ngOnInit(): void {

  }
  callNewELetter() {

    this.router.navigate(['/main/e-letter']);
  }
  // removeStaff(emp : any)
  // {
  //   console.log(emp);

  // }
  removeStaff(emp: any) {
    console.log('hai');
  }

}

