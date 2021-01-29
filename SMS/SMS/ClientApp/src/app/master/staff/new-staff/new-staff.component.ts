import { Component, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-new-staff',
  templateUrl: './new-staff.component.html',
  styleUrls: ['./new-staff.component.css']
})
export class NewStaffComponent implements OnInit {

  formDetails:any=[{value:{},valid:false},{value:{},valid:false},{value:{},valid:false},{value:{},valid:false}];
  
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

  setTabFormDetails(value:any,tab:number){  
      this.formDetails[tab]=value;  
  }

}
