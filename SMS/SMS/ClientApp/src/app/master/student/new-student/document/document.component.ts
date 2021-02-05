import { Component, OnInit,Output,EventEmitter } from '@angular/core';
import {FormBuilder, FormControl,FormGroup,Validator} from '@angular/forms';
import {HttpClient, HttpClientModule} from '@angular/common/http';
import { ConstantPool } from '@angular/compiler';
import { SSL_OP_NO_TLSv1_1 } from 'constants';
import { ShowHideDirective } from '@angular/flex-layout';
import { $ } from 'protractor';


@Component({
  selector: 'app-document',
  templateUrl: './document.component.html',
  styleUrls: ['./document.component.css']
})
export class DocumentComponent implements OnInit {
  @Output() stuFormDetails = new EventEmitter();
  documentForm : FormGroup;
  selectedFile: any= null;
  result:any=null;
  t1img:boolean=false;
  bSuccessImages:boolean=false;
  t1fileName:any=null;
  bCertificareName:any =null;
  passportName:any = null;
  aadharName:any=null;
  RationCardName:any =null;
  all_files: File[] = Array();
  
  constructor(private http:HttpClient,private fb :FormBuilder) { 
    this.documentForm =this.fb.group({
     transferCertificate : ['']
		,birthCertificate : ['']
		,passport : ['']
		,aadhar : ['']
		,rationCard : ['']
		,studentVisa : ['']
    });
    this.documentForm.valueChanges.subscribe(()=>{
    this.stuFormDetails.emit({value:this.documentForm,valid:this.documentForm.valid}); 
    })
  }
  onSubmit()
  {
    console.warn(this.documentForm.value);
  }
  Onfilesave(event: any,count:any)
  {
    
    this.all_files.push(<File>event.target.files[count][0]);
    switch(count)
    {
      case 0:
        {
          this.t1img=true;
          this.t1fileName=this.all_files[0].name
        }
        break;
        case 1:
        {
          this.bSuccessImages=true;
          this.bCertificareName=this.all_files[1].name
        }
        break;
        case 2:
        {
          
          this.passportName=this.all_files[2].name
        }
        break;
        case 3:
        {
          
          this.aadharName=this.all_files[3].name
        }
        break;
        case 4:
        {
          
          this.RationCardName=this.all_files[4].name
        }
        break;
    }


    // if(count===0)
    // {
    //   this.t1img=true;
    //   this.t1fileName=this.all_files[count].name
    // }
    // this.all_files.push(event.target.files[count]);
    // this.selectedFile =<File>event.target.files[count];
    // console.log(this.selectedFile.name+" "+this.t1img);
    // this.t1fileName=this.selectedFile.name;

    for (let i = 0; i < this.all_files.length; i++) {
      console.log('File:', this.all_files[i], 'Name:', this.all_files[i].name);
    }
    
  }
  ngOnInit(): void {
  }
  // backTab(index:number)
  // {
    
  // }
  OnUpload()
  {
    const fd= new FormData();
    fd.append('image',this.selectedFile,this.selectedFile.name);
    this.http.post('',fd).subscribe(res=>{
    console.log(res);
    });
  }

}
