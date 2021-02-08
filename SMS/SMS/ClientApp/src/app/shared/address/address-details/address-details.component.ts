import { Component, OnInit, Output, EventEmitter } from '@angular/core';


@Component({
  selector: 'app-address-details',
  templateUrl: './address-details.component.html',
  styleUrls: ['./address-details.component.css']
})
export class AddressDetailsComponent implements OnInit {

  formPermanentAddress: any = {};

  adderessArray = [{ value: {}, valid: false }, { value: {}, valid: false }];
  cTpFlag:boolean=false;

  @Output() addresses = new EventEmitter();

  constructor() {

  }

  ngOnInit(): void {
  }

  cTp(flag: boolean) {
    if (flag) {
      this.cTpFlag=true;
      this.formPermanentAddress = this.adderessArray[0].value;
      this.adderessArray[1] = this.adderessArray[0];

      this.addresses.emit(this.adderessArray);
      return;
    }
    this.cTpFlag=false;
  }

  getAddress(value: any, flg: number) {
      if(this.cTpFlag && flg==1){
        
        return ;
      }
   
    this.adderessArray[flg] = value;
    this.addresses.emit(this.adderessArray);

  }

}
