import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ClassGradeRestApiService } from '../class-grade-rest-api.service';

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

  constructor(private fb: FormBuilder, private classGradeRestApiService :ClassGradeRestApiService) {
    this.csForm = this.fb.group({
      class: [''],
      subjects: [[]],
      sections: [[]],
      group: [''],
      academicYear: ['']
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

    if (Object.keys(this.expData).length != 0)
    {
      this.update();
      return;
    }


    this.classGradeRestApiService.createClassGrade(this.csForm.value).subscribe(_=>{
      this.btnEvent.emit();
    });

  }

  delete() {
    
    if (!this.expData?.subjectDescr) {
      this.btnEvent.emit(1);
      return;
    }
    
    this.classGradeRestApiService.deleteClassGrade(this.expData.class).subscribe(_=>{
      this.btnEvent.emit();
    });

  }

  update()
  {
    this.classGradeRestApiService.updateClassGrade(this.expData.class, this.csForm.value).subscribe(_=>{
      this.btnEvent.emit();
    });

  }

  cancel() {

    this.btnEvent.emit();

  }

  toggleButton()
  {
    this.newFlag = true;
    this.csForm.enable();

    this.btnEvent.emit(2);
  }
}
