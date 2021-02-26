import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute, ParamMap } from '@angular/router';
import { Observable } from 'rxjs'

@Component({
  selector: 'app-lesson-plan-subject',
  templateUrl: './lesson-plan-subject.component.html',
  styleUrls: ['./lesson-plan-subject.component.css']
})
export class LessonPlanSubjectComponent implements OnInit {
  standard:any=
  [{
    subject:"English"},{subject:"Tamil"},{subject:"Maths"},{subject:"Science"},{subject:"Social"}];
    classId:any;
  constructor(private route: ActivatedRoute,
    private router: Router) { }
    
  ngOnInit(): void {
     this.classId = this.route.snapshot.paramMap.get('class');
    console.log(this.classId);
  }
  navigate(subject:any) {  
   
    this.router.navigate(["/main/lesson-plan/addsLessonPlanSubjectWise/"+subject+"/"+this.classId]);
}
}
