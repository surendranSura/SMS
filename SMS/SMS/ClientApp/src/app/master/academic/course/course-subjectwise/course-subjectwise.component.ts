import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-course-subjectwise',
  templateUrl: './course-subjectwise.component.html',
  styleUrls: ['./course-subjectwise.component.css']
})
export class CourseSubjectwiseComponent implements OnInit {

  courseFormtDetails: boolean[] =[]
  results : any =null;
  courseJsonResult: any ={};
  selectedTab:number=0;

  subject:any;
  class:any;
  constructor(private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.subject = this.route.snapshot.paramMap.get('subject');
    this.class = this.route.snapshot.paramMap.get('class');
  }
  btnMovement(st:string){

    if(st==='bck'){
      this.selectedTab--;
    }
    else if (st === 'frd') {

      if (this.selectedTab >= 3) {
        this.submit();
        return;
      }
      this.selectedTab++;
    }

  }
  submit(){

    // if(!this.stuFormtDetails.includes(false)){
    //   return;
    // }

    // this.studentApiService.createStudent(this.stuJsonResult).subscribe(_=>{
    // });

    console.log('submited');
  }
  setTabFormDetails(value: any,tab:number){
    this.courseFormtDetails[tab] = value.valid;
    Object.assign(this.courseJsonResult,value.value);
    console.log(this.courseJsonResult);
  }
}

