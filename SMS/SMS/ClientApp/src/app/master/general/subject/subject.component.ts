import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-subject',
  templateUrl: './subject.component.html',
  styleUrls: ['./subject.component.css']
})
export class SubjectComponent implements OnInit {

  subjectlist: any = [
    {
      subject:'Tamil',
  },
  {
    subject:'Science',
  }
];
  constructor() { }

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
