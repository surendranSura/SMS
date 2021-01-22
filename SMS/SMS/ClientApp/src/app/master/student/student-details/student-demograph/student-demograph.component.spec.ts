import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StudentDemographComponent } from './student-demograph.component';

describe('StudentDemographComponent', () => {
  let component: StudentDemographComponent;
  let fixture: ComponentFixture<StudentDemographComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ StudentDemographComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(StudentDemographComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
