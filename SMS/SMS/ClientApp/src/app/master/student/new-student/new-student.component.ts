import { Component, OnInit } from '@angular/core';
import {FormControl} from '@angular/forms';

@Component({
  selector: 'app-new-student',
  templateUrl: './new-student.component.html',
  styleUrls: ['./new-student.component.css']
})
export class NewStudentComponent implements OnInit {

  selectedTab:number=0;
  
  constructor() { }
  

  ngOnInit(): void {
  }

  btnMovement(st:string){
    if(st==='bck'){
      this.selectedTab--;
    }
    else if(st==='frd'){
      this.selectedTab++;
    }

  }

}
