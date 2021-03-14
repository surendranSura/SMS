import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { SmsConstant } from 'src/app/shared/constant-values';
import { StaffrestApiService } from '../staffrest-api.service';
import { ActivatedRoute } from '@angular/router';
import { BlockUI, NgBlockUI } from 'ng-block-ui';
import { MessageBoxComponent } from 'src/app/shared/dialog-boxes/message-box/message-box.component';
import { MatDialog } from '@angular/material/dialog';

@Component({
  selector: 'app-e-letter',
  templateUrl: './e-letter.component.html',
  styleUrls: ['./e-letter.component.css']
})
export class ELetterComponent implements OnInit {
  eletterfrm : FormGroup;
  letterTypes = SmsConstant.letterType;
  month = SmsConstant.months;
  years = SmsConstant.year;
  isAddMode?: boolean;
  loading = false;
  submitted = false;
  id?: any;

   @BlockUI() blockUI: NgBlockUI;

  constructor( private fb:FormBuilder, private staffrestApiService :StaffrestApiService, private route: ActivatedRoute, public dialog: MatDialog) {
      this.eletterfrm = this.fb.group({
        empid: ['', Validators.required],
        staffName:['', Validators.required],
        letterType:['',Validators.required],
        department:['', Validators.required],
        month:['', Validators.required],
        teacherId:['',Validators.required],
        year:['', Validators.required]
      });

   }


   ngAfterViewInit(): void {

    if(!this.isAddMode)
    {
      this.staffrestApiService.getStaffeLetter(this.id)
        .subscribe(data => {
          this.eletterfrm.patchValue(data);
        }, error => console.log(error));
    }
    
  }

  ngOnInit(): void {
    this.id = this.route.snapshot.params['id'];
    this.isAddMode = !this.id;
  }

  submit() {
    this.blockUI.start();
    this.submitted = true;

    if (this.isAddMode) {
      this.createStaffeLetter();
     } else {
      this.updateSatffeLetter();
     }

     this.blockUI.stop();
    
  }

  createStaffeLetter()
  {
    this.staffrestApiService.createStaffeLetter(this.eletterfrm.value).subscribe(_=>{
      this.dialog.open(MessageBoxComponent,{ width: '350px',height:'100px',data:"e-Letter created successfully !"});
      setTimeout(() => {
        this.dialog.closeAll();
      }, 2500);  
      
      
    });
  }

  updateSatffeLetter()
  {
    this.staffrestApiService.updateStaffeLetter(this.id, this.eletterfrm.value).subscribe(_=>{
      this.staffrestApiService.createStaffeLetter(this.eletterfrm.value).subscribe(_=>{
        this.dialog.open(MessageBoxComponent,{ width: '350px',height:'100px',data:"e-Letter Updated successfully !"});
        setTimeout(() => {
          this.dialog.closeAll();
        }, 2500);  
        
        
      });
    });
  }

}
