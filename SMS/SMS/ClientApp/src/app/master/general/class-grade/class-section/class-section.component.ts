import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-class-section',
  templateUrl: './class-section.component.html',
  styleUrls: ['./class-section.component.css']
})
export class ClassSectionComponent implements OnInit {

  @Input() expData: any;
  @Output() btnEvent = new EventEmitter();

  newFlag:boolean=false;
  sectionList: string[] = ['A', 'B', 'C', 'D', 'E'];
  subjectList: string[] = ['English', 'Tamil', 'Maths', 'Science', 'Social'];
  csForm: FormGroup;

  constructor(private fb: FormBuilder) {
    this.csForm = this.fb.group({
      class: [''],
      subject: [[]],
      sections: [[]],
      group: [''],
    });

  }

  ngOnInit(): void {
    if (Object.keys(this.expData).length != 0) {
      this.csForm.disable();
      this.csForm.setValue(this.expData);
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
