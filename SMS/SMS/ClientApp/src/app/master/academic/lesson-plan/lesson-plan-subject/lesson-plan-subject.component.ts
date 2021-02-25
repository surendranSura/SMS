import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-lesson-plan-subject',
  templateUrl: './lesson-plan-subject.component.html',
  styleUrls: ['./lesson-plan-subject.component.css']
})
export class LessonPlanSubjectComponent implements OnInit {
  standard:any=
  [{
    subject:"English"},{subject:"Tamil"},{subject:"Maths"},{subject:"Science"},{subject:"Social"}];
  router: any;
  constructor() { }

  ngOnInit(): void {
  }
//   navigate() {  
   
//     this.router.navigate([""]);
// }
}
