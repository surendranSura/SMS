import { AfterViewInit, Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { ActivatedRoute } from '@angular/router';
import { BlockUI, NgBlockUI } from 'ng-block-ui';
import { MessageBoxComponent } from 'src/app/shared/dialog-boxes/message-box/message-box.component';

@Component({
  selector: 'app-add-inventory',
  templateUrl: './add-inventory.component.html',
  styleUrls: ['./add-inventory.component.css']
})
export class AddInventoryComponent implements OnInit {

  stuFormtDetails: boolean[] =[]
  results : any =null;
  stuJsonResult: any ={};
  selectedTab:any=0;
  isAddMode?: boolean;
//  _student : Student;
  id : any;

  @BlockUI() blockUI: NgBlockUI;
  
  constructor(private route: ActivatedRoute, public dialog: MatDialog) { }

  // ngAfterViewInit(): void {

  //   if(!this.isAddMode)
  //   {
  //     this.studentApiService.getStudent(this.id)
  //       .subscribe(data => {
  //         this._student = data;
  //         this.studentApiService.setFormValue(data);
  //         console.log(this._student);
  //       }, error => console.log(error));
  //   }
    
  // }
  

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

  submit(){

    this.blockUI.start();
    // this.submitted = true;


   if (this.stuFormtDetails.includes(false)) {
       this.blockUI.stop();
      return;
    }

    if (this.isAddMode) {
      this.createStudent();
     } else {
      this.updateStudent();
     }

     this.blockUI.stop();

    // if(!this.stuFormtDetails.includes(false)){
    //   return;
    // }
    
  }

  createStudent()
  {
    // this.studentApiService.createStudent(this.stuJsonResult).subscribe(_=>{
    //   this.dialog.open(MessageBoxComponent,{ width: '350px',height:'100px',data:"student feedback updated successfully !"});
    //   setTimeout(() => {
    //     this.dialog.closeAll();
    //   }, 2500);
    // });
  }

  updateStudent()
  {
    // this.studentApiService.updateStudent(this.id, this.stuJsonResult).subscribe(_=>{

    // });
  }
  
  setTabFormDetails(value: any,tab:number){
    this.stuFormtDetails[tab] = value.valid;
    Object.assign(this.stuJsonResult,value.value);
    console.log(value.value);
  }


}

