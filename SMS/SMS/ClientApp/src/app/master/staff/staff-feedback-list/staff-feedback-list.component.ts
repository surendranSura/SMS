import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router'
import { FormControl } from '@angular/forms';
@Component({
  selector: 'app-staff-feedback-list',
  templateUrl: './staff-feedback-list.component.html',
  styleUrls: ['./staff-feedback-list.component.css']
})
export class StaffFeedbackListComponent implements OnInit {
  staffFeedbackList = [
    {
      'staffName': 'arya',
      'feedBackType': 'Achievement',
      'feedbackTitle':'Best Teacher of the Year',
      'description':'2020 Best Techer BVPS',
      'date':'06-02-2021',
      'attachment':'A1'
    }
  ];
  columnsToDisplay = ['staffName', 'feedBackType', 'feedbackTitle', 'description', 'date', 'attachment', 'actions'];
  constructor(private router: Router) { }

  ngOnInit(): void {
  }
  callNewStaffFeedback()
  {
    this.router.navigate(['./main/staff-feedback'])
  }

}
