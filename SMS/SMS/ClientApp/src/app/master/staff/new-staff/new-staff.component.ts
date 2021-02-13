import { Component, OnInit } from '@angular/core';
import { StaffrestApiService } from '../staffrest-api.service';

@Component({
  selector: 'app-new-staff',
  templateUrl: './new-staff.component.html',
  styleUrls: ['./new-staff.component.css']
})
export class NewStaffComponent implements OnInit {

  formDetails: boolean[] = [];

  results: any = null;

  conResults: any = {};

  selectedTab: number = 0;


  constructor(private staffApiService: StaffrestApiService) { }

  ngOnInit(): void {
  }

  btnMovement(st: string) {
    if (st === 'bck') {
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

  submit() {

   if (this.formDetails.includes(false)) {
      return;
    }

    this.staffApiService.createStaff(this.conResults).subscribe(_=>{
    });
    
  }

  setTabFormDetails(value: any, tab: number) {

    this.formDetails[tab] = value.valid;

    Object.assign(this.conResults, value.value);
     console.log(this.conResults);

  }

}
