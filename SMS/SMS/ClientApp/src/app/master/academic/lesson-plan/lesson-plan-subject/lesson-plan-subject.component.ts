import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute, ParamMap } from '@angular/router';
import { Observable } from 'rxjs'
import { LessonPlanRestApiService } from '../lesson-plan-rest-api.service';

@Component({
  selector: 'app-lesson-plan-subject',
  templateUrl: './lesson-plan-subject.component.html',
  styleUrls: ['./lesson-plan-subject.component.css']
})
export class LessonPlanSubjectComponent implements OnInit {
  
  standard:any;

  classId:any;
  
  constructor(private route: ActivatedRoute,
    private router: Router, private lessonPlanRestApiService : LessonPlanRestApiService) { }
    
  ngOnInit(): void {

     this.classId = this.route.snapshot.paramMap.get('class');

     this.lessonPlanRestApiService.getClassSubjects(this.classId).subscribe( data => {
       this.standard = data;
       console.log(this.standard[0].subjects);
     });

    console.log(this.classId);
  }
  navigate(subject:any) {  
   
    this.router.navigate(["/lesson-plan/addsLessonPlanSubjectWise/"+subject+"/"+this.classId]);
}
}
