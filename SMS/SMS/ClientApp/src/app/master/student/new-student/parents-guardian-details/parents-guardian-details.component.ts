import { Component, OnInit , Output, EventEmitter} from '@angular/core';
import {MatSlideToggleModule} from '@angular/material/slide-toggle';

@Component({
  selector: 'app-parents-guardian-details',
  templateUrl: './parents-guardian-details.component.html',
  styleUrls: ['./parents-guardian-details.component.css']
})
export class ParentsGuardianDetailsComponent implements OnInit {
  @Output() stuFormtDetails = new EventEmitter();
  arryoffPersonJson :any ={
    fatherDetails:{},
    motherDetails:{},
    localGuardian:{},
    legalGuardian:{}
  };
  stuParentDetails: boolean[] =[false]
  constructor() { }

  ngOnInit(): void {
  }

  getParentsInfo(obj: any, flg:number) {
    this.stuParentDetails[flg]=obj.valid;
    switch(flg){
      case 0: this.arryoffPersonJson.fatherDetails=obj.value;
      break;
      case 1: this.arryoffPersonJson.motherDetails=obj.value;
      break;
      case 2: this.arryoffPersonJson.localGuardian=obj.value;
      break;
      case 3: this.arryoffPersonJson.legalGuardian=obj.value;
      break;

    }
   console.log(true);
    console.log(this.arryoffPersonJson);
    this.stuFormtDetails.emit({ value: this.arryoffPersonJson,valid : this.stuParentDetails[flg]});
    // this.adderessArray[flg] = value;
    // this.addresses.emit(this.adderessArray);

  }
}
