import { Component, OnInit } from '@angular/core';
import {FormControl} from '@angular/forms';

@Component({
  selector: 'app-new-student',
  templateUrl: './new-student.component.html',
  styleUrls: ['./new-student.component.css']
  
})
export class NewStudentComponent implements OnInit {

  stuFormtDetails: boolean[] =[]
  results : any =null;
  stuJsonResult: any ={};
  selectedTab:number=0;
  
  constructor() { }
  

  ngOnInit(): void {
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
    if(!this.stuFormtDetails.includes(false)){
      return;
    }
    console.log('submited');
  }
  setTabFormDetails(value: any,tab:number){
    this.stuFormtDetails[tab] = value.valid;
    Object.assign(this.stuJsonResult,value.value);
    console.log(this.stuJsonResult);
  }

}
