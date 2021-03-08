import { Component, OnInit, Output, EventEmitter, Input, OnChanges, SimpleChanges } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { Validators } from '@angular/forms';
import { FormControl, FormGroup, FormArray } from '@angular/forms';
import { ActivatedRoute, Router, RouterLink } from '@angular/router';
import { SmsConstant } from 'src/app/shared/constant-values';
import {AlertService } from 'src/app/shared/alert';
@Component({
  selector: 'app-add-leson-plan-subjectwise',
  templateUrl: './add-leson-plan-subjectwise.component.html',
  styleUrls: ['./add-leson-plan-subjectwise.component.css']
})
export class AddLesonPlanSubjectwiseComponent implements OnInit {
  subjectwiselessonform:FormGroup;
   subject:any;
   class:any;
   options = {
    autoClose: false,
    keepAfterRouteChange: false
};

  constructor(private fb:FormBuilder,private route: ActivatedRoute,
    private router: Router,protected alertService: AlertService) { 
      
    this.subjectwiselessonform=this.fb.group({
      date: ['',Validators.required],
      classWork: ['',Validators.required],
      homeWork: ['',Validators.required],
      lesson: ['',Validators.required],
      games: ['',Validators.required],
      activity: ['',Validators.required],
      classActivity:['',Validators.required],
      toppic:['',Validators.required],
      extraInfo:['',Validators.required],
      concept:['',Validators.required],

    });
   }
onSubmit() {
    // TODO: Use EventEmitter with form value
    // console.warn(this.subjectwiselessonform.value);
  }
  ngOnInit(): void {
    this.subject = this.route.snapshot.paramMap.get('subject');
    this.class = this.route.snapshot.paramMap.get('class');
    
  }
  navToListView(){
    this.router.navigate(["main/lesson-plan/addLessonPlanListview/"+ this.subject+"/"+this.class]);
  }

}
