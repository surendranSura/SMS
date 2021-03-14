import { Component, OnInit, Output, EventEmitter, Input, SimpleChanges } from '@angular/core';


@Component({
  selector: 'app-address-details',
  templateUrl: './address-details.component.html',
  styleUrls: ['./address-details.component.css']
})
export class AddressDetailsComponent implements OnInit {

  formPermanentAddress: any = {};
  formCurrentAddress: any ={};

  adderessArray = [{ value: {}, valid: false }, { value: {}, valid: false }];
  cTpFlag:boolean=false;

  @Output() addresses = new EventEmitter();
  @Input() addressDetails;
  constructor() {

  }

  ngOnChanges(changes: SimpleChanges): void {
  
    if (changes.addressDetails.currentValue)
    {
      this.formCurrentAddress=this.addressDetails[0];
      this.formPermanentAddress=this.addressDetails[1];
    }
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
