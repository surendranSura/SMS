import { Component, OnInit } from '@angular/core';
import { SubjectRestApiService } from './subject-rest-api.service';

@Component({
  selector: 'app-subject',
  templateUrl: './subject.component.html',
  styleUrls: ['./subject.component.css']
})
export class SubjectComponent implements OnInit {

  subjectlist: any;

  constructor(private subjectApi : SubjectRestApiService) {

    this.subjectApi.getSubjects().subscribe(data => {
      this.subjectlist = data;
    });

  }

  ngOnInit(): void {
    this.getData();
  }

  getData()
  {

  }

  addSubject()
  {
    this.subjectlist.push({});
  }

  eventCatch(value:any){
    
    if(value===1){
      this.subjectlist.pop();
      return;
    }
    this.getData();
    //api 

  }
}
