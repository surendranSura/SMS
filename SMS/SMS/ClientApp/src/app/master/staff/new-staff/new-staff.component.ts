import { AfterViewInit, Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { ActivatedRoute } from '@angular/router';
import { BlockUI, NgBlockUI } from 'ng-block-ui';
import { MessageBoxComponent } from 'src/app/shared/dialog-boxes/message-box/message-box.component';
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

   @BlockUI() blockUI: NgBlockUI;

  constructor(private staffApiService: StaffrestApiService, private route: ActivatedRoute,public dialog: MatDialog) { }

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
    this.blockUI.start();
    this.submitted = true;


   if (this.formDetails.includes(false)) {
       this.blockUI.stop();
      return;
    }

    if (this.isAddMode) {
      this.createStaff();
     } else {
      this.updateSatff();
     }

     this.blockUI.stop();
    
  }

  createStaff()
  {
    this.staffApiService.createStaff(this.conResults).subscribe(_=>{
      this.dialog.open(MessageBoxComponent,{ width: '250px',height:'200px',data:"create"});
      setTimeout(() => {
        this.dialog.closeAll();
      }, 2500);
      

      
    });
  }

  updateSatff()
  {
    this.staffApiService.updateStaff(this.id, this.conResults).subscribe(_=>{
      this.dialog.open(MessageBoxComponent,{ width: '250px',height:'200px',data:"update"});
      setTimeout(() => {
        this.dialog.closeAll();
        //routerlink needs
      }, 2500);
    });
  }

  setTabFormDetails(value: any, tab: number) {

    this.formDetails[tab] = value.valid;

    Object.assign(this.conResults, value.value);
     console.log(this.conResults);

  }

}
