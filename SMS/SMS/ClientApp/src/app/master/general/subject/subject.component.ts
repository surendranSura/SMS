import { Component, OnInit } from '@angular/core';
import { Subject } from './Models/subject';
import { SubjectRestApiService } from './subject-rest-api.service';
import { NotificationsService } from 'angular2-notifications';
import { title } from 'process';

@Component({
  selector: 'app-subject',
  templateUrl: './subject.component.html',
  styleUrls: ['./subject.component.css']
})
export class SubjectComponent implements OnInit {

  subjectlist: any;
  addButton : any;

  constructor(private subjectApi : SubjectRestApiService, private alertservice : NotificationsService) {

   

  }

  OnSuccess(message)
  {
    this.alertservice.success('Success', message, {
      position: ['bottom', 'right'],
      timeOut: 2000,
      animate: 'fade',
      showProgressBar: true
    })
  }

  onError(message)
  {
    this.alertservice.error('Success', message, {
      position: ['bottom', 'right'],
      timeOut: 2000,
      animate: 'fade',
      showProgressBar: true
    })
  }

  ngOnInit(): void {

    this.addButton = false;

    this.getData();
  }

  getData()
  {
    this.subjectApi.getSubjects().subscribe(data => {
      this.subjectlist = data;
      this.OnSuccess('Subject Saved !!');
    });
  }

  addSubject()
  {
    this.subjectlist.push({});
    this.addButton = true;
    this.OnSuccess('Subject Saved !!');
  }

  eventCatch(value:any){

    this.addButton = false;

    if(value===1){
      this.subjectlist.pop();
      return;
    }

    if (value ===2){
      this.addButton = true;
      return;
    }
    
    this.getData();
    //api 

  }
}
