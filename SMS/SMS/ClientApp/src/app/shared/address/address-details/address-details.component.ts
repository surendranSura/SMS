import { Component, OnInit, Output, EventEmitter } from '@angular/core';


@Component({
  selector: 'app-address-details',
  templateUrl: './address-details.component.html',
  styleUrls: ['./address-details.component.css']
})
export class AddressDetailsComponent implements OnInit {

  formPermanentAddress: any = {};

  adderessArray = [{ value: {}, valid: false }, { value: {}, valid: false }];

  @Output() addresses = new EventEmitter();

  constructor() {

  }

  ngOnInit(): void {
  }

  cTp(flag: boolean) {
    if (flag) {
      this.formPermanentAddress = this.adderessArray[0].value;
      this.adderessArray[1] = this.adderessArray[0];

      this.addresses.emit(this.adderessArray);
    }
  }

  getAddress(value: any, flg: number) {

    this.adderessArray[flg] = value;
    this.addresses.emit(this.adderessArray);

  }

}
