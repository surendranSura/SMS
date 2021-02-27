import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { SmsConstant } from 'src/app/shared/constant-values';

@Component({
  selector: 'app-content-upload',
  templateUrl: './content-upload.component.html',
  styleUrls: ['./content-upload.component.css']
})
export class ContentUploadComponent implements OnInit {

  courseUploadForm: FormGroup;
  ContentType=SmsConstant.contentType
  all_files: File[] = Array();
  uploadContentName: any=null;
  constructor(private fb: FormBuilder) {
    this.courseUploadForm = this.fb.group(
      {
        contentType:[''],
        uploadContent:['']
      }
    )
  }

  ngOnInit(): void {
  }
  Onfilesave(event: any,count:any)
  {
    this.all_files.push(<File>event.target.files[count][0]);
    this.uploadContentName=this.all_files[0].name
  }
}
