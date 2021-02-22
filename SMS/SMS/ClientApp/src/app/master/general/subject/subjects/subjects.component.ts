import { Component, Input,EventEmitter, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-subjects',
  templateUrl: './subjects.component.html',
  styleUrls: ['./subjects.component.css']
})
export class SubjectsComponent implements OnInit {
 @Input() expData:any;
 @Output() btnEvent =new EventEmitter();

 newFlag:boolean=false;
 subjectForm: FormGroup;
  constructor(private fb: FormBuilder) {
    this.subjectForm = this.fb.group({
      subject :"",
    })
   }

  ngOnInit(): void {
    if (Object.keys(this.expData).length != 0) {
      this.subjectForm.disable();
      this.subjectForm.setValue(this.expData);
    }
    else{
      this.newFlag=true;
    }
  }
  save() {
    this.btnEvent.emit();
  }

  delete() {
    if (Object.keys(this.expData).length === 0) {
      this.btnEvent.emit(1);
      return;
    }

    this.btnEvent.emit();
  }

  cancel() {

    this.btnEvent.emit();

  }

}
