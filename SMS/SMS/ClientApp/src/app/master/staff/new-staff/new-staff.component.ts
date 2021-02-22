import { AfterViewInit, Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Staff } from '../Staff';
import { StaffrestApiService } from '../staffrest-api.service';

@Component({
  selector: 'app-new-staff',
  templateUrl: './new-staff.component.html',
  styleUrls: ['./new-staff.component.css']
})
export class NewStaffComponent implements OnInit, AfterViewInit {

  formDetails: boolean[] = [];
  results: any = null;
  conResults: any = {};
  selectedTab: number = 0;
  id?: any;
  _staff?: Staff;
  isAddMode?: boolean;
  loading = false;
  submitted = false;



  constructor(private staffApiService: StaffrestApiService, private route: ActivatedRoute ) { }

  ngAfterViewInit(): void {

    if(!this.isAddMode)
    {
      this.staffApiService.getStaff(this.id)
        .subscribe(data => {
          this._staff = data;
          this.staffApiService.setFormValue(data);
          console.log(this._staff);
        }, error => console.log(error));
    }
    
  }

  ngOnInit(): void {

    this.id = this.route.snapshot.params['id'];
    this.isAddMode = !this.id;
  
    
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

    this.submitted = true;


   if (this.formDetails.includes(false)) {
      return;
    }

    if (this.isAddMode) {
      this.createStaff();
     } else {
      this.updateSatff();
     }
    
  }

  createStaff()
  {
    this.staffApiService.createStaff(this.conResults).subscribe(_=>{
    });
  }

  updateSatff()
  {
    this.staffApiService.updateStaff(this.id, this.conResults).subscribe(_=>{

    });
  }

  setTabFormDetails(value: any, tab: number) {

    this.formDetails[tab] = value.valid;

    Object.assign(this.conResults, value.value);
     console.log(this.conResults);

  }

}
