import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-add-lesson-plan-listview',
  templateUrl: './add-lesson-plan-listview.component.html',
  styleUrls: ['./add-lesson-plan-listview.component.css']
})
export class AddLessonPlanListviewComponent implements OnInit {
  studentListData=[{
    "date":"20/2/2021",
    'lesson':'one',
     'topic':'one',
     'concept':'aiswarya@gmail.com',
     'extraInfo':'5',
     'games':'B',
     'activity':'good',
     'homeWork':'good'
  },
  {
    "date":"20/2/2021",
    'lesson':'one',
     'topic':'one',
     'concept':'aiswarya@gmail.com',
     'extraInfo':'5',
     'games':'B',
     'activity':'good',
     'homeWork':'good'
  }];
  columnsToDisplay = ['date','lesson', 'topic','concept','extraInfo','games','activity','homeWork','actions'];
  LessonListForm:FormGroup;

  subject: any;
  class: any;


  constructor(private fb:FormBuilder,private route: ActivatedRoute,private router:Router) { 
this.LessonListForm=this.fb.group({
  from:[''],
  to:['']
});

  }

  ngOnInit(): void {
    this.subject = this.route.snapshot.paramMap.get('subject');
    this.class = this.route.snapshot.paramMap.get('class');
  }
  navToback(){
    this.router.navigate(["main/lesson-plan/addsLessonPlanSubjectWise/"+this.subject+"/"+this.class]);
  }

}
